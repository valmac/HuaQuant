using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml;

namespace SmartQuant.Xml
{
	// Token: 0x02000002 RID: 2
	public abstract class XmlNodeBase
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2
		public abstract string NodeName { get; }

		// Token: 0x06000003 RID: 3 RVA: 0x00002058 File Offset: 0x00001058
		public static implicit operator XmlNode(XmlNodeBase xmlNodeBase)
		{
			return xmlNodeBase.xmlNode;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002060 File Offset: 0x00001060
		internal static T To<T>(XmlNode xmlNode) where T : XmlNodeBase, new()
		{
			T t = Activator.CreateInstance<T>();
			t.xmlNode = xmlNode;
			return t;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002080 File Offset: 0x00001080
		internal static T To<T>(XmlNode xmlNode, string name) where T : ValueXmlNode, new()
		{
			T t = Activator.CreateInstance<T>();
			t.xmlNode = xmlNode;
			t.nodeName = name;
			return t;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000020AC File Offset: 0x000010AC
		protected string GetStringAttribute(string name)
		{
			XmlAttribute xmlAttribute = this.xmlNode.Attributes[name];
			if (xmlAttribute != null)
			{
				return xmlAttribute.Value;
			}
			return null;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000020D6 File Offset: 0x000010D6
		protected int GetInt32Attribute(string name)
		{
			return int.Parse(this.GetStringAttribute(name), CultureInfo.InvariantCulture);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000020E9 File Offset: 0x000010E9
		protected uint GetUInt32Attribute(string name)
		{
			return uint.Parse(this.GetStringAttribute(name), CultureInfo.InvariantCulture);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000020FC File Offset: 0x000010FC
		protected long GetInt64Attribute(string name)
		{
			return long.Parse(this.GetStringAttribute(name), CultureInfo.InvariantCulture);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000210F File Offset: 0x0000110F
		protected ulong GetUInt64Attribute(string name)
		{
			return ulong.Parse(this.GetStringAttribute(name), CultureInfo.InvariantCulture);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002122 File Offset: 0x00001122
		protected short GetInt16Attribute(string name)
		{
			return short.Parse(this.GetStringAttribute(name), CultureInfo.InvariantCulture);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002135 File Offset: 0x00001135
		protected ushort GetUInt16Attribute(string name)
		{
			return ushort.Parse(this.GetStringAttribute(name), CultureInfo.InvariantCulture);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002148 File Offset: 0x00001148
		protected byte GetByteAttribute(string name)
		{
			return byte.Parse(this.GetStringAttribute(name), CultureInfo.InvariantCulture);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000215B File Offset: 0x0000115B
		protected sbyte GetSByteAttribute(string name)
		{
			return sbyte.Parse(this.GetStringAttribute(name), CultureInfo.InvariantCulture);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000216E File Offset: 0x0000116E
		protected float GetFloatAttribute(string name)
		{
			return float.Parse(this.GetStringAttribute(name), CultureInfo.InvariantCulture);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002181 File Offset: 0x00001181
		protected double GetDoubleAttribute(string name)
		{
			return double.Parse(this.GetStringAttribute(name), CultureInfo.InvariantCulture);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002194 File Offset: 0x00001194
		protected decimal GetDecimalAttribute(string name)
		{
			return decimal.Parse(this.GetStringAttribute(name), CultureInfo.InvariantCulture);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000021A7 File Offset: 0x000011A7
		protected DateTime GetDateTimeAttribute(string name)
		{
			return DateTime.Parse(this.GetStringAttribute(name), CultureInfo.InvariantCulture);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000021BA File Offset: 0x000011BA
		protected bool GetBooleanAttribute(string name)
		{
			return bool.Parse(this.GetStringAttribute(name));
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000021C8 File Offset: 0x000011C8
		protected object GetEnumAttribute(string name, Type type)
		{
			return Enum.Parse(type, this.GetStringAttribute(name));
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000021D7 File Offset: 0x000011D7
		protected Type GetTypeAttribute(string name)
		{
			return Type.GetType(this.GetStringAttribute(name));
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000021E5 File Offset: 0x000011E5
		protected Guid GetGuidAttribute(string name)
		{
			return new Guid(this.GetStringAttribute(name));
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000021F4 File Offset: 0x000011F4
		protected void SetAttribute(string name, string value)
		{
			XmlAttribute xmlAttribute = this.xmlNode.Attributes[name];
			if (xmlAttribute == null)
			{
				xmlAttribute = this.xmlNode.OwnerDocument.CreateAttribute(name);
				this.xmlNode.Attributes.Append(xmlAttribute);
			}
			xmlAttribute.Value = value;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002241 File Offset: 0x00001241
		protected void SetAttribute(string name, int value)
		{
			this.SetAttribute(name, value.ToString(CultureInfo.InvariantCulture));
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002256 File Offset: 0x00001256
		protected void SetAttribute(string name, uint value)
		{
			this.SetAttribute(name, value.ToString(CultureInfo.InvariantCulture));
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000226B File Offset: 0x0000126B
		protected void SetAttribute(string name, long value)
		{
			this.SetAttribute(name, value.ToString(CultureInfo.InvariantCulture));
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002280 File Offset: 0x00001280
		protected void SetAttribute(string name, ulong value)
		{
			this.SetAttribute(name, value.ToString(CultureInfo.InvariantCulture));
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002295 File Offset: 0x00001295
		protected void SetAttribute(string name, short value)
		{
			this.SetAttribute(name, value.ToString(CultureInfo.InvariantCulture));
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000022AA File Offset: 0x000012AA
		protected void SetAttribute(string name, ushort value)
		{
			this.SetAttribute(name, value.ToString(CultureInfo.InvariantCulture));
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000022BF File Offset: 0x000012BF
		protected void SetAttribute(string name, byte value)
		{
			this.SetAttribute(name, value.ToString(CultureInfo.InvariantCulture));
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000022D4 File Offset: 0x000012D4
		protected void SetAttribute(string name, sbyte value)
		{
			this.SetAttribute(name, value.ToString(CultureInfo.InvariantCulture));
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000022E9 File Offset: 0x000012E9
		protected void SetAttribute(string name, float value)
		{
			this.SetAttribute(name, value.ToString(CultureInfo.InvariantCulture));
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000022FE File Offset: 0x000012FE
		protected void SetAttribute(string name, double value)
		{
			this.SetAttribute(name, value.ToString(CultureInfo.InvariantCulture));
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002313 File Offset: 0x00001313
		protected void SetAttribute(string name, decimal value)
		{
			this.SetAttribute(name, value.ToString(CultureInfo.InvariantCulture));
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002328 File Offset: 0x00001328
		protected void SetAttribute(string name, DateTime value)
		{
			this.SetAttribute(name, value.ToString(CultureInfo.InvariantCulture));
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000233D File Offset: 0x0000133D
		protected void SetAttribute(string name, bool value)
		{
			this.SetAttribute(name, value.ToString());
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000234D File Offset: 0x0000134D
		protected void SetAttribute(string name, Enum value)
		{
			this.SetAttribute(name, value.ToString());
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000235C File Offset: 0x0000135C
		protected void SetAttribute(string name, Type value)
		{
			if (value.Assembly.GlobalAssemblyCache)
			{
				this.SetAttribute(name, value.AssemblyQualifiedName);
				return;
			}
			this.SetAttribute(name, string.Format("{0}, {1}", value.FullName, value.Assembly.GetName().Name));
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000023AB File Offset: 0x000013AB
		protected void SetAttribute(string name, Guid value)
		{
			this.SetAttribute(name, value.ToString(null, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000023C1 File Offset: 0x000013C1
		protected string GetStringValue()
		{
			return this.xmlNode.InnerText;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000023CE File Offset: 0x000013CE
		protected int GetInt32Value()
		{
			return int.Parse(this.GetStringValue(), CultureInfo.InvariantCulture);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000023E0 File Offset: 0x000013E0
		protected uint GetUInt32Value()
		{
			return uint.Parse(this.GetStringValue(), CultureInfo.InvariantCulture);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000023F2 File Offset: 0x000013F2
		protected long GetInt64Value()
		{
			return long.Parse(this.GetStringValue(), CultureInfo.InvariantCulture);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002404 File Offset: 0x00001404
		protected ulong GetUInt64Value()
		{
			return ulong.Parse(this.GetStringValue(), CultureInfo.InvariantCulture);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002416 File Offset: 0x00001416
		protected short GetInt16Value()
		{
			return short.Parse(this.GetStringValue(), CultureInfo.InvariantCulture);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002428 File Offset: 0x00001428
		protected ushort GetUInt16Value()
		{
			return ushort.Parse(this.GetStringValue(), CultureInfo.InvariantCulture);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000243A File Offset: 0x0000143A
		protected byte GetByteValue()
		{
			return byte.Parse(this.GetStringValue(), CultureInfo.InvariantCulture);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000244C File Offset: 0x0000144C
		protected sbyte GetSByteValue()
		{
			return sbyte.Parse(this.GetStringValue(), CultureInfo.InvariantCulture);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0000245E File Offset: 0x0000145E
		protected float GetFloatValue()
		{
			return float.Parse(this.GetStringValue(), CultureInfo.InvariantCulture);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002470 File Offset: 0x00001470
		protected double GetDoubleValue()
		{
			return double.Parse(this.GetStringValue(), CultureInfo.InvariantCulture);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002482 File Offset: 0x00001482
		protected decimal GetDecimalValue()
		{
			return decimal.Parse(this.GetStringValue(), CultureInfo.InvariantCulture);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002494 File Offset: 0x00001494
		protected DateTime GetDateTimeValue()
		{
			return DateTime.Parse(this.GetStringValue(), CultureInfo.InvariantCulture);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000024A6 File Offset: 0x000014A6
		protected bool GetBooleanValue()
		{
			return bool.Parse(this.GetStringValue());
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000024B3 File Offset: 0x000014B3
		protected object GetEnumValue(Type type)
		{
			return Enum.Parse(type, this.GetStringValue());
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000024C1 File Offset: 0x000014C1
		protected Type GetTypeValue()
		{
			return Type.GetType(this.GetStringValue());
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000024CE File Offset: 0x000014CE
		protected Guid GetGuidValue()
		{
			return new Guid(this.GetStringValue());
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000024DB File Offset: 0x000014DB
		protected void SetValue(string value)
		{
			this.xmlNode.InnerText = value;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000024E9 File Offset: 0x000014E9
		protected void SetValue(int value)
		{
			this.SetValue(value.ToString());
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000024F8 File Offset: 0x000014F8
		protected void SetValue(uint value)
		{
			this.SetValue(value.ToString());
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002507 File Offset: 0x00001507
		protected void SetValue(long value)
		{
			this.SetValue(value.ToString());
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002516 File Offset: 0x00001516
		protected void SetValue(ulong value)
		{
			this.SetValue(value.ToString());
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002525 File Offset: 0x00001525
		protected void SetValue(short value)
		{
			this.SetValue(value.ToString());
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002534 File Offset: 0x00001534
		protected void SetValue(ushort value)
		{
			this.SetValue(value.ToString());
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002543 File Offset: 0x00001543
		protected void SetValue(byte value)
		{
			this.SetValue(value.ToString());
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002552 File Offset: 0x00001552
		protected void SetValue(sbyte value)
		{
			this.SetValue(value.ToString());
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002561 File Offset: 0x00001561
		protected void SetValue(double value)
		{
			this.SetValue(value.ToString(CultureInfo.InvariantCulture));
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002575 File Offset: 0x00001575
		protected void SetValue(float value)
		{
			this.SetValue(value.ToString(CultureInfo.InvariantCulture));
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002589 File Offset: 0x00001589
		protected void SetValue(decimal value)
		{
			this.SetValue(value.ToString(CultureInfo.InvariantCulture));
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000259D File Offset: 0x0000159D
		protected void SetValue(DateTime value)
		{
			this.SetValue(value.ToString(CultureInfo.InvariantCulture));
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000025B1 File Offset: 0x000015B1
		protected void SetValue(bool value)
		{
			this.SetValue(value.ToString());
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000025C0 File Offset: 0x000015C0
		protected void SetValue(Enum value)
		{
			this.SetValue(value.ToString());
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000025D0 File Offset: 0x000015D0
		protected void SetValue(Type value)
		{
			if (value.Assembly.GlobalAssemblyCache)
			{
				this.SetValue(value.AssemblyQualifiedName);
				return;
			}
			this.SetValue(string.Format("{0}, {1}", value.FullName, value.Assembly.GetName().Name));
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000261D File Offset: 0x0000161D
		protected void SetValue(Guid value)
		{
			this.SetValue(value.ToString(null, CultureInfo.InvariantCulture));
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002634 File Offset: 0x00001634
		protected List<T> GetChildNodes<T>() where T : XmlNodeBase, new()
		{
			T t = Activator.CreateInstance<T>();
			string nodeName = t.NodeName;
			List<T> list = new List<T>();
			foreach (object obj in this.xmlNode)
			{
				XmlNode xmlNode = (XmlNode)obj;
				if (xmlNode.Name == nodeName)
				{
					list.Add(XmlNodeBase.To<T>(xmlNode));
				}
			}
			return list;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000026C4 File Offset: 0x000016C4
		protected T GetChildNode<T>() where T : XmlNodeBase, new()
		{
			T t = Activator.CreateInstance<T>();
			string nodeName = t.NodeName;
			foreach (object obj in this.xmlNode)
			{
				XmlNode xmlNode = (XmlNode)obj;
				if (xmlNode.Name == nodeName)
				{
					return XmlNodeBase.To<T>(xmlNode);
				}
			}
			return this.AppendChildNode<T>();
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002750 File Offset: 0x00001750
		protected T GetChildNode<T>(string name) where T : ValueXmlNode, new()
		{
			foreach (object obj in this.xmlNode)
			{
				XmlNode xmlNode = (XmlNode)obj;
				if (xmlNode.Name == name)
				{
					return XmlNodeBase.To<T>(xmlNode, name);
				}
			}
			return this.AppendChildNode<T>(name);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000027C4 File Offset: 0x000017C4
		protected T AppendChildNode<T>() where T : XmlNodeBase, new()
		{
			XmlDocument ownerDocument = this.xmlNode.OwnerDocument;
			T t = Activator.CreateInstance<T>();
			T t2 = XmlNodeBase.To<T>(ownerDocument.CreateElement(t.NodeName));
			this.xmlNode.AppendChild(t2);
			return t2;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002814 File Offset: 0x00001814
		protected T AppendChildNode<T>(string name) where T : ValueXmlNode, new()
		{
			T t = XmlNodeBase.To<T>(this.xmlNode.OwnerDocument.CreateElement(name));
			this.xmlNode.AppendChild(t);
			return t;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002850 File Offset: 0x00001850
		protected StringValueXmlNode GetStringValueNode(string name)
		{
			return this.GetChildNode<StringValueXmlNode>(name);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002859 File Offset: 0x00001859
		protected BooleanValueXmlNode GetBooleanValueNode(string name)
		{
			return this.GetChildNode<BooleanValueXmlNode>(name);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002862 File Offset: 0x00001862
		protected ByteValueXmlNode GetByteValueNode(string name)
		{
			return this.GetChildNode<ByteValueXmlNode>(name);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000286B File Offset: 0x0000186B
		protected DateTimeValueXmlNode GetDateTimeValueNode(string name)
		{
			return this.GetChildNode<DateTimeValueXmlNode>(name);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002874 File Offset: 0x00001874
		protected DecimalValueXmlNode GetDecimalValueNode(string name)
		{
			return this.GetChildNode<DecimalValueXmlNode>(name);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000287D File Offset: 0x0000187D
		protected DoubleValueXmlNode GetDoubleValueNode(string name)
		{
			return this.GetChildNode<DoubleValueXmlNode>(name);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002886 File Offset: 0x00001886
		protected FloatValueXmlNode GetFloatValueNode(string name)
		{
			return this.GetChildNode<FloatValueXmlNode>(name);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000288F File Offset: 0x0000188F
		protected GuidValueXmlNode GetGuidValueNode(string name)
		{
			return this.GetChildNode<GuidValueXmlNode>(name);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002898 File Offset: 0x00001898
		protected Int16ValueXmlNode GetInt16ValueNode(string name)
		{
			return this.GetChildNode<Int16ValueXmlNode>(name);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000028A1 File Offset: 0x000018A1
		protected Int32ValueXmlNode GetInt32ValueNode(string name)
		{
			return this.GetChildNode<Int32ValueXmlNode>(name);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000028AA File Offset: 0x000018AA
		protected Int64ValueXmlNode GetInt64ValueNode(string name)
		{
			return this.GetChildNode<Int64ValueXmlNode>(name);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000028B3 File Offset: 0x000018B3
		protected TypeValueXmlNode GetTypeValueNode(string name)
		{
			return this.GetChildNode<TypeValueXmlNode>(name);
		}

		// Token: 0x04000001 RID: 1
		private XmlNode xmlNode;
	}
}
