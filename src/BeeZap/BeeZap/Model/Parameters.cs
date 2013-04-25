using System;
using System.Text;
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

		public override string ToString()
		{
			StringBuilder b = new StringBuilder();

			b.AppendFormat("Path: {0}\tInclude Subdirectories: {1}\tPattern: {2}{3}", Path, IncludeSubDirectories, Pattern, Environment.NewLine);
			if (!String.IsNullOrWhiteSpace(FullNameIncludePattern))
				b.AppendFormat("File Name Regex Include: {0}{1}", FullNameIncludePattern, Environment.NewLine);
			if (!String.IsNullOrWhiteSpace(FullNameExcludePattern))
				b.AppendFormat("File Name Regex Exclude: {0}{1}", FullNameExcludePattern, Environment.NewLine);

			if (!String.IsNullOrWhiteSpace(FileContentIncludePattern))
				b.AppendFormat("File Contents Regex Include: {0}\tBetween: {1} and {2}{3}", FileContentIncludePattern, FileContentIncludeMinLine, FileContentIncludeMaxLine, Environment.NewLine);
			if (!String.IsNullOrWhiteSpace(FileContentExcludePattern))
				b.AppendFormat("File Contents Regex Exclude: {0}\tBetween: {1} and {2}{3}", FileContentExcludePattern, FileContentExcludeMinLine, FileContentExcludeMaxLine, Environment.NewLine);

			if (!String.IsNullOrWhiteSpace(FindPattern)) {
				if (IsRegex) {
					b.AppendFormat("Find Pattern - Explicit Capture: {0}\tIgnore Case: {1}\tSingleline: {2}\tMultiline: {3}{4}", ExplicitCapture, IgnoreCase, Singleline, Multiline, Environment.NewLine);
				} else {
					b.AppendLine("Find Text:");
				}
				b.AppendLine(FindPattern);
				b.AppendFormat("Replace With:{1}{0}{1}", ReplacePattern, Environment.NewLine);
			}

			return b.ToString();
		}
	}
}