using System;
using System.Drawing;
using System.IO;

namespace SmartQuant.Data
{
	// Token: 0x02000012 RID: 18
	[Serializable]
	public class Bar : IDataObject, ISeriesObject, ICloneable
	{
		// Token: 0x06000065 RID: 101 RVA: 0x00002DB8 File Offset: 0x00001DB8
		public Bar(BarType barType, long size, DateTime beginTime, DateTime endTime, double open, double high, double low, double close, long volume, long openInt)
		{
			this.barType = barType;
			this.size = size;
			this.beginTime = beginTime;
			this.endTime = endTime;
			this.open = open;
			this.high = high;
			this.low = low;
			this.close = close;
			this.volume = volume;
			this.openInt = openInt;
			this.providerId = 0;
			this.color = Color.Empty;
			this.isComplete = false;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002E34 File Offset: 0x00001E34
		public Bar(DateTime datetime, double open, double high, double low, double close, long volume, long size) : this(BarType.Time, size, datetime, datetime.AddSeconds((double)size), open, high, low, close, volume, 0L)
		{
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002E60 File Offset: 0x00001E60
		public Bar(Bar bar) : this(bar.barType, bar.size, bar.beginTime, bar.endTime, bar.open, bar.high, bar.low, bar.close, bar.volume, bar.openInt)
		{
			this.providerId = bar.providerId;
			this.color = bar.color;
			this.isComplete = bar.isComplete;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002ED3 File Offset: 0x00001ED3
		public Bar() : this(DateTime.MinValue, 0.0, 0.0, 0.0, 0.0, 0L, 0L)
		{
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00002F08 File Offset: 0x00001F08
		// (set) Token: 0x0600006A RID: 106 RVA: 0x00002F10 File Offset: 0x00001F10
		public byte ProviderId
		{
			get
			{
				return this.providerId;
			}
			set
			{
				this.providerId = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00002F19 File Offset: 0x00001F19
		// (set) Token: 0x0600006C RID: 108 RVA: 0x00002F21 File Offset: 0x00001F21
		public DateTime DateTime
		{
			get
			{
				return this.beginTime;
			}
			set
			{
				this.beginTime = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00002F2A File Offset: 0x00001F2A
		public DateTime BeginTime
		{
			get
			{
				return this.beginTime;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00002F34 File Offset: 0x00001F34
		// (set) Token: 0x0600006F RID: 111 RVA: 0x00002F8A File Offset: 0x00001F8A
		[View]
		public virtual DateTime EndTime
		{
			get
			{
				if (!(this.endTime == DateTime.MinValue))
				{
					return this.endTime;
				}
				if (this.barType == BarType.Time && this.size > 0L)
				{
					return this.beginTime.AddSeconds((double)this.size);
				}
				throw new InvalidOperationException("The EndTime is not set for the bar.");
			}
			set
			{
				this.endTime = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00002F93 File Offset: 0x00001F93
		[View]
		public TimeSpan Duration
		{
			get
			{
				return this.EndTime - this.beginTime;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00002FA6 File Offset: 0x00001FA6
		// (set) Token: 0x06000072 RID: 114 RVA: 0x00002FAE File Offset: 0x00001FAE
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

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00002FB7 File Offset: 0x00001FB7
		// (set) Token: 0x06000074 RID: 116 RVA: 0x00002FBF File Offset: 0x00001FBF
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

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00002FC8 File Offset: 0x00001FC8
		// (set) Token: 0x06000076 RID: 118 RVA: 0x00002FD0 File Offset: 0x00001FD0
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

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00002FD9 File Offset: 0x00001FD9
		// (set) Token: 0x06000078 RID: 120 RVA: 0x00002FE1 File Offset: 0x00001FE1
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

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00002FEA File Offset: 0x00001FEA
		// (set) Token: 0x0600007A RID: 122 RVA: 0x00002FF2 File Offset: 0x00001FF2
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

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00002FFB File Offset: 0x00001FFB
		// (set) Token: 0x0600007C RID: 124 RVA: 0x00003003 File Offset: 0x00002003
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

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600007D RID: 125 RVA: 0x0000300C File Offset: 0x0000200C
		// (set) Token: 0x0600007E RID: 126 RVA: 0x00003014 File Offset: 0x00002014
		[View]
		public long Size
		{
			get
			{
				return this.size;
			}
			set
			{
				this.size = value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600007F RID: 127 RVA: 0x0000301D File Offset: 0x0000201D
		// (set) Token: 0x06000080 RID: 128 RVA: 0x00003025 File Offset: 0x00002025
		public bool IsComplete
		{
			get
			{
				return this.isComplete;
			}
			set
			{
				this.isComplete = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000081 RID: 129 RVA: 0x0000302E File Offset: 0x0000202E
		// (set) Token: 0x06000082 RID: 130 RVA: 0x00003036 File Offset: 0x00002036
		[View]
		public BarType BarType
		{
			get
			{
				return this.barType;
			}
			set
			{
				this.barType = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000083 RID: 131 RVA: 0x0000303F File Offset: 0x0000203F
		public double Median
		{
			get
			{
				return (this.High + this.Low) / 2.0;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00003058 File Offset: 0x00002058
		public double Typical
		{
			get
			{
				return (this.High + this.Low + this.Close) / 3.0;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00003078 File Offset: 0x00002078
		public double Weighted
		{
			get
			{
				return (this.High + this.Low + 2.0 * this.Close) / 4.0;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000086 RID: 134 RVA: 0x000030A2 File Offset: 0x000020A2
		// (set) Token: 0x06000087 RID: 135 RVA: 0x000030AA File Offset: 0x000020AA
		public Color Color
		{
			get
			{
				return this.color;
			}
			set
			{
				this.color = value;
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000030B4 File Offset: 0x000020B4
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

		// Token: 0x17000031 RID: 49
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

		// Token: 0x17000032 RID: 50
		public double this[BarData barData]
		{
			get
			{
				return this[(int)barData];
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000031C0 File Offset: 0x000021C0
		public override string ToString()
		{
			return string.Format("[{0} - {1}) type={2} open={3} high={4} low={5} close={6} volume={7} openInt={8} size={9}", new object[]
			{
				this.beginTime,
				this.endTime,
				this.barType,
				this.open,
				this.high,
				this.low,
				this.close,
				this.volume,
				this.openInt,
				this.size
			});
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00003270 File Offset: 0x00002270
		public virtual void WriteTo(BinaryWriter writer)
		{
			writer.Write(2);
			writer.Write(this.beginTime.Ticks);
			writer.Write(this.endTime.Ticks);
			writer.Write((byte)this.barType);
			writer.Write(this.size);
			writer.Write(this.high);
			writer.Write(this.low);
			writer.Write(this.open);
			writer.Write(this.close);
			writer.Write(this.volume);
			writer.Write(this.openInt);
			writer.Write(this.providerId);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00003314 File Offset: 0x00002314
		public virtual void ReadFrom(BinaryReader reader)
		{
			byte b = reader.ReadByte();
			switch (b)
			{
			case 1:
				this.beginTime = new DateTime(reader.ReadInt64());
				this.endTime = new DateTime(reader.ReadInt64());
				this.barType = (BarType)reader.ReadByte();
				this.size = reader.ReadInt64();
				this.high = Math.Round((double)reader.ReadSingle(), 4);
				this.low = Math.Round((double)reader.ReadSingle(), 4);
				this.open = Math.Round((double)reader.ReadSingle(), 4);
				this.close = Math.Round((double)reader.ReadSingle(), 4);
				this.volume = reader.ReadInt64();
				this.openInt = reader.ReadInt64();
				this.providerId = reader.ReadByte();
				return;
			case 2:
				this.beginTime = new DateTime(reader.ReadInt64());
				this.endTime = new DateTime(reader.ReadInt64());
				this.barType = (BarType)reader.ReadByte();
				this.size = reader.ReadInt64();
				this.high = reader.ReadDouble();
				this.low = reader.ReadDouble();
				this.open = reader.ReadDouble();
				this.close = reader.ReadDouble();
				this.volume = reader.ReadInt64();
				this.openInt = reader.ReadInt64();
				this.providerId = reader.ReadByte();
				return;
			default:
				throw new Exception("Unknown version - " + b);
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000348E File Offset: 0x0000248E
		public virtual ISeriesObject NewInstance()
		{
			return new Bar();
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00003495 File Offset: 0x00002495
		public virtual object Clone()
		{
			return new Bar(this);
		}

		// Token: 0x04000024 RID: 36
		private const byte VERSION = 2;

		// Token: 0x04000025 RID: 37
		protected byte providerId;

		// Token: 0x04000026 RID: 38
		protected DateTime beginTime;

		// Token: 0x04000027 RID: 39
		protected DateTime endTime;

		// Token: 0x04000028 RID: 40
		protected double high;

		// Token: 0x04000029 RID: 41
		protected double low;

		// Token: 0x0400002A RID: 42
		protected double open;

		// Token: 0x0400002B RID: 43
		protected double close;

		// Token: 0x0400002C RID: 44
		protected long volume;

		// Token: 0x0400002D RID: 45
		protected long openInt;

		// Token: 0x0400002E RID: 46
		protected long size;

		// Token: 0x0400002F RID: 47
		protected bool isComplete;

		// Token: 0x04000030 RID: 48
		protected Color color;

		// Token: 0x04000031 RID: 49
		protected BarType barType;
	}
}
