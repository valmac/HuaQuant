using System;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x02000017 RID: 23
	[Serializable]
	public class TR : Indicator
	{
		// Token: 0x0600014D RID: 333 RVA: 0x000073F0 File Offset: 0x000063F0
		protected override void Init()
		{
			this.fName = "TR";
			this.fTitle = "True Range";
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

		// Token: 0x0600014E RID: 334 RVA: 0x00007452 File Offset: 0x00006452
		public TR()
		{
			this.Init();
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00007460 File Offset: 0x00006460
		public TR(TimeSeries input) : base(input)
		{
			this.Init();
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0000746F File Offset: 0x0000646F
		public TR(TimeSeries input, Color color) : base(input)
		{
			this.Init();
			base.Color = color;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00007485 File Offset: 0x00006485
		public TR(TimeSeries input, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x000074A4 File Offset: 0x000064A4
		protected override void Calculate(int index)
		{
			double data = TR.Value(this.fInput, index);
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x000074D4 File Offset: 0x000064D4
		public static double Value(TimeSeries input, int index)
		{
			if (index >= input.FirstIndex + 1)
			{
				double num = input[index, BarData.High];
				double num2 = input[index, BarData.Low];
				double num3 = input[index - 1, BarData.Close];
				double val = Math.Abs(num - num2);
				double val2 = Math.Abs(num - num3);
				double val3 = Math.Abs(num3 - num2);
				return Math.Max(val, Math.Max(val2, val3));
			}
			return double.NaN;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00007544 File Offset: 0x00006544
		public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
		{
			if (this.fMonitored)
			{
				int index = this.fInput.GetIndex(EventArgs.DateTime);
				if (index != -1)
				{
					for (int i = index; i <= Math.Min(this.fInput.Count - 1, index + 1); i++)
					{
						this.Calculate(i);
					}
				}
			}
		}
	}
}
