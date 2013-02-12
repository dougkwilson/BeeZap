using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Beeline.BeeZap.Model
{
	public class FullNameMatchesRegex : OperationBase<IEnumerable<IFileInfo>>
	{
		private readonly Regex _regex;

		public FullNameMatchesRegex(Regex regex)
		{
			_regex = regex;
		}

		protected override IEnumerable<IFileInfo> ExecuteImp(IEnumerable<IFileInfo> input)
		{
			return input.Where(fileInfo => _regex.IsMatch(fileInfo.FullName));
		}
	}
}