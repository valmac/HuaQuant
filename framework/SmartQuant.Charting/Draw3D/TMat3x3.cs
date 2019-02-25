using System;

namespace SmartQuant.Charting.Draw3D
{
	// Token: 0x0200000A RID: 10
	public class TMat3x3
	{
		// Token: 0x0600007A RID: 122 RVA: 0x00003177 File Offset: 0x00002177
		public TMat3x3()
		{
			this.m = new double[3, 3];
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000318C File Offset: 0x0000218C
		public TMat3x3(double x) : this()
		{
			double[,] array = this.m;
			int num = 0;
			int num2 = 0;
			double[,] array2 = this.m;
			int num3 = 1;
			int num4 = 1;
			this.m[2, 2] = x;
			double num5;
			array2[num3, num4] = (num5 = x);
			array[num, num2] = num5;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000031D0 File Offset: 0x000021D0
		public TMat3x3(double a, double b, double c, double d, double e, double f, double g, double h, double i) : this()
		{
			this.m[0, 0] = a;
			this.m[0, 1] = b;
			this.m[0, 2] = c;
			this.m[1, 0] = d;
			this.m[1, 1] = e;
			this.m[1, 2] = f;
			this.m[2, 0] = g;
			this.m[2, 1] = h;
			this.m[2, 2] = i;
		}

		// Token: 0x17000027 RID: 39
		public double this[int i, int j]
		{
			get
			{
				return this.m[i, j];
			}
			set
			{
				this.m[i, j] = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00003286 File Offset: 0x00002286
		// (set) Token: 0x06000080 RID: 128 RVA: 0x00003295 File Offset: 0x00002295
		public double xx
		{
			get
			{
				return this.m[0, 0];
			}
			set
			{
				this.m[0, 0] = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000081 RID: 129 RVA: 0x000032A5 File Offset: 0x000022A5
		// (set) Token: 0x06000082 RID: 130 RVA: 0x000032B4 File Offset: 0x000022B4
		public double xy
		{
			get
			{
				return this.m[0, 1];
			}
			set
			{
				this.m[0, 0] = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000083 RID: 131 RVA: 0x000032C4 File Offset: 0x000022C4
		// (set) Token: 0x06000084 RID: 132 RVA: 0x000032D3 File Offset: 0x000022D3
		public double xz
		{
			get
			{
				return this.m[0, 2];
			}
			set
			{
				this.m[0, 0] = value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000085 RID: 133 RVA: 0x000032E3 File Offset: 0x000022E3
		// (set) Token: 0x06000086 RID: 134 RVA: 0x000032F2 File Offset: 0x000022F2
		public double yx
		{
			get
			{
				return this.m[1, 0];
			}
			set
			{
				this.m[1, 0] = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00003302 File Offset: 0x00002302
		// (set) Token: 0x06000088 RID: 136 RVA: 0x00003311 File Offset: 0x00002311
		public double yy
		{
			get
			{
				return this.m[1, 1];
			}
			set
			{
				this.m[1, 1] = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00003321 File Offset: 0x00002321
		// (set) Token: 0x0600008A RID: 138 RVA: 0x00003330 File Offset: 0x00002330
		public double yz
		{
			get
			{
				return this.m[1, 2];
			}
			set
			{
				this.m[1, 2] = value;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00003340 File Offset: 0x00002340
		// (set) Token: 0x0600008C RID: 140 RVA: 0x0000334F File Offset: 0x0000234F
		public double zx
		{
			get
			{
				return this.m[2, 0];
			}
			set
			{
				this.m[2, 0] = value;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600008D RID: 141 RVA: 0x0000335F File Offset: 0x0000235F
		// (set) Token: 0x0600008E RID: 142 RVA: 0x0000336E File Offset: 0x0000236E
		public double zy
		{
			get
			{
				return this.m[2, 1];
			}
			set
			{
				this.m[2, 1] = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600008F RID: 143 RVA: 0x0000337E File Offset: 0x0000237E
		// (set) Token: 0x06000090 RID: 144 RVA: 0x0000338D File Offset: 0x0000238D
		public double zz
		{
			get
			{
				return this.m[2, 2];
			}
			set
			{
				this.m[2, 2] = value;
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000033A0 File Offset: 0x000023A0
		public static bool operator ==(TMat3x3 b, TMat3x3 a)
		{
			return b.xx == a.xx && b.xy == a.xy && b.xz == a.xz && b.yx == a.yx && b.yy == a.yy && b.yz == a.xz && b.zx == a.zx && b.zy == a.zy && b.zz == a.xz;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000342D File Offset: 0x0000242D
		public static bool operator !=(TMat3x3 b, TMat3x3 a)
		{
			return !(b == a);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000343C File Offset: 0x0000243C
		public static TMat3x3 operator -(TMat3x3 m)
		{
			return new TMat3x3(-m.xx, -m.xy, -m.xz, -m.yx, -m.yy, -m.yz, -m.zx, -m.zy, -m.zz);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00003490 File Offset: 0x00002490
		public static TMat3x3 operator *(TMat3x3 b, TMat3x3 a)
		{
			TMat3x3 tmat3x = new TMat3x3();
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					for (int k = 0; k < 3; k++)
					{
						TMat3x3 tmat3x2;
						int i2;
						int j2;
						(tmat3x2 = tmat3x)[i2 = i, j2 = j] = tmat3x2[i2, j2] + b[i, k] * a[k, j];
					}
				}
			}
			return tmat3x;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000034F8 File Offset: 0x000024F8
		public static TMat3x3 operator *(double k, TMat3x3 m)
		{
			TMat3x3 tmat3x = new TMat3x3();
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					tmat3x[i, j] = k * m[i, j];
				}
			}
			return tmat3x;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00003536 File Offset: 0x00002536
		public static TMat3x3 operator *(TMat3x3 m, double k)
		{
			return k * m;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00003540 File Offset: 0x00002540
		public static TVec3 operator *(TMat3x3 m, TVec3 v)
		{
			TVec3 result = default(TVec3);
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					ref TVec3 ptr = ref result;
					int i2;
					result[i2 = i] = ptr[i2] + m[i, j] * v[j];
				}
			}
			return result;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00003598 File Offset: 0x00002598
		public static TVec3 operator *(TVec3 v, TMat3x3 m)
		{
			TVec3 result = default(TVec3);
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					ref TVec3 ptr = ref result;
					int i2;
					result[i2 = j] = ptr[i2] + v[i] * m[i, j];
				}
			}
			return result;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000035F0 File Offset: 0x000025F0
		public void SetZero()
		{
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					this.m[i, j] = 0.0;
				}
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000362C File Offset: 0x0000262C
		public void SetNumber(double k)
		{
			this.SetZero();
			for (int i = 0; i < 3; i++)
			{
				this.m[i, i] = k;
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00003659 File Offset: 0x00002659
		public void SetUnit()
		{
			this.SetNumber(1.0);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000366A File Offset: 0x0000266A
		public void SetDiagonal(double lx, double ly, double lz)
		{
			this.SetZero();
			this.xx = lx;
			this.yy = ly;
			this.zz = lz;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00003688 File Offset: 0x00002688
		public void SetRot(int i1, int i2, double Angle)
		{
			this.SetUnit();
			this.m[i1, i1] = (this.m[i2, i2] = Math.Cos(Angle));
			this.m[i1, i2] = -(this.m[i2, i1] = Math.Sin(Angle));
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000036E2 File Offset: 0x000026E2
		public void SetRotYZ(double Angle)
		{
			this.SetRot(1, 2, Angle);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000036ED File Offset: 0x000026ED
		public void SetRotZX(double Angle)
		{
			this.SetRot(2, 0, Angle);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000036F8 File Offset: 0x000026F8
		public void SetRotXY(double Angle)
		{
			this.SetRot(0, 1, Angle);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00003703 File Offset: 0x00002703
		public void SetRotX(double Angle)
		{
			this.SetRotYZ(Angle);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0000370C File Offset: 0x0000270C
		public void SetRotY(double Angle)
		{
			this.SetRotZX(Angle);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00003715 File Offset: 0x00002715
		public void SetRotZ(double Angle)
		{
			this.SetRotXY(Angle);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00003720 File Offset: 0x00002720
		public void SetExchangeAxes(int i, int j)
		{
			this.SetUnit();
			this.m[i, i] = (this.m[j, j] = 0.0);
			this.m[i, j] = (this.m[j, i] = 1.0);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000377F File Offset: 0x0000277F
		public void SetExchangeYZ()
		{
			this.SetExchangeAxes(1, 2);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00003789 File Offset: 0x00002789
		public void SetSpecialProjection(double Angle)
		{
			this.SetUnit();
			this.zy = Math.Sin(Angle);
		}

		// Token: 0x04000033 RID: 51
		private double[,] m;
	}
}
