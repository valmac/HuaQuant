using System;
using System.IO;

namespace SmartQuant.Data
{
	// Token: 0x02000004 RID: 4
	[Serializable]
	public class Quote : IDataObject, ISeriesObject, ICloneable
	{
		// Token: 0x06000009 RID: 9 RVA: 0x000020D0 File Offset: 0x000010D0
		public Quote(DateTime datetime, double bid, int bidSize, double ask, int askSize)
		{
			this.datetime = datetime;
			this.bid = bid;
			this.ask = ask;
			this.bidSize = bidSize;
			this.askSize = askSize;
			this.providerId = 0;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002104 File Offset: 0x00001104
		public Quote(Quote quote) : this(quote.datetime, quote.bid, quote.bidSize, quote.ask, quote.askSize)
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000212A File Offset: 0x0000112A
		public Quote() : this(DateTime.MinValue, 0.0, 0, 0.0, 0)
		{
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000C RID: 12 RVA: 0x0000214B File Offset: 0x0000114B
		// (set) Token: 0x0600000D RID: 13 RVA: 0x00002153 File Offset: 0x00001153
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

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000E RID: 14 RVA: 0x0000215C File Offset: 0x0000115C
		// (set) Token: 0x0600000F RID: 15 RVA: 0x00002164 File Offset: 0x00001164
		public DateTime DateTime
		{
			get
			{
				return this.datetime;
			}
			set
			{
				this.datetime = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000010 RID: 16 RVA: 0x0000216D File Offset: 0x0000116D
		// (set) Token: 0x06000011 RID: 17 RVA: 0x00002175 File Offset: 0x00001175
		[View]
		public int BidSize
		{
			get
			{
				return this.bidSize;
			}
			set
			{
				this.bidSize = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000012 RID: 18 RVA: 0x0000217E File Offset: 0x0000117E
		// (set) Token: 0x06000013 RID: 19 RVA: 0x00002186 File Offset: 0x00001186
		[PriceView]
		public double Bid
		{
			get
			{
				return this.bid;
			}
			set
			{
				this.bid = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000014 RID: 20 RVA: 0x0000218F File Offset: 0x0000118F
		// (set) Token: 0x06000015 RID: 21 RVA: 0x00002197 File Offset: 0x00001197
		[PriceView]
		public double Ask
		{
			get
			{
				return this.ask;
			}
			set
			{
				this.ask = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000016 RID: 22 RVA: 0x000021A0 File Offset: 0x000011A0
		// (set) Token: 0x06000017 RID: 23 RVA: 0x000021A8 File Offset: 0x000011A8
		[View]
		public int AskSize
		{
			get
			{
				return this.askSize;
			}
			set
			{
				this.askSize = value;
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000021B4 File Offset: 0x000011B4
		public override string ToString()
		{
			return string.Format("{0} bidSize={1} bid={2} ask={3} askSize={4}", new object[]
			{
				this.datetime,
				this.bidSize,
				this.bid,
				this.ask,
				this.askSize
			});
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000221C File Offset: 0x0000121C
		public virtual void WriteTo(BinaryWriter writer)
		{
			writer.Write(2);
			writer.Write(this.datetime.Ticks);
			writer.Write(this.bid);
			writer.Write(this.ask);
			writer.Write(this.bidSize);
			writer.Write(this.askSize);
			writer.Write(this.providerId);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002280 File Offset: 0x00001280
		public virtual void ReadFrom(BinaryReader reader)
		{
			byte b = reader.ReadByte();
			switch (b)
			{
			case 1:
				this.datetime = new DateTime(reader.ReadInt64());
				this.bid = Math.Round((double)reader.ReadSingle(), 4);
				this.bidSize = reader.ReadInt32();
				this.ask = Math.Round((double)reader.ReadSingle(), 4);
				this.askSize = reader.ReadInt32();
				this.providerId = reader.ReadByte();
				return;
			case 2:
				this.datetime = new DateTime(reader.ReadInt64());
				this.bid = reader.ReadDouble();
				this.ask = reader.ReadDouble();
				this.bidSize = reader.ReadInt32();
				this.askSize = reader.ReadInt32();
				this.providerId = reader.ReadByte();
				return;
			default:
				throw new Exception("Unknown version - " + b);
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000236A File Offset: 0x0000136A
		public virtual ISeriesObject NewInstance()
		{
			return new Quote();
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002371 File Offset: 0x00001371
		public virtual object Clone()
		{
			return new Quote(this);
		}

		// Token: 0x04000001 RID: 1
		private const byte VERSION = 2;

		// Token: 0x04000002 RID: 2
		protected DateTime datetime;

		// Token: 0x04000003 RID: 3
		protected byte providerId;

		// Token: 0x04000004 RID: 4
		protected double bid;

		// Token: 0x04000005 RID: 5
		protected double ask;

		// Token: 0x04000006 RID: 6
		protected int bidSize;

		// Token: 0x04000007 RID: 7
		protected int askSize;
	}
}
