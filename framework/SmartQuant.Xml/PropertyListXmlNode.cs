using System;

namespace SmartQuant.Xml
{
	// Token: 0x02000007 RID: 7
	public class PropertyListXmlNode : ListXmlNode<PropertyXmlNode>
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00002920 File Offset: 0x00001920
		public override string NodeName
		{
			get
			{
				return "properties";
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002928 File Offset: 0x00001928
		public PropertyXmlNode Add(string name, Type type, string value)
		{
			PropertyXmlNode propertyXmlNode = base.AppendChildNode();
			propertyXmlNode.Name = name;
			propertyXmlNode.Type = type;
			propertyXmlNode.Value = value;
			return propertyXmlNode;
		}
	}
}
