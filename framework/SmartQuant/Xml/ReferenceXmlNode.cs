using System;
using System.IO;
using System.Xml;

namespace SmartQuant.Xml
{
	// Token: 0x02000026 RID: 38
	internal class ReferenceXmlNode
	{
		// Token: 0x060000D6 RID: 214 RVA: 0x0000461E File Offset: 0x0000361E
		private ReferenceXmlNode(XmlNode xmlNode)
		{
			this.xmlNode = xmlNode;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000462D File Offset: 0x0000362D
		public static implicit operator XmlNode(ReferenceXmlNode referenceXmlNode)
		{
			return referenceXmlNode.xmlNode;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00004635 File Offset: 0x00003635
		public static explicit operator ReferenceXmlNode(XmlNode xmlNode)
		{
			return new ReferenceXmlNode(xmlNode);
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00004640 File Offset: 0x00003640
		// (set) Token: 0x060000DA RID: 218 RVA: 0x00004744 File Offset: 0x00003744
		internal Reference Reference
		{
			get
			{
				Reference result = null;
				bool enabled = bool.Parse(this.xmlNode.Attributes["enabled"].Value);
				switch ((ReferenceType)Enum.Parse(typeof(ReferenceType), this.xmlNode.Attributes["type"].Value))
				{
				case ReferenceType.SmartQuant:
					result = new SmartQuantReference(this.xmlNode.Attributes["name"].Value, enabled);
					break;
				case ReferenceType.GAC:
					result = new GacReference(this.xmlNode.Attributes["name"].Value, new Version(this.xmlNode.Attributes["version"].Value), enabled);
					break;
				case ReferenceType.User:
					result = new UserReference(new FileInfo(this.xmlNode.Attributes["path"].Value), enabled);
					break;
				}
				return result;
			}
			set
			{
				this.xmlNode.Attributes.Append(this.xmlNode.OwnerDocument.CreateAttribute("enabled")).Value = value.Enabled.ToString();
				this.xmlNode.Attributes.Append(this.xmlNode.OwnerDocument.CreateAttribute("type")).Value = value.ReferenceType.ToString();
				if (value.ReferenceType == ReferenceType.User)
				{
					this.xmlNode.Attributes.Append(this.xmlNode.OwnerDocument.CreateAttribute("path")).Value = value.Path;
					return;
				}
				this.xmlNode.Attributes.Append(this.xmlNode.OwnerDocument.CreateAttribute("name")).Value = value.AssemblyName.Name;
				if (value.ReferenceType == ReferenceType.GAC)
				{
					this.xmlNode.Attributes.Append(this.xmlNode.OwnerDocument.CreateAttribute("version")).Value = value.AssemblyName.Version.ToString();
				}
			}
		}

		// Token: 0x0400008B RID: 139
		internal const string NAME = "reference";

		// Token: 0x0400008C RID: 140
		private const string ATTR_TYPE = "type";

		// Token: 0x0400008D RID: 141
		private const string ATTR_NAME = "name";

		// Token: 0x0400008E RID: 142
		private const string ATTR_VERSION = "version";

		// Token: 0x0400008F RID: 143
		private const string ATTR_PATH = "path";

		// Token: 0x04000090 RID: 144
		private const string ATTR_ENABLED = "enabled";

		// Token: 0x04000091 RID: 145
		private XmlNode xmlNode;
	}
}
