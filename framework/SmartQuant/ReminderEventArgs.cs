using System;

namespace SmartQuant
{
	// Token: 0x0200001B RID: 27
	public class ReminderEventArgs : EventArgs
	{
		// Token: 0x060000B4 RID: 180 RVA: 0x0000411C File Offset: 0x0000311C
		internal ReminderEventArgs(DateTime signalTime, object data)
		{
			this.signalTime = signalTime;
			this.data = data;
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00004132 File Offset: 0x00003132
		public DateTime SignalTime
		{
			get
			{
				return this.signalTime;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x0000413A File Offset: 0x0000313A
		public object Data
		{
			get
			{
				return this.data;
			}
		}

		// Token: 0x04000074 RID: 116
		private DateTime signalTime;

		// Token: 0x04000075 RID: 117
		private object data;
	}
}
