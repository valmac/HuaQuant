using System;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x02000043 RID: 67
	[Serializable]
	public class AroonU : Indicator
	{
		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600034A RID: 842 RVA: 0x0000EE55 File Offset: 0x0000DE55
		// (set) Token: 0x0600034B RID: 843 RVA: 0x0000EE5D File Offset: 0x0000DE5D
		[IndicatorParameter(0)]
		[Category("Parameters")]
		[Description("")]
		public int Length
		{
			get
			{
				return this.fLength;
			}
			set
			{
				this.fLength = value;
				this.Init();
			}
		}

		// Token: 0x0600034C RID: 844 RVA: 0x0000EE6C File Offset: 0x0000DE6C
		protected override void Init()
		{
			this.fName = "AroonU (" + this.fLength + ")";
			this.fTitle = "Aroon Upper";
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

		// Token: 0x0600034D RID: 845 RVA: 0x0000EEE3 File Offset: 0x0000DEE3
		public AroonU()
		{
			this.Init();
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0000EEF9 File Offset: 0x0000DEF9
		public AroonU(TimeSeries input, int length) : base(input)
		{
			this.fLength = length;
			this.Init();
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0000EF17 File Offset: 0x0000DF17
		public AroonU(TimeSeries input, int length, Color color) : base(input)
		{
			this.fLength = length;
			this.Init();
			base.Color = color;
		}

		// Token: 0x06000350 RID: 848 RVA: 0x0000EF3C File Offset: 0x0000DF3C
		public AroonU(TimeSeries input, int length, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.fLength = length;
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0000EF6C File Offset: 0x0000DF6C
		protected override void Calculate(int index)
		{
			double data = AroonU.Value(this.fInput, index, this.fLength);
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0000EFA0 File Offset: 0x0000DFA0
		public static double Value(TimeSeries input, int index, int length)
		{
			if (index >= length - 1 + input.FirstIndex)
			{
				double num = input[index, BarData.High];
				double num2 = (double)index;
				for (int i = index - length + 1; i <= index; i++)
				{
					if (input[i, BarData.High] > num)
					{
						num2 = (double)i;
						num = input[i, BarData.High];
					}
				}
				double num3 = (double)index - num2;
				return 100.0 * (1.0 - num3 / (double)length);
			}
			return double.NaN;
		}

		// Token: 0x06000353 RID: 851 RVA: 0x0000F018 File Offset: 0x0000E018
		public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
		{
			if (this.fMonitored)
			{
				int index = this.fInput.GetIndex(EventArgs.DateTime);
				if (index != -1)
				{
					for (int i = index; i <= Math.Min(this.fInput.Count - 1, index + this.fLength - 1); i++)
					{
						this.Calculate(i);
					}
				}
			}
		}

		// Token: 0x040000A4 RID: 164
		protected int fLength = 14;
	}
}
