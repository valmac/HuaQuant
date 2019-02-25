using System;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x02000020 RID: 32
	[Serializable]
	public class MFI : Indicator
	{
		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x00008DB0 File Offset: 0x00007DB0
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x00008DB8 File Offset: 0x00007DB8
		[Description("")]
		[IndicatorParameter(0)]
		[Category("Parameters")]
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

		// Token: 0x060001B5 RID: 437 RVA: 0x00008DC8 File Offset: 0x00007DC8
		protected override void Init()
		{
			this.fName = "MFI (" + this.fLength + ")";
			this.fTitle = "Money Flow Index";
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

		// Token: 0x060001B6 RID: 438 RVA: 0x00008E3F File Offset: 0x00007E3F
		public MFI()
		{
			this.Init();
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00008E55 File Offset: 0x00007E55
		public MFI(TimeSeries input, int length) : base(input)
		{
			this.fLength = length;
			this.Init();
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00008E73 File Offset: 0x00007E73
		public MFI(TimeSeries input, int length, Color color) : base(input)
		{
			this.fLength = length;
			this.Init();
			base.Color = color;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00008E98 File Offset: 0x00007E98
		public MFI(TimeSeries input, int length, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.fLength = length;
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00008EC8 File Offset: 0x00007EC8
		protected override void Calculate(int index)
		{
			double data = MFI.Value(this.fInput, index, this.fLength);
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00008EFC File Offset: 0x00007EFC
		public static double Value(TimeSeries input, int index, int length)
		{
			if (index >= length + input.FirstIndex)
			{
				double num = 0.0;
				double num2 = 0.0;
				for (int i = index; i > index - length; i--)
				{
					double num3 = input[i, BarData.Typical];
					double num4 = input[i - 1, BarData.Typical];
					double num5 = input[i, BarData.Volume];
					double num6 = input[i - 1, BarData.Volume];
					if (num3 > num4)
					{
						num += num3 * num5;
					}
					else
					{
						num2 += num3 * num5;
					}
				}
				double num7 = num / num2;
				return 100.0 - 100.0 / (1.0 + num7);
			}
			return double.NaN;
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00008FAC File Offset: 0x00007FAC
		public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
		{
			if (this.fMonitored)
			{
				int index = this.fInput.GetIndex(EventArgs.DateTime);
				if (index != -1)
				{
					for (int i = index; i <= Math.Min(this.fInput.Count - 1, index + this.fLength); i++)
					{
						this.Calculate(i);
					}
				}
			}
		}

		// Token: 0x04000055 RID: 85
		protected int fLength = 14;
	}
}
