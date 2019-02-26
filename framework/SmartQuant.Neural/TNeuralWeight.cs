using System;
using SmartQuant.Quant;

namespace SmartQuant.Neural
{
	// Token: 0x02000014 RID: 20
	[Serializable]
	public class TNeuralWeight
	{
		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000DC RID: 220 RVA: 0x000053BD File Offset: 0x000043BD
		public TNeuron Neuron
		{
			get
			{
				return this.fNeuron;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000DD RID: 221 RVA: 0x000053C5 File Offset: 0x000043C5
		// (set) Token: 0x060000DE RID: 222 RVA: 0x000053CD File Offset: 0x000043CD
		public double Weight
		{
			get
			{
				return this.fWeight;
			}
			set
			{
				this.fWeight = value;
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x000053D6 File Offset: 0x000043D6
		public TNeuralWeight()
		{
			TNeuralNetwork.Network.AddWeight(this);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000053EC File Offset: 0x000043EC
		public TNeuralWeight(TNeuron Neuron, double Weight)
		{
			this.fNeuron = Neuron;
			this.fNeuronID = Neuron.ID;
			if (TNeuralNetwork.Network.InitMode == EWeightInitMode.Random)
			{
				this.Randomize();
			}
			else
			{
				this.fWeight = Weight;
			}
			this.fOldWeight = this.fWeight;
			this.fGradient = 0.0;
			this.fOldGradient = 0.0;
			this.fRpropDelta = TNeuralNetwork.Network.RpropDeltaInit;
			this.fRpropOldDelta = this.fRpropDelta;
			TNeuralNetwork.Network.AddWeight(this);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00005480 File Offset: 0x00004480
		public TNeuralWeight(TNeuron Neuron)
		{
			this.fNeuron = Neuron;
			this.fNeuronID = Neuron.ID;
			if (TNeuralNetwork.Network.InitMode == EWeightInitMode.Random)
			{
				this.Randomize();
			}
			else
			{
				this.fWeight = 0.0;
			}
			this.fOldWeight = this.fWeight;
			this.fGradient = 0.0;
			this.fOldGradient = 0.0;
			this.fRpropDelta = TNeuralNetwork.Network.RpropDeltaInit;
			this.fRpropOldDelta = this.fRpropDelta;
			TNeuralNetwork.Network.AddWeight(this);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0000551A File Offset: 0x0000451A
		public void Randomize()
		{
			this.fWeight = SmartQuant.Quant.Random.Rndm() - 0.5;
			this.fOldWeight = this.fWeight;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0000553D File Offset: 0x0000453D
		public double GetInput()
		{
			return this.fNeuron.GetOutput();
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000554A File Offset: 0x0000454A
		public double PropagateInput()
		{
			return this.fWeight * this.GetInput();
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00005559 File Offset: 0x00004559
		public void PropagateError(double Error)
		{
			this.fNeuron.AddError(this.fWeight * Error);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00005570 File Offset: 0x00004570
		public void Update(double Error)
		{
			this.fGradient = -Error * this.fNeuron.GetOutput();
			double num = this.fWeight;
			double num2 = this.fWeight - this.fOldWeight;
			double num3 = 0.0;
			if (TNeuralNetwork.Network.LearningMethod == ELearningMethod.BackProp)
			{
				this.fWeight += -TNeuralNetwork.Network.LearningRate * this.fGradient / (double)TNeuralNetwork.Network.NBatch + TNeuralNetwork.Network.Momentum * num2 - TNeuralNetwork.Network.WeightDecay * this.fWeight;
				this.fOldGradient = this.fGradient;
			}
			if (TNeuralNetwork.Network.LearningMethod == ELearningMethod.QuickProp)
			{
				if (num2 > 0.0)
				{
					if (this.fGradient < 0.0)
					{
						num3 = -TNeuralNetwork.Network.LearningRate * this.fGradient + TNeuralNetwork.Network.Momentum * num2;
					}
					else
					{
						num3 = this.fGradient / (this.fOldGradient - this.fGradient) * num2;
						if (num3 > TNeuralNetwork.Network.MaximumGrowth * num2)
						{
							num3 = TNeuralNetwork.Network.MaximumGrowth * num2;
						}
					}
				}
				if (num2 < 0.0)
				{
					if (this.fGradient > 0.0)
					{
						num3 = -TNeuralNetwork.Network.LearningRate * this.fGradient + TNeuralNetwork.Network.Momentum * num2;
					}
					else
					{
						num3 = this.fGradient / (this.fOldGradient - this.fGradient) * num2;
						if (num3 < TNeuralNetwork.Network.MaximumGrowth * num2)
						{
							num3 = TNeuralNetwork.Network.MaximumGrowth * num2;
						}
					}
				}
				if (num2 == 0.0)
				{
					num3 = -TNeuralNetwork.Network.LearningRate * this.fGradient + TNeuralNetwork.Network.Momentum * num2;
				}
				this.fWeight += num3 - TNeuralNetwork.Network.WeightDecay * this.fWeight;
				this.fOldGradient = this.fGradient;
			}
			if (TNeuralNetwork.Network.LearningMethod == ELearningMethod.Rprop)
			{
				if (this.fGradient * this.fOldGradient > 0.0)
				{
					this.fRpropDelta = Math.Min(TNeuralNetwork.Network.RpropIncrease * this.fRpropOldDelta, TNeuralNetwork.Network.RpropDeltaMax);
					if (this.fGradient == 0.0)
					{
						num3 = 0.0;
					}
					else if (this.fGradient > 0.0)
					{
						num3 = -this.fRpropDelta;
					}
					else
					{
						num3 = this.fRpropDelta;
					}
					this.fWeight += num3;
					this.fOldGradient = this.fGradient;
				}
				if (this.fGradient * this.fOldGradient < 0.0)
				{
					this.fRpropDelta = Math.Max(TNeuralNetwork.Network.RpropDecrease * this.fRpropOldDelta, TNeuralNetwork.Network.RpropDeltaMin);
					if (this.fGradient == 0.0)
					{
						num3 = 0.0;
					}
					else if (this.fGradient > 0.0)
					{
						num3 = -this.fRpropDelta;
					}
					else
					{
						num3 = this.fRpropDelta;
					}
					this.fWeight += num3;
					this.fOldGradient = 0.0;
				}
				if (this.fGradient * this.fOldGradient == 0.0)
				{
					this.fRpropDelta = this.fRpropOldDelta;
					if (this.fGradient == 0.0)
					{
						num3 = 0.0;
					}
					else if (this.fGradient > 0.0)
					{
						num3 = -this.fRpropDelta;
					}
					else
					{
						num3 = this.fRpropDelta;
					}
					this.fWeight += num3;
					this.fOldGradient = this.fGradient;
				}
				this.fRpropOldDelta = this.fRpropDelta;
			}
			this.fOldWeight = num;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00005932 File Offset: 0x00004932
		public void Store()
		{
			this.fTmpWeight = this.fWeight;
			this.fOldTmpWeight = this.fOldWeight;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0000594C File Offset: 0x0000494C
		public void Restore()
		{
			this.fWeight = this.fTmpWeight;
			this.fOldWeight = this.fOldTmpWeight;
			this.fGradient = 0.0;
			this.fOldGradient = 0.0;
		}

		// Token: 0x04000067 RID: 103
		private TNeuron fNeuron;

		// Token: 0x04000068 RID: 104
		private int fNeuronID;

		// Token: 0x04000069 RID: 105
		private double fWeight;

		// Token: 0x0400006A RID: 106
		private double fOldWeight;

		// Token: 0x0400006B RID: 107
		private double fTmpWeight;

		// Token: 0x0400006C RID: 108
		private double fOldTmpWeight;

		// Token: 0x0400006D RID: 109
		private double fGradient;

		// Token: 0x0400006E RID: 110
		private double fOldGradient;

		// Token: 0x0400006F RID: 111
		private double fRpropDelta;

		// Token: 0x04000070 RID: 112
		private double fRpropOldDelta;
	}
}
