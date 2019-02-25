using System;
using System.Collections;
using System.Xml;

namespace SmartQuant.Xml
{
	// Token: 0x0200003C RID: 60
	internal class PluginListXmlNode : IEnumerable
	{
		// Token: 0x0600012B RID: 299 RVA: 0x00005BD5 File Offset: 0x00004BD5
		private PluginListXmlNode(XmlNode xmlNode)
		{
			this.xmlNode = xmlNode;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00005BE4 File Offset: 0x00004BE4
		public static implicit operator XmlNode(PluginListXmlNode pluginListXmlNode)
		{
			return pluginListXmlNode.xmlNode;
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00005BEC File Offset: 0x00004BEC
		public static explicit operator PluginListXmlNode(XmlNode xmlNode)
		{
			return new PluginListXmlNode(xmlNode);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00005BF4 File Offset: 0x00004BF4
		public IEnumerator GetEnumerator()
		{
			ArrayList arrayList = new ArrayList();
			foreach (object obj in this.xmlNode.ChildNodes)
			{
				XmlNode xmlNode = (XmlNode)obj;
				arrayList.Add((PluginXmlNode)xmlNode);
			}
			return arrayList.GetEnumerator();
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00005C64 File Offset: 0x00004C64
		internal void Add(Plugin plugin)
		{
			PluginXmlNode pluginXmlNode = (PluginXmlNode)this.xmlNode.OwnerDocument.CreateElement("plugin");
			pluginXmlNode.Plugin = plugin;
			this.xmlNode.AppendChild(pluginXmlNode);
		}

		// Token: 0x040000EF RID: 239
		internal const string NAME = "plugins";

		// Token: 0x040000F0 RID: 240
		private XmlNode xmlNode;
	}
}
