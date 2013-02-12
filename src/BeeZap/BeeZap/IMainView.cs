using System;
using Beeline.BeeZap.Infrastructure;
using Beeline.BeeZap.Model;

namespace Beeline.BeeZap
{
	public interface IMainView : IView {
		void AppendToLog(String message);
		void ClearLog();

		Parameters ReadParameters();

		void BeginCancelableOperation();
		void EndCancelableOperation();
	}
}