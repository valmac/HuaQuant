using System;

namespace SmartQuant.Xml
{
	// Token: 0x02000010 RID: 16
	public class ByteValueXmlNode : ValueXmlNode
	{
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00002A7A File Offset: 0x00001A7A
		// (set) Token: 0x06000087 RID: 135 RVA: 0x00002A82 File Offset: 0x00001A82
		public byte Value
		{
			get
			{
				return base.GetByteValue();
			}
			set
			{
				base.SetValue(value);
			}
		}
	}
}
