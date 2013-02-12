using System.ComponentModel;
using System.Windows.Forms;

namespace Beeline.BeeZap.Infrastructure
{
	public interface IView : IWin32Window, ISynchronizeInvoke
	{
		void Show();
		void Hide();
		void Close();

		Cursor Cursor { get; set; }
		void UpdateControlStates();
	}
}