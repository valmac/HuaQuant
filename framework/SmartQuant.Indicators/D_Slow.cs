using System;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x02000039 RID: 57
	[Serializable]
	public class D_Slow : Indicator
	{
		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060002DA RID: 730 RVA: 0x0000CE8A File Offset: 0x0000BE8A
		// (set) Token: 0x060002DB RID: 731 RVA: 0x0000CE92 File Offset: 0x0000BE92
		[IndicatorParameter(0)]
		[Description("")]
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

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060002DC RID: 732 RVA: 0x0000CEA1 File Offset: 0x0000BEA1
		// (set) Token: 0x060002DD RID: 733 RVA: 0x0000CEA9 File Offset: 0x0000BEA9
		[Description("")]
		[Category("Parameters")]
		[IndicatorParameter(1)]
		public int Order1
		{
			get
			{
				return this.fOrder1;
			}
			set
			{
				this.fOrder1 = value;
				this.Init();
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060002DE RID: 734 RVA: 0x0000CEB8 File Offset: 0x0000BEB8
		// (set) Token: 0x060002DF RID: 735 RVA: 0x0000CEC0 File Offset: 0x0000BEC0
		[Description("")]
		[IndicatorParameter(2)]
		[Category("Parameters")]
		public int Order2
		{
			get
			{
				return this.fOrder2;
			}
			set
			{
				this.fOrder2 = value;
				this.Init();
			}
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0000CED0 File Offset: 0x0000BED0
		protected override void Init()
		{
			this.fName = string.Concat(new object[]
			{
				"%D Slow (",
				this.fLength,
				", ",
				this.fOrder1,
				", ",
				this.fOrder2,
				")"
			});
			this.fTitle = "%D Slow";
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
			this.fK = new K_Fast(this.fInput, this.fLength);
			this.fK.DrawEnabled = false;
			this.Connect();
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0000CFB3 File Offset: 0x0000BFB3
		public D_Slow()
		{
			this.Init();
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x0000CFD8 File Offset: 0x0000BFD8
		public D_Slow(TimeSeries input, int length, int order1, int order2) : base(input)
		{
			this.fLength = length;
			this.fOrder1 = order1;
			this.fOrder2 = order2;
			this.Init();
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x0000D014 File Offset: 0x0000C014
		public D_Slow(TimeSeries input, int length, int order1, int order2, Color color) : base(input)
		{
			this.fLength = length;
			this.fOrder1 = order1;
			this.fOrder2 = order2;
			this.Init();
			base.Color = color;
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0000D064 File Offset: 0x0000C064
		public D_Slow(TimeSeries input, int length, int order1, int order2, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.fLength = length;
			this.fOrder1 = order1;
			this.fOrder2 = order2;
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0000D0BC File Offset: 0x0000C0BC
		protected override void Calculate(int index)
		{
			double data = D_Slow.Value(this.fInput, index, this.fLength, this.fOrder1, this.fOrder2);
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0000D0FC File Offset: 0x0000C0FC
		public static double Value(TimeSeries input, int index, int length, int order1, int order2)
		{
			if (index >= length + order1 + order2 - 1 + input.FirstIndex)
			{
				double num = 0.0;
				for (int i = index; i > index - order2; i--)
				{
					num += K_Slow.Value(input, i, length, order1);
				}
				return num / (double)order2;
			}
			return double.NaN;
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0000D150 File Offset: 0x0000C150
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

		// Token: 0x060002E8 RID: 744 RVA: 0x0000D19A File Offset: 0x0000C19A
		public override void Detach()
		{
			this.fK.Detach();
			base.Detach();
		}

		// Token: 0x0400008B RID: 139
		protected int fLength = 14;

		// Token: 0x0400008C RID: 140
		protected int fOrder1 = 10;

		// Token: 0x0400008D RID: 141
		protected int fOrder2 = 5;

		// Token: 0x0400008E RID: 142
		protected K_Fast fK;
	}
}
