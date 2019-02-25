using System;

namespace SmartQuant.Xml
{
	// Token: 0x0200000F RID: 15
	public class FloatValueXmlNode : ValueXmlNode
	{
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00002A61 File Offset: 0x00001A61
		// (set) Token: 0x06000084 RID: 132 RVA: 0x00002A69 File Offset: 0x00001A69
		public float Value
		{
			get
			{
				return base.GetFloatValue();
			}
			set
			{
				base.SetValue(value);
			}
		}
	}
}
