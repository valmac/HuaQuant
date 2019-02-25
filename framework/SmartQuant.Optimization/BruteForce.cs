using System;
using System.Windows.Forms;

namespace SmartQuant.Optimization
{
	// Token: 0x02000009 RID: 9
	public class BruteForce : Optimizer
	{
		// Token: 0x0600008C RID: 140 RVA: 0x00004120 File Offset: 0x00003120
		public BruteForce(IOptimizable Optimizable) : base(Optimizable)
		{
			this.fType = EOptimizerType.BruteForce;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00004130 File Offset: 0x00003130
		private void OptimizeParam(int i)
		{
			if (this.stopped)
			{
				return;
			}
			if (i >= this.fNParam)
			{
				this.Step();
				return;
			}
			if (this.fIsParamFixed[i])
			{
				this.OptimizeParam(i++);
				return;
			}
			for (double num = this.fLowerBound[i]; num <= this.fUpperBound[i]; num += this.fSteps[i])
			{
				this.fParam[i] = num;
				this.OptimizeParam(i + 1);
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000041A0 File Offset: 0x000031A0
		public void Step()
		{
			this.Update();
			this.fNewObjective = this.Objective();
			if (this.fNewObjective < this.fOldObjective)
			{
				this.fOldObjective = this.fNewObjective;
				for (int i = 0; i < this.fNParam; i++)
				{
					this.fOptParam[i] = this.fParam[i];
				}
			}
			this.OnStep();
			Application.DoEvents();
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00004208 File Offset: 0x00003208
		public override void Optimize()
		{
			base.Optimize();
			this.fOptParam = new double[this.fNParam];
			this.fOldObjective = double.MaxValue;
			this.OptimizeParam(0);
			for (int i = 0; i < this.fNParam; i++)
			{
				this.fParam[i] = this.fOptParam[i];
			}
			this.Update();
			base.EmitBestObjectiveReceived();
			this.fNewObjective = this.Objective();
			base.Update();
			if (this.fVerboseMode == EVerboseMode.Debug)
			{
				for (int i = 0; i < this.fNParam; i++)
				{
					Console.WriteLine("Param[{0}] = {1}", i, this.fParam[i]);
				}
				base.Print();
			}
			base.EmitCompleted();
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000042C4 File Offset: 0x000032C4
		public override void Print()
		{
			base.Print();
		}

		// Token: 0x04000056 RID: 86
		private double fOldObjective;

		// Token: 0x04000057 RID: 87
		private double fNewObjective;

		// Token: 0x04000058 RID: 88
		private double[] fOptParam;
	}
}
