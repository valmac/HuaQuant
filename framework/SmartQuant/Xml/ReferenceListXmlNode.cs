using System;
using System.Collections;
using System.Xml;

namespace SmartQuant.Xml
{
	// Token: 0x02000020 RID: 32
	internal class ReferenceListXmlNode : IEnumerable
	{
		// Token: 0x060000C0 RID: 192 RVA: 0x00004383 File Offset: 0x00003383
		private ReferenceListXmlNode(XmlNode xmlNode)
		{
			this.xmlNode = xmlNode;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00004392 File Offset: 0x00003392
		public static implicit operator XmlNode(ReferenceListXmlNode referenceListXmlNode)
		{
			return referenceListXmlNode.xmlNode;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000439A File Offset: 0x0000339A
		public static explicit operator ReferenceListXmlNode(XmlNode xmlNode)
		{
			return new ReferenceListXmlNode(xmlNode);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000043A4 File Offset: 0x000033A4
		public IEnumerator GetEnumerator()
		{
			ArrayList arrayList = new ArrayList();
			foreach (object obj in this.xmlNode.ChildNodes)
			{
				XmlNode xmlNode = (XmlNode)obj;
				arrayList.Add((ReferenceXmlNode)xmlNode);
			}
			return arrayList.GetEnumerator();
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00004414 File Offset: 0x00003414
		internal void Add(Reference reference)
		{
			ReferenceXmlNode referenceXmlNode = (ReferenceXmlNode)this.xmlNode.OwnerDocument.CreateElement("reference");
			referenceXmlNode.Reference = reference;
			this.xmlNode.AppendChild(referenceXmlNode);
		}

		// Token: 0x04000081 RID: 129
		internal const string NAME = "references";

		// Token: 0x04000082 RID: 130
		private XmlNode xmlNode;
	}
}
