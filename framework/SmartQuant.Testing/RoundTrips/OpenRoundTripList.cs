using System;
using System.Collections;
using SmartQuant.Instruments;

namespace SmartQuant.Testing.RoundTrips
{
	// Token: 0x02000006 RID: 6
	public class OpenRoundTripList : IEnumerable
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00002928 File Offset: 0x00001928
		public int Count
		{
			get
			{
				return this.list.Count;
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002935 File Offset: 0x00001935
		public OpenRoundTripList()
		{
			this.Init();
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002943 File Offset: 0x00001943
		private void Init()
		{
			this.hashtable = new Hashtable();
			this.list = new ArrayList();
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0000295C File Offset: 0x0000195C
		private void InsertRoundTrip(RoundTrip roundTrip)
		{
			DateTime entryDateTime = roundTrip.EntryDateTime;
			int num = 0;
			int num2 = 0;
			int num3 = this.list.Count - 1;
			bool flag = true;
			while (flag)
			{
				if (num3 < num2)
				{
					if (num2 == 0)
					{
						this.list.Insert(0, roundTrip);
						return;
					}
					this.list.Insert(this.list.Count, roundTrip);
					return;
				}
				else
				{
					num = (num2 + num3) / 2;
					if ((this.list[num] as RoundTrip).EntryDateTime == entryDateTime && (num + 1 == this.list.Count || (this.list[num + 1] as RoundTrip).EntryDateTime > entryDateTime))
					{
						flag = false;
					}
					else if ((this.list[num] as RoundTrip).EntryDateTime > entryDateTime)
					{
						num3 = num - 1;
					}
					else if ((this.list[num] as RoundTrip).EntryDateTime <= entryDateTime)
					{
						num2 = num + 1;
					}
				}
			}
			this.list.Insert(num, roundTrip);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002A6A File Offset: 0x00001A6A
		public void Add(RoundTrip roundTrip)
		{
			this.hashtable.Add(roundTrip.Instrument, roundTrip);
			this.InsertRoundTrip(roundTrip);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002A85 File Offset: 0x00001A85
		public void Remove(RoundTrip roundTrip)
		{
			this.hashtable.Remove(roundTrip.Instrument);
			this.list.Remove(roundTrip);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002AA4 File Offset: 0x00001AA4
		public void Remove(Instrument instrument)
		{
			if (this.hashtable.Contains(instrument))
			{
				RoundTrip obj = this.hashtable[instrument] as RoundTrip;
				this.list.Remove(obj);
				this.hashtable.Remove(instrument);
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002AE9 File Offset: 0x00001AE9
		public void Clear()
		{
			this.hashtable.Clear();
			this.list.Clear();
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002B01 File Offset: 0x00001B01
		public bool Contains(RoundTrip roundTrip)
		{
			return this.list.Contains(roundTrip);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002B0F File Offset: 0x00001B0F
		public bool Contains(Instrument instrument)
		{
			return this.hashtable.Contains(instrument);
		}

		// Token: 0x1700000C RID: 12
		public RoundTrip this[int index]
		{
			get
			{
				return this.list[index] as RoundTrip;
			}
		}

		// Token: 0x1700000D RID: 13
		public RoundTrip this[Instrument instrument]
		{
			get
			{
				return this.hashtable[instrument] as RoundTrip;
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002B43 File Offset: 0x00001B43
		public IEnumerator GetEnumerator()
		{
			return this.list.GetEnumerator();
		}

		// Token: 0x04000010 RID: 16
		private Hashtable hashtable;

		// Token: 0x04000011 RID: 17
		private ArrayList list;
	}
}
