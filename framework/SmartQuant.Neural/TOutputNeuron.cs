using System;

namespace SmartQuant.Neural
{
	// Token: 0x0200000C RID: 12
	[Serializable]
	public class TOutputNeuron : TNeuron
	{
		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00003010 File Offset: 0x00002010
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00003018 File Offset: 0x00002018
		private EActivationMode Mode
		{
			get
			{
				return this.fMode;
			}
			set
			{
				this.fMode = value;
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00003021 File Offset: 0x00002021
		public TOutputNeuron()
		{
			this.fMode = EActivationMode.Approximation;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00003030 File Offset: 0x00002030
		public TOutputNeuron(EActivationMode Mode)
		{
			this.fMode = Mode;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00003040 File Offset: 0x00002040
		public override double Activation(double x)
		{
			switch (this.fMode)
			{
			case EActivationMode.Approximation:
				return x;
			case EActivationMode.Classification:
				return 1.0 / (1.0 + Math.Exp(-2.0 * x));
			default:
				return 0.0;
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00003094 File Offset: 0x00002094
		public override double Gradient(double x)
		{
			switch (this.fMode)
			{
			case EActivationMode.Approximation:
				return 1.0;
			case EActivationMode.Classification:
			{
				double num = Math.Exp(-2.0 * x);
				return 2.0 * num / ((1.0 + num) * (1.0 + num));
			}
			default:
				return 0.0;
			}
		}

		// Token: 0x04000045 RID: 69
		private EActivationMode fMode;
	}
}
