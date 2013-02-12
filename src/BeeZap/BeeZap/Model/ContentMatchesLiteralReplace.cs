using System;
using System.Collections.Generic;

namespace Beeline.BeeZap.Model
{
	public class ContentMatchesLiteralReplace : OperationBase<IEnumerable<IFileInfo>>
	{
		private readonly String _find;
		private readonly String _replace;

		public ContentMatchesLiteralReplace(String find, String replace)
		{
			_find = find;
			_replace = replace;
		}

		protected override IEnumerable<IFileInfo> ExecuteImp(IEnumerable<IFileInfo> input)
		{
			foreach (var fileInfo in input)
			{
				String content = fileInfo.GetContent();
				if (content != null) {
					var indexOf = content.IndexOf(_find, StringComparison.Ordinal);
					if (indexOf <= -1)
					{
						continue;
					}

					if (indexOf < content.Length)
					{
						var left = content.LastIndexOf(Environment.NewLine, indexOf, indexOf, StringComparison.InvariantCultureIgnoreCase);
						var right = content.IndexOf(Environment.NewLine, indexOf + 1, StringComparison.InvariantCultureIgnoreCase);
						var length = right - left;
					}

					fileInfo.SetContent(content.Replace(_find, _replace));
				}
				yield return fileInfo;
			}
		}
	}
}