using System;
using System.Drawing;
using System.Windows.Forms;
using SmartQuant.FIX;

namespace SmartQuant.Simulation.Design
{
	// Token: 0x02000030 RID: 48
	internal class OrderEntryViewItem : ListViewItem
	{
		// Token: 0x060001A3 RID: 419 RVA: 0x00008DA4 File Offset: 0x00007DA4
		public OrderEntryViewItem(OrderEntry entry) : base(new string[8])
		{
			this.entry = entry;
			this.defaultColor = base.ForeColor;
			this.UpdateValues();
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x00008DCB File Offset: 0x00007DCB
		public OrderEntry Entry
		{
			get
			{
				return this.entry;
			}
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00008DD4 File Offset: 0x00007DD4
		public void UpdateValues()
		{
			base.SubItems[0].Text = this.entry.DateTime.ToString();
			base.SubItems[1].Text = ((this.entry.Instrument == null) ? "(none)" : this.entry.Instrument.Symbol);
			base.SubItems[2].Text = this.entry.Side.ToString();
			base.SubItems[3].Text = this.entry.OrdType.ToString();
			switch (this.entry.OrdType)
			{
			case OrdType.Market:
				base.SubItems[4].Text = "";
				base.SubItems[5].Text = "";
				break;
			case OrdType.Limit:
				base.SubItems[4].Text = this.entry.Price.ToString(this.entry.Instrument.PriceDisplay);
				base.SubItems[5].Text = "";
				break;
			case OrdType.Stop:
				base.SubItems[4].Text = "";
				base.SubItems[5].Text = this.entry.StopPx.ToString(this.entry.Instrument.PriceDisplay);
				break;
			case OrdType.StopLimit:
				base.SubItems[4].Text = this.entry.Price.ToString(this.entry.Instrument.PriceDisplay);
				base.SubItems[5].Text = this.entry.StopPx.ToString(this.entry.Instrument.PriceDisplay);
				break;
			}
			base.SubItems[6].Text = this.entry.OrderQty.ToString();
			base.SubItems[7].Text = this.entry.Text;
			if (this.entry.Enabled)
			{
				base.Checked = true;
				base.ForeColor = this.defaultColor;
				return;
			}
			base.Checked = false;
			base.ForeColor = SystemColors.GrayText;
		}

		// Token: 0x040000DA RID: 218
		private OrderEntry entry;

		// Token: 0x040000DB RID: 219
		private Color defaultColor;
	}
}
