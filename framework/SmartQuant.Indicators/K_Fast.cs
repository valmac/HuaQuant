using System;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x02000042 RID: 66
	[Serializable]
	public class K_Fast : Indicator
	{
		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000340 RID: 832 RVA: 0x0000EC53 File Offset: 0x0000DC53
		// (set) Token: 0x06000341 RID: 833 RVA: 0x0000EC5B File Offset: 0x0000DC5B
		[Category("Parameters")]
		[IndicatorParameter(0)]
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

		// Token: 0x06000342 RID: 834 RVA: 0x0000EC6C File Offset: 0x0000DC6C
		protected override void Init()
		{
			this.fName = "%K Fast (" + this.fLength + ")";
			this.fTitle = "%K Fast";
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

		// Token: 0x06000343 RID: 835 RVA: 0x0000ECE3 File Offset: 0x0000DCE3
		public K_Fast()
		{
			this.Init();
		}

		// Token: 0x06000344 RID: 836 RVA: 0x0000ECF9 File Offset: 0x0000DCF9
		public K_Fast(TimeSeries input, int length) : base(input)
		{
			this.fLength = length;
			this.Init();
		}

		// Token: 0x06000345 RID: 837 RVA: 0x0000ED17 File Offset: 0x0000DD17
		public K_Fast(TimeSeries input, int length, Color color) : base(input)
		{
			this.fLength = length;
			this.Init();
			base.Color = color;
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0000ED3C File Offset: 0x0000DD3C
		public K_Fast(TimeSeries input, int length, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.fLength = length;
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0000ED6C File Offset: 0x0000DD6C
		protected override void Calculate(int index)
		{
			double data = K_Fast.Value(this.fInput, index, this.fLength);
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0000EDA0 File Offset: 0x0000DDA0
		public static double Value(TimeSeries input, int index, int length)
		{
			if (index >= length - 1 + input.FirstIndex)
			{
				double num = input[index, BarData.Close];
				double min = input.GetMin(index - length + 1, index, BarData.Low);
				double max = input.GetMax(index - length + 1, index, BarData.High);
				return 100.0 * (num - min) / (max - min);
			}
			return double.NaN;
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0000EDFC File Offset: 0x0000DDFC
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

		// Token: 0x040000A3 RID: 163
		protected int fLength = 14;
	}
}
