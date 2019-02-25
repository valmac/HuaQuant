using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.IO;
using SmartQuant.File.Indexing;

namespace SmartQuant.File
{
	// Token: 0x02000010 RID: 16
	public class DataFile
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000054 RID: 84 RVA: 0x00004E1C File Offset: 0x00003E1C
		// (remove) Token: 0x06000055 RID: 85 RVA: 0x00004E35 File Offset: 0x00003E35
		public event SeriesEventHandler SeriesDefragmentStarted;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000056 RID: 86 RVA: 0x00004E4E File Offset: 0x00003E4E
		// (remove) Token: 0x06000057 RID: 87 RVA: 0x00004E67 File Offset: 0x00003E67
		public event SeriesEventHandler SeriesDefragmentFinished;

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000058 RID: 88 RVA: 0x00004E80 File Offset: 0x00003E80
		// (remove) Token: 0x06000059 RID: 89 RVA: 0x00004E99 File Offset: 0x00003E99
		public event DefragmentCancelEventHandler DefragmentCancelRequest;

		// Token: 0x0600005A RID: 90 RVA: 0x00004EB4 File Offset: 0x00003EB4
		public DataFile(string name, string location)
		{
			LeaseManager.Check();
			DirectoryInfo directoryInfo = new DirectoryInfo(location);
			this.location = directoryInfo.FullName;
			this.name = name;
			this.description = "";
			this.filenameProperties = this.Location + "\\file.xml";
			this.Init();
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00004F0D File Offset: 0x00003F0D
		public static DataFile Open(string location)
		{
			return new DataFile("File", location);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00004F1C File Offset: 0x00003F1C
		private void Init()
		{
			this.typeManager = new TypeManager(this.Location);
			this.formatter = new SeriesFormatter(this.typeManager);
			this.streamer = new Streamer(this.Location, this.formatter);
			this.defaultBlockSize = 1000;
			this.defaultZipLevel = 1;
			this.LoadProperties();
			this.series = new SeriesCollection(this);
			this.streamer.LoadSeries(this.series);
			this.isOpen = true;
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00004F9E File Offset: 0x00003F9E
		[Browsable(true)]
		[Category("Names")]
		[Description("The name of the file")]
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00004FA6 File Offset: 0x00003FA6
		// (set) Token: 0x0600005F RID: 95 RVA: 0x00004FAE File Offset: 0x00003FAE
		[Description("Gets or sets the description")]
		[Category("Names")]
		[Browsable(true)]
		public string Description
		{
			get
			{
				return this.description;
			}
			set
			{
				this.description = value;
				this.SaveProperties();
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00004FBD File Offset: 0x00003FBD
		[Description("Data files location")]
		[Category("Misc")]
		[Browsable(true)]
		public string Location
		{
			get
			{
				return this.location;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00004FC5 File Offset: 0x00003FC5
		[Browsable(false)]
		public SeriesCollection Series
		{
			get
			{
				return this.series;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00004FCD File Offset: 0x00003FCD
		// (set) Token: 0x06000063 RID: 99 RVA: 0x00004FD5 File Offset: 0x00003FD5
		[DefaultValue(1000)]
		[Browsable(true)]
		[Category("Defaults")]
		[Description("Gets or sets the default block's size for the new series")]
		public int DefaultBlockSize
		{
			get
			{
				return this.defaultBlockSize;
			}
			set
			{
				if (value < 2)
				{
					throw new ArgumentOutOfRangeException("DefaultBlockSize", value, "The value must be greater than 2");
				}
				this.defaultBlockSize = value;
				this.SaveProperties();
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00004FFE File Offset: 0x00003FFE
		// (set) Token: 0x06000065 RID: 101 RVA: 0x00005006 File Offset: 0x00004006
		[Browsable(true)]
		[DefaultValue(1)]
		[Category("Defaults")]
		[Description("Gets or sets the default zip level for the new series")]
		public int DefaultZipLevel
		{
			get
			{
				return this.defaultZipLevel;
			}
			set
			{
				if (value < 0 || value > 9)
				{
					throw new ArgumentOutOfRangeException("DefaultZipLevel", value, "The value must be in range 0..9");
				}
				this.defaultZipLevel = value;
				this.SaveProperties();
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00005034 File Offset: 0x00004034
		// (set) Token: 0x06000067 RID: 103 RVA: 0x0000503C File Offset: 0x0000403C
		[Browsable(false)]
		[Description("Gets or sets the indexing method for the new series")]
		[Category("Defaults")]
		public Indexer DefaultIndexer
		{
			get
			{
				return this.indexer;
			}
			set
			{
				this.indexer = value;
				this.SaveProperties();
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000068 RID: 104 RVA: 0x0000504B File Offset: 0x0000404B
		[Browsable(false)]
		public Hashtable RegisteredTypes
		{
			get
			{
				return this.typeManager.RegisteredTypes;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00005058 File Offset: 0x00004058
		[Browsable(false)]
		public long DataFileSize
		{
			get
			{
				return this.streamer.DataFileSize;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00005065 File Offset: 0x00004065
		[Browsable(false)]
		public long HeaderFileSize
		{
			get
			{
				return this.streamer.HeaderFileSize;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00005072 File Offset: 0x00004072
		[Browsable(false)]
		public long IndexFileSize
		{
			get
			{
				return this.streamer.IndexFileSize;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600006C RID: 108 RVA: 0x0000507F File Offset: 0x0000407F
		[Browsable(false)]
		public bool IsOpen
		{
			get
			{
				return this.isOpen;
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00005088 File Offset: 0x00004088
		public void Close()
		{
			if (this.isOpen)
			{
				foreach (object obj in this.series)
				{
					FileSeries fileSeries = (FileSeries)obj;
					fileSeries.Flush();
				}
				this.streamer.Close();
				this.series = new SeriesCollection(this);
				this.isOpen = false;
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00005108 File Offset: 0x00004108
		public void Defragment(int zipLevel, int maxBlockSize)
		{
			string text = this.Location + "\\temp";
			Directory.CreateDirectory(text);
			this.streamer.Defragment(text, this, zipLevel, maxBlockSize);
			Directory.Delete(text, true);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00005143 File Offset: 0x00004143
		public void Defragment()
		{
			this.Defragment(this.defaultZipLevel, this.defaultBlockSize);
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00005157 File Offset: 0x00004157
		internal Streamer Streamer
		{
			get
			{
				return this.streamer;
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000515F File Offset: 0x0000415F
		internal void EmitSeriesDefragmentStarted(FileSeries series)
		{
			if (this.SeriesDefragmentStarted != null)
			{
				this.SeriesDefragmentStarted(new SeriesEventArgs(series));
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000517A File Offset: 0x0000417A
		internal void EmitSeriesDefragmentFinished(FileSeries series)
		{
			if (this.SeriesDefragmentFinished != null)
			{
				this.SeriesDefragmentFinished(new SeriesEventArgs(series));
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00005195 File Offset: 0x00004195
		internal void EmitDefragmentCancelRequest(DefragmentCancelEventArgs args)
		{
			if (this.DefragmentCancelRequest != null)
			{
				this.DefragmentCancelRequest(args);
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000051AC File Offset: 0x000041AC
		private void LoadProperties()
		{
			try
			{
				if (System.IO.File.Exists(this.filenameProperties))
				{
					DataSet dataSet = new DataSet("config");
					DataTable dataTable = dataSet.Tables.Add("properties");
					dataTable.Columns.Add("description", typeof(string));
					dataTable.Columns.Add("zip_level", typeof(int));
					dataTable.Columns.Add("max_block_size", typeof(int));
					dataTable.Columns.Add("indexer", typeof(Indexer));
					dataSet.ReadXml(this.filenameProperties, XmlReadMode.IgnoreSchema);
					DataRow dataRow = dataSet.Tables["properties"].Rows[0];
					this.description = (string)dataRow["description"];
					this.defaultZipLevel = (int)dataRow["zip_level"];
					this.defaultBlockSize = (int)dataRow["max_block_size"];
					this.indexer = (Indexer)dataRow["indexer"];
				}
				else
				{
					this.SaveProperties();
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000052FC File Offset: 0x000042FC
		private void SaveProperties()
		{
			DataSet dataSet = new DataSet("config");
			DataTable dataTable = dataSet.Tables.Add("properties");
			dataTable.Columns.Add("description", typeof(string));
			dataTable.Columns.Add("zip_level", typeof(int));
			dataTable.Columns.Add("max_block_size", typeof(int));
			dataTable.Columns.Add("indexer", typeof(Indexer));
			DataRow dataRow = dataTable.NewRow();
			dataTable.Rows.Add(dataRow);
			dataRow["description"] = this.description;
			dataRow["zip_level"] = this.defaultZipLevel;
			dataRow["max_block_size"] = this.defaultBlockSize;
			dataRow["indexer"] = this.indexer;
			dataSet.WriteXml(this.filenameProperties, XmlWriteMode.WriteSchema);
		}

		// Token: 0x0400002A RID: 42
		public const int DEFAULT_BLOCK_SIZE = 1000;

		// Token: 0x0400002B RID: 43
		public const int DEFAULT_ZIP_LEVEL = 1;

		// Token: 0x0400002C RID: 44
		private const string PROPERTIES_FILE_NAME = "file.xml";

		// Token: 0x0400002D RID: 45
		private const string CATEGORY_DEFAULTS = "Defaults";

		// Token: 0x0400002E RID: 46
		private const string CATEGORY_NAMES = "Names";

		// Token: 0x0400002F RID: 47
		private const string CATEGORY_STATUS = "Status";

		// Token: 0x04000030 RID: 48
		private const string CATEGORY_MISC = "Misc";

		// Token: 0x04000031 RID: 49
		private const string TAG_CONFIG = "config";

		// Token: 0x04000032 RID: 50
		private const string TAG_PROPERTIES = "properties";

		// Token: 0x04000033 RID: 51
		private const string TAG_DESCRIPTION = "description";

		// Token: 0x04000034 RID: 52
		private const string TAG_DEFAULT_ZIP_LEVEL = "zip_level";

		// Token: 0x04000035 RID: 53
		private const string TAG_DEFAULT_BLOCK_SIZE = "max_block_size";

		// Token: 0x04000036 RID: 54
		private const string TAG_INDEXER = "indexer";

		// Token: 0x04000037 RID: 55
		private SeriesCollection series;

		// Token: 0x04000038 RID: 56
		private int defaultBlockSize;

		// Token: 0x04000039 RID: 57
		private int defaultZipLevel;

		// Token: 0x0400003A RID: 58
		private string name;

		// Token: 0x0400003B RID: 59
		private string description;

		// Token: 0x0400003C RID: 60
		private string location;

		// Token: 0x0400003D RID: 61
		private Indexer indexer;

		// Token: 0x0400003E RID: 62
		private string filenameProperties;

		// Token: 0x0400003F RID: 63
		private TypeManager typeManager;

		// Token: 0x04000040 RID: 64
		private SeriesFormatter formatter;

		// Token: 0x04000041 RID: 65
		private Streamer streamer;

		// Token: 0x04000042 RID: 66
		private bool isOpen;
	}
}
