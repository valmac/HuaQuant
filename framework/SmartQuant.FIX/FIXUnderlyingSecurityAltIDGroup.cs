using System;

namespace SmartQuant.FIX
{
	// Token: 0x0200011A RID: 282
	public class FIXUnderlyingSecurityAltIDGroup : FIXGroup
	{
		// Token: 0x17001830 RID: 6192
		// (get) Token: 0x060035BC RID: 13756 RVA: 0x00038B57 File Offset: 0x00037B57
		// (set) Token: 0x060035BD RID: 13757 RVA: 0x00038B69 File Offset: 0x00037B69
		[FIXField("458", EFieldOption.Optional)]
		public string UnderlyingSecurityAltID
		{
			get
			{
				return this.GetStringField(458).Value;
			}
			set
			{
				this.AddStringField(458, value);
			}
		}

		// Token: 0x17001831 RID: 6193
		// (get) Token: 0x060035BE RID: 13758 RVA: 0x00038B77 File Offset: 0x00037B77
		// (set) Token: 0x060035BF RID: 13759 RVA: 0x00038B89 File Offset: 0x00037B89
		[FIXField("459", EFieldOption.Optional)]
		public string UnderlyingSecurityAltIDSource
		{
			get
			{
				return this.GetStringField(459).Value;
			}
			set
			{
				this.AddStringField(459, value);
			}
		}
	}
}
