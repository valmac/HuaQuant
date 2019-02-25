namespace SmartQuant.Simulation.Design
{
	// Token: 0x0200000E RID: 14
	internal partial class OrderEntryDetailsForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000061 RID: 97 RVA: 0x00003004 File Offset: 0x00002004
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00003024 File Offset: 0x00002024
		private void InitializeComponent()
		{
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.btnOK = new global::System.Windows.Forms.Button();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.tbxText = new global::System.Windows.Forms.TextBox();
			this.nudOrderQty = new global::System.Windows.Forms.NumericUpDown();
			this.nudStopPx = new global::System.Windows.Forms.NumericUpDown();
			this.nudPrice = new global::System.Windows.Forms.NumericUpDown();
			this.cbxOrdTypes = new global::System.Windows.Forms.ComboBox();
			this.cbxSides = new global::System.Windows.Forms.ComboBox();
			this.cbxInstruments = new global::System.Windows.Forms.ComboBox();
			this.dtpDateTime = new global::System.Windows.Forms.DateTimePicker();
			this.label8 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudOrderQty).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudStopPx).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudPrice).BeginInit();
			base.SuspendLayout();
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.btnOK);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new global::System.Drawing.Point(4, 223);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(298, 44);
			this.panel1.TabIndex = 0;
			this.btnCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new global::System.Drawing.Point(156, 12);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(64, 22);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnOK.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new global::System.Drawing.Point(86, 12);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new global::System.Drawing.Size(64, 22);
			this.btnOK.TabIndex = 0;
			this.btnOK.Text = "Ok";
			this.btnOK.UseVisualStyleBackColor = true;
			this.groupBox1.Controls.Add(this.tbxText);
			this.groupBox1.Controls.Add(this.nudOrderQty);
			this.groupBox1.Controls.Add(this.nudStopPx);
			this.groupBox1.Controls.Add(this.nudPrice);
			this.groupBox1.Controls.Add(this.cbxOrdTypes);
			this.groupBox1.Controls.Add(this.cbxSides);
			this.groupBox1.Controls.Add(this.cbxInstruments);
			this.groupBox1.Controls.Add(this.dtpDateTime);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new global::System.Drawing.Point(4, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(298, 219);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.tbxText.Location = new global::System.Drawing.Point(88, 184);
			this.tbxText.Name = "tbxText";
			this.tbxText.Size = new global::System.Drawing.Size(188, 20);
			this.tbxText.TabIndex = 15;
			this.nudOrderQty.Location = new global::System.Drawing.Point(88, 160);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.nudOrderQty;
			int[] array = new int[4];
			array[0] = 1000000;
			numericUpDown.Maximum = new decimal(array);
			this.nudOrderQty.Name = "nudOrderQty";
			this.nudOrderQty.Size = new global::System.Drawing.Size(94, 20);
			this.nudOrderQty.TabIndex = 14;
			this.nudOrderQty.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.nudStopPx.Location = new global::System.Drawing.Point(88, 136);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.nudStopPx;
			int[] array2 = new int[4];
			array2[0] = 1000000;
			numericUpDown2.Maximum = new decimal(array2);
			this.nudStopPx.Name = "nudStopPx";
			this.nudStopPx.Size = new global::System.Drawing.Size(94, 20);
			this.nudStopPx.TabIndex = 13;
			this.nudStopPx.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.nudPrice.Location = new global::System.Drawing.Point(88, 112);
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.nudPrice;
			int[] array3 = new int[4];
			array3[0] = 1000000;
			numericUpDown3.Maximum = new decimal(array3);
			this.nudPrice.Name = "nudPrice";
			this.nudPrice.Size = new global::System.Drawing.Size(94, 20);
			this.nudPrice.TabIndex = 12;
			this.nudPrice.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.cbxOrdTypes.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxOrdTypes.FormattingEnabled = true;
			this.cbxOrdTypes.Location = new global::System.Drawing.Point(88, 88);
			this.cbxOrdTypes.Name = "cbxOrdTypes";
			this.cbxOrdTypes.Size = new global::System.Drawing.Size(96, 21);
			this.cbxOrdTypes.TabIndex = 11;
			this.cbxOrdTypes.SelectedIndexChanged += new global::System.EventHandler(this.cbxOrdTypes_SelectedIndexChanged);
			this.cbxSides.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxSides.FormattingEnabled = true;
			this.cbxSides.Location = new global::System.Drawing.Point(88, 64);
			this.cbxSides.Name = "cbxSides";
			this.cbxSides.Size = new global::System.Drawing.Size(96, 21);
			this.cbxSides.TabIndex = 10;
			this.cbxInstruments.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxInstruments.FormattingEnabled = true;
			this.cbxInstruments.Location = new global::System.Drawing.Point(88, 40);
			this.cbxInstruments.Name = "cbxInstruments";
			this.cbxInstruments.Size = new global::System.Drawing.Size(96, 21);
			this.cbxInstruments.Sorted = true;
			this.cbxInstruments.TabIndex = 9;
			this.cbxInstruments.SelectedIndexChanged += new global::System.EventHandler(this.cbxInstruments_SelectedIndexChanged);
			this.dtpDateTime.Format = global::System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDateTime.Location = new global::System.Drawing.Point(88, 16);
			this.dtpDateTime.Name = "dtpDateTime";
			this.dtpDateTime.Size = new global::System.Drawing.Size(188, 20);
			this.dtpDateTime.TabIndex = 8;
			this.label8.Location = new global::System.Drawing.Point(16, 184);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(66, 20);
			this.label8.TabIndex = 7;
			this.label8.Text = "Text";
			this.label8.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label7.Location = new global::System.Drawing.Point(16, 160);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(66, 20);
			this.label7.TabIndex = 6;
			this.label7.Text = "OrderQty";
			this.label7.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label6.Location = new global::System.Drawing.Point(16, 136);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(66, 20);
			this.label6.TabIndex = 5;
			this.label6.Text = "StopPx";
			this.label6.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label5.Location = new global::System.Drawing.Point(16, 112);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(66, 20);
			this.label5.TabIndex = 4;
			this.label5.Text = "Price";
			this.label5.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label4.Location = new global::System.Drawing.Point(16, 88);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(66, 20);
			this.label4.TabIndex = 3;
			this.label4.Text = "OrdType";
			this.label4.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label3.Location = new global::System.Drawing.Point(16, 64);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(66, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Side";
			this.label3.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label2.Location = new global::System.Drawing.Point(16, 40);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(66, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Instrument";
			this.label2.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label1.Location = new global::System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(66, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "DateTime";
			this.label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			base.AcceptButton = this.btnOK;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.btnCancel;
			base.ClientSize = new global::System.Drawing.Size(306, 267);
			base.Controls.Add(this.groupBox1);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "OrderEntryDetailsForm";
			base.Padding = new global::System.Windows.Forms.Padding(4, 4, 4, 0);
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "OrderEntryDetailsForm";
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudOrderQty).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudStopPx).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudPrice).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000026 RID: 38
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.Label label8;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.Label label7;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.Label label6;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400002D RID: 45
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000031 RID: 49
		private global::System.Windows.Forms.DateTimePicker dtpDateTime;

		// Token: 0x04000032 RID: 50
		private global::System.Windows.Forms.ComboBox cbxInstruments;

		// Token: 0x04000033 RID: 51
		private global::System.Windows.Forms.ComboBox cbxSides;

		// Token: 0x04000034 RID: 52
		private global::System.Windows.Forms.ComboBox cbxOrdTypes;

		// Token: 0x04000035 RID: 53
		private global::System.Windows.Forms.NumericUpDown nudOrderQty;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Forms.NumericUpDown nudStopPx;

		// Token: 0x04000037 RID: 55
		private global::System.Windows.Forms.NumericUpDown nudPrice;

		// Token: 0x04000038 RID: 56
		private global::System.Windows.Forms.TextBox tbxText;

		// Token: 0x04000039 RID: 57
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x0400003A RID: 58
		private global::System.Windows.Forms.Button btnOK;
	}
}
