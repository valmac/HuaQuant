using System;
using System.Collections.Generic;
using SmartQuant.Instruments;

namespace SmartQuant.Trading.Design
{
	// Token: 0x02000044 RID: 68
	internal class PortfolioTypeEditor : ComboBoxTypeEditor
	{
		// Token: 0x060002D1 RID: 721 RVA: 0x0000B8F3 File Offset: 0x0000A8F3
		public PortfolioTypeEditor() : base(true)
		{
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0000B8FC File Offset: 0x0000A8FC
		protected override List<KeyValuePair<string, object>> GetItems()
		{
			List<KeyValuePair<string, object>> list = new List<KeyValuePair<string, object>>();
			foreach (object obj in PortfolioManager.Portfolios)
			{
				Portfolio portfolio = (Portfolio)obj;
				list.Add(new KeyValuePair<string, object>(portfolio.Name, portfolio));
			}
			return list;
		}
	}
}
