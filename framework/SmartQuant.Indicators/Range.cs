using System;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x02000025 RID: 37
	[Serializable]
	public class Range : Indicator
	{
		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x00009989 File Offset: 0x00008989
		// (set) Token: 0x060001E7 RID: 487 RVA: 0x00009991 File Offset: 0x00008991
		[Category("Parameters")]
		[IndicatorParameter(0)]
		[Description("")]
		public int Length
		{
			get
			{
				return this.length;
			}
			set
			{
				this.length = value;
				this.Init();
			}
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x000099A0 File Offset: 0x000089A0
		protected override void Init()
		{
			this.fName = "Range (" + this.length + ")";
			this.fTitle = "Range";
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

		// Token: 0x060001E9 RID: 489 RVA: 0x00009A17 File Offset: 0x00008A17
		public Range()
		{
			this.Init();
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00009A2D File Offset: 0x00008A2D
		public Range(TimeSeries input, int length) : base(input)
		{
			this.length = length;
			this.Init();
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00009A4B File Offset: 0x00008A4B
		public Range(TimeSeries input, int length, Color color) : base(input)
		{
			this.length = length;
			this.Init();
			this.fColor = color;
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00009A70 File Offset: 0x00008A70
		public Range(TimeSeries input, int length, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.length = length;
			this.Init();
			this.fColor = color;
			this.fDrawStyle = drawStyle;
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00009AA0 File Offset: 0x00008AA0
		protected override void Calculate(int index)
		{
			double data = Range.Value(this.fInput, index, this.length);
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00009AD4 File Offset: 0x00008AD4
		public static double Value(TimeSeries input, int index, int length)
		{
			if (index >= length - 1 + input.FirstIndex)
			{
				double min = input.GetMin(index - length + 1, index, BarData.Low);
				double max = input.GetMax(index - length + 1, index, BarData.High);
				return Math.Log(max / min);
			}
			return double.NaN;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00009B20 File Offset: 0x00008B20
		public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
		{
			if (this.fMonitored)
			{
				int index = this.fInput.GetIndex(EventArgs.DateTime);
				if (index != -1)
				{
					for (int i = index; i <= Math.Min(this.fInput.Count - 1, index + this.length - 1); i++)
					{
						this.Calculate(i);
					}
				}
			}
		}

		// Token: 0x0400005E RID: 94
		protected int length = 14;
	}
}
