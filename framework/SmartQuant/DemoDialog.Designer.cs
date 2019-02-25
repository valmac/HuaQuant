namespace SmartQuant
{
	// Token: 0x02000007 RID: 7
	internal partial class DemoDialog : global::System.Windows.Forms.Form
	{
		// Token: 0x0600002C RID: 44 RVA: 0x00002756 File Offset: 0x00001756
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002778 File Offset: 0x00001778
		private void InitializeComponent()
		{
			global::System.Resources.ResourceManager resourceManager = new global::System.Resources.ResourceManager(typeof(global::SmartQuant.DemoDialog));
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.btnOk = new global::System.Windows.Forms.Button();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.lblText = new global::System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.panel1.Controls.Add(this.btnOk);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new global::System.Drawing.Point(0, 175);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(346, 32);
			this.panel1.TabIndex = 0;
			this.btnOk.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.btnOk.Location = new global::System.Drawing.Point(144, 4);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new global::System.Drawing.Size(64, 24);
			this.btnOk.TabIndex = 0;
			this.btnOk.Text = "Ok";
			this.pictureBox1.BackColor = global::System.Drawing.Color.White;
			this.pictureBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.pictureBox1.Image = (global::System.Drawing.Image)resourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(346, 104);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.pictureBox2.BackColor = global::System.Drawing.Color.White;
			this.pictureBox2.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.pictureBox2.Image = (global::System.Drawing.Image)resourceManager.GetObject("pictureBox2.Image");
			this.pictureBox2.Location = new global::System.Drawing.Point(0, 151);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new global::System.Drawing.Size(346, 24);
			this.pictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			this.lblText.BackColor = global::System.Drawing.Color.White;
			this.lblText.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lblText.ForeColor = global::System.Drawing.Color.Black;
			this.lblText.Location = new global::System.Drawing.Point(0, 104);
			this.lblText.Name = "lblText";
			this.lblText.Size = new global::System.Drawing.Size(346, 47);
			this.lblText.TabIndex = 3;
			this.lblText.Text = "Text";
			this.lblText.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.AutoScaleBaseSize = new global::System.Drawing.Size(5, 13);
			base.CancelButton = this.btnOk;
			base.ClientSize = new global::System.Drawing.Size(346, 207);
			base.Controls.Add(this.lblText);
			base.Controls.Add(this.pictureBox2);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "DemoDialog";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Demo";
			this.panel1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x0400002D RID: 45
		private global::System.Windows.Forms.Button btnOk;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.Label lblText;

		// Token: 0x0400002F RID: 47
		private global::System.ComponentModel.Container components;
	}
}
