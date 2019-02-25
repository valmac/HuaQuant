using System;

namespace SmartQuant.Xml
{
	// Token: 0x02000005 RID: 5
	public class BooleanValueXmlNode : ValueXmlNode
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000060 RID: 96 RVA: 0x000028E5 File Offset: 0x000018E5
		// (set) Token: 0x06000061 RID: 97 RVA: 0x000028ED File Offset: 0x000018ED
		public bool Value
		{
			get
			{
				return base.GetBooleanValue();
			}
			set
			{
				base.SetValue(value);
			}
		}
	}
}
