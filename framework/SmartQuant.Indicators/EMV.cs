using System;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x02000027 RID: 39
	[Serializable]
	public class EMV : Indicator
	{
		// Token: 0x060001F8 RID: 504 RVA: 0x00009DB0 File Offset: 0x00008DB0
		protected override void Init()
		{
			this.fName = "EMV";
			this.fTitle = "Ease of Movement";
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

		// Token: 0x060001F9 RID: 505 RVA: 0x00009E12 File Offset: 0x00008E12
		public EMV()
		{
			this.Init();
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00009E20 File Offset: 0x00008E20
		public EMV(TimeSeries input) : base(input)
		{
			this.Init();
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00009E2F File Offset: 0x00008E2F
		public EMV(TimeSeries input, Color color) : base(input)
		{
			this.Init();
			base.Color = color;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00009E45 File Offset: 0x00008E45
		public EMV(TimeSeries input, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00009E64 File Offset: 0x00008E64
		protected override void Calculate(int index)
		{
			double data = EMV.Value(this.fInput, index);
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00009E94 File Offset: 0x00008E94
		public static double Value(TimeSeries input, int index)
		{
			if (index >= input.FirstIndex + 1)
			{
				double num = input[index, BarData.High];
				double num2 = input[index - 1, BarData.High];
				double num3 = input[index, BarData.Low];
				double num4 = input[index - 1, BarData.Low];
				double num5 = input[index, BarData.Volume];
				double num6 = (num + num3) / 2.0 - (num2 + num4) / 2.0;
				double num7 = num5 / 1000000.0 / (num - num3);
				return num6 / num7;
			}
			return double.NaN;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00009F20 File Offset: 0x00008F20
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
