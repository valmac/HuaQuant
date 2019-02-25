using System;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x02000016 RID: 22
	[Serializable]
	public class ENVU : Indicator
	{
		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600013C RID: 316 RVA: 0x0000702D File Offset: 0x0000602D
		// (set) Token: 0x0600013D RID: 317 RVA: 0x00007035 File Offset: 0x00006035
		[Category("Parameters")]
		[IndicatorParameter(2)]
		[Description("")]
		public BarData Option
		{
			get
			{
				return this.fOption;
			}
			set
			{
				this.fOption = value;
				this.Init();
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600013E RID: 318 RVA: 0x00007044 File Offset: 0x00006044
		// (set) Token: 0x0600013F RID: 319 RVA: 0x0000704C File Offset: 0x0000604C
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

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000140 RID: 320 RVA: 0x0000705B File Offset: 0x0000605B
		// (set) Token: 0x06000141 RID: 321 RVA: 0x00007063 File Offset: 0x00006063
		[Description("")]
		[IndicatorParameter(1)]
		[Category("Parameters")]
		public new double Shift
		{
			get
			{
				return this.fShift;
			}
			set
			{
				this.fShift = value;
				this.Init();
			}
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00007074 File Offset: 0x00006074
		protected override void Init()
		{
			this.fName = string.Concat(new object[]
			{
				"ENVU (",
				this.fLength,
				", ",
				this.fShift,
				")"
			});
			this.fTitle = "Envelope Upper";
			this.fType = EIndicatorType.Price;
			this.Clear();
			this.fCalculate = true;
			if (this.fInput == null)
			{
				return;
			}
			if (this.fInput is BarSeries)
			{
				this.fName = string.Concat(new object[]
				{
					"ENVU (",
					this.fLength,
					", ",
					this.fShift,
					", ",
					this.fOption,
					")"
				});
			}
			if (TimeSeries.fNameOption == ENameOption.Long)
			{
				this.fName = this.fInput.Name + " " + this.fName;
			}
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00007183 File Offset: 0x00006183
		public ENVU()
		{
			this.Init();
		}

		// Token: 0x06000144 RID: 324 RVA: 0x000071A8 File Offset: 0x000061A8
		public ENVU(TimeSeries input, int length, double shift, BarData option) : base(input)
		{
			this.fLength = length;
			this.fShift = shift;
			this.fOption = option;
			this.Init();
		}

		// Token: 0x06000145 RID: 325 RVA: 0x000071E4 File Offset: 0x000061E4
		public ENVU(TimeSeries input, int length, double shift, BarData option, Color color) : base(input)
		{
			this.fLength = length;
			this.fShift = shift;
			this.fOption = option;
			this.Init();
			base.Color = color;
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00007234 File Offset: 0x00006234
		public ENVU(TimeSeries input, int length, double shift, BarData option, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.fLength = length;
			this.fShift = shift;
			this.fOption = option;
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x06000147 RID: 327 RVA: 0x0000728B File Offset: 0x0000628B
		public ENVU(TimeSeries input, int length, double shift) : base(input)
		{
			this.fLength = length;
			this.fShift = shift;
			this.Init();
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000072BF File Offset: 0x000062BF
		public ENVU(TimeSeries input, int length, double shift, Color color) : base(input)
		{
			this.fLength = length;
			this.fShift = shift;
			base.Color = color;
			this.Init();
		}

		// Token: 0x06000149 RID: 329 RVA: 0x000072FC File Offset: 0x000062FC
		protected override void Calculate(int index)
		{
			double data = ENVU.Value(this.fInput, index, this.fLength, this.fShift, this.fOption);
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0000733C File Offset: 0x0000633C
		public static double Value(TimeSeries input, int index, int length, double shift, BarData option)
		{
			if (index >= length - 1 + input.FirstIndex)
			{
				double num = SMA.Value(input, index, length, option);
				return num + num * (shift / 100.0);
			}
			return double.NaN;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00007386 File Offset: 0x00006386
		public static double Value(DoubleSeries input, int index, int length, double shift)
		{
			return ENVU.Value(input, index, length, shift, BarData.Close);
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00007394 File Offset: 0x00006394
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

		// Token: 0x04000043 RID: 67
		protected int fLength = 14;

		// Token: 0x04000044 RID: 68
		protected double fShift = 20.0;

		// Token: 0x04000045 RID: 69
		protected BarData fOption;
	}
}
