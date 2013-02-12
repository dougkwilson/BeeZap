using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Beeline.BeeZap.Model
{
	public class ContentMatchesRegexReplace : OperationBase<IEnumerable<IFileInfo>>
	{
		private readonly Regex _findRegex;
		private readonly String _replace;
		private readonly bool _replaceIsLiteral;

		public ContentMatchesRegexReplace(Regex findRegex, String replace, Boolean replaceIsLiteral)
		{
			_findRegex = findRegex;
			_replace = replace;
			_replaceIsLiteral = replaceIsLiteral;
		}

		protected override IEnumerable<IFileInfo> ExecuteImp(IEnumerable<IFileInfo> input)
		{
			foreach (var fileInfo in input)
			{
				String content = fileInfo.GetContent();
				if (fileInfo.Status == FileStatus.Error) {
					yield return fileInfo;					
				} else {
					MatchCollection matches = _findRegex.Matches(content);
					if (matches.Count > 0) {
						StringBuilder log = new StringBuilder(matches.Count + " replaced:" + Environment.NewLine);
						foreach (Match match in matches) {
							log.AppendFormat("\tPos {0}+{1}: {2}\n", match.Index, match.Length, match.Value);
						}
						fileInfo.StatusText = log.ToString();
						fileInfo.SetContent(_findRegex.Replace(content, _replace));
						yield return fileInfo;
					}
				}
			}
		}
	}
}