using System;
using System.Collections;
using System.ComponentModel;

namespace SmartQuant.Optimization
{
	// Token: 0x02000005 RID: 5
	public abstract class Optimizer : ParamSet
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000028 RID: 40 RVA: 0x00002814 File Offset: 0x00001814
		// (remove) Token: 0x06000029 RID: 41 RVA: 0x0000282D File Offset: 0x0000182D
		public event EventHandler Inited;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600002A RID: 42 RVA: 0x00002846 File Offset: 0x00001846
		// (remove) Token: 0x0600002B RID: 43 RVA: 0x0000285F File Offset: 0x0000185F
		public event EventHandler CircleCalled;

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600002C RID: 44 RVA: 0x00002878 File Offset: 0x00001878
		// (remove) Token: 0x0600002D RID: 45 RVA: 0x00002891 File Offset: 0x00001891
		public event EventHandler StepCalled;

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600002E RID: 46 RVA: 0x000028AA File Offset: 0x000018AA
		// (remove) Token: 0x0600002F RID: 47 RVA: 0x000028C3 File Offset: 0x000018C3
		public event EventHandler UpdateCalled;

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000030 RID: 48 RVA: 0x000028DC File Offset: 0x000018DC
		// (remove) Token: 0x06000031 RID: 49 RVA: 0x000028F5 File Offset: 0x000018F5
		public event EventHandler ObjectiveCalled;

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000032 RID: 50 RVA: 0x0000290E File Offset: 0x0000190E
		// (remove) Token: 0x06000033 RID: 51 RVA: 0x00002927 File Offset: 0x00001927
		public event EventHandler OptimizationCompleted;

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000034 RID: 52 RVA: 0x00002940 File Offset: 0x00001940
		// (remove) Token: 0x06000035 RID: 53 RVA: 0x00002959 File Offset: 0x00001959
		public event EventHandler BestObjectiveReceived;

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00002972 File Offset: 0x00001972
		[Browsable(false)]
		public SortedList[] Optimal1DList
		{
			get
			{
				return this.optimal1DList;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000037 RID: 55 RVA: 0x0000297A File Offset: 0x0000197A
		[Browsable(false)]
		public Hashtable[,] Optimal2DList
		{
			get
			{
				return this.optimal2DList;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00002982 File Offset: 0x00001982
		[Browsable(false)]
		public double LastObjective
		{
			get
			{
				return this.fLastObjective;
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000298A File Offset: 0x0000198A
		private void Init()
		{
			this.fType = EOptimizerType.Optimizer;
			this.fNParamSubset = 0;
			this.fNObjectiveCalls = 0;
			this.fVerboseMode = EVerboseMode.Quiet;
			this.fLastObjective = 0.0;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000029B7 File Offset: 0x000019B7
		public Optimizer(IOptimizable Object)
		{
			this.fOptimizable = Object;
			this.Init();
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600003B RID: 59 RVA: 0x000029CC File Offset: 0x000019CC
		[Browsable(false)]
		public virtual int NObjectiveCalls
		{
			get
			{
				return this.fNObjectiveCalls;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600003C RID: 60 RVA: 0x000029D4 File Offset: 0x000019D4
		// (set) Token: 0x0600003D RID: 61 RVA: 0x000029DC File Offset: 0x000019DC
		[Browsable(false)]
		public IOptimizable Object
		{
			get
			{
				return this.fOptimizable;
			}
			set
			{
				this.fOptimizable = value;
				this.fOptimizable.Init(this);
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000029F1 File Offset: 0x000019F1
		public int GetNParamSubset()
		{
			return this.fNParamSubset;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000029F9 File Offset: 0x000019F9
		public void SetNParamSubset(int NParamSubset)
		{
			this.fNParamSubset = NParamSubset;
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00002A02 File Offset: 0x00001A02
		// (set) Token: 0x06000041 RID: 65 RVA: 0x00002A0A File Offset: 0x00001A0A
		[Browsable(false)]
		public int NParamSubset
		{
			get
			{
				return this.fNParamSubset;
			}
			set
			{
				this.fNParamSubset = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00002A13 File Offset: 0x00001A13
		[Category("Description")]
		[Description("Optimizer type")]
		public EOptimizerType OptimizerType
		{
			get
			{
				return this.fType;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00002A1B File Offset: 0x00001A1B
		// (set) Token: 0x06000044 RID: 68 RVA: 0x00002A23 File Offset: 0x00001A23
		[Description("Console output mode")]
		[Category("Output")]
		public EVerboseMode VerboseMode
		{
			get
			{
				return this.fVerboseMode;
			}
			set
			{
				this.fVerboseMode = value;
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002A2C File Offset: 0x00001A2C
		public virtual void Optimize()
		{
			this.stopped = false;
			this.fOptimizable.Init(this);
			this.fNParamSubset = base.GetNParam();
			this.fNObjectiveCalls = 0;
			this.optimal1DList = new SortedList[this.fNParamSubset];
			this.optimal2DList = new Hashtable[this.fNParamSubset, this.fNParamSubset];
			for (int i = 0; i < this.fNParamSubset; i++)
			{
				this.optimal1DList[i] = new SortedList();
			}
			for (int j = 0; j < this.fNParamSubset; j++)
			{
				for (int k = 0; k < this.fNParamSubset; k++)
				{
					this.optimal2DList[j, k] = new Hashtable();
				}
			}
			if (this.Inited != null)
			{
				this.Inited(this, EventArgs.Empty);
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002AF4 File Offset: 0x00001AF4
		public virtual double Objective()
		{
			this.fNObjectiveCalls++;
			if (this.fOptimizable != null)
			{
				double num = this.fOptimizable.Objective();
				this.fLastObjective = num;
				if (this.ObjectiveCalled != null)
				{
					this.ObjectiveCalled(this, EventArgs.Empty);
				}
				for (int i = 0; i < this.fNParamSubset; i++)
				{
					double num2 = base[i];
					if (!double.IsNaN(num2))
					{
						if (!this.optimal1DList[i].ContainsKey(num2) || (double)this.optimal1DList[i][num2] > num)
						{
							this.optimal1DList[i][num2] = num;
						}
						for (int j = i + 1; j < this.fNParamSubset; j++)
						{
							double num3 = base[j];
							if (!double.IsNaN(num3) && (!this.optimal2DList[i, j].ContainsKey(new TwoParams(num2, num3)) || (double)this.optimal2DList[i, j][new TwoParams(num2, num3)] > num))
							{
								this.optimal2DList[i, j][new TwoParams(num2, num3)] = num;
							}
						}
					}
				}
				return num;
			}
			return double.NaN;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002C5C File Offset: 0x00001C5C
		public virtual void OnStep()
		{
			if (this.fOptimizable != null)
			{
				this.fOptimizable.OnStep();
				if (this.StepCalled != null)
				{
					this.StepCalled(this, EventArgs.Empty);
				}
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002C8A File Offset: 0x00001C8A
		public virtual void OnCircle()
		{
			if (this.fOptimizable != null)
			{
				this.fOptimizable.OnCircle();
				if (this.CircleCalled != null)
				{
					this.CircleCalled(this, EventArgs.Empty);
				}
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002CB8 File Offset: 0x00001CB8
		public virtual void Update()
		{
			if (this.fOptimizable != null)
			{
				this.fOptimizable.Update(this);
				if (this.UpdateCalled != null)
				{
					this.UpdateCalled(this, EventArgs.Empty);
				}
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002CE7 File Offset: 0x00001CE7
		public void Stop()
		{
			this.stopped = true;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002CF0 File Offset: 0x00001CF0
		protected void EmitCompleted()
		{
			if (this.OptimizationCompleted != null)
			{
				this.OptimizationCompleted(this, EventArgs.Empty);
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002D0B File Offset: 0x00001D0B
		protected void EmitBestObjectiveReceived()
		{
			if (this.BestObjectiveReceived != null)
			{
				this.BestObjectiveReceived(this, EventArgs.Empty);
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002D28 File Offset: 0x00001D28
		public virtual void Print()
		{
			Console.WriteLine("Optimizer:         " + this.fType.ToString());
			Console.WriteLine("VerboseMode:       " + this.fVerboseMode.ToString());
			Console.WriteLine("# Objective Calls: " + this.fNObjectiveCalls);
			Console.WriteLine("# ParamSubsets:    " + this.fNParamSubset);
		}

		// Token: 0x0400001B RID: 27
		protected bool stopped;

		// Token: 0x0400001C RID: 28
		protected IOptimizable fOptimizable;

		// Token: 0x0400001D RID: 29
		protected EOptimizerType fType;

		// Token: 0x0400001E RID: 30
		protected int fNParamSubset;

		// Token: 0x0400001F RID: 31
		protected int fNObjectiveCalls;

		// Token: 0x04000020 RID: 32
		protected EVerboseMode fVerboseMode;

		// Token: 0x04000021 RID: 33
		protected double fLastObjective;

		// Token: 0x04000022 RID: 34
		protected SortedList[] optimal1DList;

		// Token: 0x04000023 RID: 35
		protected Hashtable[,] optimal2DList;
	}
}
