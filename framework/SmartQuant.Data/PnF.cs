using System;

namespace SmartQuant.Data
{
	// Token: 0x0200001C RID: 28
	[Serializable]
	public class PnF
	{
		// Token: 0x060000DA RID: 218 RVA: 0x00004060 File Offset: 0x00003060
		public PnF(double boxSize, DateTime beginTime, DateTime endTime, double open, double high, double low, double close, long volume, long openInt)
		{
			this.boxSize = boxSize;
			this.beginTime = beginTime;
			this.endTime = endTime;
			this.open = open;
			this.high = high;
			this.low = low;
			this.close = close;
			this.volume = volume;
			this.openInt = openInt;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000040B8 File Offset: 0x000030B8
		public PnF(PnF pnF) : this(pnF.BoxSize, pnF.beginTime, pnF.endTime, pnF.open, pnF.high, pnF.low, pnF.close, pnF.volume, pnF.openInt)
		{
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000DC RID: 220 RVA: 0x00004101 File Offset: 0x00003101
		// (set) Token: 0x060000DD RID: 221 RVA: 0x00004109 File Offset: 0x00003109
		public DateTime DateTime
		{
			get
			{
				return this.beginTime;
			}
			set
			{
				throw new NotSupportedException("Cannot set date/time for the pnF.");
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00004115 File Offset: 0x00003115
		public DateTime BeginTime
		{
			get
			{
				return this.beginTime;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000DF RID: 223 RVA: 0x0000411D File Offset: 0x0000311D
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x00004125 File Offset: 0x00003125
		[View]
		public virtual DateTime EndTime
		{
			get
			{
				return this.endTime;
			}
			set
			{
				this.endTime = value;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x0000412E File Offset: 0x0000312E
		[View]
		public TimeSpan Duration
		{
			get
			{
				return this.endTime - this.beginTime;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x00004141 File Offset: 0x00003141
		public PnFKind Kind
		{
			get
			{
				if (this.open > this.close)
				{
					return PnFKind.Down;
				}
				return PnFKind.Up;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x00004154 File Offset: 0x00003154
		public double BoxSize
		{
			get
			{
				return this.boxSize;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x0000415C File Offset: 0x0000315C
		public int BoxCount
		{
			get
			{
				return (int)Math.Round(Math.Abs(this.close - this.open) / this.boxSize);
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x0000417D File Offset: 0x0000317D
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x00004185 File Offset: 0x00003185
		[PriceView]
		public double Open
		{
			get
			{
				return this.open;
			}
			set
			{
				this.open = value;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x0000418E File Offset: 0x0000318E
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x00004196 File Offset: 0x00003196
		[PriceView]
		public double High
		{
			get
			{
				return this.high;
			}
			set
			{
				this.high = value;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x0000419F File Offset: 0x0000319F
		// (set) Token: 0x060000EA RID: 234 RVA: 0x000041A7 File Offset: 0x000031A7
		[PriceView]
		public double Low
		{
			get
			{
				return this.low;
			}
			set
			{
				this.low = value;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000EB RID: 235 RVA: 0x000041B0 File Offset: 0x000031B0
		// (set) Token: 0x060000EC RID: 236 RVA: 0x000041B8 File Offset: 0x000031B8
		[PriceView]
		public double Close
		{
			get
			{
				return this.close;
			}
			set
			{
				this.close = value;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000ED RID: 237 RVA: 0x000041C1 File Offset: 0x000031C1
		// (set) Token: 0x060000EE RID: 238 RVA: 0x000041C9 File Offset: 0x000031C9
		[View]
		public long Volume
		{
			get
			{
				return this.volume;
			}
			set
			{
				this.volume = value;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000EF RID: 239 RVA: 0x000041D2 File Offset: 0x000031D2
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x000041DA File Offset: 0x000031DA
		public long OpenInt
		{
			get
			{
				return this.openInt;
			}
			set
			{
				this.openInt = value;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x000041E3 File Offset: 0x000031E3
		public double Median
		{
			get
			{
				return (this.High + this.Low) / 2.0;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x000041FC File Offset: 0x000031FC
		public double Typical
		{
			get
			{
				return (this.High + this.Low + this.Close) / 3.0;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x0000421C File Offset: 0x0000321C
		public double Weighted
		{
			get
			{
				return (this.High + this.Low + 2.0 * this.Close) / 4.0;
			}
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00004248 File Offset: 0x00003248
		public double GetPrice(BarPrice option)
		{
			double result = 0.0;
			switch (option)
			{
			case BarPrice.High:
				result = this.High;
				break;
			case BarPrice.Low:
				result = this.Low;
				break;
			case BarPrice.Open:
				result = this.Open;
				break;
			case BarPrice.Close:
				result = this.Close;
				break;
			case BarPrice.Median:
				result = this.Median;
				break;
			case BarPrice.Typical:
				result = this.Typical;
				break;
			case BarPrice.Weighted:
				result = this.Weighted;
				break;
			}
			return result;
		}

		// Token: 0x17000056 RID: 86
		public double this[int barData]
		{
			get
			{
				switch (barData)
				{
				case 0:
					return this.Close;
				case 1:
					return this.Open;
				case 2:
					return this.High;
				case 3:
					return this.Low;
				case 4:
					return this.Median;
				case 5:
					return this.Typical;
				case 6:
					return this.Weighted;
				case 7:
					return (double)this.volume;
				case 8:
					return (double)this.openInt;
				default:
					return double.NaN;
				}
			}
		}

		// Token: 0x17000057 RID: 87
		public double this[BarData barData]
		{
			get
			{
				return this[(int)barData];
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00004354 File Offset: 0x00003354
		public override string ToString()
		{
			return string.Format("[{0} - {1}) box size ={2} open={3} high={4} low={5} close={6} volume={7} openInt={8} kind={9}", new object[]
			{
				this.beginTime.ToShortDateString() + " " + this.beginTime.ToLongTimeString(),
				this.endTime.ToShortDateString() + " " + this.endTime.ToLongTimeString(),
				this.boxSize,
				this.open,
				this.high,
				this.low,
				this.close,
				this.volume,
				this.openInt,
				this.Kind
			});
		}

		// Token: 0x04000047 RID: 71
		protected DateTime beginTime;

		// Token: 0x04000048 RID: 72
		protected DateTime endTime;

		// Token: 0x04000049 RID: 73
		protected double high;

		// Token: 0x0400004A RID: 74
		protected double low;

		// Token: 0x0400004B RID: 75
		protected double open;

		// Token: 0x0400004C RID: 76
		protected double close;

		// Token: 0x0400004D RID: 77
		protected long volume;

		// Token: 0x0400004E RID: 78
		protected long openInt;

		// Token: 0x0400004F RID: 79
		protected double boxSize;
	}
}
