using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using SmartQuant.Data;
using SmartQuant.FIX;

namespace SmartQuant.Providers
{
	// Token: 0x02000019 RID: 25
	public class BarFactory : IBarFactory
	{
		// Token: 0x0600008D RID: 141 RVA: 0x00002418 File Offset: 0x00001418
		public BarFactory(bool enabled)
		{
			this.enabled = enabled;
			this.input = BarFactoryInput.Trade;
			this.lastPriceSizes = new Hashtable();
			this.items = new BarFactoryItemList();
			this.items.Add(new BarFactoryItem());
			this.instruments = new Hashtable();
			this.times = new ArrayList();
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002476 File Offset: 0x00001476
		public BarFactory() : this(true)
		{
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600008F RID: 143 RVA: 0x0000247F File Offset: 0x0000147F
		// (set) Token: 0x06000090 RID: 144 RVA: 0x00002487 File Offset: 0x00001487
		[DefaultValue(true)]
		[Category("Status")]
		public bool Enabled
		{
			get
			{
				return this.enabled;
			}
			set
			{
				this.enabled = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00002490 File Offset: 0x00001490
		// (set) Token: 0x06000092 RID: 146 RVA: 0x00002498 File Offset: 0x00001498
		[DefaultValue(BarFactoryInput.Trade)]
		public BarFactoryInput Input
		{
			get
			{
				return this.input;
			}
			set
			{
				this.input = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000093 RID: 147 RVA: 0x000024A1 File Offset: 0x000014A1
		[Category("Items")]
		public BarFactoryItemList Items
		{
			get
			{
				return this.items;
			}
		}

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x06000094 RID: 148 RVA: 0x000024A9 File Offset: 0x000014A9
		// (remove) Token: 0x06000095 RID: 149 RVA: 0x000024C2 File Offset: 0x000014C2
		public event BarEventHandler NewBar;

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x06000096 RID: 150 RVA: 0x000024DB File Offset: 0x000014DB
		// (remove) Token: 0x06000097 RID: 151 RVA: 0x000024F4 File Offset: 0x000014F4
		public event BarEventHandler NewBarOpen;

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x06000098 RID: 152 RVA: 0x0000250D File Offset: 0x0000150D
		// (remove) Token: 0x06000099 RID: 153 RVA: 0x00002526 File Offset: 0x00001526
		public event BarSliceEventHandler NewBarSlice;

		// Token: 0x0600009A RID: 154 RVA: 0x0000253F File Offset: 0x0000153F
		public void OnNewTrade(IFIXInstrument instrument, Trade trade)
		{
			if (!this.enabled)
			{
				return;
			}
			if (this.input == BarFactoryInput.Trade)
			{
				this.OnNewMarketData(instrument, trade.DateTime, trade.Price, trade.Size);
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000256C File Offset: 0x0000156C
		public void OnNewQuote(IFIXInstrument instrument, Quote quote)
		{
			if (!this.enabled)
			{
				return;
			}
			double num;
			int num2;
			switch (this.input)
			{
			case BarFactoryInput.Bid:
				num = quote.Bid;
				num2 = quote.BidSize;
				break;
			case BarFactoryInput.Ask:
				num = quote.Ask;
				num2 = quote.AskSize;
				break;
			case BarFactoryInput.BidAsk:
				this.OnNewMarketData(instrument, quote.DateTime, quote.Bid, quote.BidSize);
				this.OnNewMarketData(instrument, quote.DateTime, quote.Ask, quote.AskSize);
				return;
			case BarFactoryInput.Middle:
				num = (quote.Ask + quote.Bid) / 2.0;
				num2 = (quote.AskSize + quote.BidSize) / 2;
				break;
			case BarFactoryInput.Spread:
				num = quote.Ask - quote.Bid;
				num2 = 0;
				break;
			default:
				return;
			}
			BarFactory.PriceSizeRecord priceSizeRecord = this.lastPriceSizes[instrument] as BarFactory.PriceSizeRecord;
			if (priceSizeRecord == null)
			{
				priceSizeRecord = new BarFactory.PriceSizeRecord();
				this.lastPriceSizes.Add(instrument, priceSizeRecord);
			}
			if (num != priceSizeRecord.LastPrice || num2 != priceSizeRecord.LastSize)
			{
				this.OnNewMarketData(instrument, quote.DateTime, num, num2);
				priceSizeRecord.LastPrice = num;
				priceSizeRecord.LastSize = num2;
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000268A File Offset: 0x0000168A
		public void Reset()
		{
			this.instruments.Clear();
			this.times.Clear();
			this.lastPriceSizes.Clear();
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000026B0 File Offset: 0x000016B0
		private void OnNewMarketData(IFIXInstrument instrument, DateTime datetime, double price, int size)
		{
			List<BarFactory.BarEvent> list = new List<BarFactory.BarEvent>();
			lock (this)
			{
				foreach (object obj in this.items)
				{
					BarFactoryItem barFactoryItem = (BarFactoryItem)obj;
					if (barFactoryItem.Enabled)
					{
						Hashtable hashtable = this.instruments[instrument] as Hashtable;
						if (hashtable == null)
						{
							hashtable = new Hashtable();
							this.instruments.Add(instrument, hashtable);
						}
						SortedList sortedList = hashtable[barFactoryItem.BarType] as SortedList;
						if (sortedList == null)
						{
							sortedList = new SortedList();
							hashtable.Add(barFactoryItem.BarType, sortedList);
						}
						switch (barFactoryItem.BarType)
						{
						case BarType.Time:
						{
							Bar bar = sortedList[barFactoryItem.BarSize] as Bar;
							if (bar == null)
							{
								DateTime barDateTime = this.GetBarDateTime(datetime, barFactoryItem.BarSize);
								bar = new Bar(BarType.Time, barFactoryItem.BarSize, barDateTime, barDateTime, price, price, price, price, (long)size, 0L);
								sortedList.Add(barFactoryItem.BarSize, bar);
								list.Add(new BarFactory.BarEvent(BarFactory.BarEventType.Open, bar));
							}
							else
							{
								bar.EndTime = datetime;
								if (price > bar.High)
								{
									bar.High = price;
								}
								if (price < bar.Low)
								{
									bar.Low = price;
								}
								bar.Close = price;
								bar.Volume += (long)size;
							}
							break;
						}
						case BarType.Tick:
						{
							BarFactory.BarData barData = sortedList[barFactoryItem.BarSize] as BarFactory.BarData;
							if (barData == null)
							{
								barData = new BarFactory.BarData();
								barData.Bar = new Bar(BarType.Tick, barFactoryItem.BarSize, datetime, datetime, price, price, price, price, (long)size, 0L);
								sortedList.Add(barFactoryItem.BarSize, barData);
								list.Add(new BarFactory.BarEvent(BarFactory.BarEventType.Open, barData.Bar));
							}
							else
							{
								barData.Bar.EndTime = datetime;
								if (price > barData.Bar.High)
								{
									barData.Bar.High = price;
								}
								if (price < barData.Bar.Low)
								{
									barData.Bar.Low = price;
								}
								barData.Bar.Close = price;
								barData.Bar.Volume += (long)size;
								barData.TickCount += 1L;
							}
							if (barData.TickCount == barFactoryItem.BarSize)
							{
								list.Add(new BarFactory.BarEvent(BarFactory.BarEventType.New, barData.Bar));
								sortedList.Remove(barFactoryItem.BarSize);
							}
							break;
						}
						case BarType.Volume:
						{
							Bar bar2 = sortedList[barFactoryItem.BarSize] as Bar;
							if (bar2 == null)
							{
								bar2 = new Bar(BarType.Volume, barFactoryItem.BarSize, datetime, datetime, price, price, price, price, (long)size, 0L);
								sortedList.Add(barFactoryItem.BarSize, bar2);
								list.Add(new BarFactory.BarEvent(BarFactory.BarEventType.Open, bar2));
							}
							else
							{
								bar2.EndTime = datetime;
								if (price > bar2.High)
								{
									bar2.High = price;
								}
								if (price < bar2.Low)
								{
									bar2.Low = price;
								}
								bar2.Close = price;
								bar2.Volume += (long)size;
							}
							if (bar2.Volume >= barFactoryItem.BarSize)
							{
								list.Add(new BarFactory.BarEvent(BarFactory.BarEventType.New, bar2));
								sortedList.Remove(barFactoryItem.BarSize);
							}
							break;
						}
						case BarType.Dynamic:
							break;
						default:
							throw new NotSupportedException("The bar factory does not support bar type - " + barFactoryItem.BarType.ToString());
						}
						if (sortedList.Count == 0)
						{
							hashtable.Remove(barFactoryItem.BarType);
							if (hashtable.Count == 0)
							{
								this.instruments.Remove(instrument);
							}
						}
					}
				}
			}
			foreach (BarFactory.BarEvent barEvent in list)
			{
				switch (barEvent.BarEventType)
				{
				case BarFactory.BarEventType.Open:
				{
					Bar bar3 = barEvent.Bar;
					this.EmitNewBarOpen(bar3, instrument);
					if (bar3.BarType == BarType.Time)
					{
						this.AddReminder(bar3.BeginTime.AddSeconds((double)bar3.Size));
					}
					break;
				}
				case BarFactory.BarEventType.New:
					this.EmitNewBar(barEvent.Bar, instrument);
					break;
				}
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002B6C File Offset: 0x00001B6C
		public override string ToString()
		{
			return "Standard Bar Factory";
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002B73 File Offset: 0x00001B73
		private void AddReminder(DateTime datetime)
		{
			if (!this.times.Contains(datetime))
			{
				Clock.AddReminder(new ReminderEventHandler(this.OnReminder), datetime, null);
				this.times.Add(datetime);
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002BAD File Offset: 0x00001BAD
		private void EmitNewBar(Bar bar, IFIXInstrument instrument)
		{
			bar.IsComplete = true;
			if (this.NewBar != null)
			{
				this.NewBar(null, new BarEventArgs(bar, instrument, null));
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002BD2 File Offset: 0x00001BD2
		private void EmitNewBarOpen(Bar bar, IFIXInstrument instrument)
		{
			if (this.NewBarOpen != null)
			{
				this.NewBarOpen(null, new BarEventArgs(bar, instrument, null));
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002BF0 File Offset: 0x00001BF0
		private void EmitNewBarSlice(long barSize)
		{
			if (this.NewBarSlice != null)
			{
				this.NewBarSlice(null, new BarSliceEventArgs(barSize, null));
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002C10 File Offset: 0x00001C10
		private void OnReminder(ReminderEventArgs args)
		{
			SortedList sortedList = new SortedList();
			lock (this)
			{
				foreach (object obj in new Hashtable(this.instruments))
				{
					DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
					IFIXInstrument key = (IFIXInstrument)dictionaryEntry.Key;
					Hashtable hashtable = (Hashtable)dictionaryEntry.Value;
					SortedList sortedList2 = hashtable[BarType.Time] as SortedList;
					if (sortedList2 != null)
					{
						foreach (object obj2 in new SortedList(sortedList2))
						{
							DictionaryEntry dictionaryEntry2 = (DictionaryEntry)obj2;
							long num = (long)dictionaryEntry2.Key;
							Bar bar = (Bar)dictionaryEntry2.Value;
							if (bar.BeginTime.AddSeconds((double)num) == args.SignalTime)
							{
								bar.EndTime = args.SignalTime;
								ArrayList arrayList = sortedList[num] as ArrayList;
								if (arrayList == null)
								{
									arrayList = new ArrayList();
									sortedList.Add(num, arrayList);
								}
								arrayList.Add(new KeyValuePair<IFIXInstrument, Bar>(key, bar));
								sortedList2.Remove(num);
							}
						}
						if (sortedList2.Count == 0)
						{
							hashtable.Remove(BarType.Time);
						}
						if (hashtable.Count == 0)
						{
							this.instruments.Remove(key);
						}
					}
				}
			}
			foreach (object obj3 in sortedList)
			{
				DictionaryEntry dictionaryEntry3 = (DictionaryEntry)obj3;
				long barSize = (long)dictionaryEntry3.Key;
				ArrayList arrayList2 = (ArrayList)dictionaryEntry3.Value;
				foreach (object obj4 in arrayList2)
				{
					KeyValuePair<IFIXInstrument, Bar> keyValuePair = (KeyValuePair<IFIXInstrument, Bar>)obj4;
					this.EmitNewBar(keyValuePair.Value, keyValuePair.Key);
				}
				this.EmitNewBarSlice(barSize);
			}
			this.times.Remove(args.SignalTime);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00002EF8 File Offset: 0x00001EF8
		private DateTime GetBarDateTime(DateTime tradeDateTime, long barSize)
		{
			long num = (long)tradeDateTime.TimeOfDay.TotalSeconds / barSize * barSize;
			return tradeDateTime.Date.AddSeconds((double)num);
		}

		// Token: 0x04000034 RID: 52
		private const string CATEGORY_STATUS = "Status";

		// Token: 0x04000035 RID: 53
		private const string CATEGORY_ITEMS = "Items";

		// Token: 0x04000036 RID: 54
		private const bool DEFAULT_ENABLED = true;

		// Token: 0x04000037 RID: 55
		internal const BarFactoryInput DEFAULT_INPUT = BarFactoryInput.Trade;

		// Token: 0x04000038 RID: 56
		private BarFactoryItemList items;

		// Token: 0x04000039 RID: 57
		private Hashtable instruments;

		// Token: 0x0400003A RID: 58
		private ArrayList times;

		// Token: 0x0400003B RID: 59
		private bool enabled;

		// Token: 0x0400003C RID: 60
		private BarFactoryInput input;

		// Token: 0x0400003D RID: 61
		private Hashtable lastPriceSizes;

		// Token: 0x0200001A RID: 26
		private class BarData
		{
			// Token: 0x04000041 RID: 65
			public Bar Bar;

			// Token: 0x04000042 RID: 66
			public long TickCount = 1L;
		}

		// Token: 0x0200001B RID: 27
		private class PriceSizeRecord
		{
			// Token: 0x04000043 RID: 67
			public double LastPrice;

			// Token: 0x04000044 RID: 68
			public int LastSize;
		}

		// Token: 0x0200001C RID: 28
		private enum BarEventType
		{
			// Token: 0x04000046 RID: 70
			Open,
			// Token: 0x04000047 RID: 71
			New
		}

		// Token: 0x0200001D RID: 29
		private class BarEvent
		{
			// Token: 0x060000A7 RID: 167 RVA: 0x00002F43 File Offset: 0x00001F43
			public BarEvent(BarFactory.BarEventType barEventType, Bar bar)
			{
				this.BarEventType = barEventType;
				this.Bar = bar;
			}

			// Token: 0x04000048 RID: 72
			public BarFactory.BarEventType BarEventType;

			// Token: 0x04000049 RID: 73
			public Bar Bar;
		}
	}
}
