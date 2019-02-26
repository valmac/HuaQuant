using System;
using System.Collections;
using System.Drawing;
using SmartQuant.Charting;

namespace SmartQuant.Neural
{
	// Token: 0x02000011 RID: 17
	[Serializable]
	public class TPerceptron : TNeuralNetwork
	{
		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x000048CE File Offset: 0x000038CE
		public Graph TrainingErrorGraph
		{
			get
			{
				return this.fTrainingErrorGraph;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x000048D6 File Offset: 0x000038D6
		public Graph ValidationErrorGraph
		{
			get
			{
				return this.fValidationErrorGraph;
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000048DE File Offset: 0x000038DE
		public TPerceptron()
		{
			this.fNHidden = 0;
			this.fMode = EActivationMode.Approximation;
			this.fTrainingSet = null;
			this.fValidationSet = null;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00004902 File Offset: 0x00003902
		public TPerceptron(string Name, string Title, int NInput, int NHidden, int NOutput, EActivationMode Mode) : base(Name, Title)
		{
			this.fNInput = NInput;
			this.fNHidden = NHidden;
			this.fNOutput = NOutput;
			this.fMode = Mode;
			this.fTrainingSet = null;
			this.fValidationSet = null;
			this.Configure();
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00004940 File Offset: 0x00003940
		public TPerceptron(string Name, string Title, TNeuralDataSet TrainingSet, int NHidden, EActivationMode Mode) : base(Name, Title)
		{
			this.fTrainingSet = TrainingSet;
			this.fValidationSet = null;
			this.fNInput = TrainingSet.NInput;
			this.fNHidden = NHidden;
			this.fNOutput = TrainingSet.NOutput;
			this.fMode = Mode;
			this.Configure();
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00004994 File Offset: 0x00003994
		public TPerceptron(string Name, string Title, TNeuralDataSet TrainingSet, TNeuralDataSet ValidationSet, int NHidden, EActivationMode Mode) : base(Name, Title)
		{
			this.fTrainingSet = TrainingSet;
			this.fValidationSet = ValidationSet;
			this.fNInput = TrainingSet.NInput;
			this.fNHidden = NHidden;
			this.fNOutput = TrainingSet.NOutput;
			this.fMode = Mode;
			this.Configure();
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000049E8 File Offset: 0x000039E8
		public void Configure()
		{
			this.fInputLayer = new TInputNeuralLayer(this.fNInput, true);
			TNeuralLayer tneuralLayer = new THiddenNeuralLayer(this.fNHidden);
			tneuralLayer.Connect(this.fInputLayer);
			this.fHiddenLayer = new ArrayList();
			this.fNHiddenLayer = 1;
			this.fHiddenLayer.Add(tneuralLayer);
			this.fOutputLayer = new TOutputNeuralLayer(this.fNOutput, this.fMode);
			this.fOutputLayer.Connect(tneuralLayer);
			this.fOutput = new double[this.fNOutput];
			this.fError = new double[this.fNOutput];
			this.fMaxNX = Math.Max(this.fNInput + 1, this.fNOutput);
			this.fMaxNX = Math.Max(this.fMaxNX, this.fNHidden + 1);
			this.fMaxNY = 3;
			this.fNPattern = 0;
			this.fTrainingError = 0.0;
			this.fValidationError = 0.0;
			this.fTrainingErrorGraph = new Graph();
			this.fTrainingErrorGraph.Title = "Training error development";
			this.fTrainingErrorGraph.LineColor = Color.Red;
			this.fValidationErrorGraph = new Graph();
			this.fValidationErrorGraph.Title = "Validation error development";
			this.fValidationErrorGraph.LineColor = Color.Blue;
			this.fStopTraining = false;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00004B3E File Offset: 0x00003B3E
		public void ReConfigure(int NHidden)
		{
			this.fNInput = this.fTrainingSet.NInput;
			this.fNHidden = NHidden;
			this.fNOutput = this.fTrainingSet.NOutput;
			this.Configure();
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00004B70 File Offset: 0x00003B70
		public void ResetError()
		{
			this.fTrainingErrorGraph = new Graph();
			this.fTrainingErrorGraph.Title = "Training error development";
			this.fTrainingErrorGraph.LineColor = Color.Red;
			this.fValidationErrorGraph = new Graph();
			this.fValidationErrorGraph.Title = "Validation error development";
			this.fValidationErrorGraph.LineColor = Color.Blue;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00004BD3 File Offset: 0x00003BD3
		public override void Reset()
		{
			TNeuralNetwork.Network.Reset();
			this.ResetError();
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00004BE8 File Offset: 0x00003BE8
		public void AddHiddenLayer(int NHidden)
		{
			TNeuralLayer layer = (TNeuralLayer)this.fHiddenLayer[this.fHiddenLayer.Count - 1];
			TNeuralLayer tneuralLayer = new THiddenNeuralLayer(NHidden);
			this.fOutputLayer.Disconnect(layer);
			this.fOutputLayer.Connect(tneuralLayer);
			tneuralLayer.Connect(layer);
			this.fHiddenLayer.Add(tneuralLayer);
			this.fNHiddenLayer++;
			this.fNHidden += NHidden;
			this.fMaxNX = Math.Max(this.fMaxNX, NHidden + 1);
			this.fMaxNY++;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00004C84 File Offset: 0x00003C84
		public int GetNHidden(int i)
		{
			if (i != 0)
			{
				return ((TNeuralLayer)this.fHiddenLayer[i - 1]).GetNNeuron() - 1;
			}
			return this.fNHidden;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00004CAC File Offset: 0x00003CAC
		public void FeedForward()
		{
			((TInputNeuralLayer)this.fInputLayer).FeedInput(this.fInput);
			((TInputNeuralLayer)this.fInputLayer).ProcessInput();
			for (int i = 0; i < this.fNHiddenLayer; i++)
			{
				((TNeuralLayer)this.fHiddenLayer[i]).ProcessInput();
			}
			this.fOutputLayer.ProcessInput();
			this.fOutput = ((TOutputNeuralLayer)this.fOutputLayer).GetOutput();
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00004D28 File Offset: 0x00003D28
		public void FeedBackward()
		{
			((TOutputNeuralLayer)this.fOutputLayer).FeedError(this.fError);
			((TOutputNeuralLayer)this.fOutputLayer).ProcessError();
			for (int i = this.fNHiddenLayer - 1; i >= 0; i--)
			{
				((TNeuralLayer)this.fHiddenLayer[i]).ProcessError();
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00004D84 File Offset: 0x00003D84
		public void ComputeError()
		{
			for (int i = 0; i < this.fNOutput; i++)
			{
				this.fError[i] = this.fTarget[i] - this.fOutput[i];
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00004DBC File Offset: 0x00003DBC
		public override void Update(int Param)
		{
			base.Update(0);
			this.fOutputLayer.Update();
			for (int i = this.fNHiddenLayer - 1; i >= 0; i--)
			{
				((TNeuralLayer)this.fHiddenLayer[i]).Update();
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00004E04 File Offset: 0x00003E04
		public void TrainPerceptron()
		{
			this.fStopTraining = false;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			for (;;)
			{
				for (int i = 0; i < this.fNBatch; i++)
				{
					TNeuralData data = this.fTrainingSet.GetData();
					this.fInput = data.Input;
					this.fTarget = data.Output;
					this.FeedForward();
					this.ComputeError();
					this.FeedBackward();
				}
				this.Update(0);
				this.fNPattern += this.fNBatch;
				num += this.fNBatch;
				num2 += this.fNBatch;
				if (this.fStopTraining)
				{
					break;
				}
				if (this.fSMethod == EStoppingMethod.PatternNumber && (double)num >= this.fSParameter)
				{
					goto Block_4;
				}
				if (num2 >= this.fNGraphUpdate)
				{
					num2 = 0;
					this.fTrainingError = this.GetTrainingSetError();
					this.fTrainingErrorGraph.Add((double)num3, this.fTrainingError);
					if (this.fValidationSet != null)
					{
						this.fValidationError = this.GetValidationSetError();
						this.fValidationErrorGraph.Add((double)num3, this.fValidationError);
					}
					num3++;
					if (this.fViewMode == EViewMode.OnLine)
					{
					}
				}
			}
			Console.WriteLine("Training interrupted by user!");
			return;
			Block_4:
			Console.WriteLine("Training finished {0}!", (int)this.fSParameter);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00004F38 File Offset: 0x00003F38
		public double GetError()
		{
			double num = 0.0;
			for (int i = 0; i < this.fNOutput; i++)
			{
				num += this.fError[i] * this.fError[i];
			}
			return 0.5 * num;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00004F80 File Offset: 0x00003F80
		public double GetTrainingSetError(int Option)
		{
			if (Option != 0)
			{
				return this.fTrainingError;
			}
			int ndata = this.fTrainingSet.GetNData();
			double num = 0.0;
			for (int i = 0; i < ndata; i++)
			{
				TNeuralData data = this.fTrainingSet.GetData(i);
				this.fInput = data.Input;
				this.fTarget = data.Output;
				this.FeedForward();
				this.ComputeError();
				num += this.GetError();
			}
			return num / (double)ndata;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00004FF8 File Offset: 0x00003FF8
		public double GetValidationSetError(int Option)
		{
			if (Option != 0)
			{
				return this.fValidationError;
			}
			if (this.fValidationSet == null)
			{
				return 0.0;
			}
			int ndata = this.fValidationSet.GetNData();
			double num = 0.0;
			for (int i = 0; i < ndata; i++)
			{
				TNeuralData data = this.fValidationSet.GetData(i);
				this.fInput = data.Input;
				this.fTarget = data.Output;
				this.FeedForward();
				this.ComputeError();
				num += this.GetError();
			}
			return num / (double)ndata;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00005081 File Offset: 0x00004081
		public double GetTrainingSetError()
		{
			return this.GetTrainingSetError(0);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000508A File Offset: 0x0000408A
		public double GetValidationSetError()
		{
			return this.GetValidationSetError(0);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00005094 File Offset: 0x00004094
		public void PrintError()
		{
			if (this.fTarget[1] != 0.0)
			{
				Console.WriteLine("Error = {0}", this.GetError());
				for (int i = 0; i < this.fNOutput; i++)
				{
					Console.WriteLine("W : {0}", this.GetWinner());
					Console.WriteLine("{0} - {1} : {2}", this.fTarget[i], this.fOutput[i], this.fError[i]);
				}
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00005120 File Offset: 0x00004120
		public void PrintTrainingSetError()
		{
			int ndata = this.fTrainingSet.GetNData();
			double num = 0.0;
			for (int i = 0; i < ndata; i++)
			{
				TNeuralData data = this.fTrainingSet.GetData(i);
				this.fInput = data.Input;
				this.fTarget = data.Output;
				this.FeedForward();
				this.ComputeError();
				num += this.GetError();
				this.PrintError();
			}
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00005190 File Offset: 0x00004190
		public int GetWinner()
		{
			int num = 0;
			for (int i = 0; i < this.fNOutput; i++)
			{
				if (this.fOutput[i] > this.fOutput[num])
				{
					num = i;
				}
			}
			return num;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000051C8 File Offset: 0x000041C8
		public double GetWinnerConfidence()
		{
			int num = 0;
			double num2 = 0.0;
			for (int i = 0; i < this.fNOutput; i++)
			{
				if (this.fOutput[i] > this.fOutput[num])
				{
					num = i;
				}
				num2 += this.fOutput[i];
			}
			return this.fOutput[num] / num2;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000521B File Offset: 0x0000421B
		public void SetInputName(int i, string Name)
		{
			this.fInputLayer.SetName(i, Name);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0000522A File Offset: 0x0000422A
		public void SetOutputName(int i, string Name)
		{
			this.fOutputLayer.SetName(i - 1, Name);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000523B File Offset: 0x0000423B
		public void Print(string Option)
		{
		}

		// Token: 0x0400005A RID: 90
		private int fNHidden;

		// Token: 0x0400005B RID: 91
		private int fNHiddenLayer;

		// Token: 0x0400005C RID: 92
		private ArrayList fHiddenLayer;

		// Token: 0x0400005D RID: 93
		private double[] fError;

		// Token: 0x0400005E RID: 94
		private TNeuralDataSet fTrainingSet;

		// Token: 0x0400005F RID: 95
		private TNeuralDataSet fValidationSet;

		// Token: 0x04000060 RID: 96
		private EActivationMode fMode;

		// Token: 0x04000061 RID: 97
		private Graph fTrainingErrorGraph;

		// Token: 0x04000062 RID: 98
		private Graph fValidationErrorGraph;

		// Token: 0x04000063 RID: 99
		private double fTrainingError;

		// Token: 0x04000064 RID: 100
		private double fValidationError;

		// Token: 0x04000065 RID: 101
		private bool fStopTraining;
	}
}
