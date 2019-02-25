using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using SmartQuant.Data;
using SmartQuant.Instruments;

namespace SmartQuant.Simulation.Design
{
	// Token: 0x02000032 RID: 50
	internal partial class DataSeriesForm : Form
	{
		// Token: 0x060001AB RID: 427 RVA: 0x000090A0 File Offset: 0x000080A0
		public DataSeriesForm()
		{
			this.InitializeComponent();
			foreach (object obj in DataManager.Server.GetDataSeries())
			{
				IDataSeries dataSeries = (IDataSeries)obj;
				this.ltvSeries.Items.Add(new DataSeriesViewItem(dataSeries));
			}
		}

		// Token: 0x060001AE RID: 430 RVA: 0x000094B0 File Offset: 0x000084B0
		private void ltvSeries_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.ltvSeries.SelectedItems.Count > 0)
			{
				ArrayList arrayList = new ArrayList();
				foreach (object obj in this.ltvSeries.SelectedItems)
				{
					DataSeriesViewItem dataSeriesViewItem = (DataSeriesViewItem)obj;
					arrayList.Add(dataSeriesViewItem.Series);
				}
				this.series = (arrayList.ToArray(typeof(IDataSeries)) as IDataSeries[]);
				this.btnOk.Enabled = true;
				return;
			}
			this.series = null;
			this.btnOk.Enabled = false;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00009568 File Offset: 0x00008568
		private void ltvSeries_DoubleClick(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x00009577 File Offset: 0x00008577
		internal IDataSeries[] Series
		{
			get
			{
				return this.series;
			}
		}

		// Token: 0x040000DD RID: 221
		private IDataSeries[] series;
	}
}
