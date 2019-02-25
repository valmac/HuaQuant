using System;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Data;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x0200000D RID: 13
	[Serializable]
	public class VHF : Indicator
	{
		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000BB RID: 187 RVA: 0x00004E2C File Offset: 0x00003E2C
		// (set) Token: 0x060000BC RID: 188 RVA: 0x00004E34 File Offset: 0x00003E34
		[Description("")]
		[Category("Parameters")]
		[IndicatorParameter(1)]
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

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000BD RID: 189 RVA: 0x00004E43 File Offset: 0x00003E43
		// (set) Token: 0x060000BE RID: 190 RVA: 0x00004E4B File Offset: 0x00003E4B
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

		// Token: 0x060000BF RID: 191 RVA: 0x00004E5C File Offset: 0x00003E5C
		protected override void Init()
		{
			this.fName = "VHF (" + this.fLength + ")";
			this.fTitle = "Vertical Horizontal Filter";
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
					"VHF (",
					this.fLength,
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

		// Token: 0x060000C0 RID: 192 RVA: 0x00004F27 File Offset: 0x00003F27
		public VHF()
		{
			this.Init();
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00004F3D File Offset: 0x00003F3D
		public VHF(TimeSeries input, int length, BarData option) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00004F62 File Offset: 0x00003F62
		public VHF(TimeSeries input, int length, BarData option, Color color) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
			base.Color = color;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00004F8F File Offset: 0x00003F8F
		public VHF(TimeSeries input, int length, BarData option, Color color, EDrawStyle drawStyle) : base(input)
		{
			this.fLength = length;
			this.fOption = option;
			this.Init();
			base.Color = color;
			base.DrawStyle = drawStyle;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00004FC4 File Offset: 0x00003FC4
		public VHF(TimeSeries input, int length) : base(input)
		{
			this.fLength = length;
			this.Init();
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00004FE2 File Offset: 0x00003FE2
		public VHF(TimeSeries input, int length, Color color) : base(input)
		{
			this.fLength = length;
			base.Color = color;
			this.Init();
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00005008 File Offset: 0x00004008
		protected override void Calculate(int index)
		{
			double data = VHF.Value(this.fInput, index, this.fLength, this.fOption);
			this.Add(this.fInput.GetDateTime(index), data);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00005044 File Offset: 0x00004044
		public static double Value(TimeSeries input, int index, int length, BarData option)
		{
			if (index >= length + input.FirstIndex)
			{
				double max = input.GetMax(index - length + 1, index, option);
				double min = input.GetMin(index - length + 1, index, option);
				double num = Math.Abs(max - min);
				double num2 = 0.0;
				for (int i = index; i > index - length; i--)
				{
					num2 += Math.Abs(input[i, option] - input[i - 1, option]);
				}
				return num / num2;
			}
			return double.NaN;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x000050CB File Offset: 0x000040CB
		public static double Value(DoubleSeries input, int index, int length)
		{
			return VHF.Value(input, index, length, BarData.Close);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000050D8 File Offset: 0x000040D8
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

		// Token: 0x04000020 RID: 32
		protected int fLength = 14;

		// Token: 0x04000021 RID: 33
		protected BarData fOption;
	}
}
