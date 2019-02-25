using System;

namespace SmartQuant
{
	// Token: 0x0200000C RID: 12
	public class RuntimeError
	{
		// Token: 0x06000040 RID: 64 RVA: 0x00002F08 File Offset: 0x00001F08
		public RuntimeError(DateTime datetime, RuntimeErrorLevel level, string description, string details, object source)
		{
			this.datetime = datetime;
			this.level = level;
			this.description = description;
			this.details = details;
			this.source = source;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002F35 File Offset: 0x00001F35
		public RuntimeError(RuntimeErrorLevel level, string description, string details, object source) : this(DateTime.Now, level, description, details, source)
		{
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002F47 File Offset: 0x00001F47
		public RuntimeError(RuntimeErrorLevel level, Exception e, object source) : this(level, e.Message, e.ToString(), source)
		{
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002F5D File Offset: 0x00001F5D
		public RuntimeError(RuntimeErrorLevel level, Exception e) : this(level, e, null)
		{
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00002F68 File Offset: 0x00001F68
		public DateTime DateTime
		{
			get
			{
				return this.datetime;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00002F70 File Offset: 0x00001F70
		public RuntimeErrorLevel Level
		{
			get
			{
				return this.level;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00002F78 File Offset: 0x00001F78
		public string Description
		{
			get
			{
				return this.description;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00002F80 File Offset: 0x00001F80
		public string Details
		{
			get
			{
				return this.details;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00002F88 File Offset: 0x00001F88
		public object Source
		{
			get
			{
				return this.source;
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002F90 File Offset: 0x00001F90
		public override string ToString()
		{
			string text = (this.source == null) ? "Not defined." : this.source.ToString();
			return string.Concat(new string[]
			{
				"DateTime: ",
				this.datetime.ToShortDateString(),
				" ",
				this.datetime.ToLongTimeString(),
				Environment.NewLine,
				"Level: ",
				this.level.ToString(),
				Environment.NewLine,
				"Source: ",
				text,
				Environment.NewLine,
				"Description: ",
				this.description,
				Environment.NewLine,
				"Details: ",
				this.details
			});
		}

		// Token: 0x04000034 RID: 52
		private DateTime datetime;

		// Token: 0x04000035 RID: 53
		private RuntimeErrorLevel level;

		// Token: 0x04000036 RID: 54
		private string description;

		// Token: 0x04000037 RID: 55
		private string details;

		// Token: 0x04000038 RID: 56
		private object source;
	}
}
