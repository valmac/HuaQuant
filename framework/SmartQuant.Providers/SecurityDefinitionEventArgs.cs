using System;
using SmartQuant.FIX;

namespace SmartQuant.Providers
{
	// Token: 0x0200000F RID: 15
	public class SecurityDefinitionEventArgs : EventArgs
	{
		// Token: 0x06000046 RID: 70 RVA: 0x0000224E File Offset: 0x0000124E
		public SecurityDefinitionEventArgs(FIXSecurityDefinition definition)
		{
			this.definition = definition;
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000047 RID: 71 RVA: 0x0000225D File Offset: 0x0000125D
		public FIXSecurityDefinition SecurityDefinition
		{
			get
			{
				return this.definition;
			}
		}

		// Token: 0x0400002A RID: 42
		private FIXSecurityDefinition definition;
	}
}
