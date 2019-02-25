using System;
using System.Drawing;

namespace SmartQuant.Charting.Draw3D
{
	// Token: 0x02000035 RID: 53
	public class TLight
	{
		// Token: 0x06000295 RID: 661 RVA: 0x0000AC5C File Offset: 0x00009C5C
		public TLight()
		{
			this.SetSfumatoDay();
			this.SetShadowSources(0.25);
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0000ACEC File Offset: 0x00009CEC
		public void SetSfumatoDay()
		{
			this.Ambient = new TColor(0.55, 0.55, 0.7);
			this.ParallelBeams[0].c = 2.05 * new TColor(1.0, 1.0, 0.55);
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0000AD60 File Offset: 0x00009D60
		public void SetNormalDay()
		{
			this.SetSfumatoDay();
			this.Ambient *= 1.1;
			TLight.TSource[] parallelBeams = this.ParallelBeams;
			int num = 0;
			parallelBeams[num].c = parallelBeams[num].c * 1.1;
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0000ADB4 File Offset: 0x00009DB4
		public void SetVeryBrightDay()
		{
			this.SetSfumatoDay();
			this.Ambient *= 1.2;
			TLight.TSource[] parallelBeams = this.ParallelBeams;
			int num = 0;
			parallelBeams[num].c = parallelBeams[num].c * 1.2;
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0000AE08 File Offset: 0x00009E08
		public void SetShadowSources(double K)
		{
			TLight.TSource[] array = new TLight.TSource[2 * this.ParallelBeams.Length];
			for (int i = 0; i < this.ParallelBeams.Length; i++)
			{
				int num = 2 * i;
				array[num] = this.ParallelBeams[i];
				array[num + 1].o = -array[num].o;
				array[num + 1].c = -K * array[num].c;
			}
			this.ParallelBeams = array;
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0000AEA0 File Offset: 0x00009EA0
		public virtual TColor Result(TVec3 r, TVec3 n, TColor Diffuse)
		{
			TColor tcolor = this.Ambient;
			foreach (TLight.TSource tsource in this.ParallelBeams)
			{
				double num = n * tsource.o;
				if (num >= 0.0)
				{
					double k = num * num / (n * n * (tsource.o * tsource.o));
					tcolor += k * tsource.c;
				}
			}
			foreach (TLight.TSource tsource2 in this.NearSources)
			{
				TVec3 tvec = tsource2.o - r;
				double num2 = n * tvec;
				double num3 = tvec * tvec;
				if (num2 >= 0.0)
				{
					double k2 = num2 * num2 / (n * n * num3 * num3);
					tcolor += k2 * tsource2.c;
				}
			}
			return Diffuse * tcolor;
		}

		// Token: 0x04000122 RID: 290
		public TColor Ambient = new TColor(Color.PaleTurquoise);

		// Token: 0x04000123 RID: 291
		public TLight.TSource[] ParallelBeams = new TLight.TSource[]
		{
			new TLight.TSource(new TVec3(3.0, -2.0, 2.0), Color.LightYellow)
		};

		// Token: 0x04000124 RID: 292
		public TLight.TSource[] NearSources = new TLight.TSource[0];

		// Token: 0x02000036 RID: 54
		public struct TSource
		{
			// Token: 0x0600029B RID: 667 RVA: 0x0000AFB9 File Offset: 0x00009FB9
			public TSource(TVec3 o, TColor c)
			{
				this.o = o;
				this.c = c;
			}

			// Token: 0x04000125 RID: 293
			public TVec3 o;

			// Token: 0x04000126 RID: 294
			public TColor c;
		}
	}
}
