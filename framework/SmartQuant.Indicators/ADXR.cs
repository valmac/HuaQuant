using System;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x02000045 RID: 69
	[Serializable]
	public class ADXR : Indicator
	{
		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000363 RID: 867 RVA: 0x0000F3F5 File Offset: 0x0000E3F5
		// (set) Token: 0x06000364 RID: 868 RVA: 0x0000F3FD File Offset: 0x0000E3FD
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

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000365 RID: 869 RVA: 0x0000F40C File Offset: 0x0000E40C
		// (set) Token: 0x06000366 RID: 870 RVA: 0x0000F414 File Offset: 0x0000E414
		[Category("Parameters")]
		[Description("")]
		[IndicatorParameter(1)]
		public EIndicatorStyle Style
		{
			get
			{
				return this.fStyle;
			}
			set
			{
				this.fStyle = value;
				this.Init();
			}
		}

		// Token: 0x06000367 RID: 871 RVA: 0x0000F424 File Offset: 0x0000E424
		protected override void Init()
		{
			this.fName = "ADXR (" + this.fLength + ")";
			this.fTitle = "Average Directional Index Rating";
			this.Clear();
			this.fCalculate = true;
			if (this.fInput == null)
			{
				return;
			}
			if (TimeSeries.fNameOption == ENameOption.Long)
			{
				this.fName = this.fInput.Name + " " + this.fName;
			}
			base.Disconnect();
			this.fADX = new ADX(this.fInput, this.fLength, this.fStyle);
			this.fADX.DrawEnabled = false;
			this.Connect();
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0000F4D0 File Offset: 0x0000E4D0
		public ADXR()
		{
			this.Init();
		}

		// Token: 0x06000369 RID: 873 RVA: 0x0000F4E6 File Offset: 0x0000E4E6
		public ADXR(TimeSeries input, int length, EIndicatorStyle style) : base(input)
		{
			this.fLength = length;
			this.fStyle = style;
			this.Init();
		}

		// Token: 0x0600036A RID: 874 RVA: 0x0000F50B File Offset: 0x0000E50B
		public ADXR(TimeSeries input, int length, EIndicatorStyle style, Color color) : base(input)
		{
			this.fLength = length;
			this.fStyle = style;
			this.Init();
			base.Color = color;
		}

		// Token: 0x0600036B RID: 875 RVA: 0x0000F538 File Offset: 0x0000E538
		public ADXR(TimeSeries input, int length, EIndicatorStyle style, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.fLength = length;
			this.fStyle = style;
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x0600036C RID: 876 RVA: 0x0000F56D File Offset: 0x0000E56D
		public ADXR(TimeSeries input, int length) : base(input)
		{
			this.fLength = length;
			this.Init();
		}

		// Token: 0x0600036D RID: 877 RVA: 0x0000F58B File Offset: 0x0000E58B
		public ADXR(TimeSeries input, int length, Color color) : base(input)
		{
			this.fLength = length;
			base.Color = color;
			this.Init();
		}

		// Token: 0x0600036E RID: 878 RVA: 0x0000F5B0 File Offset: 0x0000E5B0
		protected override void Calculate(int index)
		{
			if (index >= 3 * this.fLength - 1 + this.fInput.FirstIndex)
			{
				int num = -(Indicator.SyncIndex ? 0 : 1) * 2 * this.fLength;
				double num2 = this.fADX[index + num];
				double num3 = this.fADX[index - this.fLength + 1 + num];
				double data = (num2 + num3) / 2.0;
				this.Add(this.fInput.GetDateTime(index), data);
				return;
			}
			this.Add(this.fInput.GetDateTime(index), double.NaN);
		}

		// Token: 0x0600036F RID: 879 RVA: 0x0000F65C File Offset: 0x0000E65C
		public static double Value(TimeSeries input, int index, int length, EIndicatorStyle style)
		{
			if (index >= 3 * length - 1 + input.FirstIndex)
			{
				double num = ADX.Value(input, index, length, style);
				double num2 = ADX.Value(input, index - length + 1, length, style);
				return (num + num2) / 2.0;
			}
			return double.NaN;
		}

		// Token: 0x06000370 RID: 880 RVA: 0x0000F6B3 File Offset: 0x0000E6B3
		public static double Value(TimeSeries input, int index, int length)
		{
			return ADXR.Value(input, index, length, EIndicatorStyle.QuantStudio);
		}

		// Token: 0x06000371 RID: 881 RVA: 0x0000F6C0 File Offset: 0x0000E6C0
		public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
		{
			if (this.fMonitored)
			{
				int index = this.fInput.GetIndex(EventArgs.DateTime);
				if (index != -1)
				{
					if (this.fStyle == EIndicatorStyle.QuantStudio)
					{
						for (int i = index; i <= Math.Min(this.fInput.Count - 1, index + 3 * this.fLength - 1); i++)
						{
							this.Calculate(i);
						}
						return;
					}
					for (int j = index; j <= this.fInput.Count - 1; j++)
					{
						this.Calculate(j);
					}
				}
			}
		}

		// Token: 0x06000372 RID: 882 RVA: 0x0000F743 File Offset: 0x0000E743
		public override void Detach()
		{
			this.fADX.Detach();
			base.Detach();
		}

		// Token: 0x040000A7 RID: 167
		protected EIndicatorStyle fStyle;

		// Token: 0x040000A8 RID: 168
		protected int fLength = 14;

		// Token: 0x040000A9 RID: 169
		protected ADX fADX;
	}
}
