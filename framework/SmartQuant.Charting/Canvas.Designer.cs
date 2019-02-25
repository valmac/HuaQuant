namespace SmartQuant.Charting
{
	// Token: 0x02000047 RID: 71
	public partial class Canvas : global::System.Windows.Forms.Form
	{
		// Token: 0x06000447 RID: 1095 RVA: 0x0000F614 File Offset: 0x0000E614
		protected override void Dispose(bool disposing)
		{
			global::SmartQuant.Charting.CanvasManager.Remove(this);
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x0000F670 File Offset: 0x0000E670
		private void InitializeComponent()
		{
			this.helpProvider1 = new global::System.Windows.Forms.HelpProvider();
			this.fChart = new global::SmartQuant.Charting.Chart();
			base.SuspendLayout();
			this.fChart.AntiAliasingEnabled = false;
			this.fChart.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.fChart.DoubleBufferingEnabled = true;
			this.fChart.FileName = null;
			this.fChart.GroupLeftMarginEnabled = false;
			this.fChart.GroupZoomEnabled = false;
			this.fChart.ImeMode = global::System.Windows.Forms.ImeMode.Off;
			this.fChart.Location = new global::System.Drawing.Point(0, 0);
			this.fChart.Name = "fChart";
			this.fChart.PrintAlign = global::SmartQuant.Charting.EPrintAlign.None;
			this.fChart.PrintHeight = 400;
			this.fChart.PrintLayout = global::SmartQuant.Charting.EPrintLayout.Portrait;
			this.fChart.PrintWidth = 600;
			this.fChart.PrintX = 10;
			this.fChart.PrintY = 10;
			this.fChart.Size = new global::System.Drawing.Size(488, 293);
			this.fChart.SmoothingEnabled = false;
			this.fChart.TabIndex = 0;
			this.AutoScaleBaseSize = new global::System.Drawing.Size(5, 13);
			base.ClientSize = new global::System.Drawing.Size(488, 293);
			base.Controls.Add(this.fChart);
			base.Name = "TCanvas";
			this.Text = "TCanvas";
			base.ResumeLayout(false);
		}

		// Token: 0x040001B8 RID: 440
		private global::System.Windows.Forms.HelpProvider helpProvider1;

		// Token: 0x040001B9 RID: 441
		private global::SmartQuant.Charting.Chart fChart;

		// Token: 0x040001BA RID: 442
		private global::System.ComponentModel.Container components;
	}
}
