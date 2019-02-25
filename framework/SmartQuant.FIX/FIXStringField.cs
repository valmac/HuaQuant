using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000045 RID: 69
	public class FIXStringField : FIXField
	{
		// Token: 0x06000F5E RID: 3934 RVA: 0x00011ED8 File Offset: 0x00010ED8
		public FIXStringField(int tag) : this(tag, "")
		{
		}

		// Token: 0x06000F5F RID: 3935 RVA: 0x00011EE6 File Offset: 0x00010EE6
		public FIXStringField(int tag, string value) : this(tag, value, false)
		{
		}

		// Token: 0x06000F60 RID: 3936 RVA: 0x00011EF1 File Offset: 0x00010EF1
		public FIXStringField(int tag, string value, bool invariantCulture) : base(tag)
		{
			this.Value = (invariantCulture ? value : value);
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x06000F61 RID: 3937 RVA: 0x00011F07 File Offset: 0x00010F07
		public override FIXType FIXType
		{
			get
			{
				return FIXType.String;
			}
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x00011F0A File Offset: 0x00010F0A
		public override string ToString()
		{
			return this.Value.ToString();
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x00011F17 File Offset: 0x00010F17
		public override string ToInvariantString()
		{
			return this.ToString();
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x00011F1F File Offset: 0x00010F1F
		public override object GetValue()
		{
			return this.Value;
		}

		// Token: 0x040000D7 RID: 215
		public const string Empty = "";

		// Token: 0x040000D8 RID: 216
		public string Value;
	}
}
