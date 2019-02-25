using System;

namespace SmartQuant.Trading
{
	// Token: 0x02000082 RID: 130
	[StrategyComponent("{2DBD0B38-8399-4d0b-9FAA-7C29FC1462BC}", ComponentType.MetaExposureManager, Name = "Default_MetaExposureManager", Description = "")]
	public class MetaExposureManager : MetaStrategyComponent
	{
		// Token: 0x060005F9 RID: 1529 RVA: 0x00013514 File Offset: 0x00012514
		public virtual bool Validate(Signal signal)
		{
			return true;
		}

		// Token: 0x0400019B RID: 411
		public const string GUID = "{2DBD0B38-8399-4d0b-9FAA-7C29FC1462BC}";
	}
}
