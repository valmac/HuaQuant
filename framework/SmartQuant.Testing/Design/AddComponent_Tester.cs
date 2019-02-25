using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using SmartQuant.Testing.Components;
using SmartQuant.Testing.TesterItems;

namespace SmartQuant.Testing.Design
{
	// Token: 0x02000024 RID: 36
	internal partial class AddComponent_Tester : Form
	{
		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00005B0F File Offset: 0x00004B0F
		public TesterItemList ComponentList
		{
			get
			{
				return this.componentList;
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00005B18 File Offset: 0x00004B18
		public AddComponent_Tester(LiveTester tester)
		{
			this.InitializeComponent();
			this.componentList = tester.Components;
			this.tester = tester;
			TesterSaver.Tester = tester;
			TesterComponentRecordList testerComponentRecordList = TesterComponentManager.GetComponents(false);
			foreach (object obj in testerComponentRecordList)
			{
				TesterComponentRecord testerComponentRecord = (TesterComponentRecord)obj;
				ListViewItem listViewItem = new ListViewItem(testerComponentRecord.Name);
				listViewItem.ImageIndex = 0;
				this.ltvComponents.Items.Add(listViewItem);
			}
			foreach (object obj2 in this.componentList)
			{
				TesterItem testerItem = (TesterItem)obj2;
				if (testerItem is SeriesTesterItem)
				{
					ListViewItem listViewItem = new ListViewItem(testerItem.Name);
					listViewItem.ImageIndex = 0;
					this.ltvTesterComponents.Items.Add(listViewItem);
				}
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000061EA File Offset: 0x000051EA
		private void btnOk_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000061F3 File Offset: 0x000051F3
		private void btnMove_Click(object sender, EventArgs e)
		{
			this.MoveItems();
		}

		// Token: 0x060000EE RID: 238 RVA: 0x000061FC File Offset: 0x000051FC
		private void MoveItems()
		{
			if (this.ltvComponents.SelectedItems.Count > 0)
			{
				foreach (object obj in this.ltvComponents.SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					bool flag = true;
					foreach (object obj2 in this.ltvTesterComponents.Items)
					{
						ListViewItem listViewItem2 = (ListViewItem)obj2;
						if (listViewItem.Text == listViewItem2.Text)
						{
							flag = false;
						}
					}
					if (flag)
					{
						ListViewItem listViewItem3 = new ListViewItem(listViewItem.Text);
						listViewItem3.ImageIndex = 0;
						this.ltvTesterComponents.Items.Add(listViewItem3);
						this.tester.AddComponent(TesterComponentManager.GetComponent(listViewItem.Text));
					}
				}
			}
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00006318 File Offset: 0x00005318
		private void btnDelete_Click(object sender, EventArgs e)
		{
			int num = this.ltvTesterComponents.SelectedIndices[0];
			if (this.ltvTesterComponents.SelectedItems.Count > 0)
			{
				this.ltvTesterComponents.Items.RemoveAt(num);
			}
			if (this.ltvTesterComponents.Items.Count > 0)
			{
				this.ltvTesterComponents.Items[Math.Min(num, this.ltvTesterComponents.Items.Count - 1)].Selected = true;
			}
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0000639C File Offset: 0x0000539C
		private void ltvSeriesComponents_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.ltvTesterComponents.SelectedItems.Count > 0)
			{
				this.propertyGrid.SelectedObject = this.componentList[this.ltvTesterComponents.SelectedItems[0].Text];
				return;
			}
			this.propertyGrid.SelectedObject = null;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x000063F5 File Offset: 0x000053F5
		private void btnOk_Click_1(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00006400 File Offset: 0x00005400
		private void ltvTesterComponents_DoubleClick(object sender, EventArgs e)
		{
			if (this.ltvTesterComponents.SelectedItems.Count > 0)
			{
				TesterComponentManager.SaveComponent(this.tester.Components[this.ltvTesterComponents.SelectedItems[0].Text], "D:\\1\\");
			}
		}

		// Token: 0x0400003A RID: 58
		private TesterItemList componentList;

		// Token: 0x0400003B RID: 59
		private LiveTester tester;
	}
}
