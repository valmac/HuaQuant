using System;
using System.Collections;

namespace SmartQuant.Neural
{
	// Token: 0x02000002 RID: 2
	[Serializable]
	public class TNeuron
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00001050
		// (set) Token: 0x06000002 RID: 2 RVA: 0x00002058 File Offset: 0x00001058
		public int ID
		{
			get
			{
				return this.fID;
			}
			set
			{
				this.fID = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002061 File Offset: 0x00001061
		// (set) Token: 0x06000004 RID: 4 RVA: 0x00002069 File Offset: 0x00001069
		public double Input
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

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002072 File Offset: 0x00001072
		// (set) Token: 0x06000006 RID: 6 RVA: 0x0000207A File Offset: 0x0000107A
		public double Output
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

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002083 File Offset: 0x00001083
		// (set) Token: 0x06000008 RID: 8 RVA: 0x0000208B File Offset: 0x0000108B
		public double Error
		{
			get
			{
				return this.fError;
			}
			set
			{
				this.fError = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002094 File Offset: 0x00001094
		// (set) Token: 0x0600000A RID: 10 RVA: 0x0000209C File Offset: 0x0000109C
		public bool Enabled
		{
			get
			{
				return this.fEnabled;
			}
			set
			{
				this.fEnabled = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000B RID: 11 RVA: 0x000020A5 File Offset: 0x000010A5
		// (set) Token: 0x0600000C RID: 12 RVA: 0x000020AD File Offset: 0x000010AD
		public string Name
		{
			get
			{
				return this.fName;
			}
			set
			{
				this.fName = value;
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000020B8 File Offset: 0x000010B8
		public TNeuron()
		{
			this.fID = -1;
			this.fWeight = new ArrayList();
			this.fInput = 0.0;
			this.fOutput = 0.0;
			this.fError = 0.0;
			this.fEnabled = true;
			TNeuralNetwork.Network.AddNeuron(this);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000211C File Offset: 0x0000111C
		public virtual void Connect(TNeuron Neuron)
		{
			this.fWeight.Add(new TNeuralWeight(Neuron));
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002130 File Offset: 0x00001130
		public virtual void Disconnect(TNeuron Neuron)
		{
			foreach (object obj in this.fWeight)
			{
				TNeuralWeight tneuralWeight = (TNeuralWeight)obj;
				if (tneuralWeight.Neuron == Neuron)
				{
					this.fWeight.Remove(tneuralWeight);
					break;
				}
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000219C File Offset: 0x0000119C
		public virtual double GetOutput()
		{
			if (this.fEnabled)
			{
				return this.fOutput;
			}
			return 0.0;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000021B8 File Offset: 0x000011B8
		public virtual void ProcessInput(int Option)
		{
			this.fInput = 0.0;
			foreach (object obj in this.fWeight)
			{
				TNeuralWeight tneuralWeight = (TNeuralWeight)obj;
				this.fInput += tneuralWeight.PropagateInput();
			}
			this.fOutput = this.Activation(this.fInput);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002240 File Offset: 0x00001240
		public virtual void ProcessInput()
		{
			this.ProcessInput(0);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0000224C File Offset: 0x0000124C
		public virtual void ProcessError(int Option)
		{
			this.fError *= this.Gradient(this.fInput);
			foreach (object obj in this.fWeight)
			{
				TNeuralWeight tneuralWeight = (TNeuralWeight)obj;
				tneuralWeight.PropagateError(this.fError);
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000022C4 File Offset: 0x000012C4
		public virtual void ProcessError()
		{
			this.ProcessError(0);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000022D0 File Offset: 0x000012D0
		public virtual void Update()
		{
			foreach (object obj in this.fWeight)
			{
				TNeuralWeight tneuralWeight = (TNeuralWeight)obj;
				tneuralWeight.Update(this.fError);
			}
			this.fError = 0.0;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002340 File Offset: 0x00001340
		public TNeuralWeight GetMinWeight()
		{
			if (this.fWeight.Count == 0)
			{
				return null;
			}
			TNeuralWeight tneuralWeight = (TNeuralWeight)this.fWeight[0];
			double weight = tneuralWeight.Weight;
			foreach (object obj in this.fWeight)
			{
				TNeuralWeight tneuralWeight2 = (TNeuralWeight)obj;
				if (tneuralWeight2.Weight < weight)
				{
					tneuralWeight = tneuralWeight2;
					weight = tneuralWeight2.Weight;
				}
			}
			return tneuralWeight;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000023D0 File Offset: 0x000013D0
		public TNeuralWeight GetMaxWeight()
		{
			if (this.fWeight.Count == 0)
			{
				return null;
			}
			TNeuralWeight tneuralWeight = (TNeuralWeight)this.fWeight[0];
			double weight = tneuralWeight.Weight;
			foreach (object obj in this.fWeight)
			{
				TNeuralWeight tneuralWeight2 = (TNeuralWeight)obj;
				if (tneuralWeight2.Weight > weight)
				{
					tneuralWeight = tneuralWeight2;
					weight = tneuralWeight2.Weight;
				}
			}
			return tneuralWeight;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002460 File Offset: 0x00001460
		public void RandomizeWeights()
		{
			foreach (object obj in this.fWeight)
			{
				TNeuralWeight tneuralWeight = (TNeuralWeight)obj;
				tneuralWeight.Randomize();
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000024B8 File Offset: 0x000014B8
		public void NormalizeWeights()
		{
			double num = 0.0;
			foreach (object obj in this.fWeight)
			{
				TNeuralWeight tneuralWeight = (TNeuralWeight)obj;
				num += tneuralWeight.Weight * tneuralWeight.Weight;
			}
			num = Math.Sqrt(num);
			if (num != 0.0)
			{
                IEnumerator enumerator2 = this.fWeight.GetEnumerator();
				{
					while (enumerator2.MoveNext())
					{
						object obj2 = enumerator2.Current;
						TNeuralWeight tneuralWeight2 = (TNeuralWeight)obj2;
						tneuralWeight2.Weight /= num;
					}
					return;
				}
			}
			this.RandomizeWeights();
			this.NormalizeWeights();
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000259C File Offset: 0x0000159C
		public void StoreWeights()
		{
			foreach (object obj in this.fWeight)
			{
				TNeuralWeight tneuralWeight = (TNeuralWeight)obj;
				tneuralWeight.Store();
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000025F4 File Offset: 0x000015F4
		public void RestoreWeights()
		{
			foreach (object obj in this.fWeight)
			{
				TNeuralWeight tneuralWeight = (TNeuralWeight)obj;
				tneuralWeight.Restore();
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000264C File Offset: 0x0000164C
		public void SetError(double Error)
		{
			this.fError = Error;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002655 File Offset: 0x00001655
		public void AddError(double Error)
		{
			this.fError += Error;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002665 File Offset: 0x00001665
		public int GetNWeights()
		{
			return this.fWeight.Count;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002672 File Offset: 0x00001672
		public TNeuralWeight GetWeight(int i)
		{
			return (TNeuralWeight)this.fWeight[i];
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002685 File Offset: 0x00001685
		public virtual double Activation(double x)
		{
			return x;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002688 File Offset: 0x00001688
		public virtual double Gradient(double x)
		{
			return 1.0;
		}

		// Token: 0x04000001 RID: 1
		protected int fID;

		// Token: 0x04000002 RID: 2
		protected ArrayList fWeight;

		// Token: 0x04000003 RID: 3
		protected double fInput;

		// Token: 0x04000004 RID: 4
		protected double fOutput;

		// Token: 0x04000005 RID: 5
		protected double fError;

		// Token: 0x04000006 RID: 6
		protected bool fEnabled;

		// Token: 0x04000007 RID: 7
		protected string fName;
	}
}
