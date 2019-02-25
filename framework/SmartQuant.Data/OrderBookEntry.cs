using System;

namespace SmartQuant.Data
{
	// Token: 0x0200000A RID: 10
	public class OrderBookEntry
	{
		// Token: 0x0600004A RID: 74 RVA: 0x00002BB0 File Offset: 0x00001BB0
		public OrderBookEntry(DateTime datetime, double price, int size)
		{
			this.datetime = datetime;
			this.price = price;
			this.size = size;
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00002BCD File Offset: 0x00001BCD
		// (set) Token: 0x0600004C RID: 76 RVA: 0x00002BD5 File Offset: 0x00001BD5
		public DateTime DateTime
		{
			get
			{
				return this.datetime;
			}
			set
			{
				this.datetime = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00002BDE File Offset: 0x00001BDE
		// (set) Token: 0x0600004E RID: 78 RVA: 0x00002BE6 File Offset: 0x00001BE6
		public double Price
		{
			get
			{
				return this.price;
			}
			set
			{
				this.price = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00002BEF File Offset: 0x00001BEF
		// (set) Token: 0x06000050 RID: 80 RVA: 0x00002BF7 File Offset: 0x00001BF7
		public int Size
		{
			get
			{
				return this.size;
			}
			set
			{
				this.size = value;
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002C00 File Offset: 0x00001C00
		public override string ToString()
		{
			return string.Format("{0} price={1} size={2}", this.datetime, this.price, this.size);
		}

		// Token: 0x04000013 RID: 19
		private DateTime datetime;

		// Token: 0x04000014 RID: 20
		private double price;

		// Token: 0x04000015 RID: 21
		private int size;
	}
}
