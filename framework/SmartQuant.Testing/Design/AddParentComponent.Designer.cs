namespace SmartQuant.Testing.Design
{
	// Token: 0x02000049 RID: 73
	internal partial class AddParentComponent : global::System.Windows.Forms.Form
	{
		// Token: 0x06000241 RID: 577 RVA: 0x0000DA54 File Offset: 0x0000CA54
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0000DA74 File Offset: 0x0000CA74
		private void InitializeComponent()
		{
			this.ltvComponents = new global::System.Windows.Forms.ListView();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.btnOk = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.ltvComponents.HideSelection = false;
			this.ltvComponents.Location = new global::System.Drawing.Point(8, 24);
			this.ltvComponents.Name = "ltvComponents";
			this.ltvComponents.Size = new global::System.Drawing.Size(176, 176);
			this.ltvComponents.TabIndex = 21;
			this.ltvComponents.View = global::System.Windows.Forms.View.SmallIcon;
			this.btnCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new global::System.Drawing.Point(8, 224);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(72, 32);
			this.btnCancel.TabIndex = 20;
			this.btnCancel.Text = "Cancel";
			this.label1.Location = new global::System.Drawing.Point(16, 8);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(168, 16);
			this.label1.TabIndex = 22;
			this.label1.Text = "Choose components";
			this.label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.btnOk.Location = new global::System.Drawing.Point(112, 224);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new global::System.Drawing.Size(72, 32);
			this.btnOk.TabIndex = 19;
			this.btnOk.Text = "OK";
			this.btnOk.Click += new global::System.EventHandler(this.btnOk_Click);
			this.AutoScaleBaseSize = new global::System.Drawing.Size(5, 13);
			base.ClientSize = new global::System.Drawing.Size(194, 263);
			base.ControlBox = false;
			base.Controls.Add(this.label1);
			base.Controls.Add(this.ltvComponents);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.btnOk);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.Name = "AddParentComponent";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add Viewer";
			base.ResumeLayout(false);
		}

		// Token: 0x040000E2 RID: 226
		private global::System.Windows.Forms.ListView ltvComponents;

		// Token: 0x040000E3 RID: 227
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x040000E4 RID: 228
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040000E5 RID: 229
		private global::System.Windows.Forms.Button btnOk;

		// Token: 0x040000E6 RID: 230
		private global::System.ComponentModel.IContainer components;
	}
}
