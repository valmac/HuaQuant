using System;
using System.Text;
using System.Xml;

namespace SmartQuant.Instruments.Xml
{
	// Token: 0x0200000D RID: 13
	internal class DataManagerXmlDocument : XmlDocument
	{
		// Token: 0x06000037 RID: 55 RVA: 0x000025E8 File Offset: 0x000015E8
		internal DataManagerXmlDocument()
		{
			this.LoadXml(string.Format("<{0}></{0}>", "settings"));
			XmlDeclaration newChild = this.CreateXmlDeclaration("1.0", Encoding.Unicode.HeaderName, null);
			this.InsertBefore(newChild, base.DocumentElement);
			XmlComment newChild2 = this.CreateComment("DataManager configuration settings.");
			this.InsertBefore(newChild2, base.DocumentElement);
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00002650 File Offset: 0x00001650
		internal DefaultBarXmlNode DefaultBar
		{
			get
			{
				foreach (object obj in base.DocumentElement)
				{
					XmlNode xmlNode = (XmlNode)obj;
					if (xmlNode.Name == "defaultBar")
					{
						return (DefaultBarXmlNode)xmlNode;
					}
				}
				DefaultBarXmlNode defaultBarXmlNode = (DefaultBarXmlNode)base.CreateElement("defaultBar");
				base.DocumentElement.AppendChild(defaultBarXmlNode);
				return defaultBarXmlNode;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000039 RID: 57 RVA: 0x000026E8 File Offset: 0x000016E8
		internal DataArrayListXmlNode DataArrayList
		{
			get
			{
				foreach (object obj in base.DocumentElement)
				{
					XmlNode xmlNode = (XmlNode)obj;
					if (xmlNode.Name == "dataArrays")
					{
						return (DataArrayListXmlNode)xmlNode;
					}
				}
				DataArrayListXmlNode dataArrayListXmlNode = (DataArrayListXmlNode)base.CreateElement("dataArrays");
				base.DocumentElement.AppendChild(dataArrayListXmlNode);
				return dataArrayListXmlNode;
			}
		}

		// Token: 0x04000009 RID: 9
		private const string TAG_DOCUMENT = "settings";
	}
}
