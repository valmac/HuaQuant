using System;

namespace SmartQuant.Xml
{
	// Token: 0x02000014 RID: 20
	public class Int16ValueXmlNode : ValueXmlNode
	{
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00002FC3 File Offset: 0x00001FC3
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x00002FCB File Offset: 0x00001FCB
		public short Value
		{
			get
			{
				return base.GetInt16Value();
			}
			set
			{
				base.SetValue(value);
			}
		}
	}
}
