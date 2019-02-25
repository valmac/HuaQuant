using System;
using System.IO;

namespace SmartQuant.Data
{
	// Token: 0x02000022 RID: 34
	[Serializable]
	public class MarketDepth : IDataObject, IComparable, ISeriesObject, ICloneable
	{
		// Token: 0x060000F9 RID: 249 RVA: 0x00004434 File Offset: 0x00003434
		public MarketDepth(DateTime datetime, byte providerId, string marketMaker, string source, int position, MDOperation operation, MDSide side, double price, int size)
		{
			this.datetime = datetime;
			this.providerId = providerId;
			this.marketMaker = marketMaker;
			this.source = source;
			this.position = position;
			this.operation = operation;
			this.side = side;
			this.price = price;
			this.size = size;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000448C File Offset: 0x0000348C
		public MarketDepth(DateTime datetime, string marketMaker, int position, MDOperation operation, MDSide side, double price, int size) : this(datetime, 0, marketMaker, "", position, operation, side, price, size)
		{
		}

		// Token: 0x060000FB RID: 251 RVA: 0x000044B0 File Offset: 0x000034B0
		public MarketDepth(MarketDepth marketDepth) : this(marketDepth.datetime, marketDepth.providerId, marketDepth.marketMaker, marketDepth.source, marketDepth.position, marketDepth.operation, marketDepth.side, marketDepth.price, marketDepth.size)
		{
		}

		// Token: 0x060000FC RID: 252 RVA: 0x000044F9 File Offset: 0x000034F9
		public MarketDepth()
		{
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00004501 File Offset: 0x00003501
		// (set) Token: 0x060000FE RID: 254 RVA: 0x00004509 File Offset: 0x00003509
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

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00004512 File Offset: 0x00003512
		// (set) Token: 0x06000100 RID: 256 RVA: 0x0000451A File Offset: 0x0000351A
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

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000101 RID: 257 RVA: 0x00004523 File Offset: 0x00003523
		// (set) Token: 0x06000102 RID: 258 RVA: 0x0000452B File Offset: 0x0000352B
		[View]
		public string MarketMaker
		{
			get
			{
				return this.marketMaker;
			}
			set
			{
				this.marketMaker = value;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000103 RID: 259 RVA: 0x00004534 File Offset: 0x00003534
		// (set) Token: 0x06000104 RID: 260 RVA: 0x0000453C File Offset: 0x0000353C
		[View]
		public string Source
		{
			get
			{
				return this.source;
			}
			set
			{
				this.source = value;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000105 RID: 261 RVA: 0x00004545 File Offset: 0x00003545
		// (set) Token: 0x06000106 RID: 262 RVA: 0x0000454D File Offset: 0x0000354D
		[View]
		public int Position
		{
			get
			{
				return this.position;
			}
			set
			{
				this.position = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000107 RID: 263 RVA: 0x00004556 File Offset: 0x00003556
		// (set) Token: 0x06000108 RID: 264 RVA: 0x0000455E File Offset: 0x0000355E
		[View]
		public MDOperation Operation
		{
			get
			{
				return this.operation;
			}
			set
			{
				this.operation = value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000109 RID: 265 RVA: 0x00004567 File Offset: 0x00003567
		// (set) Token: 0x0600010A RID: 266 RVA: 0x0000456F File Offset: 0x0000356F
		[View]
		public MDSide Side
		{
			get
			{
				return this.side;
			}
			set
			{
				this.side = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00004578 File Offset: 0x00003578
		// (set) Token: 0x0600010C RID: 268 RVA: 0x00004580 File Offset: 0x00003580
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

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00004589 File Offset: 0x00003589
		// (set) Token: 0x0600010E RID: 270 RVA: 0x00004591 File Offset: 0x00003591
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

		// Token: 0x0600010F RID: 271 RVA: 0x0000459A File Offset: 0x0000359A
		public int CompareTo(object obj)
		{
			if (obj is MarketDepth)
			{
				return this.price.CompareTo((obj as MarketDepth).price);
			}
			throw new ArgumentException("Cannot compare with object type " + obj.GetType().ToString());
		}

		// Token: 0x06000110 RID: 272 RVA: 0x000045D8 File Offset: 0x000035D8
		public virtual void WriteTo(BinaryWriter writer)
		{
			writer.Write(3);
			writer.Write(this.datetime.Ticks);
			writer.Write(this.marketMaker);
			writer.Write(this.source);
			writer.Write((byte)this.side);
			writer.Write(this.price);
			writer.Write(this.size);
			writer.Write(this.providerId);
			writer.Write(this.position);
			writer.Write((byte)this.operation);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00004660 File Offset: 0x00003660
		public virtual void ReadFrom(BinaryReader reader)
		{
			byte b = reader.ReadByte();
			switch (b)
			{
			case 1:
				this.datetime = new DateTime(reader.ReadInt64());
				this.marketMaker = reader.ReadString();
				this.source = reader.ReadString();
				this.side = (MDSide)reader.ReadByte();
				this.price = Math.Round((double)reader.ReadSingle(), 4);
				this.size = reader.ReadInt32();
				this.providerId = reader.ReadByte();
				this.position = -1;
				this.operation = MDOperation.Undefined;
				return;
			case 2:
				this.datetime = new DateTime(reader.ReadInt64());
				this.marketMaker = reader.ReadString();
				this.source = reader.ReadString();
				this.side = (MDSide)reader.ReadByte();
				this.price = Math.Round((double)reader.ReadSingle(), 4);
				this.size = reader.ReadInt32();
				this.providerId = reader.ReadByte();
				this.position = reader.ReadInt32();
				this.operation = (MDOperation)reader.ReadByte();
				return;
			case 3:
				this.datetime = new DateTime(reader.ReadInt64());
				this.marketMaker = reader.ReadString();
				this.source = reader.ReadString();
				this.side = (MDSide)reader.ReadByte();
				this.price = reader.ReadDouble();
				this.size = reader.ReadInt32();
				this.providerId = reader.ReadByte();
				this.position = reader.ReadInt32();
				this.operation = (MDOperation)reader.ReadByte();
				return;
			default:
				throw new Exception("Unknown version - " + b);
			}
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00004802 File Offset: 0x00003802
		public virtual ISeriesObject NewInstance()
		{
			return new MarketDepth();
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00004809 File Offset: 0x00003809
		public virtual object Clone()
		{
			return new MarketDepth(this);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00004814 File Offset: 0x00003814
		public override string ToString()
		{
			return string.Format("{0} {1} {2} {3} price={4} size={5}", new object[]
			{
				this.datetime,
				this.side,
				this.operation,
				this.position,
				this.Price,
				this.size
			});
		}

		// Token: 0x04000062 RID: 98
		private const byte VERSION = 3;

		// Token: 0x04000063 RID: 99
		private DateTime datetime;

		// Token: 0x04000064 RID: 100
		private byte providerId;

		// Token: 0x04000065 RID: 101
		private string marketMaker;

		// Token: 0x04000066 RID: 102
		private string source;

		// Token: 0x04000067 RID: 103
		private int position;

		// Token: 0x04000068 RID: 104
		private MDOperation operation;

		// Token: 0x04000069 RID: 105
		private MDSide side;

		// Token: 0x0400006A RID: 106
		private double price;

		// Token: 0x0400006B RID: 107
		private int size;
	}
}
