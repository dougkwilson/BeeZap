namespace Beeline.BeeZap.Model
{
	public abstract class OperationBase<T> : IOperation<T>
	{
		private IOperation<T> _nextOperation;

		protected abstract T ExecuteImp(T input);

		public T Execute(T input)
		{
			T retVal = ExecuteImp(input);
			if (retVal != null && _nextOperation != null) {
				retVal = _nextOperation.Execute(retVal);
			}

			return retVal;
		}

		public IOperation<T> Register(IOperation<T> operation)
		{
			if (_nextOperation == null) {
				_nextOperation = operation;
			}
			else {
				return _nextOperation.Register(operation);
			}
			return _nextOperation;
		}
	}
}