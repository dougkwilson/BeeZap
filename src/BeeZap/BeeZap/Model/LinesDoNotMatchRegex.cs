using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Beeline.BeeZap.Model
{
	public class LinesDoNotMatchRegex : OperationBase<IEnumerable<IFileInfo>>
	{
		private readonly Regex _excludeContent;
		private readonly Int32 _minLine;
		private readonly Int32 _maxLine;

		public LinesDoNotMatchRegex(Regex excludeContent, Int32 minLine, Int32 maxLine)
		{
			_excludeContent = excludeContent;
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
					Boolean matchFound = false;
					using (StringReader reader = new StringReader(content))
					{
						Int32 lineCount = 0;
						String line = reader.ReadLine();
						while (line != null)
						{
							lineCount++;
							if (_excludeContent.IsMatch(line) && (_minLine == 0 || lineCount > _minLine) && (_maxLine == 0 || lineCount < _maxLine))
							{
								matchFound = true;
								break;
							}
							line = reader.ReadLine();
						}
					}
					if (!matchFound) {
						fileInfo.StatusText = String.Empty;
						yield return fileInfo;						
					}
				}

			}
		}
	}
}