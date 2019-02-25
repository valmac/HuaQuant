using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using SmartQuant.Testing.Components;
using SmartQuant.Testing.TesterItems;

namespace SmartQuant.Testing.Design
{
	// Token: 0x02000016 RID: 22
	internal partial class EditComponent_Tester : Form
	{
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00003E1E File Offset: 0x00002E1E
		public TesterItemList ComponentList
		{
			get
			{
				return this.componentList;
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00003E28 File Offset: 0x00002E28
		public EditComponent_Tester(LiveTester tester)
		{
			this.InitializeComponent();
			this.componentList = tester.Components;
			this.tester = tester;
			TesterSaver.Tester = tester;
			foreach (object obj in this.componentList)
			{
				TesterItem testerItem = (TesterItem)obj;
				if (testerItem is SeriesTesterItem && !(testerItem as SeriesTesterItem).Enabled)
				{
					ListViewItem listViewItem = new ListViewItem(testerItem.Name);
					listViewItem.ImageIndex = 0;
					this.ltvComponents.Items.Add(listViewItem);
				}
			}
			foreach (object obj2 in this.componentList)
			{
				TesterItem testerItem2 = (TesterItem)obj2;
				if (testerItem2 is SeriesTesterItem && (testerItem2 as SeriesTesterItem).Enabled)
				{
					ListViewItem listViewItem = new ListViewItem(testerItem2.Name);
					listViewItem.ImageIndex = 0;
					this.ltvTesterComponents.Items.Add(listViewItem);
				}
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00004529 File Offset: 0x00003529
		private void btnOk_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00004532 File Offset: 0x00003532
		private void btnMove_Click(object sender, EventArgs e)
		{
			this.MoveItems();
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000453C File Offset: 0x0000353C
		private void MoveItems()
		{
			if (this.ltvComponents.SelectedItems.Count > 0)
			{
				foreach (object obj in this.ltvComponents.SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					(this.tester.Components[listViewItem.Text] as SeriesTesterItem).Enabled = true;
				}
				foreach (object obj2 in this.ltvComponents.Items)
				{
					ListViewItem listViewItem2 = (ListViewItem)obj2;
					if ((this.tester.Components[listViewItem2.Text] as SeriesTesterItem).Enabled)
					{
						bool flag = true;
						foreach (object obj3 in this.ltvTesterComponents.Items)
						{
							ListViewItem listViewItem3 = (ListViewItem)obj3;
							if (listViewItem2.Text == listViewItem3.Text)
							{
								flag = false;
							}
						}
						if (flag)
						{
							ListViewItem listViewItem4 = new ListViewItem(listViewItem2.Text);
							listViewItem4.ImageIndex = 0;
							this.ltvTesterComponents.Items.Add(listViewItem4);
							this.ltvComponents.Items.Remove(listViewItem2);
						}
					}
				}
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000046EC File Offset: 0x000036EC
		private void btnDelete_Click(object sender, EventArgs e)
		{
			foreach (object obj in this.ltvTesterComponents.SelectedItems)
			{
				ListViewItem listViewItem = (ListViewItem)obj;
				TesterItem testerItem = this.tester.Components[listViewItem.Text];
				if (testerItem is SeriesTesterItem && !(testerItem is SimpleSeriesItem))
				{
					this.ltvTesterComponents.Items.Remove(listViewItem);
					(this.tester.Components[listViewItem.Text] as SeriesTesterItem).Enabled = false;
					ListViewItem value = new ListViewItem(listViewItem.Text);
					this.ltvComponents.Items.Add(value);
				}
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000047C4 File Offset: 0x000037C4
		private void ltvSeriesComponents_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.ltvTesterComponents.SelectedItems.Count > 0)
			{
				this.propertyGrid.SelectedObject = this.componentList[this.ltvTesterComponents.SelectedItems[0].Text];
				return;
			}
			this.propertyGrid.SelectedObject = null;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000481D File Offset: 0x0000381D
		private void btnOk_Click_1(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00004828 File Offset: 0x00003828
		private void ltvTesterComponents_DoubleClick(object sender, EventArgs e)
		{
			if (this.ltvTesterComponents.SelectedItems.Count > 0)
			{
				TesterComponentManager.SaveComponent(this.tester.Components[this.ltvTesterComponents.SelectedItems[0].Text], "D:\\1\\");
			}
		}

		// Token: 0x04000020 RID: 32
		private TesterItemList componentList;

		// Token: 0x04000021 RID: 33
		private LiveTester tester;
	}
}
