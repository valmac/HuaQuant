using System;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x02000044 RID: 68
	[Serializable]
	public class SMA : Indicator
	{
		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000354 RID: 852 RVA: 0x0000F071 File Offset: 0x0000E071
		// (set) Token: 0x06000355 RID: 853 RVA: 0x0000F079 File Offset: 0x0000E079
		[IndicatorParameter(1)]
		[Description("")]
		[Category("Parameters")]
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

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000356 RID: 854 RVA: 0x0000F088 File Offset: 0x0000E088
		// (set) Token: 0x06000357 RID: 855 RVA: 0x0000F090 File Offset: 0x0000E090
		[IndicatorParameter(0)]
		[Category("Parameters")]
		[Description("")]
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

		// Token: 0x06000358 RID: 856 RVA: 0x0000F0A0 File Offset: 0x0000E0A0
		protected override void Init()
		{
			this.fName = "SMA (" + this.fLength + ")";
			this.fTitle = "Simple Moving Average";
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
					"SMA (",
					this.fLength,
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

		// Token: 0x06000359 RID: 857 RVA: 0x0000F172 File Offset: 0x0000E172
		public SMA()
		{
			this.Init();
		}

		// Token: 0x0600035A RID: 858 RVA: 0x0000F188 File Offset: 0x0000E188
		public SMA(TimeSeries input, int length, BarData option) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
		}

		// Token: 0x0600035B RID: 859 RVA: 0x0000F1AD File Offset: 0x0000E1AD
		public SMA(TimeSeries input, int length, BarData option, Color color) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
			base.Color = color;
		}

		// Token: 0x0600035C RID: 860 RVA: 0x0000F1DA File Offset: 0x0000E1DA
		public SMA(TimeSeries input, int length, BarData option, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0000F20F File Offset: 0x0000E20F
		public SMA(TimeSeries input, int length) : base(input)
		{
			this.fLength = length;
			this.Init();
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0000F22D File Offset: 0x0000E22D
		public SMA(TimeSeries input, int length, Color color) : base(input)
		{
			this.fLength = length;
			base.Color = color;
			this.Init();
		}

		// Token: 0x0600035F RID: 863 RVA: 0x0000F254 File Offset: 0x0000E254
		protected override void Calculate(int index)
		{
			double num = double.NaN;
			if (index >= this.fLength - 1 + this.fInput.FirstIndex)
			{
				num = 0.0;
				int num2 = -(Indicator.SyncIndex ? 0 : 1) * 2 * this.fLength;
				if (index >= this.fLength - 1 + this.fInput.FirstIndex)
				{
					for (int i = index; i >= index - this.fLength + 1; i--)
					{
						num += this.fInput[i, this.fOption] / (double)this.fLength;
					}
				}
				else
				{
					num = base[index - 1 + num2] + (this.fInput[index, this.fOption] - this.fInput[index - this.fLength, this.fOption]) / (double)this.fLength;
				}
			}
			this.Add(this.fInput.GetDateTime(index), num);
		}

		// Token: 0x06000360 RID: 864 RVA: 0x0000F344 File Offset: 0x0000E344
		public static double Value(TimeSeries input, int index, int length, BarData option)
		{
			if (index >= length - 1 + input.FirstIndex)
			{
				double num = 0.0;
				for (int i = index; i >= index - length + 1; i--)
				{
					num += input[i, option];
				}
				return num / (double)length;
			}
			return double.NaN;
		}

		// Token: 0x06000361 RID: 865 RVA: 0x0000F391 File Offset: 0x0000E391
		public static double Value(DoubleSeries input, int index, int length)
		{
			return SMA.Value(input, index, length, BarData.Close);
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0000F39C File Offset: 0x0000E39C
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

		// Token: 0x040000A5 RID: 165
		protected int fLength = 14;

		// Token: 0x040000A6 RID: 166
		protected BarData fOption;
	}
}
