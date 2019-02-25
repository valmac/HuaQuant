using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SmartQuant.Simulation.Design
{
	// Token: 0x0200002D RID: 45
	internal partial class SimulatorEditorForm : Form
	{
		// Token: 0x06000190 RID: 400 RVA: 0x000085CC File Offset: 0x000075CC
		public SimulatorEditorForm(Simulator simulator)
		{
			this.InitializeComponent();
			this.simulator = simulator;
			this.grdSimulator.SelectedObject = simulator;
			this.UpdateStatus();
			simulator.EnterSimulation += this.OnEnterSimulation;
			simulator.ExitSimulation += this.OnExitSimulation;
			simulator.StateChanged += this.OnStateChanged;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00008654 File Offset: 0x00007654
		protected override void OnClosing(CancelEventArgs e)
		{
			this.simulator.EnterSimulation -= this.OnEnterSimulation;
			this.simulator.ExitSimulation -= this.OnExitSimulation;
			this.simulator.StateChanged -= this.OnStateChanged;
			base.OnClosing(e);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00008AAD File Offset: 0x00007AAD
		private void btnStart_Click(object sender, EventArgs e)
		{
			if (this.simulator.CurrentState == SimulatorState.Stopped)
			{
				this.simulator.Start(false);
				return;
			}
			this.simulator.Continue();
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00008AD4 File Offset: 0x00007AD4
		private void btnPause_Click(object sender, EventArgs e)
		{
			this.simulator.Pause();
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00008AE1 File Offset: 0x00007AE1
		private void btnStop_Click(object sender, EventArgs e)
		{
			this.simulator.Stop(false);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00008AF0 File Offset: 0x00007AF0
		private void OnEnterSimulation(object sender, EventArgs e)
		{
			if (base.InvokeRequired)
			{
				base.Invoke(new EventHandler(this.OnEnterSimulation), new object[]
				{
					sender,
					e
				});
				return;
			}
			this.UpdateStatus();
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00008B30 File Offset: 0x00007B30
		private void OnExitSimulation(object sender, EventArgs e)
		{
			if (base.InvokeRequired)
			{
				base.Invoke(new EventHandler(this.OnExitSimulation), new object[]
				{
					sender,
					e
				});
				return;
			}
			this.UpdateStatus();
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00008B70 File Offset: 0x00007B70
		private void OnStateChanged(object sender, EventArgs e)
		{
			if (base.InvokeRequired)
			{
				base.Invoke(new EventHandler(this.OnStateChanged), new object[]
				{
					sender,
					e
				});
				return;
			}
			this.UpdateStatus();
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00008BB0 File Offset: 0x00007BB0
		private void UpdateStatus()
		{
			switch (this.simulator.CurrentState)
			{
			case SimulatorState.Stopped:
				this.btnStart.Enabled = true;
				this.btnPause.Enabled = false;
				this.btnStop.Enabled = false;
				this.btnStart.Text = "Start";
				return;
			case SimulatorState.Running:
				this.btnStart.Enabled = false;
				this.btnPause.Enabled = true;
				this.btnStop.Enabled = true;
				this.btnStart.Text = "Start";
				return;
			case SimulatorState.Paused:
				this.btnStart.Enabled = true;
				this.btnPause.Enabled = false;
				this.btnStop.Enabled = true;
				this.btnStart.Text = "Continue";
				return;
			default:
				return;
			}
		}

		// Token: 0x040000D7 RID: 215
		private Simulator simulator;
	}
}
