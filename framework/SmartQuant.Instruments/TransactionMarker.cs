using System;
using System.Text;
using SmartQuant.Charting;
using SmartQuant.FIX;

namespace SmartQuant.Instruments
{
	// Token: 0x02000026 RID: 38
	[Serializable]
	internal class TransactionMarker : TMarker
	{
		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000258 RID: 600 RVA: 0x00007E7C File Offset: 0x00006E7C
		public Transaction Transaction
		{
			get
			{
				return this.fTransaction;
			}
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00007E84 File Offset: 0x00006E84
		private void InitTransactionMarker()
		{
			this.fToolTipEnabled = true;
			this.fToolTipFormat = "{0} {2} {1} @ {3} {4}";
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00007E98 File Offset: 0x00006E98
		public TransactionMarker(Transaction transaction) : base(transaction.DateTime, transaction.Price)
		{
			this.fTransaction = transaction;
			this.fText = string.Concat(new object[]
			{
				this.fTransaction.Side.ToString(),
				" ",
				this.fTransaction.Qty,
				" ",
				this.fTransaction.Instrument.Symbol,
				" @ ",
				this.fTransaction.Price.ToString("F2")
			});
			this.fSize = 10;
			switch (this.fTransaction.Side)
			{
			case Side.Buy:
			case Side.BuyMinus:
				this.fStyle = EMarkerStyle.Buy;
				break;
			case Side.Sell:
			case Side.SellPlus:
				this.fStyle = EMarkerStyle.Sell;
				break;
			case Side.SellShort:
			case Side.SellShortExempt:
				this.fStyle = EMarkerStyle.SellShort;
				break;
			}
			this.InitTransactionMarker();
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00007F98 File Offset: 0x00006F98
		public override TDistance Distance(double X, double Y)
		{
			TDistance tdistance = new TDistance();
			tdistance.X = this.fX;
			tdistance.Y = this.fY;
			tdistance.dX = Math.Abs(X - this.fX);
			tdistance.dY = Math.Abs(Y - this.fY);
			StringBuilder stringBuilder = new StringBuilder();
			if (this.fTransaction.DateTime.Second != 0 || this.fTransaction.DateTime.Minute != 0 || this.fTransaction.DateTime.Hour != 0)
			{
				stringBuilder.AppendFormat(this.fToolTipFormat, new object[]
				{
					this.fTransaction.Side.ToString(),
					this.fTransaction.Instrument.Symbol,
					this.fTransaction.Qty,
					this.fTransaction.Price,
					this.fTransaction.DateTime
				});
			}
			else
			{
				stringBuilder.AppendFormat(this.fToolTipFormat, new object[]
				{
					this.fTransaction.Side.ToString(),
					this.fTransaction.Instrument.Symbol,
					this.fTransaction.Qty,
					this.fTransaction.Price,
					this.fTransaction.DateTime.ToShortDateString()
				});
			}
			tdistance.ToolTipText = stringBuilder.ToString();
			return tdistance;
		}

		// Token: 0x040000A0 RID: 160
		[NonSerialized]
		private Transaction fTransaction;
	}
}
