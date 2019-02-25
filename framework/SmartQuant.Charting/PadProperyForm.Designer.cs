namespace SmartQuant.Charting
{
	// Token: 0x02000048 RID: 72
	public partial class PadProperyForm : global::System.Windows.Forms.Form
	{
		// Token: 0x0600044F RID: 1103 RVA: 0x0000F85A File Offset: 0x0000E85A
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x0000F87C File Offset: 0x0000E87C
		private void InitializeComponent()
		{
			global::System.Resources.ResourceManager resourceManager = new global::System.Resources.ResourceManager(typeof(global::SmartQuant.Charting.PadProperyForm));
			this.PropertyGrid = new global::System.Windows.Forms.PropertyGrid();
			base.SuspendLayout();
			this.PropertyGrid.CommandsVisibleIfAvailable = true;
			this.PropertyGrid.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.PropertyGrid.LargeButtons = false;
			this.PropertyGrid.LineColor = global::System.Drawing.SystemColors.ScrollBar;
			this.PropertyGrid.Location = new global::System.Drawing.Point(0, 0);
			this.PropertyGrid.Name = "PropertyGrid";
			this.PropertyGrid.Size = new global::System.Drawing.Size(336, 381);
			this.PropertyGrid.TabIndex = 0;
			this.PropertyGrid.Text = "propertyGrid1";
			this.PropertyGrid.ViewBackColor = global::System.Drawing.SystemColors.Window;
			this.PropertyGrid.ViewForeColor = global::System.Drawing.SystemColors.WindowText;
			this.PropertyGrid.PropertyValueChanged += new global::System.Windows.Forms.PropertyValueChangedEventHandler(this.PropertyGrid_PropertyValueChanged);
			this.AutoScaleBaseSize = new global::System.Drawing.Size(5, 13);
			base.ClientSize = new global::System.Drawing.Size(336, 381);
			base.Controls.Add(this.PropertyGrid);
			base.Icon = (global::System.Drawing.Icon)resourceManager.GetObject("$this.Icon");
			base.Name = "PadProperyForm";
			this.Text = "Pad properties";
			base.ShowInTaskbar = false;
			base.ResumeLayout(false);
		}

		// Token: 0x040001BD RID: 445
		private global::System.Windows.Forms.PropertyGrid PropertyGrid;

		// Token: 0x040001BE RID: 446
		private global::System.ComponentModel.Container components;
	}
}
