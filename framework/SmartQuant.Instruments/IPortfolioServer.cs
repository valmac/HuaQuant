using System;

namespace SmartQuant.Instruments
{
	// Token: 0x02000036 RID: 54
	public interface IPortfolioServer
	{
		// Token: 0x060002E0 RID: 736
		void Open();

		// Token: 0x060002E1 RID: 737
		void Open(string database);

		// Token: 0x060002E2 RID: 738
		void Close();

		// Token: 0x060002E3 RID: 739
		PortfolioList Load();

		// Token: 0x060002E4 RID: 740
		void Save(Portfolio portfolio);

		// Token: 0x060002E5 RID: 741
		void Remove(Portfolio portfolio);

		// Token: 0x060002E6 RID: 742
		void Update(Portfolio portfolio);

		// Token: 0x060002E7 RID: 743
		void Clear(Portfolio portfolio);

		// Token: 0x060002E8 RID: 744
		void Add(Portfolio portfolio, Transaction transaction);

		// Token: 0x060002E9 RID: 745
		void Add(Portfolio portfolio, AccountTransaction transaction);
	}
}
