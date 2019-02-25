using System;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x0200000B RID: 11
	[Serializable]
	public class BBU : Indicator
	{
		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00004614 File Offset: 0x00003614
		// (set) Token: 0x0600009B RID: 155 RVA: 0x0000461C File Offset: 0x0000361C
		[IndicatorParameter(2)]
		[Category("Parameters")]
		[Description("")]
		public BarData Option
		{
			get
			{
				return this.fOption;
			}
			set
			{
				this.fOption = value;
				this.Init();
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600009C RID: 156 RVA: 0x0000462B File Offset: 0x0000362B
		// (set) Token: 0x0600009D RID: 157 RVA: 0x00004633 File Offset: 0x00003633
		[Description("")]
		[IndicatorParameter(0)]
		[Category("Parameters")]
		public int Length
		{
			get
			{
				return this.fLength;
			}
			set
			{
				this.fLength = value;
				this.Init();
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00004642 File Offset: 0x00003642
		// (set) Token: 0x0600009F RID: 159 RVA: 0x0000464A File Offset: 0x0000364A
		[Description("")]
		[IndicatorParameter(1)]
		[Category("Parameters")]
		public double K
		{
			get
			{
				return this.fK;
			}
			set
			{
				this.fK = value;
				this.Init();
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000465C File Offset: 0x0000365C
		protected override void Init()
		{
			this.fName = string.Concat(new object[]
			{
				"BBU (",
				this.fLength,
				" ,",
				this.fK,
				")"
			});
			this.fTitle = "Bollinger Band Upper";
			this.fType = EIndicatorType.Price;
			this.Clear();
			this.fCalculate = true;
			if (this.fInput == null)
			{
				return;
			}
			if (this.fInput is BarSeries)
			{
				this.fName = string.Concat(new object[]
				{
					"BBU (",
					this.fLength,
					", ",
					this.fK,
					", ",
					this.fOption,
					")"
				});
			}
			if (TimeSeries.fNameOption == ENameOption.Long)
			{
				this.fName = this.fInput.Name + " " + this.fName;
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000476B File Offset: 0x0000376B
		public BBU()
		{
			this.Init();
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00004790 File Offset: 0x00003790
		public BBU(TimeSeries input, int length, double k, BarData option) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.fK = k;
			this.Init();
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000047CC File Offset: 0x000037CC
		public BBU(TimeSeries input, int length, double k, BarData option, Color color) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.fK = k;
			this.Init();
			base.Color = color;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000481C File Offset: 0x0000381C
		public BBU(TimeSeries input, int length, double k, BarData option, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.fK = k;
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00004873 File Offset: 0x00003873
		public BBU(TimeSeries input, int length, double k) : base(input)
		{
			this.fLength = length;
			this.fK = k;
			this.Init();
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000048A7 File Offset: 0x000038A7
		public BBU(TimeSeries input, int length, double k, Color color) : base(input)
		{
			this.fLength = length;
			this.fK = k;
			base.Color = color;
			this.Init();
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000048E4 File Offset: 0x000038E4
		protected override void Calculate(int index)
		{
			double data = BBU.Value(this.fInput, index, this.fLength, this.fK, this.fOption);
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00004924 File Offset: 0x00003924
		public static double Value(TimeSeries input, int index, int length, double k, BarData option)
		{
			if (index >= length - 1 + input.FirstIndex)
			{
				return SMA.Value(input, index, length, option) + k * SMD.Value(input, index, length, option);
			}
			return double.NaN;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00004961 File Offset: 0x00003961
		public static double Value(DoubleSeries input, int index, int length, double k)
		{
			return BBU.Value(input, index, length, k, BarData.Close);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00004970 File Offset: 0x00003970
		public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
		{
			if (this.fMonitored)
			{
				int index = this.fInput.GetIndex(EventArgs.DateTime);
				if (index != -1)
				{
					for (int i = index; i <= Math.Min(this.fInput.Count - 1, index + this.fLength - 1); i++)
					{
						this.Calculate(i);
					}
				}
			}
		}

		// Token: 0x0400001A RID: 26
		protected int fLength = 14;

		// Token: 0x0400001B RID: 27
		protected double fK = 3.0;

		// Token: 0x0400001C RID: 28
		protected BarData fOption;
	}
}
