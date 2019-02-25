using System;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x0200000E RID: 14
	[Serializable]
	public class PVI : Indicator
	{
		// Token: 0x060000CA RID: 202 RVA: 0x00005130 File Offset: 0x00004130
		protected override void Init()
		{
			this.fName = "PVI";
			this.fTitle = "Positive Volume Index";
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

		// Token: 0x060000CB RID: 203 RVA: 0x00005199 File Offset: 0x00004199
		public PVI()
		{
			this.Init();
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000051A7 File Offset: 0x000041A7
		public PVI(TimeSeries input) : base(input)
		{
			this.Init();
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000051B6 File Offset: 0x000041B6
		public PVI(TimeSeries input, Color color) : base(input)
		{
			this.Init();
			base.Color = color;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x000051CC File Offset: 0x000041CC
		public PVI(TimeSeries input, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x000051EC File Offset: 0x000041EC
		protected override void Calculate(int index)
		{
			double data = double.NaN;
			if (index >= 1 + this.fInput.FirstIndex)
			{
				double num = this.fInput[index, BarData.Close];
				double num2 = this.fInput[index - 1, BarData.Close];
				double num3 = this.fInput[index, BarData.Volume];
				double num4 = this.fInput[index - 1, BarData.Volume];
				double num5 = base[index - 1];
				if (num3 > num4)
				{
					data = num5 + num5 * (num - num2) / num2;
				}
				else
				{
					data = num5;
				}
			}
			if (index == this.fInput.FirstIndex)
			{
				data = 10000.0;
			}
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0000529C File Offset: 0x0000429C
		public static double Value(TimeSeries input, int index)
		{
			if (index >= 1 + input.FirstIndex)
			{
				double num = input[index, BarData.Close];
				double num2 = input[index - 1, BarData.Close];
				double num3 = input[index, BarData.Volume];
				double num4 = input[index - 1, BarData.Volume];
				double num5 = PVI.Value(input, index - 1);
				double result;
				if (num3 > num4)
				{
					result = num5 + num5 * (num - num2) / num2;
				}
				else
				{
					result = num5;
				}
				return result;
			}
			if (index == input.FirstIndex)
			{
				return 10000.0;
			}
			return double.NaN;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00005328 File Offset: 0x00004328
		public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
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
