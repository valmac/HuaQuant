using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000014 RID: 20
	public class FIXField
	{
		// Token: 0x06000503 RID: 1283 RVA: 0x000075BF File Offset: 0x000065BF
		protected FIXField(int tag)
		{
			this.Tag = tag;
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000504 RID: 1284 RVA: 0x000075CE File Offset: 0x000065CE
		public virtual FIXType FIXType
		{
			get
			{
				return FIXType.Unknown;
			}
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x000075D1 File Offset: 0x000065D1
		public override string ToString()
		{
			return "";
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x000075D8 File Offset: 0x000065D8
		public virtual string ToInvariantString()
		{
			return "";
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x000075DF File Offset: 0x000065DF
		public virtual object GetValue()
		{
			return null;
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x000075E4 File Offset: 0x000065E4
		public static FIXField Field(FIXType type, int tag)
		{
			switch (type)
			{
			case FIXType.Bool:
				return new FIXBoolField(tag);
			case FIXType.Int:
				return new FIXIntField(tag);
			case FIXType.Double:
				return new FIXDoubleField(tag);
			case FIXType.Char:
				return new FIXCharField(tag);
			case FIXType.String:
				return new FIXStringField(tag);
			case FIXType.DateTime:
				return new FIXDateTimeField(tag);
			case FIXType.NumInGroup:
				return new FIXNumInGroupField(tag);
			default:
				throw new ArgumentException("Unknown FIX field type : " + type.ToString());
			}
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x00007664 File Offset: 0x00006664
		public static FIXField Field(FIXType type, int tag, string value)
		{
			return FIXField.Field(type, tag, value, false);
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00007670 File Offset: 0x00006670
		public static FIXField Field(FIXType type, int tag, string value, bool invariantCulture)
		{
			switch (type)
			{
			case FIXType.Bool:
				return new FIXBoolField(tag, value, invariantCulture);
			case FIXType.Int:
				return new FIXIntField(tag, value, invariantCulture);
			case FIXType.Double:
				return new FIXDoubleField(tag, value, invariantCulture);
			case FIXType.Char:
				return new FIXCharField(tag, value, invariantCulture);
			case FIXType.String:
				return new FIXStringField(tag, value, invariantCulture);
			case FIXType.DateTime:
				return new FIXDateTimeField(tag, value, invariantCulture);
			default:
				throw new ArgumentException("Unknown FIX field type : " + type.ToString());
			}
		}

		// Token: 0x04000034 RID: 52
		public int Tag;
	}
}
