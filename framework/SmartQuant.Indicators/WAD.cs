using System;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x0200003A RID: 58
	[Serializable]
	public class WAD : Indicator
	{
		// Token: 0x060002E9 RID: 745 RVA: 0x0000D1B0 File Offset: 0x0000C1B0
		protected override void Init()
		{
			this.fName = "WAD";
			this.fTitle = "Williams Accumulation/Distribution";
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

		// Token: 0x060002EA RID: 746 RVA: 0x0000D212 File Offset: 0x0000C212
		public WAD()
		{
			this.Init();
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0000D220 File Offset: 0x0000C220
		public WAD(TimeSeries input) : base(input)
		{
			this.Init();
		}

		// Token: 0x060002EC RID: 748 RVA: 0x0000D22F File Offset: 0x0000C22F
		public WAD(TimeSeries input, Color color) : base(input)
		{
			this.Init();
			base.Color = color;
		}

		// Token: 0x060002ED RID: 749 RVA: 0x0000D245 File Offset: 0x0000C245
		public WAD(TimeSeries input, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0000D264 File Offset: 0x0000C264
		protected override void Calculate(int index)
		{
			double data = 0.0;
			if (index >= this.fInput.FirstIndex + 1)
			{
				double val = this.fInput[index, BarData.High];
				double val2 = this.fInput[index, BarData.Low];
				double num = this.fInput[index, BarData.Close];
				double num2 = this.fInput[index - 1, BarData.Close];
				double num3 = this.fInput[index, BarData.Volume];
				if (num > num2)
				{
					data = base[index - 1] + num - Math.Min(val2, num2);
				}
				if (num < num2)
				{
					data = base[index - 1] + num - Math.Max(val, num2);
				}
				if (num == num2)
				{
					data = base[index - 1];
				}
			}
			else
			{
				data = 0.0;
			}
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0000D33C File Offset: 0x0000C33C
		public static double Value(TimeSeries input, int index)
		{
			if (index >= input.FirstIndex + 1)
			{
				double val = input[index, BarData.High];
				double val2 = input[index, BarData.Low];
				double num = input[index, BarData.Close];
				double num2 = input[index - 1, BarData.Close];
				double result = 0.0;
				double num3 = input[index, BarData.Volume];
				if (num > num2)
				{
					result = WAD.Value(input, index - 1) + num - Math.Min(val2, num2);
				}
				if (num < num2)
				{
					result = WAD.Value(input, index - 1) + num - Math.Max(val, num2);
				}
				if (num == num2)
				{
					result = WAD.Value(input, index - 1);
				}
				return result;
			}
			return 0.0;
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0000D3DC File Offset: 0x0000C3DC
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
