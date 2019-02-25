using System;

namespace SmartQuant.Quant
{
	// Token: 0x02000009 RID: 9
	public class Random
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000076 RID: 118 RVA: 0x000044F0 File Offset: 0x000034F0
		// (set) Token: 0x06000077 RID: 119 RVA: 0x000044F7 File Offset: 0x000034F7
		public static double Seed1
		{
			get
			{
				return Random.fSeed1;
			}
			set
			{
				Random.fSeed1 = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000078 RID: 120 RVA: 0x000044FF File Offset: 0x000034FF
		// (set) Token: 0x06000079 RID: 121 RVA: 0x00004506 File Offset: 0x00003506
		public static double Seed2
		{
			get
			{
				return Random.fSeed2;
			}
			set
			{
				Random.fSeed2 = value;
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00004518 File Offset: 0x00003518
		public static double Rndm()
		{
			int num = (int)Random.fSeed1 / 53668;
			Random.fSeed1 = 40014.0 * (Random.fSeed1 - (double)(num * 53668)) - (double)(num * 12211);
			if (Random.fSeed1 < 0.0)
			{
				Random.fSeed1 += 2147483563.0;
			}
			num = (int)Random.fSeed2 / 52774;
			Random.fSeed2 = 40692.0 * (Random.fSeed2 - (double)(num * 52774)) - (double)(num * 3791);
			if (Random.fSeed2 < 0.0)
			{
				Random.fSeed2 += 2147483399.0;
			}
			double num2 = Random.fSeed1 - Random.fSeed2;
			if (num2 <= 0.0)
			{
				num2 += 2147483562.0;
			}
			return num2 * 4.6566128E-10;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00004604 File Offset: 0x00003604
		public static int Binomial(int ntot, double prob)
		{
			if (prob < 0.0 || prob > 1.0)
			{
				return 0;
			}
			int num = 0;
			for (int i = 0; i < ntot; i++)
			{
				if (Random.Rndm() <= prob)
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00004648 File Offset: 0x00003648
		public static double Gaus(double mean, double sigma)
		{
			double num;
			do
			{
				num = Random.Rndm();
			}
			while (num == 0.0);
			double num2 = Random.Rndm();
			double a = num2 * 6.283185;
			return mean + sigma * Math.Sin(a) * Math.Sqrt(-2.0 * Math.Log(num));
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000469B File Offset: 0x0000369B
		public static double Gaus()
		{
			return Random.Gaus(0.0, 1.0);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000046B4 File Offset: 0x000036B4
		public static int Poisson(double mean)
		{
			if (mean <= 0.0)
			{
				return 0;
			}
			if (mean > 88.0)
			{
				return (int)(Random.Gaus(0.0, 1.0) * Math.Sqrt(mean) + mean + 0.5);
			}
			double num = Math.Exp(-mean);
			double num2 = 1.0;
			int num3 = -1;
			do
			{
				num3++;
				num2 *= Random.Rndm();
			}
			while (num2 > num);
			return num3;
		}

		// Token: 0x04000017 RID: 23
		private static double fSeed1 = 9876.0;

		// Token: 0x04000018 RID: 24
		private static double fSeed2 = 54321.0;
	}
}
