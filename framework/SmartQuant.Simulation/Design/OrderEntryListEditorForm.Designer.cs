namespace SmartQuant.Simulation.Design
{
	// Token: 0x02000017 RID: 23
	internal partial class OrderEntryListEditorForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000078 RID: 120 RVA: 0x00003CD7 File Offset: 0x00002CD7
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00003CF8 File Offset: 0x00002CF8
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SmartQuant.Simulation.Design.OrderEntryListEditorForm));
			this.imgToolbar = new global::System.Windows.Forms.ImageList(this.components);
			this.panel = new global::System.Windows.Forms.Panel();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.btnOk = new global::System.Windows.Forms.Button();
			this.tabControl1 = new global::System.Windows.Forms.TabControl();
			this.tabPage1 = new global::System.Windows.Forms.TabPage();
			this.ltvEntries = new global::System.Windows.Forms.ListView();
			this.columnHeader1 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader7 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader8 = new global::System.Windows.Forms.ColumnHeader();
			this.ctxEntries = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.ctxEntries_New = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ctxEntries_Edit = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.ctxEntries_Remove = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip = new global::System.Windows.Forms.ToolStrip();
			this.tsbNewEntry = new global::System.Windows.Forms.ToolStripButton();
			this.panel.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.ctxEntries.SuspendLayout();
			this.toolStrip.SuspendLayout();
			base.SuspendLayout();
			this.imgToolbar.ImageStream = (global::System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("imgToolbar.ImageStream");
			this.imgToolbar.TransparentColor = global::System.Drawing.Color.Transparent;
			this.imgToolbar.Images.SetKeyName(0, "document_add.png");
			this.panel.Controls.Add(this.panel1);
			this.panel.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.panel.Location = new global::System.Drawing.Point(0, 253);
			this.panel.Name = "panel";
			this.panel.Size = new global::System.Drawing.Size(730, 46);
			this.panel.TabIndex = 1;
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.btnOk);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new global::System.Drawing.Point(525, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(205, 46);
			this.panel1.TabIndex = 2;
			this.btnCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new global::System.Drawing.Point(126, 12);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(62, 22);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnOk.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.btnOk.Location = new global::System.Drawing.Point(58, 12);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new global::System.Drawing.Size(62, 22);
			this.btnOk.TabIndex = 1;
			this.btnOk.Text = "Ok";
			this.btnOk.UseVisualStyleBackColor = true;
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new global::System.Drawing.Point(0, 25);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new global::System.Drawing.Size(730, 228);
			this.tabControl1.TabIndex = 2;
			this.tabPage1.Controls.Add(this.ltvEntries);
			this.tabPage1.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new global::System.Drawing.Size(722, 202);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Order Entries";
			this.tabPage1.UseVisualStyleBackColor = true;
			this.ltvEntries.CheckBoxes = true;
			this.ltvEntries.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader1,
				this.columnHeader2,
				this.columnHeader3,
				this.columnHeader4,
				this.columnHeader5,
				this.columnHeader6,
				this.columnHeader7,
				this.columnHeader8
			});
			this.ltvEntries.ContextMenuStrip = this.ctxEntries;
			this.ltvEntries.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.ltvEntries.FullRowSelect = true;
			this.ltvEntries.GridLines = true;
			this.ltvEntries.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.ltvEntries.HideSelection = false;
			this.ltvEntries.Location = new global::System.Drawing.Point(3, 3);
			this.ltvEntries.Name = "ltvEntries";
			this.ltvEntries.ShowGroups = false;
			this.ltvEntries.ShowItemToolTips = true;
			this.ltvEntries.Size = new global::System.Drawing.Size(716, 196);
			this.ltvEntries.TabIndex = 0;
			this.ltvEntries.UseCompatibleStateImageBehavior = false;
			this.ltvEntries.View = global::System.Windows.Forms.View.Details;
			this.ltvEntries.ItemChecked += new global::System.Windows.Forms.ItemCheckedEventHandler(this.ltvEntries_ItemChecked);
			this.columnHeader1.Text = "DateTime";
			this.columnHeader1.Width = 137;
			this.columnHeader2.Text = "Instrument";
			this.columnHeader2.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader2.Width = 77;
			this.columnHeader3.Text = "Side";
			this.columnHeader3.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader3.Width = 64;
			this.columnHeader4.Text = "OrdType";
			this.columnHeader4.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader4.Width = 73;
			this.columnHeader5.Text = "Price";
			this.columnHeader5.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader5.Width = 66;
			this.columnHeader6.Text = "StopPx";
			this.columnHeader6.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader6.Width = 70;
			this.columnHeader7.Text = "OrderQty";
			this.columnHeader7.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader7.Width = 69;
			this.columnHeader8.Text = "Text";
			this.columnHeader8.Width = 128;
			this.ctxEntries.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.ctxEntries_New,
				this.ctxEntries_Edit,
				this.toolStripSeparator1,
				this.ctxEntries_Remove
			});
			this.ctxEntries.Name = "ctxEntries";
			this.ctxEntries.Size = new global::System.Drawing.Size(125, 76);
			this.ctxEntries.Opening += new global::System.ComponentModel.CancelEventHandler(this.ctxEntries_Opening);
			this.ctxEntries_New.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ctxEntries_New.Image");
			this.ctxEntries_New.Name = "ctxEntries_New";
			this.ctxEntries_New.Size = new global::System.Drawing.Size(124, 22);
			this.ctxEntries_New.Text = "New...";
			this.ctxEntries_New.Click += new global::System.EventHandler(this.ctxEntries_New_Click);
			this.ctxEntries_Edit.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ctxEntries_Edit.Image");
			this.ctxEntries_Edit.Name = "ctxEntries_Edit";
			this.ctxEntries_Edit.Size = new global::System.Drawing.Size(124, 22);
			this.ctxEntries_Edit.Text = "Edit...";
			this.ctxEntries_Edit.Click += new global::System.EventHandler(this.ctxEntries_Edit_Click);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new global::System.Drawing.Size(121, 6);
			this.ctxEntries_Remove.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ctxEntries_Remove.Image");
			this.ctxEntries_Remove.Name = "ctxEntries_Remove";
			this.ctxEntries_Remove.Size = new global::System.Drawing.Size(124, 22);
			this.ctxEntries_Remove.Text = "Remove";
			this.ctxEntries_Remove.Click += new global::System.EventHandler(this.ctxEntries_Remove_Click);
			this.toolStrip.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.tsbNewEntry
			});
			this.toolStrip.Location = new global::System.Drawing.Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new global::System.Drawing.Size(730, 25);
			this.toolStrip.TabIndex = 3;
			this.toolStrip.Text = "toolStrip1";
			this.tsbNewEntry.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbNewEntry.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("tsbNewEntry.Image");
			this.tsbNewEntry.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.tsbNewEntry.Name = "tsbNewEntry";
			this.tsbNewEntry.Size = new global::System.Drawing.Size(23, 22);
			this.tsbNewEntry.Text = "toolStripButton1";
			this.tsbNewEntry.ToolTipText = "New Entry";
			this.tsbNewEntry.Click += new global::System.EventHandler(this.tsbNewEntry_Click);
			base.AcceptButton = this.btnOk;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.btnCancel;
			base.ClientSize = new global::System.Drawing.Size(730, 299);
			base.Controls.Add(this.tabControl1);
			base.Controls.Add(this.toolStrip);
			base.Controls.Add(this.panel);
			base.MinimizeBox = false;
			base.Name = "OrderEntryListEditorForm";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Simulation Execution Service - Order Entries";
			this.panel.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.ctxEntries.ResumeLayout(false);
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000047 RID: 71
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000048 RID: 72
		private global::System.Windows.Forms.Panel panel;

		// Token: 0x04000049 RID: 73
		private global::System.Windows.Forms.TabControl tabControl1;

		// Token: 0x0400004A RID: 74
		private global::System.Windows.Forms.TabPage tabPage1;

		// Token: 0x0400004B RID: 75
		private global::System.Windows.Forms.ListView ltvEntries;

		// Token: 0x0400004C RID: 76
		private global::System.Windows.Forms.ImageList imgToolbar;

		// Token: 0x0400004D RID: 77
		private global::System.Windows.Forms.ColumnHeader columnHeader1;

		// Token: 0x0400004E RID: 78
		private global::System.Windows.Forms.ColumnHeader columnHeader2;

		// Token: 0x0400004F RID: 79
		private global::System.Windows.Forms.ColumnHeader columnHeader3;

		// Token: 0x04000050 RID: 80
		private global::System.Windows.Forms.ColumnHeader columnHeader4;

		// Token: 0x04000051 RID: 81
		private global::System.Windows.Forms.ColumnHeader columnHeader5;

		// Token: 0x04000052 RID: 82
		private global::System.Windows.Forms.ColumnHeader columnHeader6;

		// Token: 0x04000053 RID: 83
		private global::System.Windows.Forms.ColumnHeader columnHeader7;

		// Token: 0x04000054 RID: 84
		private global::System.Windows.Forms.ColumnHeader columnHeader8;

		// Token: 0x04000055 RID: 85
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000056 RID: 86
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000057 RID: 87
		private global::System.Windows.Forms.Button btnOk;

		// Token: 0x04000058 RID: 88
		private global::System.Windows.Forms.ToolStrip toolStrip;

		// Token: 0x04000059 RID: 89
		private global::System.Windows.Forms.ToolStripButton tsbNewEntry;

		// Token: 0x0400005A RID: 90
		private global::System.Windows.Forms.ContextMenuStrip ctxEntries;

		// Token: 0x0400005B RID: 91
		private global::System.Windows.Forms.ToolStripMenuItem ctxEntries_New;

		// Token: 0x0400005C RID: 92
		private global::System.Windows.Forms.ToolStripMenuItem ctxEntries_Edit;

		// Token: 0x0400005D RID: 93
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		// Token: 0x0400005E RID: 94
		private global::System.Windows.Forms.ToolStripMenuItem ctxEntries_Remove;
	}
}
