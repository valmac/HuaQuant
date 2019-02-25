using System;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using SmartQuant.Quant;

namespace SmartQuant.Optimization
{
	// Token: 0x02000006 RID: 6
	public class SimulatedAnnealing : Optimizer
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00002DA7 File Offset: 0x00001DA7
		[Browsable(false)]
		public double Temperature
		{
			get
			{
				return this.fTemperature;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00002DAF File Offset: 0x00001DAF
		// (set) Token: 0x06000050 RID: 80 RVA: 0x00002DB7 File Offset: 0x00001DB7
		[Category("Temperature")]
		[Description("Start temperature in the annealing schedule")]
		public double StartTemperature
		{
			get
			{
				return this.fStartTemperature;
			}
			set
			{
				this.fStartTemperature = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00002DC0 File Offset: 0x00001DC0
		// (set) Token: 0x06000052 RID: 82 RVA: 0x00002DC8 File Offset: 0x00001DC8
		[Category("Temperature")]
		[Description("Stop temperature in the annealing schedule")]
		public double StopTemperature
		{
			get
			{
				return this.fStopTemperature;
			}
			set
			{
				this.fStopTemperature = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00002DD1 File Offset: 0x00001DD1
		// (set) Token: 0x06000054 RID: 84 RVA: 0x00002DD9 File Offset: 0x00001DD9
		[Category("Temperature")]
		[Description("Temperature reduction factor")]
		public double TemperatureReductionFactor
		{
			get
			{
				return this.fTemperatureReductionFactor;
			}
			set
			{
				this.fTemperatureReductionFactor = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00002DE2 File Offset: 0x00001DE2
		// (set) Token: 0x06000056 RID: 86 RVA: 0x00002DEA File Offset: 0x00001DEA
		[Description("Number of steps (tries) per on circle of temperature reduction")]
		[Category("Temperature")]
		public int NTemperatureReductionSteps
		{
			get
			{
				return this.fNTemperatureReductionSteps;
			}
			set
			{
				this.fNTemperatureReductionSteps = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00002DF3 File Offset: 0x00001DF3
		[Browsable(false)]
		public double DisplacementTemperature
		{
			get
			{
				return this.fDisplacementTemperature;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00002DFB File Offset: 0x00001DFB
		// (set) Token: 0x06000059 RID: 89 RVA: 0x00002E03 File Offset: 0x00001E03
		[Description("Displacement start temperature in the annealing schedule")]
		[Category("Displacement")]
		public double DisplacementStartTemperature
		{
			get
			{
				return this.fDisplacementStartTemperature;
			}
			set
			{
				this.fDisplacementStartTemperature = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00002E0C File Offset: 0x00001E0C
		// (set) Token: 0x0600005B RID: 91 RVA: 0x00002E14 File Offset: 0x00001E14
		[Category("Displacement")]
		[Description("Displacement temperature reduction factor")]
		public double DisplacementTemperatureReductionFactor
		{
			get
			{
				return this.fDisplacementTemperatureReductionFactor;
			}
			set
			{
				this.fDisplacementTemperatureReductionFactor = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00002E1D File Offset: 0x00001E1D
		// (set) Token: 0x0600005D RID: 93 RVA: 0x00002E25 File Offset: 0x00001E25
		[Description("Displacement distribution parameter")]
		[Category("Displacement")]
		public double DisplacementDistributionParam
		{
			get
			{
				return this.fDisplacementDistributionParam;
			}
			set
			{
				this.fDisplacementDistributionParam = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00002E2E File Offset: 0x00001E2E
		// (set) Token: 0x0600005F RID: 95 RVA: 0x00002E36 File Offset: 0x00001E36
		[Description("Acceptance probability parameter")]
		[Category("Acceptance")]
		public double AcceptanceProbabilityParam
		{
			get
			{
				return this.fAcceptanceProbabilityParam;
			}
			set
			{
				this.fAcceptanceProbabilityParam = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00002E3F File Offset: 0x00001E3F
		// (set) Token: 0x06000061 RID: 97 RVA: 0x00002E47 File Offset: 0x00001E47
		[Description("Error tolerance")]
		[Category("Stopping Criterion")]
		public double ErrorTolerance
		{
			get
			{
				return this.fErrorTolerance;
			}
			set
			{
				this.fErrorTolerance = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00002E50 File Offset: 0x00001E50
		// (set) Token: 0x06000063 RID: 99 RVA: 0x00002E58 File Offset: 0x00001E58
		[Description("Maximum number of objective function calls")]
		[Category("Stopping Criterion")]
		public int MaxObjectiveCalls
		{
			get
			{
				return this.fMaxObjectiveCalls;
			}
			set
			{
				this.fMaxObjectiveCalls = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00002E61 File Offset: 0x00001E61
		// (set) Token: 0x06000065 RID: 101 RVA: 0x00002E69 File Offset: 0x00001E69
		[Description("Minimum number of accepted uphill jumps")]
		[Category("Stopping Criterion")]
		public int MinAcceptedUphills
		{
			get
			{
				return this.fMinAcceptedUphills;
			}
			set
			{
				this.fMinAcceptedUphills = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00002E72 File Offset: 0x00001E72
		// (set) Token: 0x06000067 RID: 103 RVA: 0x00002E7A File Offset: 0x00001E7A
		[Category("Stopping Criterion")]
		[Description("Stop temperature stopping criterion")]
		public bool IsStopTemperatureCriterion
		{
			get
			{
				return this.fIsStopTemperatureCriterion;
			}
			set
			{
				this.fIsStopTemperatureCriterion = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00002E83 File Offset: 0x00001E83
		// (set) Token: 0x06000069 RID: 105 RVA: 0x00002E8B File Offset: 0x00001E8B
		[Category("Stopping Criterion")]
		[Description("Number of objective calls stopping criterion")]
		public bool IsObjectiveCallsCriterion
		{
			get
			{
				return this.fIsObjectiveCallsCriterion;
			}
			set
			{
				this.fIsObjectiveCallsCriterion = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00002E94 File Offset: 0x00001E94
		// (set) Token: 0x0600006B RID: 107 RVA: 0x00002E9C File Offset: 0x00001E9C
		[Description("Error tolerance stopping criterion")]
		[Category("Stopping Criterion")]
		public bool IsErrorToleranceCriterion
		{
			get
			{
				return this.fIsErrorToleranceCriterion;
			}
			set
			{
				this.fIsErrorToleranceCriterion = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00002EA5 File Offset: 0x00001EA5
		// (set) Token: 0x0600006D RID: 109 RVA: 0x00002EAD File Offset: 0x00001EAD
		[Category("Stopping Criterion")]
		[Description("Number of accepted uphills stopping criterion")]
		public bool IsAcceptedUphillsCriterion
		{
			get
			{
				return this.fIsAcceptedUphillsCriterion;
			}
			set
			{
				this.fIsAcceptedUphillsCriterion = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00002EB6 File Offset: 0x00001EB6
		// (set) Token: 0x0600006F RID: 111 RVA: 0x00002EBE File Offset: 0x00001EBE
		[Description("Number of accepted downhill jumps stopping criterion")]
		[Category("Stopping Criterion")]
		public bool IsAcceptedDownhillsCriterion
		{
			get
			{
				return this.fIsAcceptedDownhillsCriterion;
			}
			set
			{
				this.fIsAcceptedDownhillsCriterion = value;
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002EC8 File Offset: 0x00001EC8
		private void Init()
		{
			this.fStartTemperature = 0.1;
			this.fStopTemperature = 0.005;
			this.fTemperatureReductionFactor = 0.55;
			this.fDisplacementStartTemperature = 1.0;
			this.fDisplacementTemperatureReductionFactor = 0.95;
			this.fDisplacementDistributionParam = 2.0;
			this.fAcceptanceProbabilityParam = 1.1;
			this.fErrorTolerance = 1E-05;
			this.fMaxObjectiveCalls = 10000000;
			this.fMinAcceptedUphills = 0;
			this.fNTemperatureReductionSteps = 20;
			this.fIsStopTemperatureCriterion = true;
			this.fIsObjectiveCallsCriterion = false;
			this.fIsErrorToleranceCriterion = false;
			this.fIsAcceptedUphillsCriterion = false;
			this.fIsAcceptedDownhillsCriterion = false;
			this.fType = EOptimizerType.SimulatedAnnealing;
			this.fVerboseMode = EVerboseMode.Quiet;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002F98 File Offset: 0x00001F98
		public SimulatedAnnealing(IOptimizable Optimizable) : base(Optimizable)
		{
			this.Init();
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002FA8 File Offset: 0x00001FA8
		public void SetScheme(ESimulatedAnnealingScheme Scheme)
		{
			switch (Scheme)
			{
			case ESimulatedAnnealingScheme.Portfolio:
				this.DisableStoppingCriterion(EStoppingCriterion.All);
				this.EnableStoppingCriterion(EStoppingCriterion.StopTemperature, true);
				this.fNTemperatureReductionSteps = 250;
				this.fTemperatureReductionFactor = 0.1;
				this.fAcceptanceProbabilityParam = -20.0;
				this.fDisplacementStartTemperature = 1.0;
				this.fDisplacementTemperatureReductionFactor = 0.85;
				this.fStartTemperature = 100.0;
				this.fStopTemperature = 0.0001;
				return;
			case ESimulatedAnnealingScheme.EfficientFrontier:
				this.DisableStoppingCriterion(EStoppingCriterion.All);
				this.EnableStoppingCriterion(EStoppingCriterion.StopTemperature, true);
				this.fNTemperatureReductionSteps = 25;
				this.fTemperatureReductionFactor = 0.5;
				this.fAcceptanceProbabilityParam = -20.0;
				this.fDisplacementStartTemperature = 1.0;
				this.fDisplacementTemperatureReductionFactor = 0.85;
				this.fStartTemperature = 0.001;
				this.fStopTemperature = 1E-06;
				return;
			case ESimulatedAnnealingScheme.Perceptron:
				this.DisableStoppingCriterion(EStoppingCriterion.All);
				this.EnableStoppingCriterion(EStoppingCriterion.StopTemperature, true);
				this.fNTemperatureReductionSteps = 25;
				this.fTemperatureReductionFactor = 0.5;
				this.fAcceptanceProbabilityParam = -20.0;
				this.fDisplacementStartTemperature = 1.0;
				this.fDisplacementTemperatureReductionFactor = 0.85;
				this.fStartTemperature = 0.001;
				this.fStopTemperature = 1E-06;
				return;
			default:
				return;
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00003124 File Offset: 0x00002124
		public void EnableStoppingCriterion(EStoppingCriterion Criterion, bool Enable)
		{
			switch (Criterion)
			{
			case EStoppingCriterion.All:
				this.fIsObjectiveCallsCriterion = Enable;
				this.fIsErrorToleranceCriterion = Enable;
				this.fIsStopTemperatureCriterion = Enable;
				this.fIsAcceptedUphillsCriterion = Enable;
				this.fIsAcceptedDownhillsCriterion = Enable;
				return;
			case EStoppingCriterion.ObjectiveCalls:
				this.fIsObjectiveCallsCriterion = Enable;
				return;
			case EStoppingCriterion.ErrorTolerance:
				this.fIsErrorToleranceCriterion = Enable;
				return;
			case EStoppingCriterion.StopTemperature:
				this.fIsStopTemperatureCriterion = Enable;
				return;
			case EStoppingCriterion.AcceptedUphills:
				this.fIsAcceptedUphillsCriterion = Enable;
				return;
			case EStoppingCriterion.AcceptedDownhills:
				this.fIsAcceptedDownhillsCriterion = Enable;
				return;
			default:
				return;
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000031A0 File Offset: 0x000021A0
		public bool IsStoppingCriterionEnabled(EStoppingCriterion Criterion)
		{
			bool result = false;
			switch (Criterion)
			{
			case EStoppingCriterion.ObjectiveCalls:
				result = this.fIsObjectiveCallsCriterion;
				break;
			case EStoppingCriterion.ErrorTolerance:
				result = this.fIsErrorToleranceCriterion;
				break;
			case EStoppingCriterion.StopTemperature:
				result = this.fIsStopTemperatureCriterion;
				break;
			case EStoppingCriterion.AcceptedUphills:
				result = this.fIsAcceptedUphillsCriterion;
				break;
			case EStoppingCriterion.AcceptedDownhills:
				result = this.fIsAcceptedDownhillsCriterion;
				break;
			}
			return result;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000031FC File Offset: 0x000021FC
		public void DisableStoppingCriterion(EStoppingCriterion Criterion)
		{
			switch (Criterion)
			{
			case EStoppingCriterion.All:
				this.fIsObjectiveCallsCriterion = false;
				this.fIsErrorToleranceCriterion = false;
				this.fIsStopTemperatureCriterion = false;
				this.fIsAcceptedUphillsCriterion = false;
				this.fIsAcceptedDownhillsCriterion = false;
				return;
			case EStoppingCriterion.ObjectiveCalls:
				this.fIsObjectiveCallsCriterion = false;
				return;
			case EStoppingCriterion.ErrorTolerance:
				this.fIsErrorToleranceCriterion = false;
				return;
			case EStoppingCriterion.StopTemperature:
				this.fIsStopTemperatureCriterion = false;
				return;
			case EStoppingCriterion.AcceptedUphills:
				this.fIsAcceptedUphillsCriterion = false;
				return;
			case EStoppingCriterion.AcceptedDownhills:
				this.fIsAcceptedDownhillsCriterion = false;
				return;
			default:
				return;
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00003278 File Offset: 0x00002278
		protected double GetDisplacementDistribution(double dx)
		{
			double x = this.fDisplacementTemperature;
			double num = (double)this.fNParam;
			double num2 = this.fDisplacementDistributionParam;
			return Math.Pow(x, -num / (3.0 - num2)) / Math.Pow(1.0 + (num2 - 1.0) * Math.Pow(dx, 2.0) / Math.Pow(x, 2.0 / (3.0 - num2)), 1.0 / (num2 - 1.0) + (num - 1.0) / 2.0);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00003324 File Offset: 0x00002324
		protected double GetDisplacement(double MinDisplacement, double MaxDisplacement)
		{
			if (MinDisplacement < -20.0 * this.fDisplacementTemperature)
			{
				MinDisplacement = -20.0 * this.fDisplacementTemperature;
			}
			if (MaxDisplacement > 20.0 * this.fDisplacementTemperature)
			{
				MaxDisplacement = 20.0 * this.fDisplacementTemperature;
			}
			double displacementDistribution = this.GetDisplacementDistribution(0.0);
			double num;
			do
			{
				num = MinDisplacement + (MaxDisplacement - MinDisplacement) * SmartQuant.Quant.Random.Rndm();
			}
			while (displacementDistribution * SmartQuant.Quant.Random.Rndm() > this.GetDisplacementDistribution(num));
			return num;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000033B4 File Offset: 0x000023B4
		protected double GetNextTemperature()
		{
			return this.fStartTemperature * (Math.Pow(2.0, this.fDisplacementDistributionParam - 1.0) - 1.0) / (Math.Pow((double)(this.fNTemperatureReductions + 1), this.fDisplacementDistributionParam - 1.0) - 1.0);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000341C File Offset: 0x0000241C
		protected double GetNextDisplacementTemperature()
		{
			return this.fDisplacementStartTemperature * (Math.Pow(2.0, this.fDisplacementDistributionParam - 1.0) - 1.0) / (Math.Pow((double)(this.fNTemperatureReductions + 1), this.fDisplacementDistributionParam - 1.0) - 1.0);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00003484 File Offset: 0x00002484
		protected double GetAcceptanceProbability(double dE)
		{
			double num = 1.0 + (this.fAcceptanceProbabilityParam - 1.0) * dE / this.fTemperature;
			if (num > 0.0)
			{
				num = Math.Pow(num, 1.0 / (1.0 - this.fAcceptanceProbabilityParam));
			}
			else
			{
				num = 0.0;
			}
			return Math.Min(1.0, num);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00003500 File Offset: 0x00002500
		public void Step()
		{
			Application.DoEvents();
			this.fNIterations++;
			this.fIsNewParam = false;
			for (int i = 0; i < this.fNParam; i++)
			{
				this.fTempSubsetParam[i] = this.fSubsetParam[i];
			}
			for (int j = 0; j < this.fNParamSubset; j++)
			{
				this.fTempSubsetIndex[j] = this.fSubsetIndex[j];
			}
			bool flag;
			do
			{
				int num = (int)((double)this.fNParamSubset * SmartQuant.Quant.Random.Rndm());
				int num2 = this.fSubsetIndex[num];
				flag = (base.GetParamType(num2) == EParamType.Float);
				if (!base.IsParamFixed(num2))
				{
					double minDisplacement = this.fLowerBound[num2] - this.fSubsetParam[num2];
					double maxDisplacement = this.fUpperBound[num2] - this.fSubsetParam[num2];
					this.fSubsetParam[num2] += this.GetDisplacement(minDisplacement, maxDisplacement);
					if (this.fNParamSubset != 0)
					{
						this.fSubsetParam[num2] = this.fLowerBound[num2] + (this.fUpperBound[num2] - this.fLowerBound[num2]) * SmartQuant.Quant.Random.Rndm();
						if (this.fNParamSubset < this.fNParam)
						{
							this.fIsNewParam = true;
							int num3;
							do
							{
								this.fIsParamAccepted = true;
								num3 = (int)((double)this.fNParam * SmartQuant.Quant.Random.Rndm());
								for (int k = 0; k < this.fNParamSubset; k++)
								{
									if (num3 == this.fSubsetIndex[k])
									{
										this.fIsParamAccepted = false;
									}
								}
							}
							while (!this.fIsParamAccepted);
							this.fSubsetIndex[num] = num3;
						}
					}
					else if (this.fSubsetParam[num2] > this.fUpperBound[num2])
					{
						this.fSubsetParam[num2] = this.fUpperBound[num2];
					}
					this.fIsParamAccepted = true;
					for (int l = 0; l < this.fNParam; l++)
					{
						this.fParam[l] = 0.0;
					}
					for (int m = 0; m < this.fNParamSubset; m++)
					{
						this.fParam[this.fSubsetIndex[m]] = this.fSubsetParam[this.fSubsetIndex[m]];
					}
					for (int n = 0; n < this.fNParamSubset; n++)
					{
						if (this.fParam[this.fSubsetIndex[n]] < this.fLowerBound[this.fSubsetIndex[n]] || this.fParam[this.fSubsetIndex[n]] > this.fUpperBound[this.fSubsetIndex[n]])
						{
							this.fIsParamAccepted = false;
							for (n = 0; n < this.fNParam; n++)
							{
								this.fSubsetParam[n] = this.fTempSubsetParam[n];
							}
							for (n = 0; n < this.fNParamSubset; n++)
							{
								this.fSubsetIndex[n] = this.fTempSubsetIndex[n];
							}
						}
					}
				}
			}
			while (!this.fIsParamAccepted);
			this.Update();
			if (this.fIsParamAccepted)
			{
				string key = this.FormatParamsHashCode();
				if (flag)
				{
					this.paramsSetList.Remove(key);
					this.fNewEnergy = this.Objective();
					this.paramsSetList[key] = this.fNewEnergy;
				}
				else if (this.paramsSetList.Contains(key))
				{
					this.fNewEnergy = (double)this.paramsSetList[key];
				}
				else
				{
					this.fNewEnergy = this.Objective();
					this.paramsSetList[key] = this.fNewEnergy;
				}
			}
			double num4 = this.fNewEnergy - this.fOldEnergy;
			if (num4 <= 0.0)
			{
				this.fIsDisplacementAccepted = true;
				this.fNDownhills++;
				if (this.fNewEnergy < this.fOptEnergy)
				{
					this.fOptEnergy = this.fNewEnergy;
					for (int num5 = 0; num5 < this.fNParam; num5++)
					{
						this.fOptParam[num5] = this.fParam[num5];
					}
				}
			}
			else
			{
				this.fNTries++;
				if (SmartQuant.Quant.Random.Rndm() < this.GetAcceptanceProbability(num4))
				{
					this.fIsDisplacementAccepted = true;
					this.fNAcceptedUphills++;
				}
				else
				{
					this.fIsDisplacementAccepted = false;
					this.fNRejectedUphills++;
				}
			}
			if (this.fIsDisplacementAccepted)
			{
				this.fNAcceptedDisplacements++;
				this.fOldEnergy = this.fNewEnergy;
				this.fStopEnergy = this.fNewEnergy;
				if (this.fIsNewParam)
				{
					this.fNNewParam++;
				}
			}
			else
			{
				for (int num6 = 0; num6 < this.fNParam; num6++)
				{
					this.fSubsetParam[num6] = this.fTempSubsetParam[num6];
				}
				for (int num7 = 0; num7 < this.fNParamSubset; num7++)
				{
					this.fSubsetIndex[num7] = this.fTempSubsetIndex[num7];
				}
				for (int num8 = 0; num8 < this.fNParamSubset; num8++)
				{
					if (!base.IsParamFixed(this.fTempSubsetIndex[num8]))
					{
						this.fParam[this.fTempSubsetIndex[num8]] = this.fSubsetParam[this.fTempSubsetIndex[num8]];
					}
				}
			}
			this.OnStep();
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00003A18 File Offset: 0x00002A18
		public void Circle()
		{
			for (int i = 0; i < this.fNTemperatureReductionSteps * this.fNParam; i++)
			{
				if (this.stopped)
				{
					return;
				}
				this.Step();
			}
			this.Update();
			this.OnCircle();
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00003A58 File Offset: 0x00002A58
		public string FormatParamsHashCode()
		{
			string text = "";
			for (int i = 0; i < this.fNParam; i++)
			{
				if (base.GetParamType(i) == EParamType.Int)
				{
					text = text + ((int)base[i]).ToString() + "_";
				}
			}
			return text;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00003AA4 File Offset: 0x00002AA4
		public override void Optimize()
		{
			base.Optimize();
			this.fSubsetIndex = new int[this.fNParam];
			this.fTempSubsetIndex = new int[this.fNParam];
			this.fOptParam = new double[this.fNParam];
			this.fTempParam = new double[this.fNParam];
			this.fSubsetParam = new double[this.fNParam];
			this.fTempSubsetParam = new double[this.fNParam];
			this.fDistance = new double[this.fNParam];
			this.fNTries = 0;
			this.fNIterations = 0;
			this.fNDownhills = 0;
			this.fNAcceptedUphills = 0;
			this.fNRejectedUphills = 0;
			this.fNAcceptedDisplacements = 0;
			this.fNTemperatureReductions = 0;
			this.fNTemperatures = 0;
			this.fIsNewParam = false;
			this.fIsParamAccepted = true;
			this.fIsDisplacementAccepted = false;
			this.fTemperature = this.fStartTemperature;
			this.fDisplacementTemperature = this.fDisplacementStartTemperature;
			this.paramsSetList = new SortedList();
			for (int i = 0; i < this.fNParam; i++)
			{
				this.fSubsetParam[i] = this.fParam[i];
				this.fParam[i] = this.fLowerBound[i] + (this.fUpperBound[i] - this.fLowerBound[i]) * SmartQuant.Quant.Random.Rndm();
				this.fSubsetParam[i] = this.fLowerBound[i] + (this.fUpperBound[i] - this.fLowerBound[i]) * SmartQuant.Quant.Random.Rndm();
				this.fDistance[i] = this.fUpperBound[i] - this.fLowerBound[i];
			}
			for (int i = 0; i < this.fNParamSubset; i++)
			{
				this.fSubsetIndex[i] = i;
			}
			base.Update();
			this.fStartEnergy = base.Objective();
			this.fStopEnergy = this.fStartEnergy;
			this.fOldEnergy = this.fStartEnergy;
			this.fOptEnergy = this.fStartEnergy;
			this.fErrorEnergy = this.fStartEnergy;
			this.paramsSetList.Add(this.FormatParamsHashCode(), this.fStartEnergy);
			for (int i = 0; i < this.fNParam; i++)
			{
				this.fOptParam[i] = this.fParam[i];
			}
			bool flag = false;
			while (!flag)
			{
				this.Circle();
				if (this.stopped)
				{
					break;
				}
				this.fTemperature *= this.fTemperatureReductionFactor;
				this.fDisplacementTemperature *= this.fDisplacementTemperatureReductionFactor;
				this.fNTemperatureReductions++;
				if (this.fVerboseMode != EVerboseMode.Quiet)
				{
					Console.WriteLine("{0:F3}  {1:F3}  {2}  {3}  {4}  {5}  {6}", new object[]
					{
						this.fTemperature,
						this.fDisplacementTemperature,
						this.fNTries,
						this.fNDownhills,
						this.fNAcceptedUphills,
						this.fNRejectedUphills,
						this.fOldEnergy
					});
				}
				if (this.fIsObjectiveCallsCriterion && this.fNObjectiveCalls > this.fMaxObjectiveCalls)
				{
					if (this.fVerboseMode != EVerboseMode.Quiet)
					{
						Console.WriteLine("MaxObjectiveCalls stop cretarion");
					}
					flag = true;
				}
				if (this.fIsErrorToleranceCriterion)
				{
					if (this.fNTemperatureReductions != 1)
					{
						if (this.fErrorEnergy - this.fOldEnergy < this.fErrorTolerance)
						{
							this.fNTemperatures++;
							if (this.fNTemperatures == 5)
							{
								flag = true;
							}
							if (this.fVerboseMode != EVerboseMode.Quiet)
							{
								Console.WriteLine("Error tolerance stopping criterion #T = {0}", this.fNTemperatures);
							}
						}
						else
						{
							this.fErrorEnergy = this.fOldEnergy;
							this.fNTemperatures = 0;
						}
					}
					else
					{
						this.fErrorEnergy = this.fOldEnergy;
					}
				}
				if (this.fIsStopTemperatureCriterion && this.fTemperature < this.fStopTemperature)
				{
					if (this.fVerboseMode != EVerboseMode.Quiet)
					{
						Console.WriteLine("StopTemperature stop criterion");
					}
					flag = true;
				}
				if (this.fIsAcceptedUphillsCriterion)
				{
					if (this.fNTries != 0 && this.fNAcceptedUphills <= this.fMinAcceptedUphills)
					{
						if (this.fVerboseMode != EVerboseMode.Quiet)
						{
							Console.WriteLine("NAcceptedUphills stop criterion");
						}
						this.fNTemperatures++;
						if (this.fNTemperatures == 5)
						{
							flag = true;
						}
					}
					else
					{
						this.fNTemperatures = 0;
					}
				}
				this.fNTries = 0;
				this.fNDownhills = 0;
				this.fNAcceptedUphills = 0;
				this.fNRejectedUphills = 0;
				this.fNNewParam = 0;
			}
			for (int i = 0; i < this.fNParam; i++)
			{
				if (!base.IsParamFixed(i))
				{
					this.fParam[i] = this.fOptParam[i];
				}
			}
			base.Update();
			base.EmitBestObjectiveReceived();
			this.fNewEnergy = this.Objective();
			base.EmitCompleted();
		}

		// Token: 0x04000024 RID: 36
		private double fStartTemperature;

		// Token: 0x04000025 RID: 37
		private double fTemperatureReductionFactor;

		// Token: 0x04000026 RID: 38
		private double fDisplacementDistributionParam;

		// Token: 0x04000027 RID: 39
		private double fDisplacementTemperatureReductionFactor;

		// Token: 0x04000028 RID: 40
		private double fDisplacementStartTemperature;

		// Token: 0x04000029 RID: 41
		private double fAcceptanceProbabilityParam;

		// Token: 0x0400002A RID: 42
		private double fStopTemperature;

		// Token: 0x0400002B RID: 43
		private int fMaxObjectiveCalls;

		// Token: 0x0400002C RID: 44
		private int fMinAcceptedUphills;

		// Token: 0x0400002D RID: 45
		private double fErrorTolerance;

		// Token: 0x0400002E RID: 46
		private int fNTemperatureReductionSteps;

		// Token: 0x0400002F RID: 47
		private bool fIsObjectiveCallsCriterion;

		// Token: 0x04000030 RID: 48
		private bool fIsErrorToleranceCriterion;

		// Token: 0x04000031 RID: 49
		private bool fIsStopTemperatureCriterion;

		// Token: 0x04000032 RID: 50
		private bool fIsAcceptedUphillsCriterion;

		// Token: 0x04000033 RID: 51
		private bool fIsAcceptedDownhillsCriterion;

		// Token: 0x04000034 RID: 52
		private int[] fSubsetIndex;

		// Token: 0x04000035 RID: 53
		private int[] fTempSubsetIndex;

		// Token: 0x04000036 RID: 54
		private double[] fOptParam;

		// Token: 0x04000037 RID: 55
		private double[] fTempParam;

		// Token: 0x04000038 RID: 56
		private double[] fSubsetParam;

		// Token: 0x04000039 RID: 57
		private double[] fTempSubsetParam;

		// Token: 0x0400003A RID: 58
		private double[] fDistance;

		// Token: 0x0400003B RID: 59
		private double fTemperature;

		// Token: 0x0400003C RID: 60
		private double fDisplacementTemperature;

		// Token: 0x0400003D RID: 61
		private double fStartEnergy;

		// Token: 0x0400003E RID: 62
		private double fStopEnergy;

		// Token: 0x0400003F RID: 63
		private double fNewEnergy;

		// Token: 0x04000040 RID: 64
		private double fOldEnergy;

		// Token: 0x04000041 RID: 65
		private double fOptEnergy;

		// Token: 0x04000042 RID: 66
		private double fErrorEnergy;

		// Token: 0x04000043 RID: 67
		private int fNIterations;

		// Token: 0x04000044 RID: 68
		private bool fIsNewParam;

		// Token: 0x04000045 RID: 69
		private bool fIsParamAccepted;

		// Token: 0x04000046 RID: 70
		private bool fIsDisplacementAccepted;

		// Token: 0x04000047 RID: 71
		private int fNTries;

		// Token: 0x04000048 RID: 72
		private int fNDownhills;

		// Token: 0x04000049 RID: 73
		private int fNAcceptedUphills;

		// Token: 0x0400004A RID: 74
		private int fNRejectedUphills;

		// Token: 0x0400004B RID: 75
		private int fNAcceptedDisplacements;

		// Token: 0x0400004C RID: 76
		private int fNTemperatureReductions;

		// Token: 0x0400004D RID: 77
		private int fNTemperatures;

		// Token: 0x0400004E RID: 78
		private int fNNewParam;

		// Token: 0x0400004F RID: 79
		private SortedList paramsSetList;
	}
}
