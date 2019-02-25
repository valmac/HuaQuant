using System;
using System.IO;

namespace SmartQuant.Data
{
	// Token: 0x02000013 RID: 19
	[Serializable]
	public class Daily : Bar
	{
		// Token: 0x06000090 RID: 144 RVA: 0x000034A0 File Offset: 0x000024A0
		public Daily(DateTime date, double open, double high, double low, double close, long volume, long openInt) : base(BarType.Time, 86400L, date.Date, date.Date.AddSeconds(86399.0), open, high, low, close, volume, openInt)
		{
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000034E3 File Offset: 0x000024E3
		public Daily(DateTime date, double open, double high, double low, double close, long volume) : this(date, open, high, low, close, volume, 0L)
		{
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000034F6 File Offset: 0x000024F6
		public Daily(Daily daily) : base(daily)
		{
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000034FF File Offset: 0x000024FF
		public Daily() : this(DateTime.MinValue, 0.0, 0.0, 0.0, 0.0, 0L)
		{
			this.endTime = DateTime.MinValue;
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000094 RID: 148 RVA: 0x0000353D File Offset: 0x0000253D
		// (set) Token: 0x06000095 RID: 149 RVA: 0x00003545 File Offset: 0x00002545
		public DateTime Date
		{
			get
			{
				return base.DateTime;
			}
			set
			{
				base.DateTime = value.Date;
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00003554 File Offset: 0x00002554
		public override ISeriesObject NewInstance()
		{
			return new Daily();
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000355B File Offset: 0x0000255B
		public override void WriteTo(BinaryWriter writer)
		{
			base.WriteTo(writer);
			writer.Write(1);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000356B File Offset: 0x0000256B
		public override void ReadFrom(BinaryReader reader)
		{
			base.ReadFrom(reader);
			reader.ReadByte();
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000357B File Offset: 0x0000257B
		public override object Clone()
		{
			return new Daily(this);
		}

		// Token: 0x04000032 RID: 50
		private const byte VERSION = 1;
	}
}
