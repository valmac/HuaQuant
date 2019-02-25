using System;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x0200001B RID: 27
	[Serializable]
	public class D_Fast : Indicator
	{
		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000174 RID: 372 RVA: 0x00008067 File Offset: 0x00007067
		// (set) Token: 0x06000175 RID: 373 RVA: 0x0000806F File Offset: 0x0000706F
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

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000176 RID: 374 RVA: 0x0000807E File Offset: 0x0000707E
		// (set) Token: 0x06000177 RID: 375 RVA: 0x00008086 File Offset: 0x00007086
		[IndicatorParameter(1)]
		[Description("")]
		[Category("Parameters")]
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

		// Token: 0x06000178 RID: 376 RVA: 0x00008098 File Offset: 0x00007098
		protected override void Init()
		{
			this.fName = string.Concat(new object[]
			{
				"%D Fast (",
				this.fLength,
				", ",
				this.fOrder,
				")"
			});
			this.fTitle = "%D Fast";
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

		// Token: 0x06000179 RID: 377 RVA: 0x00008165 File Offset: 0x00007165
		public D_Fast()
		{
			this.Init();
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00008183 File Offset: 0x00007183
		public D_Fast(TimeSeries input, int length, int order) : base(input)
		{
			this.fLength = length;
			this.fOrder = order;
			this.Init();
		}

		// Token: 0x0600017B RID: 379 RVA: 0x000081B0 File Offset: 0x000071B0
		public D_Fast(TimeSeries input, int length, int order, Color color) : base(input)
		{
			this.fLength = length;
			this.fOrder = order;
			this.Init();
			base.Color = color;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x000081E5 File Offset: 0x000071E5
		public D_Fast(TimeSeries input, int length, int order, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.fLength = length;
			this.fOrder = order;
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00008224 File Offset: 0x00007224
		protected override void Calculate(int index)
		{
			double data = D_Fast.Value(this.fInput, index, this.fLength, this.fOrder);
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00008260 File Offset: 0x00007260
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

		// Token: 0x0600017F RID: 383 RVA: 0x000082EC File Offset: 0x000072EC
		public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
		{
			if (this.fMonitored)
			{
				int index = this.fInput.GetIndex(EventArgs.DateTime);
				if (index != -1)
				{
					for (int i = index; i <= this.fInput.Count - 1; i++)
					{
						this.Calculate(i);
					}
				}
			}
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00008336 File Offset: 0x00007336
		public override void Detach()
		{
			this.fK.Detach();
			base.Detach();
		}

		// Token: 0x0400004A RID: 74
		protected int fLength = 14;

		// Token: 0x0400004B RID: 75
		protected int fOrder = 10;

		// Token: 0x0400004C RID: 76
		private K_Fast fK;
	}
}
