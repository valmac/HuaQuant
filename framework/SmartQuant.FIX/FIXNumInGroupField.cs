using System;
using System.Globalization;

namespace SmartQuant.FIX
{
	// Token: 0x0200008B RID: 139
	public class FIXNumInGroupField : FIXField
	{
		// Token: 0x06001AFD RID: 6909 RVA: 0x0001DA3B File Offset: 0x0001CA3B
		public FIXNumInGroupField(int tag) : this(tag, 0)
		{
		}

		// Token: 0x06001AFE RID: 6910 RVA: 0x0001DA45 File Offset: 0x0001CA45
		public FIXNumInGroupField(int tag, int value) : base(tag)
		{
			this.Value = value;
		}

		// Token: 0x17000C22 RID: 3106
		// (get) Token: 0x06001AFF RID: 6911 RVA: 0x0001DA55 File Offset: 0x0001CA55
		public override FIXType FIXType
		{
			get
			{
				return FIXType.NumInGroup;
			}
		}

		// Token: 0x06001B00 RID: 6912 RVA: 0x0001DA58 File Offset: 0x0001CA58
		public override string ToString()
		{
			return this.Value.ToString();
		}

		// Token: 0x06001B01 RID: 6913 RVA: 0x0001DA65 File Offset: 0x0001CA65
		public override string ToInvariantString()
		{
			return this.Value.ToString(CultureInfo.InvariantCulture);
		}

		// Token: 0x06001B02 RID: 6914 RVA: 0x0001DA77 File Offset: 0x0001CA77
		public override object GetValue()
		{
			return this.Value;
		}

		// Token: 0x040002D2 RID: 722
		public int Value;
	}
}
