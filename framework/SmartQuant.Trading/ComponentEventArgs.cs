using System;

namespace SmartQuant.Trading
{
	// Token: 0x02000040 RID: 64
	public class ComponentEventArgs : EventArgs
	{
		// Token: 0x060002C8 RID: 712 RVA: 0x0000B8A0 File Offset: 0x0000A8A0
		public ComponentEventArgs(ComponentRecord record)
		{
			this.record = record;
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x0000B8AF File Offset: 0x0000A8AF
		public ComponentRecord Record
		{
			get
			{
				return this.record;
			}
		}

		// Token: 0x040000F3 RID: 243
		private ComponentRecord record;
	}
}
