using System;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x02000003 RID: 3
	[Serializable]
	public class ROC : Indicator
	{
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00002C00 File Offset: 0x00001C00
		// (set) Token: 0x0600003B RID: 59 RVA: 0x00002C08 File Offset: 0x00001C08
		[IndicatorParameter(1)]
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

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00002C17 File Offset: 0x00001C17
		// (set) Token: 0x0600003D RID: 61 RVA: 0x00002C1F File Offset: 0x00001C1F
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

		// Token: 0x0600003E RID: 62 RVA: 0x00002C30 File Offset: 0x00001C30
		protected override void Init()
		{
			this.fName = "ROC (" + this.fLength + ")";
			this.fTitle = "Price Rate of Change";
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
					"ROC (",
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

		// Token: 0x0600003F RID: 63 RVA: 0x00002CFB File Offset: 0x00001CFB
		public ROC()
		{
			this.Init();
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002D11 File Offset: 0x00001D11
		public ROC(TimeSeries input, int length, BarData option) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002D36 File Offset: 0x00001D36
		public ROC(TimeSeries input, int length, BarData option, Color color) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
			base.Color = color;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002D63 File Offset: 0x00001D63
		public ROC(TimeSeries input, int length, BarData option, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002D98 File Offset: 0x00001D98
		public ROC(TimeSeries input, int length) : base(input)
		{
			this.fLength = length;
			this.Init();
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002DB6 File Offset: 0x00001DB6
		public ROC(TimeSeries input, int length, Color color) : base(input)
		{
			this.fLength = length;
			base.Color = color;
			this.Init();
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002DDC File Offset: 0x00001DDC
		protected override void Calculate(int index)
		{
			double data = ROC.Value(this.fInput, index, this.fLength, this.fOption);
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002E18 File Offset: 0x00001E18
		public static double Value(TimeSeries input, int index, int length, BarData option)
		{
			if (index >= length + input.FirstIndex)
			{
				return (input[index, option] - input[index - length, option]) / input[index - length, option] * 100.0;
			}
			return double.NaN;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002E64 File Offset: 0x00001E64
		public static double Value(DoubleSeries input, int index, int length)
		{
			return ROC.Value(input, index, length, BarData.Close);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002E70 File Offset: 0x00001E70
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

		// Token: 0x04000009 RID: 9
		protected int fLength = 14;

		// Token: 0x0400000A RID: 10
		protected BarData fOption;
	}
}
