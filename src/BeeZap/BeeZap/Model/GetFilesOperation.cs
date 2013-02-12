using System;
using System.Collections.Generic;

namespace Beeline.BeeZap.Model
{
	public class GetFilesOperation : OperationBase<IEnumerable<IFileInfo>>
	{
		private readonly IFileSystem _fileSystem;
		private readonly String _path;
		private readonly String _searchPattern;
		private readonly Boolean _includeSubDirectories;

		public GetFilesOperation(IFileSystem fileSystem, String path, String searchPattern, Boolean includeSubDirectories)
		{
			_fileSystem = fileSystem;
			_path = path;
			_searchPattern = searchPattern;
			_includeSubDirectories = includeSubDirectories;
		}

		protected override IEnumerable<IFileInfo> ExecuteImp(IEnumerable<IFileInfo> input)
		{
			return _fileSystem.EnumerateFileInfo(_path, _searchPattern, _includeSubDirectories);
		}
	}
}