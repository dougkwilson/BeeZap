using System;
using System.IO;
using System.Text;

namespace Beeline.BeeZap.Model
{
	public class FileInfoWrapper : IFileInfo
	{
		private readonly IFileSystem _fileSystem;
		private readonly FileInfo _fileInfo;
		private readonly String _rootPath;
		private String _content;
		private Boolean _hasChanged;
		private Encoding _encoding;

		public FileInfoWrapper(IFileSystem fileSystem, FileInfo fileInfo, String rootPath)
		{
			_fileInfo = fileInfo;
			_rootPath = rootPath;
			_fileSystem = fileSystem;
		}

		public String Name
		{
			get { return _fileInfo.Name; }
		}

		public Int64 Length
		{
			get { return _fileInfo.Length; }
		}

		public String DirectoryName
		{
			get { return _fileInfo.DirectoryName; }
		}

		public String RootPath
		{
			get { return String.IsNullOrWhiteSpace(_rootPath) ? _fileInfo.DirectoryName : _rootPath; }
		}

		public String ChildPath
		{
			get { return String.IsNullOrEmpty(_rootPath) ? _fileInfo.Name : _fileInfo.FullName.Replace(_rootPath, String.Empty); }
		}

		public String FullName
		{
			get { return _fileInfo.FullName; }
		}

		public String Extension
		{
			get { return _fileInfo.Extension; }
		}

		public Encoding Encoding
		{
			get { return _encoding ?? (_encoding = _fileSystem.GetEncoding(this)); }
		}

		public bool IsReadOnly { get { return (_fileInfo.Attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly; } }
		
		public bool IsHidden { get { return (_fileInfo.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden; } }

		public void SetContent(String value)
		{
			if (value == null)
			{
				throw new ArgumentNullException();
			}

			if (IsReadOnly)
			{
				Status = FileStatus.Error;
				StatusText = "is Read Only.";
			}
			else
			{
				_content = value;
				_hasChanged = true;
			}
		}

		public String GetContent()
		{
			if (String.IsNullOrEmpty(_content))
			{
				try
				{
					_content = _fileSystem.ReadAllText(this);
					_hasChanged = false;
					Status = FileStatus.Ok;
				}
				catch (IOException ex)
				{
					Status = FileStatus.Error;
					StatusText = ex.Message;
				}
			}
			return _content;
		}

		public FileStatus Status { get; private set; }

		public Boolean HasChanged
		{
			get { return _hasChanged; }
		}

		public String StatusText { get; set; }

		public void SaveChanges()
		{
			if (!_hasChanged)
				throw new InvalidOperationException("The file has not been changed since it was last opened.");

			_fileSystem.WriteFileContent(this, _content);
		}

		public void Release()
		{
			_content = null;
			_hasChanged = false;
		}

		public override String ToString()
		{
			return ChildPath;
		}
	}

	public enum FileStatus
	{
		Ok,
		Error
	}
}