using System;
using System.Xml;
using SmartQuant.Data;

namespace SmartQuant.Providers.Xml
{
	// Token: 0x0200001E RID: 30
	internal class BarFactoryItemXmlNode
	{
		// Token: 0x060000A8 RID: 168 RVA: 0x00002F59 File Offset: 0x00001F59
		private BarFactoryItemXmlNode(XmlNode xmlNode)
		{
			this.xmlNode = xmlNode;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002F68 File Offset: 0x00001F68
		public static implicit operator XmlNode(BarFactoryItemXmlNode barFactoryItemXmlNode)
		{
			return barFactoryItemXmlNode.xmlNode;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002F70 File Offset: 0x00001F70
		public static explicit operator BarFactoryItemXmlNode(XmlNode xmlNode)
		{
			return new BarFactoryItemXmlNode(xmlNode);
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000AB RID: 171 RVA: 0x00002F78 File Offset: 0x00001F78
		// (set) Token: 0x060000AC RID: 172 RVA: 0x00002FBC File Offset: 0x00001FBC
		internal BarType BarType
		{
			get
			{
				XmlAttribute xmlAttribute = this.xmlNode.Attributes["type"];
				if (xmlAttribute != null)
				{
					return (BarType)Enum.Parse(typeof(BarType), xmlAttribute.Value);
				}
				return BarType.Time;
			}
			set
			{
				XmlAttribute xmlAttribute = this.xmlNode.OwnerDocument.CreateAttribute("type");
				this.xmlNode.Attributes.Append(xmlAttribute);
				xmlAttribute.Value = value.ToString();
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00003002 File Offset: 0x00002002
		// (set) Token: 0x060000AE RID: 174 RVA: 0x00003024 File Offset: 0x00002024
		internal long BarSize
		{
			get
			{
				return long.Parse(this.xmlNode.Attributes["size"].Value);
			}
			set
			{
				XmlAttribute xmlAttribute = this.xmlNode.OwnerDocument.CreateAttribute("size");
				xmlAttribute.Value = value.ToString();
				this.xmlNode.Attributes.Append(xmlAttribute);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00003066 File Offset: 0x00002066
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x00003088 File Offset: 0x00002088
		internal bool Enabled
		{
			get
			{
				return bool.Parse(this.xmlNode.Attributes["enabled"].Value);
			}
			set
			{
				XmlAttribute xmlAttribute = this.xmlNode.OwnerDocument.CreateAttribute("enabled");
				xmlAttribute.Value = value.ToString();
				this.xmlNode.Attributes.Append(xmlAttribute);
			}
		}

		// Token: 0x0400004A RID: 74
		internal const string NAME = "item";

		// Token: 0x0400004B RID: 75
		private const string ATTR_TYPE = "type";

		// Token: 0x0400004C RID: 76
		private const string ATTR_SIZE = "size";

		// Token: 0x0400004D RID: 77
		private const string ATTR_ENABLED = "enabled";

		// Token: 0x0400004E RID: 78
		private XmlNode xmlNode;
	}
}
