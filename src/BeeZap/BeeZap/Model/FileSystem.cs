using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace Beeline.BeeZap.Model
{
	public class FileSystem : IFileSystem
	{
		private readonly IPreferences _preferences;

		private class UndoEntry
		{
			public UndoEntry(String backupFileName, String originalFileName, FileAttributes originalAttributes)
			{
				BackupFileName = backupFileName;
				OriginalFileName = originalFileName;
				OriginalAttributes = originalAttributes;
			}

			public String BackupFileName { get; private set; }
			public String OriginalFileName { get; private set; }
			public FileAttributes OriginalAttributes { get; private set; }
		}

		private readonly Stack<UndoEntry> _undo = new Stack<UndoEntry>();

		public FileSystem(IPreferences preferences)
		{
			_preferences = preferences;
		}

		public String ReadAllText(IFileInfo fileInfo)
		{
			return File.ReadAllText(fileInfo.FullName, fileInfo.Encoding);
		}

		public void WriteFileContent(IFileInfo fileInfo, String content)
		{
			Backup(fileInfo);

			if (File.Exists(fileInfo.FullName))
				throw new ApplicationException(String.Format("Failed to backup the original file: {0}", fileInfo.FullName));

			using (StreamWriter streamWriter = new StreamWriter(fileInfo.FullName, false, fileInfo.Encoding))
			{
				streamWriter.Write(content);
			}
		}

		private void Backup(IFileInfo fileInfo)
		{
			Int32 counter = 0;
			do
			{
				String backupFileName = Path.Combine(fileInfo.DirectoryName, String.Format("{0}-{1:00}{2}", Path.GetFileNameWithoutExtension(fileInfo.Name), counter, fileInfo.Extension));
				if (File.Exists(backupFileName))
					continue;

				FileAttributes attributes = File.GetAttributes(fileInfo.FullName);
		
				File.Move(fileInfo.FullName, backupFileName);
				
				File.SetAttributes(backupFileName, FileAttributes.Hidden | FileAttributes.ReadOnly);

				_undo.Push(new UndoEntry(backupFileName, fileInfo.FullName, attributes));

				break;
			} while (++counter < 100);
		}

		public void Commit()
		{
			while (_undo.Count > 0)
			{
				UndoEntry entry = _undo.Pop();
				if (File.Exists(entry.BackupFileName))
				{
					File.SetAttributes(entry.BackupFileName, FileAttributes.Normal);
					File.Delete(entry.BackupFileName);
				}
			}
		}

		public bool Exists(String path)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}

			if (String.IsNullOrWhiteSpace(path))
			{
				throw new ArgumentException("Path is required.", "path");
			}

			return Directory.Exists(path) || File.Exists(path);
		}

		public Boolean OpenInEditor(String path, String lineNumber, String column)
		{
			if (Exists(_preferences.TextEditorPath))
			{
				String arguments = _preferences.TextEditorArguments.Replace("{path}", path).Replace("{line}", lineNumber).Replace("{col}", column);
				if (_preferences.TextEditorPath.IndexOf("textpad.exe", StringComparison.InvariantCultureIgnoreCase) > -1)
					arguments = arguments.Replace("(,)", "").Replace(",)", ")");

				ProcessStartInfo info = new ProcessStartInfo(_preferences.TextEditorPath, arguments.Trim());
				try
				{
					Process.Start(info);
					return true;
				}
				// ReSharper disable EmptyGeneralCatchClause
				catch (Exception ex)
				{
					// We're good with doing nothing here since opening the text editor is a convenience feature.  The inability to open it shouldn't crash/halt operations.
					Debug.WriteLine(ex.Message);
				}
				// ReSharper restore EmptyGeneralCatchClause
			}

			return false;
		}

		public Encoding GetEncoding(IFileInfo fileInfoWrapper)
		{
			using (StreamReader sr = new StreamReader(fileInfoWrapper.FullName, true)) {
				sr.ReadLine();
				return sr.CurrentEncoding;
			}
		}

		public bool CanUndo()
		{
			return _undo.Count > 0;
		}

		public Int32 GetPendingUndoCount() { return _undo.Count; }

		public IEnumerable<UndoResult> Undo(Boolean haltOnError) {

			List<UndoResult> results = new List<UndoResult>();

			while (_undo.Count > 0)
			{
				UndoEntry entry = _undo.Pop();

				if (File.Exists(entry.BackupFileName)) {
					if (File.Exists(entry.OriginalFileName))
						File.Delete(entry.OriginalFileName);

					File.Move(entry.BackupFileName, entry.OriginalFileName);
					File.SetAttributes(entry.OriginalFileName, entry.OriginalAttributes);

					results.Add(new UndoResult(false, "", entry.OriginalFileName, entry.BackupFileName));
				} else {
					results.Add(new UndoResult(true, "The backup file was missing. Undo halted.", entry.OriginalFileName, entry.BackupFileName));

					if (haltOnError) {
						_undo.Push(entry);
						return results;
					}
				}
			}

			return results;
		}

		public IEnumerable<IFileInfo> EnumerateFileInfo(String path, String searchpattern, Boolean includeSubDirectories)
		{
			SearchOption option = includeSubDirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;

			return Directory.EnumerateFiles(path, searchpattern, option).Where(fi => _undo.All(u => u.BackupFileName != fi)).Select(s => new FileInfoWrapper(this, new FileInfo(s), path));
		}

		public IFileInfo GetFileInfo(String filename)
		{
			return new FileInfoWrapper(this, new FileInfo(filename), null);
		}
	}
}
