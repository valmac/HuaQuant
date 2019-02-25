using System;

namespace SmartQuant.Charting
{
	// Token: 0x02000039 RID: 57
	[Serializable]
	public class TEmptyTransformation : IChartTransformation
	{
		// Token: 0x060002B5 RID: 693 RVA: 0x0000B606 File Offset: 0x0000A606
		public double CalculateNotInSessionTicks(double X, double Y)
		{
			return 0.0;
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0000B611 File Offset: 0x0000A611
		public double CalculateRealQuantityOfTicks_Right(double X, double Y)
		{
			return Y - X;
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0000B616 File Offset: 0x0000A616
		public double CalculateRealQuantityOfTicks_Left(double X, double Y)
		{
			return Y - X;
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0000B61B File Offset: 0x0000A61B
		public void GetFirstGridDivision(ref EGridSize GridSize, ref double Min, ref double Max, ref DateTime FirstDateTime)
		{
			GridSize = Axis.CalculateSize(Max - Min);
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x0000B62C File Offset: 0x0000A62C
		public double GetNextGridDivision(double FirstTick, double PrevMajor, int MajorCount, EGridSize GridSize)
		{
			double result;
			if (MajorCount == 0)
			{
				result = FirstTick;
			}
			else
			{
				result = (double)Axis.GetNextMajor((long)PrevMajor, GridSize);
			}
			return result;
		}
	}
}
