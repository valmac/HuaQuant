using System;
using System.Drawing;

namespace SmartQuant.Charting.Draw3D
{
	// Token: 0x02000017 RID: 23
	public struct TVec3
	{
		// Token: 0x060000C9 RID: 201 RVA: 0x000042CC File Offset: 0x000032CC
		public TVec3(double X, double Y, double Z)
		{
			this.x = X;
			this.y = Y;
			this.z = Z;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x000042E3 File Offset: 0x000032E3
		public TVec3(TVec3 v)
		{
			this.x = v.x;
			this.y = v.y;
			this.z = v.z;
		}

		// Token: 0x17000037 RID: 55
		public double this[int i]
		{
			get
			{
				if (i == 0)
				{
					return this.x;
				}
				if (i != 1)
				{
					return this.z;
				}
				return this.y;
			}
			set
			{
				if (i == 0)
				{
					this.x = value;
					return;
				}
				if (i == 1)
				{
					this.y = value;
					return;
				}
				this.z = value;
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00004349 File Offset: 0x00003349
		public static implicit operator Point(TVec3 v)
		{
			return new Point((int)v.x, (int)v.y);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00004360 File Offset: 0x00003360
		public static implicit operator PointF(TVec3 v)
		{
			return new PointF((float)v.x, (float)v.y);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00004378 File Offset: 0x00003378
		public static Point[] PointArray(TVec3[] v)
		{
			Point[] array = new Point[v.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = v[i];
			}
			return array;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000043BA File Offset: 0x000033BA
		public static TVec3 operator +(TVec3 a)
		{
			return a;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000043BD File Offset: 0x000033BD
		public static TVec3 operator -(TVec3 a)
		{
			return new TVec3(-a.x, -a.y, -a.z);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000043DC File Offset: 0x000033DC
		public static TVec3 operator +(TVec3 a, TVec3 b)
		{
			return new TVec3(a.x + b.x, a.y + b.y, a.z + b.z);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00004410 File Offset: 0x00003410
		public static TVec3 operator -(TVec3 a, TVec3 b)
		{
			return new TVec3(a.x - b.x, a.y - b.y, a.z - b.z);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00004444 File Offset: 0x00003444
		public static TVec3 operator ^(TVec3 a, TVec3 b)
		{
			return new TVec3(a.y * b.z - a.z * b.y, a.z * b.x - a.x * b.z, a.x * b.y - a.y * b.x);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x000044B3 File Offset: 0x000034B3
		public static TVec3 operator *(double k, TVec3 a)
		{
			return new TVec3(k * a.x, k * a.y, k * a.z);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000044D5 File Offset: 0x000034D5
		public static TVec3 operator *(TVec3 a, double k)
		{
			return k * a;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x000044DE File Offset: 0x000034DE
		public static TVec3 operator /(TVec3 a, double d)
		{
			return new TVec3(a.x / d, a.y / d, a.z / d);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00004500 File Offset: 0x00003500
		public static double operator *(TVec3 a, TVec3 b)
		{
			return a.x * b.x + a.y * b.y + a.z * b.z;
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00004531 File Offset: 0x00003531
		public double Sqr
		{
			get
			{
				return this * this;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000DA RID: 218 RVA: 0x00004544 File Offset: 0x00003544
		public double Norm1
		{
			get
			{
				return Math.Abs(this.x) + Math.Abs(this.y) + Math.Abs(this.z);
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00004569 File Offset: 0x00003569
		public double Norm2
		{
			get
			{
				return Math.Sqrt(this.Sqr);
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000DC RID: 220 RVA: 0x00004578 File Offset: 0x00003578
		public double NormInf
		{
			get
			{
				double num = Math.Abs(this.x);
				double num2 = Math.Abs(this.y);
				double num3 = Math.Abs(this.z);
				if (num <= num2)
				{
					if (num2 <= num3)
					{
						return num3;
					}
					return num2;
				}
				else
				{
					if (num <= num3)
					{
						return num3;
					}
					return num;
				}
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000DD RID: 221 RVA: 0x000045BC File Offset: 0x000035BC
		public static TVec3 O
		{
			get
			{
				return new TVec3(0.0, 0.0, 0.0);
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000DE RID: 222 RVA: 0x000045DE File Offset: 0x000035DE
		public static TVec3 ex
		{
			get
			{
				return new TVec3(1.0, 0.0, 0.0);
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00004600 File Offset: 0x00003600
		public static TVec3 ey
		{
			get
			{
				return new TVec3(0.0, 1.0, 0.0);
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00004622 File Offset: 0x00003622
		public static TVec3 ez
		{
			get
			{
				return new TVec3(0.0, 0.0, 1.0);
			}
		}

		// Token: 0x04000054 RID: 84
		public double x;

		// Token: 0x04000055 RID: 85
		public double y;

		// Token: 0x04000056 RID: 86
		public double z;
	}
}
