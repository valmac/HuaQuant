using System;
using SmartQuant.FIX;
using SmartQuant.Xml;

namespace SmartQuant.Simulation.Xml
{
	// Token: 0x0200000D RID: 13
	internal class OrderEntryXmlNode : XmlNodeBase
	{
		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600004D RID: 77 RVA: 0x0000297A File Offset: 0x0000197A
		public override string NodeName
		{
			get
			{
				return "entry";
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00002981 File Offset: 0x00001981
		// (set) Token: 0x0600004F RID: 79 RVA: 0x0000298E File Offset: 0x0000198E
		public bool Enabled
		{
			get
			{
				return base.GetBooleanAttribute("enabled");
			}
			set
			{
				base.SetAttribute("enabled", value);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000050 RID: 80 RVA: 0x0000299C File Offset: 0x0000199C
		public DateTimeValueXmlNode DateTime
		{
			get
			{
				return base.GetChildNode<DateTimeValueXmlNode>("datetime");
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000051 RID: 81 RVA: 0x000029A9 File Offset: 0x000019A9
		public StringValueXmlNode Symbol
		{
			get
			{
				return base.GetChildNode<StringValueXmlNode>("symbol");
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000052 RID: 82 RVA: 0x000029B6 File Offset: 0x000019B6
		public EnumValueXmlNode<Side> Side
		{
			get
			{
				return base.GetChildNode<EnumValueXmlNode<Side>>("side");
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000053 RID: 83 RVA: 0x000029C3 File Offset: 0x000019C3
		public EnumValueXmlNode<OrdType> OrdType
		{
			get
			{
				return base.GetChildNode<EnumValueXmlNode<OrdType>>("ordtype");
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000054 RID: 84 RVA: 0x000029D0 File Offset: 0x000019D0
		public DoubleValueXmlNode Price
		{
			get
			{
				return base.GetChildNode<DoubleValueXmlNode>("price");
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000055 RID: 85 RVA: 0x000029DD File Offset: 0x000019DD
		public DoubleValueXmlNode StopPx
		{
			get
			{
				return base.GetChildNode<DoubleValueXmlNode>("stoppx");
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000056 RID: 86 RVA: 0x000029EA File Offset: 0x000019EA
		public DoubleValueXmlNode OrderQty
		{
			get
			{
				return base.GetChildNode<DoubleValueXmlNode>("orderqty");
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000057 RID: 87 RVA: 0x000029F7 File Offset: 0x000019F7
		public StringValueXmlNode Text
		{
			get
			{
				return base.GetChildNode<StringValueXmlNode>("text");
			}
		}

		// Token: 0x0400001C RID: 28
		private const string ATTR_ENABLED = "enabled";

		// Token: 0x0400001D RID: 29
		private const string NODE_NAME_DATETIME = "datetime";

		// Token: 0x0400001E RID: 30
		private const string NODE_NAME_SYMBOL = "symbol";

		// Token: 0x0400001F RID: 31
		private const string NODE_NAME_SIDE = "side";

		// Token: 0x04000020 RID: 32
		private const string NODE_NAME_ORDTYPE = "ordtype";

		// Token: 0x04000021 RID: 33
		private const string NODE_NAME_PRICE = "price";

		// Token: 0x04000022 RID: 34
		private const string NODE_NAME_STOPPX = "stoppx";

		// Token: 0x04000023 RID: 35
		private const string NODE_NAME_ORDERQTY = "orderqty";

		// Token: 0x04000024 RID: 36
		private const string NODE_NAME_TEXT = "text";
	}
}
