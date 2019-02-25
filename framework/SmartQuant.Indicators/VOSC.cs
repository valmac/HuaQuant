using System;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x02000034 RID: 52
	[Serializable]
	public class VOSC : Indicator
	{
		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000293 RID: 659 RVA: 0x0000BE9D File Offset: 0x0000AE9D
		// (set) Token: 0x06000294 RID: 660 RVA: 0x0000BEA5 File Offset: 0x0000AEA5
		[Description("")]
		[IndicatorParameter(0)]
		[Category("Parameters")]
		public int Length1
		{
			get
			{
				return this.fLength1;
			}
			set
			{
				this.fLength1 = value;
				this.Init();
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000295 RID: 661 RVA: 0x0000BEB4 File Offset: 0x0000AEB4
		// (set) Token: 0x06000296 RID: 662 RVA: 0x0000BEBC File Offset: 0x0000AEBC
		[Description("")]
		[Category("Parameters")]
		[IndicatorParameter(1)]
		public int Length2
		{
			get
			{
				return this.fLength2;
			}
			set
			{
				this.fLength2 = value;
				this.Init();
			}
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0000BECC File Offset: 0x0000AECC
		protected override void Init()
		{
			this.fName = string.Concat(new object[]
			{
				"VOSC (",
				this.fLength1,
				", ",
				this.fLength2,
				")"
			});
			this.fTitle = "Volume Oscillator";
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

		// Token: 0x06000298 RID: 664 RVA: 0x0000BF71 File Offset: 0x0000AF71
		public VOSC()
		{
			this.Init();
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0000BF8F File Offset: 0x0000AF8F
		public VOSC(TimeSeries input, int length1, int length2) : base(input)
		{
			this.fLength1 = length1;
			this.fLength2 = length2;
			this.Init();
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0000BFBC File Offset: 0x0000AFBC
		public VOSC(TimeSeries input, int length1, int length2, Color color) : base(input)
		{
			this.fLength1 = length1;
			this.fLength2 = length2;
			this.Init();
			base.Color = color;
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0000BFF1 File Offset: 0x0000AFF1
		public VOSC(TimeSeries input, int length1, int length2, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.fLength1 = length1;
			this.fLength2 = length2;
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0000C030 File Offset: 0x0000B030
		protected override void Calculate(int index)
		{
			double data = VOSC.Value(this.fInput, index, this.fLength1, this.fLength2);
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0000C06C File Offset: 0x0000B06C
		public static double Value(TimeSeries input, int index, int length1, int length2)
		{
			if (index >= length1 - 1 + input.FirstIndex && index >= length2 - 1 + input.FirstIndex)
			{
				DoubleSeries doubleSeries = new DoubleSeries();
				for (int i = index; i > index - Math.Max(length1, length2); i--)
				{
					doubleSeries.Add(input.GetDateTime(i), input[i, BarData.Volume]);
				}
				double num = SMA.Value(doubleSeries, length1 - 1, length1, BarData.Close);
				double num2 = SMA.Value(doubleSeries, length2 - 1, length2, BarData.Close);
				return num - num2;
			}
			return double.NaN;
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0000C0F8 File Offset: 0x0000B0F8
		public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
		{
			if (this.fMonitored)
			{
				int index = this.fInput.GetIndex(EventArgs.DateTime);
				if (index != -1)
				{
					for (int i = index; i <= Math.Min(this.fInput.Count - 1, index + Math.Max(this.fLength1, this.fLength2) - 1); i++)
					{
						this.Calculate(i);
					}
				}
			}
		}

		// Token: 0x0400007E RID: 126
		protected int fLength1 = 14;

		// Token: 0x0400007F RID: 127
		protected int fLength2 = 10;
	}
}
