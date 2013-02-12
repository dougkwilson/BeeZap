using System;
using System.Text.RegularExpressions;

namespace Beeline.BeeZap.Model
{
	public class Parameters
	{

		public String Path { get; set; }
		public Boolean IncludeSubDirectories { get; set; }
		public String Pattern { get; set; }
		public String FullNameIncludePattern { get; set; }
		public String FullNameExcludePattern { get; set; }
		public String FileContentIncludePattern { get; set; }
		public Int32 FileContentIncludeMinLine { get; set; }
		public Int32 FileContentIncludeMaxLine { get; set; }
		public String FileContentExcludePattern { get; set; }
		public Int32 FileContentExcludeMinLine { get; set; }
		public Int32 FileContentExcludeMaxLine { get; set; }
		public String FindPattern { get; set; }
		public Boolean IsRegex { get; set; }
		public Boolean ExplicitCapture { get; set; }
		public Boolean IgnoreCase { get; set; }
		public Boolean Singleline { get; set; }
		public Boolean Multiline { get; set; }
		public String ReplacePattern { get; set; }
		public Boolean LiteralReplacement { get; set; }

		public RegexOptions GetRegexOptions()
		{
			RegexOptions options = RegexOptions.None;
			if (ExplicitCapture)
				options |= RegexOptions.ExplicitCapture;
			if (IgnoreCase)
				options |= RegexOptions.IgnoreCase;
			if (Multiline)
				options |= RegexOptions.Multiline;
			if (Singleline)
				options |= RegexOptions.Singleline;

			return options;
		}
	}
}