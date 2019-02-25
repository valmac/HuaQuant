using System;
using SmartQuant.Data;
using SmartQuant.File;
using SmartQuant.Series;

namespace SmartQuant.Instruments
{
	// Token: 0x02000041 RID: 65
	public class FileDataServer : IDataServer
	{
		// Token: 0x0600035A RID: 858 RVA: 0x0000B1D2 File Offset: 0x0000A1D2
		public FileDataServer()
		{
			this.file = new DataFile("FILE", Framework.Installation.DataDir.FullName);
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600035B RID: 859 RVA: 0x0000B1F9 File Offset: 0x0000A1F9
		public DataFile File
		{
			get
			{
				return this.file;
			}
		}

		// Token: 0x0600035C RID: 860 RVA: 0x0000B204 File Offset: 0x0000A204
		public void Add(string series, IDataObject obj)
		{
			IDataSeries dataSeries = this.file.Series[series];
			if (dataSeries == null)
			{
				dataSeries = this.file.Series.Add(series);
			}
			dataSeries.Add(obj.DateTime, obj);
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0000B248 File Offset: 0x0000A248
		public void Remove(string series, DateTime dateTime)
		{
			IDataSeries dataSeries = this.file.Series[series];
			if (dataSeries != null)
			{
				dataSeries.Remove(dateTime);
			}
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0000B274 File Offset: 0x0000A274
		public void Update(string series, IDataObject obj)
		{
			IDataSeries dataSeries = this.file.Series[series];
			if (dataSeries == null)
			{
				dataSeries = this.file.Series.Add(series);
			}
			dataSeries.Update(obj.DateTime, obj);
		}

		// Token: 0x0600035F RID: 863 RVA: 0x0000B2B8 File Offset: 0x0000A2B8
		public TradeArray GetTradeArray(string series, DateTime datetime1, DateTime datetime2)
		{
			TradeArray tradeArray = new TradeArray();
			FileSeries fileSeries = this.file.Series[series];
			if (fileSeries != null)
			{
				ISeriesObject[] array = this.file.Series[series].GetArray(datetime1, datetime2);
				foreach (Trade obj in array)
				{
					tradeArray.Add(obj);
				}
			}
			return tradeArray;
		}

		// Token: 0x06000360 RID: 864 RVA: 0x0000B324 File Offset: 0x0000A324
		public QuoteArray GetQuoteArray(string series, DateTime datetime1, DateTime datetime2)
		{
			QuoteArray quoteArray = new QuoteArray();
			FileSeries fileSeries = this.file.Series[series];
			if (fileSeries != null)
			{
				ISeriesObject[] array = this.file.Series[series].GetArray(datetime1, datetime2);
				foreach (Quote obj in array)
				{
					quoteArray.Add(obj);
				}
			}
			return quoteArray;
		}

		// Token: 0x06000361 RID: 865 RVA: 0x0000B390 File Offset: 0x0000A390
		public BarSeries GetBarSeries(string series, DateTime datetime1, DateTime datetime2)
		{
			BarSeries barSeries = new BarSeries();
			FileSeries fileSeries = this.file.Series[series];
			if (fileSeries != null)
			{
				ISeriesObject[] array = this.file.Series[series].GetArray(datetime1, datetime2);
				foreach (Bar bar in array)
				{
					barSeries.Add(bar);
				}
			}
			return barSeries;
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0000B3FC File Offset: 0x0000A3FC
		public DailySeries GetDailySeries(string seriesName, DateTime datetime1, DateTime datetime2)
		{
			DailySeries dailySeries = new DailySeries();
			FileSeries fileSeries = this.file.Series[seriesName];
			if (fileSeries != null)
			{
				ISeriesObject[] array = fileSeries.GetArray(datetime1, datetime2);
				foreach (Daily bar in array)
				{
					dailySeries.Add(bar);
				}
			}
			return dailySeries;
		}

		// Token: 0x06000363 RID: 867 RVA: 0x0000B458 File Offset: 0x0000A458
		public MarketDepthArray GetMarketDepthArray(string seriesName, DateTime datetime1, DateTime datetime2)
		{
			MarketDepthArray marketDepthArray = new MarketDepthArray();
			FileSeries fileSeries = this.file.Series[seriesName];
			if (fileSeries != null)
			{
				ISeriesObject[] array = fileSeries.GetArray(datetime1, datetime2);
				foreach (MarketDepth obj in array)
				{
					marketDepthArray.Add(obj);
				}
			}
			return marketDepthArray;
		}

		// Token: 0x06000364 RID: 868 RVA: 0x0000B4B2 File Offset: 0x0000A4B2
		public IDataSeries GetDataSeries(string series)
		{
			return this.file.Series[series];
		}

		// Token: 0x06000365 RID: 869 RVA: 0x0000B4C5 File Offset: 0x0000A4C5
		public IDataSeries AddDataSeries(string series)
		{
			return this.file.Series.Add(series);
		}

		// Token: 0x06000366 RID: 870 RVA: 0x0000B4D8 File Offset: 0x0000A4D8
		public void Delete(string series)
		{
			this.file.Series.Remove(series);
		}

		// Token: 0x06000367 RID: 871 RVA: 0x0000B4EB File Offset: 0x0000A4EB
		public void Clear(string series)
		{
			this.file.Series[series].Clear();
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0000B503 File Offset: 0x0000A503
		public void Rename(string oldSeries, string newSeries)
		{
			this.file.Series.Rename(oldSeries, newSeries);
		}

		// Token: 0x06000369 RID: 873 RVA: 0x0000B518 File Offset: 0x0000A518
		public DataSeriesList GetDataSeries()
		{
			DataSeriesList dataSeriesList = new DataSeriesList();
			foreach (object obj in this.file.Series)
			{
				FileSeries series = (FileSeries)obj;
				dataSeriesList.Add(series);
			}
			return dataSeriesList;
		}

		// Token: 0x0600036A RID: 874 RVA: 0x0000B580 File Offset: 0x0000A580
		public void Flush()
		{
			foreach (object obj in this.file.Series)
			{
				FileSeries fileSeries = (FileSeries)obj;
				fileSeries.Flush();
			}
		}

		// Token: 0x0600036B RID: 875 RVA: 0x0000B5E0 File Offset: 0x0000A5E0
		public void Close()
		{
			this.file.Close();
		}

		// Token: 0x040000F6 RID: 246
		private DataFile file;
	}
}
