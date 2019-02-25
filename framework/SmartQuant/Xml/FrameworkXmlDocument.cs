using System;
using System.Text;
using System.Xml;

namespace SmartQuant.Xml
{
	// Token: 0x0200000F RID: 15
	internal class FrameworkXmlDocument : XmlDocument
	{
		// Token: 0x0600004D RID: 77 RVA: 0x00003088 File Offset: 0x00002088
		internal FrameworkXmlDocument()
		{
			this.LoadXml("<framework></framework>");
			XmlDeclaration newChild = this.CreateXmlDeclaration("1.0", Encoding.Unicode.HeaderName, null);
			this.InsertBefore(newChild, base.DocumentElement);
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600004E RID: 78 RVA: 0x000030CC File Offset: 0x000020CC
		internal ReferenceListXmlNode References
		{
			get
			{
				foreach (object obj in base.DocumentElement.ChildNodes)
				{
					XmlNode xmlNode = (XmlNode)obj;
					if (xmlNode.Name == "references")
					{
						return (ReferenceListXmlNode)xmlNode;
					}
				}
				ReferenceListXmlNode referenceListXmlNode = (ReferenceListXmlNode)base.CreateElement("references");
				base.DocumentElement.AppendChild(referenceListXmlNode);
				return referenceListXmlNode;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00003168 File Offset: 0x00002168
		internal PluginListXmlNode Plugins
		{
			get
			{
				foreach (object obj in base.DocumentElement.ChildNodes)
				{
					XmlNode xmlNode = (XmlNode)obj;
					if (xmlNode.Name == "plugins")
					{
						return (PluginListXmlNode)xmlNode;
					}
				}
				PluginListXmlNode pluginListXmlNode = (PluginListXmlNode)base.CreateElement("plugins");
				base.DocumentElement.AppendChild(pluginListXmlNode);
				return pluginListXmlNode;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00003204 File Offset: 0x00002204
		internal DefaultListXmlNode Defaults
		{
			get
			{
				foreach (object obj in base.DocumentElement)
				{
					XmlNode xmlNode = (XmlNode)obj;
					if (xmlNode.Name == "defaults")
					{
						return (DefaultListXmlNode)xmlNode;
					}
				}
				DefaultListXmlNode defaultListXmlNode = (DefaultListXmlNode)base.CreateElement("defaults");
				base.DocumentElement.AppendChild(defaultListXmlNode);
				return defaultListXmlNode;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000051 RID: 81 RVA: 0x0000329C File Offset: 0x0000229C
		internal TraceLevelXmlNode TraceLevelNode
		{
			get
			{
				foreach (object obj in base.DocumentElement.ChildNodes)
				{
					XmlNode xmlNode = (XmlNode)obj;
					if (xmlNode.Name == "trace.level")
					{
						return (TraceLevelXmlNode)xmlNode;
					}
				}
				TraceLevelXmlNode traceLevelXmlNode = (TraceLevelXmlNode)base.CreateElement("trace.level");
				base.DocumentElement.AppendChild(traceLevelXmlNode);
				return traceLevelXmlNode;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00003338 File Offset: 0x00002338
		internal RuntimeErrorXmlNode RuntimeErrorNode
		{
			get
			{
				foreach (object obj in base.DocumentElement.ChildNodes)
				{
					XmlNode xmlNode = (XmlNode)obj;
					if (xmlNode.Name == "runtime.error")
					{
						return (RuntimeErrorXmlNode)xmlNode;
					}
				}
				RuntimeErrorXmlNode runtimeErrorXmlNode = (RuntimeErrorXmlNode)base.CreateElement("runtime.error");
				base.DocumentElement.AppendChild(runtimeErrorXmlNode);
				return runtimeErrorXmlNode;
			}
		}

		// Token: 0x0400003F RID: 63
		internal const string TAG_DOCUMENT = "framework";
	}
}
