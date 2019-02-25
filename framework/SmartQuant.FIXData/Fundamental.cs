using System;
using System.IO;
using SmartQuant.Data;
using SmartQuant.FIX;

namespace SmartQuant.FIXData
{
	// Token: 0x02000003 RID: 3
	public class Fundamental : FIXGroup, IDataObject, ISeriesObject, ICloneable
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002066 File Offset: 0x00001066
		// (set) Token: 0x06000004 RID: 4 RVA: 0x00002073 File Offset: 0x00001073
		public double EarningsPerShare
		{
			get
			{
				return this.GetDoubleValue(10300);
			}
			set
			{
				this.SetDoubleValue(10300, value);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002081 File Offset: 0x00001081
		// (set) Token: 0x06000006 RID: 6 RVA: 0x0000208E File Offset: 0x0000108E
		public double CashPerShare
		{
			get
			{
				return this.GetDoubleValue(10302);
			}
			set
			{
				this.SetDoubleValue(10302, value);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000007 RID: 7 RVA: 0x0000209C File Offset: 0x0000109C
		// (set) Token: 0x06000008 RID: 8 RVA: 0x000020A9 File Offset: 0x000010A9
		public double RevenuePerShare
		{
			get
			{
				return this.GetDoubleValue(10303);
			}
			set
			{
				this.SetDoubleValue(10303, value);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000009 RID: 9 RVA: 0x000020B7 File Offset: 0x000010B7
		// (set) Token: 0x0600000A RID: 10 RVA: 0x000020C4 File Offset: 0x000010C4
		public double DebtPerShare
		{
			get
			{
				return this.GetDoubleValue(10304);
			}
			set
			{
				this.SetDoubleValue(10304, value);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000B RID: 11 RVA: 0x000020D2 File Offset: 0x000010D2
		// (set) Token: 0x0600000C RID: 12 RVA: 0x000020DF File Offset: 0x000010DF
		public double CashFlowPerShare
		{
			get
			{
				return this.GetDoubleValue(10305);
			}
			set
			{
				this.SetDoubleValue(10305, value);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000D RID: 13 RVA: 0x000020ED File Offset: 0x000010ED
		// (set) Token: 0x0600000E RID: 14 RVA: 0x000020FA File Offset: 0x000010FA
		public double InterestPaymentPerShare
		{
			get
			{
				return this.GetDoubleValue(10306);
			}
			set
			{
				this.SetDoubleValue(10306, value);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00002110 File Offset: 0x00001110
		// (set) Token: 0x06000011 RID: 17 RVA: 0x00002118 File Offset: 0x00001118
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

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00002121 File Offset: 0x00001121
		// (set) Token: 0x06000013 RID: 19 RVA: 0x00002129 File Offset: 0x00001129
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

		// Token: 0x06000014 RID: 20 RVA: 0x00002132 File Offset: 0x00001132
		public ISeriesObject NewInstance()
		{
			return new Fundamental();
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002139 File Offset: 0x00001139
		public void WriteTo(BinaryWriter writer)
		{
			writer.Write(1);
			writer.Write(this.datetime.Ticks);
			writer.Write(this.providerId);
			FIXGroupStreamer.WriteTo(writer, this);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002166 File Offset: 0x00001166
		public void ReadFrom(BinaryReader reader)
		{
			reader.ReadByte();
			this.datetime = new DateTime(reader.ReadInt64());
			this.providerId = reader.ReadByte();
			FIXGroupStreamer.ReadFrom(reader, this);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002193 File Offset: 0x00001193
		public object Clone()
		{
			return this;
		}

		// Token: 0x04000001 RID: 1
		private const byte VERSION = 1;

		// Token: 0x04000002 RID: 2
		private DateTime datetime;

		// Token: 0x04000003 RID: 3
		private byte providerId;
	}
}
