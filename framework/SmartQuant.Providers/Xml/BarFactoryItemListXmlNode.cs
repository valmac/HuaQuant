using System;
using System.Collections;
using System.Xml;

namespace SmartQuant.Providers.Xml
{
	// Token: 0x02000025 RID: 37
	internal class BarFactoryItemListXmlNode : IEnumerable
	{
		// Token: 0x060000D3 RID: 211 RVA: 0x00003433 File Offset: 0x00002433
		private BarFactoryItemListXmlNode(XmlNode xmlNode)
		{
			this.xmlNode = xmlNode;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00003442 File Offset: 0x00002442
		public static implicit operator XmlNode(BarFactoryItemListXmlNode barFactoryItemListXmlNode)
		{
			return barFactoryItemListXmlNode.xmlNode;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000344A File Offset: 0x0000244A
		public static explicit operator BarFactoryItemListXmlNode(XmlNode xmlNode)
		{
			return new BarFactoryItemListXmlNode(xmlNode);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00003454 File Offset: 0x00002454
		public IEnumerator GetEnumerator()
		{
			ArrayList arrayList = new ArrayList();
			foreach (object obj in this.xmlNode)
			{
				XmlNode xmlNode = (XmlNode)obj;
				arrayList.Add((BarFactoryItemXmlNode)xmlNode);
			}
			return arrayList.GetEnumerator();
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x000034C0 File Offset: 0x000024C0
		internal void AddItem(BarFactoryItem item)
		{
			BarFactoryItemXmlNode barFactoryItemXmlNode = (BarFactoryItemXmlNode)this.xmlNode.OwnerDocument.CreateElement("item");
			barFactoryItemXmlNode.Enabled = item.Enabled;
			barFactoryItemXmlNode.BarType = item.BarType;
			barFactoryItemXmlNode.BarSize = item.BarSize;
			this.xmlNode.AppendChild(barFactoryItemXmlNode);
		}

		// Token: 0x04000055 RID: 85
		internal const string NAME = "items";

		// Token: 0x04000056 RID: 86
		private XmlNode xmlNode;
	}
}
