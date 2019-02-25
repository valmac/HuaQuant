using System;
using System.Xml;

namespace SmartQuant.Xml
{
	// Token: 0x02000015 RID: 21
	internal class DefaultXmlNode
	{
		// Token: 0x06000094 RID: 148 RVA: 0x00003D2D File Offset: 0x00002D2D
		private DefaultXmlNode(XmlNode xmlNode)
		{
			this.xmlNode = xmlNode;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00003D3C File Offset: 0x00002D3C
		public static implicit operator XmlNode(DefaultXmlNode defaultXmlNode)
		{
			return defaultXmlNode.xmlNode;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00003D44 File Offset: 0x00002D44
		public static explicit operator DefaultXmlNode(XmlNode xmlNode)
		{
			return new DefaultXmlNode(xmlNode);
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00003D4C File Offset: 0x00002D4C
		// (set) Token: 0x06000098 RID: 152 RVA: 0x00003D78 File Offset: 0x00002D78
		internal string Name
		{
			get
			{
				XmlAttribute xmlAttribute = this.xmlNode.Attributes["name"];
				return xmlAttribute.Value;
			}
			set
			{
				XmlAttribute xmlAttribute = this.xmlNode.OwnerDocument.CreateAttribute("name");
				this.xmlNode.Attributes.Append(xmlAttribute);
				xmlAttribute.Value = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00003DB4 File Offset: 0x00002DB4
		// (set) Token: 0x0600009A RID: 154 RVA: 0x00003DC1 File Offset: 0x00002DC1
		internal string Value
		{
			get
			{
				return this.xmlNode.InnerText;
			}
			set
			{
				this.xmlNode.InnerText = value;
			}
		}

		// Token: 0x04000065 RID: 101
		internal const string NAME = "default";

		// Token: 0x04000066 RID: 102
		private const string ATTR_NAME = "name";

		// Token: 0x04000067 RID: 103
		private XmlNode xmlNode;
	}
}
