using System;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x0200003B RID: 59
	[Serializable]
	public class CCI : Indicator
	{
		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x0000D426 File Offset: 0x0000C426
		// (set) Token: 0x060002F2 RID: 754 RVA: 0x0000D42E File Offset: 0x0000C42E
		[Category("Parameters")]
		[Description("")]
		[IndicatorParameter(0)]
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

		// Token: 0x060002F3 RID: 755 RVA: 0x0000D440 File Offset: 0x0000C440
		protected override void Init()
		{
			this.fName = "CCI (" + this.fLength + ")";
			this.fTitle = "Commodity Channel Index";
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

		// Token: 0x060002F4 RID: 756 RVA: 0x0000D4B7 File Offset: 0x0000C4B7
		public CCI()
		{
			this.Init();
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x0000D4CD File Offset: 0x0000C4CD
		public CCI(TimeSeries input, int length) : base(input)
		{
			this.fLength = length;
			this.Init();
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x0000D4EB File Offset: 0x0000C4EB
		public CCI(TimeSeries input, int length, Color color) : base(input)
		{
			this.fLength = length;
			this.Init();
			base.Color = color;
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0000D510 File Offset: 0x0000C510
		public CCI(TimeSeries input, int length, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.fLength = length;
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x0000D540 File Offset: 0x0000C540
		protected override void Calculate(int index)
		{
			double data = CCI.Value(this.fInput, index, this.fLength);
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0000D574 File Offset: 0x0000C574
		public static double Value(TimeSeries input, int index, int length)
		{
			if (index >= length - 1 + input.FirstIndex)
			{
				double num = 0.0;
				for (int i = index - length + 1; i <= index; i++)
				{
					num += input[i, BarData.Typical];
				}
				num /= (double)length;
				double num2 = 0.0;
				for (int j = index - length + 1; j <= index; j++)
				{
					num2 += Math.Abs(input[j, BarData.Typical] - num);
				}
				num2 /= (double)length;
				return (input[index, BarData.Typical] - num) / (0.015 * num2);
			}
			return double.NaN;
		}

		// Token: 0x060002FA RID: 762 RVA: 0x0000D620 File Offset: 0x0000C620
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

		// Token: 0x0400008F RID: 143
		protected int fLength = 14;
	}
}
