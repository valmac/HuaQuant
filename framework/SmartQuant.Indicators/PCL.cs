using System;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x02000041 RID: 65
	[Serializable]
	public class PCL : Indicator
	{
		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000336 RID: 822 RVA: 0x0000EA76 File Offset: 0x0000DA76
		// (set) Token: 0x06000337 RID: 823 RVA: 0x0000EA7E File Offset: 0x0000DA7E
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

		// Token: 0x06000338 RID: 824 RVA: 0x0000EA90 File Offset: 0x0000DA90
		protected override void Init()
		{
			this.fName = "PCL (" + this.fLength + ")";
			this.fTitle = "Price Channel Lower";
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

		// Token: 0x06000339 RID: 825 RVA: 0x0000EB0E File Offset: 0x0000DB0E
		public PCL()
		{
			this.Init();
		}

		// Token: 0x0600033A RID: 826 RVA: 0x0000EB24 File Offset: 0x0000DB24
		public PCL(TimeSeries input, int length) : base(input)
		{
			this.fLength = length;
			this.Init();
		}

		// Token: 0x0600033B RID: 827 RVA: 0x0000EB42 File Offset: 0x0000DB42
		public PCL(TimeSeries input, int length, Color color) : base(input)
		{
			this.fLength = length;
			this.Init();
			base.Color = color;
		}

		// Token: 0x0600033C RID: 828 RVA: 0x0000EB67 File Offset: 0x0000DB67
		public PCL(TimeSeries input, int length, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.fLength = length;
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0000EB94 File Offset: 0x0000DB94
		protected override void Calculate(int index)
		{
			double data = PCL.Value(this.fInput, index, this.fLength);
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x0600033E RID: 830 RVA: 0x0000EBC8 File Offset: 0x0000DBC8
		public static double Value(TimeSeries input, int index, int length)
		{
			if (index >= length + input.FirstIndex)
			{
				return input.GetMin(index - length, index - 1, BarData.Low);
			}
			return double.NaN;
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0000EBFC File Offset: 0x0000DBFC
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

		// Token: 0x040000A2 RID: 162
		protected int fLength = 14;
	}
}
