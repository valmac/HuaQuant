using System;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x0200001D RID: 29
	[Serializable]
	public class PCU : Indicator
	{
		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600018B RID: 395 RVA: 0x00008545 File Offset: 0x00007545
		// (set) Token: 0x0600018C RID: 396 RVA: 0x0000854D File Offset: 0x0000754D
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

		// Token: 0x0600018D RID: 397 RVA: 0x0000855C File Offset: 0x0000755C
		protected override void Init()
		{
			this.fName = "PCU (" + this.fLength + ")";
			this.fTitle = "Price Channel Upper";
			this.fType = EIndicatorType.Price;
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

		// Token: 0x0600018E RID: 398 RVA: 0x000085DA File Offset: 0x000075DA
		public PCU()
		{
			this.Init();
		}

		// Token: 0x0600018F RID: 399 RVA: 0x000085F0 File Offset: 0x000075F0
		public PCU(TimeSeries input, int length) : base(input)
		{
			this.fLength = length;
			this.Init();
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0000860E File Offset: 0x0000760E
		public PCU(TimeSeries input, int length, Color color) : base(input)
		{
			this.fLength = length;
			this.Init();
			base.Color = color;
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00008633 File Offset: 0x00007633
		public PCU(TimeSeries input, int length, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.fLength = length;
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00008660 File Offset: 0x00007660
		protected override void Calculate(int index)
		{
			double data = PCU.Value(this.fInput, index, this.fLength);
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00008694 File Offset: 0x00007694
		public static double Value(TimeSeries input, int index, int length)
		{
			if (index >= length + input.FirstIndex)
			{
				return input.GetMax(index - length, index - 1, BarData.High);
			}
			return double.NaN;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x000086C8 File Offset: 0x000076C8
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

		// Token: 0x0400004E RID: 78
		protected int fLength = 14;
	}
}
