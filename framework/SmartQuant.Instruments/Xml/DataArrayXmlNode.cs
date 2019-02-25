using System;
using System.Xml;

namespace SmartQuant.Instruments.Xml
{
	// Token: 0x0200002A RID: 42
	internal class DataArrayXmlNode
	{
		// Token: 0x06000264 RID: 612 RVA: 0x0000823D File Offset: 0x0000723D
		private DataArrayXmlNode(XmlNode xmlNode)
		{
			this.xmlNode = xmlNode;
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0000824C File Offset: 0x0000724C
		public static implicit operator XmlNode(DataArrayXmlNode dataArrayXmlNode)
		{
			return dataArrayXmlNode.xmlNode;
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00008254 File Offset: 0x00007254
		public static explicit operator DataArrayXmlNode(XmlNode xmlNode)
		{
			return new DataArrayXmlNode(xmlNode);
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000267 RID: 615 RVA: 0x0000825C File Offset: 0x0000725C
		// (set) Token: 0x06000268 RID: 616 RVA: 0x0000828C File Offset: 0x0000728C
		internal Type Type
		{
			get
			{
				XmlAttribute xmlAttribute = this.xmlNode.Attributes["type"];
				return Type.GetType(xmlAttribute.Value);
			}
			set
			{
				XmlAttribute xmlAttribute = this.xmlNode.OwnerDocument.CreateAttribute("type");
				this.xmlNode.Attributes.Append(xmlAttribute);
				xmlAttribute.Value = value.FullName + ", " + value.Assembly.GetName().Name;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000269 RID: 617 RVA: 0x000082E8 File Offset: 0x000072E8
		// (set) Token: 0x0600026A RID: 618 RVA: 0x00008318 File Offset: 0x00007318
		internal int Length
		{
			get
			{
				XmlAttribute xmlAttribute = this.xmlNode.Attributes["length"];
				return int.Parse(xmlAttribute.Value);
			}
			set
			{
				XmlAttribute xmlAttribute = this.xmlNode.OwnerDocument.CreateAttribute("length");
				this.xmlNode.Attributes.Append(xmlAttribute);
				xmlAttribute.Value = value.ToString();
			}
		}

		// Token: 0x040000A8 RID: 168
		internal const string NAME = "dataArray";

		// Token: 0x040000A9 RID: 169
		private const string ATTR_TYPE = "type";

		// Token: 0x040000AA RID: 170
		private const string ATTR_LENGTH = "length";

		// Token: 0x040000AB RID: 171
		private XmlNode xmlNode;
	}
}
