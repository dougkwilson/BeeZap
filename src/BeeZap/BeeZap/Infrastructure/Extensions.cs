using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Beeline.BeeZap.Infrastructure
{
	public static class Extensions
	{
		public static String NullTrim(this String s)
		{
			return String.IsNullOrEmpty(s) ? String.Empty : s.Trim();
		}

		public static FormCursor BeginBackgroundOperation(this IView view)
		{
			return BeginOperation(view, Cursors.AppStarting);
		}

		public static FormCursor BeginLongOperation(this IView view)
		{
			return BeginOperation(view, Cursors.WaitCursor);
		}

		private static FormCursor BeginOperation(this IView view, Cursor cursor)
		{
			FormCursor formCursor = new FormCursor(view);

			view.UiThread(() => view.Cursor = cursor);

			return formCursor;
		}

		static public void UiThread(this ISynchronizeInvoke control, Action action)
		{
			if (control.InvokeRequired) {
				control.BeginInvoke(action, null);
			}
			else {
				action.Invoke();
			}
		}

		static public void UiThread(this Control control, Action action)
		{
			if (control.InvokeRequired) {
				control.BeginInvoke(action);
			}
			else {
				action.Invoke();
			}
		}
	}
}
