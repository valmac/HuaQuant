using System;
using System.ComponentModel;
using SmartQuant.FIX;
using SmartQuant.Simulation.Design;

namespace SmartQuant.Simulation
{
	// Token: 0x02000005 RID: 5
	[TypeConverter(typeof(CommissionProviderTypeConverter))]
	public interface ICommissionProvider
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600001D RID: 29
		// (set) Token: 0x0600001E RID: 30
		CommType CommType { get; set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001F RID: 31
		// (set) Token: 0x06000020 RID: 32
		double Commission { get; set; }

		// Token: 0x06000021 RID: 33
		FIXCommissionData GetCommissionData(FIXExecutionReport report);
	}
}
