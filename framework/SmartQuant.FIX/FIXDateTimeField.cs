using System;
using System.Globalization;

namespace SmartQuant.FIX
{
	// Token: 0x0200005A RID: 90
	public class FIXDateTimeField : FIXField
	{
		// Token: 0x06001106 RID: 4358 RVA: 0x000135EF File Offset: 0x000125EF
		public FIXDateTimeField(int tag) : this(tag, DateTime.MinValue)
		{
		}

		// Token: 0x06001107 RID: 4359 RVA: 0x000135FD File Offset: 0x000125FD
		public FIXDateTimeField(int tag, DateTime value) : base(tag)
		{
			this.Value = value;
		}

		// Token: 0x06001108 RID: 4360 RVA: 0x0001360D File Offset: 0x0001260D
		public FIXDateTimeField(int tag, string value) : this(tag, value, false)
		{
		}

		// Token: 0x06001109 RID: 4361 RVA: 0x00013618 File Offset: 0x00012618
		public FIXDateTimeField(int tag, string value, bool invariantCulture) : this(tag, invariantCulture ? DateTime.Parse(value, CultureInfo.InvariantCulture) : DateTime.Parse(value))
		{
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x0600110A RID: 4362 RVA: 0x00013637 File Offset: 0x00012637
		public override FIXType FIXType
		{
			get
			{
				return FIXType.DateTime;
			}
		}

		// Token: 0x0600110B RID: 4363 RVA: 0x0001363A File Offset: 0x0001263A
		public override string ToString()
		{
			return this.Value.ToString();
		}

		// Token: 0x0600110C RID: 4364 RVA: 0x0001364D File Offset: 0x0001264D
		public override string ToInvariantString()
		{
			return this.Value.ToString(CultureInfo.InvariantCulture);
		}

		// Token: 0x0600110D RID: 4365 RVA: 0x0001365F File Offset: 0x0001265F
		public override object GetValue()
		{
			return this.Value;
		}

		// Token: 0x04000210 RID: 528
		public DateTime Value;
	}
}
