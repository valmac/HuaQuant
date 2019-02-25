using System;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x0200000C RID: 12
	[Serializable]
	public class ADX : Indicator
	{
		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000AB RID: 171 RVA: 0x000049C9 File Offset: 0x000039C9
		// (set) Token: 0x060000AC RID: 172 RVA: 0x000049D1 File Offset: 0x000039D1
		[Category("Parameters")]
		[IndicatorParameter(0)]
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

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000AD RID: 173 RVA: 0x000049E0 File Offset: 0x000039E0
		// (set) Token: 0x060000AE RID: 174 RVA: 0x000049E8 File Offset: 0x000039E8
		[IndicatorParameter(1)]
		[Category("Parameters")]
		[Description("")]
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

		// Token: 0x060000AF RID: 175 RVA: 0x000049F8 File Offset: 0x000039F8
		protected override void Init()
		{
			this.fName = "ADX (" + this.fLength + ")";
			this.fTitle = "Average Directional Index";
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
			this.fDX = new DX(this.fInput, this.fLength, this.fStyle);
			this.fDX.DrawEnabled = false;
			this.Connect();
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00004AA4 File Offset: 0x00003AA4
		public ADX()
		{
			this.Init();
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00004ABA File Offset: 0x00003ABA
		public ADX(TimeSeries input, int length, EIndicatorStyle style) : base(input)
		{
			this.fLength = length;
			this.fStyle = style;
			this.Init();
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00004ADF File Offset: 0x00003ADF
		public ADX(TimeSeries input, int length, EIndicatorStyle style, Color color) : base(input)
		{
			this.fLength = length;
			this.fStyle = style;
			this.Init();
			base.Color = color;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00004B0C File Offset: 0x00003B0C
		public ADX(TimeSeries input, int length, EIndicatorStyle style, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.fLength = length;
			this.fStyle = style;
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00004B41 File Offset: 0x00003B41
		public ADX(TimeSeries input, int length) : base(input)
		{
			this.fLength = length;
			this.Init();
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00004B5F File Offset: 0x00003B5F
		public ADX(TimeSeries input, int length, Color color) : base(input)
		{
			this.fLength = length;
			base.Color = color;
			this.Init();
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00004B84 File Offset: 0x00003B84
		protected override void Calculate(int index)
		{
			if (index >= 2 * this.fLength + this.fInput.FirstIndex)
			{
				double num = 0.0;
				int num2 = -(Indicator.SyncIndex ? 0 : 1) * 2 * this.fLength;
				int num3 = -(Indicator.SyncIndex ? 0 : 1) * this.fLength;
				if (index == 2 * this.fLength + this.fInput.FirstIndex)
				{
					for (int i = index; i > index - this.fLength; i--)
					{
						num += this.fDX[i + num3];
					}
				}
				else if (this.fStyle == EIndicatorStyle.QuantStudio)
				{
					num = base[index - 1 + num2] * (double)this.fLength - this.fDX[index - this.fLength + num3] + this.fDX[index + num3];
				}
				else
				{
					num = base[index - 1 + num2] * (double)(this.fLength - 1) + this.fDX[index + num3];
				}
				double data = num / (double)this.fLength;
				this.Add(this.fInput.GetDateTime(index), data);
				return;
			}
			this.Add(this.fInput.GetDateTime(index), double.NaN);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00004CCC File Offset: 0x00003CCC
		public static double Value(TimeSeries input, int index, int length, EIndicatorStyle style)
		{
			if (index >= 2 * length + input.FirstIndex)
			{
				double num = 0.0;
				double result;
				if (style == EIndicatorStyle.QuantStudio)
				{
					for (int i = index; i > index - length; i--)
					{
						num += DX.Value(input, i, length);
					}
					result = num / (double)length;
				}
				else
				{
					for (int j = 2 * length + input.FirstIndex; j > length + input.FirstIndex; j--)
					{
						num += DX.Value(input, j, length, style);
					}
					num /= (double)length;
					for (int k = 2 * length + 1 + input.FirstIndex; k <= index; k++)
					{
						num = (num * (double)(length - 1) + DX.Value(input, k, length, style)) / (double)length;
					}
					result = num;
				}
				return result;
			}
			return double.NaN;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00004D8A File Offset: 0x00003D8A
		public static double Value(TimeSeries input, int index, int length)
		{
			return ADX.Value(input, index, length, EIndicatorStyle.QuantStudio);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00004D98 File Offset: 0x00003D98
		public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
		{
			if (this.fMonitored)
			{
				int index = this.fInput.GetIndex(EventArgs.DateTime);
				if (index != -1)
				{
					if (this.fStyle == EIndicatorStyle.QuantStudio)
					{
						for (int i = index; i <= Math.Min(this.fInput.Count - 1, index + 2 * this.fLength); i++)
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

		// Token: 0x060000BA RID: 186 RVA: 0x00004E19 File Offset: 0x00003E19
		public override void Detach()
		{
			this.fDX.Detach();
			base.Detach();
		}

		// Token: 0x0400001D RID: 29
		protected EIndicatorStyle fStyle;

		// Token: 0x0400001E RID: 30
		protected int fLength = 14;

		// Token: 0x0400001F RID: 31
		protected DX fDX;
	}
}
