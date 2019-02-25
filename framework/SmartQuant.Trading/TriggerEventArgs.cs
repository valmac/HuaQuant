using System;

namespace SmartQuant.Trading
{
	// Token: 0x0200005F RID: 95
	public class TriggerEventArgs : EventArgs
	{
		// Token: 0x060003B5 RID: 949 RVA: 0x0000EE09 File Offset: 0x0000DE09
		public TriggerEventArgs(Trigger trigger)
		{
			this.trigger = trigger;
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060003B6 RID: 950 RVA: 0x0000EE18 File Offset: 0x0000DE18
		public Trigger Trigger
		{
			get
			{
				return this.trigger;
			}
		}

		// Token: 0x04000136 RID: 310
		private Trigger trigger;
	}
}
