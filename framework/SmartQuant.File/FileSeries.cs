using System;
using System.Collections;
using System.ComponentModel;
using SmartQuant.Data;
using SmartQuant.File.Indexing;

namespace SmartQuant.File
{
	// Token: 0x02000016 RID: 22
	public class FileSeries : IDataSeries, IEnumerable
	{
		// Token: 0x06000097 RID: 151 RVA: 0x000058DC File Offset: 0x000048DC
		internal FileSeries(Streamer streamer, string name, string description, int zipLevel, int maxBlockSize, Indexer indexer)
		{
			this.streamer = streamer;
			this.name = name;
			this.description = description;
			this.zipLevel = zipLevel;
			this.maxBlockSize = maxBlockSize;
			this.indexer = indexer;
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00005952 File Offset: 0x00004952
		[Category("Naming")]
		[Description("Gets the name of the series")]
		[Browsable(true)]
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000099 RID: 153 RVA: 0x0000595A File Offset: 0x0000495A
		// (set) Token: 0x0600009A RID: 154 RVA: 0x00005962 File Offset: 0x00004962
		[Category("Naming")]
		[Browsable(true)]
		[Description("Gets or sets the description")]
		public string Description
		{
			get
			{
				return this.description;
			}
			set
			{
				if (value.Length > 127)
				{
					throw new ArgumentException("The length of the description string must be less than 128", "description");
				}
				this.description = value;
				this.streamer.WriteSeriesSettings(this);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00005991 File Offset: 0x00004991
		// (set) Token: 0x0600009C RID: 156 RVA: 0x00005999 File Offset: 0x00004999
		[DefaultValue(1000)]
		[Browsable(true)]
		[Category("Settings")]
		[Description("Gets or sets the maximum block's size")]
		public int MaxBlockSize
		{
			get
			{
				return this.maxBlockSize;
			}
			set
			{
				if (value < 2)
				{
					throw new ArgumentOutOfRangeException("MaxBlockSize", value, "The value must be greater than 2");
				}
				this.maxBlockSize = value;
				this.streamer.WriteSeriesSettings(this);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600009D RID: 157 RVA: 0x000059C8 File Offset: 0x000049C8
		// (set) Token: 0x0600009E RID: 158 RVA: 0x000059D0 File Offset: 0x000049D0
		[Browsable(true)]
		[Category("Settings")]
		[Description("Gets or sets the zip level")]
		[DefaultValue(1)]
		public int ZipLevel
		{
			get
			{
				return this.zipLevel;
			}
			set
			{
				if (value < 0 || value > 9)
				{
					throw new ArgumentOutOfRangeException("ZipLevel", value, "The value must be in range 0..9");
				}
				this.zipLevel = value;
				this.streamer.WriteSeriesSettings(this);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00005A04 File Offset: 0x00004A04
		[Browsable(false)]
		public Indexer Indexer
		{
			get
			{
				return this.indexer;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00005A0C File Offset: 0x00004A0C
		[Browsable(false)]
		public IndexStatus IndexStatus
		{
			get
			{
				if (this.indexer == Indexer.None)
				{
					return IndexStatus.None;
				}
				if (this.IndexPosition == -1L)
				{
					return IndexStatus.Old;
				}
				return IndexStatus.Valid;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00005A25 File Offset: 0x00004A25
		[Browsable(false)]
		public int Count
		{
			get
			{
				return this.ObjectCount;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00005A2D File Offset: 0x00004A2D
		[Browsable(false)]
		public DateTime FirstDateTime
		{
			get
			{
				if (this.ObjectCount == 0)
				{
					throw new InvalidOperationException("The series is empty");
				}
				return this.firstDateTime;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00005A48 File Offset: 0x00004A48
		[Browsable(false)]
		public DateTime LastDateTime
		{
			get
			{
				if (this.ObjectCount == 0)
				{
					throw new InvalidOperationException("The series is empty");
				}
				return this.lastDateTime;
			}
		}

		// Token: 0x1700002C RID: 44
		[Browsable(false)]
		object IDataSeries.this[int index]
		{
			get
			{
				return this[index];
			}
		}

		// Token: 0x1700002D RID: 45
		[Browsable(false)]
		public ISeriesObject this[int index]
		{
			get
			{
				return this.streamer.GetByIndex(this, index);
			}
		}

		// Token: 0x1700002E RID: 46
		[Browsable(false)]
		object IDataSeries.this[DateTime datetime]
		{
			get
			{
				return this[datetime];
			}
			set
			{
			}
		}

		// Token: 0x1700002F RID: 47
		[Browsable(false)]
		public ISeriesObject this[DateTime datetime]
		{
			get
			{
				return this[datetime, SearchOption.Exact];
			}
		}

		// Token: 0x17000030 RID: 48
		[Browsable(false)]
		public ISeriesObject this[DateTime datetime, SearchOption option]
		{
			get
			{
				return this.streamer.GetByDateTime(this, datetime, option);
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00005AA0 File Offset: 0x00004AA0
		public ISeriesObject[] GetArray()
		{
			return this.GetArray(DateTime.MinValue, DateTime.MaxValue);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00005AB2 File Offset: 0x00004AB2
		public ISeriesObject[] GetArray(DateTime start, DateTime end)
		{
			return this.streamer.GetArray(this, start, end);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00005AC2 File Offset: 0x00004AC2
		public ISeriesObject[] GetArray(int beginIndex, int endIndex)
		{
			return this.streamer.GetArray(this, beginIndex, endIndex);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00005AD2 File Offset: 0x00004AD2
		public void Add(ISeriesObject obj)
		{
			this.streamer.AddObject(this, obj);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00005AE1 File Offset: 0x00004AE1
		public void Add(DateTime datetime, object obj)
		{
			if (obj is ISeriesObject)
			{
				this.Add(obj as ISeriesObject);
				return;
			}
			throw new ArgumentException("Can not add object. Object class should implement ISeriesObject interface.");
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00005B02 File Offset: 0x00004B02
		public void Update(DateTime datetime, object obj)
		{
			this.streamer.Update(this, obj as ISeriesObject);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00005B16 File Offset: 0x00004B16
		public void Update(int index, object obj)
		{
			this.streamer.Update(this, obj as ISeriesObject, index);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00005B2B File Offset: 0x00004B2B
		public void Flush()
		{
			this.Flush(false);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00005B34 File Offset: 0x00004B34
		public void Flush(bool flushIndex)
		{
			this.streamer.Flush(this, flushIndex);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00005B43 File Offset: 0x00004B43
		public void Reindex(Indexer indexer)
		{
			this.indexer = indexer;
			this.streamer.Reindex(this);
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00005B58 File Offset: 0x00004B58
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x00005B66 File Offset: 0x00004B66
		[Browsable(false)]
		public int Position
		{
			get
			{
				return this.streamer.GetSeriesPosition(this);
			}
			set
			{
				this.streamer.SetSeriesPosition(this, value);
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00005B75 File Offset: 0x00004B75
		public ISeriesObject Read()
		{
			return this.streamer.Read(this);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00005B83 File Offset: 0x00004B83
		public int IndexOf(DateTime datetime, SearchOption option)
		{
			return this.streamer.IndexOf(this, datetime, option);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00005B93 File Offset: 0x00004B93
		public int IndexOf(DateTime datetime)
		{
			return this.IndexOf(datetime, SearchOption.Exact);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00005B9D File Offset: 0x00004B9D
		public bool Contains(DateTime datetime)
		{
			return this.IndexOf(datetime) != -1;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00005BAC File Offset: 0x00004BAC
		public void Remove(DateTime datetime)
		{
			this.streamer.Remove(this, datetime);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00005BBB File Offset: 0x00004BBB
		public void RemoveAt(int index)
		{
			this.streamer.RemoveAt(this, index);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00005BCA File Offset: 0x00004BCA
		public void Clear()
		{
			this.streamer.Clear(this);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00005BD8 File Offset: 0x00004BD8
		public void CopyTo(FileSeries dstSeries, ISeriesFilter filter)
		{
			if (dstSeries == this)
			{
				throw new ArgumentException("The destination series is the same!");
			}
            if (filter == null)
            {
                IEnumerator enumerator = this.GetEnumerator();

                while (enumerator.MoveNext())
                {
                    object obj = enumerator.Current;
                    ISeriesObject obj2 = (ISeriesObject)obj;
                    dstSeries.Add(obj2);
                }
                return;

            }
			filter.Copy(this, dstSeries);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00005C48 File Offset: 0x00004C48
		public DateTime DateTimeAt(int index)
		{
			return this[index].DateTime;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00005C56 File Offset: 0x00004C56
		public IEnumerator GetEnumerator()
		{
			return new FileSeriesEnumerator(this);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00005C5E File Offset: 0x00004C5E
		internal void SetName(string name)
		{
			this.name = name;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00005C67 File Offset: 0x00004C67
		private void DumpBlocks()
		{
			this.streamer.DumpBlocks(this);
		}

		// Token: 0x04000054 RID: 84
		private const string CATEGORY_SETTINGS = "Settings";

		// Token: 0x04000055 RID: 85
		private const string CATEGORY_NAMING = "Naming";

		// Token: 0x04000056 RID: 86
		internal long HeaderPosition = -1L;

		// Token: 0x04000057 RID: 87
		internal long FirstBlockPosition = -1L;

		// Token: 0x04000058 RID: 88
		internal long LastBlockPosition = -1L;

		// Token: 0x04000059 RID: 89
		internal DateTime firstDateTime = DateTime.MaxValue;

		// Token: 0x0400005A RID: 90
		internal DateTime lastDateTime = DateTime.MinValue;

		// Token: 0x0400005B RID: 91
		internal int ObjectCount;

		// Token: 0x0400005C RID: 92
		internal long IndexPosition = -1L;

		// Token: 0x0400005D RID: 93
		private Streamer streamer;

		// Token: 0x0400005E RID: 94
		private string name;

		// Token: 0x0400005F RID: 95
		private string description;

		// Token: 0x04000060 RID: 96
		private int maxBlockSize;

		// Token: 0x04000061 RID: 97
		private int zipLevel;

		// Token: 0x04000062 RID: 98
		private Indexer indexer;
	}
}
