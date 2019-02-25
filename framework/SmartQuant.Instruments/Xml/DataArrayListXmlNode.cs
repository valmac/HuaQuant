using System;
using System.Xml;

namespace SmartQuant.Instruments.Xml
{
	// Token: 0x02000044 RID: 68
	internal class DataArrayListXmlNode
	{
		// Token: 0x06000375 RID: 885 RVA: 0x0000B71E File Offset: 0x0000A71E
		private DataArrayListXmlNode(XmlNode xmlNode)
		{
			this.xmlNode = xmlNode;
		}

		// Token: 0x06000376 RID: 886 RVA: 0x0000B72D File Offset: 0x0000A72D
		public static implicit operator XmlNode(DataArrayListXmlNode dataArrayListXmlNode)
		{
			return dataArrayListXmlNode.xmlNode;
		}

		// Token: 0x06000377 RID: 887 RVA: 0x0000B735 File Offset: 0x0000A735
		public static explicit operator DataArrayListXmlNode(XmlNode xmlNode)
		{
			return new DataArrayListXmlNode(xmlNode);
		}

		// Token: 0x170000CC RID: 204
		internal DataArrayXmlNode this[Type type]
		{
			get
			{
				foreach (object obj in this.xmlNode)
				{
					XmlNode xmlNode = (XmlNode)obj;
					DataArrayXmlNode dataArrayXmlNode = (DataArrayXmlNode)xmlNode;
					if (dataArrayXmlNode.Type == type)
					{
						return dataArrayXmlNode;
					}
				}
				DataArrayXmlNode dataArrayXmlNode2 = (DataArrayXmlNode)this.xmlNode.OwnerDocument.CreateElement("dataArray");
				this.xmlNode.AppendChild(dataArrayXmlNode2);
				dataArrayXmlNode2.Type = type;
				return dataArrayXmlNode2;
			}
		}

		// Token: 0x040000FC RID: 252
		internal const string NAME = "dataArrays";

		// Token: 0x040000FD RID: 253
		private XmlNode xmlNode;
	}
}
