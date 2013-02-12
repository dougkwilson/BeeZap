using System;
using System.Text.RegularExpressions;

namespace Beeline.BeeZap.Model
{
	public class ViewMatchesPipelineFactory : ViewFileInfoPipelineFactory
	{
		public ViewMatchesPipelineFactory(IFileSystem filesystem, Parameters matchesInfo)
			: base(filesystem, matchesInfo)
		{
			if (String.IsNullOrWhiteSpace(matchesInfo.FindPattern)) {
				throw new ArgumentException("The \"Text to Find\" is required.");
			}

			if (matchesInfo.IsRegex) {
				Pipeline.Register(new ContentMatchesRegex(new Regex(matchesInfo.FindPattern, matchesInfo.GetRegexOptions())));
			}
			else {
				Pipeline.Register(new ContentMatchesRegex(new Regex(Regex.Escape(matchesInfo.FindPattern), matchesInfo.GetRegexOptions())));
			}
		}
	}
}