namespace SmartQuant.Trading.Design
{
	// Token: 0x0200003C RID: 60
	internal partial class NewRequestForm : global::System.Windows.Forms.Form
	{
		// Token: 0x060002BB RID: 699 RVA: 0x0000B0C4 File Offset: 0x0000A0C4
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060002BC RID: 700 RVA: 0x0000B0E4 File Offset: 0x0000A0E4
		private void InitializeComponent()
		{
			this.pnlBar = new global::System.Windows.Forms.Panel();
			this.label2 = new global::System.Windows.Forms.Label();
			this.cbxBarType = new global::System.Windows.Forms.ComboBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.nudBarSize = new global::System.Windows.Forms.NumericUpDown();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.label1 = new global::System.Windows.Forms.Label();
			this.cbxDataType = new global::System.Windows.Forms.ComboBox();
			this.btnOk = new global::System.Windows.Forms.Button();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.pnlBar.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudBarSize).BeginInit();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.pnlBar.Controls.Add(this.nudBarSize);
			this.pnlBar.Controls.Add(this.label3);
			this.pnlBar.Controls.Add(this.cbxBarType);
			this.pnlBar.Controls.Add(this.label2);
			this.pnlBar.Location = new global::System.Drawing.Point(8, 40);
			this.pnlBar.Name = "pnlBar";
			this.pnlBar.Size = new global::System.Drawing.Size(280, 24);
			this.pnlBar.TabIndex = 6;
			this.label2.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.label2.Location = new global::System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(56, 24);
			this.label2.TabIndex = 3;
			this.label2.Text = "Bar type";
			this.label2.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.cbxBarType.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.cbxBarType.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxBarType.Location = new global::System.Drawing.Point(56, 0);
			this.cbxBarType.Name = "cbxBarType";
			this.cbxBarType.Size = new global::System.Drawing.Size(88, 21);
			this.cbxBarType.TabIndex = 5;
			this.label3.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.label3.Location = new global::System.Drawing.Point(144, 0);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(56, 24);
			this.label3.TabIndex = 6;
			this.label3.Text = "Bar type";
			this.label3.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.nudBarSize.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.nudBarSize.Location = new global::System.Drawing.Point(200, 0);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.nudBarSize;
			int[] array = new int[4];
			array[0] = 10000000;
			numericUpDown.Maximum = new decimal(array);
			this.nudBarSize.Name = "nudBarSize";
			this.nudBarSize.Size = new global::System.Drawing.Size(80, 20);
			this.nudBarSize.TabIndex = 7;
			this.nudBarSize.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.panel1.Controls.Add(this.cbxDataType);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new global::System.Drawing.Point(8, 8);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(176, 24);
			this.panel1.TabIndex = 7;
			this.label1.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.label1.Location = new global::System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(56, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "Data type";
			this.label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.cbxDataType.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.cbxDataType.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxDataType.Location = new global::System.Drawing.Point(56, 0);
			this.cbxDataType.Name = "cbxDataType";
			this.cbxDataType.Size = new global::System.Drawing.Size(120, 21);
			this.cbxDataType.TabIndex = 2;
			this.cbxDataType.SelectedIndexChanged += new global::System.EventHandler(this.cbxDataType_SelectedIndexChanged);
			this.btnOk.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.btnOk.Location = new global::System.Drawing.Point(144, 80);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new global::System.Drawing.Size(72, 24);
			this.btnOk.TabIndex = 8;
			this.btnOk.Text = "Ok";
			this.btnCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new global::System.Drawing.Point(224, 80);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(72, 24);
			this.btnCancel.TabIndex = 9;
			this.btnCancel.Text = "Cancel";
			base.AcceptButton = this.btnOk;
			this.AutoScaleBaseSize = new global::System.Drawing.Size(5, 13);
			base.CancelButton = this.btnCancel;
			base.ClientSize = new global::System.Drawing.Size(314, 111);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.btnOk);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.pnlBar);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "NewRequestForm";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "New Request";
			this.pnlBar.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.nudBarSize).EndInit();
			this.panel1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040000E3 RID: 227
		private global::System.Windows.Forms.Panel pnlBar;

		// Token: 0x040000E4 RID: 228
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040000E5 RID: 229
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040000E6 RID: 230
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040000E7 RID: 231
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040000E8 RID: 232
		private global::System.Windows.Forms.ComboBox cbxDataType;

		// Token: 0x040000E9 RID: 233
		private global::System.Windows.Forms.Button btnOk;

		// Token: 0x040000EA RID: 234
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x040000EB RID: 235
		private global::System.Windows.Forms.ComboBox cbxBarType;

		// Token: 0x040000EC RID: 236
		private global::System.Windows.Forms.NumericUpDown nudBarSize;

		// Token: 0x040000ED RID: 237
		private global::System.ComponentModel.Container components;
	}
}
