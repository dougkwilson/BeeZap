using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Beeline.BeeZap.Infrastructure;
using Beeline.BeeZap.Model;
using Beeline.BeeZap.Properties;
using NLog;

namespace Beeline.BeeZap
{
	public class MainPresenter
	{
		private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
		private readonly IFileSystem _fileSystem;
		private IMainView _mainView;
		private Boolean _stopRequested;

		public MainPresenter(IFileSystem fileSystem) {
			if (fileSystem == null) {
				throw new ArgumentNullException("fileSystem");
			}
			_fileSystem = fileSystem;
		}

		public int BackupCount { get { return _fileSystem.GetPendingUndoCount(); } }

		public void Register(IMainView mainView) {
			if (mainView == null) {
				throw new ArgumentNullException("mainView");
			}

			_mainView = mainView;
		}

		public void Loading() {
			_mainView.UpdateControlStates();
			_mainView.UpdateBackupCount();
		}

		private void Log(Object obj) {
			Log(obj.ToString());	
		}

		private void Log(String message) {
			Logger.Info(message);
			_mainView.UiThread(() => _mainView.AppendToLog(message + Environment.NewLine));
		}

		public String ChoosePath() {
			using (var dialog = new FolderBrowserDialog {
				ShowNewFolderButton = false,
				RootFolder = Environment.SpecialFolder.MyComputer
			}) {
				DialogResult result = dialog.ShowDialog(_mainView);
				if (result == DialogResult.OK) {
					return dialog.SelectedPath;
				}
			}

			return String.Empty;
		}

		public void ViewFiles() {
			Parameters parameters = _mainView.ReadParameters();
			Log(String.Format("Executing View Files:{0}{1}", Environment.NewLine, parameters));

			if (ParametersAreValid(parameters)) {
				Pipeline<IEnumerable<IFileInfo>> pipeline = new ViewFileInfoPipelineFactory(_fileSystem, parameters).Create();
				ExecutePipeline(pipeline);
			}
		}

		public void ViewMatches() {
			Parameters parameters = _mainView.ReadParameters();
			Log(String.Format("Executing View Matches:{0}{1}", Environment.NewLine, parameters));

			if (ParametersAreValid(parameters)) {
				Pipeline<IEnumerable<IFileInfo>> pipeline = new ViewMatchesPipelineFactory(_fileSystem, parameters).Create();
				ExecutePipeline(pipeline);
			}
		}

		public void Replace() {
			Parameters parameters = _mainView.ReadParameters();
			Log(String.Format("Executing Find/Replace:{0}{1}", Environment.NewLine, parameters));

			if (ParametersAreValid(parameters)) {
				Pipeline<IEnumerable<IFileInfo>> pipeline = new FindReplacePipelineFactory(_fileSystem, parameters).Create();
				ExecutePipeline(pipeline);
			}
		}

		private bool ParametersAreValid(Parameters parameters) {
			if (!_fileSystem.Exists(parameters.Path)) {
				MessageBox.Show(_mainView, "The path does not exist.", "Hey! Pay attention!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}

			return true;
		}

		private void ExecutePipeline(Pipeline<IEnumerable<IFileInfo>> pipeline) {
			var thread = new Thread(() => ExecutePipelineThreadProc(pipeline)) {
				IsBackground = true,
				Name = "ExecutePipeline"
			};
			thread.Start();
		}

		private void ExecutePipelineThreadProc(Pipeline<IEnumerable<IFileInfo>> pipeline) {
			Stopwatch sw = Stopwatch.StartNew();
			Log("Started at " + SystemTime.Local());
			var log = new StringBuilder();
			var errors = new StringBuilder();
			try {
				_stopRequested = false;
				_mainView.BeginCancelableOperation();

				Int32 counter = 0;
				foreach (IFileInfo fileInfo in pipeline.Execute(null)) {
					if (fileInfo.Status == FileStatus.Error) {
						errors.AppendLine(String.Format("{0} {1}", fileInfo.FullName, fileInfo.StatusText));
					} else {
						if (fileInfo.HasChanged) {
							fileInfo.SaveChanges();
						}
						log.AppendLine(String.Format("{0,6}\t{1}\t{2}", ++counter, fileInfo.FullName, fileInfo.StatusText.NullTrim()));
					}

					fileInfo.Release();

					if (_stopRequested) {
						log.AppendLine("Stop Requested");
						break;
					}
				}
				sw.Stop();
			}
			finally {
				_mainView.EndCancelableOperation();
				Log(log.ToString());
				if (errors.Length > 0) {
					Log("The following errors were encountered: ");
					Log(errors.ToString());
				}
			}
			if (_stopRequested) {
				Log("Cancelled at " + SystemTime.Local() + "  Duration: " + sw.Elapsed);
			} else {
				Log("Stopped at " + SystemTime.Local() + "  Duration: " + sw.Elapsed);
			}

			_mainView.UpdateBackupCount();
		}

		public void Undo() {

			if (ExecuteUndo(true)) {
				DialogResult result = MessageBox.Show(_mainView, Resources.UndoChangesFailedText, Resources.UndoChangesFailedCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes) {
					ExecuteUndo(false);
				}
			}

		}

		private Boolean ExecuteUndo(Boolean haltOnError) {
			Boolean errorOccurred = false;
			using (_mainView.BeginLongOperation()) {
				foreach (UndoResult result in _fileSystem.Undo(haltOnError)) {
					Log(result);
					if (result.Failed) {
						errorOccurred = true;
					}
				}
			}
			_mainView.UpdateBackupCount();
			return errorOccurred;
		}

		public void DeleteBackups() {
			DialogResult result = MessageBox.Show(_mainView, Resources.DeleteBackupConfirmationText, Resources.DeleteBackupsConfirmationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes) {
				using (_mainView.BeginLongOperation()) {
					_fileSystem.Commit();
					_mainView.UpdateBackupCount();
				}
			}
		}

		public void ClearLog() {
			_mainView.ClearLog();
		}

		public void Stop() {
			_stopRequested = true;
			if (_fileSystem.CanUndo()) {
				MessageBox.Show(_mainView, "Files may have been modified before the operation was cancelled.", "Files Were Modified", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		public void Quit() {
			if (_fileSystem.CanUndo()) {
				DialogResult result = MessageBox.Show(_mainView, "Delete all the backup files before closing?", "Delete Backups?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes) {
					using (_mainView.BeginLongOperation()) {
						_fileSystem.Commit();
					}
				}
			}
		}

		public void LogEntrySelected(IList<String> lines) {
			Int32 left = lines[0].IndexOf('\t', 1) + 1;
			if (left <= 0) {
				return;
			}

			Int32 right = lines[0].IndexOf('\t', left);
			if (right <= 0) {
				return;
			}

			String path = lines[0].Substring(left, right - left);

			String lineNumber = lines.Count > 1 ? Regex.Match(lines[1], @"Line\W+(?<Line>[0-9]+):", RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture).Groups["Line"].Value : String.Empty;

			Debug.WriteLine("Line: " + lineNumber);

			if (!_fileSystem.Exists(path)) {
				return;
			}

			String column = String.IsNullOrWhiteSpace(lineNumber) ? String.Empty : "0";

			if (!_fileSystem.OpenInEditor(path, lineNumber, column)) {
				MessageBox.Show(_mainView, Resources.OpenInEditorFailedText, Resources.OpenInEditorFailedCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
	}
}
