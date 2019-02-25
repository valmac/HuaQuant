using System;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x02000004 RID: 4
	[Serializable]
	public class DX : Indicator
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00002EC7 File Offset: 0x00001EC7
		// (set) Token: 0x0600004A RID: 74 RVA: 0x00002ECF File Offset: 0x00001ECF
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

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00002EDE File Offset: 0x00001EDE
		// (set) Token: 0x0600004C RID: 76 RVA: 0x00002EE6 File Offset: 0x00001EE6
		[IndicatorParameter(1)]
		[Description("")]
		[Category("Parameters")]
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

		// Token: 0x0600004D RID: 77 RVA: 0x00002EF8 File Offset: 0x00001EF8
		protected override void Init()
		{
			this.fName = "DX (" + this.fLength + ")";
			this.fTitle = "Directional Movement Index";
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
			this.fMDM = new DoubleSeries();
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002F85 File Offset: 0x00001F85
		public DX()
		{
			this.Init();
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002F9B File Offset: 0x00001F9B
		public DX(TimeSeries input, int length, EIndicatorStyle style) : base(input)
		{
			this.fLength = length;
			this.fStyle = style;
			this.Init();
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002FC0 File Offset: 0x00001FC0
		public DX(TimeSeries input, int length, EIndicatorStyle style, Color color) : base(input)
		{
			this.fLength = length;
			this.fStyle = style;
			this.Init();
			base.Color = color;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002FED File Offset: 0x00001FED
		public DX(TimeSeries input, int length, EIndicatorStyle style, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.fLength = length;
			this.fStyle = style;
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00003022 File Offset: 0x00002022
		public DX(TimeSeries input, int length) : base(input)
		{
			this.fLength = length;
			this.Init();
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00003040 File Offset: 0x00002040
		public DX(TimeSeries input, int length, Color color) : base(input)
		{
			this.fLength = length;
			base.Color = color;
			this.Init();
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00003068 File Offset: 0x00002068
		protected override void Calculate(int index)
		{
			if (this.fStyle == EIndicatorStyle.QuantStudio)
			{
				double num = 0.0;
				double num2 = 0.0;
				double data = 0.0;
				if (index >= this.fLength + this.fInput.FirstIndex)
				{
					if (index == this.fLength + this.fInput.FirstIndex)
					{
						for (int i = index; i >= index - this.fLength + 1; i--)
						{
							num += PDM.Value(this.fInput, i);
							num2 += MDM.Value(this.fInput, i);
						}
					}
					else
					{
						num2 = this.fMDM[index - 1] - MDM.Value(this.fInput, index - this.fLength) + MDM.Value(this.fInput, index);
						num = this.fPDM[index - 1] - PDM.Value(this.fInput, index - this.fLength) + PDM.Value(this.fInput, index);
					}
					if (num + num2 != 0.0)
					{
						data = Math.Abs(num - num2) / (num + num2) * 100.0;
					}
					this.Add(this.fInput.GetDateTime(index), data);
				}
				else
				{
					this.Add(this.fInput.GetDateTime(index), double.NaN);
				}
				this.fPDM.Add(this.fInput.GetDateTime(index), num);
				this.fMDM.Add(this.fInput.GetDateTime(index), num2);
				return;
			}
			double num3 = 0.0;
			double num4 = 0.0;
			double data2 = 0.0;
			if (index >= this.fLength + this.fInput.FirstIndex)
			{
				if (index == this.fLength + this.fInput.FirstIndex)
				{
					for (int j = index; j >= index - this.fLength + 1; j--)
					{
						num3 += PDM.Value(this.fInput, j);
						num4 += MDM.Value(this.fInput, j);
					}
				}
				else
				{
					num3 = this.fPDM[index - 1] - this.fPDM[index - 1] / (double)this.fLength + PDM.Value(this.fInput, index);
					num4 = this.fMDM[index - 1] - this.fMDM[index - 1] / (double)this.fLength + MDM.Value(this.fInput, index);
				}
				if (num3 + num4 != 0.0)
				{
					data2 = Math.Abs(num3 - num4) / (num3 + num4) * 100.0;
				}
				this.Add(this.fInput.GetDateTime(index), data2);
			}
			else
			{
				this.Add(this.fInput.GetDateTime(index), double.NaN);
			}
			this.fPDM.Add(this.fInput.GetDateTime(index), num3);
			this.fMDM.Add(this.fInput.GetDateTime(index), num4);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000336C File Offset: 0x0000236C
		public static double Value(TimeSeries input, int index, int length, EIndicatorStyle style)
		{
			if (index >= length + input.FirstIndex)
			{
				double result = 0.0;
				double num = PDI.Value(input, index, length, style);
				double num2 = MDI.Value(input, index, length, style);
				if (num + num2 != 0.0)
				{
					result = 100.0 * Math.Abs(num - num2) / (num + num2);
				}
				return result;
			}
			return double.NaN;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000033D2 File Offset: 0x000023D2
		public static double Value(TimeSeries input, int index, int length)
		{
			return DX.Value(input, index, length, EIndicatorStyle.QuantStudio);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000033E0 File Offset: 0x000023E0
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

		// Token: 0x0400000B RID: 11
		protected EIndicatorStyle fStyle;

		// Token: 0x0400000C RID: 12
		protected int fLength = 14;

		// Token: 0x0400000D RID: 13
		protected DoubleSeries fPDM;

		// Token: 0x0400000E RID: 14
		protected DoubleSeries fMDM;
	}
}
