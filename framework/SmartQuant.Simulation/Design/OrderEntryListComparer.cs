using System;
using System.Collections;

namespace SmartQuant.Simulation.Design
{
	// Token: 0x0200000C RID: 12
	internal class OrderEntryListComparer : IComparer
	{
		// Token: 0x0600004B RID: 75 RVA: 0x0000293C File Offset: 0x0000193C
		public int Compare(object x, object y)
		{
			OrderEntryViewItem orderEntryViewItem = (OrderEntryViewItem)x;
			OrderEntryViewItem orderEntryViewItem2 = (OrderEntryViewItem)y;
			return DateTime.Compare(orderEntryViewItem.Entry.DateTime, orderEntryViewItem2.Entry.DateTime);
		}
	}
}
