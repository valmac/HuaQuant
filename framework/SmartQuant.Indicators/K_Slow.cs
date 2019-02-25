using System;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x0200001E RID: 30
	[Serializable]
	public class K_Slow : Indicator
	{
		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000195 RID: 405 RVA: 0x0000871F File Offset: 0x0000771F
		// (set) Token: 0x06000196 RID: 406 RVA: 0x00008727 File Offset: 0x00007727
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

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000197 RID: 407 RVA: 0x00008736 File Offset: 0x00007736
		// (set) Token: 0x06000198 RID: 408 RVA: 0x0000873E File Offset: 0x0000773E
		[IndicatorParameter(1)]
		[Category("Parameters")]
		[Description("")]
		public int Order
		{
			get
			{
				return this.fOrder;
			}
			set
			{
				this.fOrder = value;
				this.Init();
			}
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00008750 File Offset: 0x00007750
		protected override void Init()
		{
			this.fName = string.Concat(new object[]
			{
				"%K Slow (",
				this.fLength,
				", ",
				this.fOrder,
				")"
			});
			this.fTitle = "%K SLow";
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
			this.fK = new K_Fast(this.fInput, this.fLength);
			this.fK.DrawEnabled = false;
			this.Connect();
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0000881D File Offset: 0x0000781D
		public K_Slow()
		{
			this.Init();
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0000883B File Offset: 0x0000783B
		public K_Slow(TimeSeries input, int length, int order) : base(input)
		{
			this.fLength = length;
			this.fOrder = order;
			this.Init();
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00008868 File Offset: 0x00007868
		public K_Slow(TimeSeries input, int length, int order, Color color) : base(input)
		{
			this.fLength = length;
			this.fOrder = order;
			this.Init();
			base.Color = color;
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0000889D File Offset: 0x0000789D
		public K_Slow(TimeSeries input, int length, int order, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.fLength = length;
			this.fOrder = order;
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x000088DC File Offset: 0x000078DC
		protected override void Calculate(int index)
		{
			double data = K_Slow.Value(this.fInput, index, this.fLength, this.fOrder);
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00008918 File Offset: 0x00007918
		public static double Value(TimeSeries input, int index, int length, int order)
		{
			if (index >= length + order - 1 + input.FirstIndex)
			{
				double num = 0.0;
				for (int i = index; i > index - order; i--)
				{
					double min = input.GetMin(i - length + 1, i, BarData.Low);
					double max = input.GetMax(i - length + 1, i, BarData.High);
					double num2 = input[i, BarData.Close];
					double num3 = max - min;
					double num4 = num2 - min;
					num += 100.0 * num4 / num3;
				}
				return num / (double)order;
			}
			return double.NaN;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x000089A4 File Offset: 0x000079A4
		public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
		{
			if (this.fMonitored)
			{
				int index = this.fInput.GetIndex(EventArgs.DateTime);
				if (index != -1)
				{
					for (int i = index; i <= Math.Min(this.fInput.Count - 1, index + this.fLength + this.fOrder - 1); i++)
					{
						this.Calculate(i);
					}
				}
			}
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00008A04 File Offset: 0x00007A04
		public override void Detach()
		{
			this.fK.Detach();
			base.Detach();
		}

		// Token: 0x0400004F RID: 79
		protected int fLength = 14;

		// Token: 0x04000050 RID: 80
		protected int fOrder = 10;

		// Token: 0x04000051 RID: 81
		protected K_Fast fK;
	}
}
