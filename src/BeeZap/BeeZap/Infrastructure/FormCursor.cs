using System;
using System.Windows.Forms;

namespace Beeline.BeeZap.Infrastructure
{
	public sealed class FormCursor : IDisposable
	{
		private bool _disposed;
		private readonly IView _view;
		private readonly Cursor _originalCursor;

		public FormCursor(IView view)
		{
			if (view == null) {
				throw new ArgumentNullException("view");
			}

			_view = view;
			_originalCursor = _view.Cursor;
		}

		public void Dispose()
		{
			Dispose(true /* disposing */);
			GC.SuppressFinalize(this);
		}

		private void Dispose(bool disposing)
		{
			if (_disposed) {
				return;
			}

			if (disposing) {
					
			}

			// output client validation and restore the original form context
			if (_view != null) {
				_view.UiThread(() => _view.Cursor = _originalCursor);
				_view.UiThread(() => _view.UpdateControlStates());
			}

			_disposed = true;
		}

		~FormCursor()
		{
			Dispose(false);
		}

	}
}