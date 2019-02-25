using System;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x02000005 RID: 5
	[Serializable]
	public class CAD : Indicator
	{
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000058 RID: 88 RVA: 0x0000345F File Offset: 0x0000245F
		// (set) Token: 0x06000059 RID: 89 RVA: 0x00003467 File Offset: 0x00002467
		[IndicatorParameter(0)]
		[Description("")]
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

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00003476 File Offset: 0x00002476
		// (set) Token: 0x0600005B RID: 91 RVA: 0x0000347E File Offset: 0x0000247E
		[IndicatorParameter(1)]
		[Category("Parameters")]
		[Description("")]
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

		// Token: 0x0600005C RID: 92 RVA: 0x00003490 File Offset: 0x00002490
		protected override void Init()
		{
			this.fName = string.Concat(new object[]
			{
				"CAD (",
				this.fLength1,
				" ,",
				this.fLength2,
				" )"
			});
			this.fTitle = "Chaikin A/D Oscillator";
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
			base.Disconnect();
			this.fAD = new AD(this.fInput);
			this.Connect();
			this.fEMA1 = new EMA(this.fAD, this.fLength1);
			this.fEMA2 = new EMA(this.fAD, this.fLength2);
			this.fAD.DrawEnabled = false;
			this.fEMA1.DrawEnabled = false;
			this.fEMA1.DrawEnabled = false;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000359D File Offset: 0x0000259D
		public CAD()
		{
			this.Init();
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000035BA File Offset: 0x000025BA
		public CAD(TimeSeries input, int length1, int length2) : base(input)
		{
			this.fLength1 = length1;
			this.fLength2 = length2;
			this.Init();
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000035E6 File Offset: 0x000025E6
		public CAD(TimeSeries input, int length1, int length2, Color color) : base(input)
		{
			this.fLength1 = length1;
			this.fLength2 = length2;
			this.Init();
			base.Color = color;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000361A File Offset: 0x0000261A
		public CAD(TimeSeries input, int length1, int length2, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.fLength1 = length1;
			this.fLength2 = length2;
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00003658 File Offset: 0x00002658
		protected override void Calculate(int index)
		{
			if (index >= Math.Max(this.fLength1, this.fLength2) + this.fInput.FirstIndex)
			{
				double data = this.fEMA1[index] - this.fEMA2[index];
				this.Add(this.fInput.GetDateTime(index), data);
				return;
			}
			this.Add(this.fInput.GetDateTime(index), double.NaN);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000036D8 File Offset: 0x000026D8
		public static double Value(TimeSeries input, int index, int length1, int length2)
		{
			if (index >= Math.Max(length1, length2) + input.FirstIndex)
			{
				AD input2 = new AD(input);
				EMA ema = new EMA(input2, length1);
				EMA ema2 = new EMA(input2, length2);
				return ema[index] - ema2[index];
			}
			return double.NaN;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00003728 File Offset: 0x00002728
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

		// Token: 0x06000064 RID: 100 RVA: 0x00003772 File Offset: 0x00002772
		public override void Detach()
		{
			this.fAD.Detach();
			base.Detach();
		}

		// Token: 0x0400000F RID: 15
		protected EMA fEMA1;

		// Token: 0x04000010 RID: 16
		protected EMA fEMA2;

		// Token: 0x04000011 RID: 17
		protected AD fAD;

		// Token: 0x04000012 RID: 18
		protected int fLength1 = 3;

		// Token: 0x04000013 RID: 19
		protected int fLength2 = 10;
	}
}
