using System;

namespace SmartQuant.Xml
{
	// Token: 0x02000009 RID: 9
	public class GuidValueXmlNode : ValueXmlNode
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600006C RID: 108 RVA: 0x0000298E File Offset: 0x0000198E
		// (set) Token: 0x0600006D RID: 109 RVA: 0x00002996 File Offset: 0x00001996
		public Guid Value
		{
			get
			{
				return base.GetGuidValue();
			}
			set
			{
				base.SetValue(value);
			}
		}
	}
}
