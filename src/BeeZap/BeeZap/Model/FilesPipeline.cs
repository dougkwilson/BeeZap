using System;
using System.Collections.Generic;

namespace Beeline.BeeZap.Model
{
	public class FilesPipeline : Pipeline<IEnumerable<IFileInfo>>
	{
		public FilesPipeline(IFileSystem fileSystem, String path, String pattern, Boolean includeSubDirectories)
		{
			Register(new GetFilesOperation(fileSystem, path, pattern, includeSubDirectories));
		}
	}
}