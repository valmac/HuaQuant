using System;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x02000008 RID: 8
	[Serializable]
	public class CMO : Indicator
	{
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00003BCA File Offset: 0x00002BCA
		// (set) Token: 0x06000076 RID: 118 RVA: 0x00003BD2 File Offset: 0x00002BD2
		[Category("Parameters")]
		[Description("")]
		[IndicatorParameter(1)]
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

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00003BE1 File Offset: 0x00002BE1
		// (set) Token: 0x06000078 RID: 120 RVA: 0x00003BE9 File Offset: 0x00002BE9
		[Category("Parameters")]
		[Description("")]
		[IndicatorParameter(0)]
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

		// Token: 0x06000079 RID: 121 RVA: 0x00003BF8 File Offset: 0x00002BF8
		protected override void Init()
		{
			this.fName = "CMO (" + this.fLength + ")";
			this.fTitle = "Change Momentum Oscillator";
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
					"CMO (",
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

		// Token: 0x0600007A RID: 122 RVA: 0x00003CC3 File Offset: 0x00002CC3
		public CMO()
		{
			this.Init();
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00003CD9 File Offset: 0x00002CD9
		public CMO(TimeSeries input, int length, BarData option) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00003CFE File Offset: 0x00002CFE
		public CMO(TimeSeries input, int length, BarData option, Color color) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
			base.Color = color;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00003D2B File Offset: 0x00002D2B
		public CMO(TimeSeries input, int length, BarData option, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00003D60 File Offset: 0x00002D60
		public CMO(TimeSeries input, int length) : base(input)
		{
			this.fLength = length;
			this.Init();
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00003D7E File Offset: 0x00002D7E
		public CMO(TimeSeries input, int length, Color color) : base(input)
		{
			this.fLength = length;
			base.Color = color;
			this.Init();
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00003DA4 File Offset: 0x00002DA4
		protected override void Calculate(int index)
		{
			double data = CMO.Value(this.fInput, index, this.fLength, this.fOption);
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00003DE0 File Offset: 0x00002DE0
		public static double Value(TimeSeries input, int index, int length, BarData option)
		{
			double num = 0.0;
			double num2 = 0.0;
			if (index >= length + input.FirstIndex)
			{
				for (int i = index; i > index - length; i--)
				{
					double num3 = input[i, option] - input[i - 1, option];
					if (num3 > 0.0)
					{
						num += num3;
					}
					else
					{
						num2 -= num3;
					}
				}
				return 100.0 * (num - num2) / (num + num2);
			}
			return double.NaN;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00003E6F File Offset: 0x00002E6F
		public static double Value(DoubleSeries input, int index, int length)
		{
			return CMO.Value(input, index, length, BarData.Close);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00003E7C File Offset: 0x00002E7C
		public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
		{
			if (this.fMonitored)
			{
				int index = this.fInput.GetIndex(EventArgs.DateTime);
				if (index != -1)
				{
					for (int i = index; i <= Math.Min(this.fInput.Count - 1, index + this.fLength); i++)
					{
						this.Calculate(i);
					}
				}
			}
		}

		// Token: 0x04000014 RID: 20
		protected int fLength = 14;

		// Token: 0x04000015 RID: 21
		protected BarData fOption;
	}
}
