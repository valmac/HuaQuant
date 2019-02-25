using System;
using System.Xml;

namespace SmartQuant.Providers.Xml
{
	// Token: 0x02000047 RID: 71
	internal class BarFactoryXmlNode
	{
		// Token: 0x0600019E RID: 414 RVA: 0x00004EC7 File Offset: 0x00003EC7
		private BarFactoryXmlNode(XmlNode xmlNode)
		{
			this.xmlNode = xmlNode;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00004ED6 File Offset: 0x00003ED6
		public static implicit operator XmlNode(BarFactoryXmlNode barFactoryXmlNode)
		{
			return barFactoryXmlNode.xmlNode;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00004EDE File Offset: 0x00003EDE
		public static explicit operator BarFactoryXmlNode(XmlNode xmlNode)
		{
			return new BarFactoryXmlNode(xmlNode);
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x00004EE6 File Offset: 0x00003EE6
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x00004F08 File Offset: 0x00003F08
		internal Type Type
		{
			get
			{
				return Type.GetType(this.xmlNode.Attributes["type"].Value);
			}
			set
			{
				XmlAttribute xmlAttribute = this.xmlNode.OwnerDocument.CreateAttribute("type");
				xmlAttribute.Value = value.FullName + ", " + value.Assembly.GetName().Name;
				this.xmlNode.Attributes.Append(xmlAttribute);
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x00004F63 File Offset: 0x00003F63
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x00004F84 File Offset: 0x00003F84
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

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x00004FC8 File Offset: 0x00003FC8
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x0000500C File Offset: 0x0000400C
		internal BarFactoryInput Input
		{
			get
			{
				XmlAttribute xmlAttribute = this.xmlNode.Attributes["input"];
				if (xmlAttribute == null)
				{
					return BarFactoryInput.Trade;
				}
				return (BarFactoryInput)Enum.Parse(typeof(BarFactoryInput), xmlAttribute.Value);
			}
			set
			{
				XmlAttribute xmlAttribute = this.xmlNode.OwnerDocument.CreateAttribute("input");
				xmlAttribute.Value = value.ToString();
				this.xmlNode.Attributes.Append(xmlAttribute);
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x00005054 File Offset: 0x00004054
		internal BarFactoryItemListXmlNode Items
		{
			get
			{
				foreach (object obj in this.xmlNode)
				{
					XmlNode xmlNode = (XmlNode)obj;
					if (xmlNode.Name == "items")
					{
						return (BarFactoryItemListXmlNode)xmlNode;
					}
				}
				BarFactoryItemListXmlNode barFactoryItemListXmlNode = (BarFactoryItemListXmlNode)this.xmlNode.OwnerDocument.CreateElement("items");
				this.xmlNode.AppendChild(barFactoryItemListXmlNode);
				return barFactoryItemListXmlNode;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x000050F4 File Offset: 0x000040F4
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

		// Token: 0x040000A8 RID: 168
		internal const string NAME = "barfactory";

		// Token: 0x040000A9 RID: 169
		private const string ATTR_TYPE = "type";

		// Token: 0x040000AA RID: 170
		private const string ATTR_ENABLED = "enabled";

		// Token: 0x040000AB RID: 171
		private const string ATTR_INPUT = "input";

		// Token: 0x040000AC RID: 172
		private XmlNode xmlNode;
	}
}
