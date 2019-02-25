namespace SmartQuant.Testing.Design
{
	// Token: 0x02000024 RID: 36
	internal partial class AddComponent_Tester : global::System.Windows.Forms.Form
	{
		// Token: 0x060000EA RID: 234 RVA: 0x00005C34 File Offset: 0x00004C34
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00005C54 File Offset: 0x00004C54
		private void InitializeComponent()
		{
			this.btnDelete = new global::System.Windows.Forms.Button();
			this.btnMove = new global::System.Windows.Forms.Button();
			this.label2 = new global::System.Windows.Forms.Label();
			this.ltvTesterComponents = new global::System.Windows.Forms.ListView();
			this.label1 = new global::System.Windows.Forms.Label();
			this.ltvComponents = new global::System.Windows.Forms.ListView();
			this.btnOk = new global::System.Windows.Forms.Button();
			this.propertyGrid = new global::System.Windows.Forms.PropertyGrid();
			this.btnCancel = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.btnDelete.Location = new global::System.Drawing.Point(192, 120);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new global::System.Drawing.Size(56, 24);
			this.btnDelete.TabIndex = 35;
			this.btnDelete.Text = "Delete";
			this.btnDelete.Click += new global::System.EventHandler(this.btnDelete_Click);
			this.btnMove.Location = new global::System.Drawing.Point(192, 80);
			this.btnMove.Name = "btnMove";
			this.btnMove.Size = new global::System.Drawing.Size(56, 24);
			this.btnMove.TabIndex = 33;
			this.btnMove.Text = "Move ->";
			this.btnMove.Click += new global::System.EventHandler(this.btnMove_Click);
			this.label2.Location = new global::System.Drawing.Point(264, 8);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(168, 16);
			this.label2.TabIndex = 24;
			this.label2.Text = "Series View Components";
			this.label2.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.ltvTesterComponents.HideSelection = false;
			this.ltvTesterComponents.Location = new global::System.Drawing.Point(256, 24);
			this.ltvTesterComponents.MultiSelect = false;
			this.ltvTesterComponents.Name = "ltvTesterComponents";
			this.ltvTesterComponents.Size = new global::System.Drawing.Size(176, 176);
			this.ltvTesterComponents.TabIndex = 23;
			this.ltvTesterComponents.View = global::System.Windows.Forms.View.SmallIcon;
			this.ltvTesterComponents.DoubleClick += new global::System.EventHandler(this.ltvTesterComponents_DoubleClick);
			this.ltvTesterComponents.SelectedIndexChanged += new global::System.EventHandler(this.ltvSeriesComponents_SelectedIndexChanged);
			this.label1.Location = new global::System.Drawing.Point(16, 8);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(168, 16);
			this.label1.TabIndex = 22;
			this.label1.Text = "Choose components";
			this.label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.ltvComponents.HideSelection = false;
			this.ltvComponents.Location = new global::System.Drawing.Point(8, 24);
			this.ltvComponents.Name = "ltvComponents";
			this.ltvComponents.Size = new global::System.Drawing.Size(176, 176);
			this.ltvComponents.TabIndex = 21;
			this.ltvComponents.View = global::System.Windows.Forms.View.SmallIcon;
			this.btnOk.Location = new global::System.Drawing.Point(360, 464);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new global::System.Drawing.Size(72, 32);
			this.btnOk.TabIndex = 19;
			this.btnOk.Text = "OK";
			this.btnOk.Click += new global::System.EventHandler(this.btnOk_Click_1);
			this.propertyGrid.CommandsVisibleIfAvailable = true;
			this.propertyGrid.LargeButtons = false;
			this.propertyGrid.LineColor = global::System.Drawing.SystemColors.ScrollBar;
			this.propertyGrid.Location = new global::System.Drawing.Point(24, 208);
			this.propertyGrid.Name = "propertyGrid";
			this.propertyGrid.Size = new global::System.Drawing.Size(392, 248);
			this.propertyGrid.TabIndex = 36;
			this.propertyGrid.Text = "propertyGrid1";
			this.propertyGrid.ViewBackColor = global::System.Drawing.SystemColors.Window;
			this.propertyGrid.ViewForeColor = global::System.Drawing.SystemColors.WindowText;
			this.btnCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new global::System.Drawing.Point(8, 464);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(72, 32);
			this.btnCancel.TabIndex = 20;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.Visible = false;
			this.AutoScaleBaseSize = new global::System.Drawing.Size(5, 13);
			base.ClientSize = new global::System.Drawing.Size(442, 503);
			base.ControlBox = false;
			base.Controls.Add(this.propertyGrid);
			base.Controls.Add(this.btnDelete);
			base.Controls.Add(this.btnMove);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.ltvTesterComponents);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.ltvComponents);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.btnOk);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.Name = "AddComponent_Tester";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add Viewer";
			base.ResumeLayout(false);
		}

		// Token: 0x0400003C RID: 60
		private global::System.Windows.Forms.Button btnDelete;

		// Token: 0x0400003D RID: 61
		private global::System.Windows.Forms.Button btnMove;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400003F RID: 63
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000040 RID: 64
		private global::System.Windows.Forms.ListView ltvComponents;

		// Token: 0x04000041 RID: 65
		private global::System.Windows.Forms.Button btnOk;

		// Token: 0x04000042 RID: 66
		private global::System.Windows.Forms.ListView ltvTesterComponents;

		// Token: 0x04000043 RID: 67
		private global::System.Windows.Forms.PropertyGrid propertyGrid;

		// Token: 0x04000044 RID: 68
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000045 RID: 69
		private global::System.ComponentModel.IContainer components;
	}
}
