using System;
using System.Collections;
using SmartQuant.Quant;

namespace SmartQuant.Neural
{
	// Token: 0x0200000D RID: 13
	[Serializable]
	public class TNeuralDataSet
	{
		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00003100 File Offset: 0x00002100
		// (set) Token: 0x06000079 RID: 121 RVA: 0x00003108 File Offset: 0x00002108
		public int NInput
		{
			get
			{
				return this.fNInput;
			}
			set
			{
				this.fNInput = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00003111 File Offset: 0x00002111
		// (set) Token: 0x0600007B RID: 123 RVA: 0x00003119 File Offset: 0x00002119
		public int NOutput
		{
			get
			{
				return this.fNOutput;
			}
			set
			{
				this.fNOutput = value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00003122 File Offset: 0x00002122
		// (set) Token: 0x0600007D RID: 125 RVA: 0x0000312A File Offset: 0x0000212A
		public int NData
		{
			get
			{
				return this.fNData;
			}
			set
			{
				this.fNData = value;
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00003134 File Offset: 0x00002134
		private void Init()
		{
			this.fNData = 0;
			this.fNoiseLevel = 0.0;
			this.fData = new ArrayList();
			this.fFirst = -1;
			this.fLast = -1;
			this.fMean = new double[this.fNInput];
			this.fVariance = new double[this.fNInput];
			this.fIsChanged = true;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00003199 File Offset: 0x00002199
		public TNeuralDataSet()
		{
			this.fIsOwner = true;
			this.Init();
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000031AE File Offset: 0x000021AE
		public TNeuralDataSet(int NInput, int NOutput, bool IsOwner)
		{
			this.fNData = 0;
			this.fNInput = NInput;
			this.fNOutput = NOutput;
			this.fIsOwner = IsOwner;
			this.Init();
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000031D8 File Offset: 0x000021D8
		public TNeuralDataSet(int NInput, int NOutput)
		{
			this.fNData = 0;
			this.fNInput = NInput;
			this.fNOutput = NOutput;
			this.fIsOwner = true;
			this.Init();
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00003202 File Offset: 0x00002202
		public void AddData(TNeuralData NeuralData)
		{
			this.fData.Add(NeuralData);
			this.fNData++;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000321F File Offset: 0x0000221F
		public void AddData(int NInput, int NOutput, double[] Input, double[] Output)
		{
			this.AddData(new TNeuralData(NInput, NOutput, Input, Output));
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00003234 File Offset: 0x00002234
		public int GetNData()
		{
			if (this.fIsChanged)
			{
				this.PrepareData();
				this.fIsChanged = false;
			}
			int num;
			if (this.fFirst == -1)
			{
				num = 0;
			}
			else
			{
				num = this.fFirst;
			}
			int num2;
			if (this.fLast == -1)
			{
				num2 = this.fData.Count - 1;
			}
			else
			{
				num2 = this.fLast;
			}
			this.fNData = num2 - num + 1;
			return this.fNData;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000329C File Offset: 0x0000229C
		public TNeuralData GetData(int Seek)
		{
			if (this.fIsChanged)
			{
				this.PrepareData();
				this.fIsChanged = false;
			}
			int num;
			if (this.fFirst == -1)
			{
				num = 0;
			}
			else
			{
				num = this.fFirst;
			}
			int num2;
			if (this.fLast == -1)
			{
				num2 = this.fData.Count - 1;
			}
			else
			{
				num2 = this.fLast;
			}
			int index;
			if (Seek == -1)
			{
				index = num + (int)((double)(num2 - num + 1) * SmartQuant.Quant.Random.Rndm());
			}
			else
			{
				index = num + Seek;
			}
			return (TNeuralData)this.fData[index];
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000331D File Offset: 0x0000231D
		public double[] GetInput(int Seek)
		{
			return this.GetData(Seek).Input;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000332B File Offset: 0x0000232B
		public double[] GetOutput(int Seek)
		{
			return this.GetData(Seek).Output;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00003339 File Offset: 0x00002339
		public TNeuralData GetData()
		{
			return this.GetData(-1);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00003342 File Offset: 0x00002342
		public double[] GetInput()
		{
			return this.GetInput(-1);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000334B File Offset: 0x0000234B
		public double[] GetOutput()
		{
			return this.GetOutput(-1);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00003354 File Offset: 0x00002354
		public void RandomizeInput(int Input, double Min, double Max)
		{
			for (int i = 0; i < this.fData.Count; i++)
			{
				this.GetData(i).RandomizeInput(Input, Min, Max);
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00003388 File Offset: 0x00002388
		public void RandomizeOutput(int Output, double Min, double Max)
		{
			for (int i = 0; i < this.fData.Count; i++)
			{
				this.GetData(i).RandomizeInput(Output, Min, Max);
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x000033BC File Offset: 0x000023BC
		public double GetMean(int Col)
		{
			double num = 0.0;
			int num2 = 0;
			for (int i = 0; i < this.fData.Count; i++)
			{
				num += this.GetData(i).Input[Col];
				num2++;
			}
			num /= (double)num2;
			this.fMean[Col] = num;
			return num;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00003410 File Offset: 0x00002410
		public double GetVariance(int Col)
		{
			double mean = this.GetMean(Col);
			double num = 0.0;
			int num2 = 0;
			for (int i = 0; i < this.fData.Count; i++)
			{
				num += (this.GetData(i).Input[Col] - mean) * (this.GetData(i).Input[Col] - mean);
				num2++;
			}
			num /= (double)(num2 - 1);
			this.fVariance[Col] = num;
			return num;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00003480 File Offset: 0x00002480
		public double GetStandardDeviation(int Col)
		{
			return Math.Sqrt(this.GetVariance(Col));
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00003490 File Offset: 0x00002490
		public void NormalizeInput()
		{
			for (int i = 0; i < this.fData.Count; i++)
			{
				this.GetData(i).NormalizeInput();
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000034C0 File Offset: 0x000024C0
		public void Renormalize()
		{
			for (int i = 0; i < this.fNInput; i++)
			{
				double storedMean = this.GetStoredMean(i);
				double num = Math.Sqrt(this.GetStoredVariance(i));
				for (int j = 0; j < this.fData.Count; j++)
				{
					TNeuralData data = this.GetData(j);
					double num2 = data.Input[i];
					data.Input[i] = num2 * num + storedMean;
				}
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00003530 File Offset: 0x00002530
		public void NormalizeOutput()
		{
			for (int i = 0; i < this.fData.Count; i++)
			{
				this.GetData(i).NormalizeOutput();
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000355F File Offset: 0x0000255F
		public virtual void PrepareData()
		{
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00003561 File Offset: 0x00002561
		public double GetStoredMean(int Col)
		{
			return this.fMean[Col];
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000356B File Offset: 0x0000256B
		public double GetStoredVariance(int Col)
		{
			return this.fVariance[Col];
		}

		// Token: 0x04000046 RID: 70
		protected int fNInput;

		// Token: 0x04000047 RID: 71
		protected int fNOutput;

		// Token: 0x04000048 RID: 72
		protected int fNData;

		// Token: 0x04000049 RID: 73
		protected ArrayList fData;

		// Token: 0x0400004A RID: 74
		protected double fNoiseLevel;

		// Token: 0x0400004B RID: 75
		protected int fFirst;

		// Token: 0x0400004C RID: 76
		protected int fLast;

		// Token: 0x0400004D RID: 77
		protected bool fIsOwner;

		// Token: 0x0400004E RID: 78
		protected bool fIsChanged;

		// Token: 0x0400004F RID: 79
		protected double[] fMean;

		// Token: 0x04000050 RID: 80
		protected double[] fVariance;
	}
}
