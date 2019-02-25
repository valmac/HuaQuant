using System;
using SmartQuant.Data;

namespace SmartQuant.Series
{
	// Token: 0x0200000A RID: 10
	public class PnFSeries : DoubleSeries
	{
		// Token: 0x06000122 RID: 290 RVA: 0x000055C7 File Offset: 0x000045C7
		public PnFSeries(string name, string title) : base(name, title)
		{
			this.fArray = new MemorySeries<PnF>();
		}

		// Token: 0x06000123 RID: 291 RVA: 0x000055DC File Offset: 0x000045DC
		public PnFSeries(string name) : this(name, "")
		{
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000055EA File Offset: 0x000045EA
		public PnFSeries() : this("Point And Figure")
		{
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000125 RID: 293 RVA: 0x000055F7 File Offset: 0x000045F7
		public new PnF First
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

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000126 RID: 294 RVA: 0x00005614 File Offset: 0x00004614
		public new PnF Last
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

		// Token: 0x06000127 RID: 295 RVA: 0x00005638 File Offset: 0x00004638
		public new PnFSeries Clone()
		{
			return base.Clone() as PnFSeries;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00005645 File Offset: 0x00004645
		public new PnFSeries Clone(int Index1, int Index2)
		{
			return base.Clone(Index1, Index2) as PnFSeries;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00005654 File Offset: 0x00004654
		public new PnFSeries Clone(DateTime DateTime1, DateTime DateTime2)
		{
			return base.Clone(DateTime1, DateTime2) as PnFSeries;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00005663 File Offset: 0x00004663
		public bool Contains(PnF PnF)
		{
			return base.Contains(PnF.DateTime);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00005671 File Offset: 0x00004671
		public void Add(PnF pnF)
		{
			this.fArray[pnF.DateTime] = pnF;
			this.EmitItemAdded(pnF.DateTime);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00005691 File Offset: 0x00004691
		public void Remove(PnF PnF)
		{
			this.fArray.Remove(PnF.DateTime);
		}

		// Token: 0x17000026 RID: 38
		public new PnF this[int i]
		{
			get
			{
				return this.fArray[i] as PnF;
			}
		}

		// Token: 0x17000027 RID: 39
		public new PnF this[DateTime DateTime]
		{
			get
			{
                int index = this.GetIndex(DateTime);
                if (index != -1)
                {
                    return this.fArray[index] as PnF;
                }
                else throw new Exception("No data entry on " + DateTime);
            }
		}

		// Token: 0x17000028 RID: 40
		public new PnF this[DateTime DateTime, EIndexOption Option]
		{
			get
			{
                int index = this.GetIndex(DateTime, Option);
                if (index != -1)
                {
                    return this.fArray[index] as PnF;
                }
                else throw new Exception("No data entry on " + DateTime);
            }
		}

		// Token: 0x17000029 RID: 41
		public override double this[int Index, int BarData]
		{
			get
			{
				return this[Index][BarData];
			}
		}

		// Token: 0x1700002A RID: 42
		public override double this[int Index, BarData BarData]
		{
			get
			{
				return this[Index][BarData];
			}
		}

		// Token: 0x06000132 RID: 306 RVA: 0x000056F0 File Offset: 0x000046F0
		public new PnFSeries Shift(int offset)
		{
			PnFSeries pnFSeries = new PnFSeries(base.Name, base.Title);
			int num = 0;
			if (offset < 0)
			{
				num += Math.Abs(offset);
			}
			for (int i = num; i < this.Count; i++)
			{
				int num2 = i + offset;
				if (num2 >= this.Count)
				{
					break;
				}
				DateTime dateTime = this.GetDateTime(num2);
				pnFSeries.Add(new PnF(this[i])
				{
					DateTime = dateTime
				});
			}
			return pnFSeries;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00005768 File Offset: 0x00004768
		public new PnF Ago(int n)
		{
			int num = this.Count - 1 - n;
			if (num < 0)
			{
				throw new ArgumentException("Can not return pnF " + n + " pnFs ago: pnF series is too short.");
			}
			return this[num];
		}

		// Token: 0x06000134 RID: 308 RVA: 0x000057A6 File Offset: 0x000047A6
		public DoubleSeries GetArray(BarData BarData)
		{
			return this.GetArray(0, this.Count - 1, BarData);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x000057B8 File Offset: 0x000047B8
		public DoubleSeries GetArray(int Index1, int Index2, BarData BarData)
		{
			DoubleSeries doubleSeries = new DoubleSeries();
			for (int i = Index1; i <= Index2; i++)
			{
				doubleSeries.Add(this.GetDateTime(i), this[i, BarData]);
			}
			return doubleSeries;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x000057F0 File Offset: 0x000047F0
		public DoubleSeries GetArray(DateTime DateTime1, DateTime DateTime2, BarData BarData)
		{
			int index = this.GetIndex(DateTime1, EIndexOption.Next);
			int index2 = this.GetIndex(DateTime2, EIndexOption.Prev);
			return this.GetArray(index, index2, BarData);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00005818 File Offset: 0x00004818
		public DoubleSeries GetHighSeries()
		{
			DoubleSeries doubleSeries = new DoubleSeries(base.Name + " High");
			for (int i = 0; i < this.Count; i++)
			{
				doubleSeries.Add(this[i].DateTime, this[i].High);
			}
			return doubleSeries;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0000586C File Offset: 0x0000486C
		public DoubleSeries GetLowSeries()
		{
			DoubleSeries doubleSeries = new DoubleSeries(base.Name + " Low");
			for (int i = 0; i < this.Count; i++)
			{
				doubleSeries.Add(this[i].DateTime, this[i].Low);
			}
			return doubleSeries;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x000058C0 File Offset: 0x000048C0
		public DoubleSeries GetOpenSeries()
		{
			DoubleSeries doubleSeries = new DoubleSeries(base.Name + " Open");
			for (int i = 0; i < this.Count; i++)
			{
				doubleSeries.Add(this[i].DateTime, this[i].Open);
			}
			return doubleSeries;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00005914 File Offset: 0x00004914
		public DoubleSeries GetCloseSeries()
		{
			DoubleSeries doubleSeries = new DoubleSeries(base.Name + " Close");
			for (int i = 0; i < this.Count; i++)
			{
				doubleSeries.Add(this[i].DateTime, this[i].Close);
			}
			return doubleSeries;
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00005968 File Offset: 0x00004968
		public DoubleSeries GetVolumeSeries()
		{
			DoubleSeries doubleSeries = new DoubleSeries(base.Name + " Volume");
			for (int i = 0; i < this.Count; i++)
			{
				doubleSeries.Add(this[i].DateTime, (double)this[i].Volume);
			}
			return doubleSeries;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x000059BC File Offset: 0x000049BC
		public DoubleSeries GetOpenIntSeries()
		{
			DoubleSeries doubleSeries = new DoubleSeries(base.Name + " OpenInt");
			for (int i = 0; i < this.Count; i++)
			{
				doubleSeries.Add(this[i].DateTime, (double)this[i].OpenInt);
			}
			return doubleSeries;
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00005A10 File Offset: 0x00004A10
		public DoubleSeries GetHighSeries(DateTime date1, DateTime date2)
		{
			DoubleSeries doubleSeries = new DoubleSeries(base.Name + " High");
			for (int i = 0; i < this.Count; i++)
			{
				if (this[i].DateTime >= date1 && this[i].DateTime <= date2)
				{
					doubleSeries.Add(this[i].DateTime, this[i].High);
				}
			}
			return doubleSeries;
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00005A8C File Offset: 0x00004A8C
		public DoubleSeries GetLowSeries(DateTime date1, DateTime date2)
		{
			DoubleSeries doubleSeries = new DoubleSeries(base.Name + " Low");
			for (int i = 0; i < this.Count; i++)
			{
				if (this[i].DateTime >= date1 && this[i].DateTime <= date2)
				{
					doubleSeries.Add(this[i].DateTime, this[i].Low);
				}
			}
			return doubleSeries;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00005B08 File Offset: 0x00004B08
		public DoubleSeries GetOpenSeries(DateTime date1, DateTime date2)
		{
			DoubleSeries doubleSeries = new DoubleSeries(base.Name + " Open");
			for (int i = 0; i < this.Count; i++)
			{
				if (this[i].DateTime >= date1 && this[i].DateTime <= date2)
				{
					doubleSeries.Add(this[i].DateTime, this[i].Open);
				}
			}
			return doubleSeries;
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00005B84 File Offset: 0x00004B84
		public DoubleSeries GetCloseSeries(DateTime date1, DateTime date2)
		{
			DoubleSeries doubleSeries = new DoubleSeries(base.Name + " Close");
			for (int i = 0; i < this.Count; i++)
			{
				if (this[i].DateTime >= date1 && this[i].DateTime <= date2)
				{
					doubleSeries.Add(this[i].DateTime, this[i].Close);
				}
			}
			return doubleSeries;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00005C00 File Offset: 0x00004C00
		public DoubleSeries GetVolumeSeries(DateTime date1, DateTime date2)
		{
			DoubleSeries doubleSeries = new DoubleSeries(base.Name + " Volume");
			for (int i = 0; i < this.Count; i++)
			{
				if (this[i].DateTime >= date1 && this[i].DateTime <= date2)
				{
					doubleSeries.Add(this[i].DateTime, (double)this[i].Volume);
				}
			}
			return doubleSeries;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00005C7C File Offset: 0x00004C7C
		public DoubleSeries GetOpenIntSeries(DateTime date1, DateTime date2)
		{
			DoubleSeries doubleSeries = new DoubleSeries(base.Name + " OpenInt");
			for (int i = 0; i < this.Count; i++)
			{
				if (this[i].DateTime >= date1 && this[i].DateTime <= date2)
				{
					doubleSeries.Add(this[i].DateTime, (double)this[i].OpenInt);
				}
			}
			return doubleSeries;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00005CF8 File Offset: 0x00004CF8
		public PnF HighestHighPnF(int Index1, int Index2)
		{
			if (this.Count <= 0)
			{
				throw new ApplicationException("Can not find highest high pnF. Array is empty.");
			}
			if (Index1 > Index2)
			{
				throw new ApplicationException("Index1 must be smaller than Index2");
			}
			if (Index1 < 0 || Index1 > this.Count - 1)
			{
				throw new ApplicationException("Index1 is out of range");
			}
			if (Index2 < 0 || Index2 > this.Count - 1)
			{
				throw new ApplicationException("Index2 is out of range");
			}
			PnF pnF = this[Index1];
			for (int i = Index1 + 1; i <= Index2; i++)
			{
				if (this[i].High > pnF.High)
				{
					pnF = this[i];
				}
			}
			return pnF;
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00005D90 File Offset: 0x00004D90
		public PnF HighestHighPnF(DateTime DateTime1, DateTime DateTime2)
		{
			int index = this.GetIndex(DateTime1, EIndexOption.Next);
			int index2 = this.GetIndex(DateTime2, EIndexOption.Prev);
			return this.HighestHighPnF(index, index2);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00005DB7 File Offset: 0x00004DB7
		public PnF HighestHighPnF()
		{
			return this.HighestHighPnF(0, this.Count - 1);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00005DC8 File Offset: 0x00004DC8
		public PnF LowestLowPnF(int Index1, int Index2)
		{
			if (this.Count <= 0)
			{
				throw new ApplicationException("Can not find lowest low pnF. Array is empty.");
			}
			if (Index1 > Index2)
			{
				throw new ApplicationException("Index1 must be smaller than Index2");
			}
			if (Index1 < 0 || Index1 > this.Count - 1)
			{
				throw new ApplicationException("Index1 is out of range");
			}
			if (Index2 < 0 || Index2 > this.Count - 1)
			{
				throw new ApplicationException("Index2 is out of range");
			}
			PnF pnF = this[Index1];
			for (int i = Index1 + 1; i <= Index2; i++)
			{
				if (this[i].Low < pnF.Low)
				{
					pnF = this[i];
				}
			}
			return pnF;
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00005E60 File Offset: 0x00004E60
		public PnF LowestLowPnF(DateTime DateTime1, DateTime DateTime2)
		{
			int index = this.GetIndex(DateTime1, EIndexOption.Next);
			int index2 = this.GetIndex(DateTime2, EIndexOption.Prev);
			return this.LowestLowPnF(index, index2);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00005E87 File Offset: 0x00004E87
		public PnF LowestLowPnF(int nPnFs)
		{
			return this.LowestLowPnF(this.LastIndex - nPnFs + 1, this.LastIndex);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00005E9F File Offset: 0x00004E9F
		public PnF HighestHighPnF(int nPnFs)
		{
			return this.HighestHighPnF(this.LastIndex - nPnFs + 1, this.LastIndex);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00005EB7 File Offset: 0x00004EB7
		public PnF LowestLowPnF()
		{
			return this.LowestLowPnF(0, this.Count - 1);
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00005EC8 File Offset: 0x00004EC8
		public double HighestHigh(int index1, int index2)
		{
			PnF pnF = this.HighestHighPnF(index1, index2);
			if (pnF != null)
			{
				return pnF.High;
			}
			return double.NaN;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00005EF4 File Offset: 0x00004EF4
		public double LowestLow(int index1, int index2)
		{
			PnF pnF = this.LowestLowPnF(index1, index2);
			if (pnF != null)
			{
				return pnF.Low;
			}
			return double.NaN;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00005F20 File Offset: 0x00004F20
		public double HighestHigh(DateTime dateTime1, DateTime dateTime2)
		{
			PnF pnF = this.HighestHighPnF(dateTime1, dateTime2);
			if (pnF != null)
			{
				return pnF.High;
			}
			return double.NaN;
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00005F4C File Offset: 0x00004F4C
		public double LowestLow(DateTime dateTime1, DateTime dateTime2)
		{
			PnF pnF = this.LowestLowPnF(dateTime1, dateTime2);
			if (pnF != null)
			{
				return pnF.Low;
			}
			return double.NaN;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00005F78 File Offset: 0x00004F78
		public double HighestHigh(int nPnFs)
		{
			PnF pnF = this.HighestHighPnF(nPnFs);
			if (pnF != null)
			{
				return pnF.High;
			}
			return double.NaN;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00005FA0 File Offset: 0x00004FA0
		public double LowestLow(int nPnFs)
		{
			PnF pnF = this.LowestLowPnF(nPnFs);
			if (pnF != null)
			{
				return pnF.Low;
			}
			return double.NaN;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00005FC8 File Offset: 0x00004FC8
		public double HighestHigh()
		{
			PnF pnF = this.HighestHighPnF();
			if (pnF != null)
			{
				return pnF.High;
			}
			return double.NaN;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00005FF0 File Offset: 0x00004FF0
		public double LowestLow()
		{
			PnF pnF = this.LowestLowPnF();
			if (pnF != null)
			{
				return pnF.Low;
			}
			return double.NaN;
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00006017 File Offset: 0x00005017
		public override double GetMin(int index1, int index2)
		{
			return this.LowestLowPnF(index1, index2).Low;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00006026 File Offset: 0x00005026
		public override double GetMax(int index1, int index2)
		{
			return this.HighestHighPnF(index1, index2).High;
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00006035 File Offset: 0x00005035
		public override double GetMin()
		{
			return this.GetMin(0, this.Count - 1);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00006046 File Offset: 0x00005046
		public override double GetMax()
		{
			return this.GetMax(0, this.Count - 1);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00006058 File Offset: 0x00005058
		public double CloseD(DateTime dateTime)
		{
			DateTime dateTime2 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
			dateTime = dateTime2.AddDays(1.0);
			int num = this.GetIndex(dateTime) - 1;
			if (num == -2)
			{
				num = this.GetIndex(dateTime, EIndexOption.Prev);
			}
			if (num == -1)
			{
				return -1.0;
			}
			PnF pnF = this[num];
			DateTime dateTime3 = this.GetDateTime(num);
			if (dateTime3.Year == dateTime2.Year && dateTime3.Month == dateTime2.Month && dateTime3.Day == dateTime2.Day)
			{
				return pnF.Close;
			}
			return -1.0;
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0000610C File Offset: 0x0000510C
		public double CloseW(DateTime dateTime)
		{
			DateTime dateTime2 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
			dateTime = dateTime2.AddDays((double)((DayOfWeek)7 - dateTime2.DayOfWeek));
			int num = this.GetIndex(dateTime) - 1;
			if (num == -2)
			{
				num = this.GetIndex(dateTime, EIndexOption.Prev);
			}
			if (num == -1)
			{
				return -1.0;
			}
			PnF pnF = this[num];
			DateTime dateTime3 = this.GetDateTime(num);
			if ((dateTime2 <= dateTime3 && new DateTime(dateTime2.Year, dateTime2.Month, dateTime2.Day).Subtract(dateTime3).Days <= (int)dateTime2.DayOfWeek) | (dateTime2 > dateTime3 && new DateTime(dateTime3.Year, dateTime3.Month, dateTime3.Day).Subtract(dateTime2).Days <= (int)((DayOfWeek)7 - dateTime2.DayOfWeek)))
			{
				return pnF.Close;
			}
			return -1.0;
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00006220 File Offset: 0x00005220
		public double CloseM(DateTime dateTime)
		{
			DateTime dateTime2 = new DateTime(dateTime.Year, dateTime.Month, 1);
			dateTime = dateTime2.AddMonths(1);
			int num = this.GetIndex(dateTime) - 1;
			if (num == -2)
			{
				num = this.GetIndex(dateTime, EIndexOption.Prev);
			}
			if (num == -1)
			{
				return -1.0;
			}
			PnF pnF = this[num];
			DateTime dateTime3 = this.GetDateTime(num);
			if (dateTime3.Year == dateTime2.Year && dateTime3.Month == dateTime2.Month)
			{
				return pnF.Close;
			}
			return -1.0;
		}

		// Token: 0x0600015A RID: 346 RVA: 0x000062B4 File Offset: 0x000052B4
		public double CloseY(DateTime dateTime)
		{
			DateTime dateTime2 = new DateTime(dateTime.Year, 1, 1);
			dateTime = dateTime2.AddYears(1);
			int num = this.GetIndex(dateTime) - 1;
			if (num == -2)
			{
				num = this.GetIndex(dateTime, EIndexOption.Prev);
			}
			if (num == -1)
			{
				return -1.0;
			}
			PnF pnF = this[num];
			if (this.GetDateTime(num).Year == dateTime2.Year)
			{
				return pnF.Close;
			}
			return -1.0;
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00006331 File Offset: 0x00005331
		public double CloseD(int index, int daysAgo)
		{
			return this.CloseD(this.GetDateTime(index), daysAgo);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00006341 File Offset: 0x00005341
		public double CloseW(int index, int weeksAgo)
		{
			return this.CloseW(this.GetDateTime(index), weeksAgo);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00006351 File Offset: 0x00005351
		public double CloseM(int index, int monthsAgo)
		{
			return this.CloseM(this.GetDateTime(index), monthsAgo);
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00006361 File Offset: 0x00005361
		public double CloseY(int index, int yearsAgo)
		{
			return this.CloseY(this.GetDateTime(index), yearsAgo);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00006374 File Offset: 0x00005374
		public double CloseD(DateTime dateTime, int daysAgo)
		{
			return this.CloseD(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays((double)(-(double)daysAgo)));
		}

		// Token: 0x06000160 RID: 352 RVA: 0x000063AC File Offset: 0x000053AC
		public double CloseW(DateTime dateTime, int weeksAgo)
		{
			return this.CloseW(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays((double)(-(double)weeksAgo * 7)));
		}

		// Token: 0x06000161 RID: 353 RVA: 0x000063E8 File Offset: 0x000053E8
		public double CloseM(DateTime dateTime, int monthsAgo)
		{
			return this.CloseM(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddMonths(-monthsAgo));
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00006420 File Offset: 0x00005420
		public double CloseY(DateTime dateTime, int yearsAgo)
		{
			return this.CloseY(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddYears(-yearsAgo));
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00006458 File Offset: 0x00005458
		public double CloseD(PnF pnF, int daysAgo)
		{
			return this.CloseD(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day).AddDays((double)(-(double)daysAgo)));
		}

		// Token: 0x06000164 RID: 356 RVA: 0x000064A8 File Offset: 0x000054A8
		public double CloseW(PnF pnF, int weeksAgo)
		{
			return this.CloseW(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day).AddDays((double)(-(double)weeksAgo * 7)));
		}

		// Token: 0x06000165 RID: 357 RVA: 0x000064F8 File Offset: 0x000054F8
		public double CloseM(PnF pnF, int monthsAgo)
		{
			return this.CloseM(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day).AddMonths(-monthsAgo));
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00006544 File Offset: 0x00005544
		public double CloseY(PnF pnF, int yearsAgo)
		{
			return this.CloseY(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day).AddDays((double)(-(double)yearsAgo)));
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00006594 File Offset: 0x00005594
		public double CloseD(PnF pnF)
		{
			return this.CloseD(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day));
		}

		// Token: 0x06000168 RID: 360 RVA: 0x000065D8 File Offset: 0x000055D8
		public double CloseW(PnF pnF)
		{
			return this.CloseW(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day));
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0000661C File Offset: 0x0000561C
		public double CloseM(PnF pnF)
		{
			return this.CloseM(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day));
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00006660 File Offset: 0x00005660
		public double CloseY(PnF pnF)
		{
			return this.CloseY(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day));
		}

		// Token: 0x0600016B RID: 363 RVA: 0x000066A4 File Offset: 0x000056A4
		public double OpenD(DateTime dateTime)
		{
			DateTime dateTime2 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
			dateTime = dateTime2;
			int index = this.GetIndex(dateTime);
			if (index == -1)
			{
				index = this.GetIndex(dateTime, EIndexOption.Next);
			}
			if (index == -1)
			{
				return -1.0;
			}
			PnF pnF = this[index];
			DateTime dateTime3 = this.GetDateTime(index);
			if (dateTime3.Year == dateTime2.Year && dateTime3.Month == dateTime2.Month && dateTime3.Day == dateTime2.Day)
			{
				return pnF.Open;
			}
			return -1.0;
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00006744 File Offset: 0x00005744
		public double OpenW(DateTime dateTime)
		{
			DateTime dateTime2 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
			dateTime = dateTime2.AddDays((double)(-(double)dateTime2.DayOfWeek));
			int index = this.GetIndex(dateTime);
			if (index == -1)
			{
				index = this.GetIndex(dateTime, EIndexOption.Next);
			}
			if (index == -1)
			{
				return -1.0;
			}
			PnF pnF = this[index];
			DateTime dateTime3 = this.GetDateTime(index);
			if ((dateTime2 <= dateTime3 && new DateTime(dateTime2.Year, dateTime2.Month, dateTime2.Day).Subtract(dateTime3).Days <= (int)dateTime2.DayOfWeek) | (dateTime2 > dateTime3 && new DateTime(dateTime3.Year, dateTime3.Month, dateTime3.Day).Subtract(dateTime2).Days <= (int)((DayOfWeek)7 - dateTime2.DayOfWeek)))
			{
				return pnF.Open;
			}
			return -1.0;
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00006854 File Offset: 0x00005854
		public double OpenM(DateTime dateTime)
		{
			DateTime dateTime2 = new DateTime(dateTime.Year, dateTime.Month, 1);
			dateTime = dateTime2;
			int index = this.GetIndex(dateTime);
			if (index == -1)
			{
				index = this.GetIndex(dateTime, EIndexOption.Next);
			}
			if (index == -1)
			{
				return -1.0;
			}
			PnF pnF = this[index];
			DateTime dateTime3 = this.GetDateTime(index);
			if (dateTime3.Year == dateTime2.Year && dateTime3.Month == dateTime2.Month)
			{
				return pnF.Open;
			}
			return -1.0;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x000068E0 File Offset: 0x000058E0
		public double OpenY(DateTime dateTime)
		{
			DateTime dateTime2 = new DateTime(dateTime.Year, 1, 1);
			dateTime = dateTime2;
			int index = this.GetIndex(dateTime);
			if (index == -1)
			{
				index = this.GetIndex(dateTime, EIndexOption.Next);
			}
			if (index == -1)
			{
				return -1.0;
			}
			PnF pnF = this[index];
			if (this.GetDateTime(index).Year == dateTime2.Year)
			{
				return pnF.Open;
			}
			return -1.0;
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00006953 File Offset: 0x00005953
		public double OpenD(int index, int daysAgo)
		{
			return this.OpenD(this.GetDateTime(index), daysAgo);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00006963 File Offset: 0x00005963
		public double OpenW(int index, int weeksAgo)
		{
			return this.OpenW(this.GetDateTime(index), weeksAgo);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00006973 File Offset: 0x00005973
		public double OpenM(int index, int monthsAgo)
		{
			return this.OpenM(this.GetDateTime(index), monthsAgo);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00006983 File Offset: 0x00005983
		public double OpenY(int index, int yearsAgo)
		{
			return this.OpenY(this.GetDateTime(index), yearsAgo);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00006994 File Offset: 0x00005994
		public double OpenD(DateTime dateTime, int daysAgo)
		{
			return this.OpenD(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays((double)(-(double)daysAgo)));
		}

		// Token: 0x06000174 RID: 372 RVA: 0x000069CC File Offset: 0x000059CC
		public double OpenW(DateTime dateTime, int weeksAgo)
		{
			return this.OpenW(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays((double)(-(double)weeksAgo * 7)));
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00006A08 File Offset: 0x00005A08
		public double OpenM(DateTime dateTime, int monthsAgo)
		{
			return this.OpenM(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddMonths(-monthsAgo));
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00006A40 File Offset: 0x00005A40
		public double OpenY(DateTime dateTime, int yearsAgo)
		{
			return this.OpenY(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddYears(-yearsAgo));
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00006A78 File Offset: 0x00005A78
		public double OpenD(PnF pnF, int daysAgo)
		{
			return this.OpenD(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day).AddDays((double)(-(double)daysAgo)));
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00006AC8 File Offset: 0x00005AC8
		public double OpenW(PnF pnF, int weeksAgo)
		{
			return this.OpenW(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day).AddDays((double)(-(double)weeksAgo * 7)));
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00006B18 File Offset: 0x00005B18
		public double OpenM(PnF pnF, int monthsAgo)
		{
			return this.OpenM(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day).AddMonths(-monthsAgo));
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00006B64 File Offset: 0x00005B64
		public double OpenY(PnF pnF, int yearsAgo)
		{
			return this.OpenY(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day).AddDays((double)(-(double)yearsAgo)));
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00006BB4 File Offset: 0x00005BB4
		public double OpenD(PnF pnF)
		{
			return this.OpenD(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day));
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00006BF8 File Offset: 0x00005BF8
		public double OpenW(PnF pnF)
		{
			return this.OpenW(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day));
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00006C3C File Offset: 0x00005C3C
		public double OpenM(PnF pnF)
		{
			return this.OpenM(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day));
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00006C80 File Offset: 0x00005C80
		public double OpenY(PnF pnF)
		{
			return this.OpenY(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day));
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00006CC4 File Offset: 0x00005CC4
		public double HighD(DateTime dateTime)
		{
			DateTime dateTime2 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
			DateTime dateTime3 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays(1.0).Subtract(new TimeSpan(1L));
			PnF pnF = this.HighestHighPnF(dateTime2, dateTime3);
			if (pnF.DateTime >= dateTime2 && pnF.DateTime <= dateTime3)
			{
				return pnF.High;
			}
			return -1.0;
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00006D60 File Offset: 0x00005D60
		public double HighW(DateTime dateTime)
		{
			DateTime dateTime2 = dateTime.AddDays((double)((DayOfWeek)7 - dateTime.DayOfWeek)).Subtract(new TimeSpan(7, 0, 0, 0));
			DateTime dateTime3 = dateTime.AddDays((double)((DayOfWeek)7 - dateTime.DayOfWeek)).Subtract(new TimeSpan(1L));
			PnF pnF = this.HighestHighPnF(dateTime2, dateTime3);
			if (pnF.DateTime >= dateTime2 && pnF.DateTime <= dateTime3)
			{
				return pnF.High;
			}
			return -1.0;
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00006DE8 File Offset: 0x00005DE8
		public double HighM(DateTime dateTime)
		{
			DateTime dateTime2 = new DateTime(dateTime.Year, dateTime.Month, 1);
			DateTime dateTime3 = new DateTime(dateTime.Year, dateTime.Month, 1).AddMonths(1).Subtract(new TimeSpan(1L));
			PnF pnF = this.HighestHighPnF(dateTime2, dateTime3);
			if (pnF.DateTime >= dateTime2 && pnF.DateTime <= dateTime3)
			{
				return pnF.High;
			}
			return -1.0;
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00006E70 File Offset: 0x00005E70
		public double HighY(DateTime dateTime)
		{
			DateTime dateTime2 = new DateTime(dateTime.Year, 1, 1);
			DateTime dateTime3 = new DateTime(dateTime.Year, 1, 1).AddYears(1).Subtract(new TimeSpan(1L));
			PnF pnF = this.HighestHighPnF(dateTime2, dateTime3);
			if (pnF.DateTime >= dateTime2 && pnF.DateTime <= dateTime3)
			{
				return pnF.High;
			}
			return -1.0;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00006EEA File Offset: 0x00005EEA
		public double HighD(int index, int daysAgo)
		{
			return this.HighD(this.GetDateTime(index), daysAgo);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00006EFA File Offset: 0x00005EFA
		public double HighW(int index, int weeksAgo)
		{
			return this.HighW(this.GetDateTime(index), weeksAgo);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00006F0A File Offset: 0x00005F0A
		public double HighM(int index, int monthsAgo)
		{
			return this.HighM(this.GetDateTime(index), monthsAgo);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00006F1A File Offset: 0x00005F1A
		public double HighY(int index, int yearsAgo)
		{
			return this.HighY(this.GetDateTime(index), yearsAgo);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00006F2C File Offset: 0x00005F2C
		public double HighD(DateTime dateTime, int daysAgo)
		{
			return this.HighD(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays((double)(-(double)daysAgo)));
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00006F64 File Offset: 0x00005F64
		public double HighW(DateTime dateTime, int weeksAgo)
		{
			return this.HighW(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays((double)(-(double)weeksAgo * 7)));
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00006FA0 File Offset: 0x00005FA0
		public double HighM(DateTime dateTime, int monthsAgo)
		{
			return this.HighM(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddMonths(-monthsAgo));
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00006FD8 File Offset: 0x00005FD8
		public double HighY(DateTime dateTime, int yearsAgo)
		{
			return this.HighY(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddYears(-yearsAgo));
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00007010 File Offset: 0x00006010
		public double HighD(PnF pnF, int daysAgo)
		{
			return this.HighD(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day).AddDays((double)(-(double)daysAgo)));
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00007060 File Offset: 0x00006060
		public double HighW(PnF pnF, int weeksAgo)
		{
			return this.HighW(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day).AddDays((double)(-(double)weeksAgo * 7)));
		}

		// Token: 0x0600018D RID: 397 RVA: 0x000070B0 File Offset: 0x000060B0
		public double HighM(PnF pnF, int monthsAgo)
		{
			return this.HighM(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day).AddMonths(-monthsAgo));
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000070FC File Offset: 0x000060FC
		public double HighY(PnF pnF, int yearsAgo)
		{
			return this.HighY(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day).AddDays((double)(-(double)yearsAgo)));
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0000714C File Offset: 0x0000614C
		public double HighD(PnF pnF)
		{
			return this.HighD(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day));
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00007190 File Offset: 0x00006190
		public double HighW(PnF pnF)
		{
			return this.HighW(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day));
		}

		// Token: 0x06000191 RID: 401 RVA: 0x000071D4 File Offset: 0x000061D4
		public double HighM(PnF pnF)
		{
			return this.HighM(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day));
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00007218 File Offset: 0x00006218
		public double HighY(PnF pnF)
		{
			return this.HighY(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day));
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0000725C File Offset: 0x0000625C
		public double LowD(DateTime dateTime)
		{
			DateTime dateTime2 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
			DateTime dateTime3 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays(1.0).Subtract(new TimeSpan(1L));
			PnF pnF = this.LowestLowPnF(dateTime2, dateTime3);
			if (pnF.DateTime >= dateTime2 && pnF.DateTime <= dateTime3)
			{
				return pnF.Low;
			}
			return -1.0;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x000072F8 File Offset: 0x000062F8
		public double LowW(DateTime dateTime)
		{
			DateTime dateTime2 = dateTime.AddDays((double)((DayOfWeek)7 - dateTime.DayOfWeek)).Subtract(new TimeSpan(7, 0, 0, 0));
			DateTime dateTime3 = dateTime.AddDays((double)((DayOfWeek)7 - dateTime.DayOfWeek)).Subtract(new TimeSpan(1L));
			PnF pnF = this.LowestLowPnF(dateTime2, dateTime3);
			if (pnF.DateTime >= dateTime2 && pnF.DateTime <= dateTime3)
			{
				return pnF.Low;
			}
			return -1.0;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00007380 File Offset: 0x00006380
		public double LowM(DateTime dateTime)
		{
			DateTime dateTime2 = new DateTime(dateTime.Year, dateTime.Month, 1);
			DateTime dateTime3 = new DateTime(dateTime.Year, dateTime.Month, 1).AddMonths(1).Subtract(new TimeSpan(1L));
			PnF pnF = this.LowestLowPnF(dateTime2, dateTime3);
			if (pnF.DateTime >= dateTime2 && pnF.DateTime <= dateTime3)
			{
				return pnF.Low;
			}
			return -1.0;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00007408 File Offset: 0x00006408
		public double LowY(DateTime dateTime)
		{
			DateTime dateTime2 = new DateTime(dateTime.Year, 1, 1);
			DateTime dateTime3 = new DateTime(dateTime.Year, 1, 1).AddYears(1).Subtract(new TimeSpan(1L));
			PnF pnF = this.LowestLowPnF(dateTime2, dateTime3);
			if (pnF.DateTime >= dateTime2 && pnF.DateTime <= dateTime3)
			{
				return pnF.Low;
			}
			return -1.0;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00007482 File Offset: 0x00006482
		public double LowD(int index, int daysAgo)
		{
			return this.LowD(this.GetDateTime(index), daysAgo);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00007492 File Offset: 0x00006492
		public double LowW(int index, int weeksAgo)
		{
			return this.LowW(this.GetDateTime(index), weeksAgo);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x000074A2 File Offset: 0x000064A2
		public double LowM(int index, int monthsAgo)
		{
			return this.LowM(this.GetDateTime(index), monthsAgo);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x000074B2 File Offset: 0x000064B2
		public double LowY(int index, int yearsAgo)
		{
			return this.LowY(this.GetDateTime(index), yearsAgo);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x000074C4 File Offset: 0x000064C4
		public double LowD(DateTime dateTime, int daysAgo)
		{
			return this.LowD(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays((double)(-(double)daysAgo)));
		}

		// Token: 0x0600019C RID: 412 RVA: 0x000074FC File Offset: 0x000064FC
		public double LowW(DateTime dateTime, int weeksAgo)
		{
			return this.LowW(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays((double)(-(double)weeksAgo * 7)));
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00007538 File Offset: 0x00006538
		public double LowM(DateTime dateTime, int monthsAgo)
		{
			return this.LowM(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddMonths(-monthsAgo));
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00007570 File Offset: 0x00006570
		public double LowY(DateTime dateTime, int yearsAgo)
		{
			return this.LowY(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddYears(-yearsAgo));
		}

		// Token: 0x0600019F RID: 415 RVA: 0x000075A8 File Offset: 0x000065A8
		public double LowD(PnF pnF, int daysAgo)
		{
			return this.LowD(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day).AddDays((double)(-(double)daysAgo)));
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x000075F8 File Offset: 0x000065F8
		public double LowW(PnF pnF, int weeksAgo)
		{
			return this.LowW(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day).AddDays((double)(-(double)weeksAgo * 7)));
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00007648 File Offset: 0x00006648
		public double LowM(PnF pnF, int monthsAgo)
		{
			return this.LowM(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day).AddMonths(-monthsAgo));
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00007694 File Offset: 0x00006694
		public double LowY(PnF pnF, int yearsAgo)
		{
			return this.LowY(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day).AddDays((double)(-(double)yearsAgo)));
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x000076E4 File Offset: 0x000066E4
		public double LowD(PnF pnF)
		{
			return this.LowD(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day));
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00007728 File Offset: 0x00006728
		public double LowW(PnF pnF)
		{
			return this.LowW(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day));
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0000776C File Offset: 0x0000676C
		public double LowM(PnF pnF)
		{
			return this.LowM(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day));
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x000077B0 File Offset: 0x000067B0
		public double LowY(PnF pnF)
		{
			return this.LowY(new DateTime(pnF.DateTime.Year, pnF.DateTime.Month, pnF.DateTime.Day));
		}
	}
}
