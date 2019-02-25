using System;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x02000006 RID: 6
	[Serializable]
	public class AD : Indicator
	{
		// Token: 0x06000065 RID: 101 RVA: 0x00003788 File Offset: 0x00002788
		protected override void Init()
		{
			this.fName = "AD ";
			this.fTitle = "Accumulation/Distribution";
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

		// Token: 0x06000066 RID: 102 RVA: 0x000037EA File Offset: 0x000027EA
		public AD()
		{
			this.Init();
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000037F8 File Offset: 0x000027F8
		public AD(TimeSeries input) : base(input)
		{
			this.Init();
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00003807 File Offset: 0x00002807
		public AD(TimeSeries input, Color color) : base(input)
		{
			this.Init();
			base.Color = color;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000381D File Offset: 0x0000281D
		public AD(TimeSeries input, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000383C File Offset: 0x0000283C
		protected override void Calculate(int index)
		{
			double num = this.fInput[index, BarData.High];
			double num2 = this.fInput[index, BarData.Low];
			double num3 = this.fInput[index, BarData.Close];
			double num4 = this.fInput[index, BarData.Open];
			double num5 = this.fInput[index, BarData.Volume];
			double data = double.NaN;
			if (index >= this.fInput.FirstIndex + 1)
			{
				int num6 = -(Indicator.SyncIndex ? 0 : 1);
				if (num != num2)
				{
					data = num5 * (num3 - num2 - (num - num3)) / (num - num2) + base[index - 1];
				}
				else
				{
					data = base[index - 1 + num6];
				}
			}
			if (index == this.fInput.FirstIndex && num != num2)
			{
				data = num5 * (num3 - num2 - (num - num3)) / (num - num2);
			}
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000391C File Offset: 0x0000291C
		public static double Value(TimeSeries input, int index)
		{
			double result = 0.0;
			if (index >= input.FirstIndex)
			{
				double num = input[index, BarData.High];
				double num2 = input[index, BarData.Low];
				double num3 = input[index, BarData.Close];
				double num4 = input[index, BarData.Open];
				double num5 = input[index, BarData.Volume];
				if (index >= input.FirstIndex + 1)
				{
					if (num != num2)
					{
						result = num5 * (num3 - num2 - (num - num3)) / (num - num2) + AD.Value(input, index - 1);
					}
					else
					{
						result = AD.Value(input, index - 1);
					}
				}
				if (index == input.FirstIndex && num != num2)
				{
					result = num5 * (num3 - num2 - (num - num3)) / (num - num2);
				}
			}
			else
			{
				result = double.NaN;
			}
			return result;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000039CC File Offset: 0x000029CC
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
