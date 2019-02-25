using System;

namespace SmartQuant.Xml
{
	// Token: 0x0200000B RID: 11
	public class DateTimeValueXmlNode : ValueXmlNode
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000072 RID: 114 RVA: 0x000029C0 File Offset: 0x000019C0
		// (set) Token: 0x06000073 RID: 115 RVA: 0x000029C8 File Offset: 0x000019C8
		public DateTime Value
		{
			get
			{
				return base.GetDateTimeValue();
			}
			set
			{
				base.SetValue(value);
			}
		}
	}
}
