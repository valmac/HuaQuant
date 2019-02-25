using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Xml;

namespace SmartQuant.Xml
{
	// Token: 0x02000011 RID: 17
	public class XmlDocumentBase : XmlDocument
	{
		// Token: 0x06000089 RID: 137 RVA: 0x00002A94 File Offset: 0x00001A94
		protected XmlDocumentBase(string name, string description, int schemaVersion)
		{
			this.LoadXml(string.Format("<{0}></{0}>", name));
			XmlDeclaration newChild = this.CreateXmlDeclaration("1.0", Encoding.Unicode.HeaderName, null);
			this.InsertBefore(newChild, base.DocumentElement);
			if (description != null)
			{
				XmlComment newChild2 = this.CreateComment(description);
				this.InsertBefore(newChild2, base.DocumentElement);
			}
			this.SetAttribute("schemaVersion", schemaVersion);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002B02 File Offset: 0x00001B02
		protected XmlDocumentBase(string name, string description) : this(name, description, 1)
		{
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002B0D File Offset: 0x00001B0D
		protected XmlDocumentBase(string name, int schemaVersion) : this(name, null, schemaVersion)
		{
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002B18 File Offset: 0x00001B18
		protected XmlDocumentBase(string name) : this(name, 1)
		{
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002B24 File Offset: 0x00001B24
		protected T GetChildNode<T>() where T : XmlNodeBase, new()
		{
			T t = Activator.CreateInstance<T>();
			string nodeName = t.NodeName;
			foreach (object obj in base.DocumentElement)
			{
				XmlNode xmlNode = (XmlNode)obj;
				if (xmlNode.Name == nodeName)
				{
					return XmlNodeBase.To<T>(xmlNode);
				}
			}
			T t2 = XmlNodeBase.To<T>(base.CreateElement(nodeName));
			base.DocumentElement.AppendChild(t2);
			return t2;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002BD0 File Offset: 0x00001BD0
		protected List<T> GetChildNodes<T>() where T : XmlNodeBase, new()
		{
			T t = Activator.CreateInstance<T>();
			string nodeName = t.NodeName;
			List<T> list = new List<T>();
			foreach (object obj in base.DocumentElement)
			{
				XmlNode xmlNode = (XmlNode)obj;
				if (xmlNode.Name == nodeName)
				{
					list.Add(XmlNodeBase.To<T>(xmlNode));
				}
			}
			return list;
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00002C60 File Offset: 0x00001C60
		public int SchemaVersion
		{
			get
			{
				if (!base.DocumentElement.HasAttribute("schemaVersion"))
				{
					return 1;
				}
				return this.GetInt32Attribute("schemaVersion");
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002C84 File Offset: 0x00001C84
		protected string GetStringAttribute(string name)
		{
			XmlAttribute xmlAttribute = base.DocumentElement.Attributes[name];
			if (xmlAttribute != null)
			{
				return xmlAttribute.Value;
			}
			return null;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002CAE File Offset: 0x00001CAE
		protected int GetInt32Attribute(string name)
		{
			return int.Parse(this.GetStringAttribute(name), CultureInfo.InvariantCulture);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002CC1 File Offset: 0x00001CC1
		protected uint GetUInt32Attribute(string name)
		{
			return uint.Parse(this.GetStringAttribute(name), CultureInfo.InvariantCulture);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002CD4 File Offset: 0x00001CD4
		protected long GetInt64Attribute(string name)
		{
			return long.Parse(this.GetStringAttribute(name), CultureInfo.InvariantCulture);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002CE7 File Offset: 0x00001CE7
		protected ulong GetUInt64Attribute(string name)
		{
			return ulong.Parse(this.GetStringAttribute(name), CultureInfo.InvariantCulture);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002CFA File Offset: 0x00001CFA
		protected short GetInt16Attribute(string name)
		{
			return short.Parse(this.GetStringAttribute(name), CultureInfo.InvariantCulture);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002D0D File Offset: 0x00001D0D
		protected ushort GetUInt16Attribute(string name)
		{
			return ushort.Parse(this.GetStringAttribute(name), CultureInfo.InvariantCulture);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002D20 File Offset: 0x00001D20
		protected byte GetByteAttribute(string name)
		{
			return byte.Parse(this.GetStringAttribute(name), CultureInfo.InvariantCulture);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00002D33 File Offset: 0x00001D33
		protected sbyte GetSByteAttribute(string name)
		{
			return sbyte.Parse(this.GetStringAttribute(name), CultureInfo.InvariantCulture);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002D46 File Offset: 0x00001D46
		protected float GetFloatAttribute(string name)
		{
			return float.Parse(this.GetStringAttribute(name), CultureInfo.InvariantCulture);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002D59 File Offset: 0x00001D59
		protected double GetDoubleAttribute(string name)
		{
			return double.Parse(this.GetStringAttribute(name), CultureInfo.InvariantCulture);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002D6C File Offset: 0x00001D6C
		protected decimal GetDecimalAttribute(string name)
		{
			return decimal.Parse(this.GetStringAttribute(name), CultureInfo.InvariantCulture);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002D7F File Offset: 0x00001D7F
		protected DateTime GetDateTimeAttribute(string name)
		{
			return DateTime.Parse(this.GetStringAttribute(name), CultureInfo.InvariantCulture);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002D92 File Offset: 0x00001D92
		protected bool GetBooleanAttribute(string name)
		{
			return bool.Parse(this.GetStringAttribute(name));
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002DA0 File Offset: 0x00001DA0
		protected object GetEnumAttribute(string name, Type type)
		{
			return Enum.Parse(type, this.GetStringAttribute(name));
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002DAF File Offset: 0x00001DAF
		protected Type GetTypeAttribute(string name)
		{
			return Type.GetType(this.GetStringAttribute(name));
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002DBD File Offset: 0x00001DBD
		protected Guid GetGuidAttribute(string name)
		{
			return new Guid(this.GetStringAttribute(name));
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002DCC File Offset: 0x00001DCC
		protected void SetAttribute(string name, string value)
		{
			XmlAttribute xmlAttribute = base.DocumentElement.Attributes[name];
			if (xmlAttribute == null)
			{
				xmlAttribute = base.CreateAttribute(name);
				base.DocumentElement.Attributes.Append(xmlAttribute);
			}
			xmlAttribute.Value = value;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002E0F File Offset: 0x00001E0F
		protected void SetAttribute(string name, int value)
		{
			this.SetAttribute(name, value.ToString(CultureInfo.InvariantCulture));
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002E24 File Offset: 0x00001E24
		protected void SetAttribute(string name, uint value)
		{
			this.SetAttribute(name, value.ToString(CultureInfo.InvariantCulture));
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00002E39 File Offset: 0x00001E39
		protected void SetAttribute(string name, long value)
		{
			this.SetAttribute(name, value.ToString(CultureInfo.InvariantCulture));
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002E4E File Offset: 0x00001E4E
		protected void SetAttribute(string name, ulong value)
		{
			this.SetAttribute(name, value.ToString(CultureInfo.InvariantCulture));
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002E63 File Offset: 0x00001E63
		protected void SetAttribute(string name, short value)
		{
			this.SetAttribute(name, value.ToString(CultureInfo.InvariantCulture));
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002E78 File Offset: 0x00001E78
		protected void SetAttribute(string name, ushort value)
		{
			this.SetAttribute(name, value.ToString(CultureInfo.InvariantCulture));
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002E8D File Offset: 0x00001E8D
		protected void SetAttribute(string name, byte value)
		{
			this.SetAttribute(name, value.ToString(CultureInfo.InvariantCulture));
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002EA2 File Offset: 0x00001EA2
		protected void SetAttribute(string name, sbyte value)
		{
			this.SetAttribute(name, value.ToString(CultureInfo.InvariantCulture));
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002EB7 File Offset: 0x00001EB7
		protected void SetAttribute(string name, float value)
		{
			this.SetAttribute(name, value.ToString(CultureInfo.InvariantCulture));
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002ECC File Offset: 0x00001ECC
		protected void SetAttribute(string name, double value)
		{
			this.SetAttribute(name, value.ToString(CultureInfo.InvariantCulture));
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002EE1 File Offset: 0x00001EE1
		protected void SetAttribute(string name, decimal value)
		{
			this.SetAttribute(name, value.ToString(CultureInfo.InvariantCulture));
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002EF6 File Offset: 0x00001EF6
		protected void SetAttribute(string name, DateTime value)
		{
			this.SetAttribute(name, value.ToString(CultureInfo.InvariantCulture));
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002F0B File Offset: 0x00001F0B
		protected void SetAttribute(string name, bool value)
		{
			this.SetAttribute(name, value.ToString());
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00002F1B File Offset: 0x00001F1B
		protected void SetAttribute(string name, Enum value)
		{
			this.SetAttribute(name, value.ToString());
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002F2C File Offset: 0x00001F2C
		protected void SetAttribute(string name, Type value)
		{
			if (value.Assembly.GlobalAssemblyCache)
			{
				this.SetAttribute(name, value.AssemblyQualifiedName);
				return;
			}
			this.SetAttribute(name, string.Format("{0}, {1}", value.FullName, value.Assembly.GetName().Name));
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002F7B File Offset: 0x00001F7B
		protected void SetAttribute(string name, Guid value)
		{
			this.SetAttribute(name, value.ToString(null, CultureInfo.InvariantCulture));
		}

		// Token: 0x04000005 RID: 5
		protected const int DEFAULT_SCHEMA_VERSION = 1;

		// Token: 0x04000006 RID: 6
		private const string ATTR_SCHEMA_VERSION = "schemaVersion";
	}
}
