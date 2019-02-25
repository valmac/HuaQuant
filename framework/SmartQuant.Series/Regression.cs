using System;
using SmartQuant.Charting;

namespace SmartQuant.Series
{
	// Token: 0x02000013 RID: 19
	public class Regression
	{
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000284 RID: 644 RVA: 0x0000BAFC File Offset: 0x0000AAFC
		public Graph Graph
		{
			get
			{
				this.Calculate();
				return this.fGraph;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000285 RID: 645 RVA: 0x0000BB0A File Offset: 0x0000AB0A
		public double Alpha
		{
			get
			{
				this.Calculate();
				return this.fAlpha;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000286 RID: 646 RVA: 0x0000BB18 File Offset: 0x0000AB18
		public double Beta
		{
			get
			{
				this.Calculate();
				return this.fBeta;
			}
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0000BB26 File Offset: 0x0000AB26
		public Regression(DoubleSeries series1, DoubleSeries series2)
		{
			this.fSeries1 = series1;
			this.fSeries2 = series2;
			this.fGraph.LineEnabled = false;
			this.fGraph.MarkerSize = 1;
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0000BB5F File Offset: 0x0000AB5F
		public Regression(DoubleSeries series1, DoubleSeries series2, double alpha, double beta)
		{
			this.fSeries1 = series1;
			this.fSeries2 = series2;
			this.fGraph.LineEnabled = false;
			this.fGraph.MarkerSize = 1;
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0000BB98 File Offset: 0x0000AB98
		public void Calculate()
		{
			if (!this.fIsCalculated)
			{
				this.fBeta = this.fSeries1.GetCovariance(this.fSeries2) / this.fSeries1.GetVariance();
				this.fAlpha = this.fSeries2.GetMean() - this.fBeta * this.fSeries1.GetMean();
				this.fIsCalculated = true;
			}
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0000BBFB File Offset: 0x0000ABFB
		public void Calculate(bool force)
		{
			if (force)
			{
				this.fIsCalculated = false;
			}
			this.Calculate();
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0000BC0D File Offset: 0x0000AC0D
		public double GetRegression(double X)
		{
			this.Calculate();
			return this.fAlpha + this.fBeta * X;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0000BC24 File Offset: 0x0000AC24
		public DoubleSeries GetResidualSeries()
		{
			this.Calculate();
			this.fResidualSeries = new DoubleSeries();
			this.fResidualSeries.Title = this.fSeries1.Name + " - " + this.fSeries2.Name + " regression residuals";
			for (int i = 0; i < this.fSeries1.Count; i++)
			{
				DateTime dateTime = this.fSeries1.GetDateTime(i);
				if (this.fSeries2.Contains(dateTime))
				{
					double x = this.fSeries1[dateTime];
					double num = this.fSeries2[dateTime];
					double regression = this.GetRegression(x);
					this.fResidualSeries.Add(dateTime, num - regression);
				}
			}
			return this.fResidualSeries;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000BCDC File Offset: 0x0000ACDC
		public void Draw(string Option)
		{
			this.Calculate();
			if (Option.ToLower().IndexOf("r") != -1)
			{
				this.GetResidualSeries().Draw();
			}
			if (Option.ToLower().IndexOf("p") != -1)
			{
				for (int i = 0; i < this.fSeries1.Count; i++)
				{
					DateTime dateTime = this.fSeries1.GetDateTime(i);
					if (this.fSeries2.Contains(dateTime))
					{
						double x = this.fSeries1[dateTime];
						double y = this.fSeries2[dateTime];
						this.fGraph.Add(x, y);
					}
				}
				this.fGraph.Draw();
			}
			if (Option.ToLower().IndexOf("l") != -1)
			{
				double min = this.fSeries1.GetMin();
				double max = this.fSeries1.GetMax();
				double regression = this.GetRegression(min);
				double regression2 = this.GetRegression(max);
				TLine tline = new TLine(min, regression, max, regression2);
				tline.Draw();
			}
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0000BDDA File Offset: 0x0000ADDA
		public void Draw()
		{
			this.Draw("PL");
		}

		// Token: 0x04000041 RID: 65
		private DoubleSeries fSeries1;

		// Token: 0x04000042 RID: 66
		private DoubleSeries fSeries2;

		// Token: 0x04000043 RID: 67
		private DoubleSeries fResidualSeries;

		// Token: 0x04000044 RID: 68
		private double fAlpha;

		// Token: 0x04000045 RID: 69
		private double fBeta;

		// Token: 0x04000046 RID: 70
		private bool fIsCalculated;

		// Token: 0x04000047 RID: 71
		private Graph fGraph = new Graph();
	}
}
