using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200018E RID: 398
	public class FIXMiscFeesGroup : FIXGroup
	{
		// Token: 0x1700220F RID: 8719
		// (get) Token: 0x06004B7E RID: 19326 RVA: 0x0005372E File Offset: 0x0005272E
		// (set) Token: 0x06004B7F RID: 19327 RVA: 0x00053740 File Offset: 0x00052740
		[FIXField("137", EFieldOption.Optional)]
		public double MiscFeeAmt
		{
			get
			{
				return this.GetDoubleField(137).Value;
			}
			set
			{
				this.AddDoubleField(137, value);
			}
		}

		// Token: 0x17002210 RID: 8720
		// (get) Token: 0x06004B80 RID: 19328 RVA: 0x0005374E File Offset: 0x0005274E
		// (set) Token: 0x06004B81 RID: 19329 RVA: 0x00053760 File Offset: 0x00052760
		[FIXField("138", EFieldOption.Optional)]
		public double MiscFeeCurr
		{
			get
			{
				return this.GetDoubleField(138).Value;
			}
			set
			{
				this.AddDoubleField(138, value);
			}
		}

		// Token: 0x17002211 RID: 8721
		// (get) Token: 0x06004B82 RID: 19330 RVA: 0x0005376E File Offset: 0x0005276E
		// (set) Token: 0x06004B83 RID: 19331 RVA: 0x00053780 File Offset: 0x00052780
		[FIXField("139", EFieldOption.Optional)]
		public char MiscFeeType
		{
			get
			{
				return this.GetCharField(139).Value;
			}
			set
			{
				this.AddCharField(139, value);
			}
		}

		// Token: 0x17002212 RID: 8722
		// (get) Token: 0x06004B84 RID: 19332 RVA: 0x0005378E File Offset: 0x0005278E
		// (set) Token: 0x06004B85 RID: 19333 RVA: 0x000537A0 File Offset: 0x000527A0
		[FIXField("891", EFieldOption.Optional)]
		public int MiscFeeBasis
		{
			get
			{
				return this.GetIntField(891).Value;
			}
			set
			{
				this.AddIntField(891, value);
			}
		}
	}
}
