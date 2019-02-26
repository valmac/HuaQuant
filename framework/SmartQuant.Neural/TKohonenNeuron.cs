using System;

namespace SmartQuant.Neural
{
	// Token: 0x02000019 RID: 25
	[Serializable]
	public class TKohonenNeuron : TNeuron
	{
		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600010B RID: 267 RVA: 0x0000643F File Offset: 0x0000543F
		public int Col
		{
			get
			{
				return this.fCol;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00006447 File Offset: 0x00005447
		public int Row
		{
			get
			{
				return this.fRow;
			}
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0000644F File Offset: 0x0000544F
		public TKohonenNeuron()
		{
			this.fWin = 0.0;
			this.fNWins = 0;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0000646D File Offset: 0x0000546D
		public TKohonenNeuron(TKohonenMap Map, int Col, int Row)
		{
			this.fMap = Map;
			this.fCol = Col;
			this.fRow = Row;
			this.fWin = 0.0;
			this.fNWins = 0;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x000064A0 File Offset: 0x000054A0
		public void SetWeightVector(double[] WeightVector)
		{
			for (int i = 0; i < base.GetNWeights(); i++)
			{
				base.GetWeight(i).Weight = WeightVector[i];
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x000064D0 File Offset: 0x000054D0
		public double[] GetWeightVector()
		{
			double[] array = new double[base.GetNWeights()];
			for (int i = 0; i < base.GetNWeights(); i++)
			{
				array[i] = base.GetWeight(i).Weight;
			}
			return array;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0000650A File Offset: 0x0000550A
		public override double Activation(double x)
		{
			return x;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00006510 File Offset: 0x00005510
		public double GetNeighborhoodFunction(TKohonenNeuron Neuron)
		{
			if (Neuron == this)
			{
				return 1.0;
			}
			double distance = this.GetDistance(Neuron);
			double neighborhoodRadius = this.fMap.NeighborhoodRadius;
			switch (this.fMap.Kernel)
			{
			case EKohonenKernel.Bubble:
				if (distance <= neighborhoodRadius)
				{
					return 1.0;
				}
				return 0.0;
			case EKohonenKernel.Gauss:
				return Math.Exp(-distance * distance / (neighborhoodRadius * neighborhoodRadius));
			default:
				return 0.0;
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0000658C File Offset: 0x0000558C
		public double GetDistance(TKohonenNeuron Neuron)
		{
			if (Neuron == this)
			{
				return 0.0;
			}
			return Math.Sqrt((double)((this.fCol - Neuron.Col) * (this.fCol - Neuron.Col) + (this.fRow - Neuron.Row) * (this.fRow - Neuron.Row)));
		}

		// Token: 0x06000114 RID: 276 RVA: 0x000065E4 File Offset: 0x000055E4
		public void Update(TKohonenNeuron Neuron)
		{
			double neighborhoodFunction = this.GetNeighborhoodFunction(Neuron);
			foreach (object obj in this.fWeight)
			{
				TNeuralWeight tneuralWeight = (TNeuralWeight)obj;
				tneuralWeight.Weight += this.fMap.LearningRate * neighborhoodFunction * (tneuralWeight.GetInput() - tneuralWeight.Weight);
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00006668 File Offset: 0x00005668
		public double GetError()
		{
			double num = 0.0;
			foreach (object obj in this.fWeight)
			{
				TNeuralWeight tneuralWeight = (TNeuralWeight)obj;
				num += (tneuralWeight.Weight - tneuralWeight.GetInput()) * (tneuralWeight.Weight - tneuralWeight.GetInput());
			}
			return Math.Sqrt(num);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x000066E8 File Offset: 0x000056E8
		public void ResetWin()
		{
			this.fWin = 0.0;
			this.fNWins = 0;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00006700 File Offset: 0x00005700
		public void SetWin(double Win)
		{
			this.fWin = Win;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00006709 File Offset: 0x00005709
		public void SetNWins(int NWins)
		{
			this.fNWins = NWins;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00006712 File Offset: 0x00005712
		public void AddWin(double Win)
		{
			this.fWin += Win;
			this.fNWins++;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00006730 File Offset: 0x00005730
		public double GetWin()
		{
			return this.fWin;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00006738 File Offset: 0x00005738
		public int GetNWins()
		{
			return this.fNWins;
		}

		// Token: 0x04000086 RID: 134
		private TKohonenMap fMap;

		// Token: 0x04000087 RID: 135
		private int fCol;

		// Token: 0x04000088 RID: 136
		private int fRow;

		// Token: 0x04000089 RID: 137
		private double fWin;

		// Token: 0x0400008A RID: 138
		private int fNWins;
	}
}
