using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using SmartQuant.Charting;
using SmartQuant.Data;

namespace SmartQuant.Series
{
	// Token: 0x0200000F RID: 15
	[Serializable]
	public class BarSeries : DoubleSeries
	{
		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060001CF RID: 463 RVA: 0x00008537 File Offset: 0x00007537
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x0000853F File Offset: 0x0000753F
		[Category("Chart Style")]
		[Description("A bar array can be drawn as bar, candle or line chart")]
		public ChartStyle ChartStyle
		{
			get
			{
				return this.fChartStyle;
			}
			set
			{
				this.fChartStyle = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x00008548 File Offset: 0x00007548
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x00008550 File Offset: 0x00007550
		[Category("Bar")]
		[Description("Bar color")]
		public Color BarColor
		{
			get
			{
				return this.fBarColor;
			}
			set
			{
				this.fBarColor = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x00008559 File Offset: 0x00007559
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x00008561 File Offset: 0x00007561
		[Description("Bar width")]
		[Category("Bar")]
		public int BarWidth
		{
			get
			{
				return this.fBarWidth;
			}
			set
			{
				this.fBarWidth = value;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x0000856A File Offset: 0x0000756A
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x00008572 File Offset: 0x00007572
		[Description("Bar width style")]
		[Category("Bar")]
		public EWidthStyle BarWidthStyle
		{
			get
			{
				return this.fBarWidthStyle;
			}
			set
			{
				this.fBarWidthStyle = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x0000857B File Offset: 0x0000757B
		// (set) Token: 0x060001D8 RID: 472 RVA: 0x00008583 File Offset: 0x00007583
		[Description("Candle color")]
		[Category("Candle")]
		public Color CandleColor
		{
			get
			{
				return this.fCandleColor;
			}
			set
			{
				this.fCandleColor = value;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x0000858C File Offset: 0x0000758C
		// (set) Token: 0x060001DA RID: 474 RVA: 0x00008594 File Offset: 0x00007594
		[Category("Candle")]
		[Description("Black candle color on the chart")]
		public Color CandleBlackColor
		{
			get
			{
				return this.fCandleBlackColor;
			}
			set
			{
				this.fCandleBlackColor = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060001DB RID: 475 RVA: 0x0000859D File Offset: 0x0000759D
		// (set) Token: 0x060001DC RID: 476 RVA: 0x000085A5 File Offset: 0x000075A5
		[Description("White candle color on the chart")]
		[Category("Candle")]
		public Color CandleWhiteColor
		{
			get
			{
				return this.fCandleWhiteColor;
			}
			set
			{
				this.fCandleWhiteColor = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060001DD RID: 477 RVA: 0x000085AE File Offset: 0x000075AE
		// (set) Token: 0x060001DE RID: 478 RVA: 0x000085B6 File Offset: 0x000075B6
		[Description("Candle width")]
		[Category("Candle")]
		public int CandleWidth
		{
			get
			{
				return this.fCandleWidth;
			}
			set
			{
				this.fCandleWidth = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060001DF RID: 479 RVA: 0x000085BF File Offset: 0x000075BF
		// (set) Token: 0x060001E0 RID: 480 RVA: 0x000085C7 File Offset: 0x000075C7
		[Category("Candle")]
		[Description("Candle width style")]
		public EWidthStyle CandleWidthStyle
		{
			get
			{
				return this.fCandleWidthStyle;
			}
			set
			{
				this.fCandleWidthStyle = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x000085D0 File Offset: 0x000075D0
		// (set) Token: 0x060001E2 RID: 482 RVA: 0x000085D8 File Offset: 0x000075D8
		[Description("Candle border color")]
		[Category("Candle")]
		public Color CandleBorderColor
		{
			get
			{
				return this.fCandleBorderColor;
			}
			set
			{
				this.fCandleBorderColor = value;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x000085E1 File Offset: 0x000075E1
		public new Bar First
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

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x000085FE File Offset: 0x000075FE
		public new Bar Last
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

		// Token: 0x060001E5 RID: 485 RVA: 0x00008622 File Offset: 0x00007622
		private void IniBarSeries()
		{
			this.fToolTipEnabled = true;
			this.fToolTipFormat = "{0} {2}\n\nH : {3:F2}\nL : {4:F2}\nO : {5:F2}\nC : {6:F2}\nV : {7}";
			this.fToolTipDateTimeFormat = "MM/dd/yyyy hh:mm:ss";
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00008644 File Offset: 0x00007644
		public BarSeries(string name, string title) : base(name, title)
		{
			this.IniBarSeries();
			this.fArray = new MemorySeries<Bar>();
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x000086C4 File Offset: 0x000076C4
		public BarSeries(string name) : this(name, "")
		{
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x000086D2 File Offset: 0x000076D2
		public BarSeries() : this("")
		{
			this.fName = "Price";
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x000086EA File Offset: 0x000076EA
		public new BarSeries Clone()
		{
			return base.Clone() as BarSeries;
		}

		// Token: 0x060001EA RID: 490 RVA: 0x000086F7 File Offset: 0x000076F7
		public new BarSeries Clone(int Index1, int Index2)
		{
			return base.Clone(Index1, Index2) as BarSeries;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00008706 File Offset: 0x00007706
		public new BarSeries Clone(DateTime DateTime1, DateTime DateTime2)
		{
			return base.Clone(DateTime1, DateTime2) as BarSeries;
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00008715 File Offset: 0x00007715
		public bool Contains(Bar Bar)
		{
			return base.Contains(Bar.DateTime);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00008723 File Offset: 0x00007723
		public void Add(Bar bar)
		{
			this.fArray[bar.DateTime] = bar;
			this.EmitItemAdded(bar.DateTime);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00008743 File Offset: 0x00007743
		public void Remove(Bar Bar)
		{
			this.fArray.Remove(Bar.DateTime);
		}

		// Token: 0x17000043 RID: 67
		public new Bar this[int i]
		{
			get
			{
				return this.fArray[i] as Bar;
			}
		}

		// Token: 0x17000044 RID: 68
		public new Bar this[DateTime DateTime]
		{
			get
			{
                int index = this.GetIndex(DateTime);
                if (index != -1)
                {
                    return this.fArray[index] as Bar;
                }
                else throw new Exception("No data entry on " + DateTime);
            }
		}

		// Token: 0x17000045 RID: 69
		public new Bar this[DateTime DateTime, EIndexOption Option]
		{
			get
			{
                int index = this.GetIndex(DateTime,Option);
                if (index != -1)
                {
                    return this.fArray[index] as Bar;
                }
                else throw new Exception("No data entry on " + DateTime);
            }
		}

		// Token: 0x17000046 RID: 70
		public override double this[int Index, int BarData]
		{
			get
			{
				return this[Index][BarData];
			}
		}

		// Token: 0x17000047 RID: 71
		public override double this[int Index, BarData BarData]
		{
			get
			{
				return this[Index][BarData];
			}
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x000087A0 File Offset: 0x000077A0
		public new BarSeries Shift(int offset)
		{
			BarSeries barSeries = new BarSeries(base.Name, base.Title);
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
				barSeries.Add(new Bar(this[i])
				{
					DateTime = dateTime
				});
			}
			return barSeries;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00008818 File Offset: 0x00007818
		public new Bar Ago(int n)
		{
			int num = this.Count - 1 - n;
			if (num < 0)
			{
				throw new ArgumentException("Can not return bar " + n + " bars ago: bar series is too short.");
			}
			return this[num];
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00008856 File Offset: 0x00007856
		public DoubleSeries GetArray(BarData BarData)
		{
			return this.GetArray(0, this.Count - 1, BarData);
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00008868 File Offset: 0x00007868
		public DoubleSeries GetArray(int Index1, int Index2, BarData BarData)
		{
			DoubleSeries doubleSeries = new DoubleSeries();
			for (int i = Index1; i <= Index2; i++)
			{
				doubleSeries.Add(this.GetDateTime(i), this[i, BarData]);
			}
			return doubleSeries;
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x000088A0 File Offset: 0x000078A0
		public DoubleSeries GetArray(DateTime DateTime1, DateTime DateTime2, BarData BarData)
		{
			int index = this.GetIndex(DateTime1, EIndexOption.Next);
			int index2 = this.GetIndex(DateTime2, EIndexOption.Prev);
			return this.GetArray(index, index2, BarData);
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x000088C8 File Offset: 0x000078C8
		public DoubleSeries GetHighSeries()
		{
			DoubleSeries doubleSeries = new DoubleSeries(base.Name + " High");
			for (int i = 0; i < this.Count; i++)
			{
				doubleSeries.Add(this[i].DateTime, this[i].High);
			}
			return doubleSeries;
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0000891C File Offset: 0x0000791C
		public DoubleSeries GetLowSeries()
		{
			DoubleSeries doubleSeries = new DoubleSeries(base.Name + " Low");
			for (int i = 0; i < this.Count; i++)
			{
				doubleSeries.Add(this[i].DateTime, this[i].Low);
			}
			return doubleSeries;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00008970 File Offset: 0x00007970
		public DoubleSeries GetOpenSeries()
		{
			DoubleSeries doubleSeries = new DoubleSeries(base.Name + " Open");
			for (int i = 0; i < this.Count; i++)
			{
				doubleSeries.Add(this[i].DateTime, this[i].Open);
			}
			return doubleSeries;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x000089C4 File Offset: 0x000079C4
		public DoubleSeries GetCloseSeries()
		{
			DoubleSeries doubleSeries = new DoubleSeries(base.Name + " Close");
			for (int i = 0; i < this.Count; i++)
			{
				doubleSeries.Add(this[i].DateTime, this[i].Close);
			}
			return doubleSeries;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00008A18 File Offset: 0x00007A18
		public DoubleSeries GetVolumeSeries()
		{
			DoubleSeries doubleSeries = new DoubleSeries(base.Name + " Volume");
			for (int i = 0; i < this.Count; i++)
			{
				doubleSeries.Add(this[i].DateTime, (double)this[i].Volume);
			}
			return doubleSeries;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00008A6C File Offset: 0x00007A6C
		public DoubleSeries GetOpenIntSeries()
		{
			DoubleSeries doubleSeries = new DoubleSeries(base.Name + " OpenInt");
			for (int i = 0; i < this.Count; i++)
			{
				doubleSeries.Add(this[i].DateTime, (double)this[i].OpenInt);
			}
			return doubleSeries;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00008AC0 File Offset: 0x00007AC0
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

		// Token: 0x06000200 RID: 512 RVA: 0x00008B3C File Offset: 0x00007B3C
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

		// Token: 0x06000201 RID: 513 RVA: 0x00008BB8 File Offset: 0x00007BB8
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

		// Token: 0x06000202 RID: 514 RVA: 0x00008C34 File Offset: 0x00007C34
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

		// Token: 0x06000203 RID: 515 RVA: 0x00008CB0 File Offset: 0x00007CB0
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

		// Token: 0x06000204 RID: 516 RVA: 0x00008D2C File Offset: 0x00007D2C
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

		// Token: 0x06000205 RID: 517 RVA: 0x00008DA8 File Offset: 0x00007DA8
		public Bar HighestHighBar(int Index1, int Index2)
		{
			if (this.Count <= 0)
			{
				throw new ApplicationException("Can not find highest high bar. Array is empty.");
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
			Bar bar = this[Index1];
			for (int i = Index1 + 1; i <= Index2; i++)
			{
				if (this[i].High > bar.High)
				{
					bar = this[i];
				}
			}
			return bar;
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00008E40 File Offset: 0x00007E40
		public Bar HighestHighBar(DateTime DateTime1, DateTime DateTime2)
		{
			int index = this.GetIndex(DateTime1, EIndexOption.Next);
			int index2 = this.GetIndex(DateTime2, EIndexOption.Prev);
			return this.HighestHighBar(index, index2);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00008E67 File Offset: 0x00007E67
		public Bar HighestHighBar()
		{
			return this.HighestHighBar(0, this.Count - 1);
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00008E78 File Offset: 0x00007E78
		public Bar LowestLowBar(int Index1, int Index2)
		{
			if (this.Count <= 0)
			{
				throw new ApplicationException("Can not find lowest low bar. Array is empty.");
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
			Bar bar = this[Index1];
			for (int i = Index1 + 1; i <= Index2; i++)
			{
				if (this[i].Low < bar.Low)
				{
					bar = this[i];
				}
			}
			return bar;
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00008F10 File Offset: 0x00007F10
		public Bar LowestLowBar(DateTime DateTime1, DateTime DateTime2)
		{
			int index = this.GetIndex(DateTime1, EIndexOption.Next);
			int index2 = this.GetIndex(DateTime2, EIndexOption.Prev);
			return this.LowestLowBar(index, index2);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00008F37 File Offset: 0x00007F37
		public Bar LowestLowBar(int nBars)
		{
			return this.LowestLowBar(this.LastIndex - nBars + 1, this.LastIndex);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00008F4F File Offset: 0x00007F4F
		public Bar HighestHighBar(int nBars)
		{
			return this.HighestHighBar(this.LastIndex - nBars + 1, this.LastIndex);
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00008F67 File Offset: 0x00007F67
		public Bar LowestLowBar()
		{
			return this.LowestLowBar(0, this.Count - 1);
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00008F78 File Offset: 0x00007F78
		public double HighestHigh(int index1, int index2)
		{
			Bar bar = this.HighestHighBar(index1, index2);
			if (bar != null)
			{
				return bar.High;
			}
			return double.NaN;
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00008FA4 File Offset: 0x00007FA4
		public double LowestLow(int index1, int index2)
		{
			Bar bar = this.LowestLowBar(index1, index2);
			if (bar != null)
			{
				return bar.Low;
			}
			return double.NaN;
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00008FD0 File Offset: 0x00007FD0
		public double HighestHigh(DateTime dateTime1, DateTime dateTime2)
		{
			Bar bar = this.HighestHighBar(dateTime1, dateTime2);
			if (bar != null)
			{
				return bar.High;
			}
			return double.NaN;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00008FFC File Offset: 0x00007FFC
		public double LowestLow(DateTime dateTime1, DateTime dateTime2)
		{
			Bar bar = this.LowestLowBar(dateTime1, dateTime2);
			if (bar != null)
			{
				return bar.Low;
			}
			return double.NaN;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00009028 File Offset: 0x00008028
		public double HighestHigh(int nBars)
		{
			Bar bar = this.HighestHighBar(nBars);
			if (bar != null)
			{
				return bar.High;
			}
			return double.NaN;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00009050 File Offset: 0x00008050
		public double LowestLow(int nBars)
		{
			Bar bar = this.LowestLowBar(nBars);
			if (bar != null)
			{
				return bar.Low;
			}
			return double.NaN;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00009078 File Offset: 0x00008078
		public double HighestHigh()
		{
			Bar bar = this.HighestHighBar();
			if (bar != null)
			{
				return bar.High;
			}
			return double.NaN;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x000090A0 File Offset: 0x000080A0
		public double LowestLow()
		{
			Bar bar = this.LowestLowBar();
			if (bar != null)
			{
				return bar.Low;
			}
			return double.NaN;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x000090C7 File Offset: 0x000080C7
		public override double GetMin(int index1, int index2)
		{
			return this.LowestLowBar(index1, index2).Low;
		}

		// Token: 0x06000216 RID: 534 RVA: 0x000090D6 File Offset: 0x000080D6
		public override double GetMax(int index1, int index2)
		{
			return this.HighestHighBar(index1, index2).High;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x000090E5 File Offset: 0x000080E5
		public override double GetMin()
		{
			return this.GetMin(0, this.Count - 1);
		}

		// Token: 0x06000218 RID: 536 RVA: 0x000090F6 File Offset: 0x000080F6
		public override double GetMax()
		{
			return this.GetMax(0, this.Count - 1);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00009108 File Offset: 0x00008108
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
			Bar bar = this[num];
			DateTime dateTime3 = this.GetDateTime(num);
			if (dateTime3.Year == dateTime2.Year && dateTime3.Month == dateTime2.Month && dateTime3.Day == dateTime2.Day)
			{
				return bar.Close;
			}
			return -1.0;
		}

		// Token: 0x0600021A RID: 538 RVA: 0x000091BC File Offset: 0x000081BC
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
			Bar bar = this[num];
			DateTime dateTime3 = this.GetDateTime(num);
			if ((dateTime2 <= dateTime3 && new DateTime(dateTime2.Year, dateTime2.Month, dateTime2.Day).Subtract(dateTime3).Days <= (int)dateTime2.DayOfWeek) | (dateTime2 > dateTime3 && new DateTime(dateTime3.Year, dateTime3.Month, dateTime3.Day).Subtract(dateTime2).Days <= (int)((DayOfWeek)7 - dateTime2.DayOfWeek)))
			{
				return bar.Close;
			}
			return -1.0;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x000092D0 File Offset: 0x000082D0
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
			Bar bar = this[num];
			DateTime dateTime3 = this.GetDateTime(num);
			if (dateTime3.Year == dateTime2.Year && dateTime3.Month == dateTime2.Month)
			{
				return bar.Close;
			}
			return -1.0;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00009364 File Offset: 0x00008364
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
			Bar bar = this[num];
			if (this.GetDateTime(num).Year == dateTime2.Year)
			{
				return bar.Close;
			}
			return -1.0;
		}

		// Token: 0x0600021D RID: 541 RVA: 0x000093E1 File Offset: 0x000083E1
		public double CloseD(int index, int daysAgo)
		{
			return this.CloseD(this.GetDateTime(index), daysAgo);
		}

		// Token: 0x0600021E RID: 542 RVA: 0x000093F1 File Offset: 0x000083F1
		public double CloseW(int index, int weeksAgo)
		{
			return this.CloseW(this.GetDateTime(index), weeksAgo);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00009401 File Offset: 0x00008401
		public double CloseM(int index, int monthsAgo)
		{
			return this.CloseM(this.GetDateTime(index), monthsAgo);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00009411 File Offset: 0x00008411
		public double CloseY(int index, int yearsAgo)
		{
			return this.CloseY(this.GetDateTime(index), yearsAgo);
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00009424 File Offset: 0x00008424
		public double CloseD(DateTime dateTime, int daysAgo)
		{
			return this.CloseD(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays((double)(-(double)daysAgo)));
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0000945C File Offset: 0x0000845C
		public double CloseW(DateTime dateTime, int weeksAgo)
		{
			return this.CloseW(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays((double)(-(double)weeksAgo * 7)));
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00009498 File Offset: 0x00008498
		public double CloseM(DateTime dateTime, int monthsAgo)
		{
			return this.CloseM(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddMonths(-monthsAgo));
		}

		// Token: 0x06000224 RID: 548 RVA: 0x000094D0 File Offset: 0x000084D0
		public double CloseY(DateTime dateTime, int yearsAgo)
		{
			return this.CloseY(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddYears(-yearsAgo));
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00009508 File Offset: 0x00008508
		public double CloseD(Bar bar, int daysAgo)
		{
			return this.CloseD(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day).AddDays((double)(-(double)daysAgo)));
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00009558 File Offset: 0x00008558
		public double CloseW(Bar bar, int weeksAgo)
		{
			return this.CloseW(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day).AddDays((double)(-(double)weeksAgo * 7)));
		}

		// Token: 0x06000227 RID: 551 RVA: 0x000095A8 File Offset: 0x000085A8
		public double CloseM(Bar bar, int monthsAgo)
		{
			return this.CloseM(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day).AddMonths(-monthsAgo));
		}

		// Token: 0x06000228 RID: 552 RVA: 0x000095F4 File Offset: 0x000085F4
		public double CloseY(Bar bar, int yearsAgo)
		{
			return this.CloseY(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day).AddDays((double)(-(double)yearsAgo)));
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00009644 File Offset: 0x00008644
		public double CloseD(Bar bar)
		{
			return this.CloseD(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day));
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00009688 File Offset: 0x00008688
		public double CloseW(Bar bar)
		{
			return this.CloseW(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day));
		}

		// Token: 0x0600022B RID: 555 RVA: 0x000096CC File Offset: 0x000086CC
		public double CloseM(Bar bar)
		{
			return this.CloseM(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day));
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00009710 File Offset: 0x00008710
		public double CloseY(Bar bar)
		{
			return this.CloseY(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day));
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00009754 File Offset: 0x00008754
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
			Bar bar = this[index];
			DateTime dateTime3 = this.GetDateTime(index);
			if (dateTime3.Year == dateTime2.Year && dateTime3.Month == dateTime2.Month && dateTime3.Day == dateTime2.Day)
			{
				return bar.Open;
			}
			return -1.0;
		}

		// Token: 0x0600022E RID: 558 RVA: 0x000097F4 File Offset: 0x000087F4
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
			Bar bar = this[index];
			DateTime dateTime3 = this.GetDateTime(index);
			if ((dateTime2 <= dateTime3 && new DateTime(dateTime2.Year, dateTime2.Month, dateTime2.Day).Subtract(dateTime3).Days <= (int)dateTime2.DayOfWeek) | (dateTime2 > dateTime3 && new DateTime(dateTime3.Year, dateTime3.Month, dateTime3.Day).Subtract(dateTime2).Days <= (int)((DayOfWeek)7 - dateTime2.DayOfWeek)))
			{
				return bar.Open;
			}
			return -1.0;
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00009904 File Offset: 0x00008904
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
			Bar bar = this[index];
			DateTime dateTime3 = this.GetDateTime(index);
			if (dateTime3.Year == dateTime2.Year && dateTime3.Month == dateTime2.Month)
			{
				return bar.Open;
			}
			return -1.0;
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00009990 File Offset: 0x00008990
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
			Bar bar = this[index];
			if (this.GetDateTime(index).Year == dateTime2.Year)
			{
				return bar.Open;
			}
			return -1.0;
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00009A03 File Offset: 0x00008A03
		public double OpenD(int index, int daysAgo)
		{
			return this.OpenD(this.GetDateTime(index), daysAgo);
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00009A13 File Offset: 0x00008A13
		public double OpenW(int index, int weeksAgo)
		{
			return this.OpenW(this.GetDateTime(index), weeksAgo);
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00009A23 File Offset: 0x00008A23
		public double OpenM(int index, int monthsAgo)
		{
			return this.OpenM(this.GetDateTime(index), monthsAgo);
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00009A33 File Offset: 0x00008A33
		public double OpenY(int index, int yearsAgo)
		{
			return this.OpenY(this.GetDateTime(index), yearsAgo);
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00009A44 File Offset: 0x00008A44
		public double OpenD(DateTime dateTime, int daysAgo)
		{
			return this.OpenD(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays((double)(-(double)daysAgo)));
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00009A7C File Offset: 0x00008A7C
		public double OpenW(DateTime dateTime, int weeksAgo)
		{
			return this.OpenW(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays((double)(-(double)weeksAgo * 7)));
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00009AB8 File Offset: 0x00008AB8
		public double OpenM(DateTime dateTime, int monthsAgo)
		{
			return this.OpenM(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddMonths(-monthsAgo));
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00009AF0 File Offset: 0x00008AF0
		public double OpenY(DateTime dateTime, int yearsAgo)
		{
			return this.OpenY(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddYears(-yearsAgo));
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00009B28 File Offset: 0x00008B28
		public double OpenD(Bar bar, int daysAgo)
		{
			return this.OpenD(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day).AddDays((double)(-(double)daysAgo)));
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00009B78 File Offset: 0x00008B78
		public double OpenW(Bar bar, int weeksAgo)
		{
			return this.OpenW(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day).AddDays((double)(-(double)weeksAgo * 7)));
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00009BC8 File Offset: 0x00008BC8
		public double OpenM(Bar bar, int monthsAgo)
		{
			return this.OpenM(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day).AddMonths(-monthsAgo));
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00009C14 File Offset: 0x00008C14
		public double OpenY(Bar bar, int yearsAgo)
		{
			return this.OpenY(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day).AddDays((double)(-(double)yearsAgo)));
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00009C64 File Offset: 0x00008C64
		public double OpenD(Bar bar)
		{
			return this.OpenD(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day));
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00009CA8 File Offset: 0x00008CA8
		public double OpenW(Bar bar)
		{
			return this.OpenW(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day));
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00009CEC File Offset: 0x00008CEC
		public double OpenM(Bar bar)
		{
			return this.OpenM(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day));
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00009D30 File Offset: 0x00008D30
		public double OpenY(Bar bar)
		{
			return this.OpenY(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day));
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00009D74 File Offset: 0x00008D74
		public double HighD(DateTime dateTime)
		{
			DateTime dateTime2 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
			DateTime dateTime3 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays(1.0).Subtract(new TimeSpan(1L));
			Bar bar = this.HighestHighBar(dateTime2, dateTime3);
			if (bar.DateTime >= dateTime2 && bar.DateTime <= dateTime3)
			{
				return bar.High;
			}
			return -1.0;
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00009E10 File Offset: 0x00008E10
		public double HighW(DateTime dateTime)
		{
			DateTime dateTime2 = dateTime.AddDays((double)((DayOfWeek)7 - dateTime.DayOfWeek)).Subtract(new TimeSpan(7, 0, 0, 0));
			DateTime dateTime3 = dateTime.AddDays((double)((DayOfWeek)7 - dateTime.DayOfWeek)).Subtract(new TimeSpan(1L));
			Bar bar = this.HighestHighBar(dateTime2, dateTime3);
			if (bar.DateTime >= dateTime2 && bar.DateTime <= dateTime3)
			{
				return bar.High;
			}
			return -1.0;
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00009E98 File Offset: 0x00008E98
		public double HighM(DateTime dateTime)
		{
			DateTime dateTime2 = new DateTime(dateTime.Year, dateTime.Month, 1);
			DateTime dateTime3 = new DateTime(dateTime.Year, dateTime.Month, 1).AddMonths(1).Subtract(new TimeSpan(1L));
			Bar bar = this.HighestHighBar(dateTime2, dateTime3);
			if (bar.DateTime >= dateTime2 && bar.DateTime <= dateTime3)
			{
				return bar.High;
			}
			return -1.0;
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00009F20 File Offset: 0x00008F20
		public double HighY(DateTime dateTime)
		{
			DateTime dateTime2 = new DateTime(dateTime.Year, 1, 1);
			DateTime dateTime3 = new DateTime(dateTime.Year, 1, 1).AddYears(1).Subtract(new TimeSpan(1L));
			Bar bar = this.HighestHighBar(dateTime2, dateTime3);
			if (bar.DateTime >= dateTime2 && bar.DateTime <= dateTime3)
			{
				return bar.High;
			}
			return -1.0;
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00009F9A File Offset: 0x00008F9A
		public double HighD(int index, int daysAgo)
		{
			return this.HighD(this.GetDateTime(index), daysAgo);
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00009FAA File Offset: 0x00008FAA
		public double HighW(int index, int weeksAgo)
		{
			return this.HighW(this.GetDateTime(index), weeksAgo);
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00009FBA File Offset: 0x00008FBA
		public double HighM(int index, int monthsAgo)
		{
			return this.HighM(this.GetDateTime(index), monthsAgo);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00009FCA File Offset: 0x00008FCA
		public double HighY(int index, int yearsAgo)
		{
			return this.HighY(this.GetDateTime(index), yearsAgo);
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00009FDC File Offset: 0x00008FDC
		public double HighD(DateTime dateTime, int daysAgo)
		{
			return this.HighD(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays((double)(-(double)daysAgo)));
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0000A014 File Offset: 0x00009014
		public double HighW(DateTime dateTime, int weeksAgo)
		{
			return this.HighW(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays((double)(-(double)weeksAgo * 7)));
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0000A050 File Offset: 0x00009050
		public double HighM(DateTime dateTime, int monthsAgo)
		{
			return this.HighM(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddMonths(-monthsAgo));
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0000A088 File Offset: 0x00009088
		public double HighY(DateTime dateTime, int yearsAgo)
		{
			return this.HighY(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddYears(-yearsAgo));
		}

		// Token: 0x0600024D RID: 589 RVA: 0x0000A0C0 File Offset: 0x000090C0
		public double HighD(Bar bar, int daysAgo)
		{
			return this.HighD(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day).AddDays((double)(-(double)daysAgo)));
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0000A110 File Offset: 0x00009110
		public double HighW(Bar bar, int weeksAgo)
		{
			return this.HighW(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day).AddDays((double)(-(double)weeksAgo * 7)));
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0000A160 File Offset: 0x00009160
		public double HighM(Bar bar, int monthsAgo)
		{
			return this.HighM(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day).AddMonths(-monthsAgo));
		}

		// Token: 0x06000250 RID: 592 RVA: 0x0000A1AC File Offset: 0x000091AC
		public double HighY(Bar bar, int yearsAgo)
		{
			return this.HighY(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day).AddDays((double)(-(double)yearsAgo)));
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0000A1FC File Offset: 0x000091FC
		public double HighD(Bar bar)
		{
			return this.HighD(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day));
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0000A240 File Offset: 0x00009240
		public double HighW(Bar bar)
		{
			return this.HighW(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day));
		}

		// Token: 0x06000253 RID: 595 RVA: 0x0000A284 File Offset: 0x00009284
		public double HighM(Bar bar)
		{
			return this.HighM(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day));
		}

		// Token: 0x06000254 RID: 596 RVA: 0x0000A2C8 File Offset: 0x000092C8
		public double HighY(Bar bar)
		{
			return this.HighY(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day));
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0000A30C File Offset: 0x0000930C
		public double LowD(DateTime dateTime)
		{
			DateTime dateTime2 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
			DateTime dateTime3 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays(1.0).Subtract(new TimeSpan(1L));
			Bar bar = this.LowestLowBar(dateTime2, dateTime3);
			if (bar.DateTime >= dateTime2 && bar.DateTime <= dateTime3)
			{
				return bar.Low;
			}
			return -1.0;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0000A3A8 File Offset: 0x000093A8
		public double LowW(DateTime dateTime)
		{
			DateTime dateTime2 = dateTime.AddDays((double)((DayOfWeek)7 - dateTime.DayOfWeek)).Subtract(new TimeSpan(7, 0, 0, 0));
			DateTime dateTime3 = dateTime.AddDays((double)((DayOfWeek)7 - dateTime.DayOfWeek)).Subtract(new TimeSpan(1L));
			Bar bar = this.LowestLowBar(dateTime2, dateTime3);
			if (bar.DateTime >= dateTime2 && bar.DateTime <= dateTime3)
			{
				return bar.Low;
			}
			return -1.0;
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0000A430 File Offset: 0x00009430
		public double LowM(DateTime dateTime)
		{
			DateTime dateTime2 = new DateTime(dateTime.Year, dateTime.Month, 1);
			DateTime dateTime3 = new DateTime(dateTime.Year, dateTime.Month, 1).AddMonths(1).Subtract(new TimeSpan(1L));
			Bar bar = this.LowestLowBar(dateTime2, dateTime3);
			if (bar.DateTime >= dateTime2 && bar.DateTime <= dateTime3)
			{
				return bar.Low;
			}
			return -1.0;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0000A4B8 File Offset: 0x000094B8
		public double LowY(DateTime dateTime)
		{
			DateTime dateTime2 = new DateTime(dateTime.Year, 1, 1);
			DateTime dateTime3 = new DateTime(dateTime.Year, 1, 1).AddYears(1).Subtract(new TimeSpan(1L));
			Bar bar = this.LowestLowBar(dateTime2, dateTime3);
			if (bar.DateTime >= dateTime2 && bar.DateTime <= dateTime3)
			{
				return bar.Low;
			}
			return -1.0;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0000A532 File Offset: 0x00009532
		public double LowD(int index, int daysAgo)
		{
			return this.LowD(this.GetDateTime(index), daysAgo);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0000A542 File Offset: 0x00009542
		public double LowW(int index, int weeksAgo)
		{
			return this.LowW(this.GetDateTime(index), weeksAgo);
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0000A552 File Offset: 0x00009552
		public double LowM(int index, int monthsAgo)
		{
			return this.LowM(this.GetDateTime(index), monthsAgo);
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0000A562 File Offset: 0x00009562
		public double LowY(int index, int yearsAgo)
		{
			return this.LowY(this.GetDateTime(index), yearsAgo);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0000A574 File Offset: 0x00009574
		public double LowD(DateTime dateTime, int daysAgo)
		{
			return this.LowD(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays((double)(-(double)daysAgo)));
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0000A5AC File Offset: 0x000095AC
		public double LowW(DateTime dateTime, int weeksAgo)
		{
			return this.LowW(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays((double)(-(double)weeksAgo * 7)));
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0000A5E8 File Offset: 0x000095E8
		public double LowM(DateTime dateTime, int monthsAgo)
		{
			return this.LowM(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddMonths(-monthsAgo));
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0000A620 File Offset: 0x00009620
		public double LowY(DateTime dateTime, int yearsAgo)
		{
			return this.LowY(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddYears(-yearsAgo));
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0000A658 File Offset: 0x00009658
		public double LowD(Bar bar, int daysAgo)
		{
			return this.LowD(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day).AddDays((double)(-(double)daysAgo)));
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0000A6A8 File Offset: 0x000096A8
		public double LowW(Bar bar, int weeksAgo)
		{
			return this.LowW(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day).AddDays((double)(-(double)weeksAgo * 7)));
		}

		// Token: 0x06000263 RID: 611 RVA: 0x0000A6F8 File Offset: 0x000096F8
		public double LowM(Bar bar, int monthsAgo)
		{
			return this.LowM(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day).AddMonths(-monthsAgo));
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0000A744 File Offset: 0x00009744
		public double LowY(Bar bar, int yearsAgo)
		{
			return this.LowY(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day).AddDays((double)(-(double)yearsAgo)));
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0000A794 File Offset: 0x00009794
		public double LowD(Bar bar)
		{
			return this.LowD(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day));
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0000A7D8 File Offset: 0x000097D8
		public double LowW(Bar bar)
		{
			return this.LowW(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day));
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0000A81C File Offset: 0x0000981C
		public double LowM(Bar bar)
		{
			return this.LowM(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day));
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0000A860 File Offset: 0x00009860
		public double LowY(Bar bar)
		{
			return this.LowY(new DateTime(bar.DateTime.Year, bar.DateTime.Month, bar.DateTime.Day));
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0000A8A4 File Offset: 0x000098A4
		public virtual BarSeries Compress(long NewBarSize)
		{
			BarSeries barSeries = base.GetType().GetConstructor(new Type[0]).Invoke(new object[0]) as BarSeries;
			if (this.Count <= 0)
			{
				return barSeries;
			}
			long size = this[0].Size;
			if (NewBarSize < size)
			{
				throw new ArgumentException("New bar size can not be smaller than the origianl bar size");
			}
			long num;
			Math.DivRem(NewBarSize, size, out num);
			if (num != 0L)
			{
				throw new ArgumentException("New bar size should be a multiple of the original bar size");
			}
			if (NewBarSize == size)
			{
				return this;
			}
			double num2 = 0.0;
			double num3 = 0.0;
			double open = 0.0;
			double close = 0.0;
			long num4 = 0L;
			long num5 = 0L;
			bool flag = true;
			int num6 = 0;
			while (flag)
			{
				DateTime dateTime = this[num6].DateTime;
				DateTime dateTime2;
				DateTime d;
				if (NewBarSize != 604800L)
				{
					if (NewBarSize != 2419200L)
					{
						if (NewBarSize == 29030400L)
						{
							dateTime2 = new DateTime(dateTime.Year, 1, 1);
							d = dateTime2.AddYears(1);
						}
						else
						{
							dateTime2 = new DateTime(dateTime.Ticks / (10000000L * NewBarSize) * (10000000L * NewBarSize));
							d = dateTime2.AddSeconds((double)NewBarSize);
						}
					}
					else
					{
						dateTime2 = new DateTime(dateTime.Year, dateTime.Month, 1);
						d = dateTime2.AddMonths(1);
					}
				}
				else
				{
					dateTime2 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays((double)(-((int)DayOfWeek.Saturday + (int)dateTime.DayOfWeek) % 7));
					d = dateTime2.AddDays(7.0);
				}
				int index = this.GetIndex(d.AddTicks(-1L), EIndexOption.Prev);
				Bar bar = null;
				for (int i = num6; i <= index; i++)
				{
					bar = this[i];
					if (i == num6)
					{
						num2 = bar.High;
						num3 = bar.Low;
						open = bar.Open;
						close = bar.Close;
						num4 = bar.Volume;
						num5 = bar.OpenInt;
					}
					else
					{
						num2 = Math.Max(num2, bar.High);
						num3 = Math.Min(num3, bar.Low);
						close = bar.Close;
						num4 += bar.Volume;
						num5 += bar.OpenInt;
					}
				}
				if (bar != null)
				{
					barSeries.Add(new Bar(dateTime2, open, num2, num3, close, num4, (d - dateTime2).Ticks / 10000000L)
					{
						OpenInt = num5
					});
				}
				else
				{
					flag = false;
				}
				num6 = index + 1;
				if (num6 > this.Count - 1)
				{
					flag = false;
				}
			}
			return barSeries;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0000AB52 File Offset: 0x00009B52
		public virtual BarSeries Compress(long newBarSize, TimeSpan sessionStart, TimeSpan sessionEnd)
		{
			return this.Compress(newBarSize, sessionStart, sessionEnd, BarSlycing.Equally);
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0000AB5E File Offset: 0x00009B5E
		public virtual BarSeries Compress(long newBarSize, TimeSpan sessionStart, TimeSpan sessionEnd, BarSlycing mode)
		{
			return this.Compress(newBarSize, sessionStart, sessionEnd, mode, true, true);
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0000AB70 File Offset: 0x00009B70
		public virtual BarSeries Compress(long newBarSize, TimeSpan sessionStart, TimeSpan sessionEnd, BarSlycing mode, bool weeklySlicingEnabled, bool clubWithPrevBar)
		{
			BarSeries barSeries = base.GetType().GetConstructor(new Type[0]).Invoke(new object[0]) as BarSeries;
			if (this.Count <= 0)
			{
				return barSeries;
			}
			long size = this[0].Size;
			if (newBarSize < size)
			{
				throw new ArgumentException("New bar size can not be smaller than the origianl bar size");
			}
			if (sessionStart >= sessionEnd)
			{
				throw new ArgumentException("SessionStart must be less than SessionEnd parameter");
			}
			long num;
			Math.DivRem(newBarSize, size, out num);
			if (num != 0L)
			{
				throw new ArgumentException("New bar size should be a multiple of the original bar size");
			}
			if (newBarSize == size)
			{
				return this;
			}
			double num2 = 0.0;
			double num3 = 0.0;
			double open = 0.0;
			double close = 0.0;
			long num4 = 0L;
			long num5 = 0L;
			bool flag = true;
			DateTime datetime = this[0].DateTime.Date.Add(sessionStart);
			DateTime dateTime = DateTime.MaxValue;
			long ticks = (sessionEnd - sessionStart).Ticks;
			int num6 = 0;
			bool flag2 = false;
			while (flag)
			{
				if (flag2)
				{
					datetime = dateTime.AddDays(2.0).Date.Add(sessionStart);
					flag2 = false;
				}
				dateTime = datetime.AddSeconds((double)newBarSize);
				DateTime dateTime2 = datetime.Date.Add(sessionEnd);
				if (dateTime > dateTime2)
				{
					long ticks2 = (dateTime - dateTime2).Ticks;
					dateTime = datetime.Date.AddDays(1.0).Add(sessionStart);
					if (mode == BarSlycing.Equally)
					{
						dateTime = dateTime.AddDays((double)(ticks2 / ticks)).AddTicks(ticks2 % ticks);
					}
					if (this.LastDateTime > dateTime)
					{
						DateTime date = this[dateTime, EIndexOption.Next].DateTime.Date;
						while (dateTime < date && (dateTime.DayOfWeek != DayOfWeek.Saturday || !weeklySlicingEnabled))
						{
							dateTime = dateTime.AddDays(1.0);
						}
						if (dateTime.DayOfWeek == DayOfWeek.Saturday && weeklySlicingEnabled)
						{
							flag2 = true;
						}
					}
				}
				int index = this.GetIndex(dateTime.AddTicks(-1L), EIndexOption.Prev);
				Bar bar = null;
				for (int i = num6; i <= index; i++)
				{
					bar = this[i];
					if (i == num6)
					{
						num2 = bar.High;
						num3 = bar.Low;
						open = bar.Open;
						close = bar.Close;
						num4 = bar.Volume;
						num5 = bar.OpenInt;
					}
					else
					{
						num2 = Math.Max(num2, bar.High);
						num3 = Math.Min(num3, bar.Low);
						close = bar.Close;
						num4 += bar.Volume;
						num5 += bar.OpenInt;
					}
				}
				if (bar != null)
				{
					Bar bar2 = new Bar(datetime, open, num2, num3, close, num4, newBarSize);
					if (flag2)
					{
						bar2.EndTime = dateTime.Date.AddDays(-1.0).Add(sessionEnd);
					}
					else
					{
						bar2.EndTime = dateTime;
					}
					if (mode == BarSlycing.Normal && dateTime > dateTime2)
					{
						bar2.EndTime = dateTime2;
					}
					bar2.OpenInt = num5;
					if (flag2 && clubWithPrevBar && bar2.Duration.TotalSeconds * 2.0 < (double)newBarSize && barSeries.Count > 0)
					{
						Bar last = barSeries.Last;
						bar2.Open = last.Open;
						bar2.High = Math.Max(bar2.High, last.High);
						bar2.Low = Math.Min(bar2.Low, last.Low);
						bar2.Volume += last.Volume;
						bar2.OpenInt += last.OpenInt;
						bar2.DateTime = last.BeginTime;
					}
					barSeries.Add(bar2);
				}
				num6 = index + 1;
				if (num6 > this.Count - 1)
				{
					flag = false;
				}
				datetime = dateTime;
			}
			return barSeries;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0000AF9B File Offset: 0x00009F9B
		public override PadRange GetPadRangeX(Pad pad)
		{
			return null;
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0000AFA0 File Offset: 0x00009FA0
		public override PadRange GetPadRangeY(Pad pad)
		{
			double num = 0.0;
			double num2 = 0.0;
			DateTime dateTime = new DateTime((long)pad.XMin);
			DateTime dateTime2 = new DateTime((long)pad.XMax);
			Bar bar = this.LowestLowBar(dateTime, dateTime2);
			if (bar != null)
			{
				num = bar.Low;
			}
			if (num == 0.0)
			{
				num = this.GetMin(dateTime, dateTime2, BarData.Close);
			}
			if (num == 0.0)
			{
				num = this.GetMin(dateTime, dateTime2, BarData.Open);
			}
			bar = this.HighestHighBar(dateTime, dateTime2);
			if (bar != null)
			{
				num2 = bar.High;
			}
			if (num2 == 0.0)
			{
				num2 = this.GetMax(dateTime, dateTime2, BarData.Close);
			}
			if (num2 == 0.0)
			{
				num2 = this.GetMax(dateTime, dateTime2, BarData.Open);
			}
			return new PadRange(num, num2);
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0000B06C File Offset: 0x0000A06C
		public override void Draw(string Option)
		{
			if (Option.ToLower().IndexOf("c") != -1)
			{
				this.fChartStyle = ChartStyle.Candle;
			}
			if (Option.ToLower().IndexOf("b") != -1)
			{
				this.fChartStyle = ChartStyle.Bar;
			}
			if (Option.ToLower().IndexOf("l") != -1)
			{
				this.fChartStyle = ChartStyle.Line;
			}
			if (Option.ToLower().IndexOf("s") == -1 && this.Count > 0)
			{
				double xmin = (double)this.FirstDateTime.Ticks;
				double xmax = (double)(this.LastDateTime.Ticks + this.Last.EndTime.Ticks - this.Last.BeginTime.Ticks);
				double low = this.LowestLowBar().Low;
				double high = this.HighestHighBar().High;
				Chart.Pad.SetRange(xmin, xmax, low, high);
			}
			if (Chart.Pad == null)
			{
				new Canvas("Canvas", "Canvas");
			}
			Chart.Pad.Add(this);
			Chart.Pad.Title.Add(this.fName, this.fColor);
			Chart.Pad.Legend.Add(this.fName, this.fColor);
			Chart.Pad.AxisBottom.Type = EAxisType.DateTime;
			if (Chart.Pad.AxisBottom.LabelFormat == "")
			{
				Chart.Pad.AxisBottom.LabelFormat = "MM/dd/yyyy hh:mm";
				return;
			}
			if (this.Count > 0)
			{
				if ((this.LastDateTime - this.FirstDateTime).TotalSeconds / (double)this.Count >= 86400.0)
				{
					Chart.Pad.AxisBottom.LabelFormat = "MM/dd/yyyy";
					this.fToolTipDateTimeFormat = "MM/dd/yyyy";
					return;
				}
				Chart.Pad.AxisBottom.LabelFormat = "hh:mm";
				this.fToolTipDateTimeFormat = "hh:mm";
			}
		}

		// Token: 0x06000270 RID: 624 RVA: 0x0000B262 File Offset: 0x0000A262
		public override void Draw()
		{
			this.Draw("");
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0000B270 File Offset: 0x0000A270
		public override void Paint(Pad pad, double XMin, double XMax, double YMin, double YMax)
		{
			Pen pen = new Pen(this.fColor);
			Pen pen2 = new Pen(this.fBarColor);
			Pen pen3 = new Pen(this.fCandleColor);
			Pen pen4 = new Pen(this.fCandleBorderColor);
			Brush brush = new SolidBrush(this.fCandleWhiteColor);
			Brush brush2 = new SolidBrush(this.fCandleBlackColor);
			int num = 0;
			double num2 = 0.0;
			double num3 = 0.0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			int num7 = 0;
			long num8 = 0L;
			long num9 = 0L;
			int num10 = 0;
			int num11 = 0;
			DateTime dateTime = new DateTime((long)XMin);
			DateTime dateTime2 = new DateTime((long)XMax);
			int num12;
			if (dateTime < this.FirstDateTime)
			{
				num12 = 0;
			}
			else
			{
				num12 = this.GetIndex(dateTime, EIndexOption.Prev);
			}
			int num13;
			if (dateTime2 > this.LastDateTime)
			{
				num13 = this.Count - 1;
			}
			else
			{
				num13 = this.GetIndex(dateTime2, EIndexOption.Next);
			}
			if (num12 == -1 || num13 == -1)
			{
				return;
			}
			for (int i = num12; i <= num13; i++)
			{
				Bar bar = this[i];
				long num14 = bar.BeginTime.Ticks;
				long num15 = bar.EndTime.Ticks;
				double num16 = (double)(num14 + (num15 - num14) / 2L);
				int num17 = pad.ClientX(num16);
				double high = bar.High;
				double low = bar.Low;
				double open = bar.Open;
				double close = bar.Close;
				Pen pen5 = pen2;
				if (bar.Color != Color.Empty)
				{
					pen5 = new Pen(bar.Color);
				}
				switch (this.fChartStyle)
				{
				case ChartStyle.Line:
				{
					double num18 = close;
					if (num != 0)
					{
						num14 = (long)pad.ClientX(num2);
						num4 = pad.ClientY(num3);
						num15 = (long)pad.ClientX(num16);
						num5 = pad.ClientY(num18);
						if ((pad.IsInRange(num16, num18) || pad.IsInRange(num2, num3)) && (num14 != num8 || num15 != num9 || num4 != num10 || num5 != num11))
						{
							pad.Graphics.DrawLine(pen, (float)num14, (float)num4, (float)num15, (float)num5);
						}
					}
					num8 = num14;
					num10 = num4;
					num9 = num15;
					num11 = num5;
					num2 = num16;
					num3 = num18;
					num++;
					break;
				}
				case ChartStyle.Bar:
					switch (this.fBarWidthStyle)
					{
					case EWidthStyle.Pixel:
						num6 = pad.ClientX(num16) - this.fBarWidth / 2;
						num7 = pad.ClientX(num16) + this.fBarWidth / 2;
						break;
					case EWidthStyle.DateTime:
						num6 = pad.ClientX(num16 - (double)((long)this.fBarWidth * 10000000L / 2L));
						num7 = pad.ClientX(num16 + (double)((long)this.fBarWidth * 10000000L / 2L));
						break;
					case EWidthStyle.Auto:
						num6 = pad.ClientX((double)num14);
						num7 = pad.ClientX((double)num15);
						break;
					}
					pad.Graphics.DrawLine(pen5, num17, pad.ClientY(low), num17, pad.ClientY(high));
					if (open != 0.0)
					{
						pad.Graphics.DrawLine(pen5, num17, pad.ClientY(open), num6, pad.ClientY(open));
					}
					if (close != 0.0)
					{
						pad.Graphics.DrawLine(pen5, num17, pad.ClientY(close), num7, pad.ClientY(close));
					}
					break;
				case ChartStyle.Candle:
					switch (this.fCandleWidthStyle)
					{
					case EWidthStyle.Pixel:
						num6 = pad.ClientX(num16) - this.fCandleWidth / 2;
						num7 = pad.ClientX(num16) + this.fCandleWidth / 2;
						break;
					case EWidthStyle.DateTime:
						num6 = pad.ClientX(num16 - (double)((long)this.fCandleWidth * 10000000L / 2L));
						num7 = pad.ClientX(num16 + (double)((long)this.fCandleWidth * 10000000L / 2L));
						break;
					case EWidthStyle.Auto:
						num6 = pad.ClientX((double)num14);
						num7 = pad.ClientX((double)num15);
						break;
					}
					pad.Graphics.DrawLine(pen3, num17, pad.ClientY(low), num17, pad.ClientY(high));
					if (open != 0.0 && close != 0.0)
					{
						if (open > close)
						{
							int num19 = num7 - num6;
							int num20 = pad.ClientY(close) - pad.ClientY(open);
							if (num20 == 0)
							{
								num20 = 1;
							}
							pad.Graphics.FillRectangle(brush2, num6, pad.ClientY(open), num19, num20);
						}
						else
						{
							int num19 = num7 - num6;
							int num20 = pad.ClientY(open) - pad.ClientY(close);
							if (num20 == 0)
							{
								num20 = 1;
							}
							if (pad.ForeColor == this.fCandleWhiteColor)
							{
								pad.Graphics.DrawRectangle(pen4, num6, pad.ClientY(close), num19, num20);
								pad.Graphics.FillRectangle(brush, num6 + 1, pad.ClientY(close) + 1, num19 - 2, num20 - 1);
							}
							else
							{
								pad.Graphics.FillRectangle(brush, num6, pad.ClientY(close), num19, num20);
							}
						}
					}
					break;
				}
			}
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0000B798 File Offset: 0x0000A798
		public override TDistance Distance(double X, double Y)
		{
			TDistance tdistance = new TDistance();
			int index = this.GetIndex(new DateTime((long)X), EIndexOption.Prev);
			if (index == -1)
			{
				return null;
			}
			Bar bar = this[index];
			if (X >= (double)bar.DateTime.Ticks && X <= (double)(bar.DateTime.Ticks + bar.Size * 10000000L))
			{
				tdistance.dX = 0.0;
			}
			else
			{
				tdistance.dX = double.MaxValue;
			}
			if (Y <= bar.High && Y >= bar.Low)
			{
				tdistance.dY = 0.0;
			}
			else
			{
				tdistance.dY = double.MaxValue;
			}
			tdistance.X = (double)bar.DateTime.Ticks;
			tdistance.Y = bar.Close;
			if (tdistance.dX != 1.7976931348623157E+308 && tdistance.dY != 1.7976931348623157E+308)
			{
				new DateTime((long)tdistance.X);
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.AppendFormat(this.fToolTipFormat, new object[]
				{
					this.fName,
					this.fTitle,
					bar.DateTime.ToString(this.fToolTipDateTimeFormat),
					bar.High,
					bar.Low,
					bar.Open,
					bar.Close,
					bar.Volume
				});
				tdistance.ToolTipText = stringBuilder.ToString();
				return tdistance;
			}
			return null;
		}

		// Token: 0x04000035 RID: 53
		private ChartStyle fChartStyle = ChartStyle.Bar;

		// Token: 0x04000036 RID: 54
		private Color fBarColor = Color.Black;

		// Token: 0x04000037 RID: 55
		private int fBarWidth = 5;

		// Token: 0x04000038 RID: 56
		private EWidthStyle fBarWidthStyle = EWidthStyle.Auto;

		// Token: 0x04000039 RID: 57
		private int fCandleWidth = 5;

		// Token: 0x0400003A RID: 58
		private EWidthStyle fCandleWidthStyle = EWidthStyle.Auto;

		// Token: 0x0400003B RID: 59
		private Color fCandleColor = Color.Black;

		// Token: 0x0400003C RID: 60
		private Color fCandleBlackColor = Color.Black;

		// Token: 0x0400003D RID: 61
		private Color fCandleWhiteColor = Color.White;

		// Token: 0x0400003E RID: 62
		private Color fCandleBorderColor = Color.Black;
	}
}
