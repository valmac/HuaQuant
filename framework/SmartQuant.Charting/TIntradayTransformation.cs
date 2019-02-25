using System;

namespace SmartQuant.Charting
{
	// Token: 0x02000038 RID: 56
	[Serializable]
	public class TIntradayTransformation : IChartTransformation
	{
		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x0000AFC9 File Offset: 0x00009FC9
		// (set) Token: 0x060002A2 RID: 674 RVA: 0x0000AFD1 File Offset: 0x00009FD1
		public long FirstSessionTick
		{
			get
			{
				return this.fFirstSessionTick;
			}
			set
			{
				this.fFirstSessionTick = value;
				this.fSession = this.fLastSessionTick - this.fFirstSessionTick;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x0000AFED File Offset: 0x00009FED
		// (set) Token: 0x060002A4 RID: 676 RVA: 0x0000AFF5 File Offset: 0x00009FF5
		public long LastSessionTick
		{
			get
			{
				return this.fLastSessionTick;
			}
			set
			{
				this.fLastSessionTick = value;
				this.fSession = this.fLastSessionTick - this.fFirstSessionTick;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x0000B011 File Offset: 0x0000A011
		public long Session
		{
			get
			{
				return this.fSession;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x0000B019 File Offset: 0x0000A019
		// (set) Token: 0x060002A7 RID: 679 RVA: 0x0000B021 File Offset: 0x0000A021
		public bool SessionGridEnabled
		{
			get
			{
				return this.fSessionGridEnabled;
			}
			set
			{
				this.fSessionGridEnabled = value;
			}
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x0000B02A File Offset: 0x0000A02A
		public TIntradayTransformation()
		{
			this.SetSessionBounds(0L, 864000000000L);
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0000B04A File Offset: 0x0000A04A
		public TIntradayTransformation(long FirstSessionTick, long LastSessionTick)
		{
			this.SetSessionBounds(FirstSessionTick, LastSessionTick);
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0000B061 File Offset: 0x0000A061
		public void SetSessionBounds(long FirstSessionTick, long LastSessionTick)
		{
			this.fFirstSessionTick = FirstSessionTick;
			this.fLastSessionTick = LastSessionTick;
			this.fSession = this.fLastSessionTick - this.fFirstSessionTick;
		}

		// Token: 0x060002AB RID: 683 RVA: 0x0000B084 File Offset: 0x0000A084
		public void GetFirstGridDivision(ref EGridSize GridSize, ref double Min, ref double Max, ref DateTime FirstDateTime)
		{
			if ((Max - Min) / (double)this.fSession <= 10.0)
			{
				GridSize = Axis.CalculateSize(Max - Min);
				Max = Min + this.CalculateRealQuantityOfTicks_Right(Min, Max);
			}
			else
			{
				Max = Min + this.CalculateRealQuantityOfTicks_Right(Min, Max);
				GridSize = Axis.CalculateSize(Max - Min);
			}
			this.fGap = this.CalculateGap((long)Min, (long)GridSize);
			if ((long)Min / (long)EGridSize.day1 - (long)(((long)Min + this.fGap + (long)GridSize) / (long)EGridSize.day1) < (long)0L && GridSize < (EGridSize)576000000000L)
			{
				Min += (double)this.CalculateJumpGap((long)Min, (long)GridSize);
				this.fGap = this.CalculateGap((long)Min, (long)GridSize);
			}
			if (GridSize < (EGridSize)576000000000L)
			{
				FirstDateTime = new DateTime((long)Min + this.fGap);
				return;
			}
			this.fGap = -this.fFirstSessionTick;
		}

		// Token: 0x060002AC RID: 684 RVA: 0x0000B17C File Offset: 0x0000A17C
		public double GetNextGridDivision(double FirstTick, double PrevMajor, int MajorCount, EGridSize GridSize)
		{
			double result;
			if (MajorCount == 0)
			{
				result = (double)this.GetFirstMajor((long)FirstTick - this.fGap);
			}
			else if (GridSize < (EGridSize)576000000000L)
			{
				result = this.GetNextMajor(PrevMajor, (long)GridSize);
			}
			else
			{
				result = (double)Axis.GetNextMajor((long)PrevMajor, GridSize);
			}
			return result;
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0000B1D0 File Offset: 0x0000A1D0
		private double GetNextMajor(double X, long gridSize)
		{
			double result = 0.0;
			if (X > 10000.0)
			{
				if (X % 864000000000.0 < (double)this.fFirstSessionTick)
				{
					X = (double)((long)X / 864000000000L * 864000000000L + this.fFirstSessionTick);
				}
				else if (X % 864000000000.0 > (double)this.fLastSessionTick)
				{
					X = (double)(((long)X / 864000000000L + 1L) * 864000000000L + this.fFirstSessionTick);
				}
				double num = (double)((long)X / 864000000000L * 864000000000L + this.fLastSessionTick);
				double num2 = num - X;
				if (num2 < (double)gridSize)
				{
					result = num + 864000000000.0 - (double)this.fSession - num2 + (double)gridSize;
				}
				else
				{
					result = X + (double)gridSize;
				}
			}
			return result;
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0000B2AC File Offset: 0x0000A2AC
		private long GetFirstMajor(long X)
		{
			long result = 0L;
			if (X > 10000L)
			{
				if (X % 864000000000L < this.fFirstSessionTick || X % 864000000000L > this.fLastSessionTick)
				{
					result = this.GetFirstMajor(X + 864000000000L - this.fSession);
				}
				else
				{
					result = X;
				}
			}
			return result;
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0000B30C File Offset: 0x0000A30C
		public double CalculateRealQuantityOfTicks_Right(double X, double Y)
		{
			long num = (long)(Y - X) / this.fSession * 864000000000L;
			long num2 = (long)(Y - X) % this.fSession;
			long num3 = (long)(X + (double)num) / 864000000000L * 864000000000L + this.fLastSessionTick;
			long num4;
			if ((double)num3 - (X + (double)num) >= (double)num2)
			{
				num4 = num + num2;
			}
			else
			{
				num4 = num + num2 + 864000000000L - this.fSession;
			}
			return (double)num4;
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0000B388 File Offset: 0x0000A388
		public double CalculateRealQuantityOfTicks_Left(double X, double Y)
		{
			long num = (long)(X - Y) / this.fSession * 864000000000L;
			long num2 = (long)(X - Y) % this.fSession;
			long num3 = (long)(X - (double)num) / 864000000000L * 864000000000L + this.fFirstSessionTick;
			long num4;
			if (X - (double)num - (double)num3 >= (double)num2)
			{
				num4 = num + num2;
			}
			else
			{
				num4 = num + num2 + 864000000000L - this.fSession;
			}
			return (double)(-(double)num4);
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x0000B404 File Offset: 0x0000A404
		private long CalculateGap(long X, long gridSize)
		{
			X = X / 864000000000L * 864000000000L + this.fFirstSessionTick;
			long num = -((X - this.fFirstSessionTick) / 864000000000L) * ((864000000000L - this.fSession) % gridSize);
			return num % gridSize;
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0000B45C File Offset: 0x0000A45C
		private long CalculateJumpGap(long X, long fGridSize)
		{
			if ((X + fGridSize) / 864000000000L - X / 864000000000L > 0L && (X + fGridSize) % 864000000000L > this.fFirstSessionTick && fGridSize < 576000000000L)
			{
				return (X / 864000000000L + 1L) * 864000000000L + this.fFirstSessionTick - X;
			}
			return 0L;
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0000B4CC File Offset: 0x0000A4CC
		public double CalculateNotInSessionTicks(double X, double Y)
		{
			if (Y > 10000.0)
			{
				long num = (long)X % 864000000000L;
				long num2 = (long)Y % 864000000000L;
				double num3 = (double)((long)X / 864000000000L * 864000000000L);
				double num4 = (double)((long)Y / 864000000000L * 864000000000L);
				double num5 = 0.0;
				double num6 = 0.0;
				double num7 = num3 + (double)this.fLastSessionTick;
				if (num < this.fFirstSessionTick)
				{
					num5 = (double)(this.fFirstSessionTick - num);
				}
				if (num > this.fLastSessionTick)
				{
					num5 = (double)(this.fFirstSessionTick + 864000000000L - num);
				}
				double num8 = num4 + (double)this.fLastSessionTick;
				if (num2 < this.fFirstSessionTick)
				{
					num6 = (double)(-(double)this.fFirstSessionTick + num2);
				}
				if (num2 > this.fLastSessionTick)
				{
					num6 = (double)(num2 - this.fLastSessionTick);
				}
				return num5 + num6 + (double)(864000000000L - this.fSession) * ((num8 - num7) / 864000000000.0);
			}
			return 0.0;
		}

		// Token: 0x04000127 RID: 295
		private long fFirstSessionTick;

		// Token: 0x04000128 RID: 296
		private long fLastSessionTick;

		// Token: 0x04000129 RID: 297
		private long fSession;

		// Token: 0x0400012A RID: 298
		private long fGap;

		// Token: 0x0400012B RID: 299
		private bool fSessionGridEnabled = true;
	}
}
