using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000119 RID: 281
	public class OrderCancelRejectList : FIXGroupList
	{
		// Token: 0x1700182F RID: 6191
		public new OrderCancelReject this[int index]
		{
			get
			{
				return base[index] as OrderCancelReject;
			}
		}

		// Token: 0x060035BB RID: 13755 RVA: 0x00038B49 File Offset: 0x00037B49
		public new OrderCancelReject GetById(int id)
		{
			return base.GetById(id) as OrderCancelReject;
		}
	}
}
