using System;

namespace SmartQuant.Optimization
{
	// Token: 0x02000007 RID: 7
	public class CoordinateDescent : Optimizer
	{
		// Token: 0x0600007F RID: 127 RVA: 0x00003F22 File Offset: 0x00002F22
		public CoordinateDescent(IOptimizable Optimizable) : base(Optimizable)
		{
			this.fType = EOptimizerType.CoordinateDescent;
			this.fDescentStepSize = 0.01;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00003F41 File Offset: 0x00002F41
		public double GetDescentStepSize()
		{
			return this.fDescentStepSize;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00003F49 File Offset: 0x00002F49
		public void SetDescentStepSize(double DescentStepSize)
		{
			this.fDescentStepSize = DescentStepSize;
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00003F52 File Offset: 0x00002F52
		// (set) Token: 0x06000083 RID: 131 RVA: 0x00003F5A File Offset: 0x00002F5A
		public double DescentStepSize
		{
			get
			{
				return this.fDescentStepSize;
			}
			set
			{
				this.fDescentStepSize = value;
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00003F64 File Offset: 0x00002F64
		private bool OptimizeParam(int i)
		{
			double num = this.fParam[i];
			double num2 = (this.fSteps[i] == 0.0) ? this.fDescentStepSize : this.fSteps[i];
			bool flag = false;
			bool flag2 = false;
			this.Update();
			this.fOldObjective = this.Objective();
			for (;;)
			{
				this.fParam[i] += num2;
				if (this.fParam[i] < this.fLowerBound[i])
				{
					this.fParam[i] = this.fLowerBound[i];
				}
				if (this.fParam[i] > this.fUpperBound[i])
				{
					this.fParam[i] = this.fUpperBound[i];
				}
				this.Update();
				this.fNewObjective = this.Objective();
				if (this.fNewObjective < this.fOldObjective)
				{
					this.fOldObjective = this.fNewObjective;
					num = this.fParam[i];
					flag2 = true;
				}
				else
				{
					this.fParam[i] = num;
					this.Update();
					if (flag2 || flag)
					{
						break;
					}
					num2 = -num2;
					flag = true;
				}
			}
			return flag2;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00004070 File Offset: 0x00003070
		public override void Optimize()
		{
			base.Optimize();
			bool flag = true;
			do
			{
				for (int i = 0; i < this.fNParam; i++)
				{
					if (!this.OptimizeParam(i))
					{
						flag = false;
					}
				}
			}
			while (!flag);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000040A4 File Offset: 0x000030A4
		public override void Print()
		{
			base.Print();
			Console.WriteLine("DescentStepSize:   " + this.fDescentStepSize);
		}

		// Token: 0x04000050 RID: 80
		private double fDescentStepSize;

		// Token: 0x04000051 RID: 81
		private double fOldObjective;

		// Token: 0x04000052 RID: 82
		private double fNewObjective;
	}
}
