using System;

namespace SmartQuant.Charting
{
	// Token: 0x02000037 RID: 55
	public interface IChartTransformation
	{
		// Token: 0x0600029C RID: 668
		double CalculateNotInSessionTicks(double X, double Y);

		// Token: 0x0600029D RID: 669
		double CalculateRealQuantityOfTicks_Right(double X, double Y);

		// Token: 0x0600029E RID: 670
		double CalculateRealQuantityOfTicks_Left(double X, double Y);

		// Token: 0x0600029F RID: 671
		void GetFirstGridDivision(ref EGridSize GridSize, ref double Min, ref double Max, ref DateTime FirstDateTime);

		// Token: 0x060002A0 RID: 672
		double GetNextGridDivision(double FirstTick, double PrevMajor, int MajorCount, EGridSize GridSize);
	}
}
