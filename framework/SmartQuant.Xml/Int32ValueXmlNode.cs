using System;

namespace SmartQuant.Xml
{
	// Token: 0x0200000C RID: 12
	public class Int32ValueXmlNode : ValueXmlNode
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000075 RID: 117 RVA: 0x000029D9 File Offset: 0x000019D9
		// (set) Token: 0x06000076 RID: 118 RVA: 0x000029E1 File Offset: 0x000019E1
		public int Value
		{
			get
			{
				return base.GetInt32Value();
			}
			set
			{
				base.SetValue(value);
			}
		}
	}
}
