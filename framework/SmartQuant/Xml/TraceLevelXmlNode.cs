using System;
using System.Diagnostics;
using System.Xml;

namespace SmartQuant.Xml
{
	// Token: 0x02000025 RID: 37
	internal class TraceLevelXmlNode
	{
		// Token: 0x060000D1 RID: 209 RVA: 0x000045C6 File Offset: 0x000035C6
		private TraceLevelXmlNode(XmlNode xmlNode)
		{
			this.xmlNode = xmlNode;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000045D5 File Offset: 0x000035D5
		public static implicit operator XmlNode(TraceLevelXmlNode traceLevelXmlNode)
		{
			return traceLevelXmlNode.xmlNode;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000045DD File Offset: 0x000035DD
		public static explicit operator TraceLevelXmlNode(XmlNode xmlNode)
		{
			return new TraceLevelXmlNode(xmlNode);
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x000045E5 File Offset: 0x000035E5
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x00004606 File Offset: 0x00003606
		internal System.Diagnostics.TraceLevel Level
		{
			get
			{
				return (System.Diagnostics.TraceLevel)Enum.Parse(typeof(System.Diagnostics.TraceLevel), this.xmlNode.InnerText);
			}
			set
			{
				this.xmlNode.InnerText = value.ToString();
			}
		}

		// Token: 0x04000089 RID: 137
		internal const string NAME = "trace.level";

		// Token: 0x0400008A RID: 138
		private XmlNode xmlNode;
	}
}
