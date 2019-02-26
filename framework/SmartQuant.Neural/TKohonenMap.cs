using System;
using System.Drawing;
using SmartQuant.Charting;

namespace SmartQuant.Neural
{
	// Token: 0x02000017 RID: 23
	[Serializable]
	public class TKohonenMap : TNeuralNetwork
	{
		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x00005984 File Offset: 0x00004984
		// (set) Token: 0x060000EA RID: 234 RVA: 0x0000598C File Offset: 0x0000498C
		public EKohonenTopology Topology
		{
			get
			{
				return this.fTopology;
			}
			set
			{
				this.fTopology = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000EB RID: 235 RVA: 0x00005995 File Offset: 0x00004995
		// (set) Token: 0x060000EC RID: 236 RVA: 0x0000599D File Offset: 0x0000499D
		public EKohonenKernel Kernel
		{
			get
			{
				return this.fKernel;
			}
			set
			{
				this.fKernel = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000ED RID: 237 RVA: 0x000059A6 File Offset: 0x000049A6
		// (set) Token: 0x060000EE RID: 238 RVA: 0x000059AE File Offset: 0x000049AE
		public double InitLearningRate
		{
			get
			{
				return this.fInitLearningRate;
			}
			set
			{
				this.fInitLearningRate = value;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000EF RID: 239 RVA: 0x000059B7 File Offset: 0x000049B7
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x000059BF File Offset: 0x000049BF
		public double InitNeighborhoodRadius
		{
			get
			{
				return this.fInitNeighborhoodRadius;
			}
			set
			{
				this.fInitNeighborhoodRadius = value;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x000059C8 File Offset: 0x000049C8
		public double NeighborhoodRadius
		{
			get
			{
				return this.fNeighborhoodRadius;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x000059D0 File Offset: 0x000049D0
		public int NCols
		{
			get
			{
				return this.fNCols;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x000059D8 File Offset: 0x000049D8
		public int NRows
		{
			get
			{
				return this.fNRows;
			}
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x000059E0 File Offset: 0x000049E0
		private void Configure()
		{
			this.fInputLayer = new TInputNeuron[this.fNInput];
			for (int i = 0; i < this.fNInput; i++)
			{
				this.fInputLayer[i] = new TInputNeuron();
			}
			this.fMap = new TKohonenNeuron[this.fNCols, this.fNRows];
			for (int j = 0; j < this.fNCols; j++)
			{
				for (int k = 0; k < this.fNRows; k++)
				{
					this.fMap[j, k] = new TKohonenNeuron(this, j, k);
				}
			}
			for (int i = 0; i < this.fNInput; i++)
			{
				for (int j = 0; j < this.fNCols; j++)
				{
					for (int k = 0; k < this.fNRows; k++)
					{
						this.fMap[j, k].Connect(this.fInputLayer[i]);
					}
				}
			}
			this.fMapHist = null;
			this.fDataGraph = null;
			this.fTopology = EKohonenTopology.Rectangular;
			this.fKernel = EKohonenKernel.Bubble;
			this.fInitLearningRate = 0.05;
			this.fInitNeighborhoodRadius = 10.0;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00005AF7 File Offset: 0x00004AF7
		public TKohonenMap()
		{
			this.fDataSet = null;
			this.fMapHist = null;
			this.fDataGraph = null;
			this.fNeighborhoodRadius = this.fInitNeighborhoodRadius;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00005B20 File Offset: 0x00004B20
		public TKohonenMap(string Name, string Title, int NCols, int NRows, TNeuralDataSet DataSet, int NPatterns) : base(Name, Title)
		{
			this.fNCols = NCols;
			this.fNRows = NRows;
			this.fDataSet = DataSet;
			this.fNInput = DataSet.NInput;
			base.SetStopping(EStoppingMethod.PatternNumber, (double)NPatterns);
			this.fInitNeighborhoodRadius = (double)Math.Max(NCols, NRows);
			this.fNeighborhoodRadius = this.fInitNeighborhoodRadius;
			this.Configure();
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00005B84 File Offset: 0x00004B84
		public TKohonenMap(string Name, string Title, int NCols, int NRows, int Topology, TNeuralDataSet DataSet, int NPatterns) : base(Name, Title)
		{
			this.fNCols = NCols;
			this.fNRows = NRows;
			this.fDataSet = DataSet;
			this.fNInput = DataSet.NInput;
			base.SetStopping(EStoppingMethod.PatternNumber, (double)NPatterns);
			this.fInitNeighborhoodRadius = (double)Math.Max(NCols, NRows);
			this.fNeighborhoodRadius = this.fInitNeighborhoodRadius;
			this.Configure();
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00005BE8 File Offset: 0x00004BE8
		public TKohonenMap(string Name, int NCols, int NRows, TNeuralDataSet DataSet, int NPatterns) : base(Name)
		{
			this.fNCols = NCols;
			this.fNRows = NRows;
			this.fDataSet = DataSet;
			this.fNInput = DataSet.NInput;
			base.SetStopping(EStoppingMethod.PatternNumber, (double)NPatterns);
			this.fInitNeighborhoodRadius = (double)Math.Max(NCols, NRows);
			this.fNeighborhoodRadius = this.fInitNeighborhoodRadius;
			this.Configure();
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00005C4C File Offset: 0x00004C4C
		public TKohonenMap(string Name, int NCols, int NRows, int Topology, TNeuralDataSet DataSet, int NPatterns) : base(Name)
		{
			this.fNCols = NCols;
			this.fNRows = NRows;
			this.fDataSet = DataSet;
			this.fNInput = DataSet.NInput;
			base.SetStopping(EStoppingMethod.PatternNumber, (double)NPatterns);
			this.fInitNeighborhoodRadius = (double)Math.Max(NCols, NRows);
			this.fNeighborhoodRadius = this.fInitNeighborhoodRadius;
			this.Configure();
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00005CB0 File Offset: 0x00004CB0
		public void ProcessInput(double[] Input)
		{
			this.fInput = Input;
			for (int i = 0; i < this.fNInput; i++)
			{
				this.fInputLayer[i].Input = Input[i];
			}
			for (int i = 0; i < this.fNInput; i++)
			{
				this.fInputLayer[i].ProcessInput();
			}
			for (int j = 0; j < this.fNCols; j++)
			{
				for (int k = 0; k < this.fNRows; k++)
				{
					this.fMap[j, k].ProcessInput();
				}
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00005D3C File Offset: 0x00004D3C
		public double GetError()
		{
			double num = 0.0;
			for (int i = 0; i < this.fNCols; i++)
			{
				for (int j = 0; j < this.fNRows; j++)
				{
					num += this.fMap[i, j].GetError();
				}
			}
			return num / (double)(this.fNCols * this.fNRows);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00005D9C File Offset: 0x00004D9C
		public double GetAverageError()
		{
			double num = 0.0;
			for (int i = 0; i < this.fDataSet.GetNData(); i++)
			{
				this.ProcessInput(this.fDataSet.GetInput(i));
				num += this.GetError();
			}
			return num;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00005DE8 File Offset: 0x00004DE8
		public TKohonenNeuron GetWinner()
		{
			TKohonenNeuron tkohonenNeuron = this.fMap[0, 0];
			double num = tkohonenNeuron.GetError();
			for (int i = 0; i < this.fNCols; i++)
			{
				for (int j = 0; j < this.fNRows; j++)
				{
					double error = this.fMap[i, j].GetError();
					if (error < num)
					{
						num = error;
						tkohonenNeuron = this.fMap[i, j];
					}
				}
			}
			return tkohonenNeuron;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00005E58 File Offset: 0x00004E58
		public void Update()
		{
			for (int i = 0; i < this.fNCols; i++)
			{
				for (int j = 0; j < this.fNRows; j++)
				{
					this.fMap[i, j].Update(this.fWinner);
				}
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00005EA0 File Offset: 0x00004EA0
		public void TrainThread()
		{
			this.fNPattern = 0;
			int num = 0;
			while ((double)num < this.fSParameter)
			{
				this.fInput = this.fDataSet.GetData().Input;
				this.ProcessInput(this.fInput);
				this.fWinner = this.GetWinner();
				this.Update();
				this.fNPattern++;
				double num2 = (double)this.fNPattern / this.fSParameter;
				this.fLearningRate = this.fInitLearningRate * (1.0 - num2);
				this.fNeighborhoodRadius = 1.0 + this.fInitNeighborhoodRadius * (1.0 - num2);
				num++;
			}
			Console.WriteLine("Training finished, " + this.fNPattern + " patterns trained...");
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00005F78 File Offset: 0x00004F78
		public Histogram2D GetMapHist()
		{
			this.fMapHist = new Histogram2D(this.fName, this.fTitle, this.fNCols, 0.0, (double)this.fNCols, this.fNRows, 0.0, (double)this.fNRows);
			for (int i = 0; i < this.fNCols; i++)
			{
				for (int j = 0; j < this.fNRows; j++)
				{
					this.fMap[i, j].ResetWin();
				}
			}
			for (int k = 0; k < this.fDataSet.GetNData(); k++)
			{
				TKohonenData tkohonenData = (TKohonenData)this.fDataSet.GetData(k);
				double[] input = tkohonenData.Input;
				double[] output = tkohonenData.Output;
				this.ProcessInput(input);
				TKohonenNeuron winner = this.GetWinner();
				if (output != null)
				{
					if (output[0] != 0.0)
					{
						winner.AddWin(output[0]);
					}
				}
				else
				{
					winner.AddWin(1.0);
					winner.SetNWins(1);
				}
				tkohonenData.X = winner.Col;
				tkohonenData.Y = winner.Row;
			}
			for (int l = 0; l < this.fNCols; l++)
			{
				for (int m = 0; m < this.fNRows; m++)
				{
					TKohonenNeuron tkohonenNeuron = this.fMap[l, m];
					if (tkohonenNeuron.GetNWins() != 0)
					{
						this.fMapHist.Set((double)tkohonenNeuron.Col, (double)tkohonenNeuron.Row, tkohonenNeuron.GetWin() / (double)tkohonenNeuron.GetNWins());
					}
					else
					{
						this.fMapHist.Set((double)tkohonenNeuron.Col, (double)tkohonenNeuron.Row, 0.0);
					}
				}
			}
			return this.fMapHist;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00006140 File Offset: 0x00005140
		public void DrawData(int X, int Y)
		{
			if (this.fDataGraph == null)
			{
				this.fDataGraph = new Graph("Kohonen data");
				this.fDataGraph.Style = EGraphStyle.Scatter;
				this.fDataGraph.MarkerSize = 1;
			}
			for (int i = 0; i < this.fDataSet.GetNData(); i++)
			{
				double[] input = this.fDataSet.GetInput(i);
				this.fDataGraph.Add(input[X], input[Y]);
			}
			this.fDataGraph.Draw();
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000061BC File Offset: 0x000051BC
		public void DrawData()
		{
			this.DrawData(0, 1);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000061C8 File Offset: 0x000051C8
		public void DrawMesh(int X, int Y)
		{
			for (int i = 0; i < this.fNCols; i++)
			{
				for (int j = 0; j < this.fNRows; j++)
				{
					TKohonenNeuron tkohonenNeuron = this.fMap[i, j];
					if (i < this.fNCols - 1)
					{
						TKohonenNeuron tkohonenNeuron2 = this.fMap[i + 1, j];
						new TLine(tkohonenNeuron.GetWeight(X).Weight, tkohonenNeuron.GetWeight(Y).Weight, tkohonenNeuron2.GetWeight(X).Weight, tkohonenNeuron2.GetWeight(Y).Weight)
						{
							Color = Color.Blue
						}.Draw();
					}
					if (j < this.fNRows - 1)
					{
						TKohonenNeuron tkohonenNeuron3 = this.fMap[i, j + 1];
						new TLine(tkohonenNeuron.GetWeight(X).Weight, tkohonenNeuron.GetWeight(Y).Weight, tkohonenNeuron3.GetWeight(X).Weight, tkohonenNeuron3.GetWeight(Y).Weight)
						{
							Color = Color.Blue
						}.Draw();
					}
					new TMarker(tkohonenNeuron.GetWeight(X).Weight, tkohonenNeuron.GetWeight(Y).Weight, 20.0)
					{
						Color = Color.Red
					}.Draw();
				}
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000631E File Offset: 0x0000531E
		public void DrawMesh()
		{
			this.DrawMesh(0, 1);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00006328 File Offset: 0x00005328
		public void Draw(string Option)
		{
			if (this.fMapHist == null || Option.ToLower() == "n")
			{
				this.GetMapHist();
			}
			this.fMapHist.Draw();
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00006356 File Offset: 0x00005356
		public void Draw()
		{
			this.Draw("");
		}

		// Token: 0x04000077 RID: 119
		private EKohonenTopology fTopology;

		// Token: 0x04000078 RID: 120
		private EKohonenKernel fKernel;

		// Token: 0x04000079 RID: 121
		private double fInitLearningRate;

		// Token: 0x0400007A RID: 122
		private double fInitNeighborhoodRadius;

		// Token: 0x0400007B RID: 123
		private int fNCols;

		// Token: 0x0400007C RID: 124
		private int fNRows;

		// Token: 0x0400007D RID: 125
		private new TInputNeuron[] fInputLayer;

		// Token: 0x0400007E RID: 126
		private TKohonenNeuron[,] fMap;

		// Token: 0x0400007F RID: 127
		private TKohonenNeuron fWinner;

		// Token: 0x04000080 RID: 128
		private TNeuralDataSet fDataSet;

		// Token: 0x04000081 RID: 129
		private Histogram2D fMapHist;

		// Token: 0x04000082 RID: 130
		private Graph fDataGraph;

		// Token: 0x04000083 RID: 131
		private double fNeighborhoodRadius;
	}
}
