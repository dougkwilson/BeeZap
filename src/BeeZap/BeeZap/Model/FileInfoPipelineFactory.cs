using System.Collections.Generic;

namespace Beeline.BeeZap.Model
{
	public abstract class FileInfoPipelineFactory : IPipelineFactory
	{
		protected readonly IFileSystem Filesystem;
		private readonly Parameters _parameters;
		protected readonly FilesPipeline Pipeline;

		protected FileInfoPipelineFactory(IFileSystem filesystem, Parameters parameters)
		{
			Filesystem = filesystem;
			_parameters = parameters;
			Pipeline = new FilesPipeline(Filesystem, _parameters.Path, _parameters.Pattern, _parameters.IncludeSubDirectories);
		}

		public Pipeline<IEnumerable<IFileInfo>> Create()
		{
			return Pipeline;
		}
	}
}