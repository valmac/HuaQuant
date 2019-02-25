using System;
using System.Xml;

namespace SmartQuant.Xml
{
	// Token: 0x0200000B RID: 11
	internal class DefaultListXmlNode
	{
		// Token: 0x0600003B RID: 59 RVA: 0x00002E19 File Offset: 0x00001E19
		private DefaultListXmlNode(XmlNode xmlNode)
		{
			this.xmlNode = xmlNode;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002E28 File Offset: 0x00001E28
		public static implicit operator XmlNode(DefaultListXmlNode defaultListXmlNode)
		{
			return defaultListXmlNode.xmlNode;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002E30 File Offset: 0x00001E30
		public static explicit operator DefaultListXmlNode(XmlNode xmlNode)
		{
			return new DefaultListXmlNode(xmlNode);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002E38 File Offset: 0x00001E38
		internal void Add(string name, string value)
		{
			DefaultXmlNode defaultXmlNode = (DefaultXmlNode)this.xmlNode.OwnerDocument.CreateElement("default");
			this.xmlNode.AppendChild(defaultXmlNode);
			defaultXmlNode.Name = name;
			defaultXmlNode.Value = value;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002E80 File Offset: 0x00001E80
		internal string GetValue(string name, string defaultValue)
		{
			foreach (object obj in this.xmlNode)
			{
				XmlNode xmlNode = (XmlNode)obj;
				if (xmlNode.Name == "default")
				{
					DefaultXmlNode defaultXmlNode = (DefaultXmlNode)xmlNode;
					if (defaultXmlNode.Name == name)
					{
						return defaultXmlNode.Value;
					}
				}
			}
			return defaultValue;
		}

		// Token: 0x04000032 RID: 50
		internal const string NAME = "defaults";

		// Token: 0x04000033 RID: 51
		private XmlNode xmlNode;
	}
}
