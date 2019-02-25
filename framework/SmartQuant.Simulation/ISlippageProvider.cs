using System;
using System.ComponentModel;
using SmartQuant.FIX;
using SmartQuant.Simulation.Design;

namespace SmartQuant.Simulation
{
	// Token: 0x02000009 RID: 9
	[TypeConverter(typeof(SlippageProviderTypeConverter))]
	public interface ISlippageProvider
	{
		// Token: 0x0600002E RID: 46
		double GetExecutionPrice(ExecutionReport report);
	}
}
