using System;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x02000012 RID: 18
	[Serializable]
	public class UltOsc : Indicator
	{
		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000105 RID: 261 RVA: 0x00005F48 File Offset: 0x00004F48
		// (set) Token: 0x06000106 RID: 262 RVA: 0x00005F50 File Offset: 0x00004F50
		[Description("")]
		[IndicatorParameter(0)]
		[Category("Parameters")]
		public int N1
		{
			get
			{
				return this.fN1;
			}
			set
			{
				this.fN1 = value;
				this.Init();
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000107 RID: 263 RVA: 0x00005F5F File Offset: 0x00004F5F
		// (set) Token: 0x06000108 RID: 264 RVA: 0x00005F67 File Offset: 0x00004F67
		[Category("Parameters")]
		[Description("")]
		[IndicatorParameter(1)]
		public int N2
		{
			get
			{
				return this.fN2;
			}
			set
			{
				this.fN2 = value;
				this.Init();
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000109 RID: 265 RVA: 0x00005F76 File Offset: 0x00004F76
		// (set) Token: 0x0600010A RID: 266 RVA: 0x00005F7E File Offset: 0x00004F7E
		[IndicatorParameter(2)]
		[Description("")]
		[Category("Parameters")]
		public int N3
		{
			get
			{
				return this.fN3;
			}
			set
			{
				this.fN3 = value;
				this.Init();
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00005F90 File Offset: 0x00004F90
		protected override void Init()
		{
			this.fName = string.Concat(new object[]
			{
				"UOSC (",
				this.fN1,
				", ",
				this.fN2,
				", ",
				this.fN3,
				")"
			});
			this.fTitle = "Ultimate Oscillator";
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

		// Token: 0x0600010C RID: 268 RVA: 0x00006044 File Offset: 0x00005044
		public UltOsc()
		{
			this.Init();
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00006069 File Offset: 0x00005069
		public UltOsc(TimeSeries input, int n1, int n2, int n3) : base(input)
		{
			this.fN1 = n1;
			this.fN2 = n2;
			this.fN3 = n3;
			this.Init();
		}

		// Token: 0x0600010E RID: 270 RVA: 0x000060A8 File Offset: 0x000050A8
		public UltOsc(TimeSeries input, int n1, int n2, int n3, Color color) : base(input)
		{
			this.fN1 = n1;
			this.fN2 = n2;
			this.fN3 = n3;
			this.Init();
			base.Color = color;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x000060F8 File Offset: 0x000050F8
		public UltOsc(TimeSeries input, int n1, int n2, int n3, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.fN1 = n1;
			this.fN2 = n2;
			this.fN3 = n3;
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00006150 File Offset: 0x00005150
		protected override void Calculate(int index)
		{
			double data = UltOsc.Value(this.fInput, index, this.fN1, this.fN2, this.fN3);
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00006190 File Offset: 0x00005190
		public static double Value(TimeSeries input, int index, int n1, int n2, int n3)
		{
			if (index >= Math.Max(n1, Math.Max(n2, n3)) + input.FirstIndex)
			{
				double num = 0.0;
				double num2 = 0.0;
				for (int i = index; i > index - n1; i--)
				{
					double num3 = input[i, BarData.Close];
					double val = input[i - 1, BarData.Close];
					double val2 = input[i, BarData.Low];
					num += num3 - Math.Min(val2, val);
					num2 += TR.Value(input, i);
				}
				double num4 = (double)(n3 / n1) * (num / num2);
				num = 0.0;
				num2 = 0.0;
				for (int j = index; j > index - n2; j--)
				{
					double num3 = input[j, BarData.Close];
					double val = input[j - 1, BarData.Close];
					double val2 = input[j, BarData.Low];
					num += num3 - Math.Min(val2, val);
					num2 += TR.Value(input, j);
				}
				double num5 = (double)(n3 / n2) * (num / num2);
				num = 0.0;
				num2 = 0.0;
				for (int k = index; k > index - n3; k--)
				{
					double num3 = input[k, BarData.Close];
					double val = input[k - 1, BarData.Close];
					double val2 = input[k, BarData.Low];
					num += num3 - Math.Min(val2, val);
					num2 += TR.Value(input, k);
				}
				double num6 = num / num2;
				return (num4 + num5 + num6) / (double)(n3 / n1 + n3 / n2 + 1) * 100.0;
			}
			return double.NaN;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00006350 File Offset: 0x00005350
		public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
		{
			if (this.fMonitored)
			{
				int index = this.fInput.GetIndex(EventArgs.DateTime);
				if (index != -1)
				{
					for (int i = index; i <= Math.Min(this.fInput.Count - 1, index + Math.Max(this.fN1, Math.Max(this.fN2, this.fN3))); i++)
					{
						this.Calculate(i);
					}
				}
			}
		}

		// Token: 0x0400002C RID: 44
		protected int fN1 = 14;

		// Token: 0x0400002D RID: 45
		protected int fN2 = 10;

		// Token: 0x0400002E RID: 46
		protected int fN3 = 5;
	}
}
