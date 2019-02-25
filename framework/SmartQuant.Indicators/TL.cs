using System;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x0200002A RID: 42
	[Serializable]
	public class TL : Indicator
	{
		// Token: 0x06000222 RID: 546 RVA: 0x0000A7E0 File Offset: 0x000097E0
		protected override void Init()
		{
			this.fName = "TL";
			this.fTitle = "True Low";
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

		// Token: 0x06000223 RID: 547 RVA: 0x0000A842 File Offset: 0x00009842
		public TL()
		{
			this.Init();
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0000A850 File Offset: 0x00009850
		public TL(TimeSeries input) : base(input)
		{
			this.Init();
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0000A85F File Offset: 0x0000985F
		public TL(TimeSeries input, Color color) : base(input)
		{
			this.Init();
			base.Color = color;
		}

		// Token: 0x06000226 RID: 550 RVA: 0x0000A875 File Offset: 0x00009875
		public TL(TimeSeries input, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x06000227 RID: 551 RVA: 0x0000A894 File Offset: 0x00009894
		protected override void Calculate(int index)
		{
			double data = TL.Value(this.fInput, index);
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0000A8C4 File Offset: 0x000098C4
		public static double Value(TimeSeries input, int index)
		{
			if (index >= 1 + input.FirstIndex)
			{
				double val = input[index, BarData.Low];
				double val2 = input[index - 1, BarData.Close];
				return Math.Min(val, val2);
			}
			return double.NaN;
		}

		// Token: 0x06000229 RID: 553 RVA: 0x0000A904 File Offset: 0x00009904
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
