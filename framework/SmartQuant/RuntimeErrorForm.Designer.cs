namespace SmartQuant
{
	// Token: 0x02000038 RID: 56
	internal partial class RuntimeErrorForm : global::System.Windows.Forms.Form
	{
		// Token: 0x0600010B RID: 267 RVA: 0x00004B59 File Offset: 0x00003B59
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00004B78 File Offset: 0x00003B78
		private void InitializeComponent()
		{
			global::System.Resources.ResourceManager resourceManager = new global::System.Resources.ResourceManager(typeof(global::SmartQuant.RuntimeErrorForm));
			this.label1 = new global::System.Windows.Forms.Label();
			this.lblDescription = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.lblLevel = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.lblSource = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.tbxDetails = new global::System.Windows.Forms.TextBox();
			this.btnClose = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.label1.Location = new global::System.Drawing.Point(16, 64);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(64, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Description:";
			this.lblDescription.Location = new global::System.Drawing.Point(80, 64);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new global::System.Drawing.Size(552, 32);
			this.lblDescription.TabIndex = 1;
			this.lblDescription.Text = "Description";
			this.label2.Location = new global::System.Drawing.Point(16, 40);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(64, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Level:";
			this.label2.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.lblLevel.Location = new global::System.Drawing.Point(80, 40);
			this.lblLevel.Name = "lblLevel";
			this.lblLevel.Size = new global::System.Drawing.Size(552, 16);
			this.lblLevel.TabIndex = 3;
			this.lblLevel.Text = "Level";
			this.lblLevel.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label3.Location = new global::System.Drawing.Point(16, 16);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(64, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "Source:";
			this.label3.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.lblSource.Location = new global::System.Drawing.Point(80, 16);
			this.lblSource.Name = "lblSource";
			this.lblSource.Size = new global::System.Drawing.Size(552, 16);
			this.lblSource.TabIndex = 5;
			this.lblSource.Text = "Source";
			this.lblSource.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label4.Location = new global::System.Drawing.Point(16, 104);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(64, 16);
			this.label4.TabIndex = 6;
			this.label4.Text = "Details:";
			this.label4.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.tbxDetails.Location = new global::System.Drawing.Point(16, 120);
			this.tbxDetails.Multiline = true;
			this.tbxDetails.Name = "tbxDetails";
			this.tbxDetails.ReadOnly = true;
			this.tbxDetails.ScrollBars = global::System.Windows.Forms.ScrollBars.Both;
			this.tbxDetails.Size = new global::System.Drawing.Size(632, 176);
			this.tbxDetails.TabIndex = 7;
			this.tbxDetails.Text = "Details";
			this.tbxDetails.WordWrap = false;
			this.btnClose.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Location = new global::System.Drawing.Point(568, 304);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new global::System.Drawing.Size(80, 24);
			this.btnClose.TabIndex = 8;
			this.btnClose.Text = "Close";
			this.AutoScaleBaseSize = new global::System.Drawing.Size(5, 13);
			base.CancelButton = this.btnClose;
			base.ClientSize = new global::System.Drawing.Size(664, 335);
			base.Controls.Add(this.btnClose);
			base.Controls.Add(this.tbxDetails);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.lblSource);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.lblLevel);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.lblDescription);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.Icon = (global::System.Drawing.Icon)resourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "RuntimeErrorForm";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Runtime Error";
			base.ResumeLayout(false);
		}

		// Token: 0x040000D9 RID: 217
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040000DA RID: 218
		private global::System.Windows.Forms.Label lblDescription;

		// Token: 0x040000DB RID: 219
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040000DC RID: 220
		private global::System.Windows.Forms.Label lblLevel;

		// Token: 0x040000DD RID: 221
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040000DE RID: 222
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040000DF RID: 223
		private global::System.Windows.Forms.TextBox tbxDetails;

		// Token: 0x040000E0 RID: 224
		private global::System.Windows.Forms.Button btnClose;

		// Token: 0x040000E1 RID: 225
		private global::System.Windows.Forms.Label lblSource;

		// Token: 0x040000E2 RID: 226
		private global::System.ComponentModel.Container components;
	}
}
