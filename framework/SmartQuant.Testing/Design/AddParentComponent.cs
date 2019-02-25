using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using SmartQuant.Testing.TesterItems;

namespace SmartQuant.Testing.Design
{
	// Token: 0x02000049 RID: 73
	internal partial class AddParentComponent : Form
	{
		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600023F RID: 575 RVA: 0x0000D99F File Offset: 0x0000C99F
		public TesterItem Component
		{
			get
			{
				return this.component;
			}
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0000D9A8 File Offset: 0x0000C9A8
		public AddParentComponent(TesterItem component, LiveTester tester)
		{
			this.InitializeComponent();
			this.component = component;
			this.tester = tester;
			foreach (object obj in tester.Components)
			{
				TesterItem testerItem = (TesterItem)obj;
				if (component == null || component.Name != testerItem.Name)
				{
					ListViewItem listViewItem = new ListViewItem(testerItem.Name);
					listViewItem.ImageIndex = 0;
					this.ltvComponents.Items.Add(listViewItem);
				}
			}
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0000DCE4 File Offset: 0x0000CCE4
		private void btnOk_Click(object sender, EventArgs e)
		{
			if (this.ltvComponents.SelectedItems.Count > 0)
			{
				this.component = this.tester.Components[this.ltvComponents.SelectedItems[0].Text];
			}
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x040000E0 RID: 224
		private TesterItem component;

		// Token: 0x040000E1 RID: 225
		private LiveTester tester;
	}
}
