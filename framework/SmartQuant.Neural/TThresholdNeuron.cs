using System;

namespace SmartQuant.Neural
{
	// Token: 0x02000003 RID: 3
	[Serializable]
	public class TThresholdNeuron : TNeuron
	{
		// Token: 0x06000022 RID: 34 RVA: 0x00002693 File Offset: 0x00001693
		public TThresholdNeuron()
		{
			this.fOutput = 1.0;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000026AA File Offset: 0x000016AA
		public override void Connect(TNeuron Neuron)
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000026AC File Offset: 0x000016AC
		public override void Disconnect(TNeuron Neuron)
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000026AE File Offset: 0x000016AE
		public override void ProcessInput(int Option)
		{
			this.fOutput = 1.0;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000026BF File Offset: 0x000016BF
		public override void ProcessError(int Option)
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000026C1 File Offset: 0x000016C1
		public override void Update()
		{
		}
	}
}
