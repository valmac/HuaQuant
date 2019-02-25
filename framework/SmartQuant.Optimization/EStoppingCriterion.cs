using System;

namespace SmartQuant.Optimization
{
	// Token: 0x02000002 RID: 2
	public enum EStoppingCriterion
	{
		// Token: 0x04000002 RID: 2
		All,
		// Token: 0x04000003 RID: 3
		ObjectiveCalls,
		// Token: 0x04000004 RID: 4
		ErrorTolerance,
		// Token: 0x04000005 RID: 5
		StopTemperature,
		// Token: 0x04000006 RID: 6
		AcceptedUphills,
		// Token: 0x04000007 RID: 7
		AcceptedDownhills
	}
}
