using System;
using SmartQuant.Testing.TesterItems;

namespace SmartQuant.Testing
{
	// Token: 0x0200004F RID: 79
	public class TesterSettings
	{
		// Token: 0x0600025B RID: 603 RVA: 0x0000E2D8 File Offset: 0x0000D2D8
		public TesterSettings(LiveTester tester)
		{
			this.tester = tester;
			this.SaveSettings();
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0000E2F0 File Offset: 0x0000D2F0
		private void SaveSettings()
		{
			this.componentEnabledList = new TesterItemList();
			this.componentFillSeriesList = new TesterItemList();
			foreach (object obj in this.tester.Components)
			{
				TesterItem testerItem = (TesterItem)obj;
				SeriesTesterItem seriesTesterItem = testerItem as SeriesTesterItem;
				if (seriesTesterItem != null)
				{
					if (seriesTesterItem.Enabled)
					{
						this.componentEnabledList.Add(seriesTesterItem);
					}
					if (seriesTesterItem.FillSeries)
					{
						this.componentFillSeriesList.Add(seriesTesterItem);
					}
				}
			}
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0000E390 File Offset: 0x0000D390
		public void LoadState()
		{
			foreach (object obj in this.tester.Components)
			{
				TesterItem testerItem = (TesterItem)obj;
				SeriesTesterItem seriesTesterItem = testerItem as SeriesTesterItem;
				if (seriesTesterItem != null)
				{
					if (this.componentEnabledList.Contains(seriesTesterItem.Name))
					{
						seriesTesterItem.Enabled = true;
					}
					if (this.componentFillSeriesList.Contains(seriesTesterItem.Name))
					{
						seriesTesterItem.FillSeries = true;
					}
				}
			}
		}

		// Token: 0x040000E9 RID: 233
		private LiveTester tester;

		// Token: 0x040000EA RID: 234
		private TesterItemList componentEnabledList;

		// Token: 0x040000EB RID: 235
		private TesterItemList componentFillSeriesList;
	}
}
