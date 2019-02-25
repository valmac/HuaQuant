namespace SmartQuant.Simulation.Design
{
	// Token: 0x02000032 RID: 50
	internal partial class DataSeriesForm : global::System.Windows.Forms.Form
	{
		// Token: 0x060001AC RID: 428 RVA: 0x0000911C File Offset: 0x0000811C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0000913C File Offset: 0x0000813C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SmartQuant.Simulation.Design.DataSeriesForm));
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.btnOk = new global::System.Windows.Forms.Button();
			this.ltvSeries = new global::System.Windows.Forms.ListView();
			this.images = new global::System.Windows.Forms.ImageList(this.components);
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.btnOk);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new global::System.Drawing.Point(0, 285);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(432, 40);
			this.panel1.TabIndex = 0;
			this.btnCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new global::System.Drawing.Point(336, 8);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(72, 24);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnOk.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.btnOk.Enabled = false;
			this.btnOk.Location = new global::System.Drawing.Point(248, 8);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new global::System.Drawing.Size(72, 24);
			this.btnOk.TabIndex = 0;
			this.btnOk.Text = "Ok";
			this.ltvSeries.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.ltvSeries.HideSelection = false;
			this.ltvSeries.Location = new global::System.Drawing.Point(0, 0);
			this.ltvSeries.Name = "ltvSeries";
			this.ltvSeries.Size = new global::System.Drawing.Size(432, 285);
			this.ltvSeries.SmallImageList = this.images;
			this.ltvSeries.Sorting = global::System.Windows.Forms.SortOrder.Ascending;
			this.ltvSeries.TabIndex = 1;
			this.ltvSeries.UseCompatibleStateImageBehavior = false;
			this.ltvSeries.View = global::System.Windows.Forms.View.List;
			this.ltvSeries.DoubleClick += new global::System.EventHandler(this.ltvSeries_DoubleClick);
			this.ltvSeries.SelectedIndexChanged += new global::System.EventHandler(this.ltvSeries_SelectedIndexChanged);
			this.images.ImageStream = (global::System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("images.ImageStream");
			this.images.TransparentColor = global::System.Drawing.Color.Transparent;
			this.images.Images.SetKeyName(0, "");
			base.AcceptButton = this.btnOk;
			this.AutoScaleBaseSize = new global::System.Drawing.Size(5, 13);
			base.CancelButton = this.btnCancel;
			base.ClientSize = new global::System.Drawing.Size(432, 325);
			base.Controls.Add(this.ltvSeries);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "DataSeriesForm";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Data Series";
			this.panel1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040000DE RID: 222
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040000DF RID: 223
		private global::System.Windows.Forms.ListView ltvSeries;

		// Token: 0x040000E0 RID: 224
		private global::System.Windows.Forms.Button btnOk;

		// Token: 0x040000E1 RID: 225
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x040000E2 RID: 226
		private global::System.Windows.Forms.ImageList images;

		// Token: 0x040000E3 RID: 227
		private global::System.ComponentModel.IContainer components;
	}
}
