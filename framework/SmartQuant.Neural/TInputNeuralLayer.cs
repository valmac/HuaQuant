using System;

namespace SmartQuant.Neural
{
	// Token: 0x02000012 RID: 18
	[Serializable]
	public class TInputNeuralLayer : TNeuralLayer
	{
		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x0000523D File Offset: 0x0000423D
		public bool IsThreshold
		{
			get
			{
				return this.fIsThreshold;
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00005245 File Offset: 0x00004245
		public TInputNeuralLayer()
		{
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00005250 File Offset: 0x00004250
		public TInputNeuralLayer(int NNeuron, bool AddThreshold)
		{
			if (AddThreshold)
			{
				this.fNeuron.Add(new TThresholdNeuron());
				this.fNNeuron++;
				this.fIsThreshold = true;
			}
			else
			{
				this.fIsThreshold = false;
			}
			for (int i = 0; i < NNeuron; i++)
			{
				this.fNeuron.Add(new TInputNeuron());
			}
			this.fNNeuron += NNeuron;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x000052C0 File Offset: 0x000042C0
		public void Connect(TInputNeuralLayer InputLayer)
		{
			int num = 0;
			int num2 = 0;
			if (this.IsThreshold)
			{
				num = 1;
			}
			if (InputLayer.IsThreshold)
			{
				num2 = 1;
			}
			int num3 = Math.Min(base.GetNNeuron() - num, InputLayer.GetNNeuron() - num2);
			for (int i = num; i < num3; i++)
			{
				base.GetNeuron(i).Connect(InputLayer.GetNeuron(i - num2));
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000531C File Offset: 0x0000431C
		public void Connect(TOutputNeuralLayer OutputLayer)
		{
			int num = 0;
			if (this.IsThreshold)
			{
				num = 1;
			}
			int num2 = Math.Min(base.GetNNeuron() - num, OutputLayer.GetNNeuron());
			for (int i = num; i < num2; i++)
			{
				base.GetNeuron(i).Connect(OutputLayer.GetNeuron(i));
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00005368 File Offset: 0x00004368
		public void FeedInput(double[] InputPattern)
		{
			for (int i = 1; i < this.fNNeuron; i++)
			{
				((TInputNeuron)this.fNeuron[i]).Input = InputPattern[i - 1];
			}
		}

		// Token: 0x04000066 RID: 102
		private bool fIsThreshold;
	}
}
