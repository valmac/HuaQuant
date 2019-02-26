using System;
using SmartQuant.Xml;

namespace SmartQuant.Services.Xml
{
	// Token: 0x02000007 RID: 7
	internal class ServicePropertiesXmlDocument : XmlDocumentBase
	{
		// Token: 0x06000011 RID: 17 RVA: 0x00002093 File Offset: 0x00001093
		public ServicePropertiesXmlDocument() : base("document", "service properties")
		{
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000012 RID: 18 RVA: 0x000020A5 File Offset: 0x000010A5
		public ServiceListXmlNode Services
		{
			get
			{
				return base.GetChildNode<ServiceListXmlNode>();
			}
		}
	}
}
