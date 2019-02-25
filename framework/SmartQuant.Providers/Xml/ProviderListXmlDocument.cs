using System;
using System.Collections;
using System.Text;
using System.Xml;

namespace SmartQuant.Providers.Xml
{
	// Token: 0x02000011 RID: 17
	internal class ProviderListXmlDocument : XmlDocument
	{
		// Token: 0x0600004B RID: 75 RVA: 0x0000228C File Offset: 0x0000128C
		internal ProviderListXmlDocument()
		{
			this.LoadXml("<providers></providers>");
			XmlDeclaration newChild = this.CreateXmlDeclaration("1.0", Encoding.Unicode.HeaderName, null);
			this.InsertBefore(newChild, base.DocumentElement);
			XmlComment newChild2 = this.CreateComment("Saved Provider's Properties");
			this.InsertBefore(newChild2, base.DocumentElement);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000022EC File Offset: 0x000012EC
		internal ProviderXmlNode CreateProviderNode()
		{
			ProviderXmlNode providerXmlNode = (ProviderXmlNode)base.CreateElement("provider");
			base.DocumentElement.AppendChild(providerXmlNode);
			return providerXmlNode;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002320 File Offset: 0x00001320
		internal ProviderXmlNode[] GetProviders()
		{
			ArrayList arrayList = new ArrayList();
			foreach (object obj in base.DocumentElement)
			{
				XmlNode xmlNode = (XmlNode)obj;
				arrayList.Add((ProviderXmlNode)xmlNode);
			}
			return arrayList.ToArray(typeof(ProviderXmlNode)) as ProviderXmlNode[];
		}

		// Token: 0x0400002D RID: 45
		private const string TAG_DOCUMENT = "providers";
	}
}
