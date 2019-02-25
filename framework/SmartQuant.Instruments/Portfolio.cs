using System;
using System.Collections.Generic;
using System.ComponentModel;
using SmartQuant.FIX;

namespace SmartQuant.Instruments
{
	// Token: 0x02000014 RID: 20
	public class Portfolio
	{
		// Token: 0x1400000A RID: 10
		// (add) Token: 0x060000DC RID: 220 RVA: 0x000036E1 File Offset: 0x000026E1
		// (remove) Token: 0x060000DD RID: 221 RVA: 0x000036FA File Offset: 0x000026FA
		public event TransactionEventHandler TransactionAdded;

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x060000DE RID: 222 RVA: 0x00003713 File Offset: 0x00002713
		// (remove) Token: 0x060000DF RID: 223 RVA: 0x0000372C File Offset: 0x0000272C
		public event PositionEventHandler PositionOpened;

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x060000E0 RID: 224 RVA: 0x00003745 File Offset: 0x00002745
		// (remove) Token: 0x060000E1 RID: 225 RVA: 0x0000375E File Offset: 0x0000275E
		public event PositionEventHandler PositionClosed;

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x060000E2 RID: 226 RVA: 0x00003777 File Offset: 0x00002777
		// (remove) Token: 0x060000E3 RID: 227 RVA: 0x00003790 File Offset: 0x00002790
		public event PositionEventHandler PositionChanged;

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x060000E4 RID: 228 RVA: 0x000037A9 File Offset: 0x000027A9
		// (remove) Token: 0x060000E5 RID: 229 RVA: 0x000037C2 File Offset: 0x000027C2
		public event PositionEventHandler ValueChanged;

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x060000E6 RID: 230 RVA: 0x000037DB File Offset: 0x000027DB
		// (remove) Token: 0x060000E7 RID: 231 RVA: 0x000037F4 File Offset: 0x000027F4
		public event EventHandler Cleared;

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x060000E8 RID: 232 RVA: 0x0000380D File Offset: 0x0000280D
		// (remove) Token: 0x060000E9 RID: 233 RVA: 0x00003826 File Offset: 0x00002826
		public event EventHandler CompositionChanged;

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x060000EA RID: 234 RVA: 0x0000383F File Offset: 0x0000283F
		// (remove) Token: 0x060000EB RID: 235 RVA: 0x00003858 File Offset: 0x00002858
		public event EventHandler ConsolidationStarted;

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x060000EC RID: 236 RVA: 0x00003871 File Offset: 0x00002871
		// (remove) Token: 0x060000ED RID: 237 RVA: 0x0000388A File Offset: 0x0000288A
		public event EventHandler ConsolidationFinished;

