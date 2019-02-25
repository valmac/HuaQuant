using System;
using System.Collections;
using System.Xml;

namespace SmartQuant.Providers.Xml
{
	// Token: 0x02000009 RID: 9
	internal class PropertyListXmlNode : IEnumerable
	{
		// Token: 0x06000021 RID: 33 RVA: 0x0000215A File Offset: 0x0000115A
		private PropertyListXmlNode(XmlNode xmlNode)
		{
			this.xmlNode = xmlNode;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002169 File Offset: 0x00001169
		public static implicit operator XmlNode(PropertyListXmlNode propertyListXmlNode)
		{
			return propertyListXmlNode.xmlNode;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002171 File Offset: 0x00001171
		public static explicit operator PropertyListXmlNode(XmlNode xmlNode)
		{
			return new PropertyListXmlNode(xmlNode);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000217C File Offset: 0x0000117C
		public IEnumerator GetEnumerator()
		{
			ArrayList arrayList = new ArrayList();
			foreach (object obj in this.xmlNode)
			{
				XmlNode xmlNode = (XmlNode)obj;
				arrayList.Add((PropertyXmlNode)xmlNode);
			}
			return arrayList.GetEnumerator();
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000021E8 File Offset: 0x000011E8
		internal void AddProperty(string name, Type type, string value)
		{
			PropertyXmlNode propertyXmlNode = (PropertyXmlNode)this.xmlNode.OwnerDocument.CreateElement("property");
			propertyXmlNode.Name = name;
			propertyXmlNode.Type = type;
			propertyXmlNode.Value = value;
			this.xmlNode.AppendChild(propertyXmlNode);
		}

		// Token: 0x04000027 RID: 39
		internal const string NAME = "properties";

		// Token: 0x04000028 RID: 40
		private XmlNode xmlNode;
	}
}
