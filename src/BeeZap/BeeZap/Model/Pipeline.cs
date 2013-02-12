namespace Beeline.BeeZap.Model
{
	public abstract class Pipeline<T>
	{
		private IOperation<T> _root;

		public void Register(IOperation<T> operation)
		{
			if (_root == null)
				_root = operation;
			else {
				_root.Register(operation);
			}
		}

		public T Execute(T input)
		{
			T retVal = _root.Execute(input);

			return retVal;
		}
	}
}