using System;
using System.Globalization;

namespace SmartQuant.FIX
{
	// Token: 0x02000017 RID: 23
	public class FIXIntField : FIXField
	{
		// Token: 0x06000516 RID: 1302 RVA: 0x000077E6 File Offset: 0x000067E6
		public FIXIntField(int tag) : this(tag, 0)
		{
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x000077F0 File Offset: 0x000067F0
		public FIXIntField(int tag, int value) : base(tag)
		{
			this.Value = value;
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00007800 File Offset: 0x00006800
		public FIXIntField(int tag, string value) : this(tag, value, false)
		{
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x0000780B File Offset: 0x0000680B
		public FIXIntField(int tag, string value, bool invariantCulture) : this(tag, invariantCulture ? int.Parse(value, CultureInfo.InvariantCulture) : int.Parse(value))
		{
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x0600051A RID: 1306 RVA: 0x0000782A File Offset: 0x0000682A
		public override FIXType FIXType
		{
			get
			{
				return FIXType.Int;
			}
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x0000782D File Offset: 0x0000682D
		public override string ToString()
		{
			return this.Value.ToString();
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x0000783A File Offset: 0x0000683A
		public override string ToInvariantString()
		{
			return this.Value.ToString(CultureInfo.InvariantCulture);
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x0000784C File Offset: 0x0000684C
		public override object GetValue()
		{
			return this.Value;
		}

		// Token: 0x04000039 RID: 57
		public const int Empty = -1;

		// Token: 0x0400003A RID: 58
		public int Value;
	}
}
