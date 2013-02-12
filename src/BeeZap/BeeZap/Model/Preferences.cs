using System;
using System.Text;

namespace Beeline.BeeZap.Model
{
	public interface IPreferences {
		Encoding Encoding { get; }
		String TextEditorPath { get; }
		String TextEditorArguments { get; }
	}

	public class Preferences : IPreferences
	{
		public Encoding Encoding { get { return Encoding.UTF8; } }
		public string TextEditorPath { get; set; }
		public string TextEditorArguments { get; set; }
	}

}
