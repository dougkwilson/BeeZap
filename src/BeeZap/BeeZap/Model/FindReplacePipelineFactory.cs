using System;
using System.Text.RegularExpressions;

namespace Beeline.BeeZap.Model
{
	public class FindReplacePipelineFactory : ViewFileInfoPipelineFactory
	{
		public FindReplacePipelineFactory(IFileSystem filesystem, Parameters parameters)
			: base(filesystem, parameters)
		{
			if (String.IsNullOrWhiteSpace(parameters.FindPattern)) {
				throw new ArgumentException("The \"Text to Find\" is required.");
			}

			if (parameters.IsRegex) {
				Pipeline.Register(new ContentMatchesRegexReplace(new Regex(parameters.FindPattern, parameters.GetRegexOptions()), parameters.ReplacePattern, parameters.LiteralReplacement));
			}
			else {
				Pipeline.Register(new ContentMatchesRegexReplace(new Regex(Regex.Escape(parameters.FindPattern), parameters.GetRegexOptions()), parameters.ReplacePattern, parameters.LiteralReplacement));
			}
		}
	}
}
