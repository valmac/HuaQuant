using System;

namespace SmartQuant.Neural
{
	// Token: 0x02000018 RID: 24
	[Serializable]
	public class TOutputNeuralLayer : TNeuralLayer
	{
		// Token: 0x06000107 RID: 263 RVA: 0x00006363 File Offset: 0x00005363
		public TOutputNeuralLayer()
		{
			this.fMode = EActivationMode.Approximation;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00006374 File Offset: 0x00005374
		public TOutputNeuralLayer(int NNeuron, EActivationMode Mode)
		{
			this.fMode = Mode;
			for (int i = 0; i < NNeuron; i++)
			{
				this.fNeuron.Add(new TOutputNeuron(this.fMode));
			}
			this.fOutput = new double[NNeuron];
			this.fNNeuron = NNeuron;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000063C4 File Offset: 0x000053C4
		public double[] GetOutput()
		{
			for (int i = 0; i < this.fNNeuron; i++)
			{
				this.fOutput[i] = ((TOutputNeuron)this.fNeuron[i]).Output;
			}
			return this.fOutput;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00006408 File Offset: 0x00005408
		public void FeedError(double[] Error)
		{
			for (int i = 0; i < this.fNNeuron; i++)
			{
				((TOutputNeuron)this.fNeuron[i]).Error = Error[i];
			}
		}

		// Token: 0x04000084 RID: 132
		private double[] fOutput;

		// Token: 0x04000085 RID: 133
		private EActivationMode fMode;
	}
}
