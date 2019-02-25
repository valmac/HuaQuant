using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using SmartQuant.FIX;
using SmartQuant.Instruments;

namespace SmartQuant.Simulation.Design
{
	// Token: 0x0200000E RID: 14
	internal partial class OrderEntryDetailsForm : Form
	{
		// Token: 0x06000059 RID: 89 RVA: 0x00002A0C File Offset: 0x00001A0C
		public OrderEntryDetailsForm()
		{
			this.InitializeComponent();
			this.dtpDateTime.CustomFormat = string.Format("{0} {1}", DateTimeFormatInfo.CurrentInfo.ShortDatePattern, DateTimeFormatInfo.CurrentInfo.LongTimePattern);
			this.cbxInstruments.BeginUpdate();
			this.cbxInstruments.Items.Clear();
			foreach (object obj in InstrumentManager.Instruments)
			{
				Instrument instrument = (Instrument)obj;
				this.cbxInstruments.Items.Add(new InstrumentItem(instrument));
			}
			this.cbxInstruments.EndUpdate();
			this.cbxSides.BeginUpdate();
			this.cbxSides.Items.Clear();
			this.cbxSides.Items.Add(Side.Buy);
			this.cbxSides.Items.Add(Side.Sell);
			this.cbxSides.Items.Add(Side.SellShort);
			this.cbxSides.EndUpdate();
			this.cbxOrdTypes.BeginUpdate();
			this.cbxOrdTypes.Items.Clear();
			this.cbxOrdTypes.Items.Add(OrdType.Market);
			this.cbxOrdTypes.Items.Add(OrdType.Limit);
			this.cbxOrdTypes.Items.Add(OrdType.Stop);
			this.cbxOrdTypes.Items.Add(OrdType.StopLimit);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002BB4 File Offset: 0x00001BB4
		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			if (base.DialogResult == DialogResult.OK)
			{
				this.entry.DateTime = this.dtpDateTime.Value;
				this.entry.Instrument = ((this.cbxInstruments.SelectedItem == null) ? null : (this.cbxInstruments.SelectedItem as InstrumentItem).Instrument);
				this.entry.Side = (Side)this.cbxSides.SelectedItem;
				this.entry.OrdType = (OrdType)this.cbxOrdTypes.SelectedItem;
				switch (this.entry.OrdType)
				{
				case OrdType.Market:
					this.entry.Price = 0.0;
					this.entry.StopPx = 0.0;
					break;
				case OrdType.Limit:
					this.entry.Price = (double)this.nudPrice.Value;
					this.entry.StopPx = 0.0;
					break;
				case OrdType.Stop:
					this.entry.Price = 0.0;
					this.entry.StopPx = (double)this.nudStopPx.Value;
					break;
				case OrdType.StopLimit:
					this.entry.Price = (double)this.nudPrice.Value;
					this.entry.StopPx = (double)this.nudStopPx.Value;
					break;
				}
				this.entry.OrderQty = (double)this.nudOrderQty.Value;
				this.entry.Text = this.tbxText.Text.Trim();
			}
			base.OnFormClosing(e);
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00002D79 File Offset: 0x00001D79
		// (set) Token: 0x0600005C RID: 92 RVA: 0x00002D84 File Offset: 0x00001D84
		public OrderEntry Entry
		{
			get
			{
				return this.entry;
			}
			set
			{
				this.entry = value;
				if (this.entry == null)
				{
					this.entry = new OrderEntry();
					this.entry.Enabled = true;
					this.Text = "New Entry";
					this.dtpDateTime.Value = DateTime.Now;
					if (this.cbxInstruments.Items.Count > 0)
					{
						this.cbxInstruments.SelectedIndex = 0;
					}
					this.cbxSides.SelectedIndex = 0;
					this.cbxOrdTypes.SelectedIndex = 0;
					return;
				}
				this.Text = "Edit Entry";
				this.dtpDateTime.Value = this.entry.DateTime;
				this.cbxInstruments.SelectedItem = this.entry.Instrument;
				this.cbxSides.SelectedItem = this.entry.Side;
				this.cbxOrdTypes.SelectedItem = this.entry.OrdType;
				this.nudPrice.Value = (decimal)this.entry.Price;
				this.nudStopPx.Value = (decimal)this.entry.StopPx;
				this.nudOrderQty.Value = (decimal)this.entry.OrderQty;
				this.tbxText.Text = this.entry.Text;
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002EE4 File Offset: 0x00001EE4
		private void UpdateDecimalPlaces()
		{
			int decimalPlaces;
			if (this.cbxInstruments.SelectedItem == null)
			{
				decimalPlaces = 2;
			}
			else
			{
				string priceDisplay = (this.cbxInstruments.SelectedItem as InstrumentItem).Instrument.PriceDisplay;
				if (priceDisplay != null && priceDisplay.Length > 1)
				{
					if (!int.TryParse(priceDisplay.Substring(1), out decimalPlaces))
					{
						decimalPlaces = 2;
					}
				}
				else
				{
					decimalPlaces = 2;
				}
			}
			this.nudPrice.DecimalPlaces = decimalPlaces;
			this.nudStopPx.DecimalPlaces = decimalPlaces;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002F58 File Offset: 0x00001F58
		private void OrderTypeChanged()
		{
			switch ((OrdType)this.cbxOrdTypes.SelectedItem)
			{
			case OrdType.Market:
				this.nudPrice.Enabled = false;
				this.nudStopPx.Enabled = false;
				return;
			case OrdType.Limit:
				this.nudPrice.Enabled = true;
				this.nudStopPx.Enabled = false;
				return;
			case OrdType.Stop:
				this.nudPrice.Enabled = false;
				this.nudStopPx.Enabled = true;
				return;
			case OrdType.StopLimit:
				this.nudPrice.Enabled = true;
				this.nudStopPx.Enabled = true;
				return;
			default:
				return;
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002FF4 File Offset: 0x00001FF4
		private void cbxInstruments_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.UpdateDecimalPlaces();
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002FFC File Offset: 0x00001FFC
		private void cbxOrdTypes_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.OrderTypeChanged();
		}

		// Token: 0x04000025 RID: 37
		private OrderEntry entry;
	}
}
