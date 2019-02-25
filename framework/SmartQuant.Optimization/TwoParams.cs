using System;

namespace SmartQuant.Optimization
{
	// Token: 0x0200000F RID: 15
	public struct TwoParams
	{
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600009C RID: 156 RVA: 0x000042DC File Offset: 0x000032DC
		public double Param1
		{
			get
			{
				return this.param1;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600009D RID: 157 RVA: 0x000042E4 File Offset: 0x000032E4
		public double Param2
		{
			get
			{
				return this.param2;
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000042EC File Offset: 0x000032EC
		public TwoParams(double param1, double param2)
		{
			this.param1 = param1;
			this.param2 = param2;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000042FC File Offset: 0x000032FC
		public override bool Equals(object obj)
		{
			TwoParams twoParams = (TwoParams)obj;
			return twoParams.param1 == this.param1 && twoParams.param2 == this.param2;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00004330 File Offset: 0x00003330
		public override int GetHashCode()
		{
			return 1;
		}

		// Token: 0x04000066 RID: 102
		private double param1;

		// Token: 0x04000067 RID: 103
		private double param2;
	}
}
