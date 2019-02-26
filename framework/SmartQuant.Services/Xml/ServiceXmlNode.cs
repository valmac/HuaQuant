using System;
using SmartQuant.Xml;

namespace SmartQuant.Services.Xml
{
	// Token: 0x0200000E RID: 14
	internal class ServiceXmlNode : XmlNodeBase
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000027 RID: 39 RVA: 0x0000217D File Offset: 0x0000117D
		public override string NodeName
		{
			get
			{
				return "service";
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00002184 File Offset: 0x00001184
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00002191 File Offset: 0x00001191
		public string ServiceName
		{
			get
			{
				return base.GetStringAttribute("name");
			}
			set
			{
				base.SetAttribute("name", value);
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600002A RID: 42 RVA: 0x0000219F File Offset: 0x0000119F
		public PropertyListXmlNode Properties
		{
			get
			{
				return base.GetChildNode<PropertyListXmlNode>();
			}
		}

		// Token: 0x04000008 RID: 8
		private const string ATTR_NAME = "name";
	}
}
