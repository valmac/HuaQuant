using System;

namespace SmartQuant.Trading
{
	// Token: 0x0200006F RID: 111
	[StrategyComponent("{0449D7E3-2016-47f6-9B80-C787B3E0F18F}", ComponentType.ExposureManager, Name = "Default_ExposureManager", Description = "")]
	public class ExposureManager : StrategyMultiComponent
	{
		// Token: 0x06000482 RID: 1154 RVA: 0x00010252 File Offset: 0x0000F252
		public virtual bool Validate(Signal signal)
		{
			return true;
		}

		// Token: 0x04000163 RID: 355
		public const string GUID = "{0449D7E3-2016-47f6-9B80-C787B3E0F18F}";
	}
}
