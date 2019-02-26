using System;
using SmartQuant.Xml;

namespace SmartQuant.Services.Xml
{
	// Token: 0x0200000C RID: 12
	internal class ServiceListXmlNode : XmlNodeBase
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000021 RID: 33 RVA: 0x000020DC File Offset: 0x000010DC
		public override string NodeName
		{
			get
			{
				return "services";
			}
		}

		// Token: 0x1700000C RID: 12
		public ServiceXmlNode this[string name]
		{
			get
			{
				foreach (ServiceXmlNode serviceXmlNode in base.GetChildNodes<ServiceXmlNode>())
				{
					if (serviceXmlNode.ServiceName == name)
					{
						return serviceXmlNode;
					}
				}
				return null;
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002148 File Offset: 0x00001148
		public ServiceXmlNode Add(IService service)
		{
			return base.AppendChildNode<ServiceXmlNode>();
		}
	}
}
