using System;

namespace SmartQuant.Neural
{
	// Token: 0x0200001A RID: 26
	[Serializable]
	public class THiddenNeuron : TNeuron
	{
		// Token: 0x0600011C RID: 284 RVA: 0x00006740 File Offset: 0x00005740
		public override double Activation(double x)
		{
			return Math.Tanh(x);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00006748 File Offset: 0x00005748
		public override double Gradient(double x)
		{
			double num = Math.Tanh(x);
			return 1.0 - num * num;
		}
	}
}
