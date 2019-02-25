using System;

namespace SmartQuant.Optimization
{
	// Token: 0x0200000B RID: 11
	public abstract class TOptimizable : IOptimizable
	{
		// Token: 0x06000096 RID: 150 RVA: 0x000042CC File Offset: 0x000032CC
		public virtual void Init(ParamSet paramSet)
		{
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000042CE File Offset: 0x000032CE
		public virtual void Update(ParamSet paramSet)
		{
		}

		// Token: 0x06000098 RID: 152
		public abstract double Objective();

		// Token: 0x06000099 RID: 153 RVA: 0x000042D0 File Offset: 0x000032D0
		public virtual void OnStep()
		{
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000042D2 File Offset: 0x000032D2
		public virtual void OnCircle()
		{
		}
	}
}
