using System;
using System.Xml;

namespace SmartQuant.Providers.Xml
{
	// Token: 0x0200004D RID: 77
	internal class PropertyXmlNode
	{
		// Token: 0x060001CE RID: 462 RVA: 0x00005348 File Offset: 0x00004348
		private PropertyXmlNode(XmlNode xmlNode)
		{
			this.xmlNode = xmlNode;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00005357 File Offset: 0x00004357
		public static implicit operator XmlNode(PropertyXmlNode propertyXmlNode)
		{
			return propertyXmlNode.xmlNode;
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0000535F File Offset: 0x0000435F
		public static explicit operator PropertyXmlNode(XmlNode xmlNode)
		{
			return new PropertyXmlNode(xmlNode);
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x00005367 File Offset: 0x00004367
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x00005383 File Offset: 0x00004383
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

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x000053B0 File Offset: 0x000043B0
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x000053D4 File Offset: 0x000043D4
		internal Type Type
		{
			get
			{
				return Type.GetType(this.xmlNode.Attributes["type"].Value);
			}
			set
			{
				XmlAttribute xmlAttribute = this.xmlNode.Attributes.Append(this.xmlNode.OwnerDocument.CreateAttribute("type"));
				xmlAttribute.Value = value.FullName + ", " + value.Assembly.GetName().Name;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x0000542D File Offset: 0x0000442D
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x0000543A File Offset: 0x0000443A
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

		// Token: 0x040000B5 RID: 181
		internal const string NAME = "property";

		// Token: 0x040000B6 RID: 182
		private const string ATTR_NAME = "name";

		// Token: 0x040000B7 RID: 183
		private const string ATTR_TYPE = "type";

		// Token: 0x040000B8 RID: 184
		private XmlNode xmlNode;
	}
}
