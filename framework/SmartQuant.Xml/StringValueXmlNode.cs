using System;

namespace SmartQuant.Xml
{
	// Token: 0x02000013 RID: 19
	public class StringValueXmlNode : ValueXmlNode
	{
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00002FAA File Offset: 0x00001FAA
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x00002FB2 File Offset: 0x00001FB2
		public string Value
		{
			get
			{
				return base.GetStringValue();
			}
			set
			{
				base.SetValue(value);
			}
		}
	}
}
