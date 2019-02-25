using System;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x0200001C RID: 28
	[Serializable]
	public class VROC : Indicator
	{
		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000181 RID: 385 RVA: 0x00008349 File Offset: 0x00007349
		// (set) Token: 0x06000182 RID: 386 RVA: 0x00008351 File Offset: 0x00007351
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

		// Token: 0x06000183 RID: 387 RVA: 0x00008360 File Offset: 0x00007360
		protected override void Init()
		{
			this.fName = "VROC (" + this.fLength + ")";
			this.fTitle = "Volume Rate of Change";
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

		// Token: 0x06000184 RID: 388 RVA: 0x000083DE File Offset: 0x000073DE
		public VROC()
		{
			this.Init();
		}

		// Token: 0x06000185 RID: 389 RVA: 0x000083F4 File Offset: 0x000073F4
		public VROC(TimeSeries input, int length) : base(input)
		{
			this.fLength = length;
			this.Init();
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00008412 File Offset: 0x00007412
		public VROC(TimeSeries input, int length, Color color) : base(input)
		{
			this.fLength = length;
			this.Init();
			base.Color = color;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00008437 File Offset: 0x00007437
		public VROC(TimeSeries input, int length, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.fLength = length;
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00008464 File Offset: 0x00007464
		protected override void Calculate(int index)
		{
			double data = VROC.Value(this.fInput, index, this.fLength);
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00008498 File Offset: 0x00007498
		public static double Value(TimeSeries input, int index, int length)
		{
			if (index >= length - 1 + input.FirstIndex)
			{
				return (input[index, BarData.Volume] - input[index - length + 1, BarData.Volume]) / input[index - length + 1, BarData.Volume] * 100.0;
			}
			return double.NaN;
		}

		// Token: 0x0600018A RID: 394 RVA: 0x000084EC File Offset: 0x000074EC
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

		// Token: 0x0400004D RID: 77
		protected int fLength = 14;
	}
}
