using System;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x02000026 RID: 38
	[Serializable]
	public class PVT : Indicator
	{
		// Token: 0x060001F0 RID: 496 RVA: 0x00009B7C File Offset: 0x00008B7C
		protected override void Init()
		{
			this.fName = "PVT";
			this.fTitle = "Price and Volume Trend";
			this.fType = EIndicatorType.Volume;
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

		// Token: 0x060001F1 RID: 497 RVA: 0x00009BE5 File Offset: 0x00008BE5
		public PVT()
		{
			this.Init();
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00009BF3 File Offset: 0x00008BF3
		public PVT(TimeSeries input) : base(input)
		{
			this.Init();
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00009C02 File Offset: 0x00008C02
		public PVT(TimeSeries input, Color color) : base(input)
		{
			this.Init();
			base.Color = color;
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00009C18 File Offset: 0x00008C18
		public PVT(TimeSeries input, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00009C38 File Offset: 0x00008C38
		protected override void Calculate(int index)
		{
			double data = double.NaN;
			if (index >= 1 + this.fInput.FirstIndex)
			{
				double num = this.fInput[index, BarData.Close];
				double num2 = this.fInput[index - 1, BarData.Close];
				double num3 = this.fInput[index, BarData.Volume];
				if (index >= 2 + this.fInput.FirstIndex)
				{
					int num4 = -(Indicator.SyncIndex ? 0 : 1);
					data = (num - num2) / num2 * num3 + base[index - 1 + num4];
					this.Add(this.fInput.GetDateTime(index), data);
				}
				else
				{
					data = (num - num2) / num2 * num3;
				}
			}
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00009CF0 File Offset: 0x00008CF0
		public static double Value(TimeSeries input, int index)
		{
			if (index >= 1 + input.FirstIndex)
			{
				double num = input[index, BarData.Close];
				double num2 = input[index - 1, BarData.Close];
				double num3 = input[index, BarData.Volume];
				double result;
				if (index >= 2 + input.FirstIndex)
				{
					result = (num - num2) / num2 * num3 + PVT.Value(input, index - 1);
				}
				else
				{
					result = (num - num2) / num2 * num3;
				}
				return result;
			}
			return double.NaN;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00009D64 File Offset: 0x00008D64
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
	}
}
