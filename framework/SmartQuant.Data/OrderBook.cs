using System;
using System.Diagnostics;

namespace SmartQuant.Data
{
	// Token: 0x0200001A RID: 26
	public class OrderBook
	{
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060000CA RID: 202 RVA: 0x000038B4 File Offset: 0x000028B4
		// (remove) Token: 0x060000CB RID: 203 RVA: 0x000038CD File Offset: 0x000028CD
		public event OrderBookEventHandler Changed;

		// Token: 0x060000CC RID: 204 RVA: 0x000038E6 File Offset: 0x000028E6
		public OrderBook()
		{
			this.bidList = new OrderBookEntryList();
			this.askList = new OrderBookEntryList();
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00003904 File Offset: 0x00002904
		public OrderBookEntryList Bid
		{
			get
			{
				return this.bidList;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000CE RID: 206 RVA: 0x0000390C File Offset: 0x0000290C
		public OrderBookEntryList Ask
		{
			get
			{
				return this.askList;
			}
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00003914 File Offset: 0x00002914
		public void Clear()
		{
			this.bidList.Clear();
			this.askList.Clear();
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0000392C File Offset: 0x0000292C
		public void Add(MarketDepth marketDepth)
		{
			try
			{
				OrderBookEntryList orderBookEntryList;
				switch (marketDepth.Side)
				{
				case MDSide.Bid:
					orderBookEntryList = this.bidList;
					break;
				case MDSide.Ask:
					orderBookEntryList = this.askList;
					break;
				default:
					throw new ArgumentException("Unknown side - " + marketDepth.Side.ToString());
				}
				MDOperation operation = marketDepth.Operation;
				switch (operation)
				{
				case MDOperation.Insert:
					if (marketDepth.Position == -1)
					{
						int i = -1;
						switch (marketDepth.Side)
						{
						case MDSide.Bid:
							for (i = 0; i < orderBookEntryList.Count; i++)
							{
								if (marketDepth.Price > orderBookEntryList[i].Price)
								{
									break;
								}
							}
							break;
						case MDSide.Ask:
							i = orderBookEntryList.Count;
							while (i > 0 && marketDepth.Price <= orderBookEntryList[i - 1].Price)
							{
								i--;
							}
							break;
						}
						orderBookEntryList.Insert(i, new OrderBookEntry(marketDepth.DateTime, marketDepth.Price, marketDepth.Size));
						this.EmitChanged(marketDepth.Side, marketDepth.Operation, i);
						goto IL_258;
					}
					orderBookEntryList.Insert(marketDepth.Position, new OrderBookEntry(marketDepth.DateTime, marketDepth.Price, marketDepth.Size));
					this.EmitChanged(marketDepth.Side, marketDepth.Operation, marketDepth.Position);
					goto IL_258;
				case MDOperation.Update:
					if (marketDepth.Position != -1 && marketDepth.Position < orderBookEntryList.Count)
					{
						OrderBookEntry orderBookEntry = orderBookEntryList[marketDepth.Position];
						orderBookEntry.DateTime = marketDepth.DateTime;
						orderBookEntry.Size = marketDepth.Size;
						if (marketDepth.Price > 0.0)
						{
							orderBookEntry.Price = marketDepth.Price;
						}
						this.EmitChanged(marketDepth.Side, marketDepth.Operation, marketDepth.Position);
						goto IL_258;
					}
					goto IL_258;
				case MDOperation.Delete:
					if (marketDepth.Position != -1)
					{
						orderBookEntryList.RemoveAt(marketDepth.Position);
						this.EmitChanged(marketDepth.Side, marketDepth.Operation, marketDepth.Position);
						goto IL_258;
					}
					goto IL_258;
				case (MDOperation)3:
					break;
				case MDOperation.Reset:
					orderBookEntryList.Clear();
					this.EmitChanged(marketDepth.Side, marketDepth.Operation, marketDepth.Position);
					goto IL_258;
				default:
					if (operation == MDOperation.Undefined)
					{
						goto IL_258;
					}
					break;
				}
				throw new ArgumentException("Unknown operation - " + marketDepth.Operation.ToString());
				IL_258:;
			}
			catch (Exception ex)
			{
				Trace.WriteLine(ex.ToString());
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00003BC0 File Offset: 0x00002BC0
		public Quote GetQuote(int level)
		{
			DateTime dateTime = DateTime.MinValue;
			double bid = 0.0;
			double ask = 0.0;
			int bidSize = 0;
			int askSize = 0;
			if (level < this.bidList.Count)
			{
				OrderBookEntry orderBookEntry = this.bidList[level];
				bid = orderBookEntry.Price;
				bidSize = orderBookEntry.Size;
				if (orderBookEntry.DateTime > dateTime)
				{
					dateTime = orderBookEntry.DateTime;
				}
			}
			if (level < this.askList.Count)
			{
				OrderBookEntry orderBookEntry2 = this.askList[level];
				ask = orderBookEntry2.Price;
				askSize = orderBookEntry2.Size;
				if (orderBookEntry2.DateTime > dateTime)
				{
					dateTime = orderBookEntry2.DateTime;
				}
			}
			return new Quote(dateTime, bid, bidSize, ask, askSize);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00003C80 File Offset: 0x00002C80
		public int GetBidVolume()
		{
			int num = 0;
			foreach (object obj in this.bidList)
			{
				OrderBookEntry orderBookEntry = (OrderBookEntry)obj;
				num += orderBookEntry.Size;
			}
			return num;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00003CE0 File Offset: 0x00002CE0
		public int GetAskVolume()
		{
			int num = 0;
			foreach (object obj in this.askList)
			{
				OrderBookEntry orderBookEntry = (OrderBookEntry)obj;
				num += orderBookEntry.Size;
			}
			return num;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00003D40 File Offset: 0x00002D40
		public double GetAvgBidPrice()
		{
			double num = 0.0;
			double num2 = 0.0;
			foreach (object obj in this.bidList)
			{
				OrderBookEntry orderBookEntry = (OrderBookEntry)obj;
				num += orderBookEntry.Price * (double)orderBookEntry.Size;
				num2 += (double)orderBookEntry.Size;
			}
			return num / num2;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00003DC8 File Offset: 0x00002DC8
		public double GetAvgAskPrice()
		{
			double num = 0.0;
			double num2 = 0.0;
			foreach (object obj in this.askList)
			{
				OrderBookEntry orderBookEntry = (OrderBookEntry)obj;
				num += orderBookEntry.Price * (double)orderBookEntry.Size;
				num2 += (double)orderBookEntry.Size;
			}
			return num / num2;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00003E50 File Offset: 0x00002E50
		public double GetAvgBidPrice(double qty)
		{
			if (this.bidList.Count == 0)
			{
				return 0.0;
			}
			double num = 0.0;
			double num2 = qty;
			foreach (object obj in this.bidList)
			{
				OrderBookEntry orderBookEntry = (OrderBookEntry)obj;
				if (num2 >= (double)orderBookEntry.Size)
				{
					num += orderBookEntry.Price * (double)orderBookEntry.Size;
					num2 -= (double)orderBookEntry.Size;
				}
				else
				{
					num += orderBookEntry.Price * num2;
					num2 = 0.0;
				}
				if (num2 <= 0.0)
				{
					break;
				}
			}
			if (num2 > 0.0)
			{
				num += this.bidList[this.bidList.Count - 1].Price * num2;
			}
			num /= qty;
			return num;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00003F44 File Offset: 0x00002F44
		public double GetAvgAskPrice(double qty)
		{
			if (this.askList.Count == 0)
			{
				return 0.0;
			}
			double num = 0.0;
			double num2 = qty;
			foreach (object obj in this.askList)
			{
				OrderBookEntry orderBookEntry = (OrderBookEntry)obj;
				if (num2 >= (double)orderBookEntry.Size)
				{
					num += orderBookEntry.Price * (double)orderBookEntry.Size;
					num2 -= (double)orderBookEntry.Size;
				}
				else
				{
					num += orderBookEntry.Price * num2;
					num2 = 0.0;
				}
				if (num2 <= 0.0)
				{
					break;
				}
			}
			if (num2 > 0.0)
			{
				num += this.askList[this.askList.Count - 1].Price * num2;
			}
			num /= qty;
			return num;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00004038 File Offset: 0x00003038
		private void EmitChanged(MDSide side, MDOperation operation, int position)
		{
			if (this.Changed != null)
			{
				this.Changed(this, new OrderBookEventArgs(side, operation, position));
			}
		}

		// Token: 0x0400003D RID: 61
		private OrderBookEntryList bidList;

		// Token: 0x0400003E RID: 62
		private OrderBookEntryList askList;
	}
}
