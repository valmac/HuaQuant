using System;
using System.Globalization;

namespace SmartQuant.FIX
{
	// Token: 0x02000015 RID: 21
	public class FIXCharField : FIXField
	{
		// Token: 0x0600050B RID: 1291 RVA: 0x000076F1 File Offset: 0x000066F1
		public FIXCharField(int tag) : this(tag, ' ')
		{
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x000076FC File Offset: 0x000066FC
		public FIXCharField(int tag, char value) : base(tag)
		{
			this.Value = value;
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x0000770C File Offset: 0x0000670C
		public FIXCharField(int tag, string value) : this(tag, value, false)
		{
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00007717 File Offset: 0x00006717
		public FIXCharField(int tag, string value, bool invariantCulture) : this(tag, invariantCulture ? char.Parse(value) : char.Parse(value))
		{
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x0600050F RID: 1295 RVA: 0x00007731 File Offset: 0x00006731
		public override FIXType FIXType
		{
			get
			{
				return FIXType.Char;
			}
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00007734 File Offset: 0x00006734
		public override string ToString()
		{
			return this.Value.ToString();
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00007741 File Offset: 0x00006741
		public override string ToInvariantString()
		{
			return this.Value.ToString(CultureInfo.InvariantCulture);
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00007753 File Offset: 0x00006753
		public override object GetValue()
		{
			return this.Value;
		}

		// Token: 0x04000035 RID: 53
		public const char Empty = '\0';

		// Token: 0x04000036 RID: 54
		public char Value;
	}
}
