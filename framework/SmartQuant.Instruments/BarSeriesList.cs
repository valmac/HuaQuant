using System;
using System.Collections;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Instruments
{
	// Token: 0x0200001E RID: 30
	public class BarSeriesList : ICollection, IEnumerable
	{
		// Token: 0x14000013 RID: 19
		// (add) Token: 0x060001D1 RID: 465 RVA: 0x00006696 File Offset: 0x00005696
		// (remove) Token: 0x060001D2 RID: 466 RVA: 0x000066AF File Offset: 0x000056AF
		public event BarSeriesEventHandler BarSeriesAdded;

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x060001D3 RID: 467 RVA: 0x000066C8 File Offset: 0x000056C8
		// (remove) Token: 0x060001D4 RID: 468 RVA: 0x000066E1 File Offset: 0x000056E1
		public event BarSeriesEventHandler BarSeriesRenamed;

		// Token: 0x060001D5 RID: 469 RVA: 0x000066FA File Offset: 0x000056FA
		internal BarSeriesList()
		{
			this.series = new Hashtable();
			this.defaultSeries = new Hashtable();
			this.defaultBarType = BarType.Time;
			this.defaultBarSize = 86400L;
			this.defaultsAreSet = false;
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x00006732 File Offset: 0x00005732
		public bool IsSynchronized
		{
			get
			{
				return this.series.IsSynchronized;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x0000673F File Offset: 0x0000573F
		public int Count
		{
			get
			{
				return this.series.Count;
			}
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0000674C File Offset: 0x0000574C
		public void CopyTo(Array array, int index)
		{
			this.series.CopyTo(array, index);
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x0000675B File Offset: 0x0000575B
		public object SyncRoot
		{
			get
			{
				return this.series.SyncRoot;
			}
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00006768 File Offset: 0x00005768
		public IEnumerator GetEnumerator()
		{
			Hashtable hashtable = new Hashtable();
			foreach (object obj in this.series)
			{
				DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
				Instrument key = dictionaryEntry.Key as Instrument;
				ArrayList arrayList = hashtable[key] as ArrayList;
				if (arrayList == null)
				{
					arrayList = new ArrayList();
					hashtable.Add(key, arrayList);
				}
				foreach (object obj2 in ((IEnumerable)dictionaryEntry.Value))
				{
					foreach (object obj3 in ((IEnumerable)((DictionaryEntry)obj2).Value))
					{
						arrayList.Add(((DictionaryEntry)obj3).Value);
					}
				}
			}
			foreach (object obj4 in this.defaultSeries)
			{
				DictionaryEntry dictionaryEntry2 = (DictionaryEntry)obj4;
				Instrument key2 = dictionaryEntry2.Key as Instrument;
				ArrayList arrayList2 = hashtable[key2] as ArrayList;
				if (arrayList2 == null)
				{
					arrayList2 = new ArrayList();
					hashtable.Add(key2, arrayList2);
				}
				arrayList2.Add(dictionaryEntry2.Value);
			}
			return hashtable.GetEnumerator();
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00006934 File Offset: 0x00005934
		internal void Clear()
		{
			this.series.Clear();
			this.defaultSeries.Clear();
			this.defaultsAreSet = false;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00006953 File Offset: 0x00005953
		internal void AddBar(Instrument instrument, Bar bar)
		{
			this[instrument, bar.BarType, bar.Size].Add(bar);
		}

		// Token: 0x17000062 RID: 98
		public BarSeries this[Instrument instrument, BarType barType, long barSize]
		{
			get
			{
				if (this.defaultsAreSet)
				{
					Hashtable seriesTable = this.GetSeriesTable(instrument, barType);
					BarSeries barSeries = seriesTable[barSize] as BarSeries;
					if (barSeries == null)
					{
						barSeries = new BarSeries(string.Format("{0} ({1} {2})", instrument.Symbol, barType, barSize));
						seriesTable.Add(barSize, barSeries);
						if (this.BarSeriesAdded != null)
						{
							this.BarSeriesAdded(this, new BarSeriesEventArgs(barSeries, instrument));
						}
					}
					return barSeries;
				}
				this.defaultBarType = barType;
				this.defaultBarSize = barSize;
				Hashtable hashtable = new Hashtable(this.defaultSeries);
				foreach (object obj in this.defaultSeries)
				{
					DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
					Instrument instrument2 = dictionaryEntry.Key as Instrument;
					BarSeries barSeries2 = dictionaryEntry.Value as BarSeries;
					barSeries2.Name = string.Format("{0} ({1} {2})", instrument2.Symbol, barType, barSize);
					Hashtable seriesTable2 = this.GetSeriesTable(instrument2, barType);
					seriesTable2.Add(barSize, barSeries2);
				}
				this.defaultSeries.Clear();
				this.defaultsAreSet = true;
				BarSeries result = this[instrument, barType, barSize];
				foreach (object obj2 in hashtable)
				{
					DictionaryEntry dictionaryEntry2 = (DictionaryEntry)obj2;
					if (this.BarSeriesRenamed != null)
					{
						this.BarSeriesRenamed(this, new BarSeriesEventArgs(dictionaryEntry2.Value as BarSeries, dictionaryEntry2.Key as Instrument));
					}
				}
				return result;
			}
		}

		// Token: 0x17000063 RID: 99
		public BarSeries this[Instrument instrument]
		{
			get
			{
				if (this.defaultsAreSet)
				{
					return this[instrument, this.defaultBarType, this.defaultBarSize];
				}
				BarSeries barSeries = this.defaultSeries[instrument] as BarSeries;
				if (barSeries == null)
				{
					barSeries = new BarSeries(instrument.Symbol);
					this.defaultSeries.Add(instrument, barSeries);
					if (this.BarSeriesAdded != null)
					{
						this.BarSeriesAdded(this, new BarSeriesEventArgs(barSeries, instrument));
					}
				}
				return barSeries;
			}
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00006BB8 File Offset: 0x00005BB8
		private Hashtable GetSeriesTable(Instrument instrument, BarType barType)
		{
			Hashtable hashtable = this.series[instrument] as Hashtable;
			if (hashtable == null)
			{
				hashtable = new Hashtable();
				this.series.Add(instrument, hashtable);
			}
			Hashtable hashtable2 = hashtable[barType] as Hashtable;
			if (hashtable2 == null)
			{
				hashtable2 = new Hashtable();
				hashtable.Add(barType, hashtable2);
			}
			return hashtable2;
		}

		// Token: 0x04000074 RID: 116
		private Hashtable series;

		// Token: 0x04000075 RID: 117
		private Hashtable defaultSeries;

		// Token: 0x04000076 RID: 118
		private BarType defaultBarType;

		// Token: 0x04000077 RID: 119
		private long defaultBarSize;

		// Token: 0x04000078 RID: 120
		private bool defaultsAreSet;
	}
}
