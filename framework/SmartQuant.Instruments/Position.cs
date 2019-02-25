using System;
using System.ComponentModel;
using SmartQuant.FIX;
using SmartQuant.Providers;

namespace SmartQuant.Instruments
{
	// Token: 0x02000032 RID: 50
	public class Position
	{
		// Token: 0x14000016 RID: 22
		// (add) Token: 0x060002AE RID: 686 RVA: 0x00008984 File Offset: 0x00007984
		// (remove) Token: 0x060002AF RID: 687 RVA: 0x0000899D File Offset: 0x0000799D
		public event EventHandler ValueChanged;

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x000089B6 File Offset: 0x000079B6
		// (set) Token: 0x060002B1 RID: 689 RVA: 0x000089BE File Offset: 0x000079BE
		internal int Id
		{
			get
			{
				return this.fId;
			}
			set
			{
				this.fId = value;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x000089C7 File Offset: 0x000079C7
		public string Name
		{
			get
			{
				if (this.fInstrument == null)
				{
					throw new ApplicationException("Can not return name of portfolio position. Instrument is not set.");
				}
				return this.fInstrument.Symbol;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060002B3 RID: 691 RVA: 0x000089E7 File Offset: 0x000079E7
		public Portfolio Portfolio
		{
			get
			{
				return this.fPortfolio;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x000089EF File Offset: 0x000079EF
		public Instrument Instrument
		{
			get
			{
				return this.fInstrument;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x000089F7 File Offset: 0x000079F7
		[Browsable(false)]
		public TransactionList Transactions
		{
			get
			{
				return this.fTransactions;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x000089FF File Offset: 0x000079FF
		public PositionSide Side
		{
			get
			{
				if (this.Amount >= 0.0)
				{
					return PositionSide.Long;
				}
				return PositionSide.Short;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060002B7 RID: 695 RVA: 0x00008A15 File Offset: 0x00007A15
		public double EntryPrice
		{
			get
			{
				return this.fTransactions[0].Price;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x00008A28 File Offset: 0x00007A28
		public DateTime EntryDate
		{
			get
			{
				return this.fTransactions[0].DateTime;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060002B9 RID: 697 RVA: 0x00008A3B File Offset: 0x00007A3B
		public double EntryQty
		{
			get
			{
				return this.fTransactions[0].Qty;
			}
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00008A50 File Offset: 0x00007A50
		public string SideToString()
		{
			switch (this.Side)
			{
			case PositionSide.Long:
				return "Long";
			case PositionSide.Short:
				return "Short";
			default:
				throw new NotSupportedException("Unknown position side : " + this.Side);
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060002BB RID: 699 RVA: 0x00008A9A File Offset: 0x00007A9A
		public double Amount
		{
			get
			{
				return this.fQtyBought - this.fQtySold - this.fQtySoldShort;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060002BC RID: 700 RVA: 0x00008AB0 File Offset: 0x00007AB0
		public double Qty
		{
			get
			{
				return Math.Abs(this.Amount);
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060002BD RID: 701 RVA: 0x00008ABD File Offset: 0x00007ABD
		public double QtyBought
		{
			get
			{
				return this.fQtyBought;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060002BE RID: 702 RVA: 0x00008AC5 File Offset: 0x00007AC5
		public double QtySold
		{
			get
			{
				return this.fQtySold;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060002BF RID: 703 RVA: 0x00008ACD File Offset: 0x00007ACD
		public double QtySoldShort
		{
			get
			{
				return this.fQtySoldShort;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x00008AD5 File Offset: 0x00007AD5
		// (set) Token: 0x060002C1 RID: 705 RVA: 0x00008ADD File Offset: 0x00007ADD
		[ReadOnly(true)]
		public double Margin
		{
			get
			{
				return this.fMargin;
			}
			set
			{
				this.fMargin = value;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x00008AE6 File Offset: 0x00007AE6
		// (set) Token: 0x060002C3 RID: 707 RVA: 0x00008AEE File Offset: 0x00007AEE
		[ReadOnly(true)]
		public double Debt
		{
			get
			{
				return this.fDebt;
			}
			set
			{
				this.fDebt = value;
			}
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00008AF7 File Offset: 0x00007AF7
		public Position(Portfolio portfolio, Instrument instrument)
		{
			this.fPortfolio = portfolio;
			this.fInstrument = instrument;
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00008B26 File Offset: 0x00007B26
		public Position(Portfolio portfolio, Transaction transaction)
		{
			this.fPortfolio = portfolio;
			this.fInstrument = transaction.Instrument;
			this.Add(transaction);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00008B61 File Offset: 0x00007B61
		internal void Connect()
		{
			if (this.fInstrument != null)
			{
				this.fInstrument.NewBar += this.OnNewBar;
				this.fInstrument.NewTrade += this.OnNewTrade;
			}
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00008B99 File Offset: 0x00007B99
		internal void Disconnect()
		{
			if (this.fInstrument != null)
			{
				this.fInstrument.NewBar -= this.OnNewBar;
				this.fInstrument.NewTrade -= this.OnNewTrade;
			}
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00008BD4 File Offset: 0x00007BD4
		public void Add(Transaction transaction)
		{
			if (this.fInstrument != transaction.Instrument)
			{
				throw new ArgumentException("Can not add transaction. Transaction instrument : " + transaction.Instrument.Symbol + " does not match position instrument : " + this.fInstrument.Symbol);
			}
			double num = 0.0;
			double num2 = 0.0;
			int num3 = Math.Sign(transaction.Amount);
			if (this.fTransactions.Count == 0)
			{
				this.fPnLTransactionIndex = 0;
				this.fQtyLeft = transaction.Qty;
			}
			else if ((this.Side == PositionSide.Long && num3 == -1) || (this.Side == PositionSide.Short && num3 == 1))
			{
				int num4 = this.fPnLTransactionIndex + 1;
				double qty = transaction.Qty;
				double num5 = 0.0;
				double num6 = Math.Min(qty, this.fQtyLeft);
				num5 += this.fQtyLeft;
				num2 += num6 * (transaction.Cost / transaction.Qty + this.fTransactions[this.fPnLTransactionIndex].Cost / this.fTransactions[this.fPnLTransactionIndex].Qty);
				num += (transaction.Price - this.fTransactions[this.fPnLTransactionIndex].Price) * num6 * (double)(-(double)num3);
				while (qty > num5 && num4 < this.fTransactions.Count)
				{
					Transaction transaction2 = this.fTransactions[num4];
					if (Math.Sign(transaction2.Amount) != num3)
					{
						num6 = Math.Min(qty - num5, transaction2.Qty);
						num2 += num6 * (transaction.Cost / transaction.Qty + transaction2.Cost / transaction2.Qty);
						num += (transaction.Price - transaction2.Price) * num6 * (double)(-(double)num3);
						num5 += transaction2.Qty;
					}
					num4++;
				}
				this.fQtyLeft = Math.Abs(qty - num5);
				if ((qty == num5 && num4 == this.fTransactions.Count) || qty > num5)
				{
					this.fPnLTransactionIndex = this.fTransactions.Count;
				}
				else
				{
					this.fPnLTransactionIndex = num4 - 1;
				}
			}
			if (this.fInstrument.Factor != 0.0)
			{
				num *= this.fInstrument.Factor;
			}
			transaction.PnL = num - transaction.Cost;
			transaction.RealizedPnL = num - num2;
			switch (transaction.Side)
			{
			case SmartQuant.FIX.Side.Buy:
			case SmartQuant.FIX.Side.BuyMinus:
				this.fQtyBought += transaction.Qty;
				break;
			case SmartQuant.FIX.Side.Sell:
			case SmartQuant.FIX.Side.SellPlus:
				this.fQtySold += transaction.Qty;
				break;
			case SmartQuant.FIX.Side.SellShort:
			case SmartQuant.FIX.Side.SellShortExempt:
				this.fQtySoldShort += transaction.Qty;
				break;
			default:
				throw new Exception("Transaction Side is not supported : " + transaction.Side.ToString());
			}
			this.fTransactions.Add(transaction);
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00008EC8 File Offset: 0x00007EC8
		public double Price(DateTime datetime)
		{
			Currency currency = this.fInstrument.GetCurrency();
			if (currency != null && this.fPortfolio.Account.Currency != null)
			{
				return currency.Convert(this.fInstrument.Price(datetime), this.fPortfolio.Account.Currency, datetime);
			}
			return this.fInstrument.Price(datetime);
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00008F28 File Offset: 0x00007F28
		public double Price()
		{
			Currency currency = this.fInstrument.GetCurrency();
			if (currency != null && this.fPortfolio.Account.Currency != null)
			{
				return currency.Convert(PortfolioManager.Pricer.Price(this), this.fPortfolio.Account.Currency);
			}
			return PortfolioManager.Pricer.Price(this);
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00008F84 File Offset: 0x00007F84
		public double GetValue(DateTime datetime)
		{
			if (this.fInstrument.Factor != 0.0)
			{
				return this.Price(datetime) * this.Amount * this.fInstrument.Factor;
			}
			return this.Price(datetime) * this.Amount;
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00008FD0 File Offset: 0x00007FD0
		public double GetValue()
		{
			if (this.fInstrument.Factor != 0.0)
			{
				return this.Price() * this.Amount * this.fInstrument.Factor;
			}
			return this.Price() * this.Amount;
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0000900F File Offset: 0x0000800F
		public double GetMarginValue()
		{
			return this.fMargin;
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00009017 File Offset: 0x00008017
		public double GetDebtValue()
		{
			return this.fDebt;
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00009020 File Offset: 0x00008020
		public double GetLeverage()
		{
			double marginValue = this.GetMarginValue();
			if (marginValue == 0.0)
			{
				return 0.0;
			}
			return this.GetValue() / marginValue;
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00009054 File Offset: 0x00008054
		public double GetCashFlow()
		{
			double num = 0.0;
			foreach (object obj in this.fTransactions)
			{
				Transaction transaction = (Transaction)obj;
				num += transaction.CashFlow;
			}
			return num;
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x000090BC File Offset: 0x000080BC
		public double GetNetCashFlow()
		{
			double num = 0.0;
			foreach (object obj in this.fTransactions)
			{
				Transaction transaction = (Transaction)obj;
				num += transaction.NetCashFlow;
			}
			return num;
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00009124 File Offset: 0x00008124
		public double GetPnL()
		{
			return this.GetValue() + this.GetCashFlow();
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00009133 File Offset: 0x00008133
		public double GetNetPnL()
		{
			return this.GetValue() + this.GetNetCashFlow();
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00009142 File Offset: 0x00008142
		public double GetPnLPercent()
		{
			return this.GetPnL() / this.fTransactions[0].Value;
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0000915C File Offset: 0x0000815C
		public double GetNetPnLPercent()
		{
			return this.GetNetPnL() / this.fTransactions[0].Value;
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00009178 File Offset: 0x00008178
		public double GetUnrealizedPnL()
		{
			if (this.Qty == 0.0)
			{
				return 0.0;
			}
			double num = this.fInstrument.Price();
			double num2 = 0.0;
			int num3 = (this.Side == PositionSide.Long) ? -1 : 1;
			double num4 = this.fQtyLeft;
			num2 += (num - this.fTransactions[this.fPnLTransactionIndex].Price) * num4 * (double)(-(double)num3);
			for (int i = this.fPnLTransactionIndex + 1; i < this.fTransactions.Count; i++)
			{
				Transaction transaction = this.fTransactions[i];
				num2 += (num - transaction.Price) * num4 * (double)(-(double)num3);
			}
			return num2 * this.Instrument.Factor;
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0000923A File Offset: 0x0000823A
		public TimeSpan GetDuration()
		{
			return Clock.Now - this.fTransactions[0].DateTime;
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00009257 File Offset: 0x00008257
		private void OnNewBar(object sender, BarEventArgs args)
		{
			if (this.ValueChanged != null)
			{
				this.ValueChanged(this, EventArgs.Empty);
			}
			this.fPortfolio.EmitValueChanged(this);
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0000927E File Offset: 0x0000827E
		private void OnNewTrade(object sender, TradeEventArgs args)
		{
			if (this.ValueChanged != null)
			{
				this.ValueChanged(this, EventArgs.Empty);
			}
			this.fPortfolio.EmitValueChanged(this);
		}

		// Token: 0x060002DA RID: 730 RVA: 0x000092A8 File Offset: 0x000082A8
		public override string ToString()
		{
			return string.Concat(new object[]
			{
				this.SideToString(),
				" ",
				this.Qty,
				" ",
				this.fInstrument.Symbol
			});
		}

		// Token: 0x040000BA RID: 186
		private int fId = -1;

		// Token: 0x040000BB RID: 187
		private TransactionList fTransactions = new TransactionList();

		// Token: 0x040000BC RID: 188
		private Portfolio fPortfolio;

		// Token: 0x040000BD RID: 189
		private Instrument fInstrument;

		// Token: 0x040000BE RID: 190
		private double fQtyBought;

		// Token: 0x040000BF RID: 191
		private double fQtySold;

		// Token: 0x040000C0 RID: 192
		private double fQtySoldShort;

		// Token: 0x040000C1 RID: 193
		private double fMargin;

		// Token: 0x040000C2 RID: 194
		private double fDebt;

		// Token: 0x040000C3 RID: 195
		private int fPnLTransactionIndex = -1;

		// Token: 0x040000C4 RID: 196
		private double fQtyLeft;
	}
}
