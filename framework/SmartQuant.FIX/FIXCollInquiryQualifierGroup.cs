using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000089 RID: 137
	public class FIXCollInquiryQualifierGroup : FIXGroup
	{
		// Token: 0x17000C21 RID: 3105
		// (get) Token: 0x06001AF5 RID: 6901 RVA: 0x0001D57F File Offset: 0x0001C57F
		// (set) Token: 0x06001AF6 RID: 6902 RVA: 0x0001D591 File Offset: 0x0001C591
		[FIXField("896", EFieldOption.Optional)]
		public int CollInquiryQualifier
		{
			get
			{
				return this.GetIntField(896).Value;
			}
			set
			{
				this.AddIntField(896, value);
			}
		}
	}
}
