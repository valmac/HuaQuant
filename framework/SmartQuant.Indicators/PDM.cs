using System;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x02000040 RID: 64
	[Serializable]
	public class PDM : Indicator
	{
		// Token: 0x0600032E RID: 814 RVA: 0x0000E8BC File Offset: 0x0000D8BC
		protected override void Init()
		{
			this.fName = "PDM";
			this.fTitle = "Plus Directional Movement";
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

		// Token: 0x0600032F RID: 815 RVA: 0x0000E91E File Offset: 0x0000D91E
		public PDM()
		{
			this.Init();
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0000E92C File Offset: 0x0000D92C
		public PDM(TimeSeries input) : base(input)
		{
			this.Init();
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0000E93B File Offset: 0x0000D93B
		public PDM(TimeSeries input, Color color) : base(input)
		{
			this.Init();
			base.Color = color;
		}

		// Token: 0x06000332 RID: 818 RVA: 0x0000E951 File Offset: 0x0000D951
		public PDM(TimeSeries input, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x06000333 RID: 819 RVA: 0x0000E970 File Offset: 0x0000D970
		protected override void Calculate(int index)
		{
			double data = PDM.Value(this.fInput, index);
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0000E9A0 File Offset: 0x0000D9A0
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
			if (num5 > num6)
			{
				return num5;
			}
			return 0.0;
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0000EA24 File Offset: 0x0000DA24
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
