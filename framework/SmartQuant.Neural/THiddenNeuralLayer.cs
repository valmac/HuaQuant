using System;

namespace SmartQuant.Neural
{
	// Token: 0x02000005 RID: 5
	[Serializable]
	public class THiddenNeuralLayer : TNeuralLayer
	{
		// Token: 0x06000036 RID: 54 RVA: 0x00002A00 File Offset: 0x00001A00
		public THiddenNeuralLayer()
		{
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002A08 File Offset: 0x00001A08
		public THiddenNeuralLayer(int NNeuron)
		{
			this.fNeuron.Add(new TThresholdNeuron());
			for (int i = 0; i < NNeuron; i++)
			{
				this.fNeuron.Add(new THiddenNeuron());
			}
			this.fNNeuron = NNeuron + 1;
		}
	}
}
