using System;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x02000009 RID: 9
	[Serializable]
	public class PDI : Indicator
	{
		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00003ED3 File Offset: 0x00002ED3
		// (set) Token: 0x06000085 RID: 133 RVA: 0x00003EDB File Offset: 0x00002EDB
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

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00003EEA File Offset: 0x00002EEA
		// (set) Token: 0x06000087 RID: 135 RVA: 0x00003EF2 File Offset: 0x00002EF2
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

		// Token: 0x06000088 RID: 136 RVA: 0x00003F04 File Offset: 0x00002F04
		protected override void Init()
		{
			this.fName = "PDI (" + this.fLength + ")";
			this.fTitle = "Plus Directional Indicator";
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
			this.fPDM = new DoubleSeries();
			this.fTR = new DoubleSeries();
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00003F91 File Offset: 0x00002F91
		public PDI()
		{
			this.Init();
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00003FA7 File Offset: 0x00002FA7
		public PDI(TimeSeries input, int length, EIndicatorStyle style) : base(input)
		{
			this.fLength = length;
			this.fStyle = style;
			this.Init();
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00003FCC File Offset: 0x00002FCC
		public PDI(TimeSeries input, int length, EIndicatorStyle style, Color color) : base(input)
		{
			this.fLength = length;
			this.fStyle = style;
			this.Init();
			base.Color = color;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00003FF9 File Offset: 0x00002FF9
		public PDI(TimeSeries input, int length, EIndicatorStyle style, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.fLength = length;
			this.fStyle = style;
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000402E File Offset: 0x0000302E
		public PDI(TimeSeries input, int length) : base(input)
		{
			this.fLength = length;
			this.Init();
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000404C File Offset: 0x0000304C
		public PDI(TimeSeries input, int length, Color color) : base(input)
		{
			this.fLength = length;
			base.Color = color;
			this.Init();
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00004074 File Offset: 0x00003074
		protected override void Calculate(int index)
		{
			double data = double.NaN;
			if (this.fStyle == EIndicatorStyle.QuantStudio)
			{
				double num = 0.0;
				double num2 = 0.0;
				if (index >= this.fLength + this.fInput.FirstIndex)
				{
					if (index == this.fLength + this.fInput.FirstIndex)
					{
						for (int i = index; i >= index - this.fLength + 1; i--)
						{
							num2 += TR.Value(this.fInput, i);
							num += PDM.Value(this.fInput, i);
						}
					}
					else
					{
						num = this.fPDM[index - 1] - PDM.Value(this.fInput, index - this.fLength) + PDM.Value(this.fInput, index);
						num2 = this.fTR[index - 1] - TR.Value(this.fInput, index - this.fLength) + TR.Value(this.fInput, index);
					}
					if (num2 != 0.0)
					{
						data = num / num2 * 100.0;
					}
				}
				this.fPDM.Add(this.fInput.GetDateTime(index), num);
				this.fTR.Add(this.fInput.GetDateTime(index), num2);
			}
			else
			{
				double num3 = 0.0;
				double num4 = 0.0;
				if (index >= this.fLength + this.fInput.FirstIndex)
				{
					if (index == this.fLength + this.fInput.FirstIndex)
					{
						for (int j = index; j >= index - this.fLength + 1; j--)
						{
							num4 += TR.Value(this.fInput, j);
							num3 += PDM.Value(this.fInput, j);
						}
					}
					else
					{
						num3 = this.fPDM[index - 1] - this.fPDM[index - 1] / (double)this.fLength + PDM.Value(this.fInput, index);
						num4 = this.fTR[index - 1] - this.fTR[index - 1] / (double)this.fLength + TR.Value(this.fInput, index);
					}
					if (num4 != 0.0)
					{
						data = num3 / num4 * 100.0;
					}
				}
				this.fPDM.Add(this.fInput.GetDateTime(index), num3);
				this.fTR.Add(this.fInput.GetDateTime(index), num4);
			}
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00004308 File Offset: 0x00003308
		public static double Value(TimeSeries input, int index, int length, EIndicatorStyle style)
		{
			if (style == EIndicatorStyle.QuantStudio)
			{
				double num = 0.0;
				double num2 = 0.0;
				if (index >= length + input.FirstIndex)
				{
					for (int i = index; i > index - length; i--)
					{
						num2 += TR.Value(input, i);
						num += PDM.Value(input, i);
					}
					return num / num2 * 100.0;
				}
				return double.NaN;
			}
			else
			{
				double num3 = 0.0;
				double num4 = 0.0;
				if (index >= length + input.FirstIndex)
				{
					for (int j = length + input.FirstIndex; j >= input.FirstIndex + 1; j--)
					{
						num4 += TR.Value(input, j);
						num3 += PDM.Value(input, j);
					}
					for (int k = length + 1 + input.FirstIndex; k <= index; k++)
					{
						num3 = num3 - num3 / (double)length + PDM.Value(input, k);
						num4 = num4 - num4 / (double)length + TR.Value(input, k);
					}
					return num3 / num4 * 100.0;
				}
				return double.NaN;
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00004440 File Offset: 0x00003440
		public static double Value(TimeSeries input, int index, int length)
		{
			return PDI.Value(input, index, length, EIndicatorStyle.QuantStudio);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000444C File Offset: 0x0000344C
		public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
		{
			if (this.fMonitored)
			{
				int index = this.fInput.GetIndex(EventArgs.DateTime);
				if (index != -1)
				{
					if (this.fStyle == EIndicatorStyle.QuantStudio)
					{
						for (int i = index; i <= Math.Min(this.fInput.Count - 1, index + this.fLength); i++)
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

		// Token: 0x04000016 RID: 22
		protected EIndicatorStyle fStyle;

		// Token: 0x04000017 RID: 23
		protected int fLength = 14;

		// Token: 0x04000018 RID: 24
		protected DoubleSeries fPDM;

		// Token: 0x04000019 RID: 25
		protected DoubleSeries fTR;
	}
}
