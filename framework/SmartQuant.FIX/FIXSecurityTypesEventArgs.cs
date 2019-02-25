using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200001F RID: 31
	public class FIXSecurityTypesEventArgs : EventArgs
	{
		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000574 RID: 1396 RVA: 0x00008139 File Offset: 0x00007139
		// (set) Token: 0x06000575 RID: 1397 RVA: 0x00008141 File Offset: 0x00007141
		public FIXSecurityTypes SecurityTypes
		{
			get
			{
				return this.fSecurityTypes;
			}
			set
			{
				this.fSecurityTypes = value;
			}
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x0000814A File Offset: 0x0000714A
		public FIXSecurityTypesEventArgs(FIXSecurityTypes SecurityTypes)
		{
			this.fSecurityTypes = SecurityTypes;
		}

		// Token: 0x04000048 RID: 72
		private FIXSecurityTypes fSecurityTypes;
	}
}
