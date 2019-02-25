using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200008E RID: 142
	public class FIXSecurityDefinitionEventArgs : EventArgs
	{
		// Token: 0x17000C27 RID: 3111
		// (get) Token: 0x06001B0F RID: 6927 RVA: 0x0001DBA1 File Offset: 0x0001CBA1
		// (set) Token: 0x06001B10 RID: 6928 RVA: 0x0001DBA9 File Offset: 0x0001CBA9
		public FIXSecurityDefinition SecurityDefinition
		{
			get
			{
				return this.fSecurityDefinition;
			}
			set
			{
				this.fSecurityDefinition = value;
			}
		}

		// Token: 0x06001B11 RID: 6929 RVA: 0x0001DBB2 File Offset: 0x0001CBB2
		public FIXSecurityDefinitionEventArgs(FIXSecurityDefinition SecurityDefinition)
		{
			this.fSecurityDefinition = SecurityDefinition;
		}

		// Token: 0x040002D7 RID: 727
		private FIXSecurityDefinition fSecurityDefinition;
	}
}
