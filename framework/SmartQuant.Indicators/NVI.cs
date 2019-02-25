using System;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x02000019 RID: 25
	[Serializable]
	public class NVI : Indicator
	{
		// Token: 0x0600015D RID: 349 RVA: 0x0000781C File Offset: 0x0000681C
		protected override void Init()
		{
			this.fName = "NVI";
			this.fTitle = "Negative Volume Index";
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

		// Token: 0x0600015E RID: 350 RVA: 0x00007885 File Offset: 0x00006885
		public NVI()
		{
			this.Init();
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00007893 File Offset: 0x00006893
		public NVI(TimeSeries input) : base(input)
		{
			this.Init();
		}

		// Token: 0x06000160 RID: 352 RVA: 0x000078A2 File Offset: 0x000068A2
		public NVI(TimeSeries input, Color color) : base(input)
		{
			this.Init();
			base.Color = color;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x000078B8 File Offset: 0x000068B8
		public NVI(TimeSeries input, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x000078D8 File Offset: 0x000068D8
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
				if (num3 < num4)
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
				data = this.fInput[this.fInput.FirstIndex, BarData.Volume];
			}
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00007998 File Offset: 0x00006998
		public static double Value(TimeSeries input, int index)
		{
			if (index >= 1 + input.FirstIndex)
			{
				double num = input[index, BarData.Close];
				double num2 = input[index - 1, BarData.Close];
				double num3 = input[index, BarData.Volume];
				double num4 = input[index - 1, BarData.Volume];
				double num5 = NVI.Value(input, index - 1);
				double result;
				if (num3 < num4)
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
				return input[input.FirstIndex, BarData.Volume];
			}
			return double.NaN;
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00007A28 File Offset: 0x00006A28
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
