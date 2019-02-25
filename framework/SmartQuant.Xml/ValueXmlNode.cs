using System;

namespace SmartQuant.Xml
{
	// Token: 0x02000003 RID: 3
	public class ValueXmlNode : XmlNodeBase
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600005B RID: 91 RVA: 0x000028BC File Offset: 0x000018BC
		public sealed override string NodeName
		{
			get
			{
				return this.nodeName;
			}
		}

		// Token: 0x04000002 RID: 2
		internal string nodeName;
	}
}
