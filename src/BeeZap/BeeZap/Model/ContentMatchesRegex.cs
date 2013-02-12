using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Beeline.BeeZap.Model
{
	public class ContentMatchesRegex : OperationBase<IEnumerable<IFileInfo>>
	{
		private readonly Regex _find;

		public ContentMatchesRegex(Regex find)
		{
			_find = find;
		}

		protected override IEnumerable<IFileInfo> ExecuteImp(IEnumerable<IFileInfo> input)
		{
			foreach (IFileInfo fileInfo in input)
			{
				String content = fileInfo.GetContent();
				if (content == null)
				{
					yield return fileInfo;
				}
				else
				{
					MatchCollection matches = _find.Matches(content);
					if (matches.Count > 0) {
						StringBuilder log = new StringBuilder(matches.Count + " matches:" + Environment.NewLine);
						foreach (Match match in matches)
						{
							log.AppendFormat("\tPos {0}+{1}: {2}{3}", match.Index, match.Length, match.Value, Environment.NewLine);
						}
						fileInfo.StatusText = log.ToString();
						yield return fileInfo;
					}
				}
			}
		}
	}
}