namespace Beeline.BeeZap.Model
{
	public interface IOperation<T>
	{
		T Execute(T input);
		IOperation<T> Register(IOperation<T> operation);
	}
}