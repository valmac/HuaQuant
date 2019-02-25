using System;

namespace SmartQuant.Xml
{
	// Token: 0x0200000D RID: 13
	public class TypeValueXmlNode : ValueXmlNode
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000078 RID: 120 RVA: 0x000029F2 File Offset: 0x000019F2
		// (set) Token: 0x06000079 RID: 121 RVA: 0x000029FA File Offset: 0x000019FA
		public Type Value
		{
			get
			{
				return base.GetTypeValue();
			}
			set
			{
				base.SetValue(value);
			}
		}
	}
}
