using System;
using System.Globalization;

namespace SmartQuant.FIX
{
	// Token: 0x02000043 RID: 67
	public class FIXDoubleField : FIXField
	{
		// Token: 0x06000F53 RID: 3923 RVA: 0x00011DCA File Offset: 0x00010DCA
		public FIXDoubleField(int tag) : this(tag, 0.0)
		{
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x00011DDC File Offset: 0x00010DDC
		public FIXDoubleField(int tag, double value) : base(tag)
		{
			this.Value = value;
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x00011DEC File Offset: 0x00010DEC
		public FIXDoubleField(int tag, string value) : this(tag, value, false)
		{
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x00011DF7 File Offset: 0x00010DF7
		public FIXDoubleField(int tag, string value, bool invariantCulture) : this(tag, invariantCulture ? double.Parse(value, CultureInfo.InvariantCulture) : double.Parse(value))
		{
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06000F57 RID: 3927 RVA: 0x00011E16 File Offset: 0x00010E16
		public override FIXType FIXType
		{
			get
			{
				return FIXType.Double;
			}
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x00011E19 File Offset: 0x00010E19
		public override string ToString()
		{
			return this.Value.ToString();
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x00011E26 File Offset: 0x00010E26
		public override string ToInvariantString()
		{
			return this.Value.ToString(CultureInfo.InvariantCulture);
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x00011E38 File Offset: 0x00010E38
		public override object GetValue()
		{
			return this.Value;
		}

		// Token: 0x040000D1 RID: 209
		public const double Empty = 0.0;

		// Token: 0x040000D2 RID: 210
		public double Value;
	}
}
