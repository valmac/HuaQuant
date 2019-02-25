using System;
using System.ComponentModel;
using System.Drawing;
using SmartQuant.Charting;
using SmartQuant.Series;

namespace SmartQuant.Indicators
{
	// Token: 0x02000002 RID: 2
	[Serializable]
	public class Indicator : DoubleSeries, IDisposable
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00001050
		protected int fRealCount
		{
			get
			{
				return this.fLastIndex - this.fFirstIndex + 1;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000002 RID: 2 RVA: 0x00002061 File Offset: 0x00001061
		[Browsable(false)]
		public override DateTime FirstDateTime
		{
			get
			{
				this.Calculate();
				if (this.fRealCount <= 0)
				{
					throw new ApplicationException("Array has no elements");
				}
				return this.GetDateTime(this.fFirstIndex);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002089 File Offset: 0x00001089
		[Browsable(false)]
		public override DateTime LastDateTime
		{
			get
			{
				this.Calculate();
				if (this.fRealCount <= 0)
				{
					throw new ApplicationException("Array has no elements");
				}
				return this.GetDateTime(this.fLastIndex);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000004 RID: 4 RVA: 0x000020B1 File Offset: 0x000010B1
		[Description("")]
		[Category("Description")]
		public EIndicatorType Type
		{
			get
			{
				return this.fType;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000005 RID: 5 RVA: 0x000020B9 File Offset: 0x000010B9
		[Browsable(false)]
		public override int Count
		{
			get
			{
				this.Calculate();
				return base.Count;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000006 RID: 6 RVA: 0x000020C7 File Offset: 0x000010C7
		// (set) Token: 0x06000007 RID: 7 RVA: 0x000020D0 File Offset: 0x000010D0
		[Browsable(false)]
		public TimeSeries Input
		{
			get
			{
				return this.fInput;
			}
			set
			{
				if (this.fInput != null)
				{
					this.fInput.Children.Remove(this);
				}
				this.fInput = value;
				this.fInput.Children.Add(this);
				this.fCalculate = true;
				this.Init();
				this.Connect();
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002122 File Offset: 0x00001122
		// (set) Token: 0x06000009 RID: 9 RVA: 0x0000212A File Offset: 0x0000112A
		[Browsable(false)]
		public bool Monitored
		{
			get
			{
				return this.fMonitored;
			}
			set
			{
				this.fMonitored = value;
				if (this.fMonitored)
				{
					this.fInput.ItemAdded += this.OnInputItemAdded2;
					return;
				}
				this.fInput.ItemAdded -= this.OnInputItemAdded2;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000A RID: 10 RVA: 0x0000216A File Offset: 0x0000116A
		[Browsable(false)]
		public override int FirstIndex
		{
			get
			{
				return this.fFirstIndex;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00002172 File Offset: 0x00001172
		[Browsable(false)]
		public override int LastIndex
		{
			get
			{
				return this.fLastIndex;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600000C RID: 12 RVA: 0x0000217A File Offset: 0x0000117A
		[Browsable(false)]
		public override int RealCount
		{
			get
			{
				return this.fRealCount;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002182 File Offset: 0x00001182
		// (set) Token: 0x0600000E RID: 14 RVA: 0x0000218A File Offset: 0x0000118A
		[Browsable(false)]
		public bool DrawEnabled
		{
			get
			{
				return this.fDrawEnabled;
			}
			set
			{
				this.fDrawEnabled = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00002193 File Offset: 0x00001193
		// (set) Token: 0x06000010 RID: 16 RVA: 0x0000219A File Offset: 0x0000119A
		public static bool SyncIndex
		{
			get
			{
				return Indicator.fSyncIndex;
			}
			set
			{
				Indicator.fSyncIndex = value;
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000021A2 File Offset: 0x000011A2
		protected virtual void Connect()
		{
			if (this.fInput != null)
			{
				this.fInput.ItemAdded += this.OnInputItemAdded2;
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000021C3 File Offset: 0x000011C3
		protected void Disconnect()
		{
			this.fInput.ItemAdded -= this.OnInputItemAdded2;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000021DC File Offset: 0x000011DC
		public virtual void Detach()
		{
			this.Disconnect();
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000021E4 File Offset: 0x000011E4
		protected virtual void Init()
		{
			this.fFirstIndex = 1073741823;
			this.fLastIndex = -1073741824;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000021FC File Offset: 0x000011FC
		public Indicator()
		{
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002212 File Offset: 0x00001212
		public Indicator(TimeSeries Input)
		{
			this.fInput = Input;
			this.fInput.Children.Add(this);
			this.Connect();
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002247 File Offset: 0x00001247
		protected void OnInputItemAdded2(object sender, DateTimeEventArgs EventArgs)
		{
			if (this.calculatingInput)
			{
				return;
			}
			if (this.fCalculate)
			{
				this.Calculate();
			}
			this.OnInputItemAdded(sender, EventArgs);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002268 File Offset: 0x00001268
		public virtual void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
		{
			if (this.fMonitored)
			{
				int index = this.fInput.GetIndex(EventArgs.DateTime);
				if (index != -1)
				{
					this.Calculate(index);
				}
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000229C File Offset: 0x0000129C
		public virtual void Calculate()
		{
			if (this.fCalculate)
			{
				this.fCalculate = false;
				this.calculatingInput = true;
				if (this.fInput is Indicator)
				{
					(this.fInput as Indicator).Calculate();
				}
				this.calculatingInput = false;
				for (int i = 0; i < this.fInput.Count; i++)
				{
					this.Calculate(i);
				}
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002300 File Offset: 0x00001300
		public virtual void Calculate(bool Force)
		{
			if (Force)
			{
				this.fCalculate = true;
			}
			this.Calculate();
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002312 File Offset: 0x00001312
		protected virtual void Calculate(int Index)
		{
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002314 File Offset: 0x00001314
		public override void Add(DateTime DateTime, double Data)
		{
			if (Indicator.fSyncIndex || !double.IsNaN(Data))
			{
				this.fArray.Remove(DateTime);
				this.fArray.Add(DateTime, Data);
				int num = this.fArray.IndexOf(DateTime);
				if (num < this.fFirstIndex)
				{
					if (!double.IsNaN(Data))
					{
						this.fFirstIndex = num;
					}
					else
					{
						this.fFirstIndex++;
					}
				}
				if (num > this.fLastIndex)
				{
					if (!double.IsNaN(Data))
					{
						this.fLastIndex = num;
					}
					else
					{
						this.fLastIndex--;
					}
				}
				this.fChanged = true;
				this.EmitItemAdded(DateTime);
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000023BC File Offset: 0x000013BC
		public override void Remove(int Index)
		{
			if (Index < this.fFirstIndex)
			{
				this.fFirstIndex--;
			}
			if (Index <= this.fLastIndex)
			{
				this.fLastIndex--;
			}
			this.fArray.RemoveAt(Index);
			this.fChanged = true;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000240A File Offset: 0x0000140A
		public override void Clear()
		{
			this.fArray.Clear();
			this.fFirstIndex = 1073741823;
			this.fLastIndex = -1073741824;
			this.fChanged = true;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002434 File Offset: 0x00001434
		public override DateTime GetDateTime(int Index)
		{
			this.Calculate();
			return base.GetDateTime(Index);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002443 File Offset: 0x00001443
		public override int GetIndex(DateTime DateTime)
		{
			this.Calculate();
			return base.GetIndex(DateTime);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002452 File Offset: 0x00001452
		public override int GetIndex(DateTime DateTime, EIndexOption Option)
		{
			this.Calculate();
			return base.GetIndex(DateTime, Option);
		}

		// Token: 0x1700000D RID: 13
		public new double this[int Index]
		{
			get
			{
				this.Calculate();
				return base[Index];
			}
		}

		// Token: 0x1700000E RID: 14
		public new double this[DateTime DateTime]
		{
			get
			{
				this.Calculate();
				return base[DateTime];
			}
		}

		// Token: 0x1700000F RID: 15
		public new double this[DateTime DateTime, EIndexOption Option]
		{
			get
			{
				this.Calculate();
				return base[DateTime, Option];
			}
		}

		// Token: 0x17000010 RID: 16
		public override double this[int Col, int Row]
		{
			get
			{
				this.Calculate();
				return base[Col, Row];
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000024A0 File Offset: 0x000014A0
		public override void Paint(Pad pad, double XMin, double XMax, double YMin, double YMax)
		{
			Pen pen = new Pen(this.fColor, (float)this.fDrawWidth);
			Brush brush = new SolidBrush(this.fColor);
			int num = 0;
			double num2 = 0.0;
			double num3 = 0.0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			int num7 = 0;
			int num8 = 0;
			int num9 = 0;
			int num10 = 0;
			int num11 = 0;
			DateTime dateTime = new DateTime((long)XMin);
			DateTime dateTime2 = new DateTime((long)XMax);
			int index;
			if (dateTime < this.FirstDateTime)
			{
				index = this.fFirstIndex;
			}
			else
			{
				index = this.GetIndex(dateTime, EIndexOption.Next);
			}
			int index2;
			if (dateTime2 > this.LastDateTime)
			{
				index2 = this.fLastIndex;
			}
			else
			{
				index2 = this.GetIndex(dateTime2, EIndexOption.Prev);
			}
			if (index == -1 || index2 == -1)
			{
				return;
			}
			switch (this.fDrawStyle)
			{
			case EDrawStyle.Line:
				for (int i = index; i <= index2; i++)
				{
					double num12 = (double)this.GetDateTime(i).Ticks;
					double num13 = this[i, 0];
					if (num != 0)
					{
						num4 = pad.ClientX(num2);
						num6 = pad.ClientY(num3);
						num5 = pad.ClientX(num12);
						num7 = pad.ClientY(num13);
						if ((pad.IsInRange(num12, num13) || pad.IsInRange(num2, num3)) && (num4 != num8 || num5 != num9 || num6 != num10 || num7 != num11))
						{
							pad.Graphics.DrawLine(pen, num4, num6, num5, num7);
						}
					}
					num8 = num4;
					num10 = num6;
					num9 = num5;
					num11 = num7;
					num2 = num12;
					num3 = num13;
					num++;
				}
				return;
			case EDrawStyle.Bar:
				for (int j = index; j <= index2; j++)
				{
					double num12 = (double)this.GetDateTime(j).Ticks;
					double num13 = this[j, 0];
					if (num13 > 0.0)
					{
						pad.Graphics.FillRectangle(new SolidBrush(this.fColor), pad.ClientX(num12) - this.fDrawWidth / 2, pad.ClientY(num13), this.fDrawWidth, pad.ClientY(0.0) - pad.ClientY(num13));
					}
					else
					{
						pad.Graphics.FillRectangle(new SolidBrush(this.fColor), pad.ClientX(num12) - this.fDrawWidth / 2, pad.ClientY(0.0), this.fDrawWidth, pad.ClientY(num13) - pad.ClientY(0.0));
					}
				}
				return;
			case EDrawStyle.Circle:
				for (int k = index; k <= index2; k++)
				{
					double num12 = (double)this.GetDateTime(k).Ticks;
					double num13 = this[k, 0];
					pad.Graphics.FillEllipse(brush, pad.ClientX(num12) - this.fDrawWidth / 2, pad.ClientY(num13) - this.fDrawWidth / 2, this.fDrawWidth, this.fDrawWidth);
				}
				return;
			default:
				return;
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002788 File Offset: 0x00001788
		public override double GetSum()
		{
			if (this.fChanged)
			{
				this.fSum = 0.0;
				for (int i = this.fFirstIndex; i < this.fLastIndex; i++)
				{
					this.fSum += this[i, 0];
				}
			}
			return this.fSum;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000027DD File Offset: 0x000017DD
		public override double GetSum(int Row)
		{
			return this.GetSum(this.fFirstIndex, this.fLastIndex, Row);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000027F2 File Offset: 0x000017F2
		public override double GetMean()
		{
			if (this.Count <= 0)
			{
				throw new ApplicationException("Can not calculate mean. Array is empty.");
			}
			if (this.fChanged)
			{
				this.fMean = this.GetMean(this.fFirstIndex, this.fLastIndex);
			}
			return this.fMean;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000282E File Offset: 0x0000182E
		public override double GetMean(int Row)
		{
			return this.GetMean(this.fFirstIndex, this.fLastIndex, Row);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002843 File Offset: 0x00001843
		public override double GetMedian()
		{
			if (this.Count <= 0)
			{
				throw new ApplicationException("Can not calculate median. Array is empty.");
			}
			if (this.fChanged)
			{
				this.fMedian = this.GetMedian(this.fFirstIndex, this.fLastIndex);
			}
			return this.fMedian;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000287F File Offset: 0x0000187F
		public override double GetMedian(int Row)
		{
			return this.GetMedian(this.fFirstIndex, this.fLastIndex, Row);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002894 File Offset: 0x00001894
		public override double GetVariance()
		{
			if (this.fRealCount <= 1)
			{
				throw new ApplicationException("Can not calculate variance. Insufficient number of elements in the array.");
			}
			if (this.fChanged)
			{
				double mean = this.GetMean();
				this.fVariance = 0.0;
				for (int i = this.fFirstIndex; i < this.fLastIndex; i++)
				{
					this.fVariance += (mean - this[i, 0]) * (mean - this[i, 0]);
				}
				this.fVariance /= (double)(this.fRealCount - 1);
			}
			return this.fVariance;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002927 File Offset: 0x00001927
		public override double GetVariance(int Row)
		{
			return this.GetVariance(this.fFirstIndex, this.fLastIndex, Row);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000293C File Offset: 0x0000193C
		public override double GetPositiveVariance(int Row)
		{
			return this.GetPositiveVariance(this.fFirstIndex, this.fLastIndex, Row);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002951 File Offset: 0x00001951
		public override double GetNegativeVariance(int Row)
		{
			return this.GetNegativeVariance(this.fFirstIndex, this.fLastIndex, Row);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002966 File Offset: 0x00001966
		public override double GetMoment(int k, int Row)
		{
			return this.GetMoment(k, this.fFirstIndex, this.fLastIndex, Row);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000297C File Offset: 0x0000197C
		public override double GetAsymmetry(int Row)
		{
			return this.GetAsymmetry(this.fFirstIndex, this.fLastIndex, Row);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002991 File Offset: 0x00001991
		public override double GetExcess(int Row)
		{
			return this.GetExcess(this.fFirstIndex, this.fLastIndex, Row);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000029A8 File Offset: 0x000019A8
		public override double GetAutoCovariance(int Lag)
		{
			if (Lag >= this.fRealCount)
			{
				throw new ApplicationException("Not enough data points in the array to calculate autocovariance");
			}
			double mean = this.GetMean();
			double num = 0.0;
			for (int i = Lag + this.fFirstIndex; i < this.fLastIndex; i++)
			{
				num += (this[i, 0] - mean) * (this[i - Lag, 0] - mean);
			}
			return num / (double)(this.fLastIndex - Lag);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002A1C File Offset: 0x00001A1C
		public override DoubleSeries GetReturnSeries()
		{
			DoubleSeries doubleSeries = new DoubleSeries(this.fName, this.fTitle + " (return)");
			if (this.Count > 1)
			{
				double num = this[0];
				for (int i = this.fFirstIndex; i < this.fLastIndex; i++)
				{
					DateTime dateTime = this.GetDateTime(i);
					double num2 = this[i];
					if (num != 0.0)
					{
						doubleSeries.Add(dateTime, num2 / num);
					}
					else
					{
						doubleSeries.Add(dateTime, 0.0);
					}
					num = num2;
				}
			}
			return doubleSeries;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002AB0 File Offset: 0x00001AB0
		public override DoubleSeries GetPercentReturnSeries()
		{
			DoubleSeries doubleSeries = new DoubleSeries(this.fName, this.fTitle + " (% return)");
			if (this.fRealCount > 1)
			{
				double num = this[0];
				for (int i = this.fFirstIndex; i < this.fLastIndex; i++)
				{
					DateTime dateTime = this.GetDateTime(i);
					double num2 = this[i];
					if (num != 0.0)
					{
						doubleSeries.Add(dateTime, (num2 / num - 1.0) * 100.0);
					}
					else
					{
						doubleSeries.Add(dateTime, 0.0);
					}
					num = num2;
				}
			}
			return doubleSeries;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002B58 File Offset: 0x00001B58
		public override DoubleSeries GetPositiveSeries()
		{
			DoubleSeries doubleSeries = new DoubleSeries();
			for (int i = this.fFirstIndex; i < this.fLastIndex; i++)
			{
				if (this[i] > 0.0)
				{
					doubleSeries.Add(this.GetDateTime(i), this[i]);
				}
			}
			return doubleSeries;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002BA8 File Offset: 0x00001BA8
		public override DoubleSeries GetNegativeSeries()
		{
			DoubleSeries doubleSeries = new DoubleSeries();
			for (int i = this.fFirstIndex; i < this.fLastIndex; i++)
			{
				if (this[i] < 0.0)
				{
					doubleSeries.Add(this.GetDateTime(i), this[i]);
				}
			}
			return doubleSeries;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002BF8 File Offset: 0x00001BF8
		public void Dispose()
		{
			this.Detach();
		}

		// Token: 0x04000001 RID: 1
		protected TimeSeries fInput;

		// Token: 0x04000002 RID: 2
		protected EIndicatorType fType;

		// Token: 0x04000003 RID: 3
		protected bool fCalculate = true;

		// Token: 0x04000004 RID: 4
		protected bool fDrawEnabled = true;

		// Token: 0x04000005 RID: 5
		protected int fFirstIndex;

		// Token: 0x04000006 RID: 6
		protected int fLastIndex;

		// Token: 0x04000007 RID: 7
		protected static bool fSyncIndex;

		// Token: 0x04000008 RID: 8
		private bool calculatingInput;
	}
}
