using System;
using System.Xml;

namespace SmartQuant.Providers.Xml
{
	// Token: 0x02000024 RID: 36
	internal class ProviderXmlNode
	{
		// Token: 0x060000CB RID: 203 RVA: 0x0000327D File Offset: 0x0000227D
		internal ProviderXmlNode(XmlNode xmlNode)
		{
			this.xmlNode = xmlNode;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000328C File Offset: 0x0000228C
		public static implicit operator XmlNode(ProviderXmlNode providerXmlNode)
		{
			return providerXmlNode.xmlNode;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00003294 File Offset: 0x00002294
		public static explicit operator ProviderXmlNode(XmlNode xmlNode)
		{
			return new ProviderXmlNode(xmlNode);
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000CE RID: 206 RVA: 0x0000329C File Offset: 0x0000229C
		// (set) Token: 0x060000CF RID: 207 RVA: 0x000032B8 File Offset: 0x000022B8
		internal string Name
		{
			get
			{
				return this.xmlNode.Attributes["name"].Value;
			}
			set
			{
				this.xmlNode.Attributes.Append(this.xmlNode.OwnerDocument.CreateAttribute("name")).Value = value;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x000032E8 File Offset: 0x000022E8
		internal PropertyListXmlNode Properties
		{
			get
			{
				foreach (object obj in this.xmlNode)
				{
					XmlNode xmlNode = (XmlNode)obj;
					if (xmlNode.Name == "properties")
					{
						return (PropertyListXmlNode)xmlNode;
					}
				}
				PropertyListXmlNode propertyListXmlNode = (PropertyListXmlNode)this.xmlNode.OwnerDocument.CreateElement("properties");
				this.xmlNode.AppendChild(propertyListXmlNode);
				return propertyListXmlNode;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00003388 File Offset: 0x00002388
		internal BarFactoryXmlNode BarFactory
		{
			get
			{
				foreach (object obj in this.xmlNode)
				{
					XmlNode xmlNode = (XmlNode)obj;
					if (xmlNode.Name == "barfactory")
					{
						return (BarFactoryXmlNode)xmlNode;
					}
				}
				return null;
			}
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000033F8 File Offset: 0x000023F8
		internal BarFactoryXmlNode CreateBarFactoryNode()
		{
			BarFactoryXmlNode barFactoryXmlNode = (BarFactoryXmlNode)this.xmlNode.OwnerDocument.CreateElement("barfactory");
			this.xmlNode.AppendChild(barFactoryXmlNode);
			return barFactoryXmlNode;
		}

		// Token: 0x04000052 RID: 82
		internal const string NAME = "provider";

		// Token: 0x04000053 RID: 83
		private const string ATTR_NAME = "name";

		// Token: 0x04000054 RID: 84
		private XmlNode xmlNode;
	}
}
