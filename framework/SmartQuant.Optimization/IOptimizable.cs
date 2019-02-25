using System;

namespace SmartQuant.Optimization
{
	// Token: 0x0200000A RID: 10
	public interface IOptimizable
	{
		// Token: 0x06000091 RID: 145
		void Init(ParamSet paramSet);

		// Token: 0x06000092 RID: 146
		void Update(ParamSet paramSet);

		// Token: 0x06000093 RID: 147
		double Objective();

		// Token: 0x06000094 RID: 148
		void OnStep();

		// Token: 0x06000095 RID: 149
		void OnCircle();
	}
}
