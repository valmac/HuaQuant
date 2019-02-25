using System;
using SmartQuant.Xml;

namespace SmartQuant.Simulation.Xml
{
	// Token: 0x02000026 RID: 38
	internal class SimulationExecutionServiceXmlDocument : XmlDocumentBase
	{
		// Token: 0x0600013C RID: 316 RVA: 0x00007A2D File Offset: 0x00006A2D
		public SimulationExecutionServiceXmlDocument() : base("configuration")
		{
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600013D RID: 317 RVA: 0x00007A3A File Offset: 0x00006A3A
		public OrderEntryListXmlNode Entries
		{
			get
			{
				return base.GetChildNode<OrderEntryListXmlNode>();
			}
		}
	}
}
