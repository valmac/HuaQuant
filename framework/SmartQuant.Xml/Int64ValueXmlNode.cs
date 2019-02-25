using System;

namespace SmartQuant.Xml
{
	// Token: 0x02000012 RID: 18
	public class Int64ValueXmlNode : ValueXmlNode
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x00002F91 File Offset: 0x00001F91
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x00002F99 File Offset: 0x00001F99
		public long Value
		{
			get
			{
				return base.GetInt64Value();
			}
			set
			{
				base.SetValue(value);
			}
		}
	}
}
