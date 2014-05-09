using System;

namespace Beeline.BeeZap.Model
{
	public interface IPreferences
	{
		String TextEditorPath { get; }
		String TextEditorArguments { get; }
		String OutputEncoding { get; }
	}

	public class Preferences : IPreferences
	{
		public string TextEditorPath { get; set; }
		public string TextEditorArguments { get; set; }
		public string OutputEncoding { get; set; }
	}

}
