using System;
using System.Xml;

namespace SmartQuant.Xml
{
	// Token: 0x02000014 RID: 20
	internal class RuntimeErrorXmlNode
	{
		// Token: 0x0600008D RID: 141 RVA: 0x00003C2C File Offset: 0x00002C2C
		private RuntimeErrorXmlNode(XmlNode xmlNode)
		{
			this.xmlNode = xmlNode;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00003C3B File Offset: 0x00002C3B
		public static implicit operator XmlNode(RuntimeErrorXmlNode runtimeErrorXmlNode)
		{
			return runtimeErrorXmlNode.xmlNode;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00003C43 File Offset: 0x00002C43
		public static explicit operator RuntimeErrorXmlNode(XmlNode xmlNode)
		{
			return new RuntimeErrorXmlNode(xmlNode);
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00003C4C File Offset: 0x00002C4C
		// (set) Token: 0x06000091 RID: 145 RVA: 0x00003C7F File Offset: 0x00002C7F
		internal bool Enabled
		{
			get
			{
				XmlAttribute xmlAttribute = this.xmlNode.Attributes["enabled"];
				return xmlAttribute == null || bool.Parse(xmlAttribute.Value);
			}
			set
			{
				this.xmlNode.Attributes.Append(this.xmlNode.OwnerDocument.CreateAttribute("enabled")).Value = value.ToString();
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00003CB4 File Offset: 0x00002CB4
		// (set) Token: 0x06000093 RID: 147 RVA: 0x00003CF6 File Offset: 0x00002CF6
		internal RuntimeErrorOutputTarget Target
		{
			get
			{
				XmlAttribute xmlAttribute = this.xmlNode.Attributes["target"];
				if (xmlAttribute != null)
				{
					return (RuntimeErrorOutputTarget)Enum.Parse(typeof(RuntimeErrorOutputTarget), xmlAttribute.Value);
				}
				return RuntimeErrorOutputTarget.PopupWindow;
			}
			set
			{
				this.xmlNode.Attributes.Append(this.xmlNode.OwnerDocument.CreateAttribute("target")).Value = value.ToString();
			}
		}

		// Token: 0x04000061 RID: 97
		internal const string NAME = "runtime.error";

		// Token: 0x04000062 RID: 98
		private const string ATTR_ENABLED = "enabled";

		// Token: 0x04000063 RID: 99
		private const string ATTR_TARGET = "target";

		// Token: 0x04000064 RID: 100
		private XmlNode xmlNode;
	}
}
