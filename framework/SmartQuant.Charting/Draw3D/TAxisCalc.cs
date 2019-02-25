using System;

namespace SmartQuant.Charting.Draw3D
{
	// Token: 0x02000031 RID: 49
	public class TAxisCalc
	{
		// Token: 0x06000271 RID: 625 RVA: 0x0000A614 File Offset: 0x00009614
		public TAxisCalc(TVec3 Origin, TVec3 End, double ValO, double ValEnd, int nTicks)
		{
			this.Origin = Origin;
			this.End = End;
			this.ValO = ValO;
			this.ValEnd = ValEnd;
			this.n = nTicks;
			this.SetTicks();
			this.SetTickPositions();
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000272 RID: 626 RVA: 0x0000A664 File Offset: 0x00009664
		public int nTicks
		{
			get
			{
				return this.n;
			}
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0000A66C File Offset: 0x0000966C
		public double TickVal(int i)
		{
			return this.ticks[i].Value;
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0000A67F File Offset: 0x0000967F
		public TVec3 TickPos(int i)
		{
			return new TVec3(this.ticks[i].Position);
		}

		// Token: 0x06000275 RID: 629 RVA: 0x0000A698 File Offset: 0x00009698
		public bool TickPassed(ref TAxisCalc.TTick Tick, double Val)
		{
			foreach (TAxisCalc.TTick ttick in this.ticks)
			{
				if (Val == ttick.Value || (Val - ttick.Value) * (this.lastVal - ttick.Value) < 0.0)
				{
					Tick = ttick;
					this.lastVal = Val;
					return true;
				}
			}
			this.lastVal = Val;
			return false;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0000A710 File Offset: 0x00009710
		public bool TickPassed(double Val)
		{
			foreach (TAxisCalc.TTick ttick in this.ticks)
			{
				if (Val == ttick.Value || (Val - ttick.Value) * (this.lastVal - ttick.Value) < 0.0)
				{
					this.lastVal = Val;
					return true;
				}
			}
			this.lastVal = Val;
			return false;
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0000A781 File Offset: 0x00009781
		public static double Round(double x)
		{
			return Math.Pow(10.0, Math.Round(Math.Log10(x)));
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0000A79C File Offset: 0x0000979C
		public static double Ceiling(double x, double d)
		{
			if (x < 0.0)
			{
				return d * Math.Floor(x / d);
			}
			return d * Math.Ceiling(x / d);
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0000A7C0 File Offset: 0x000097C0
		private void SetTicks()
		{
			double num = Math.Abs(this.ValEnd - this.ValO);
			double num2 = TAxisCalc.Round(num / (double)this.n);
			double num3 = TAxisCalc.Ceiling(this.ValO, num2);
			this.n = (int)(Math.Abs(this.ValEnd - num3) / num2) + 1;
			if (this.n < 3)
			{
				this.n = 3;
			}
			this.ticks = new TAxisCalc.TTick[this.n];
			if (this.n == 3)
			{
				this.ticks[0].Value = this.ValO;
				this.ticks[1].Value = 0.5 * (this.ValO + this.ValEnd);
				this.ticks[2].Value = this.ValEnd;
				return;
			}
			double num4 = num3;
			if (this.ValEnd < this.ValO)
			{
				num2 = -num2;
			}
			int i = 0;
			while (i < this.n)
			{
				this.ticks[i].Value = num4;
				i++;
				num4 += num2;
			}
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0000A8D4 File Offset: 0x000098D4
		private void SetTickPositions()
		{
			for (int i = 0; i < this.ticks.Length; i++)
			{
				this.ticks[i].Position = this.Origin + (this.End - this.Origin) * (this.ticks[i].Value - this.ValO) / (this.ValEnd - this.ValO);
			}
		}

		// Token: 0x04000109 RID: 265
		private TVec3 Origin;

		// Token: 0x0400010A RID: 266
		private TVec3 End;

		// Token: 0x0400010B RID: 267
		private double ValO;

		// Token: 0x0400010C RID: 268
		private double ValEnd;

		// Token: 0x0400010D RID: 269
		private int n;

		// Token: 0x0400010E RID: 270
		private TAxisCalc.TTick[] ticks = new TAxisCalc.TTick[0];

		// Token: 0x0400010F RID: 271
		private double lastVal;

		// Token: 0x02000032 RID: 50
		public struct TTick
		{
			// Token: 0x04000110 RID: 272
			public double Value;

			// Token: 0x04000111 RID: 273
			public TVec3 Position;
		}
	}
}
