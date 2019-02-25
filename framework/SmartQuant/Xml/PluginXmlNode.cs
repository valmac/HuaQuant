using System;
using System.Xml;

namespace SmartQuant.Xml
{
	// Token: 0x02000021 RID: 33
	internal class PluginXmlNode
	{
		// Token: 0x060000C5 RID: 197 RVA: 0x00004455 File Offset: 0x00003455
		private PluginXmlNode(XmlNode xmlNode)
		{
			this.xmlNode = xmlNode;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00004464 File Offset: 0x00003464
		public static implicit operator XmlNode(PluginXmlNode pluginXmlNode)
		{
			return pluginXmlNode.xmlNode;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000446C File Offset: 0x0000346C
		public static explicit operator PluginXmlNode(XmlNode xmlNode)
		{
			return new PluginXmlNode(xmlNode);
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00004474 File Offset: 0x00003474
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x000044DC File Offset: 0x000034DC
		internal Plugin Plugin
		{
			get
			{
				return new Plugin(this.xmlNode.Attributes["assembly"].Value, this.xmlNode.Attributes["type"].Value, bool.Parse(this.xmlNode.Attributes["enabled"].Value));
			}
			set
			{
				this.xmlNode.Attributes.Append(this.xmlNode.OwnerDocument.CreateAttribute("enabled")).Value = value.Enabled.ToString();
				this.xmlNode.Attributes.Append(this.xmlNode.OwnerDocument.CreateAttribute("assembly")).Value = value.AssemblyName;
				this.xmlNode.Attributes.Append(this.xmlNode.OwnerDocument.CreateAttribute("type")).Value = value.TypeName;
			}
		}

		// Token: 0x04000083 RID: 131
		internal const string NAME = "plugin";

		// Token: 0x04000084 RID: 132
		private const string ATTR_ASSEMBLY = "assembly";

		// Token: 0x04000085 RID: 133
		private const string ATTR_TYPE = "type";

		// Token: 0x04000086 RID: 134
		private const string ATTR_ENABLED = "enabled";

		// Token: 0x04000087 RID: 135
		private XmlNode xmlNode;
	}
}
