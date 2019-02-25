using System;

namespace SmartQuant.Optimization
{
	// Token: 0x02000008 RID: 8
	[AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
	public class OptimizationParameterAttribute : Attribute
	{
		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000087 RID: 135 RVA: 0x000040C6 File Offset: 0x000030C6
		public double LowerBound
		{
			get
			{
				return this.fLowerBound;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000088 RID: 136 RVA: 0x000040CE File Offset: 0x000030CE
		public double UpperBound
		{
			get
			{
				return this.fUpperBound;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000089 RID: 137 RVA: 0x000040D6 File Offset: 0x000030D6
		public double Step
		{
			get
			{
				return this.fStep;
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000040DE File Offset: 0x000030DE
		public OptimizationParameterAttribute(double lowerBound, double upperBound, double step)
		{
			this.fLowerBound = lowerBound;
			this.fUpperBound = upperBound;
			this.fStep = step;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000040FB File Offset: 0x000030FB
		public OptimizationParameterAttribute(double lowerBound, double upperBound)
		{
			this.fLowerBound = lowerBound;
			this.fUpperBound = upperBound;
			this.fStep = 1.0;
		}

		// Token: 0x04000053 RID: 83
		private double fLowerBound;

		// Token: 0x04000054 RID: 84
		private double fUpperBound;

		// Token: 0x04000055 RID: 85
		private double fStep;
	}
}
