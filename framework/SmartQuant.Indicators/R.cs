using System;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x02000030 RID: 48
	[Serializable]
	public class R : Indicator
	{
		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600027A RID: 634 RVA: 0x0000B9DD File Offset: 0x0000A9DD
		// (set) Token: 0x0600027B RID: 635 RVA: 0x0000B9E5 File Offset: 0x0000A9E5
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

		// Token: 0x0600027C RID: 636 RVA: 0x0000B9F4 File Offset: 0x0000A9F4
		protected override void Init()
		{
			this.fName = "%R (" + this.fLength + ")";
			this.fTitle = "Williams %R";
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

		// Token: 0x0600027D RID: 637 RVA: 0x0000BA6B File Offset: 0x0000AA6B
		public R()
		{
			this.Init();
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0000BA81 File Offset: 0x0000AA81
		public R(TimeSeries input, int length) : base(input)
		{
			this.fLength = length;
			this.Init();
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0000BA9F File Offset: 0x0000AA9F
		public R(TimeSeries input, int length, Color color) : base(input)
		{
			this.fLength = length;
			this.Init();
			base.Color = color;
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0000BAC4 File Offset: 0x0000AAC4
		public R(TimeSeries input, int length, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.fLength = length;
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0000BAF4 File Offset: 0x0000AAF4
		protected override void Calculate(int index)
		{
			double data = R.Value(this.fInput, index, this.fLength);
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0000BB28 File Offset: 0x0000AB28
		public static double Value(TimeSeries input, int index, int length)
		{
			if (index >= length - 1 + input.FirstIndex)
			{
				double num = input[index, BarData.Close];
				double min = input.GetMin(index - length + 1, index, BarData.Low);
				double max = input.GetMax(index - length + 1, index, BarData.High);
				return -100.0 * (max - num) / (max - min);
			}
			return double.NaN;
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0000BB84 File Offset: 0x0000AB84
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

		// Token: 0x04000074 RID: 116
		protected int fLength = 14;
	}
}
