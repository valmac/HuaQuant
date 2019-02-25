using System;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x02000021 RID: 33
	[Serializable]
	public class ATR : Indicator
	{
		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060001BD RID: 445 RVA: 0x00009003 File Offset: 0x00008003
		// (set) Token: 0x060001BE RID: 446 RVA: 0x0000900B File Offset: 0x0000800B
		[Description("")]
		[Category("Parameters")]
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

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060001BF RID: 447 RVA: 0x0000901A File Offset: 0x0000801A
		// (set) Token: 0x060001C0 RID: 448 RVA: 0x00009022 File Offset: 0x00008022
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

		// Token: 0x060001C1 RID: 449 RVA: 0x00009034 File Offset: 0x00008034
		protected override void Init()
		{
			this.fName = "ATR (" + this.fLength + ")";
			this.fTitle = "Average True Range";
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
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x000090AB File Offset: 0x000080AB
		public ATR()
		{
			this.Init();
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x000090C1 File Offset: 0x000080C1
		public ATR(TimeSeries input, int length, EIndicatorStyle style) : base(input)
		{
			this.fLength = length;
			this.fStyle = style;
			this.Init();
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x000090E6 File Offset: 0x000080E6
		public ATR(TimeSeries input, int length, EIndicatorStyle style, Color color) : base(input)
		{
			this.fLength = length;
			this.fStyle = style;
			this.Init();
			base.Color = color;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00009113 File Offset: 0x00008113
		public ATR(TimeSeries input, int length, EIndicatorStyle style, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.fLength = length;
			this.fStyle = style;
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00009148 File Offset: 0x00008148
		public ATR(TimeSeries input, int length) : base(input)
		{
			this.fLength = length;
			this.Init();
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00009166 File Offset: 0x00008166
		public ATR(TimeSeries input, int length, Color color) : base(input)
		{
			this.fLength = length;
			base.Color = color;
			this.Init();
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0000918C File Offset: 0x0000818C
		protected override void Calculate(int index)
		{
			if (index >= this.fLength + this.fInput.FirstIndex)
			{
				int num = -(Indicator.SyncIndex ? 0 : 1) * this.fLength;
				double data;
				if (this.fStyle == EIndicatorStyle.QuantStudio)
				{
					if (index == this.fLength + this.fInput.FirstIndex)
					{
						double num2 = 0.0;
						for (int i = index; i > index - this.fLength; i--)
						{
							num2 += TR.Value(this.fInput, i);
						}
						data = num2 / (double)this.fLength;
					}
					else
					{
						double num3 = TR.Value(this.fInput, index);
						data = (base[index - 1 + num] * (double)this.fLength + num3 - TR.Value(this.fInput, index - this.fLength)) / (double)this.fLength;
					}
				}
				else if (index == this.fLength + this.fInput.FirstIndex)
				{
					double num4 = 0.0;
					for (int j = index; j > index - this.fLength; j--)
					{
						num4 += TR.Value(this.fInput, j);
					}
					data = num4 / (double)this.fLength;
				}
				else
				{
					double num3 = TR.Value(this.fInput, index);
					data = (base[index - 1 + num] * (double)(this.fLength - 1) + num3) / (double)this.fLength;
				}
				this.Add(this.fInput.GetDateTime(index), data);
				return;
			}
			this.Add(this.fInput.GetDateTime(index), double.NaN);
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00009330 File Offset: 0x00008330
		public static double Value(TimeSeries input, int index, int length, EIndicatorStyle style)
		{
			if (index >= length + input.FirstIndex)
			{
				double num = 0.0;
				double result;
				if (style == EIndicatorStyle.QuantStudio)
				{
					for (int i = index; i > index - length; i--)
					{
						num += TR.Value(input, i);
					}
					result = num / (double)length;
				}
				else
				{
					for (int j = length + input.FirstIndex; j > input.FirstIndex; j--)
					{
						num += TR.Value(input, j);
					}
					num /= (double)length;
					for (int k = length + 1 + input.FirstIndex; k <= index; k++)
					{
						num = (num * (double)(length - 1) + TR.Value(input, k)) / (double)length;
					}
					result = num;
				}
				return result;
			}
			return double.NaN;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x000093E1 File Offset: 0x000083E1
		public static double Value(TimeSeries input, int index, int length)
		{
			return ATR.Value(input, index, length, EIndicatorStyle.QuantStudio);
		}

		// Token: 0x060001CB RID: 459 RVA: 0x000093EC File Offset: 0x000083EC
		public static double Value(TimeSeries input, int length)
		{
			return ATR.Value(input, input.LastIndex, length);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x000093FC File Offset: 0x000083FC
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

		// Token: 0x04000056 RID: 86
		protected EIndicatorStyle fStyle;

		// Token: 0x04000057 RID: 87
		protected int fLength = 14;
	}
}
