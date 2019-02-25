using System;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x0200003C RID: 60
	[Serializable]
	public class TH : Indicator
	{
		// Token: 0x060002FB RID: 763 RVA: 0x0000D678 File Offset: 0x0000C678
		protected override void Init()
		{
			this.fName = "TH";
			this.fTitle = "True High";
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

		// Token: 0x060002FC RID: 764 RVA: 0x0000D6DA File Offset: 0x0000C6DA
		public TH()
		{
			this.Init();
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0000D6E8 File Offset: 0x0000C6E8
		public TH(TimeSeries input) : base(input)
		{
			this.Init();
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0000D6F7 File Offset: 0x0000C6F7
		public TH(TimeSeries input, Color color) : base(input)
		{
			this.Init();
			base.Color = color;
		}

		// Token: 0x060002FF RID: 767 RVA: 0x0000D70D File Offset: 0x0000C70D
		public TH(TimeSeries input, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x06000300 RID: 768 RVA: 0x0000D72C File Offset: 0x0000C72C
		protected override void Calculate(int index)
		{
			double data = TH.Value(this.fInput, index);
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x06000301 RID: 769 RVA: 0x0000D75C File Offset: 0x0000C75C
		public static double Value(TimeSeries input, int index)
		{
			if (index >= 1 + input.FirstIndex)
			{
				double val = input[index, BarData.High];
				double val2 = input[index - 1, BarData.Close];
				return Math.Max(val, val2);
			}
			return double.NaN;
		}

		// Token: 0x06000302 RID: 770 RVA: 0x0000D79C File Offset: 0x0000C79C
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
