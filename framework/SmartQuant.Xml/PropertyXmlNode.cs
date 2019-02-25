using System;

namespace SmartQuant.Xml
{
	// Token: 0x0200000E RID: 14
	public class PropertyXmlNode : XmlNodeBase
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00002A0B File Offset: 0x00001A0B
		public override string NodeName
		{
			get
			{
				return "property";
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00002A12 File Offset: 0x00001A12
		// (set) Token: 0x0600007D RID: 125 RVA: 0x00002A1F File Offset: 0x00001A1F
		public string Name
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

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00002A2D File Offset: 0x00001A2D
		// (set) Token: 0x0600007F RID: 127 RVA: 0x00002A3A File Offset: 0x00001A3A
		public Type Type
		{
			get
			{
				return base.GetTypeAttribute("type");
			}
			set
			{
				base.SetAttribute("type", value);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00002A48 File Offset: 0x00001A48
		// (set) Token: 0x06000081 RID: 129 RVA: 0x00002A50 File Offset: 0x00001A50
		public string Value
		{
			get
			{
				return base.GetStringValue();
			}
			set
			{
				base.SetValue(value);
			}
		}

		// Token: 0x04000003 RID: 3
		private const string ATTR_NAME = "name";

		// Token: 0x04000004 RID: 4
		private const string ATTR_TYPE = "type";
	}
}
