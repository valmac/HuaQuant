using System;
using System.Globalization;

namespace SmartQuant.FIX
{
	// Token: 0x02000075 RID: 117
	public class FIXBoolField : FIXField
	{
		// Token: 0x06001486 RID: 5254 RVA: 0x00017167 File Offset: 0x00016167
		public FIXBoolField(int tag) : this(tag, false)
		{
		}

		// Token: 0x06001487 RID: 5255 RVA: 0x00017171 File Offset: 0x00016171
		public FIXBoolField(int tag, bool value) : base(tag)
		{
			this.Value = value;
		}

		// Token: 0x06001488 RID: 5256 RVA: 0x00017181 File Offset: 0x00016181
		public FIXBoolField(int tag, string value) : this(tag, value, false)
		{
		}

		// Token: 0x06001489 RID: 5257 RVA: 0x0001718C File Offset: 0x0001618C
		public FIXBoolField(int tag, string value, bool invariantCulture) : this(tag, invariantCulture ? bool.Parse(value) : bool.Parse(value))
		{
		}

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x0600148A RID: 5258 RVA: 0x000171A6 File Offset: 0x000161A6
		public override FIXType FIXType
		{
			get
			{
				return FIXType.Bool;
			}
		}

		// Token: 0x0600148B RID: 5259 RVA: 0x000171A9 File Offset: 0x000161A9
		public override string ToString()
		{
			return this.Value.ToString();
		}

		// Token: 0x0600148C RID: 5260 RVA: 0x000171B6 File Offset: 0x000161B6
		public override string ToInvariantString()
		{
			return this.Value.ToString(CultureInfo.InvariantCulture);
		}

		// Token: 0x0600148D RID: 5261 RVA: 0x000171C8 File Offset: 0x000161C8
		public override object GetValue()
		{
			return this.Value;
		}

		// Token: 0x04000281 RID: 641
		public const bool Empty = false;

		// Token: 0x04000282 RID: 642
		public bool Value;
	}
}
