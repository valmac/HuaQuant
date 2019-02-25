using System;

namespace SmartQuant.Data
{
	// Token: 0x0200000D RID: 13
	public class OrderBookEventArgs : EventArgs
	{
		// Token: 0x0600005C RID: 92 RVA: 0x00002D49 File Offset: 0x00001D49
		public OrderBookEventArgs(MDSide side, MDOperation operation, int position)
		{
			this.side = side;
			this.operation = operation;
			this.position = position;
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00002D66 File Offset: 0x00001D66
		public MDSide Side
		{
			get
			{
				return this.side;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00002D6E File Offset: 0x00001D6E
		public MDOperation Operation
		{
			get
			{
				return this.operation;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00002D76 File Offset: 0x00001D76
		public int Position
		{
			get
			{
				return this.position;
			}
		}

		// Token: 0x04000017 RID: 23
		private MDSide side;

		// Token: 0x04000018 RID: 24
		private MDOperation operation;

		// Token: 0x04000019 RID: 25
		private int position;
	}
}
