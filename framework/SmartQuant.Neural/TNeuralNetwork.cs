using System;
using System.Collections;
using SmartQuant.Quant;

namespace SmartQuant.Neural
{
	// Token: 0x0200000B RID: 11
	[Serializable]
	public class TNeuralNetwork
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00002A52 File Offset: 0x00001A52
		public static TNeuralNetwork Network
		{
			get
			{
				return TNeuralNetwork.fNetwork;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00002A59 File Offset: 0x00001A59
		// (set) Token: 0x0600003A RID: 58 RVA: 0x00002A61 File Offset: 0x00001A61
		public EWeightInitMode InitMode
		{
			get
			{
				return this.fInitMode;
			}
			set
			{
				this.fInitMode = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00002A6A File Offset: 0x00001A6A
		// (set) Token: 0x0600003C RID: 60 RVA: 0x00002A72 File Offset: 0x00001A72
		public ELearningMethod LearningMethod
		{
			get
			{
				return this.fLearningMethod;
			}
			set
			{
				this.fLearningMethod = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00002A7B File Offset: 0x00001A7B
		// (set) Token: 0x0600003E RID: 62 RVA: 0x00002A83 File Offset: 0x00001A83
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

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00002A8C File Offset: 0x00001A8C
		// (set) Token: 0x06000040 RID: 64 RVA: 0x00002A94 File Offset: 0x00001A94
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

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00002A9D File Offset: 0x00001A9D
		// (set) Token: 0x06000042 RID: 66 RVA: 0x00002AA5 File Offset: 0x00001AA5
		public double[] Target
		{
			get
			{
				return this.fTarget;
			}
			set
			{
				this.fTarget = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00002AAE File Offset: 0x00001AAE
		// (set) Token: 0x06000044 RID: 68 RVA: 0x00002AB6 File Offset: 0x00001AB6
		public int NBatch
		{
			get
			{
				return this.fNBatch;
			}
			set
			{
				this.fNBatch = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00002ABF File Offset: 0x00001ABF
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00002AC7 File Offset: 0x00001AC7
		public int NPattern
		{
			get
			{
				return this.fNPattern;
			}
			set
			{
				this.fNPattern = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00002AD0 File Offset: 0x00001AD0
		// (set) Token: 0x06000048 RID: 72 RVA: 0x00002AD8 File Offset: 0x00001AD8
		public double LearningRate
		{
			get
			{
				return this.fLearningRate;
			}
			set
			{
				this.fLearningRate = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00002AE1 File Offset: 0x00001AE1
		// (set) Token: 0x0600004A RID: 74 RVA: 0x00002AE9 File Offset: 0x00001AE9
		public double Momentum
		{
			get
			{
				return this.fMomentum;
			}
			set
			{
				this.fMomentum = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00002AF2 File Offset: 0x00001AF2
		// (set) Token: 0x0600004C RID: 76 RVA: 0x00002AFA File Offset: 0x00001AFA
		public double WeightDecay
		{
			get
			{
				return this.fWeightDecay;
			}
			set
			{
				this.fWeightDecay = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00002B03 File Offset: 0x00001B03
		// (set) Token: 0x0600004E RID: 78 RVA: 0x00002B0B File Offset: 0x00001B0B
		public double MaximumGrowth
		{
			get
			{
				return this.fMaximumGrowth;
			}
			set
			{
				this.fMaximumGrowth = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00002B14 File Offset: 0x00001B14
		// (set) Token: 0x06000050 RID: 80 RVA: 0x00002B1C File Offset: 0x00001B1C
		public double RpropDeltaInit
		{
			get
			{
				return this.fRpropDeltaInit;
			}
			set
			{
				this.fRpropDeltaInit = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00002B25 File Offset: 0x00001B25
		// (set) Token: 0x06000052 RID: 82 RVA: 0x00002B2D File Offset: 0x00001B2D
		public double RpropDeltaMin
		{
			get
			{
				return this.fRpropDeltaMin;
			}
			set
			{
				this.fRpropDeltaMin = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00002B36 File Offset: 0x00001B36
		// (set) Token: 0x06000054 RID: 84 RVA: 0x00002B3E File Offset: 0x00001B3E
		public double RpropDeltaMax
		{
			get
			{
				return this.fRpropDeltaMax;
			}
			set
			{
				this.fRpropDeltaMax = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00002B47 File Offset: 0x00001B47
		// (set) Token: 0x06000056 RID: 86 RVA: 0x00002B4F File Offset: 0x00001B4F
		public double RpropDecrease
		{
			get
			{
				return this.fRpropDecrease;
			}
			set
			{
				this.fRpropDecrease = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00002B58 File Offset: 0x00001B58
		// (set) Token: 0x06000058 RID: 88 RVA: 0x00002B60 File Offset: 0x00001B60
		public double RpropIncrease
		{
			get
			{
				return this.fRpropIncrease;
			}
			set
			{
				this.fRpropIncrease = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00002B69 File Offset: 0x00001B69
		// (set) Token: 0x0600005A RID: 90 RVA: 0x00002B71 File Offset: 0x00001B71
		public TNeuralLayer InputLayer
		{
			get
			{
				return this.fInputLayer;
			}
			set
			{
				this.fInputLayer = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00002B7A File Offset: 0x00001B7A
		// (set) Token: 0x0600005C RID: 92 RVA: 0x00002B82 File Offset: 0x00001B82
		public TNeuralLayer OutputLayer
		{
			get
			{
				return this.fOutputLayer;
			}
			set
			{
				this.fOutputLayer = value;
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002B8C File Offset: 0x00001B8C
		private void Init()
		{
			this.fNeuron = new ArrayList();
			this.fWeight = new ArrayList();
			this.fLearningRate = 0.01;
			this.fMomentum = 0.01;
			this.fMaximumGrowth = 1.75;
			this.fWeightDecay = 0.0;
			this.fRpropDeltaInit = 0.1;
			this.fRpropDeltaMin = 1E-06;
			this.fRpropDeltaMax = 50.0;
			this.fRpropDecrease = 0.5;
			this.fRpropIncrease = 1.2;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002C36 File Offset: 0x00001C36
		public TNeuralNetwork()
		{
			this.fNInput = 0;
			this.fNOutput = 0;
			this.Init();
			TNeuralNetwork.fNetwork = this;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002C58 File Offset: 0x00001C58
		public TNeuralNetwork(string Name, string Title)
		{
			this.fName = Name;
			this.fTitle = Title;
			this.fNInput = 0;
			this.fNOutput = 0;
			this.Init();
			TNeuralNetwork.fNetwork = this;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002C88 File Offset: 0x00001C88
		public TNeuralNetwork(string Name)
		{
			this.fName = Name;
			this.fNInput = 0;
			this.fNOutput = 0;
			this.Init();
			TNeuralNetwork.fNetwork = this;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002CB4 File Offset: 0x00001CB4
		public void AddNeuron(TNeuron Neuron)
		{
			int num = Neuron.ID;
			if (num == -1)
			{
				num = this.fNeuron.Add(Neuron);
				Neuron.ID = num;
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002CE0 File Offset: 0x00001CE0
		public void AddWeight(TNeuralWeight Weight)
		{
			if (this.fWeight.IndexOf(Weight) != -1)
			{
				this.fWeight.Add(Weight);
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002CFE File Offset: 0x00001CFE
		public virtual void Reset()
		{
			this.ResetWeights();
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002D06 File Offset: 0x00001D06
		public void ResetWeights()
		{
			this.RandomizeWeights();
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002D10 File Offset: 0x00001D10
		public void RandomizeWeights(int Option)
		{
			if (Option != 0)
			{
				SmartQuant.Quant.Random.Seed1 = this.fSeed1;
				SmartQuant.Quant.Random.Seed2 = this.fSeed2;
			}
			else
			{
				this.fSeed1 = SmartQuant.Quant.Random.Seed1;
				this.fSeed2 = SmartQuant.Quant.Random.Seed2;
			}
			foreach (object obj in this.fNeuron)
			{
				TNeuron tneuron = (TNeuron)obj;
				tneuron.RandomizeWeights();
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002D9C File Offset: 0x00001D9C
		public void RandomizeWeights()
		{
			this.RandomizeWeights(0);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002DA8 File Offset: 0x00001DA8
		public void StoreWeights()
		{
			foreach (object obj in this.fNeuron)
			{
				TNeuron tneuron = (TNeuron)obj;
				tneuron.StoreWeights();
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002E00 File Offset: 0x00001E00
		public void RestoreWeights()
		{
			foreach (object obj in this.fNeuron)
			{
				TNeuron tneuron = (TNeuron)obj;
				tneuron.RestoreWeights();
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002E58 File Offset: 0x00001E58
		public TNeuralWeight GetMinWeight()
		{
			if (this.fMinChanged)
			{
				double num = 10000000000.0;
				foreach (object obj in this.fNeuron)
				{
					TNeuron tneuron = (TNeuron)obj;
					TNeuralWeight minWeight = tneuron.GetMinWeight();
					if (minWeight != null && minWeight.Weight < num)
					{
						this.fMinWeightNeuron = tneuron;
						this.fMinWeight = minWeight;
						num = minWeight.Weight;
					}
				}
				this.fMinChanged = false;
			}
			return this.fMinWeight;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002EF4 File Offset: 0x00001EF4
		public TNeuralWeight GetMaxWeight()
		{
			if (this.fMaxChanged)
			{
				double num = -10000000000.0;
				foreach (object obj in this.fNeuron)
				{
					TNeuron tneuron = (TNeuron)obj;
					TNeuralWeight maxWeight = tneuron.GetMaxWeight();
					if (maxWeight != null && maxWeight.Weight > num)
					{
						this.fMaxWeightNeuron = tneuron;
						this.fMaxWeight = maxWeight;
						num = maxWeight.Weight;
					}
				}
				this.fMaxChanged = false;
			}
			return this.fMaxWeight;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002F90 File Offset: 0x00001F90
		public TNeuron GetMinWeightNeuron()
		{
			this.GetMinWeight();
			return this.fMinWeightNeuron;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002F9F File Offset: 0x00001F9F
		public TNeuron GetMaxWeightNeuron()
		{
			this.GetMaxWeight();
			return this.fMaxWeightNeuron;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002FB0 File Offset: 0x00001FB0
		public void Prune()
		{
			TNeuralWeight minWeight = this.GetMinWeight();
			this.fMinWeightNeuron.Disconnect(minWeight.Neuron);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002FD5 File Offset: 0x00001FD5
		public void Connect(TNeuralNetwork Network)
		{
			this.fInputLayer.Connect(Network.OutputLayer);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002FE8 File Offset: 0x00001FE8
		public void cd()
		{
			TNeuralNetwork.fNetwork = this;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002FF0 File Offset: 0x00001FF0
		public void SetStopping(EStoppingMethod SCriterion, double SParameter)
		{
			this.fSMethod = SCriterion;
			this.fSParameter = SParameter;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00003000 File Offset: 0x00002000
		public virtual void Update(int Param)
		{
			this.fMinChanged = true;
			this.fMaxChanged = true;
		}

		// Token: 0x0400001C RID: 28
		protected string fName;

		// Token: 0x0400001D RID: 29
		protected string fTitle;

		// Token: 0x0400001E RID: 30
		protected int fNInput;

		// Token: 0x0400001F RID: 31
		protected int fNOutput;

		// Token: 0x04000020 RID: 32
		protected bool fIsEnabled;

		// Token: 0x04000021 RID: 33
		protected ELearningMethod fLearningMethod;

		// Token: 0x04000022 RID: 34
		protected int fNBatch;

		// Token: 0x04000023 RID: 35
		protected int fNPattern;

		// Token: 0x04000024 RID: 36
		protected EWeightInitMode fInitMode;

		// Token: 0x04000025 RID: 37
		protected bool fDebugMode;

		// Token: 0x04000026 RID: 38
		protected EStoppingMethod fSMethod;

		// Token: 0x04000027 RID: 39
		protected double fSParameter;

		// Token: 0x04000028 RID: 40
		protected int fNGraphUpdate;

		// Token: 0x04000029 RID: 41
		protected int fMaxNX;

		// Token: 0x0400002A RID: 42
		protected int fMaxNY;

		// Token: 0x0400002B RID: 43
		private double fSeed1;

		// Token: 0x0400002C RID: 44
		private double fSeed2;

		// Token: 0x0400002D RID: 45
		private TNeuralWeight fMinWeight;

		// Token: 0x0400002E RID: 46
		private TNeuralWeight fMaxWeight;

		// Token: 0x0400002F RID: 47
		private TNeuron fMinWeightNeuron;

		// Token: 0x04000030 RID: 48
		private TNeuron fMaxWeightNeuron;

		// Token: 0x04000031 RID: 49
		private bool fMinChanged;

		// Token: 0x04000032 RID: 50
		private bool fMaxChanged;

		// Token: 0x04000033 RID: 51
		protected EViewMode fViewMode;

		// Token: 0x04000034 RID: 52
		protected double[] fInput;

		// Token: 0x04000035 RID: 53
		protected double[] fOutput;

		// Token: 0x04000036 RID: 54
		protected double[] fTarget;

		// Token: 0x04000037 RID: 55
		protected ArrayList fNeuron;

		// Token: 0x04000038 RID: 56
		protected ArrayList fWeight;

		// Token: 0x04000039 RID: 57
		protected TNeuralLayer fInputLayer;

		// Token: 0x0400003A RID: 58
		protected TNeuralLayer fOutputLayer;

		// Token: 0x0400003B RID: 59
		private static TNeuralNetwork fNetwork;

		// Token: 0x0400003C RID: 60
		protected double fLearningRate;

		// Token: 0x0400003D RID: 61
		protected double fMomentum;

		// Token: 0x0400003E RID: 62
		protected double fWeightDecay;

		// Token: 0x0400003F RID: 63
		protected double fMaximumGrowth;

		// Token: 0x04000040 RID: 64
		protected double fRpropDeltaInit;

		// Token: 0x04000041 RID: 65
		protected double fRpropDeltaMin;

		// Token: 0x04000042 RID: 66
		protected double fRpropDeltaMax;

		// Token: 0x04000043 RID: 67
		protected double fRpropDecrease;

		// Token: 0x04000044 RID: 68
		protected double fRpropIncrease;
	}
}
