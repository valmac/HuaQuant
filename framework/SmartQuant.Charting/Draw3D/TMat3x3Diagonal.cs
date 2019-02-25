using System;

namespace SmartQuant.Charting.Draw3D
{
	// Token: 0x0200000B RID: 11
	public class TMat3x3Diagonal : TMat3x3
	{
		// Token: 0x060000A7 RID: 167 RVA: 0x0000379D File Offset: 0x0000279D
		public TMat3x3Diagonal(double lx, double ly, double lz)
		{
			base.SetDiagonal(lx, ly, lz);
		}
	}
}
