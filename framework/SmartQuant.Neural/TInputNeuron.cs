using System;

namespace SmartQuant.Neural
{
	// Token: 0x02000013 RID: 19
	[Serializable]
	public class TInputNeuron : TNeuron
	{
		// Token: 0x060000DB RID: 219 RVA: 0x000053A9 File Offset: 0x000043A9
		public override void ProcessInput(int Option)
		{
			this.fOutput = this.Activation(this.fInput);
		}
	}
}