		// Token: 0x060000EE RID: 238 RVA: 0x000038A4 File Offset: 0x000028A4
		public Portfolio()
		{
			this.id = -1;
			this.transactions = new TransactionList();
			this.positions = new PositionList();
			this.account = new Account();
			this.account.TransactionAdded += this.account_TransactionAdded;
			this.monitored = true;
			this.persistent = false;
			this.marginManager = new MarginManager();
			this.marginManager.Enabled = false;
			this.performance = new Performance(this);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00003927 File Offset: 0x00002927
		public Portfolio(string name, string description) : this()
		{
			this.name = name;
			this.description = description;
			PortfolioManager.Add(this);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00003943 File Offset: 0x00002943
		public Portfolio(string name) : this(name, "")
		{
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00003951 File Offset: 0x00002951
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x00003959 File Offset: 0x00002959
		[Browsable(false)]
		public int Id
		{
			get
			{
				return this.id;
			}
			set
			{
				this.id = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x00003962 File Offset: 0x00002962
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x0000396A File Offset: 0x0000296A
		[Category("Naming")]
		[ReadOnly(true)]
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00003973 File Offset: 0x00002973
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x0000397B File Offset: 0x0000297B
		[Category("Naming")]
		public string Description
		{
			get
			{
				return this.description;
			}
			set
			{
				this.description = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00003984 File Offset: 0x00002984
		[Browsable(false)]
		public PositionList Positions
		{
			get
			{
				return this.positions;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x0000398C File Offset: 0x0000298C
		[Browsable(false)]
		public TransactionList Transactions
		{
			get
			{
				return this.transactions;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x00003994 File Offset: 0x00002994
		[Browsable(false)]
		public Account Account
		{
			get
			{
				return this.account;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000FA RID: 250 RVA: 0x0000399C File Offset: 0x0000299C
		[Browsable(false)]
		public Performance Performance
		{
			get
			{
				return this.performance;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000FB RID: 251 RVA: 0x000039A4 File Offset: 0x000029A4
		// (set) Token: 0x060000FC RID: 252 RVA: 0x000039AC File Offset: 0x000029AC
		[DefaultValue(true)]
		public bool Monitored
		{
			get
			{
				return this.monitored;
			}
			set
			{
				if (value)
				{
					if (!this.monitored)
					{
						this.Connect();
					}
				}
				else if (this.monitored)
				{
					this.Disconnect();
				}
				this.monitored = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000FD RID: 253 RVA: 0x000039D6 File Offset: 0x000029D6
		// (set) Token: 0x060000FE RID: 254 RVA: 0x000039DE File Offset: 0x000029DE
		[DefaultValue(false)]
		public bool Persistent
		{
			get
			{
				return this.persistent;
			}
			set
			{
				if (this.persistent == value)
				{
					return;
				}
				if (value)
				{
					this.Save();
				}
				this.persistent = value;
				PortfolioManager.Update(this);
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00003A00 File Offset: 0x00002A00
		public void Add(DateTime datetime, Side side, double qty, Instrument instrument, double price, double commission, CommType commType)
		{
			this.Add(new Transaction(datetime, side, qty, instrument, price, commission, commType));
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00003A23 File Offset: 0x00002A23
		public void Add(DateTime datetime, Side side, double qty, Instrument instrument, double price)
		{
			this.Add(new Transaction(datetime, side, qty, instrument, price));
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00003A38 File Offset: 0x00002A38
		public void Add(DateTime datetime, Side side, double qty, string symbol, double price, double commission, CommType commType)
		{
			Instrument instrument = InstrumentManager.Instruments[symbol];
			if (instrument == null)
			{
				throw new ArgumentException(string.Concat(new string[]
				{
					"Can not add transaction to portfolio ",
					this.Name,
					"! Instrument with symbol ",
					symbol,
					" does not exist in the system"
				}));
			}
			this.Add(new Transaction(datetime, side, qty, instrument, price, commission, commType));
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00003AA4 File Offset: 0x00002AA4
		public void Add(DateTime datetime, Side side, double qty, string symbol, double price)
		{
			Instrument instrument = InstrumentManager.Instruments[symbol];
			if (instrument == null)
			{
				throw new ArgumentException(string.Concat(new string[]
				{
					"Can not add transaction to portfolio ",
					this.Name,
					"! Instrument with symbol ",
					symbol,
					" does not exist in the system"
				}));
			}
			this.Add(new Transaction(datetime, side, qty, instrument, price));
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00003B0C File Offset: 0x00002B0C
		public void Add(Transaction transaction)
		{
			bool flag = false;
			bool flag2 = true;
			bool flag3 = false;
			Position position = this.positions[transaction.Instrument];
			double num = 0.0;
			double num2 = 0.0;
			if (position == null)
			{
				position = new Position(this, transaction);
				this.positions.Add(position);
				if (this.monitored)
				{
					position.Connect();
				}
				if (transaction.Margin != 0.0)
				{
					double num3 = transaction.Margin;
					num2 = 0.0;
					num = transaction.Debt;
					position.Margin = transaction.Margin;
					position.Debt = transaction.Debt;
				}
				flag = true;
			}
			else
			{
				if (transaction.Margin != 0.0)
				{
					if ((position.Side == PositionSide.Long && transaction.Side == Side.Buy) || (position.Side == PositionSide.Short && (transaction.Side == Side.Sell || transaction.Side == Side.SellShort)))
					{
						double num3 = transaction.Margin;
						num2 = 0.0;
						num = transaction.Debt;
						position.Margin += transaction.Margin;
						position.Debt += transaction.Debt;
					}
					if ((position.Side == PositionSide.Long && (transaction.Side == Side.Sell || transaction.Side == Side.SellShort)) || (position.Side == PositionSide.Short && transaction.Side == Side.Buy))
					{
						if (position.Qty == transaction.Qty)
						{
							double margin = position.Margin;
							num2 = position.Debt;
							num = 0.0;
							position.Margin = 0.0;
							position.Debt = 0.0;
						}
						else if (position.Qty > transaction.Qty)
						{
							double margin2 = transaction.Margin;
							num2 = position.Debt * transaction.Qty / position.Qty;
							num = 0.0;
							position.Margin -= transaction.Margin;
							position.Debt -= num2;
						}
						else
						{
							double num4 = transaction.Qty - position.Qty;
							double num5 = num4 * transaction.Price;
							if (transaction.Instrument.Factor != 0.0)
							{
								num5 *= transaction.Instrument.Factor;
							}
							double margin3 = position.Margin;
							double num3 = transaction.Instrument.Margin * num4;
							num2 = position.Debt;
							num = num5 - num3;
							position.Margin = num3;
							position.Debt = num;
						}
					}
				}
				position.Add(transaction);
				if (position.Qty == 0.0)
				{
					this.positions.Remove(position);
					if (this.monitored)
					{
						position.Disconnect();
					}
					flag3 = true;
				}
			}
			this.transactions.Add(transaction);
			if (!this.isLoading && this.persistent)
			{
				PortfolioManager.Add(this, transaction);
			}
			this.EmitTransactionAdded(transaction);
			if (!this.isLoading)
			{
				this.account.Add(transaction.CashFlow + num - num2, transaction.Currency, transaction.DateTime, transaction.Text);
			}
			if (flag)
			{
				this.EmitPositionOpened(position);
			}
			if (flag2)
			{
				this.EmitPositionChanged(position);
			}
			if (flag3)
			{
				this.EmitPositionClosed(position);
			}
			this.EmitCompositionChanged();
			if (!this.isLoading)
			{
				this.EmitValueChanged(position);
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00003E68 File Offset: 0x00002E68
		public Portfolio Reconstruct(DateTime dateTime)
		{
			Portfolio portfolio = new Portfolio();
			foreach (object obj in this.transactions)
			{
				Transaction transaction = (Transaction)obj;
				if (transaction.DateTime <= dateTime)
				{
					portfolio.Add(transaction);
				}
			}
			portfolio.Account.Clear();
			foreach (object obj2 in this.account.Transactions)
			{
				AccountTransaction accountTransaction = (AccountTransaction)obj2;
				if (accountTransaction.DateTime <= dateTime)
				{
					portfolio.Account.Add(accountTransaction);
				}
			}
			return portfolio;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00003F4C File Offset: 0x00002F4C
		public Portfolio Consolidate(Portfolio portfolio)
		{
			TransactionList transactionList = new TransactionList();
			foreach (object obj in this.Transactions)
			{
				Transaction transaction = (Transaction)obj;
				transactionList.Add(transaction, false);
			}
			foreach (object obj2 in portfolio.Transactions)
			{
				Transaction transaction2 = (Transaction)obj2;
				transactionList.Add(transaction2, false);
			}
			transactionList.Sort();
			Portfolio portfolio2 = new Portfolio();
			foreach (object obj3 in transactionList)
			{
				Transaction transaction3 = (Transaction)obj3;
				portfolio2.Add(transaction3);
			}
			portfolio2.Account.Clear();
			AccountTransactionList accountTransactionList = new AccountTransactionList();
			foreach (object obj4 in this.Account.Transactions)
			{
				AccountTransaction transaction4 = (AccountTransaction)obj4;
				accountTransactionList.Add(transaction4);
			}
			foreach (object obj5 in portfolio.Account.Transactions)
			{
				AccountTransaction transaction5 = (AccountTransaction)obj5;
				accountTransactionList.Add(transaction5);
			}
			foreach (object obj6 in accountTransactionList)
			{
				AccountTransaction transaction6 = (AccountTransaction)obj6;
				portfolio2.Account.Add(transaction6);
			}
			return portfolio2;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00004170 File Offset: 0x00003170
		public bool Contains(Instrument instrument)
		{
			return this.positions.Contains(instrument);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00004180 File Offset: 0x00003180
		public double GetPositionValue(DateTime dateTime)
		{
			if (this.transactions.Count == 0)
			{
				return 0.0;
			}
			bool flag = false;
			if (this.transactions.Count != 0 && this.transactions.Last.DateTime > dateTime)
			{
				flag = true;
			}
			Portfolio portfolio;
			if (flag)
			{
				portfolio = this.Reconstruct(dateTime);
			}
			else
			{
				portfolio = this;
			}
			double num = 0.0;
			foreach (object obj in portfolio.Positions)
			{
				Position position = (Position)obj;
				num += position.GetValue(dateTime);
			}
			return num;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00004240 File Offset: 0x00003240
		public double GetPositionValue()
		{
			double num = 0.0;
			foreach (object obj in this.positions)
			{
				Position position = (Position)obj;
				num += position.GetValue();
			}
			return num;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000042A8 File Offset: 0x000032A8
		public double GetAccountValue()
		{
			return this.account.GetValue();
		}

		// Token: 0x0600010A RID: 266 RVA: 0x000042B5 File Offset: 0x000032B5
		public double GetAccountValue(DateTime dateTime)
		{
			return this.account.GetValue(dateTime);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000042C3 File Offset: 0x000032C3
		public double GetValue()
		{
			return this.account.GetValue() + this.GetPositionValue();
		}

		// Token: 0x0600010C RID: 268 RVA: 0x000042D7 File Offset: 0x000032D7
		public double GetValue(DateTime dateTime)
		{
			return this.account.GetValue(dateTime) + this.GetPositionValue(dateTime);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x000042F0 File Offset: 0x000032F0
		public double GetMarginValue()
		{
			double num = 0.0;
			foreach (object obj in this.positions)
			{
				Position position = (Position)obj;
				num += position.GetMarginValue();
			}
			return num;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00004358 File Offset: 0x00003358
		public double GetMarginValue(DateTime dateTime)
		{
			if (this.transactions.Count == 0)
			{
				return 0.0;
			}
			bool flag = false;
			if (this.transactions.Count != 0 && this.transactions.Last.DateTime > dateTime)
			{
				flag = true;
			}
			Portfolio portfolio;
			if (flag)
			{
				portfolio = this.Reconstruct(dateTime);
			}
			else
			{
				portfolio = this;
			}
			double num = 0.0;
			foreach (object obj in portfolio.Positions)
			{
				Position position = (Position)obj;
				num += position.GetMarginValue();
			}
			return num;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00004418 File Offset: 0x00003418
		public double GetDebtValue()
		{
			double num = 0.0;
			foreach (object obj in this.positions)
			{
				Position position = (Position)obj;
				num += position.GetDebtValue();
			}
			return num;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00004480 File Offset: 0x00003480
		public double GetDebtValue(DateTime dateTime)
		{
			if (this.transactions.Count == 0)
			{
				return 0.0;
			}
			bool flag = false;
			if (this.transactions.Count != 0 && this.transactions.Last.DateTime > dateTime)
			{
				flag = true;
			}
			Portfolio portfolio;
			if (flag)
			{
				portfolio = this.Reconstruct(dateTime);
			}
			else
			{
				portfolio = this;
			}
			double num = 0.0;
			foreach (object obj in portfolio.Positions)
			{
				Position position = (Position)obj;
				num += position.GetDebtValue();
			}
			return num;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00004540 File Offset: 0x00003540
		public double GetCoreEquity()
		{
			return this.GetAccountValue();
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00004548 File Offset: 0x00003548
		public double GetCoreEquity(DateTime DateTime)
		{
			return this.GetAccountValue(DateTime);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00004551 File Offset: 0x00003551
		public double GetTotalEquity()
		{
			return this.GetValue() - this.GetDebtValue();
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00004560 File Offset: 0x00003560
		public double GetTotalEquity(DateTime DateTime)
		{
			return this.GetValue(DateTime) - this.GetDebtValue();
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00004570 File Offset: 0x00003570
		public double GetLeverage()
		{
			double marginValue = this.GetMarginValue();
			if (marginValue == 0.0)
			{
				return 0.0;
			}
			return this.GetValue() / marginValue;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x000045A4 File Offset: 0x000035A4
		public double GetDebtEquityRatio()
		{
			double totalEquity = this.GetTotalEquity();
			if (totalEquity == 0.0)
			{
				return 0.0;
			}
			return this.GetDebtValue() / totalEquity;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x000045D8 File Offset: 0x000035D8
		public double GetCashFlow()
		{
			double num = 0.0;
			foreach (object obj in this.positions)
			{
				Position position = (Position)obj;
				num += position.GetCashFlow();
			}
			return num;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00004640 File Offset: 0x00003640
		public double GetNetCashFlow()
		{
			double num = 0.0;
			foreach (object obj in this.positions)
			{
				Position position = (Position)obj;
				num += position.GetNetCashFlow();
			}
			return num;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x000046A8 File Offset: 0x000036A8
		public virtual double GetExposure(int tag, string val, PositionSide side)
		{
			double num = 0.0;
			foreach (object obj in this.positions)
			{
				Position position = (Position)obj;
				if (position.Side == side && position.Instrument.GetStringField(tag).Value == val)
				{
					num += position.GetValue();
				}
			}
			return num / this.GetPositionValue();
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00004738 File Offset: 0x00003738
		public virtual double GetExposure(int tag, string val)
		{
			double num = 0.0;
			foreach (object obj in this.positions)
			{
				Position position = (Position)obj;
				if (position.Instrument.GetStringField(tag).Value == val)
				{
					num += position.GetValue();
				}
			}
			return num / this.GetPositionValue();
		}

		// Token: 0x0600011B RID: 283 RVA: 0x000047C0 File Offset: 0x000037C0
		public void Clear()
		{
			this.Disconnect();
			this.positions.Clear();
			this.transactions.Clear();
			this.account.Clear();
			if (this.persistent)
			{
				PortfolioManager.Clear(this);
			}
			if (this.Cleared != null)
			{
				this.Cleared(this, EventArgs.Empty);
			}
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0000481B File Offset: 0x0000381B
		public void Save()
		{
			if (!this.persistent)
			{
				PortfolioManager.Save(this);
			}
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0000482C File Offset: 0x0000382C
		internal void Connect()
		{
			foreach (object obj in this.positions)
			{
				Position position = (Position)obj;
				position.Connect();
			}
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00004884 File Offset: 0x00003884
		internal void Disconnect()
		{
			foreach (object obj in this.positions)
			{
				Position position = (Position)obj;
				position.Disconnect();
			}
		}

		// Token: 0x0600011F RID: 287 RVA: 0x000048DC File Offset: 0x000038DC
		private void EmitPositionOpened(Position position)
		{
			if (this.PositionOpened != null)
			{
				this.PositionOpened(this, new PositionEventArgs(position));
			}
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000048F8 File Offset: 0x000038F8
		private void EmitPositionClosed(Position position)
		{
			if (this.PositionClosed != null)
			{
				this.PositionClosed(this, new PositionEventArgs(position));
			}
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00004914 File Offset: 0x00003914
		private void EmitPositionChanged(Position position)
		{
			if (this.PositionChanged != null)
			{
				this.PositionChanged(this, new PositionEventArgs(position));
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00004930 File Offset: 0x00003930
		private void EmitTransactionAdded(Transaction transaction)
		{
			if (this.TransactionAdded != null)
			{
				this.TransactionAdded(this, new TransactionEventArgs(transaction));
			}
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0000494C File Offset: 0x0000394C
		internal void EmitValueChanged(Position position)
		{
			if (this.ValueChanged != null)
			{
				this.ValueChanged(this, new PositionEventArgs(position));
			}
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00004968 File Offset: 0x00003968
		internal void EmitCompositionChanged()
		{
			if (this.CompositionChanged != null)
			{
				this.CompositionChanged(this, EventArgs.Empty);
			}
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00004983 File Offset: 0x00003983
		public override string ToString()
		{
			return this.name;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0000498B File Offset: 0x0000398B
		public void ConsolidateFrom(Portfolio[] portfolioList)
		{
			this.ConsolidateFrom(portfolioList, false);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00004998 File Offset: 0x00003998
		public void ConsolidateFrom(Portfolio[] portfolioList, bool cloneTransactions)
		{
			if (this.ConsolidationStarted != null)
			{
				this.ConsolidationStarted(this, EventArgs.Empty);
			}
			this.isLoading = true;
			this.Clear();
			List<Portfolio> list = new List<Portfolio>();
			List<int> list2 = new List<int>();
			foreach (Portfolio portfolio in portfolioList)
			{
				if (portfolio.Transactions.Count > 0)
				{
					list.Add(portfolio);
					list2.Add(0);
				}
			}
			while (list.Count > 0)
			{
				DateTime t = DateTime.MaxValue;
				int num = -1;
				for (int j = 0; j < list.Count; j++)
				{
					Portfolio portfolio2 = list[j];
					DateTime dateTime = portfolio2.Transactions[list2[j]].DateTime;
					if (dateTime < t)
					{
						t = dateTime;
						num = j;
					}
				}
				if (!cloneTransactions)
				{
					this.Add(list[num].Transactions[list2[num]]);
				}
				else
				{
					this.Add((Transaction)list[num].Transactions[list2[num]].Clone());
				}
				List<int> list3;
				int index;
				(list3 = list2)[index = num] = list3[index] + 1;
				if (list2[num] == list[num].Transactions.Count)
				{
					list2.RemoveAt(num);
					list.RemoveAt(num);
				}
			}
			this.isLoading = false;
			if (this.ConsolidationFinished != null)
			{
				this.ConsolidationFinished(this, EventArgs.Empty);
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00004B28 File Offset: 0x00003B28
		internal void SetIsLoading(bool value)
		{
			this.isLoading = value;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00004B31 File Offset: 0x00003B31
		internal void SetPersistent(bool value)
		{
			this.persistent = value;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00004B3A File Offset: 0x00003B3A
		private void account_TransactionAdded(object sender, AccountTransactionEventArgs args)
		{
			if (!this.isLoading && this.persistent)
			{
				PortfolioManager.Add(this, args.Transaction);
			}
		}

		// Token: 0x04000027 RID: 39
		private const string CATEGORY_NAMING = "Naming";

		// Token: 0x04000028 RID: 40
		private const bool DEFAULT_MONITORED = true;

		// Token: 0x04000029 RID: 41
		private const bool DEFAULT_PERSISTENT = false;

		// Token: 0x04000033 RID: 51
		private int id;

		// Token: 0x04000034 RID: 52
		private string name;

		// Token: 0x04000035 RID: 53
		private string description;

		// Token: 0x04000036 RID: 54
		private TransactionList transactions;

		// Token: 0x04000037 RID: 55
		private PositionList positions;

		// Token: 0x04000038 RID: 56
		private Account account;

		// Token: 0x04000039 RID: 57
		private bool monitored;

		// Token: 0x0400003A RID: 58
		private bool persistent;

		// Token: 0x0400003B RID: 59
		private MarginManager marginManager;

		// Token: 0x0400003C RID: 60
		private Performance performance;

		// Token: 0x0400003D RID: 61
		private bool isLoading;
	}
}
