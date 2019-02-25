using System;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x02000007 RID: 7
	[Serializable]
	public class MDM : Indicator
	{
		// Token: 0x0600006D RID: 109 RVA: 0x00003A10 File Offset: 0x00002A10
		protected override void Init()
		{
			this.fName = "MDM";
			this.fTitle = "Minus Directional Movement";
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

		// Token: 0x0600006E RID: 110 RVA: 0x00003A72 File Offset: 0x00002A72
		public MDM()
		{
			this.Init();
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00003A80 File Offset: 0x00002A80
		public MDM(TimeSeries input) : base(input)
		{
			this.Init();
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00003A8F File Offset: 0x00002A8F
		public MDM(TimeSeries input, Color color) : base(input)
		{
			this.Init();
			base.Color = color;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00003AA5 File Offset: 0x00002AA5
		public MDM(TimeSeries input, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00003AC4 File Offset: 0x00002AC4
		protected override void Calculate(int index)
		{
			double data = MDM.Value(this.fInput, index);
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00003AF4 File Offset: 0x00002AF4
		public static double Value(TimeSeries input, int index)
		{
			if (index < input.FirstIndex + 1)
			{
				return double.NaN;
			}
			double num = input[index, BarData.High];
			double num2 = input[index, BarData.Low];
			double num3 = input[index - 1, BarData.High];
			double num4 = input[index - 1, BarData.Low];
			double num5 = 0.0;
			double num6 = 0.0;
			if (num > num3)
			{
				num5 = num - num3;
			}
			if (num2 < num4)
			{
				num6 = num4 - num2;
			}
			if (num6 > num5)
			{
				return num6;
			}
			return 0.0;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00003B78 File Offset: 0x00002B78
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
