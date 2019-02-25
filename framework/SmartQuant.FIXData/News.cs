using System;
using System.IO;
using SmartQuant.Data;
using SmartQuant.FIX;

namespace SmartQuant.FIXData
{
	// Token: 0x02000007 RID: 7
	public class News : FIXNews, IDataObject, ISeriesObject, ICloneable
	{
		// Token: 0x06000042 RID: 66 RVA: 0x000025E8 File Offset: 0x000015E8
		public News()
		{
			this.providerId = 0;
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000043 RID: 67 RVA: 0x000025F7 File Offset: 0x000015F7
		// (set) Token: 0x06000044 RID: 68 RVA: 0x000025FF File Offset: 0x000015FF
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

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00002608 File Offset: 0x00001608
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00002610 File Offset: 0x00001610
		public DateTime DateTime
		{
			get
			{
				return base.OrigTime;
			}
			set
			{
				base.OrigTime = value;
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002619 File Offset: 0x00001619
		public ISeriesObject NewInstance()
		{
			return new News();
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002620 File Offset: 0x00001620
		public void WriteTo(BinaryWriter writer)
		{
			writer.Write(1);
			writer.Write(this.DateTime.Ticks);
			writer.Write(this.providerId);
			FIXGroupStreamer.WriteTo(writer, this);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000265B File Offset: 0x0000165B
		public void ReadFrom(BinaryReader reader)
		{
			reader.ReadByte();
			this.DateTime = new DateTime(reader.ReadInt64());
			this.providerId = reader.ReadByte();
			FIXGroupStreamer.ReadFrom(reader, this);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002688 File Offset: 0x00001688
		public object Clone()
		{
			return this;
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600004B RID: 75 RVA: 0x0000268B File Offset: 0x0000168B
		// (set) Token: 0x0600004C RID: 76 RVA: 0x00002693 File Offset: 0x00001693
		[View]
		public override string Headline
		{
			get
			{
				return base.Headline;
			}
			set
			{
				base.Headline = value;
			}
		}

		// Token: 0x04000007 RID: 7
		private const byte VERSION = 1;

		// Token: 0x04000008 RID: 8
		private byte providerId;
	}
}
