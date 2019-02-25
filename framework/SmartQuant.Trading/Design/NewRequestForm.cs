using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using SmartQuant.Data;
using SmartQuant.Instruments;

namespace SmartQuant.Trading.Design
{
	// Token: 0x0200003C RID: 60
	internal partial class NewRequestForm : Form
	{
		// Token: 0x060002BA RID: 698 RVA: 0x0000AFC4 File Offset: 0x00009FC4
		public NewRequestForm()
		{
			this.InitializeComponent();
			foreach (object obj in Enum.GetValues(typeof(DataManager.EDataSeries)))
			{
				DataManager.EDataSeries edataSeries = (DataManager.EDataSeries)obj;
				this.cbxDataType.Items.Add(edataSeries);
			}
			this.cbxDataType.SelectedIndex = 0;
			foreach (object obj2 in Enum.GetValues(typeof(BarType)))
			{
				BarType barType = (BarType)obj2;
				this.cbxBarType.Items.Add(barType);
			}
			this.cbxBarType.SelectedIndex = 0;
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060002BD RID: 701 RVA: 0x0000B6CC File Offset: 0x0000A6CC
		public string Request
		{
			get
			{
				string result = null;
				switch ((DataManager.EDataSeries)this.cbxDataType.SelectedItem)
				{
				case DataManager.EDataSeries.Daily:
					result = "Daily";
					break;
				case DataManager.EDataSeries.Trade:
					result = "Trade";
					break;
				case DataManager.EDataSeries.Quote:
					result = "Quote";
					break;
				case DataManager.EDataSeries.Bar:
					result = string.Concat(new object[]
					{
						"Bar",
						'.',
						((BarType)this.cbxBarType.SelectedItem).ToString(),
						'.',
						((long)this.nudBarSize.Value).ToString()
					});
					break;
				case DataManager.EDataSeries.MarketDepth:
					result = "Depth";
					break;
				case DataManager.EDataSeries.Fundamental:
					result = "Fund";
					break;
				case DataManager.EDataSeries.CorporateAction:
					result = "Corp";
					break;
				}
				return result;
			}
		}

		// Token: 0x060002BE RID: 702 RVA: 0x0000B7AC File Offset: 0x0000A7AC
		private void cbxDataType_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.pnlBar.Enabled = ((DataManager.EDataSeries)this.cbxDataType.SelectedItem == DataManager.EDataSeries.Bar);
		}
	}
}
