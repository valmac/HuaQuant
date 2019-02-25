using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Data;

namespace SmartQuant.Series
{
	// Token: 0x02000008 RID: 8
	[Serializable]
	public class TimeSeries : IEnumerable
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000008 RID: 8 RVA: 0x00002076 File Offset: 0x00001076
		// (remove) Token: 0x06000009 RID: 9 RVA: 0x0000208F File Offset: 0x0000108F
		public event ItemAddedEventHandler ItemAdded;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600000A RID: 10 RVA: 0x000020A8 File Offset: 0x000010A8
		// (remove) Token: 0x0600000B RID: 11 RVA: 0x000020C1 File Offset: 0x000010C1
		public event EventHandler Cleared;

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000020DA File Offset: 0x000010DA
		// (set) Token: 0x0600000D RID: 13 RVA: 0x000020E2 File Offset: 0x000010E2
		[Description("")]
		[Category("Description")]
		public string Name
		{
			get
			{
				return this.fName;
			}
			set
			{
				this.fName = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000020EB File Offset: 0x000010EB
		// (set) Token: 0x0600000F RID: 15 RVA: 0x000020F3 File Offset: 0x000010F3
		[Category("Description")]
		[Description("")]
		public string Title
		{
			get
			{
				return this.fTitle;
			}
			set
			{
				this.fTitle = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000020FC File Offset: 0x000010FC
		// (set) Token: 0x06000011 RID: 17 RVA: 0x00002104 File Offset: 0x00001104
		[Category("Chart")]
		[IndicatorParameter(1000000)]
		[Description("")]
		public Color Color
		{
			get
			{
				return this.fColor;
			}
			set
			{
				this.fColor = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000012 RID: 18 RVA: 0x0000210D File Offset: 0x0000110D
		[Browsable(false)]
		public virtual int Count
		{
			get
			{
				return this.fArray.Count;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000013 RID: 19 RVA: 0x0000211A File Offset: 0x0000111A
		[Browsable(false)]
		public virtual DateTime FirstDateTime
		{
			get
			{
				if (this.Count <= 0)
				{
					throw new ApplicationException("Array has no elements");
				}
				return this.GetDateTime(0);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002137 File Offset: 0x00001137
		[Browsable(false)]
		public virtual DateTime LastDateTime
		{
			get
			{
				if (this.Count <= 0)
				{
					throw new ApplicationException("Array has no elements");
				}
				return this.GetDateTime(this.Count - 1);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000015 RID: 21 RVA: 0x0000215C File Offset: 0x0000115C
		[Browsable(false)]
		public virtual DateTime FirstDate
		{
			get
			{
				return this.FirstDateTime.Date;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00002178 File Offset: 0x00001178
		[Browsable(false)]
		public virtual DateTime LastDate
		{
			get
			{
				return this.LastDateTime.Date;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002193 File Offset: 0x00001193
		[Browsable(false)]
		public virtual int FirstIndex
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00002196 File Offset: 0x00001196
		[Browsable(false)]
		public virtual int LastIndex
		{
			get
			{
				return this.Count - 1;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000019 RID: 25 RVA: 0x000021A0 File Offset: 0x000011A0
		public virtual object First
		{
			get
			{
				if (this.Count <= 0)
				{
					throw new ApplicationException("Array has no elements");
				}
				return this[0];
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600001A RID: 26 RVA: 0x000021BD File Offset: 0x000011BD
		public virtual object Last
		{
			get
			{
				if (this.Count <= 0)
				{
					throw new ApplicationException("Array has no elements");
				}
				return this[this.Count - 1];
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600001B RID: 27 RVA: 0x000021E1 File Offset: 0x000011E1
		[Browsable(false)]
		public virtual int RealCount
		{
			get
			{
				return this.Count;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600001C RID: 28 RVA: 0x000021E9 File Offset: 0x000011E9
		[Browsable(false)]
		public ArrayList Children
		{
			get
			{
				return this.fChildren;
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000021F4 File Offset: 0x000011F4
		public TimeSeries(string name, string title)
		{
			this.fName = name;
			this.fTitle = title;
			this.fArray = new MemorySeries<object>();
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000225A File Offset: 0x0000125A
		public TimeSeries(string name) : this(name, "")
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002268 File Offset: 0x00001268
		public TimeSeries() : this("")
		{
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00002275 File Offset: 0x00001275
		// (set) Token: 0x06000021 RID: 33 RVA: 0x0000227D File Offset: 0x0000127D
		public IDataSeries DataSeries
		{
			get
			{
				return this.fArray;
			}
			set
			{
				this.fArray = value;
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002286 File Offset: 0x00001286
		public virtual TimeSeries Clone()
		{
			return this.Clone(0, this.Count - 1);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002298 File Offset: 0x00001298
		public virtual TimeSeries Clone(int index1, int index2)
		{
			TimeSeries timeSeries = base.GetType().GetConstructor(new Type[0]).Invoke(new object[0]) as TimeSeries;
			timeSeries.fName = this.fName;
			timeSeries.fTitle = this.fTitle;
			for (int i = index1; i <= index2; i++)
			{
				timeSeries.Add(this.GetDateTime(i), this[i]);
			}
			return timeSeries;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002300 File Offset: 0x00001300
		public virtual TimeSeries Clone(DateTime dateTime1, DateTime dateTime2)
		{
			int num = this.GetIndex(dateTime1, EIndexOption.Next);
			int num2 = this.GetIndex(dateTime2, EIndexOption.Prev);
			if (num == -1)
			{
				num = 0;
			}
			if (num2 == -1)
			{
				num2 = 0;
			}
			return this.Clone(num, num2);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002333 File Offset: 0x00001333
		public virtual void Clear()
		{
			this.fArray.Clear();
			this.fChanged = true;
			if (this.Cleared != null)
			{
				this.Cleared(this, EventArgs.Empty);
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002360 File Offset: 0x00001360
		public bool Contains(DateTime dateTime)
		{
			return this.fArray.Contains(dateTime);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0000236E File Offset: 0x0000136E
		public bool Contains(int index)
		{
			return index >= 0 && index <= this.Count - 1;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002382 File Offset: 0x00001382
		public void Add(DateTime dateTime, object obj)
		{
			if (this.fArray.Contains(dateTime))
			{
				this.fArray.Remove(dateTime);
			}
			this.fArray.Add(dateTime, obj);
			this.fChanged = true;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000023B2 File Offset: 0x000013B2
		public void Remove(DateTime dateTime)
		{
			this.fArray.Remove(dateTime);
			this.fChanged = true;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000023C7 File Offset: 0x000013C7
		public virtual void Remove(int index)
		{
			this.fArray.RemoveAt(index);
			this.fChanged = true;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000023DC File Offset: 0x000013DC
		public virtual DateTime GetDateTime(int index)
		{
			return this.fArray.DateTimeAt(index);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000023EA File Offset: 0x000013EA
		public virtual int GetIndex(DateTime dateTime)
		{
			return this.GetIndex(dateTime, this.fIndexOption);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000023FC File Offset: 0x000013FC
		public virtual int GetIndex(DateTime dateTime, EIndexOption option)
		{
			int num = this.fArray.IndexOf(dateTime);
			if (num == -1 && option != EIndexOption.Null)
			{
				switch (option)
				{
				case EIndexOption.Next:
					num = this.fArray.IndexOf(dateTime, SearchOption.Next);
					break;
				case EIndexOption.Prev:
					num = this.fArray.IndexOf(dateTime, SearchOption.Prev);
					break;
				}
			}
			return num;
		}

		// Token: 0x17000011 RID: 17
		public virtual object this[int index]
		{
			get
			{
				return this.fArray[index];
			}
		}

		// Token: 0x17000012 RID: 18
		public virtual double this[int index, int row]
		{
			get
			{
				return (double)this.fArray[index];
			}
		}

		// Token: 0x17000013 RID: 19
		public virtual double this[int index, BarData barData]
		{
			get
			{
				return this[index, (int)barData];
			}
		}

		// Token: 0x17000014 RID: 20
		public object this[DateTime dateTime]
		{
			get
			{
				int index = this.GetIndex(dateTime);
				if (index != -1)
				{
					return this.fArray[index];
				}
				return null;
			}
		}

		// Token: 0x17000015 RID: 21
		public object this[DateTime dateTime, EIndexOption option]
		{
			get
			{
				int index = this.GetIndex(dateTime, option);
				if (index != -1)
				{
					return this.fArray[index];
				}
				return null;
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000024CC File Offset: 0x000014CC
		public virtual double GetMin()
		{
			return this.GetMin(0);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000024D5 File Offset: 0x000014D5
		public virtual double GetMax()
		{
			return this.GetMax(0);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000024DE File Offset: 0x000014DE
		public virtual int GetMinIndex()
		{
			return this.GetMinIndex(0);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000024E7 File Offset: 0x000014E7
		public virtual int GetMaxIndex()
		{
			return this.GetMaxIndex(0);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000024F0 File Offset: 0x000014F0
		public virtual DateTime GetMinDateTime()
		{
			return this.GetDateTime(this.GetMinIndex());
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000024FE File Offset: 0x000014FE
		public virtual DateTime GetMaxDateTime()
		{
			return this.GetDateTime(this.GetMaxIndex());
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000250C File Offset: 0x0000150C
		public virtual double GetMin(int index1, int index2)
		{
			return this.GetMin(index1, index2, 0);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002517 File Offset: 0x00001517
		public virtual double GetMax(int index1, int index2)
		{
			return this.GetMax(index1, index2, 0);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002522 File Offset: 0x00001522
		public virtual int GetMinIndex(int index1, int index2)
		{
			return this.GetMinIndex(index1, index2, 0);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0000252D File Offset: 0x0000152D
		public virtual int GetMaxIndex(int index1, int index2)
		{
			return this.GetMaxIndex(index1, index2, 0);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002538 File Offset: 0x00001538
		public virtual double GetMin(DateTime dateTime1, DateTime dateTime2)
		{
			return this.GetMin(dateTime1, dateTime2, 0);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002543 File Offset: 0x00001543
		public virtual double GetMax(DateTime dateTime1, DateTime dateTime2)
		{
			return this.GetMax(dateTime1, dateTime2, 0);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000254E File Offset: 0x0000154E
		public virtual int GetMinIndex(DateTime dateTime1, DateTime dateTime2)
		{
			return this.GetMinIndex(dateTime1, dateTime2, 0);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002559 File Offset: 0x00001559
		public virtual int GetMaxIndex(DateTime dateTime1, DateTime dateTime2)
		{
			return this.GetMaxIndex(dateTime1, dateTime2, 0);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002564 File Offset: 0x00001564
		public virtual double GetMin(int row)
		{
			return this.GetMin(0, this.Count - 1, row);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002576 File Offset: 0x00001576
		public virtual double GetMax(int row)
		{
			return this.GetMax(0, this.Count - 1, row);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002588 File Offset: 0x00001588
		public virtual int GetMinIndex(int row)
		{
			return this.GetMinIndex(0, this.Count - 1, row);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0000259A File Offset: 0x0000159A
		public virtual int GetMaxIndex(int row)
		{
			return this.GetMaxIndex(0, this.Count - 1, row);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000025AC File Offset: 0x000015AC
		public virtual double GetMin(int index1, int index2, int row)
		{
			return double.NaN;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000025B7 File Offset: 0x000015B7
		public virtual double GetMax(int index1, int index2, int row)
		{
			return double.NaN;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000025C2 File Offset: 0x000015C2
		public virtual int GetMinIndex(int index1, int index2, int row)
		{
			return -1;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000025C5 File Offset: 0x000015C5
		public virtual int GetMaxIndex(int index1, int index2, int row)
		{
			return -1;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000025C8 File Offset: 0x000015C8
		public virtual double GetMin(DateTime dateTime1, DateTime dateTime2, int row)
		{
			if (this.Count <= 0)
			{
				throw new ApplicationException("Can not find min value. Array is empty.");
			}
			if (dateTime1 > dateTime2)
			{
				throw new ApplicationException("dateTime1 must be smaller than dateTime2");
			}
			int index = this.GetIndex(dateTime1, EIndexOption.Next);
			int index2 = this.GetIndex(dateTime2, EIndexOption.Prev);
			if (index == -1)
			{
				throw new ApplicationException("dateTime1 is out of range");
			}
			if (index2 == -1)
			{
				throw new ApplicationException("dateTime2 is out of range");
			}
			return this.GetMin(index, index2, row);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002638 File Offset: 0x00001638
		public virtual double GetMax(DateTime dateTime1, DateTime dateTime2, int row)
		{
			if (this.Count <= 0)
			{
				throw new ApplicationException("Can not find max value. Array is empty.");
			}
			if (dateTime1 > dateTime2)
			{
				throw new ApplicationException("dateTime1 must be smaller than dateTime2");
			}
			int index = this.GetIndex(dateTime1, EIndexOption.Next);
			int index2 = this.GetIndex(dateTime2, EIndexOption.Prev);
			if (index == -1)
			{
				throw new ApplicationException("dateTime1 is out of range");
			}
			if (index2 == -1)
			{
				throw new ApplicationException("dateTime2 is out of range");
			}
			return this.GetMax(index, index2, row);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000026A8 File Offset: 0x000016A8
		public virtual int GetMinIndex(DateTime dateTime1, DateTime dateTime2, int row)
		{
			if (this.Count <= 0)
			{
				throw new ApplicationException("Can not find min value. Array is empty.");
			}
			if (dateTime1 >= dateTime2)
			{
				throw new ApplicationException("dateTime1 must be smaller than dateTime2");
			}
			int index = this.GetIndex(dateTime1, EIndexOption.Next);
			int index2 = this.GetIndex(dateTime2, EIndexOption.Prev);
			if (index == -1)
			{
				throw new ApplicationException("dateTime1 is out of range");
			}
			if (index2 == -1)
			{
				throw new ApplicationException("dateTime2 is out of range");
			}
			return this.GetMinIndex(index, index2, row);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002718 File Offset: 0x00001718
		public virtual int GetMaxIndex(DateTime dateTime1, DateTime dateTime2, int row)
		{
			if (this.Count <= 0)
			{
				throw new ApplicationException("Can not find max value. Array is empty.");
			}
			if (dateTime1 >= dateTime2)
			{
				throw new ApplicationException("dateTime1 must be smaller than dateTime2");
			}
			int index = this.GetIndex(dateTime1, EIndexOption.Next);
			int index2 = this.GetIndex(dateTime2, EIndexOption.Prev);
			if (index == -1)
			{
				throw new ApplicationException("dateTime1 is out of range");
			}
			if (index2 == -1)
			{
				throw new ApplicationException("dateTime2 is out of range");
			}
			return this.GetMaxIndex(index, index2, row);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002786 File Offset: 0x00001786
		public virtual double GetMin(BarData barData)
		{
			return this.GetMin((int)barData);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x0000278F File Offset: 0x0000178F
		public virtual double GetMax(BarData barData)
		{
			return this.GetMax((int)barData);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002798 File Offset: 0x00001798
		public virtual int GetMinIndex(BarData barData)
		{
			return this.GetMinIndex((int)barData);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000027A1 File Offset: 0x000017A1
		public virtual int GetMaxIndex(BarData barData)
		{
			return this.GetMaxIndex((int)barData);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000027AA File Offset: 0x000017AA
		public virtual double GetMin(int index1, int index2, BarData barData)
		{
			return this.GetMin(index1, index2, (int)barData);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000027B5 File Offset: 0x000017B5
		public virtual double GetMax(int index1, int index2, BarData barData)
		{
			return this.GetMax(index1, index2, (int)barData);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000027C0 File Offset: 0x000017C0
		public virtual int GetMinIndex(int index1, int index2, BarData barData)
		{
			return this.GetMinIndex(index1, index2, (int)barData);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000027CB File Offset: 0x000017CB
		public virtual int GetMaxIndex(int index1, int index2, BarData barData)
		{
			return this.GetMaxIndex(index1, index2, (int)barData);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000027D6 File Offset: 0x000017D6
		public virtual double GetMin(DateTime dateTime1, DateTime dateTime2, BarData barData)
		{
			return this.GetMin(dateTime1, dateTime2, (int)barData);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000027E1 File Offset: 0x000017E1
		public virtual double GetMax(DateTime dateTime1, DateTime dateTime2, BarData barData)
		{
			return this.GetMax(dateTime1, dateTime2, (int)barData);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000027EC File Offset: 0x000017EC
		public virtual int GetMinIndex(DateTime dateTime1, DateTime dateTime2, BarData barData)
		{
			return this.GetMinIndex(dateTime1, dateTime2, (int)barData);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000027F7 File Offset: 0x000017F7
		public virtual int GetMaxIndex(DateTime dateTime1, DateTime dateTime2, BarData barData)
		{
			return this.GetMaxIndex(dateTime1, dateTime2, (int)barData);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002802 File Offset: 0x00001802
		public virtual double GetSum()
		{
			return this.GetSum(0);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000280B File Offset: 0x0000180B
		public virtual double GetSum(int index1, int index2)
		{
			return this.GetSum(index1, index2, 0);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002816 File Offset: 0x00001816
		public virtual double GetSum(DateTime dateTime1, DateTime dateTime2)
		{
			return this.GetSum(dateTime1, dateTime2, 0);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002821 File Offset: 0x00001821
		public virtual double GetSum(int row)
		{
			return this.GetSum(0, this.Count - 1, row);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002833 File Offset: 0x00001833
		public virtual double GetSum(int index1, int index2, int row)
		{
			return double.NaN;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002840 File Offset: 0x00001840
		public double GetSum(DateTime dateTime1, DateTime dateTime2, int row)
		{
			if (dateTime1 >= dateTime2)
			{
				throw new ApplicationException("dateTime1 must be smaller than dateTime2");
			}
			int index = this.GetIndex(dateTime1);
			int index2 = this.GetIndex(dateTime2);
			if (index == -1)
			{
				throw new ApplicationException("dateTime1 is out of range");
			}
			if (index2 == -1)
			{
				throw new ApplicationException("dateTime2 is out of range");
			}
			return this.GetSum(index, index2, row);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002898 File Offset: 0x00001898
		public virtual double GetMean()
		{
			return this.GetMean(0);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000028A1 File Offset: 0x000018A1
		public virtual double GetMean(int index1, int index2)
		{
			return this.GetMean(index1, index2, 0);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000028AC File Offset: 0x000018AC
		public virtual double GetMean(DateTime dateTime1, DateTime dateTime2)
		{
			return this.GetMean(dateTime1, dateTime2, 0);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000028B7 File Offset: 0x000018B7
		public virtual double GetMean(int row)
		{
			return this.GetMean(0, this.Count - 1, row);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000028C9 File Offset: 0x000018C9
		public virtual double GetMean(int index1, int index2, int row)
		{
			return double.NaN;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000028D4 File Offset: 0x000018D4
		public double GetMean(DateTime dateTime1, DateTime dateTime2, int row)
		{
			if (this.Count <= 0)
			{
				throw new ApplicationException("Can not calculate mean. Array is empty.");
			}
			if (dateTime1 >= dateTime2)
			{
				throw new ApplicationException("dateTime1 must be smaller than dateTime2");
			}
			int index = this.GetIndex(dateTime1);
			int index2 = this.GetIndex(dateTime2);
			if (index == -1)
			{
				throw new ApplicationException("dateTime1 is out of range");
			}
			if (index2 == -1)
			{
				throw new ApplicationException("dateTime2 is out of range");
			}
			return this.GetMean(index, index2, row);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002940 File Offset: 0x00001940
		public virtual double GetMedian()
		{
			return this.GetMedian(0);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002949 File Offset: 0x00001949
		public virtual double GetMedian(int index1, int index2)
		{
			return this.GetMedian(index1, index2, 0);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002954 File Offset: 0x00001954
		public virtual double GetMedian(DateTime dateTime1, DateTime dateTime2)
		{
			return this.GetMedian(dateTime1, dateTime2, 0);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000295F File Offset: 0x0000195F
		public virtual double GetMedian(int row)
		{
			return this.GetMedian(0, this.Count - 1, row);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002971 File Offset: 0x00001971
		public virtual double GetMedian(int index1, int index2, int row)
		{
			return double.NaN;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000297C File Offset: 0x0000197C
		public double GetMedian(DateTime dateTime1, DateTime dateTime2, int row)
		{
			if (this.Count <= 0)
			{
				throw new ApplicationException("Can not calculate mean. Array is empty.");
			}
			if (dateTime1 >= dateTime2)
			{
				throw new ApplicationException("dateTime1 must be smaller than dateTime2");
			}
			int index = this.GetIndex(dateTime1);
			int index2 = this.GetIndex(dateTime2);
			if (index == -1)
			{
				throw new ApplicationException("dateTime1 is out of range");
			}
			if (index2 == -1)
			{
				throw new ApplicationException("dateTime2 is out of range");
			}
			return this.GetMedian(index, index2, row);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000029E8 File Offset: 0x000019E8
		public virtual double GetVariance()
		{
			return this.GetVariance(0);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000029F1 File Offset: 0x000019F1
		public virtual double GetVariance(int index1, int index2)
		{
			return this.GetVariance(index1, index2, 0);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000029FC File Offset: 0x000019FC
		public virtual double GetVariance(DateTime dateTime1, DateTime dateTime2)
		{
			return this.GetVariance(dateTime1, dateTime2, 0);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002A07 File Offset: 0x00001A07
		public virtual double GetVariance(int row)
		{
			return this.GetVariance(0, this.Count - 1, row);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002A19 File Offset: 0x00001A19
		public virtual double GetVariance(int index1, int index2, int row)
		{
			return double.NaN;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002A24 File Offset: 0x00001A24
		public virtual double GetVariance(DateTime dateTime1, DateTime dateTime2, int row)
		{
			if (this.Count <= 1)
			{
				throw new ApplicationException("Can not calculate variance. Insufficient number of elements in the array.");
			}
			if (dateTime1 >= dateTime2)
			{
				throw new ApplicationException("dateTime1 must be smaller than dateTime2");
			}
			int index = this.GetIndex(dateTime1);
			int index2 = this.GetIndex(dateTime2);
			if (index == -1)
			{
				throw new ApplicationException("dateTime1 is out of range");
			}
			if (index2 == -1)
			{
				throw new ApplicationException("dateTime2 is out of range");
			}
			return this.GetVariance(index, index2, row);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002A90 File Offset: 0x00001A90
		public virtual double GetPositiveVariance()
		{
			return this.GetPositiveVariance(0);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002A99 File Offset: 0x00001A99
		public virtual double GetPositiveVariance(int index1, int index2)
		{
			return this.GetPositiveVariance(index1, index2, 0);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002AA4 File Offset: 0x00001AA4
		public virtual double GetPositiveVariance(DateTime dateTime1, DateTime dateTime2)
		{
			return this.GetPositiveVariance(dateTime1, dateTime2, 0);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002AAF File Offset: 0x00001AAF
		public virtual double GetPositiveVariance(int row)
		{
			return this.GetPositiveVariance(0, this.Count - 1, row);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002AC1 File Offset: 0x00001AC1
		public virtual double GetPositiveVariance(int index1, int index2, int row)
		{
			return double.NaN;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002ACC File Offset: 0x00001ACC
		public virtual double GetPositiveVariance(DateTime dateTime1, DateTime dateTime2, int row)
		{
			if (this.Count <= 1)
			{
				throw new ApplicationException("Can not calculate variance. Insufficient number of elements in the array.");
			}
			if (dateTime1 >= dateTime2)
			{
				throw new ApplicationException("dateTime1 must be smaller than dateTime2");
			}
			int index = this.GetIndex(dateTime1);
			int index2 = this.GetIndex(dateTime2);
			if (index == -1)
			{
				throw new ApplicationException("dateTime1 is out of range");
			}
			if (index2 == -1)
			{
				throw new ApplicationException("dateTime2 is out of range");
			}
			return this.GetPositiveVariance(index, index2, row);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002B38 File Offset: 0x00001B38
		public virtual double GetNegativeVariance()
		{
			return this.GetNegativeVariance(0);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002B41 File Offset: 0x00001B41
		public virtual double GetNegativeVariance(int index1, int index2)
		{
			return this.GetNegativeVariance(index1, index2, 0);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002B4C File Offset: 0x00001B4C
		public virtual double GetNegativeVariance(DateTime dateTime1, DateTime dateTime2)
		{
			return this.GetNegativeVariance(dateTime1, dateTime2, 0);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002B57 File Offset: 0x00001B57
		public virtual double GetNegativeVariance(int row)
		{
			return this.GetNegativeVariance(0, this.Count - 1, row);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002B69 File Offset: 0x00001B69
		public virtual double GetNegativeVariance(int index1, int index2, int row)
		{
			return double.NaN;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002B74 File Offset: 0x00001B74
		public virtual double GetNegativeVariance(DateTime dateTime1, DateTime dateTime2, int row)
		{
			if (this.Count <= 1)
			{
				throw new ApplicationException("Can not calculate variance. Insufficient number of elements in the array.");
			}
			if (dateTime1 >= dateTime2)
			{
				throw new ApplicationException("dateTime1 must be smaller than dateTime2");
			}
			int index = this.GetIndex(dateTime1);
			int index2 = this.GetIndex(dateTime2);
			if (index == -1)
			{
				throw new ApplicationException("dateTime1 is out of range");
			}
			if (index2 == -1)
			{
				throw new ApplicationException("dateTime2 is out of range");
			}
			return this.GetNegativeVariance(index, index2, row);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002BE0 File Offset: 0x00001BE0
		public virtual double GetStdDev()
		{
			return Math.Sqrt(this.GetVariance());
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002BED File Offset: 0x00001BED
		public virtual double GetStdDev(int index1, int index2)
		{
			return Math.Sqrt(this.GetVariance(index1, index2));
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002BFC File Offset: 0x00001BFC
		public virtual double GetStdDev(DateTime dateTime1, DateTime dateTime2)
		{
			return Math.Sqrt(this.GetVariance(dateTime1, dateTime2));
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002C0B File Offset: 0x00001C0B
		public virtual double GetStdDev(int row)
		{
			return Math.Sqrt(this.GetVariance(row));
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002C19 File Offset: 0x00001C19
		public virtual double GetStdDev(int index1, int index2, int row)
		{
			return Math.Sqrt(this.GetVariance(index1, index2, row));
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002C29 File Offset: 0x00001C29
		public virtual double GetStdDev(DateTime dateTime1, DateTime dateTime2, int row)
		{
			return Math.Sqrt(this.GetVariance(dateTime1, dateTime2, row));
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002C39 File Offset: 0x00001C39
		public virtual double GetPositiveStdDev()
		{
			return Math.Sqrt(this.GetPositiveVariance());
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002C46 File Offset: 0x00001C46
		public virtual double GetPositiveStdDev(int index1, int index2)
		{
			return Math.Sqrt(this.GetPositiveVariance(index1, index2));
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002C55 File Offset: 0x00001C55
		public virtual double GetPositiveStdDev(DateTime dateTime1, DateTime dateTime2)
		{
			return Math.Sqrt(this.GetPositiveVariance(dateTime1, dateTime2));
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002C64 File Offset: 0x00001C64
		public virtual double GetPositiveStdDev(int row)
		{
			return Math.Sqrt(this.GetPositiveVariance(row));
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002C72 File Offset: 0x00001C72
		public virtual double GetPositiveStdDev(int index1, int index2, int row)
		{
			return Math.Sqrt(this.GetPositiveVariance(index1, index2, row));
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002C82 File Offset: 0x00001C82
		public virtual double GetPositiveStdDev(DateTime dateTime1, DateTime dateTime2, int row)
		{
			return Math.Sqrt(this.GetPositiveVariance(dateTime1, dateTime2, row));
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002C92 File Offset: 0x00001C92
		public virtual double GetNegativeStdDev()
		{
			return Math.Sqrt(this.GetNegativeVariance());
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002C9F File Offset: 0x00001C9F
		public virtual double GetNegativeStdDev(int index1, int index2)
		{
			return Math.Sqrt(this.GetNegativeVariance(index1, index2));
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002CAE File Offset: 0x00001CAE
		public virtual double GetNegativeStdDev(DateTime dateTime1, DateTime dateTime2)
		{
			return Math.Sqrt(this.GetNegativeVariance(dateTime1, dateTime2));
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002CBD File Offset: 0x00001CBD
		public virtual double GetNegativeStdDev(int row)
		{
			return Math.Sqrt(this.GetNegativeVariance(row));
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002CCB File Offset: 0x00001CCB
		public virtual double GetNegativeStdDev(int index1, int index2, int row)
		{
			return Math.Sqrt(this.GetNegativeVariance(index1, index2, row));
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002CDB File Offset: 0x00001CDB
		public virtual double GetNegativeStdDev(DateTime dateTime1, DateTime dateTime2, int row)
		{
			return Math.Sqrt(this.GetNegativeVariance(dateTime1, dateTime2, row));
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002CEB File Offset: 0x00001CEB
		public virtual double GetMoment(int k)
		{
			return this.GetMoment(k, 0);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002CF5 File Offset: 0x00001CF5
		public virtual double GetMoment(int k, int index1, int index2)
		{
			return this.GetMoment(k, index1, index2, 0);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002D01 File Offset: 0x00001D01
		public virtual double GetMoment(int k, DateTime dateTime1, DateTime dateTime2)
		{
			return this.GetMoment(k, dateTime1, dateTime2, 0);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002D0D File Offset: 0x00001D0D
		public virtual double GetMoment(int k, int row)
		{
			return this.GetMoment(k, 0, this.Count - 1, row);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002D20 File Offset: 0x00001D20
		public virtual double GetMoment(int k, int index1, int index2, int row)
		{
			return double.NaN;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002D2C File Offset: 0x00001D2C
		public double GetMoment(int k, DateTime dateTime1, DateTime dateTime2, int row)
		{
			if (this.Count <= 0)
			{
				throw new ApplicationException("Can not calculate momentum. Array is empty.");
			}
			if (dateTime1 >= dateTime2)
			{
				throw new ApplicationException("dateTime1 must be smaller than dateTime2");
			}
			int index = this.GetIndex(dateTime1);
			int index2 = this.GetIndex(dateTime2);
			if (index == -1)
			{
				throw new ApplicationException("dateTime1 is out of range");
			}
			if (index2 == -1)
			{
				throw new ApplicationException("dateTime2 is out of range");
			}
			return this.GetMoment(k, index, index2, row);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002D9A File Offset: 0x00001D9A
		public virtual double GetAsymmetry()
		{
			return this.GetAsymmetry(0);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002DA3 File Offset: 0x00001DA3
		public virtual double GetAsymmetry(int index1, int index2)
		{
			return this.GetAsymmetry(index1, index2, 0);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002DAE File Offset: 0x00001DAE
		public virtual double GetAsymmetry(DateTime dateTime1, DateTime dateTime2)
		{
			return this.GetAsymmetry(dateTime1, dateTime2, 0);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00002DB9 File Offset: 0x00001DB9
		public virtual double GetAsymmetry(int row)
		{
			return this.GetAsymmetry(0, this.Count - 1, row);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002DCB File Offset: 0x00001DCB
		public virtual double GetAsymmetry(int index1, int index2, int row)
		{
			return double.NaN;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002DD8 File Offset: 0x00001DD8
		public double GetAsymmetry(DateTime dateTime1, DateTime dateTime2, int row)
		{
			if (this.Count <= 0)
			{
				throw new ApplicationException("Can not calculate asymmetry. Array is empty.");
			}
			if (dateTime1 >= dateTime2)
			{
				throw new ApplicationException("dateTime1 must be smaller than dateTime2");
			}
			int index = this.GetIndex(dateTime1);
			int index2 = this.GetIndex(dateTime2);
			if (index == -1)
			{
				throw new ApplicationException("dateTime1 is out of range");
			}
			if (index2 == -1)
			{
				throw new ApplicationException("dateTime2 is out of range");
			}
			return this.GetAsymmetry(index, index2, row);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002E44 File Offset: 0x00001E44
		public virtual double GetExcess()
		{
			return this.GetExcess(0);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002E4D File Offset: 0x00001E4D
		public virtual double GetExcess(int index1, int index2)
		{
			return this.GetExcess(index1, index2, 0);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002E58 File Offset: 0x00001E58
		public virtual double GetExcess(DateTime dateTime1, DateTime dateTime2)
		{
			return this.GetExcess(dateTime1, dateTime2, 0);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002E63 File Offset: 0x00001E63
		public virtual double GetExcess(int row)
		{
			return this.GetExcess(0, this.Count - 1, row);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002E75 File Offset: 0x00001E75
		public virtual double GetExcess(int index1, int index2, int row)
		{
			return double.NaN;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002E80 File Offset: 0x00001E80
		public double GetExcess(DateTime dateTime1, DateTime dateTime2, int row)
		{
			if (this.Count <= 0)
			{
				throw new ApplicationException("Can not calculate excess. Array is empty.");
			}
			if (dateTime1 >= dateTime2)
			{
				throw new ApplicationException("dateTime1 must be smaller than dateTime2");
			}
			int index = this.GetIndex(dateTime1);
			int index2 = this.GetIndex(dateTime2);
			if (index == -1)
			{
				throw new ApplicationException("dateTime1 is out of range");
			}
			if (index2 == -1)
			{
				throw new ApplicationException("dateTime2 is out of range");
			}
			return this.GetExcess(index, index2, row);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002EEC File Offset: 0x00001EEC
		public virtual double GetCovariance(int row1, int row2)
		{
			return this.GetCovariance(row1, row2, 0, this.Count - 1);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002EFF File Offset: 0x00001EFF
		public virtual double GetCovariance(int row1, int row2, int index1, int index2)
		{
			throw new NotSupportedException();
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002F06 File Offset: 0x00001F06
		public virtual double GetCorrelation(int row1, int row2, int index1, int index2)
		{
			throw new NotSupportedException();
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00002F0D File Offset: 0x00001F0D
		public virtual double GetCorrelation(int row1, int row2)
		{
			return this.GetCorrelation(row1, row2, 0, this.Count - 1);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002F20 File Offset: 0x00001F20
		public virtual double GetCovariance(TimeSeries series)
		{
			throw new NotSupportedException();
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002F27 File Offset: 0x00001F27
		public virtual double GetCorrelation(TimeSeries series)
		{
			throw new NotSupportedException();
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002F2E File Offset: 0x00001F2E
		public virtual TimeSeries Shift(int offset)
		{
			throw new NotSupportedException();
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002F38 File Offset: 0x00001F38
		public virtual void Print()
		{
			for (int i = 0; i < this.Count; i++)
			{
				Console.WriteLine(this.GetDateTime(i) + " " + this[i]);
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002F78 File Offset: 0x00001F78
		public virtual void Draw()
		{
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002F7A File Offset: 0x00001F7A
		public virtual void Draw(string option)
		{
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002F7C File Offset: 0x00001F7C
		public virtual void Draw(Color color)
		{
			this.fColor = color;
			this.Draw();
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002F8B File Offset: 0x00001F8B
		public virtual void Draw(string option, Color color)
		{
			this.fColor = color;
			this.Draw(option);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002F9C File Offset: 0x00001F9C
		public ECross Crosses(double level, int index, int row)
		{
			if (index <= 0 || index > this.Count - 1)
			{
				return ECross.None;
			}
			if (this[index - 1, row] <= level && this[index, row] > level)
			{
				return ECross.Above;
			}
			if (this[index - 1, row] >= level && this[index, row] < level)
			{
				return ECross.Below;
			}
			return ECross.None;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002FEF File Offset: 0x00001FEF
		public ECross Crosses(double level, int index, BarData barData)
		{
			return this.Crosses(level, index, (int)barData);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00002FFA File Offset: 0x00001FFA
		public ECross Crosses(double level, int index)
		{
			return this.Crosses(level, index, 0);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00003008 File Offset: 0x00002008
		public ECross Crosses(TimeSeries series, DateTime dateTime, int row)
		{
			int index = this.GetIndex(dateTime);
			int index2 = series.GetIndex(dateTime);
			if (index <= 0 || index >= this.Count)
			{
				return ECross.None;
			}
			if (index2 <= 0 || index2 >= series.Count)
			{
				return ECross.None;
			}
			DateTime dateTime2 = this.GetDateTime(index - 1);
			DateTime dateTime3 = series.GetDateTime(index2 - 1);
			if (dateTime2 == dateTime3)
			{
				if (this[index - 1, row] <= series[index2 - 1, row] && this[index, row] > series[index2, row])
				{
					return ECross.Above;
				}
				if (this[index - 1, row] >= series[index2 - 1, row] && this[index, row] < series[index2, row])
				{
					return ECross.Below;
				}
			}
			else
			{
				double num;
				double num2;
				if (dateTime2 < dateTime3)
				{
					DateTime dateTime4 = this.GetDateTime(index - 1);
					num = this[index - 1, row];
					if (series.GetIndex(dateTime4, EIndexOption.Next) != index2)
					{
						num2 = series[series.GetIndex(dateTime4, EIndexOption.Next), row];
					}
					else
					{
						num2 = series[series.GetIndex(dateTime4, EIndexOption.Prev), row];
					}
				}
				else
				{
					DateTime dateTime5 = series.GetDateTime(index2 - 1);
					num2 = series[index2 - 1, row];
					if (this.GetIndex(dateTime5, EIndexOption.Next) != index)
					{
						num = this[this.GetIndex(dateTime5, EIndexOption.Next), row];
					}
					else
					{
						num = this[this.GetIndex(dateTime5, EIndexOption.Prev), row];
					}
				}
				if (num <= num2 && this[index, row] > series[index2, row])
				{
					return ECross.Above;
				}
				if (num >= num2 && this[index, row] < series[index2, row])
				{
					return ECross.Below;
				}
			}
			return ECross.None;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000318C File Offset: 0x0000218C
		public ECross Crosses(TimeSeries series, DateTime dateTime, BarData barData)
		{
			return this.Crosses(series, dateTime, (int)barData);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00003197 File Offset: 0x00002197
		public ECross Crosses(TimeSeries series, DateTime dateTime)
		{
			return this.Crosses(series, dateTime, 0);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000031A2 File Offset: 0x000021A2
		public ECross Crosses(TimeSeries series, Bar bar, int row)
		{
			return this.Crosses(series, bar.DateTime, row);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000031B2 File Offset: 0x000021B2
		public ECross Crosses(TimeSeries series, Bar bar, BarData barData)
		{
			return this.Crosses(series, bar.DateTime, barData);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000031C2 File Offset: 0x000021C2
		public ECross Crosses(TimeSeries series, Bar bar)
		{
			return this.Crosses(series, bar.DateTime);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000031D1 File Offset: 0x000021D1
		public bool CrossesBelow(double level, int index, int row)
		{
			return this.Crosses(level, index, row) == ECross.Below;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000031DF File Offset: 0x000021DF
		public bool CrossesBelow(double level, int index, BarData barData)
		{
			return this.Crosses(level, index, barData) == ECross.Below;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000031ED File Offset: 0x000021ED
		public bool CrossesBelow(double level, int index)
		{
			return this.Crosses(level, index) == ECross.Below;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000031FA File Offset: 0x000021FA
		public bool CrossesBelow(TimeSeries series, DateTime dateTime, int row)
		{
			return this.Crosses(series, dateTime, row) == ECross.Below;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00003208 File Offset: 0x00002208
		public bool CrossesBelow(TimeSeries series, DateTime dateTime, BarData barData)
		{
			return this.Crosses(series, dateTime, barData) == ECross.Below;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00003216 File Offset: 0x00002216
		public bool CrossesBelow(TimeSeries series, DateTime dateTime)
		{
			return this.Crosses(series, dateTime) == ECross.Below;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00003223 File Offset: 0x00002223
		public bool CrossesBelow(TimeSeries series, Bar bar, int row)
		{
			return this.Crosses(series, bar.DateTime, row) == ECross.Below;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00003236 File Offset: 0x00002236
		public bool CrossesBelow(TimeSeries series, Bar bar, BarData barData)
		{
			return this.Crosses(series, bar.DateTime, barData) == ECross.Below;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00003249 File Offset: 0x00002249
		public bool CrossesBelow(TimeSeries series, Bar bar)
		{
			return this.Crosses(series, bar.DateTime) == ECross.Below;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000325B File Offset: 0x0000225B
		public bool CrossesAbove(double level, int index, int row)
		{
			return this.Crosses(level, index, row) == ECross.Above;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00003269 File Offset: 0x00002269
		public bool CrossesAbove(double level, int index, BarData barData)
		{
			return this.Crosses(level, index, barData) == ECross.Above;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00003277 File Offset: 0x00002277
		public bool CrossesAbove(double level, int index)
		{
			return this.Crosses(level, index) == ECross.Above;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00003284 File Offset: 0x00002284
		public bool CrossesAbove(TimeSeries series, DateTime dateTime, int row)
		{
			return this.Crosses(series, dateTime, row) == ECross.Above;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00003292 File Offset: 0x00002292
		public bool CrossesAbove(TimeSeries series, DateTime dateTime, BarData barData)
		{
			return this.Crosses(series, dateTime, barData) == ECross.Above;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000032A0 File Offset: 0x000022A0
		public bool CrossesAbove(TimeSeries series, DateTime dateTime)
		{
			return this.Crosses(series, dateTime) == ECross.Above;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000032AD File Offset: 0x000022AD
		public bool CrossesAbove(TimeSeries series, Bar bar, int row)
		{
			return this.Crosses(series, bar.DateTime, row) == ECross.Above;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000032C0 File Offset: 0x000022C0
		public bool CrossesAbove(TimeSeries series, Bar bar, BarData barData)
		{
			return this.Crosses(series, bar.DateTime, barData) == ECross.Above;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000032D3 File Offset: 0x000022D3
		public bool CrossesAbove(TimeSeries series, Bar bar)
		{
			return this.Crosses(series, bar.DateTime) == ECross.Above;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x000032E5 File Offset: 0x000022E5
		public virtual void EmitItemAdded(DateTime dateTime)
		{
			if (this.ItemAdded != null)
			{
				this.ItemAdded(this, new DateTimeEventArgs(dateTime));
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00003301 File Offset: 0x00002301
		public IEnumerator GetEnumerator()
		{
			return this.fArray.GetEnumerator();
		}

		// Token: 0x0400000E RID: 14
		protected internal IDataSeries fArray;

		// Token: 0x0400000F RID: 15
		protected EIndexOption fIndexOption;

		// Token: 0x04000010 RID: 16
		protected string fName;

		// Token: 0x04000011 RID: 17
		protected string fTitle;

		// Token: 0x04000012 RID: 18
		protected Color fColor = Color.Black;

		// Token: 0x04000013 RID: 19
		protected bool fMonitored = true;

		// Token: 0x04000014 RID: 20
		protected bool fChanged;

		// Token: 0x04000015 RID: 21
		protected bool fToolTipEnabled = true;

		// Token: 0x04000016 RID: 22
		protected string fToolTipFormat = "{0}\n{2} - {3:F2}";

		// Token: 0x04000017 RID: 23
		protected string fToolTipDateTimeFormat = "MM/dd/yyyy";

		// Token: 0x04000018 RID: 24
		protected ArrayList fChildren = new ArrayList();

		// Token: 0x04000019 RID: 25
		public static ENameOption fNameOption;
	}
}
