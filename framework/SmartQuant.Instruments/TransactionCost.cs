using System;
using SmartQuant.FIX;

namespace SmartQuant.Instruments
{
	// Token: 0x0200000E RID: 14
	public class TransactionCost
	{
		// Token: 0x0600003A RID: 58 RVA: 0x00002780 File Offset: 0x00001780
		public TransactionCost(CommType commType, double commission)
		{
			this.Set(commType, commission);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002790 File Offset: 0x00001790
		public TransactionCost() : this(CommType.Absolute, 0.0)
		{
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600003C RID: 60 RVA: 0x000027A2 File Offset: 0x000017A2
		// (set) Token: 0x0600003D RID: 61 RVA: 0x000027AA File Offset: 0x000017AA
		public double Commission
		{
			get
			{
				return this.commission;
			}
			set
			{
				this.commission = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600003E RID: 62 RVA: 0x000027B3 File Offset: 0x000017B3
		// (set) Token: 0x0600003F RID: 63 RVA: 0x000027BB File Offset: 0x000017BB
		public CommType CommType
		{
			get
			{
				return this.commType;
			}
			set
			{
				this.commType = value;
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000027C4 File Offset: 0x000017C4
		public void Set(CommType commType, double commission)
		{
			this.commType = commType;
			this.commission = commission;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000027D4 File Offset: 0x000017D4
		public virtual double GetCost(Transaction transaction)
		{
			if (this.commission == 0.0)
			{
				return 0.0;
			}
			switch (this.commType)
			{
			case CommType.PerShare:
				return this.Commission * transaction.Qty;
			case CommType.Percent:
				return this.Commission * transaction.Value;
			case CommType.Absolute:
				return this.Commission;
			default:
				throw new NotSupportedException("Commission type is not supported : " + this.commType);
			}
		}

		// Token: 0x0400000A RID: 10
		private CommType commType;

		// Token: 0x0400000B RID: 11
		private double commission;
	}
}
