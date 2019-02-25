using System;

namespace SmartQuant.Trading
{
	// Token: 0x02000072 RID: 114
	public class SignalEventArgs : EventArgs
	{
		// Token: 0x060004CA RID: 1226 RVA: 0x0001128B File Offset: 0x0001028B
		public SignalEventArgs(Signal signal)
		{
			this.signal = signal;
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060004CB RID: 1227 RVA: 0x0001129A File Offset: 0x0001029A
		public Signal Signal
		{
			get
			{
				return this.signal;
			}
		}

		// Token: 0x04000167 RID: 359
		private Signal signal;
	}
}
