using System;
using SmartQuant.Quant;

namespace SmartQuant.Neural
{
	// Token: 0x0200000F RID: 15
	[Serializable]
	public class TNeuralData
	{
		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00004461 File Offset: 0x00003461
		// (set) Token: 0x06000099 RID: 153 RVA: 0x00004469 File Offset: 0x00003469
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

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00004472 File Offset: 0x00003472
		// (set) Token: 0x0600009B RID: 155 RVA: 0x0000447A File Offset: 0x0000347A
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

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00004483 File Offset: 0x00003483
		// (set) Token: 0x0600009D RID: 157 RVA: 0x0000448B File Offset: 0x0000348B
		public double[] Input
		{
			get
			{
				return this.fInput;
			}
			set
			{
				this.fInput = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00004494 File Offset: 0x00003494
		// (set) Token: 0x0600009F RID: 159 RVA: 0x0000449C File Offset: 0x0000349C
		public double[] Output
		{
			get
			{
				return this.fOutput;
			}
			set
			{
				this.fOutput = value;
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000044A5 File Offset: 0x000034A5
		public TNeuralData()
		{
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000044B0 File Offset: 0x000034B0
		public TNeuralData(TNeuralData Data)
		{
			this.fNInput = Data.fNInput;
			this.fNOutput = Data.fNInput;
			if (this.fNInput != 0)
			{
				this.fInput = new double[this.fNInput];
			}
			else
			{
				this.fInput = null;
			}
			if (this.fNOutput != 0)
			{
				this.fOutput = new double[this.fNOutput];
			}
			else
			{
				this.fOutput = null;
			}
			for (int i = 0; i < this.fNInput; i++)
			{
				this.fInput[i] = Data.fInput[i];
			}
			for (int j = 0; j < this.fNOutput; j++)
			{
				this.fOutput[j] = Data.fOutput[j];
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00004564 File Offset: 0x00003564
		public TNeuralData(int NInput, int NOutput)
		{
			this.fNInput = NInput;
			this.fNOutput = NOutput;
			if (NInput != 0)
			{
				this.fInput = new double[NInput];
			}
			else
			{
				this.fInput = null;
			}
			if (NOutput != 0)
			{
				this.fOutput = new double[NOutput];
				return;
			}
			this.fOutput = null;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000045B4 File Offset: 0x000035B4
		public TNeuralData(int NInput, int NOutput, double[] Input, double[] Output, bool Copy)
		{
			this.fNInput = NInput;
			this.fNOutput = NOutput;
			if (Copy)
			{
				this.fInput = new double[NInput];
				this.fOutput = new double[NOutput];
				for (int i = 0; i < NInput; i++)
				{
					this.fInput[i] = Input[i];
				}
				for (int j = 0; j < NOutput; j++)
				{
					this.fOutput[j] = Output[j];
				}
				return;
			}
			this.fInput = Input;
			this.fOutput = Output;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00004630 File Offset: 0x00003630
		public TNeuralData(int NInput, int NOutput, double[] Input, double[] Output)
		{
			this.fNInput = NInput;
			this.fNOutput = NOutput;
			this.fInput = new double[NInput];
			this.fOutput = new double[NOutput];
			for (int i = 0; i < NInput; i++)
			{
				this.fInput[i] = Input[i];
			}
			for (int j = 0; j < NOutput; j++)
			{
				this.fOutput[j] = Output[j];
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00004698 File Offset: 0x00003698
		public void SetInput(int i, double Input)
		{
			this.fInput[i] = Input;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000046A3 File Offset: 0x000036A3
		public void SetOutput(int i, double Output)
		{
			this.fOutput[i] = Output;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000046B0 File Offset: 0x000036B0
		public void RandomizeInput(int Input, double Min, double Max)
		{
			if (Input == -1)
			{
				for (int i = 0; i < this.fNInput; i++)
				{
					this.RandomizeInput(i, Min, Max);
				}
				return;
			}
			this.fInput[Input] = Min + SmartQuant.Quant.Random.Rndm() * (Max - Min);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000046F0 File Offset: 0x000036F0
		public void RandomizeOutput(int Output, double Min, double Max)
		{
			if (Output == -1)
			{
				for (int i = 0; i < this.fNOutput; i++)
				{
					this.RandomizeInput(i, Min, Max);
				}
				return;
			}
			this.fOutput[Output] = Min + SmartQuant.Quant.Random.Rndm() * (Max - Min);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00004730 File Offset: 0x00003730
		public void NormalizeInput()
		{
			double num = 0.0;
			for (int i = 0; i < this.fNInput; i++)
			{
				num += this.fInput[i] * this.fInput[i];
			}
			num = Math.Sqrt(num);
			for (int j = 0; j < this.fNInput; j++)
			{
				this.fInput[j] /= num;
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000047A0 File Offset: 0x000037A0
		public void NormalizeOutput()
		{
			double num = 0.0;
			for (int i = 0; i < this.fNOutput; i++)
			{
				num += this.fOutput[i] * this.fOutput[i];
			}
			num = Math.Sqrt(num);
			for (int j = 0; j < this.fNOutput; j++)
			{
				this.fOutput[j] /= num;
			}
		}

		// Token: 0x04000053 RID: 83
		private int fNInput;

		// Token: 0x04000054 RID: 84
		private int fNOutput;

		// Token: 0x04000055 RID: 85
		private double[] fInput;

		// Token: 0x04000056 RID: 86
		private double[] fOutput;
	}
}
