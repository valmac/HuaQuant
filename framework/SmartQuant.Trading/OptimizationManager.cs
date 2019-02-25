using System;

namespace SmartQuant.Trading
{
	// Token: 0x0200001C RID: 28
	[StrategyComponent("{A4D510F9-13DB-4b4c-9557-BC6A48A25D0B}", ComponentType.OptimizationManager, Name = "Default_OptimizationManager", Description = "")]
	public class OptimizationManager : MetaStrategyBaseComponent
	{
		// Token: 0x0600012F RID: 303 RVA: 0x000056F3 File Offset: 0x000046F3
		public virtual double Objective()
		{
			return 0.0;
		}

		// Token: 0x0400005E RID: 94
		public const string GUID = "{A4D510F9-13DB-4b4c-9557-BC6A48A25D0B}";
	}
}
