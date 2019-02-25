using System;
using System.Windows.Forms;
using SmartQuant.Data;

namespace SmartQuant.Simulation.Design
{
	// Token: 0x0200000F RID: 15
	internal class DataSeriesViewItem : ListViewItem
	{
		// Token: 0x06000063 RID: 99 RVA: 0x00003BC4 File Offset: 0x00002BC4
		internal DataSeriesViewItem(IDataSeries series) : base(series.Name, 0)
		{
			this.series = series;
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00003BDA File Offset: 0x00002BDA
		internal IDataSeries Series
		{
			get
			{
				return this.series;
			}
		}

		// Token: 0x0400003B RID: 59
		private IDataSeries series;
	}
}
