using System;
using System.IO;
using SmartQuant.Data;
using SmartQuant.FIX;

namespace SmartQuant.FIXData
{
	// Token: 0x02000006 RID: 6
	public class CorporateAction : FIXGroup, IDataObject, ISeriesObject, ICloneable
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600001D RID: 29 RVA: 0x000023E6 File Offset: 0x000013E6
		// (set) Token: 0x0600001E RID: 30 RVA: 0x000023F3 File Offset: 0x000013F3
		public int CorporateActionType
		{
			get
			{
				return this.GetIntValue(10200);
			}
			set
			{
				this.SetIntValue(10200, value);
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00002401 File Offset: 0x00001401
		// (set) Token: 0x06000020 RID: 32 RVA: 0x0000240E File Offset: 0x0000140E
		public DateTime DeclaredDate
		{
			get
			{
				return this.GetDateTimeValue(10201);
			}
			set
			{
				this.SetDateTimeValue(10201, value);
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000021 RID: 33 RVA: 0x0000241C File Offset: 0x0000141C
		// (set) Token: 0x06000022 RID: 34 RVA: 0x00002429 File Offset: 0x00001429
		public DateTime ExDate
		{
			get
			{
				return this.GetDateTimeValue(230);
			}
			set
			{
				this.SetDateTimeValue(230, value);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00002437 File Offset: 0x00001437
		// (set) Token: 0x06000024 RID: 36 RVA: 0x00002444 File Offset: 0x00001444
		public DateTime RecordDate
		{
			get
			{
				return this.GetDateTimeValue(10202);
			}
			set
			{
				this.SetDateTimeValue(10202, value);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00002452 File Offset: 0x00001452
		// (set) Token: 0x06000026 RID: 38 RVA: 0x0000245F File Offset: 0x0000145F
		public DateTime PayDate
		{
			get
			{
				return this.GetDateTimeValue(10203);
			}
			set
			{
				this.SetDateTimeValue(10203, value);
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000027 RID: 39 RVA: 0x0000246D File Offset: 0x0000146D
		// (set) Token: 0x06000028 RID: 40 RVA: 0x0000247A File Offset: 0x0000147A
		public int DividendType
		{
			get
			{
				return this.GetIntValue(10204);
			}
			set
			{
				this.SetIntValue(10204, value);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00002488 File Offset: 0x00001488
		// (set) Token: 0x0600002A RID: 42 RVA: 0x00002495 File Offset: 0x00001495
		public int SplitType
		{
			get
			{
				return this.GetIntValue(10205);
			}
			set
			{
				this.SetIntValue(10205, value);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600002B RID: 43 RVA: 0x000024A3 File Offset: 0x000014A3
		// (set) Token: 0x0600002C RID: 44 RVA: 0x000024B0 File Offset: 0x000014B0
		public int RightsIssueType
		{
			get
			{
				return this.GetIntValue(10206);
			}
			set
			{
				this.SetIntValue(10206, value);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600002D RID: 45 RVA: 0x000024BE File Offset: 0x000014BE
		// (set) Token: 0x0600002E RID: 46 RVA: 0x000024CB File Offset: 0x000014CB
		public double NetAmount
		{
			get
			{
				return this.GetDoubleValue(10207);
			}
			set
			{
				this.SetDoubleValue(10207, value);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600002F RID: 47 RVA: 0x000024D9 File Offset: 0x000014D9
		// (set) Token: 0x06000030 RID: 48 RVA: 0x000024E6 File Offset: 0x000014E6
		public double GrossAmount
		{
			get
			{
				return this.GetDoubleValue(10208);
			}
			set
			{
				this.SetDoubleValue(10208, value);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000031 RID: 49 RVA: 0x000024F4 File Offset: 0x000014F4
		// (set) Token: 0x06000032 RID: 50 RVA: 0x00002501 File Offset: 0x00001501
		public double Percent
		{
			get
			{
				return this.GetDoubleValue(10210);
			}
			set
			{
				this.SetDoubleValue(10210, value);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000033 RID: 51 RVA: 0x0000250F File Offset: 0x0000150F
		// (set) Token: 0x06000034 RID: 52 RVA: 0x0000251C File Offset: 0x0000151C
		public double Ratio
		{
			get
			{
				return this.GetDoubleValue(10209);
			}
			set
			{
				this.SetDoubleValue(10209, value);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000035 RID: 53 RVA: 0x0000252A File Offset: 0x0000152A
		// (set) Token: 0x06000036 RID: 54 RVA: 0x00002537 File Offset: 0x00001537
		public double AdjustmentFactor
		{
			get
			{
				return this.GetDoubleValue(10211);
			}
			set
			{
				this.SetDoubleValue(10211, value);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00002545 File Offset: 0x00001545
		// (set) Token: 0x06000038 RID: 56 RVA: 0x0000254F File Offset: 0x0000154F
		[FIXField("15", EFieldOption.Optional)]
		public string Currency
		{
			get
			{
				return this.GetStringValue(15);
			}
			set
			{
				this.SetStringValue(15, value);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00002562 File Offset: 0x00001562
		// (set) Token: 0x0600003B RID: 59 RVA: 0x0000256A File Offset: 0x0000156A
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

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00002573 File Offset: 0x00001573
		// (set) Token: 0x0600003D RID: 61 RVA: 0x0000257B File Offset: 0x0000157B
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

		// Token: 0x0600003E RID: 62 RVA: 0x00002584 File Offset: 0x00001584
		public ISeriesObject NewInstance()
		{
			return new CorporateAction();
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000258B File Offset: 0x0000158B
		public void WriteTo(BinaryWriter writer)
		{
			writer.Write(1);
			writer.Write(this.datetime.Ticks);
			writer.Write(this.providerId);
			FIXGroupStreamer.WriteTo(writer, this);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000025B8 File Offset: 0x000015B8
		public void ReadFrom(BinaryReader reader)
		{
			reader.ReadByte();
			this.datetime = new DateTime(reader.ReadInt64());
			this.providerId = reader.ReadByte();
			FIXGroupStreamer.ReadFrom(reader, this);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000025E5 File Offset: 0x000015E5
		public object Clone()
		{
			return this;
		}

		// Token: 0x04000004 RID: 4
		private const byte VERSION = 1;

		// Token: 0x04000005 RID: 5
		private DateTime datetime;

		// Token: 0x04000006 RID: 6
		private byte providerId;
	}
}
