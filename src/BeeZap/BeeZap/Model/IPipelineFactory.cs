using System.Collections.Generic;

namespace Beeline.BeeZap.Model
{
	public interface IPipelineFactory
	{
		Pipeline<IEnumerable<IFileInfo>> Create();
	}
}