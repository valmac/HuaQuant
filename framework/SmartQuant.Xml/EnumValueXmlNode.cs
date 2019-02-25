using System;

namespace SmartQuant.Xml
{
	// Token: 0x02000008 RID: 8
	public class EnumValueXmlNode<T> : ValueXmlNode
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000069 RID: 105 RVA: 0x0000295A File Offset: 0x0000195A
		// (set) Token: 0x0600006A RID: 106 RVA: 0x00002971 File Offset: 0x00001971
		public T Value
		{
			get
			{
				return (T)((object)base.GetEnumValue(typeof(T)));
			}
			set
			{
				base.SetValue(value.ToString());
			}
		}
	}
}
