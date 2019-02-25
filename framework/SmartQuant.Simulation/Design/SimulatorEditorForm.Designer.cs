namespace SmartQuant.Simulation.Design
{
	// Token: 0x0200002D RID: 45
	internal partial class SimulatorEditorForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000191 RID: 401 RVA: 0x00008634 File Offset: 0x00007634
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x000086B0 File Offset: 0x000076B0
		private void InitializeComponent()
		{
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.btnPause = new global::System.Windows.Forms.Button();
			this.btnClose = new global::System.Windows.Forms.Button();
			this.btnStop = new global::System.Windows.Forms.Button();
			this.btnStart = new global::System.Windows.Forms.Button();
			this.grdSimulator = new global::System.Windows.Forms.PropertyGrid();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.panel1.Controls.Add(this.btnPause);
			this.panel1.Controls.Add(this.btnClose);
			this.panel1.Controls.Add(this.btnStop);
			this.panel1.Controls.Add(this.btnStart);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new global::System.Drawing.Point(0, 263);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(458, 56);
			this.panel1.TabIndex = 0;
			this.btnPause.Location = new global::System.Drawing.Point(104, 16);
			this.btnPause.Name = "btnPause";
			this.btnPause.Size = new global::System.Drawing.Size(80, 24);
			this.btnPause.TabIndex = 3;
			this.btnPause.Text = "Pause";
			this.btnPause.Click += new global::System.EventHandler(this.btnPause_Click);
			this.btnClose.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Location = new global::System.Drawing.Point(376, 16);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new global::System.Drawing.Size(72, 24);
			this.btnClose.TabIndex = 2;
			this.btnClose.Text = "Close";
			this.btnStop.Location = new global::System.Drawing.Point(192, 16);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new global::System.Drawing.Size(80, 24);
			this.btnStop.TabIndex = 1;
			this.btnStop.Text = "Stop";
			this.btnStop.Click += new global::System.EventHandler(this.btnStop_Click);
			this.btnStart.Location = new global::System.Drawing.Point(16, 16);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new global::System.Drawing.Size(80, 24);
			this.btnStart.TabIndex = 0;
			this.btnStart.Text = "Start";
			this.btnStart.Click += new global::System.EventHandler(this.btnStart_Click);
			this.grdSimulator.CommandsVisibleIfAvailable = true;
			this.grdSimulator.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.grdSimulator.LargeButtons = false;
			this.grdSimulator.LineColor = global::System.Drawing.SystemColors.ScrollBar;
			this.grdSimulator.Location = new global::System.Drawing.Point(0, 0);
			this.grdSimulator.Name = "grdSimulator";
			this.grdSimulator.Size = new global::System.Drawing.Size(458, 263);
			this.grdSimulator.TabIndex = 3;
			this.grdSimulator.Text = "propertyGrid1";
			this.grdSimulator.ViewBackColor = global::System.Drawing.SystemColors.Window;
			this.grdSimulator.ViewForeColor = global::System.Drawing.SystemColors.WindowText;
			this.AutoScaleBaseSize = new global::System.Drawing.Size(5, 13);
			base.CancelButton = this.btnClose;
			base.ClientSize = new global::System.Drawing.Size(458, 319);
			base.Controls.Add(this.grdSimulator);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "SimulatorEditorForm";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Simulator settings";
			this.panel1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040000D0 RID: 208
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040000D1 RID: 209
		private global::System.ComponentModel.Container components;

		// Token: 0x040000D2 RID: 210
		private global::System.Windows.Forms.Button btnStart;

		// Token: 0x040000D3 RID: 211
		private global::System.Windows.Forms.Button btnStop;

		// Token: 0x040000D4 RID: 212
		private global::System.Windows.Forms.Button btnClose;

		// Token: 0x040000D5 RID: 213
		private global::System.Windows.Forms.PropertyGrid grdSimulator;

		// Token: 0x040000D6 RID: 214
		private global::System.Windows.Forms.Button btnPause;
	}
}
