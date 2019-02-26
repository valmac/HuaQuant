using System;
using System.Collections;

namespace SmartQuant.Neural
{
	// Token: 0x02000004 RID: 4
	[Serializable]
	public class TNeuralLayer
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000028 RID: 40 RVA: 0x000026C3 File Offset: 0x000016C3
		// (set) Token: 0x06000029 RID: 41 RVA: 0x000026CC File Offset: 0x000016CC
		public bool Enabled
		{
			get
			{
				return this.fEnabled;
			}
			set
			{
				this.fEnabled = value;
				foreach (object obj in this.fNeuron)
				{
					TNeuron tneuron = (TNeuron)obj;
					if (this.fEnabled)
					{
						tneuron.Enabled = true;
					}
					else
					{
						tneuron.Enabled = false;
					}
				}
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002740 File Offset: 0x00001740
		public TNeuralLayer()
		{
			this.fNeuron = new ArrayList();
			this.fNNeuron = 0;
			this.fEnabled = true;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002761 File Offset: 0x00001761
		public int GetNNeuron()
		{
			return this.fNNeuron;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002769 File Offset: 0x00001769
		public TNeuron GetNeuron(int i)
		{
			return (TNeuron)this.fNeuron[i];
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0000277C File Offset: 0x0000177C
		public void Connect(TNeuralLayer Layer)
		{
			foreach (object obj in this.fNeuron)
			{
				TNeuron tneuron = (TNeuron)obj;
				foreach (object obj2 in Layer.fNeuron)
				{
					TNeuron neuron = (TNeuron)obj2;
					tneuron.Connect(neuron);
				}
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000281C File Offset: 0x0000181C
		public void Disconnect(TNeuralLayer Layer)
		{
			foreach (object obj in this.fNeuron)
			{
				TNeuron tneuron = (TNeuron)obj;
				foreach (object obj2 in Layer.fNeuron)
				{
					TNeuron neuron = (TNeuron)obj2;
					tneuron.Disconnect(neuron);
				}
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000028BC File Offset: 0x000018BC
		public virtual void ProcessInput(int Option)
		{
			foreach (object obj in this.fNeuron)
			{
				TNeuron tneuron = (TNeuron)obj;
				tneuron.ProcessInput(Option);
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002918 File Offset: 0x00001918
		public virtual void ProcessInput()
		{
			this.ProcessInput(0);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002924 File Offset: 0x00001924
		public virtual void ProcessError(int Option)
		{
			foreach (object obj in this.fNeuron)
			{
				TNeuron tneuron = (TNeuron)obj;
				tneuron.ProcessError(Option);
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002980 File Offset: 0x00001980
		public virtual void ProcessError()
		{
			this.ProcessError(0);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002989 File Offset: 0x00001989
		public void SetName(int i, string Name)
		{
			this.GetNeuron(i).Name = Name;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002998 File Offset: 0x00001998
		public string GetName(int i)
		{
			return this.GetNeuron(i).Name;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000029A8 File Offset: 0x000019A8
		public virtual void Update()
		{
			foreach (object obj in this.fNeuron)
			{
				TNeuron tneuron = (TNeuron)obj;
				tneuron.Update();
			}
		}

		// Token: 0x04000008 RID: 8
		protected int fNNeuron;

		// Token: 0x04000009 RID: 9
		protected ArrayList fNeuron;

		// Token: 0x0400000A RID: 10
		protected bool fEnabled;
	}
}
