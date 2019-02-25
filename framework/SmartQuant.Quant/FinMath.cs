using System;

namespace SmartQuant.Quant
{
	// Token: 0x02000008 RID: 8
	public class FinMath
	{
		// Token: 0x06000040 RID: 64 RVA: 0x00003A92 File Offset: 0x00002A92
		public static double FV1(double P, double r, double n)
		{
			return P * (1.0 + r * n);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00003AA3 File Offset: 0x00002AA3
		public static double FV2(double P, double r, double n)
		{
			return P * Math.Pow(1.0 + r, n);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00003AB8 File Offset: 0x00002AB8
		public static double FV3(double P, double r, double n, double m)
		{
			return P * Math.Pow(1.0 + r / m, n * m);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00003AD1 File Offset: 0x00002AD1
		public static double FV4(double P, double r, double n)
		{
			return P * Math.Exp(r * n);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00003ADD File Offset: 0x00002ADD
		public static double PV1(double F, double r, double n)
		{
			return F / (1.0 + r * n);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00003AEE File Offset: 0x00002AEE
		public static double PV2(double F, double r, double n)
		{
			return F / Math.Pow(1.0 + r, n);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00003B03 File Offset: 0x00002B03
		public static double PV3(double F, double r, double n, double m)
		{
			return F / Math.Pow(1.0 + r / m, n * m);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00003B1C File Offset: 0x00002B1C
		public static double PV4(double F, double r, double n)
		{
			return F / Math.Exp(r * n);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00003B28 File Offset: 0x00002B28
		public static double dPV2(double F, double r, double n)
		{
			return -F * n / Math.Pow(1.0 + r, n + 1.0);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00003B4A File Offset: 0x00002B4A
		public static double d2PV2(double F, double r, double n)
		{
			return F * n * (n + 1.0) / Math.Pow(1.0 + r, n + 2.0);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00003B78 File Offset: 0x00002B78
		public static double Fact(int n)
		{
			double num = 1.0;
			for (int i = 1; i <= n; i++)
			{
				num *= (double)i;
			}
			return num;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00003BA1 File Offset: 0x00002BA1
		public static double C(int m, int n)
		{
			return FinMath.Fact(n) / (FinMath.Fact(m) * FinMath.Fact(n - m));
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00003BB9 File Offset: 0x00002BB9
		public static double Binom(int m, int n, double p)
		{
			return FinMath.C(m, n) * Math.Pow(p, (double)m) * Math.Pow(1.0 - p, (double)(n - m));
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00003BE0 File Offset: 0x00002BE0
		public static double u(double t, double s, int n)
		{
			return Math.Exp(s * Math.Sqrt(t / (double)n));
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00003BF2 File Offset: 0x00002BF2
		public static double d(double t, double s, int n)
		{
			return Math.Exp(-s * Math.Sqrt(t / (double)n));
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00003C08 File Offset: 0x00002C08
		public static double p(double t, double s, int n, double r)
		{
			double num = FinMath.FV2(1.0, r, t / (double)n);
			double num2 = FinMath.u(t, s, n);
			double num3 = FinMath.d(t, s, n);
			return (num - num3) / (num2 - num3);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00003C44 File Offset: 0x00002C44
		public static double N(double z)
		{
			double num = 2.506628;
			double num2 = 0.3193815;
			double num3 = -0.3565638;
			double num4 = 1.7814779;
			double num5 = -1.821256;
			double num6 = 1.3302744;
			double num7;
			if (z > 0.0 || z == 0.0)
			{
				num7 = 1.0;
			}
			else
			{
				num7 = -1.0;
			}
			double num8 = 1.0 / (1.0 + 0.2316419 * num7 * z);
			return 0.5 + num7 * (0.5 - Math.Exp(-z * z / 2.0) / num * (num8 * (num2 + num8 * (num3 + num8 * (num4 + num8 * (num5 + num8 * num6))))));
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00003D2A File Offset: 0x00002D2A
		public static double n(double z)
		{
			return 1.0 / Math.Sqrt(6.2831853071795862) * Math.Exp(-0.5 * z * z);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00003D57 File Offset: 0x00002D57
		public static double Call(double S, double X)
		{
			return Math.Max(0.0, S - X);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00003D6A File Offset: 0x00002D6A
		public static double Put(double S, double X)
		{
			return Math.Max(0.0, X - S);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00003D80 File Offset: 0x00002D80
		public static double Payoff(double S, double X, EPutCall PutCall)
		{
			switch (PutCall)
			{
			case EPutCall.Call:
				return FinMath.Call(S, X);
			case EPutCall.Put:
				return FinMath.Put(S, X);
			default:
				return 0.0;
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00003DB8 File Offset: 0x00002DB8
		public static double Parity(double P, double S, double X, double t, double r, EPutCall PutCall)
		{
			switch (PutCall)
			{
			case EPutCall.Call:
				return P - (S - X * Math.Exp(-r * t));
			case EPutCall.Put:
				return P + (S - X * Math.Exp(-r * t));
			default:
				return 0.0;
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00003E04 File Offset: 0x00002E04
		public static double BM(double S, double X, double t, double s, double r, EPutCall PutCall, int n)
		{
			double num = 0.0;
			double x = FinMath.u(t, s, n);
			double x2 = FinMath.d(t, s, n);
			double p = FinMath.p(t, s, n, r);
			for (int i = 0; i <= n; i++)
			{
				num += FinMath.Binom(i, n, p) * FinMath.Payoff(S * Math.Pow(x, (double)i) * Math.Pow(x2, (double)(n - i)), X, PutCall);
			}
			return FinMath.PV4(num, r, t);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00003E83 File Offset: 0x00002E83
		public static double BM(double S, double X, double t, double s, double r, EPutCall PutCall)
		{
			return FinMath.BM(S, X, t, s, r, PutCall, 100);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00003E94 File Offset: 0x00002E94
		public static double MC(double S, double X, double t, double s, double r, EPutCall PutCall, int n)
		{
			double num = (r - 0.5 * s * s) * t;
			double num2 = s * Math.Sqrt(t);
			double num3 = 0.0;
			for (int i = 0; i < n; i++)
			{
				num3 += FinMath.Payoff(S * Math.Exp(num + num2 * Random.Gaus()), X, PutCall);
			}
			num3 /= (double)n;
			return FinMath.PV4(num3, r, t);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00003EFE File Offset: 0x00002EFE
		public static double MC(double S, double X, double t, double s, double r, EPutCall PutCall)
		{
			return FinMath.MC(S, X, t, s, r, PutCall, 100000);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00003F12 File Offset: 0x00002F12
		public static double d1(double S, double X, double t, double s, double r)
		{
			return (Math.Log(S / X) + (r + s * s / 2.0) * t) / (s * Math.Sqrt(t));
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00003F38 File Offset: 0x00002F38
		public static double d2(double S, double X, double t, double s, double r)
		{
			return FinMath.d1(S, X, t, s, r) - s * Math.Sqrt(t);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00003F50 File Offset: 0x00002F50
		public static double BS(double S, double X, double t, double s, double r, EPutCall PutCall)
		{
			switch (PutCall)
			{
			case EPutCall.Call:
				return S * FinMath.N(FinMath.d1(S, X, t, s, r)) - X * Math.Exp(-r * t) * FinMath.N(FinMath.d2(S, X, t, s, r));
			case EPutCall.Put:
				return -S * FinMath.N(-FinMath.d1(S, X, t, s, r)) + X * Math.Exp(-r * t) * FinMath.N(-FinMath.d2(S, X, t, s, r));
			default:
				return 0.0;
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00003FE0 File Offset: 0x00002FE0
		public static double Delta(double S, double X, double t, double s, double r, EPutCall PutCall)
		{
			switch (PutCall)
			{
			case EPutCall.Call:
				return FinMath.N(FinMath.d1(S, X, t, s, r));
			case EPutCall.Put:
				return FinMath.N(FinMath.d1(S, X, t, s, r)) - 1.0;
			default:
				return 0.0;
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00004035 File Offset: 0x00003035
		public static double Gamma(double S, double X, double t, double s, double r)
		{
			return FinMath.n(FinMath.d1(S, X, t, s, r)) / (S * s * Math.Sqrt(t));
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00004054 File Offset: 0x00003054
		public static double Theta(double S, double X, double t, double s, double r, EPutCall PutCall)
		{
			switch (PutCall)
			{
			case EPutCall.Call:
				return -S * FinMath.n(FinMath.d1(S, X, t, s, r)) * s / (2.0 * Math.Sqrt(t)) - r * X * Math.Exp(-r * t) * FinMath.N(FinMath.d2(S, X, t, s, r));
			case EPutCall.Put:
				return -S * FinMath.n(FinMath.d1(S, X, t, s, r)) * s / (2.0 * Math.Sqrt(t)) + r * X * Math.Exp(-r * t) * FinMath.N(-FinMath.d2(S, X, t, s, r));
			default:
				return 0.0;
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00004111 File Offset: 0x00003111
		public static double Vega(double S, double X, double t, double s, double r)
		{
			return S * Math.Sqrt(t) * FinMath.n(FinMath.d1(S, X, t, s, r));
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000412C File Offset: 0x0000312C
		public static double Rho(double S, double X, double t, double s, double r, EPutCall PutCall)
		{
			switch (PutCall)
			{
			case EPutCall.Call:
				return X * t * Math.Exp(-r * t) * FinMath.N(FinMath.d2(S, X, t, s, r));
			case EPutCall.Put:
				return -X * t * Math.Exp(-r * t) * FinMath.N(-FinMath.d2(S, X, t, s, r));
			default:
				return 0.0;
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00004198 File Offset: 0x00003198
		public static double ImpliedVolatility(double S, double X, double t, double r, double P, EOptionType OptionType, EPutCall PutCall, EOptionPrice Method, int n, double Eps)
		{
			double num = 0.0;
			double num2 = 10.0;
			double num3 = 0.0;
			double num4 = 0.0;
			while (Math.Abs(num2 - num) > Eps)
			{
				num4 = num + (num2 - num) / 2.0;
				switch (Method)
				{
				case EOptionPrice.BlackScholes:
					num3 = FinMath.BS(S, X, t, num4, r, PutCall);
					break;
				case EOptionPrice.Binomial:
					num3 = FinMath.BM(S, X, t, num4, r, PutCall, n);
					break;
				case EOptionPrice.MonteCarlo:
					num3 = FinMath.MC(S, X, t, num4, r, PutCall, n);
					break;
				}
				if (num3 > P)
				{
					num2 = num4;
				}
				else
				{
					num = num4;
				}
			}
			return num4;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00004244 File Offset: 0x00003244
		public static double ImpliedVolatility(double S, double X, double t, double r, double P, EOptionType OptionType, EPutCall PutCall, EOptionPrice Method)
		{
			int n = 0;
			switch (Method)
			{
			case EOptionPrice.Binomial:
				n = 100;
				break;
			case EOptionPrice.MonteCarlo:
				n = 100000;
				break;
			}
			double eps = 0.001;
			return FinMath.ImpliedVolatility(S, X, t, r, P, OptionType, PutCall, Method, n, eps);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00004294 File Offset: 0x00003294
		public static double FuturesPrice(double S, double t, double r)
		{
			return S * Math.Exp(r * t);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000042A0 File Offset: 0x000032A0
		public static double FuturesPrice(double S, double t, double r, double I)
		{
			return (S - I) * Math.Exp(r * t);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000042AE File Offset: 0x000032AE
		public static double Min(double Value1, double Value2, double Value3)
		{
			return Math.Min(Math.Min(Value1, Value2), Value3);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000042BD File Offset: 0x000032BD
		public static double Max(double Value1, double Value2, double Value3)
		{
			return Math.Max(Math.Max(Value1, Value2), Value3);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000042CC File Offset: 0x000032CC
		public static int Min(int Value1, int Value2, int Value3)
		{
			return Math.Min(Math.Min(Value1, Value2), Value3);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000042DB File Offset: 0x000032DB
		public static int Max(int Value1, int Value2, int Value3)
		{
			return Math.Max(Math.Max(Value1, Value2), Value3);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000042EA File Offset: 0x000032EA
		public static DateTime Min(DateTime DateTime1, DateTime DateTime2)
		{
			if (DateTime1 <= DateTime2)
			{
				return DateTime1;
			}
			return DateTime2;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000042F8 File Offset: 0x000032F8
		public static DateTime Max(DateTime DateTime1, DateTime DateTime2)
		{
			if (DateTime1 >= DateTime2)
			{
				return DateTime1;
			}
			return DateTime2;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00004306 File Offset: 0x00003306
		public static DateTime Min(DateTime DateTime1, DateTime DateTime2, DateTime DateTime3)
		{
			return FinMath.Min(FinMath.Min(DateTime1, DateTime2), DateTime3);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00004315 File Offset: 0x00003315
		public static DateTime Max(DateTime DateTime1, DateTime DateTime2, DateTime DateTime3)
		{
			return FinMath.Max(FinMath.Max(DateTime1, DateTime2), DateTime3);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00004324 File Offset: 0x00003324
		public static double Percentile(double Level, double[] Data)
		{
			if (Level < 0.0 || Level > 100.0)
			{
				throw new ArgumentException("Can not calculate percentile. Percentile value should be between 0 and 100");
			}
			if (Data == null)
			{
				throw new ArgumentException("Can not calculate percentile. Data array can not be null");
			}
			int num = Data.Length;
			double[] array = new double[num];
			Data.CopyTo(array, 0);
			Array.Sort<double>(array);
			double num2 = Level / 100.0 * (double)(num + 1) - 1.0;
			int num3 = (int)num2;
			double num4 = num2 - (double)num3;
			if (num3 < 0)
			{
				return array[0];
			}
			if (num3 >= num - 1)
			{
				return array[num - 1];
			}
			if (num4 == 0.0)
			{
				return array[num3];
			}
			return array[num3] + (array[num3 + 1] - array[num3]) * num4;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000043D4 File Offset: 0x000033D4
		public static int BinarySearch(int n, double[] SearchArray, double SearchValue)
		{
			int num = n + 1;
			int num2 = 0;
			while (num - num2 > 1)
			{
				int num3 = (num + num2) / 2;
				if (SearchValue == SearchArray[num3 - 1])
				{
					return num3 - 1;
				}
				if (SearchValue < SearchArray[num3 - 1])
				{
					num = num3;
				}
				else
				{
					num2 = num3;
				}
			}
			return num2 - 1;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00004414 File Offset: 0x00003414
		public static int BinarySearch(int n, int[] SearchArray, int SearchValue)
		{
			int num = n + 1;
			int num2 = 0;
			while (num - num2 > 1)
			{
				int num3 = (num + num2) / 2;
				if (SearchValue == SearchArray[num3 - 1])
				{
					return num3 - 1;
				}
				if (SearchValue < SearchArray[num3 - 1])
				{
					num = num3;
				}
				else
				{
					num2 = num3;
				}
			}
			return num2 - 1;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00004452 File Offset: 0x00003452
		public static double Distance(double X1, double Y1, double X2, double Y2)
		{
			return Math.Sqrt(Math.Pow(X1 - X2, 2.0) + Math.Pow(Y1 - Y2, 2.0));
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000447C File Offset: 0x0000347C
		public static double Distance(double X1, double Y1, double Z1, double X2, double Y2, double Z2)
		{
			return Math.Sqrt(Math.Pow(X1 - X2, 2.0) + Math.Pow(Y1 - Y2, 2.0) + Math.Pow(Z1 - Z2, 2.0));
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000044BA File Offset: 0x000034BA
		public static double Percent(double P, double Base)
		{
			return Base / 100.0 * P;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000044CC File Offset: 0x000034CC
		public static int GetNDays(DateTime Date1, DateTime Date2)
		{
			return (Date1 - Date2).Days;
		}
	}
}
