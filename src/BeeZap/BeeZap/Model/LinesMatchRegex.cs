using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Beeline.BeeZap.Model
{
	public class LinesMatchRegex : OperationBase<IEnumerable<IFileInfo>>
	{
		private readonly Int32 _maxLine;
		private readonly Int32 _minLine;
		private readonly Regex _regex;

		public LinesMatchRegex(Regex regex, Int32 minLine, Int32 maxLine)
		{
			_regex = regex;
			_minLine = minLine;
			_maxLine = maxLine;
		}

		protected override IEnumerable<IFileInfo> ExecuteImp(IEnumerable<IFileInfo> input)
		{
			foreach (IFileInfo fileInfo in input)
			{
				String content = fileInfo.GetContent();
				if (fileInfo.Status == FileStatus.Error)
				{
					yield return fileInfo;
				}
				else
				{
					Int32 matchingLines = 0;
					var log = new StringBuilder();
					using (var reader = new StringReader(content))
					{
						Int32 lineCount = 0;
						String line = reader.ReadLine();
						while (line != null)
						{
							lineCount++;
							if (_regex.IsMatch(line) && (_minLine == 0 || lineCount > _minLine) && (_maxLine == 0 || lineCount < _maxLine))
							{
								log.AppendLine("\tLine " + lineCount + ": " + line.Trim());
								matchingLines++;
							}
							line = reader.ReadLine();
						}
					}
					if (matchingLines > 0)
					{
						fileInfo.StatusText = "Matching Lines: " + matchingLines + Environment.NewLine + log;
						yield return fileInfo;
					}
				}
			}
		}
	}
}
