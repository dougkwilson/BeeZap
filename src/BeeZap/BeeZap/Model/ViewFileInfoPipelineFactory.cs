using System;
using System.Text.RegularExpressions;

namespace Beeline.BeeZap.Model
{
	public class ViewFileInfoPipelineFactory : FileInfoPipelineFactory
	{
		public ViewFileInfoPipelineFactory(IFileSystem filesystem, Parameters parameters)
			: base(filesystem, parameters)
		{
			if (!String.IsNullOrWhiteSpace(parameters.FullNameIncludePattern)) {
				Pipeline.Register(new FullNameMatchesRegex(new Regex(parameters.FullNameIncludePattern, RegexOptions.IgnoreCase)));
			}

			if (!String.IsNullOrWhiteSpace(parameters.FullNameExcludePattern)) {
				Pipeline.Register(new FullNameDoesNotMatchRegex(new Regex(parameters.FullNameExcludePattern, RegexOptions.IgnoreCase)));
			}

			if (!String.IsNullOrWhiteSpace(parameters.FileContentIncludePattern)) {
				Pipeline.Register(new LinesMatchRegex(new Regex(parameters.FileContentIncludePattern, RegexOptions.IgnoreCase), parameters.FileContentIncludeMinLine, parameters.FileContentIncludeMaxLine));
			}

			if (!String.IsNullOrWhiteSpace(parameters.FileContentExcludePattern)) {
				Pipeline.Register(new LinesDoNotMatchRegex(new Regex(parameters.FileContentExcludePattern, RegexOptions.IgnoreCase), parameters.FileContentExcludeMinLine, parameters.FileContentExcludeMaxLine));
			}

		}
	}
}