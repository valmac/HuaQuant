using System;

namespace SmartQuant.Data
{
	// Token: 0x0200000B RID: 11
	public class MarketDepthArray : DataArray
	{
		// Token: 0x17000018 RID: 24
		public new MarketDepth this[int index]
		{
			get
			{
				return this.fList[index] as MarketDepth;
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002C48 File Offset: 0x00001C48
		public bool AddReplaceItem(MarketDepth item)
		{
			bool flag = false;
			int num = 0;
			foreach (object obj in this.fList)
			{
				MarketDepth marketDepth = (MarketDepth)obj;
				if (marketDepth.Price == item.Price && marketDepth.Size == item.Size && marketDepth.MarketMaker == item.MarketMaker && marketDepth.Side == item.Side)
				{
					this.fList[num] = item;
					flag = true;
				}
				num++;
			}
			if (!flag)
			{
				this.fList.Add(item);
			}
			return flag;
		}
	}
}
