using System;

namespace SmartQuant.Xml
{
	// Token: 0x0200000A RID: 10
	public class DoubleValueXmlNode : ValueXmlNode
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600006F RID: 111 RVA: 0x000029A7 File Offset: 0x000019A7
		// (set) Token: 0x06000070 RID: 112 RVA: 0x000029AF File Offset: 0x000019AF
		public double Value
		{
			get
			{
				return base.GetDoubleValue();
			}
			set
			{
				base.SetValue(value);
			}
		}
	}
}
