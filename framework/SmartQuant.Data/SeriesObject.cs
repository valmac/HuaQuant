using System;
using System.IO;

namespace SmartQuant.Data
{
	// Token: 0x0200000C RID: 12
	public abstract class SeriesObject : ISeriesObject, ICloneable
	{
		// Token: 0x06000055 RID: 85 RVA: 0x00002D04 File Offset: 0x00001D04
		protected SeriesObject(DateTime datetime)
		{
			this.datetime = datetime;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002D13 File Offset: 0x00001D13
		protected SeriesObject()
		{
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00002D1B File Offset: 0x00001D1B
		public DateTime DateTime
		{
			get
			{
				return this.datetime;
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002D23 File Offset: 0x00001D23
		public virtual void ReadFrom(BinaryReader reader)
		{
			this.datetime = new DateTime(reader.ReadInt64());
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002D36 File Offset: 0x00001D36
		public virtual void WriteTo(BinaryWriter writer)
		{
			writer.Write(this.datetime.Ticks);
		}

		// Token: 0x0600005A RID: 90
		public abstract ISeriesObject NewInstance();

		// Token: 0x0600005B RID: 91
		public abstract object Clone();

		// Token: 0x04000016 RID: 22
		protected DateTime datetime;
	}
}
