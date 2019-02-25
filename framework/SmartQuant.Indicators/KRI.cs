using System;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x02000015 RID: 21
	[Serializable]
	public class KRI : Indicator
	{
		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600012D RID: 301 RVA: 0x00006D68 File Offset: 0x00005D68
		// (set) Token: 0x0600012E RID: 302 RVA: 0x00006D70 File Offset: 0x00005D70
		[Description("")]
		[Category("Parameters")]
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

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600012F RID: 303 RVA: 0x00006D7F File Offset: 0x00005D7F
		// (set) Token: 0x06000130 RID: 304 RVA: 0x00006D87 File Offset: 0x00005D87
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

		// Token: 0x06000131 RID: 305 RVA: 0x00006D98 File Offset: 0x00005D98
		protected override void Init()
		{
			this.fName = "KRI (" + this.fLength + ")";
			this.fTitle = "Kairi Indicator";
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
					"KRI (",
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

		// Token: 0x06000132 RID: 306 RVA: 0x00006E63 File Offset: 0x00005E63
		public KRI()
		{
			this.Init();
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00006E79 File Offset: 0x00005E79
		public KRI(TimeSeries input, int length, BarData option) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00006E9E File Offset: 0x00005E9E
		public KRI(TimeSeries input, int length, BarData option, Color color) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
			base.Color = color;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00006ECB File Offset: 0x00005ECB
		public KRI(TimeSeries input, int length, BarData option, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00006F00 File Offset: 0x00005F00
		public KRI(TimeSeries input, int length) : base(input)
		{
			this.fLength = length;
			this.Init();
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00006F1E File Offset: 0x00005F1E
		public KRI(TimeSeries input, int length, Color color) : base(input)
		{
			this.fLength = length;
			base.Color = color;
			this.Init();
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00006F44 File Offset: 0x00005F44
		protected override void Calculate(int index)
		{
			double data = KRI.Value(this.fInput, index, this.fLength, this.fOption);
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00006F80 File Offset: 0x00005F80
		public static double Value(TimeSeries input, int index, int length, BarData option)
		{
			if (index >= length - 1 + input.FirstIndex)
			{
				double num = SMA.Value(input, index, length, option);
				return (input[index, option] - num) / num * 100.0;
			}
			return double.NaN;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00006FC6 File Offset: 0x00005FC6
		public static double Value(DoubleSeries input, int index, int length)
		{
			return KRI.Value(input, index, length, BarData.Close);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00006FD4 File Offset: 0x00005FD4
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

		// Token: 0x04000041 RID: 65
		protected int fLength = 14;

		// Token: 0x04000042 RID: 66
		protected BarData fOption;
	}
}
