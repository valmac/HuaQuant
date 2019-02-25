using System;
using System.Xml;
using SmartQuant.Data;

namespace SmartQuant.Instruments.Xml
{
	// Token: 0x02000043 RID: 67
	internal class DefaultBarXmlNode
	{
		// Token: 0x0600036E RID: 878 RVA: 0x0000B604 File Offset: 0x0000A604
		private DefaultBarXmlNode(XmlNode xmlNode)
		{
			this.xmlNode = xmlNode;
		}

		// Token: 0x0600036F RID: 879 RVA: 0x0000B613 File Offset: 0x0000A613
		public static implicit operator XmlNode(DefaultBarXmlNode defaultBarXmlNode)
		{
			return defaultBarXmlNode.xmlNode;
		}

		// Token: 0x06000370 RID: 880 RVA: 0x0000B61B File Offset: 0x0000A61B
		public static explicit operator DefaultBarXmlNode(XmlNode xmlNode)
		{
			return new DefaultBarXmlNode(xmlNode);
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000371 RID: 881 RVA: 0x0000B624 File Offset: 0x0000A624
		// (set) Token: 0x06000372 RID: 882 RVA: 0x0000B664 File Offset: 0x0000A664
		internal BarType Type
		{
			get
			{
				XmlAttribute xmlAttribute = this.xmlNode.Attributes["type"];
				return (BarType)Enum.Parse(typeof(BarType), xmlAttribute.Value);
			}
			set
			{
				XmlAttribute xmlAttribute = this.xmlNode.OwnerDocument.CreateAttribute("type");
				this.xmlNode.Attributes.Append(xmlAttribute);
				xmlAttribute.Value = value.ToString();
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000373 RID: 883 RVA: 0x0000B6AC File Offset: 0x0000A6AC
		// (set) Token: 0x06000374 RID: 884 RVA: 0x0000B6DC File Offset: 0x0000A6DC
		internal long Size
		{
			get
			{
				XmlAttribute xmlAttribute = this.xmlNode.Attributes["size"];
				return long.Parse(xmlAttribute.Value);
			}
			set
			{
				XmlAttribute xmlAttribute = this.xmlNode.OwnerDocument.CreateAttribute("size");
				this.xmlNode.Attributes.Append(xmlAttribute);
				xmlAttribute.Value = value.ToString();
			}
		}

		// Token: 0x040000F8 RID: 248
		internal const string NAME = "defaultBar";

		// Token: 0x040000F9 RID: 249
		private const string ATTR_TYPE = "type";

		// Token: 0x040000FA RID: 250
		private const string ATTR_SIZE = "size";

		// Token: 0x040000FB RID: 251
		private XmlNode xmlNode;
	}
}
