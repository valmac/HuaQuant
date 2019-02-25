using System;

namespace SmartQuant.FIX
{
	// Token: 0x02000139 RID: 313
	public class MarketDataRequestList : FIXGroupList
	{
		// Token: 0x06003CCC RID: 15564 RVA: 0x0004011B File Offset: 0x0003F11B
		public new FIXMarketDataRequest GetById(int id)
		{
			return base.GetById(id) as FIXMarketDataRequest;
		}

		// Token: 0x17001B64 RID: 7012
		public new FIXMarketDataRequest this[int index]
		{
			get
			{
				return this.fList[index] as FIXMarketDataRequest;
			}
		}

		// Token: 0x06003CCE RID: 15566 RVA: 0x0004013C File Offset: 0x0003F13C
		public static implicit operator FIXMarketDataRequest[](MarketDataRequestList list)
		{
			FIXMarketDataRequest[] array = new FIXMarketDataRequest[list.Count];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = list[i];
			}
			return array;
		}
	}
}
