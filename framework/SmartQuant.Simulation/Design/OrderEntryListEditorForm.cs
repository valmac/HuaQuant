using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SmartQuant.Simulation.Design
{
	// Token: 0x02000017 RID: 23
	internal partial class OrderEntryListEditorForm : Form
	{
		// Token: 0x0600007A RID: 122 RVA: 0x000047D9 File Offset: 0x000037D9
		public OrderEntryListEditorForm()
		{
			this.InitializeComponent();
			this.entryItems = new Dictionary<OrderEntry, OrderEntryViewItem>();
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600007B RID: 123 RVA: 0x000047F4 File Offset: 0x000037F4
		// (set) Token: 0x0600007C RID: 124 RVA: 0x00004854 File Offset: 0x00003854
		public OrderEntryList Entries
		{
			get
			{
				OrderEntryList orderEntryList = new OrderEntryList();
				foreach (OrderEntry entry in this.entryItems.Keys)
				{
					orderEntryList.Add(entry);
				}
				return orderEntryList;
			}
			set
			{
				this.ltvEntries.BeginUpdate();
				this.ltvEntries.Items.Clear();
				foreach (object obj in value)
				{
					OrderEntry entry = (OrderEntry)obj;
					this.AddEntry(entry);
				}
				this.ltvEntries.ListViewItemSorter = new OrderEntryListComparer();
				this.ltvEntries.Sort();
				this.ltvEntries.EndUpdate();
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000048EC File Offset: 0x000038EC
		private void AddEntry(OrderEntry entry)
		{
			OrderEntryViewItem value = new OrderEntryViewItem(entry);
			this.ltvEntries.Items.Add(value);
			this.entryItems.Add(entry, value);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00004920 File Offset: 0x00003920
		private void RemoveEntry(OrderEntry entry)
		{
			OrderEntryViewItem orderEntryViewItem = this.entryItems[entry];
			this.entryItems.Remove(entry);
			orderEntryViewItem.Remove();
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00004950 File Offset: 0x00003950
		private void NewEntry()
		{
			OrderEntryDetailsForm orderEntryDetailsForm = new OrderEntryDetailsForm();
			orderEntryDetailsForm.Entry = null;
			if (orderEntryDetailsForm.ShowDialog(this) == DialogResult.OK)
			{
				this.AddEntry(orderEntryDetailsForm.Entry);
			}
			orderEntryDetailsForm.Dispose();
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00004988 File Offset: 0x00003988
		private void EditEntry(OrderEntry entry)
		{
			OrderEntryDetailsForm orderEntryDetailsForm = new OrderEntryDetailsForm();
			orderEntryDetailsForm.Entry = entry;
			if (orderEntryDetailsForm.ShowDialog(this) == DialogResult.OK)
			{
				this.entryItems[entry].UpdateValues();
				this.ltvEntries.Sort();
			}
			orderEntryDetailsForm.Dispose();
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000049CE File Offset: 0x000039CE
		private void tsbNewEntry_Click(object sender, EventArgs e)
		{
			this.NewEntry();
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000049D8 File Offset: 0x000039D8
		private void ctxEntries_Opening(object sender, CancelEventArgs e)
		{
			int count = this.ltvEntries.SelectedItems.Count;
			if (count == 0)
			{
				this.ctxEntries_New.Enabled = true;
				this.ctxEntries_Edit.Enabled = false;
				this.ctxEntries_Remove.Enabled = false;
				return;
			}
			if (count == 1)
			{
				this.ctxEntries_New.Enabled = true;
				this.ctxEntries_Edit.Enabled = true;
				this.ctxEntries_Remove.Enabled = true;
				return;
			}
			this.ctxEntries_New.Enabled = true;
			this.ctxEntries_Edit.Enabled = false;
			this.ctxEntries_Remove.Enabled = true;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00004A6B File Offset: 0x00003A6B
		private void ctxEntries_New_Click(object sender, EventArgs e)
		{
			this.NewEntry();
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00004A74 File Offset: 0x00003A74
		private void ctxEntries_Edit_Click(object sender, EventArgs e)
		{
			OrderEntry entry = (this.ltvEntries.SelectedItems[0] as OrderEntryViewItem).Entry;
			this.EditEntry(entry);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00004AA4 File Offset: 0x00003AA4
		private void ctxEntries_Remove_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show(this, "Are you sure to remove selected entries?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				List<OrderEntry> list = new List<OrderEntry>();
				foreach (object obj in this.ltvEntries.SelectedItems)
				{
					OrderEntryViewItem orderEntryViewItem = (OrderEntryViewItem)obj;
					list.Add(orderEntryViewItem.Entry);
				}
				foreach (OrderEntry entry in list)
				{
					this.RemoveEntry(entry);
				}
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00004B68 File Offset: 0x00003B68
		private void ltvEntries_ItemChecked(object sender, ItemCheckedEventArgs e)
		{
			OrderEntryViewItem orderEntryViewItem = (OrderEntryViewItem)e.Item;
			orderEntryViewItem.Entry.Enabled = orderEntryViewItem.Checked;
			orderEntryViewItem.UpdateValues();
		}

		// Token: 0x0400005F RID: 95
		private Dictionary<OrderEntry, OrderEntryViewItem> entryItems;
	}
}
