using System;
using System.Collections;
using SmartQuant.FIX;

namespace SmartQuant.Instruments
{
	// Token: 0x02000005 RID: 5
	public class MarginManager1
	{
		// Token: 0x0600000B RID: 11 RVA: 0x00002096 File Offset: 0x00001096
		public MarginManager1(Portfolio portfolio)
		{
			this.fPortfolio = portfolio;
			this.Connect();
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000020B8 File Offset: 0x000010B8
		protected virtual void Connect()
		{
			foreach (object obj in this.fPortfolio.Positions)
			{
				Position position = (Position)obj;
				position.ValueChanged += this.OnValueChanged;
			}
			this.fPortfolio.PositionOpened += this.OnPositionOpened;
			this.fPortfolio.PositionClosed += this.OnPositionClosed;
			this.fPortfolio.PositionChanged += this.OnPositionChanged;
			this.fPortfolio.TransactionAdded += this.OnTransactionAdded;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002180 File Offset: 0x00001180
		protected virtual void Disconnect()
		{
			foreach (object obj in this.fPortfolio.Positions)
			{
				Position position = (Position)obj;
				position.ValueChanged -= this.OnValueChanged;
			}
			this.fPortfolio.PositionOpened -= this.OnPositionOpened;
			this.fPortfolio.PositionClosed -= this.OnPositionClosed;
			this.fPortfolio.PositionChanged -= this.OnPositionChanged;
			this.fPortfolio.TransactionAdded -= this.OnTransactionAdded;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002248 File Offset: 0x00001248
		private void OnValueChanged(object sender, EventArgs args)
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000224C File Offset: 0x0000124C
		private void OnPositionOpened(object sender, PositionEventArgs args)
		{
			Position position = args.Position;
			Transaction last = position.Transactions.Last;
			MarginPosition marginPosition = new MarginPosition(position);
			if (last.Instrument.SecurityType == "CS")
			{
				Side side = last.Side;
				if (side == Side.Buy)
				{
					marginPosition.Margin = last.Value * 0.5;
					this.fMargins.Add(position, marginPosition);
					this.fPortfolio.Account.Deposit(marginPosition.Margin, last.Currency, last.DateTime, "Margin +");
				}
			}
			position.ValueChanged += this.OnValueChanged;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000022F4 File Offset: 0x000012F4
		private void OnPositionClosed(object sender, PositionEventArgs args)
		{
			Position position = args.Position;
			Transaction last = position.Transactions.Last;
			MarginPosition marginPosition = new MarginPosition(position);
			if (last.Instrument.SecurityType == "CS")
			{
				Side side = last.Side;
				if (side == Side.Sell)
				{
					this.fMargins.Remove(position);
					this.fPortfolio.Account.Withdraw(marginPosition.Margin, last.Currency, last.DateTime, "Margin -");
				}
			}
			args.Position.ValueChanged -= this.OnValueChanged;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002387 File Offset: 0x00001387
		private void OnPositionChanged(object sender, PositionEventArgs args)
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002389 File Offset: 0x00001389
		private void OnTransactionAdded(object sender, TransactionEventArgs args)
		{
		}

		// Token: 0x04000004 RID: 4
		private Portfolio fPortfolio;

		// Token: 0x04000005 RID: 5
		private Hashtable fMargins = new Hashtable();
	}
}
