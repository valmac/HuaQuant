using System;

namespace SmartQuant.Xml
{
	// Token: 0x02000004 RID: 4
	public class DecimalValueXmlNode : ValueXmlNode
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600005D RID: 93 RVA: 0x000028CC File Offset: 0x000018CC
		// (set) Token: 0x0600005E RID: 94 RVA: 0x000028D4 File Offset: 0x000018D4
		public decimal Value
		{
			get
			{
				return base.GetDecimalValue();
			}
			set
			{
				base.SetValue(value);
			}
		}
	}
}
