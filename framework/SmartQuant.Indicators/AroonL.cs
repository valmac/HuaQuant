using System;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x02000022 RID: 34
	[Serializable]
	public class AroonL : Indicator
	{
		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060001CD RID: 461 RVA: 0x0000947B File Offset: 0x0000847B
		// (set) Token: 0x060001CE RID: 462 RVA: 0x00009483 File Offset: 0x00008483
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

		// Token: 0x060001CF RID: 463 RVA: 0x00009494 File Offset: 0x00008494
		protected override void Init()
		{
			this.fName = "AroonL (" + this.fLength + ")";
			this.fTitle = "Aroon Lower";
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

		// Token: 0x060001D0 RID: 464 RVA: 0x0000950B File Offset: 0x0000850B
		public AroonL()
		{
			this.Init();
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00009521 File Offset: 0x00008521
		public AroonL(TimeSeries input, int length) : base(input)
		{
			this.fLength = length;
			this.Init();
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x0000953F File Offset: 0x0000853F
		public AroonL(TimeSeries input, int length, Color color) : base(input)
		{
			this.fLength = length;
			this.Init();
			base.Color = color;
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00009564 File Offset: 0x00008564
		public AroonL(TimeSeries input, int length, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.fLength = length;
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00009594 File Offset: 0x00008594
		protected override void Calculate(int index)
		{
			double data = AroonL.Value(this.fInput, index, this.fLength);
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x000095C8 File Offset: 0x000085C8
		public static double Value(TimeSeries input, int index, int length)
		{
			if (index >= length - 1 + input.FirstIndex)
			{
				double num = input[index, BarData.Low];
				double num2 = (double)index;
				for (int i = index - length + 1; i <= index; i++)
				{
					if (input[i, BarData.Low] < num)
					{
						num2 = (double)i;
						num = input[i, BarData.Low];
					}
				}
				double num3 = (double)index - num2;
				return 100.0 * (1.0 - num3 / (double)length);
			}
			return double.NaN;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00009640 File Offset: 0x00008640
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

		// Token: 0x04000058 RID: 88
		protected int fLength = 14;
	}
}
