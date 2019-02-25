using System;
using SmartQuant.Xml;

namespace SmartQuant.Simulation.Xml
{
	// Token: 0x0200001B RID: 27
	internal class OrderEntryListXmlNode : ListXmlNode<OrderEntryXmlNode>
	{
		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00005B88 File Offset: 0x00004B88
		public override string NodeName
		{
			get
			{
				return "entries";
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00005B90 File Offset: 0x00004B90
		public OrderEntryXmlNode Add(OrderEntry entry)
		{
			OrderEntryXmlNode orderEntryXmlNode = base.AppendChildNode();
			orderEntryXmlNode.Enabled = entry.Enabled;
			orderEntryXmlNode.DateTime.Value = entry.DateTime;
			orderEntryXmlNode.Symbol.Value = ((entry.Instrument == null) ? "" : entry.Instrument.Symbol);
			orderEntryXmlNode.Side.Value = entry.Side;
			orderEntryXmlNode.OrdType.Value = entry.OrdType;
			orderEntryXmlNode.Price.Value = entry.Price;
			orderEntryXmlNode.StopPx.Value = entry.StopPx;
			orderEntryXmlNode.OrderQty.Value = entry.OrderQty;
			orderEntryXmlNode.Text.Value = entry.Text;
			return orderEntryXmlNode;
		}
	}
}
