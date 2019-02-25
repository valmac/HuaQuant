using System;
using System.IO;

namespace SmartQuant.Data
{
	// Token: 0x02000023 RID: 35
	[Serializable]
	public class Trade : IDataObject, ISeriesObject, ICloneable
	{
		// Token: 0x06000115 RID: 277 RVA: 0x00004887 File Offset: 0x00003887
		public Trade(DateTime datetime, double price, int size)
		{
			this.datetime = datetime;
			this.price = price;
			this.size = size;
			this.providerId = 0;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x000048AB File Offset: 0x000038AB
		public Trade(Trade trade) : this(trade.datetime, trade.price, trade.size)
		{
		}

		// Token: 0x06000117 RID: 279 RVA: 0x000048C5 File Offset: 0x000038C5
		public Trade() : this(DateTime.MinValue, 0.0, 0)
		{
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000118 RID: 280 RVA: 0x000048DC File Offset: 0x000038DC
		// (set) Token: 0x06000119 RID: 281 RVA: 0x000048E4 File Offset: 0x000038E4
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

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600011A RID: 282 RVA: 0x000048ED File Offset: 0x000038ED
		// (set) Token: 0x0600011B RID: 283 RVA: 0x000048F5 File Offset: 0x000038F5
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

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600011C RID: 284 RVA: 0x000048FE File Offset: 0x000038FE
		// (set) Token: 0x0600011D RID: 285 RVA: 0x00004906 File Offset: 0x00003906
		[PriceView]
		public double Price
		{
			get
			{
				return this.price;
			}
			set
			{
				this.price = value;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600011E RID: 286 RVA: 0x0000490F File Offset: 0x0000390F
		// (set) Token: 0x0600011F RID: 287 RVA: 0x00004917 File Offset: 0x00003917
		[View]
		public int Size
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

		// Token: 0x06000120 RID: 288 RVA: 0x00004920 File Offset: 0x00003920
		public override string ToString()
		{
			return string.Format("{0} price={1} size={2}", this.datetime, this.price, this.size);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000494D File Offset: 0x0000394D
		public virtual ISeriesObject NewInstance()
		{
			return new Trade();
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00004954 File Offset: 0x00003954
		public virtual object Clone()
		{
			return new Trade(this);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0000495C File Offset: 0x0000395C
		public virtual void WriteTo(BinaryWriter writer)
		{
			writer.Write(2);
			writer.Write(this.datetime.Ticks);
			writer.Write(this.price);
			writer.Write(this.size);
			writer.Write(this.providerId);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0000499C File Offset: 0x0000399C
		public virtual void ReadFrom(BinaryReader reader)
		{
			byte b = reader.ReadByte();
			switch (b)
			{
			case 1:
				this.datetime = new DateTime(reader.ReadInt64());
				this.price = Math.Round((double)reader.ReadSingle(), 4);
				this.size = reader.ReadInt32();
				this.providerId = reader.ReadByte();
				return;
			case 2:
				this.datetime = new DateTime(reader.ReadInt64());
				this.price = reader.ReadDouble();
				this.size = reader.ReadInt32();
				this.providerId = reader.ReadByte();
				return;
			default:
				throw new Exception("Unknown version - " + b);
			}
		}

		// Token: 0x0400006C RID: 108
		private const byte VERSION = 2;

		// Token: 0x0400006D RID: 109
		protected DateTime datetime;

		// Token: 0x0400006E RID: 110
		protected byte providerId;

		// Token: 0x0400006F RID: 111
		protected double price;

		// Token: 0x04000070 RID: 112
		protected int size;
	}
}
