using System;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x02000018 RID: 24
	[Serializable]
	public class OBV : Indicator
	{
		// Token: 0x06000155 RID: 341 RVA: 0x00007598 File Offset: 0x00006598
		protected override void Init()
		{
			this.fName = "OBV";
			this.fTitle = "On Balance Volume";
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

		// Token: 0x06000156 RID: 342 RVA: 0x00007601 File Offset: 0x00006601
		public OBV()
		{
			this.Init();
		}

		// Token: 0x06000157 RID: 343 RVA: 0x0000760F File Offset: 0x0000660F
		public OBV(TimeSeries input) : base(input)
		{
			this.Init();
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0000761E File Offset: 0x0000661E
		public OBV(TimeSeries input, Color color) : base(input)
		{
			this.Init();
			base.Color = color;
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00007634 File Offset: 0x00006634
		public OBV(TimeSeries input, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00007654 File Offset: 0x00006654
		protected override void Calculate(int index)
		{
			double data = double.NaN;
			if (index >= 1 + this.fInput.FirstIndex)
			{
				double num = this.fInput[index, BarData.Close];
				double num2 = this.fInput[index - 1, BarData.Close];
				double num3 = this.fInput[index, BarData.Volume];
				int num4 = -(Indicator.SyncIndex ? 0 : 1);
				if (index > 1 + this.fInput.FirstIndex)
				{
					if (num > num2)
					{
						data = base[index - 1 + num4] + num3;
					}
					if (num < num2)
					{
						data = base[index - 1 + num4] - num3;
					}
					if (num == num2)
					{
						data = base[index - 1 + num4];
					}
				}
				else
				{
					if (num > num2)
					{
						data = num3;
					}
					if (num < num2)
					{
						data = -num3;
					}
					if (num == num2)
					{
						data = 0.0;
					}
				}
			}
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00007730 File Offset: 0x00006730
		public static double Value(TimeSeries input, int index)
		{
			if (index >= 1 + input.FirstIndex)
			{
				double num = input[index, BarData.Close];
				double num2 = input[index - 1, BarData.Close];
				double num3 = input[index, BarData.Volume];
				double result = 0.0;
				if (index > 1 + input.FirstIndex)
				{
					if (num > num2)
					{
						result = OBV.Value(input, index - 1) + num3;
					}
					if (num < num2)
					{
						result = OBV.Value(input, index - 1) - num3;
					}
					if (num == num2)
					{
						result = OBV.Value(input, index - 1);
					}
				}
				else
				{
					if (num > num2)
					{
						result = num3;
					}
					if (num < num2)
					{
						result = -num3;
					}
					if (num == num2)
					{
						result = 0.0;
					}
				}
				return result;
			}
			return double.NaN;
		}

		// Token: 0x0600015C RID: 348 RVA: 0x000077D0 File Offset: 0x000067D0
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
