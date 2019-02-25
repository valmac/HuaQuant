using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using SmartQuant.Charting;
using SmartQuant.Data;

namespace SmartQuant.Series
{
	// Token: 0x02000009 RID: 9
	[Serializable]
	public class DoubleSeries : TimeSeries, IDrawable, IZoomable
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000CA RID: 202 RVA: 0x0000330E File Offset: 0x0000230E
		// (set) Token: 0x060000CB RID: 203 RVA: 0x00003316 File Offset: 0x00002316
		[Description("")]
		[Category("Chart")]
		[IndicatorParameter(1000001)]
		public EDrawStyle DrawStyle
		{
			get
			{
				return this.fDrawStyle;
			}
			set
			{
				this.fDrawStyle = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000CC RID: 204 RVA: 0x0000331F File Offset: 0x0000231F
		// (set) Token: 0x060000CD RID: 205 RVA: 0x00003327 File Offset: 0x00002327
		[Description("")]
		[Category("Chart")]
		[IndicatorParameter(1000002)]
		public int DrawWidth
		{
			get
			{
				return this.fDrawWidth;
			}
			set
			{
				this.fDrawWidth = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00003330 File Offset: 0x00002330
		// (set) Token: 0x060000CF RID: 207 RVA: 0x00003338 File Offset: 0x00002338
		[Category("Zoom")]
		[Description("")]
		public virtual bool AutoZoom
		{
			get
			{
				return this.fAutoZoom;
			}
			set
			{
				this.fAutoZoom = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00003341 File Offset: 0x00002341
		public new double First
		{
			get
			{
				if (this.Count <= 0)
				{
					throw new ApplicationException("Array has no elements");
				}
				return this[0];
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x0000335E File Offset: 0x0000235E
		public new double Last
		{
			get
			{
				if (this.Count <= 0)
				{
					throw new ApplicationException("Array has no elements");
				}
				return this[this.Count - 1];
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00003382 File Offset: 0x00002382
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x0000338A File Offset: 0x0000238A
		public Color SecondColor
		{
			get
			{
				return this.secondColor;
			}
			set
			{
				this.secondColor = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x00003393 File Offset: 0x00002393
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x0000339B File Offset: 0x0000239B
		public DateTime SplitDate
		{
			get
			{
				return this.splitDate;
			}
			set
			{
				this.splitDate = value;
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000033A4 File Offset: 0x000023A4
		public DoubleSeries(string name, string title) : base(name, title)
		{
			this.fArray = new MemorySeries<double>();
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00003437 File Offset: 0x00002437
		public DoubleSeries(string name) : this(name, "")
		{
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00003445 File Offset: 0x00002445
		public DoubleSeries() : this("")
		{
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00003452 File Offset: 0x00002452
		public new DoubleSeries Clone()
		{
			return base.Clone() as DoubleSeries;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000345F File Offset: 0x0000245F
		public new DoubleSeries Clone(int index1, int index2)
		{
			return base.Clone(index1, index2) as DoubleSeries;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000346E File Offset: 0x0000246E
		public new DoubleSeries Clone(DateTime DateTime1, DateTime DateTime2)
		{
			return base.Clone(DateTime1, DateTime2) as DoubleSeries;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000347D File Offset: 0x0000247D
		public virtual void Add(DateTime DateTime, double Data)
		{
			this.fArray[DateTime] = Data;
			this.fChanged = true;
			this.EmitItemAdded(DateTime);
		}

		// Token: 0x1700001D RID: 29
		public new double this[int Index]
		{
			get
			{
				return (double)base[Index];
			}
		}

		// Token: 0x1700001E RID: 30
		public new double this[DateTime DateTime]
		{
			get
			{
				object obj = base[DateTime];
				if (obj == null)
				{
					throw new Exception("No data entry on " + DateTime);
				}
				return (double)obj;
			}
			set
			{
				this.Add(DateTime, value);
			}
		}

		// Token: 0x1700001F RID: 31
		public new double this[DateTime DateTime, EIndexOption Option]
		{
			get
			{
				object obj = base[DateTime, Option];
				if (obj == null)
				{
					throw new Exception(string.Concat(new object[]
					{
						"No data entry on ",
						DateTime,
						"( option = ",
						Option,
						")"
					}));
				}
				return (double)obj;
			}
		}

		// Token: 0x17000020 RID: 32
		public override double this[int Col, int row]
		{
			get
			{
				return this[Col];
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00003558 File Offset: 0x00002558
		public override double GetMin(int row)
		{
			if (this.Count <= 0)
			{
				throw new ApplicationException("Can not find max value. Array is empty.");
			}
			if (this.fChanged)
			{
				this.fMin = double.MaxValue;
				for (int i = 0; i < this.Count; i++)
				{
					if (this[i, row] < this.fMin)
					{
						this.fMin = this[i, row];
					}
				}
			}
			return this.fMin;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000035C8 File Offset: 0x000025C8
		public override double GetMax(int row)
		{
			if (this.Count <= 0)
			{
				throw new ApplicationException("Can not find max value. Array is empty.");
			}
			if (this.fChanged)
			{
				this.fMax = double.MinValue;
				for (int i = 0; i < this.Count; i++)
				{
					if (this[i, row] > this.fMax)
					{
						this.fMax = this[i, row];
					}
				}
			}
			return this.fMax;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00003638 File Offset: 0x00002638
		public override double GetMin(int index1, int index2, int row)
		{
			if (this.Count <= 0)
			{
				throw new ApplicationException("Can not find min value. Array is empty.");
			}
			if (index1 > index2)
			{
				throw new ApplicationException("index1 must be smaller than index2");
			}
			if (index1 < 0 || index1 > this.Count - 1)
			{
				throw new ApplicationException("index1 is out of range");
			}
			if (index2 < 0 || index2 > this.Count - 1)
			{
				throw new ApplicationException("index2 is out of range");
			}
			double num = double.MaxValue;
			for (int i = index1; i <= index2; i++)
			{
				if (this[i, row] < num)
				{
					num = this[i, row];
				}
			}
			return num;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x000036C8 File Offset: 0x000026C8
		public override double GetMax(int index1, int index2, int row)
		{
			if (this.Count <= 0)
			{
				throw new ApplicationException("Can not find max value. Array is empty.");
			}
			if (index1 > index2)
			{
				throw new ApplicationException("index1 must be smaller than index2");
			}
			if (index1 < 0 || index1 > this.Count - 1)
			{
				throw new ApplicationException("index1 is out of range");
			}
			if (index2 < 0 || index2 > this.Count - 1)
			{
				throw new ApplicationException("index2 is out of range");
			}
			double num = double.MinValue;
			for (int i = index1; i <= index2; i++)
			{
				if (this[i, row] > num)
				{
					num = this[i, row];
				}
			}
			return num;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00003758 File Offset: 0x00002758
		public override int GetMinIndex(int index1, int index2, int row)
		{
			if (this.Count <= 0)
			{
				throw new ApplicationException("Can not find index of min value. Array is empty.");
			}
			if (index1 > index2)
			{
				throw new ApplicationException("index1 must be smaller than index2");
			}
			if (index1 < 0 || index1 > this.Count - 1)
			{
				throw new ApplicationException("index1 is out of range");
			}
			if (index2 < 0 || index2 > this.Count - 1)
			{
				throw new ApplicationException("index2 is out of range");
			}
			int result = -1;
			double num = double.MaxValue;
			for (int i = index1; i <= index2; i++)
			{
				if (this[i, row] < num)
				{
					num = this[i, row];
					result = i;
				}
			}
			return result;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x000037EC File Offset: 0x000027EC
		public override int GetMaxIndex(int index1, int index2, int row)
		{
			if (this.Count <= 0)
			{
				throw new ApplicationException("Can not find index of max value. Array is empty.");
			}
			if (index1 > index2)
			{
				throw new ApplicationException("index1 must be smaller than index2");
			}
			if (index1 < 0 || index1 > this.Count - 1)
			{
				throw new ApplicationException("index1 is out of range");
			}
			if (index2 < 0 || index2 > this.Count - 1)
			{
				throw new ApplicationException("index2 is out of range");
			}
			int result = -1;
			double num = double.MinValue;
			for (int i = index1; i <= index2; i++)
			{
				if (this[i, row] > num)
				{
					num = this[i, row];
					result = i;
				}
			}
			return result;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00003880 File Offset: 0x00002880
		public override double GetSum()
		{
			if (this.fChanged)
			{
				this.fSum = 0.0;
				for (int i = 0; i < this.Count; i++)
				{
					this.fSum += this[i, 0];
				}
			}
			return this.fSum;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x000038D0 File Offset: 0x000028D0
		public override double GetSum(int index1, int index2, int row)
		{
			if (index1 >= index2)
			{
				throw new ApplicationException("index1 must be smaller than index2");
			}
			if (index1 < 0 || index1 > this.Count - 1)
			{
				throw new ApplicationException("index1 is out of range");
			}
			if (index2 < 0 || index2 > this.Count - 1)
			{
				throw new ApplicationException("index2 is out of range");
			}
			double num = 0.0;
			for (int i = index1; i <= index2; i++)
			{
				num += this[i, row];
			}
			return num;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00003942 File Offset: 0x00002942
		public override double GetMean()
		{
			if (this.Count <= 0)
			{
				throw new ApplicationException("Can not calculate mean. Array is empty.");
			}
			if (this.fChanged)
			{
				this.fMean = this.GetMean(0, this.Count - 1);
			}
			return this.fMean;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000397C File Offset: 0x0000297C
		public override double GetMean(int index1, int index2, int row)
		{
			if (this.Count <= 0)
			{
				throw new ApplicationException("Can not calculate mean. Array is empty.");
			}
			if (index1 > index2)
			{
				throw new ApplicationException("index1 must be smaller than index2");
			}
			if (index1 < 0 || index1 > this.Count - 1)
			{
				throw new ApplicationException("index1 is out of range");
			}
			if (index2 < 0 || index2 > this.Count - 1)
			{
				throw new ApplicationException("index2 is out of range");
			}
			double num = 0.0;
			for (int i = index1; i <= index2; i++)
			{
				num += this[i, row];
			}
			return num / (double)(index2 - index1 + 1);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00003A0B File Offset: 0x00002A0B
		public override double GetMedian()
		{
			if (this.Count <= 0)
			{
				throw new ApplicationException("Can not calculate median. Array is empty.");
			}
			if (this.fChanged)
			{
				this.fMedian = this.GetMedian(0, this.Count - 1);
			}
			return this.fMedian;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00003A44 File Offset: 0x00002A44
		public override double GetMedian(int index1, int index2, int row)
		{
			if (this.Count <= 0)
			{
				throw new ApplicationException("Can not calculate mean. Array is empty.");
			}
			if (index1 > index2)
			{
				throw new ApplicationException("index1 must be smaller than index2");
			}
			if (index1 < 0 || index1 > this.Count - 1)
			{
				throw new ApplicationException("index1 is out of range");
			}
			if (index2 < 0 || index2 > this.Count - 1)
			{
				throw new ApplicationException("index2 is out of range");
			}
			ArrayList arrayList = new ArrayList();
			for (int i = index1; i <= index2; i++)
			{
				arrayList.Add(this[i, row]);
			}
			arrayList.Sort();
			return (double)arrayList[arrayList.Count / 2];
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00003AE8 File Offset: 0x00002AE8
		public override double GetVariance()
		{
			if (this.Count <= 1)
			{
				throw new ApplicationException("Can not calculate variance. Insufficient number of elements in the array.");
			}
			if (this.fChanged)
			{
				double mean = this.GetMean();
				this.fVariance = 0.0;
				for (int i = 0; i < this.Count; i++)
				{
					this.fVariance += (mean - this[i, 0]) * (mean - this[i, 0]);
				}
				this.fVariance /= (double)(this.Count - 1);
			}
			return this.fVariance;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00003B78 File Offset: 0x00002B78
		public override double GetVariance(int index1, int index2, int row)
		{
			if (this.Count <= 1)
			{
				throw new ApplicationException("Can not calculate variance. Insufficient number of elements in the array.");
			}
			if (index1 > index2)
			{
				throw new ApplicationException("index1 must be smaller than index2");
			}
			if (index1 < 0 || index1 > this.Count - 1)
			{
				throw new ApplicationException("index1 is out of range");
			}
			if (index2 < 0 || index2 > this.Count - 1)
			{
				throw new ApplicationException("index2 is out of range");
			}
			double mean = this.GetMean(index1, index2, row);
			double num = 0.0;
			for (int i = index1; i <= index2; i++)
			{
				num += (mean - this[i, row]) * (mean - this[i, row]);
			}
			return num / (double)(index2 - index1);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00003C1C File Offset: 0x00002C1C
		public override double GetPositiveVariance(int index1, int index2, int row)
		{
			if (this.Count <= 1)
			{
				throw new ApplicationException("Can not calculate variance. Insufficient number of elements in the array.");
			}
			if (index1 > index2)
			{
				throw new ApplicationException("index1 must be smaller than index2");
			}
			if (index1 < 0 || index1 > this.Count - 1)
			{
				throw new ApplicationException("index1 is out of range");
			}
			if (index2 < 0 || index2 > this.Count - 1)
			{
				throw new ApplicationException("index2 is out of range");
			}
			int num = 0;
			double num2 = 0.0;
			for (int i = index1; i <= index2; i++)
			{
				if (this[i, row] > 0.0)
				{
					num2 += this[i, row];
					num++;
				}
			}
			num2 /= (double)num;
			double num3 = 0.0;
			for (int j = index1; j <= index2; j++)
			{
				if (this[j, row] > 0.0)
				{
					num3 += (num2 - this[j, row]) * (num2 - this[j, row]);
				}
			}
			return num3 / (double)num;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00003D10 File Offset: 0x00002D10
		public override double GetNegativeVariance(int index1, int index2, int row)
		{
			if (this.Count <= 1)
			{
				throw new ApplicationException("Can not calculate variance. Insufficient number of elements in the array.");
			}
			if (index1 > index2)
			{
				throw new ApplicationException("index1 must be smaller than index2");
			}
			if (index1 < 0 || index1 > this.Count - 1)
			{
				throw new ApplicationException("index1 is out of range");
			}
			if (index2 < 0 || index2 > this.Count - 1)
			{
				throw new ApplicationException("index2 is out of range");
			}
			int num = 0;
			double num2 = 0.0;
			for (int i = index1; i <= index2; i++)
			{
				if (this[i, row] < 0.0)
				{
					num2 += this[i, row];
					num++;
				}
			}
			num2 /= (double)num;
			double num3 = 0.0;
			for (int j = index1; j <= index2; j++)
			{
				if (this[j, row] < 0.0)
				{
					num3 += (num2 - this[j, row]) * (num2 - this[j, row]);
				}
			}
			return num3 / (double)num;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00003E04 File Offset: 0x00002E04
		public override double GetMoment(int k, int index1, int index2, int row)
		{
			if (this.Count <= 0)
			{
				throw new ApplicationException("Can not calculate momentum. Series " + this.fName + " is empty.");
			}
			if (index1 > index2)
			{
				throw new ApplicationException("index1 must be smaller than index2");
			}
			if (index1 < 0 || index1 > this.Count - 1)
			{
				throw new ApplicationException("index1 is out of range");
			}
			if (index2 < 0 || index2 > this.Count - 1)
			{
				throw new ApplicationException("index2 is out of range");
			}
			double num;
			if (k == 1)
			{
				num = 0.0;
			}
			else
			{
				num = this.GetMean(index1, index2, row);
			}
			int num2 = 0;
			double num3 = 0.0;
			for (int i = index1; i <= index2; i++)
			{
				num3 += Math.Pow(this[i, row] - num, (double)k);
				num2++;
			}
			if (num2 == 0)
			{
				return 0.0;
			}
			return num3 / (double)num2;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00003ED8 File Offset: 0x00002ED8
		public override double GetAsymmetry(int index1, int index2, int row)
		{
			if (this.Count <= 0)
			{
				throw new ApplicationException("Can not calculate asymmetry. Series " + this.fName + " is empty.");
			}
			if (index1 > index2)
			{
				throw new ApplicationException("index1 must be smaller than index2");
			}
			if (index1 < 0 || index1 > this.Count - 1)
			{
				throw new ApplicationException("index1 is out of range");
			}
			if (index2 < 0 || index2 > this.Count - 1)
			{
				throw new ApplicationException("index2 is out of range");
			}
			double stdDev = this.GetStdDev(index1, index2, row);
			if (stdDev == 0.0)
			{
				return 0.0;
			}
			return this.GetMoment(3, index1, index2, row) / Math.Pow(stdDev, 3.0);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00003F88 File Offset: 0x00002F88
		public override double GetExcess(int index1, int index2, int row)
		{
			if (this.Count <= 0)
			{
				throw new ApplicationException("Can not calculate excess. Series " + this.fName + " is empty.");
			}
			if (index1 > index2)
			{
				throw new ApplicationException("index1 must be smaller than index2");
			}
			if (index1 < 0 || index1 > this.Count - 1)
			{
				throw new ApplicationException("index1 is out of range");
			}
			if (index2 < 0 || index2 > this.Count - 1)
			{
				throw new ApplicationException("index2 is out of range");
			}
			double stdDev = this.GetStdDev(index1, index2, row);
			if (stdDev == 0.0)
			{
				return 0.0;
			}
			return this.GetMoment(4, index1, index2, row) / Math.Pow(stdDev, 4.0);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00004038 File Offset: 0x00003038
		public override double GetCovariance(int row1, int row2, int index1, int index2)
		{
			if (this.Count <= 0)
			{
				throw new ApplicationException("Can not calculate covariance. Array is empty.");
			}
			if (index1 > index2)
			{
				throw new ApplicationException("index1 must be smaller than index2");
			}
			if (index1 < 0 || index1 > this.Count - 1)
			{
				throw new ApplicationException("index1 is out of range");
			}
			if (index2 < 0 || index2 > this.Count - 1)
			{
				throw new ApplicationException("index2 is out of range");
			}
			double mean = this.GetMean(index1, index2, row1);
			double mean2 = this.GetMean(index1, index2, row2);
			double num = 0.0;
			double num2 = 0.0;
			for (int i = index1; i <= index2; i++)
			{
				num2 += (this[i, row1] - mean) * (this[i, row2] - mean2);
				num += 1.0;
			}
			if (num <= 1.0)
			{
				return 0.0;
			}
			return num2 / (num - 1.0);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00004123 File Offset: 0x00003123
		public override double GetCorrelation(int row1, int row2, int index1, int index2)
		{
			return this.GetCovariance(row1, row2, index1, index2) / (this.GetStdDev(index1, index2, row1) * this.GetStdDev(index1, index2, row2));
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00004148 File Offset: 0x00003148
		public override double GetCovariance(TimeSeries series)
		{
			if (!(series is DoubleSeries))
			{
				throw new ArgumentException("Argument series should be of DoubleSeries type");
			}
			double mean = this.GetMean();
			double mean2 = series.GetMean();
			double num = 0.0;
			double num2 = 0.0;
			for (int i = 0; i < this.Count; i++)
			{
				DateTime dateTime = this.GetDateTime(i);
				if (series.Contains(dateTime))
				{
					num2 += (this[i] - mean) * ((double)series[dateTime] - mean2);
					num += 1.0;
				}
			}
			if (num <= 1.0)
			{
				return 0.0;
			}
			return num2 / (num - 1.0);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x000041FF File Offset: 0x000031FF
		public override double GetCorrelation(TimeSeries series)
		{
			return this.GetCovariance(series) / (this.GetStdDev() * series.GetStdDev());
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00004218 File Offset: 0x00003218
		public virtual DoubleSeries Log()
		{
			DoubleSeries doubleSeries = base.GetType().GetConstructor(new Type[0]).Invoke(new object[0]) as DoubleSeries;
			doubleSeries.fName = "Log(" + this.fName + ")";
			doubleSeries.fTitle = this.fTitle;
			for (int i = 0; i < this.Count; i++)
			{
				doubleSeries.Add(this.GetDateTime(i), Math.Log(this[i, 0]));
			}
			return doubleSeries;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000429C File Offset: 0x0000329C
		public DoubleSeries Log10()
		{
			DoubleSeries doubleSeries = base.GetType().GetConstructor(new Type[0]).Invoke(new object[0]) as DoubleSeries;
			doubleSeries.fName = "Log10(" + this.fName + ")";
			doubleSeries.fTitle = this.fTitle;
			for (int i = 0; i < this.Count; i++)
			{
				doubleSeries.Add(this.GetDateTime(i), Math.Log10(this[i, 0]));
			}
			return doubleSeries;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00004320 File Offset: 0x00003320
		public DoubleSeries Sqrt()
		{
			DoubleSeries doubleSeries = base.GetType().GetConstructor(new Type[0]).Invoke(new object[0]) as DoubleSeries;
			doubleSeries.fName = "Sqrt(" + this.fName + ")";
			doubleSeries.fTitle = this.fTitle;
			for (int i = 0; i < this.Count; i++)
			{
				doubleSeries.Add(this.GetDateTime(i), Math.Sqrt(this[i, 0]));
			}
			return doubleSeries;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x000043A4 File Offset: 0x000033A4
		public DoubleSeries Exp()
		{
			DoubleSeries doubleSeries = base.GetType().GetConstructor(new Type[0]).Invoke(new object[0]) as DoubleSeries;
			doubleSeries.fName = "Exp(" + this.fName + ")";
			doubleSeries.fTitle = this.fTitle;
			for (int i = 0; i < this.Count; i++)
			{
				doubleSeries.Add(this.GetDateTime(i), Math.Exp(this[i, 0]));
			}
			return doubleSeries;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00004428 File Offset: 0x00003428
		public DoubleSeries Pow(double Pow)
		{
			DoubleSeries doubleSeries = base.GetType().GetConstructor(new Type[0]).Invoke(new object[0]) as DoubleSeries;
			doubleSeries.Name = "Pow(" + this.fName + ")";
			doubleSeries.Title = this.fTitle;
			for (int i = 0; i < this.Count; i++)
			{
				doubleSeries.Add(this.GetDateTime(i), Math.Pow(this[i, 0], Pow));
			}
			return doubleSeries;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x000044AC File Offset: 0x000034AC
		public virtual double GetAutoCovariance(int Lag)
		{
			if (Lag >= this.Count)
			{
				throw new ApplicationException("Not enough data points in the series to calculate autocovariance");
			}
			double mean = this.GetMean();
			double num = 0.0;
			for (int i = Lag; i < this.Count; i++)
			{
				num += (this[i, 0] - mean) * (this[i - Lag, 0] - mean);
			}
			return num / (double)(this.Count - Lag);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00004516 File Offset: 0x00003516
		public double GetAutoCorrelation(int Lag)
		{
			return this.GetAutoCovariance(Lag) / this.GetVariance();
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00004528 File Offset: 0x00003528
		public Graph GetCorrelogram(int Lag1, int Lag2)
		{
			Graph graph = new Graph();
			for (int i = Lag1; i <= Lag2; i++)
			{
				graph.Add((double)i, this.GetAutoCorrelation(i));
			}
			return graph;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00004557 File Offset: 0x00003557
		public Graph GetCorrelogram(int Lag)
		{
			return this.GetCorrelogram(Lag, this.Count / 4);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00004568 File Offset: 0x00003568
		public virtual DoubleSeries GetReturnSeries()
		{
			DoubleSeries doubleSeries = new DoubleSeries(this.fName, this.fTitle + " (return)");
			if (this.Count > 1)
			{
				double num = this[0];
				for (int i = 0; i < this.Count; i++)
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

		// Token: 0x06000103 RID: 259 RVA: 0x000045F4 File Offset: 0x000035F4
		public virtual DoubleSeries GetPercentReturnSeries()
		{
			DoubleSeries doubleSeries = new DoubleSeries(this.fName, this.fTitle + " (% return)");
			if (this.Count > 1)
			{
				double num = this[0];
				for (int i = 0; i < this.Count; i++)
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

		// Token: 0x06000104 RID: 260 RVA: 0x00004694 File Offset: 0x00003694
		public virtual DoubleSeries GetPositiveSeries()
		{
			DoubleSeries doubleSeries = new DoubleSeries();
			for (int i = 0; i < this.Count; i++)
			{
				if (this[i] > 0.0)
				{
					doubleSeries.Add(this.GetDateTime(i), this[i]);
				}
			}
			return doubleSeries;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000046E0 File Offset: 0x000036E0
		public virtual DoubleSeries GetNegativeSeries()
		{
			DoubleSeries doubleSeries = new DoubleSeries();
			for (int i = 0; i < this.Count; i++)
			{
				if (this[i] < 0.0)
				{
					doubleSeries.Add(this.GetDateTime(i), this[i]);
				}
			}
			return doubleSeries;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0000472C File Offset: 0x0000372C
		public new DoubleSeries Shift(int offset)
		{
			DoubleSeries doubleSeries = new DoubleSeries(base.Name, base.Title);
			int num = 0;
			if (offset < 0)
			{
				num += Math.Abs(offset);
			}
			for (int i = num; i < this.Count; i++)
			{
				int num2 = i + offset;
				if (num2 >= this.Count)
				{
					break;
				}
				DateTime dateTime = this.GetDateTime(num2);
				double value = this[i];
				doubleSeries[dateTime] = value;
			}
			return doubleSeries;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00004798 File Offset: 0x00003798
		public double Ago(int n)
		{
			int num = this.Count - 1 - n;
			if (num < 0)
			{
				throw new ArgumentException("Can not return an entry " + n + " entries ago: time series is too short.");
			}
			return this[num];
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000047D8 File Offset: 0x000037D8
		public static DoubleSeries operator +(DoubleSeries series1, DoubleSeries series2)
		{
			if (series1 == null || series2 == null)
			{
				throw new ArgumentException("Operator argument can not be null");
			}
			DoubleSeries doubleSeries = new DoubleSeries(string.Concat(new string[]
			{
				"(",
				series1.Name,
				"+",
				series2.Name,
				")"
			}));
			for (int i = 0; i < series1.Count; i++)
			{
				DateTime dateTime = series1.GetDateTime(i);
				if (series2.Contains(dateTime))
				{
					doubleSeries.Add(dateTime, series1[dateTime, EIndexOption.Null] + series2[dateTime, EIndexOption.Null]);
				}
			}
			return doubleSeries;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00004870 File Offset: 0x00003870
		public static DoubleSeries operator -(DoubleSeries series1, DoubleSeries series2)
		{
			if (series1 == null || series2 == null)
			{
				throw new ArgumentException("Operator argument can not be null");
			}
			DoubleSeries doubleSeries = new DoubleSeries(string.Concat(new string[]
			{
				"(",
				series1.Name,
				"-",
				series2.Name,
				")"
			}));
			for (int i = 0; i < series1.Count; i++)
			{
				DateTime dateTime = series1.GetDateTime(i);
				if (series2.Contains(dateTime))
				{
					doubleSeries.Add(dateTime, series1[dateTime, EIndexOption.Null] - series2[dateTime, EIndexOption.Null]);
				}
			}
			return doubleSeries;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00004908 File Offset: 0x00003908
		public static DoubleSeries operator *(DoubleSeries series1, DoubleSeries series2)
		{
			if (series1 == null || series2 == null)
			{
				throw new ArgumentException("Operator argument can not be null");
			}
			DoubleSeries doubleSeries = new DoubleSeries(string.Concat(new string[]
			{
				"(",
				series1.Name,
				"*",
				series2.Name,
				")"
			}));
			for (int i = 0; i < series1.Count; i++)
			{
				DateTime dateTime = series1.GetDateTime(i);
				if (series2.Contains(dateTime))
				{
					doubleSeries.Add(dateTime, series1[dateTime, EIndexOption.Null] * series2[dateTime, EIndexOption.Null]);
				}
			}
			return doubleSeries;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000049A0 File Offset: 0x000039A0
		public static DoubleSeries operator /(DoubleSeries series1, DoubleSeries series2)
		{
			if (series1 == null || series2 == null)
			{
				throw new ArgumentException("Operator argument can not be null");
			}
			DoubleSeries doubleSeries = new DoubleSeries(string.Concat(new string[]
			{
				"(",
				series1.Name,
				"/",
				series2.Name,
				")"
			}));
			for (int i = 0; i < series1.Count; i++)
			{
				DateTime dateTime = series1.GetDateTime(i);
				if (series2.Contains(dateTime) && series2[dateTime] != 0.0)
				{
					doubleSeries.Add(dateTime, series1[dateTime, EIndexOption.Null] / series2[dateTime, EIndexOption.Null]);
				}
			}
			return doubleSeries;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00004A48 File Offset: 0x00003A48
		public static DoubleSeries operator +(DoubleSeries series, double Value)
		{
			if (series == null)
			{
				throw new ArgumentException("Operator argument can not be null");
			}
			DoubleSeries doubleSeries = new DoubleSeries(string.Concat(new string[]
			{
				"(",
				series.Name,
				"+",
				Value.ToString("F2"),
				")"
			}));
			for (int i = 0; i < series.Count; i++)
			{
				doubleSeries.Add(series.GetDateTime(i), series[i, 0] + Value);
			}
			return doubleSeries;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00004AD0 File Offset: 0x00003AD0
		public static DoubleSeries operator -(DoubleSeries series, double Value)
		{
			if (series == null)
			{
				throw new ArgumentException("Operator argument can not be null");
			}
			DoubleSeries doubleSeries = new DoubleSeries(string.Concat(new string[]
			{
				"(",
				series.Name,
				"-",
				Value.ToString("F2"),
				")"
			}));
			for (int i = 0; i < series.Count; i++)
			{
				doubleSeries.Add(series.GetDateTime(i), series[i, 0] - Value);
			}
			return doubleSeries;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00004B58 File Offset: 0x00003B58
		public static DoubleSeries operator *(DoubleSeries series, double Value)
		{
			if (series == null)
			{
				throw new ArgumentException("Operator argument can not be null");
			}
			DoubleSeries doubleSeries = new DoubleSeries(string.Concat(new string[]
			{
				"(",
				series.Name,
				"*",
				Value.ToString("F2"),
				")"
			}));
			for (int i = 0; i < series.Count; i++)
			{
				doubleSeries.Add(series.GetDateTime(i), series[i, 0] * Value);
			}
			return doubleSeries;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00004BE0 File Offset: 0x00003BE0
		public static DoubleSeries operator /(DoubleSeries series, double Value)
		{
			if (series == null)
			{
				throw new ArgumentException("Operator argument can not be null");
			}
			DoubleSeries doubleSeries = new DoubleSeries(string.Concat(new string[]
			{
				"(",
				series.Name,
				"/",
				Value.ToString("F2"),
				")"
			}));
			for (int i = 0; i < series.Count; i++)
			{
				doubleSeries.Add(series.GetDateTime(i), series[i, 0] / Value);
			}
			return doubleSeries;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00004C68 File Offset: 0x00003C68
		public static DoubleSeries operator +(double Value, DoubleSeries series)
		{
			if (series == null)
			{
				throw new ArgumentException("Operator argument can not be null");
			}
			DoubleSeries doubleSeries = new DoubleSeries(string.Concat(new string[]
			{
				"(",
				Value.ToString("F2"),
				"+",
				series.Name,
				")"
			}));
			for (int i = 0; i < series.Count; i++)
			{
				doubleSeries.Add(series.GetDateTime(i), Value + series[i, 0]);
			}
			return doubleSeries;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00004CF0 File Offset: 0x00003CF0
		public static DoubleSeries operator -(double Value, DoubleSeries series)
		{
			if (series == null)
			{
				throw new ArgumentException("Operator argument can not be null");
			}
			DoubleSeries doubleSeries = new DoubleSeries(string.Concat(new string[]
			{
				"(",
				Value.ToString("F2"),
				"-",
				series.Name,
				")"
			}));
			for (int i = 0; i < series.Count; i++)
			{
				doubleSeries.Add(series.GetDateTime(i), Value - series[i, 0]);
			}
			return doubleSeries;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00004D78 File Offset: 0x00003D78
		public static DoubleSeries operator *(double Value, DoubleSeries series)
		{
			if (series == null)
			{
				throw new ArgumentException("Operator argument can not be null");
			}
			DoubleSeries doubleSeries = new DoubleSeries(string.Concat(new string[]
			{
				"(",
				Value.ToString("F2"),
				"*",
				series.Name,
				")"
			}));
			for (int i = 0; i < series.Count; i++)
			{
				doubleSeries.Add(series.GetDateTime(i), Value * series[i, 0]);
			}
			return doubleSeries;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00004E00 File Offset: 0x00003E00
		public static DoubleSeries operator /(double Value, DoubleSeries series)
		{
			if (series == null)
			{
				throw new ArgumentException("Operator argument can not be null");
			}
			DoubleSeries doubleSeries = new DoubleSeries(string.Concat(new string[]
			{
				"(",
				Value.ToString("F2"),
				"/",
				series.Name,
				")"
			}));
			for (int i = 0; i < series.Count; i++)
			{
				if (series[i, 0] != 0.0)
				{
					doubleSeries.Add(series.GetDateTime(i), Value / series[i, 0]);
				}
			}
			return doubleSeries;
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000114 RID: 276 RVA: 0x00004E9A File Offset: 0x00003E9A
		// (set) Token: 0x06000115 RID: 277 RVA: 0x00004EA2 File Offset: 0x00003EA2
		[Description("")]
		[Category("ToolTip")]
		public bool ToolTipEnabled
		{
			get
			{
				return this.fToolTipEnabled;
			}
			set
			{
				this.fToolTipEnabled = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000116 RID: 278 RVA: 0x00004EAB File Offset: 0x00003EAB
		// (set) Token: 0x06000117 RID: 279 RVA: 0x00004EB3 File Offset: 0x00003EB3
		[Category("ToolTip")]
		[Description("")]
		public string ToolTipFormat
		{
			get
			{
				return this.fToolTipFormat;
			}
			set
			{
				this.fToolTipFormat = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000118 RID: 280 RVA: 0x00004EBC File Offset: 0x00003EBC
		// (set) Token: 0x06000119 RID: 281 RVA: 0x00004EC4 File Offset: 0x00003EC4
		[Description("")]
		[Category("ToolTip")]
		public string ToolTipDateTimeFormat
		{
			get
			{
				return this.fToolTipDateTimeFormat;
			}
			set
			{
				this.fToolTipDateTimeFormat = value;
			}
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00004ECD File Offset: 0x00003ECD
		public bool IsPadRangeX()
		{
			return false;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00004ED0 File Offset: 0x00003ED0
		public bool IsPadRangeY()
		{
			return this.fMonitored || this.fAutoZoom;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00004EE5 File Offset: 0x00003EE5
		public virtual PadRange GetPadRangeX(Pad pad)
		{
			return null;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00004EE8 File Offset: 0x00003EE8
		public virtual PadRange GetPadRangeY(Pad pad)
		{
			if (this.Count != 0)
			{
				DateTime dateTime = new DateTime((long)pad.XMin);
				DateTime dateTime2 = new DateTime((long)pad.XMax);
				double min = this.GetMin(dateTime, dateTime2);
				double max = this.GetMax(dateTime, dateTime2);
				return new PadRange(min, max);
			}
			return new PadRange(0.0, 0.0);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00004F4C File Offset: 0x00003F4C
		public override void Draw(string Option)
		{
			if (Chart.Pad == null)
			{
				new Canvas("Canvas", "Canvas");
			}
			if (Option.ToLower().IndexOf("b") != -1)
			{
				this.fDrawStyle = EDrawStyle.Bar;
			}
			if (Option.ToLower().IndexOf("c") != -1)
			{
				this.fDrawStyle = EDrawStyle.Circle;
			}
			if (Option.ToLower().IndexOf("l") != -1)
			{
				this.fDrawStyle = EDrawStyle.Line;
			}
			Chart.Pad.Add(this);
			Chart.Pad.Title.Add(this.fName, this.fColor);
			Chart.Pad.Legend.Add(this.fName, this.fColor);
			Chart.Pad.AxisBottom.Type = EAxisType.DateTime;
			Chart.Pad.AxisBottom.LabelFormat = "MM/dd/yyyy hh:mm";
			if (this.Count > 0)
			{
				if ((this.LastDateTime - this.FirstDateTime).TotalSeconds / (double)(this.Count - 1) >= 86400.0)
				{
					Chart.Pad.AxisBottom.LabelFormat = "MM/dd/yyyy";
					this.fToolTipDateTimeFormat = "MM/dd/yyyy";
				}
				else
				{
					Chart.Pad.AxisBottom.LabelFormat = "hh:mm";
					this.fToolTipDateTimeFormat = "hh:mm";
				}
				if (Option.ToLower().IndexOf("s") == -1)
				{
					double xmin = (double)this.FirstDateTime.Ticks;
					double xmax = (double)this.LastDateTime.Ticks;
					double min = this.GetMin();
					double max = this.GetMax();
					Chart.Pad.SetRange(xmin, xmax, min, max);
				}
			}
		}

		// Token: 0x0600011F RID: 287 RVA: 0x000050EF File Offset: 0x000040EF
		public override void Draw()
		{
			this.Draw("");
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000050FC File Offset: 0x000040FC
		public virtual void Paint(Pad pad, double XMin, double XMax, double YMin, double YMax)
		{
			Pen pen = new Pen(this.fColor, (float)this.fDrawWidth);
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
			int index = this.GetIndex(dateTime, EIndexOption.Next);
			int index2 = this.GetIndex(dateTime2, EIndexOption.Prev);
			if (index == -1 || index2 == -1)
			{
				return;
			}
			switch (this.fDrawStyle)
			{
			case EDrawStyle.Line:
				for (int i = index; i <= index2; i++)
				{
					DateTime dateTime3 = this.GetDateTime(i);
					double num12 = (double)dateTime3.Ticks;
					double num13 = this[i, 0];
					if (dateTime3 > this.splitDate)
					{
						pen = new Pen(this.secondColor, (float)this.fDrawWidth);
					}
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
					DateTime dateTime4 = this.GetDateTime(j);
					double num12 = (double)dateTime4.Ticks;
					double num13 = this[j, 0];
					if (dateTime4 > this.splitDate)
					{
						pen = new Pen(this.secondColor, (float)this.fDrawWidth);
					}
					if (num13 > 0.0)
					{
						pad.Graphics.FillRectangle(new SolidBrush(this.fColor), pad.ClientX(num12) - (this.fDrawWidth + 1) / 2, pad.ClientY(num13), this.fDrawWidth + 1, pad.ClientY(0.0) - pad.ClientY(num13));
					}
					else
					{
						pad.Graphics.FillRectangle(new SolidBrush(this.fColor), pad.ClientX(num12) - (this.fDrawWidth + 1) / 2, pad.ClientY(0.0), this.fDrawWidth + 1, pad.ClientY(num13) - pad.ClientY(0.0));
					}
				}
				return;
			case EDrawStyle.Circle:
				for (int k = index; k <= index2; k++)
				{
					DateTime dateTime5 = this.GetDateTime(k);
					double num12 = (double)dateTime5.Ticks;
					double num13 = this[k, 0];
					SolidBrush brush;
					if (dateTime5 > this.splitDate)
					{
						brush = new SolidBrush(this.secondColor);
					}
					else
					{
						brush = new SolidBrush(this.fColor);
					}
					pad.Graphics.FillEllipse(brush, pad.ClientX(num12) - this.fDrawWidth / 2, pad.ClientY(num13) - this.fDrawWidth / 2, this.fDrawWidth, this.fDrawWidth);
				}
				return;
			default:
				return;
			}
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00005420 File Offset: 0x00004420
		public virtual TDistance Distance(double X, double Y)
		{
			if (X < 0.0)
			{
				return null;
			}
			TDistance tdistance = new TDistance();
			int index = this.GetIndex(new DateTime((long)X), EIndexOption.Next);
			int index2 = this.GetIndex(new DateTime((long)X), EIndexOption.Prev);
			if (index != -1)
			{
				DateTime dateTime = this.GetDateTime(index);
				tdistance.dX = Math.Abs(X - (double)dateTime.Ticks);
				tdistance.dY = Math.Abs(Y - this[dateTime]);
				tdistance.X = (double)dateTime.Ticks;
				tdistance.Y = this[dateTime];
			}
			if (index2 != -1)
			{
				DateTime dateTime2 = this.GetDateTime(index2);
				double num = Math.Abs(X - (double)dateTime2.Ticks);
				double num2 = Math.Abs(Y - this[dateTime2]);
				if (num < tdistance.dX && num2 < tdistance.dY)
				{
					tdistance.dX = num;
					tdistance.dY = num2;
					tdistance.X = (double)dateTime2.Ticks;
					tdistance.Y = this[dateTime2];
				}
			}
			if (tdistance.dX != 1.7976931348623157E+308 && tdistance.dY != 1.7976931348623157E+308)
			{
				DateTime dateTime3 = new DateTime((long)tdistance.X);
				StringBuilder stringBuilder = new StringBuilder();
				if (this.fToolTipFormat != null && this.fToolTipDateTimeFormat != null)
				{
					stringBuilder.AppendFormat(this.fToolTipFormat, new object[]
					{
						this.fName,
						this.fTitle,
						dateTime3.ToString(this.fToolTipDateTimeFormat),
						tdistance.Y
					});
				}
				tdistance.ToolTipText = stringBuilder.ToString();
				return tdistance;
			}
			return null;
		}

		// Token: 0x0400001C RID: 28
		protected EDrawStyle fDrawStyle;

		// Token: 0x0400001D RID: 29
		protected int fDrawWidth = 1;

		// Token: 0x0400001E RID: 30
		protected bool fAutoZoom = true;

		// Token: 0x0400001F RID: 31
		protected double fMin = double.NaN;

		// Token: 0x04000020 RID: 32
		protected double fMax = double.NaN;

		// Token: 0x04000021 RID: 33
		protected double fSum = double.NaN;

		// Token: 0x04000022 RID: 34
		protected double fMean = double.NaN;

		// Token: 0x04000023 RID: 35
		protected double fMedian = double.NaN;

		// Token: 0x04000024 RID: 36
		protected double fVariance = double.NaN;

		// Token: 0x04000025 RID: 37
		protected Color secondColor;

		// Token: 0x04000026 RID: 38
		protected DateTime splitDate = DateTime.MaxValue;
	}
}
