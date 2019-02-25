using System;
using System.Collections;
using SmartQuant.File.Indexing;

namespace SmartQuant.File
{
	// Token: 0x02000015 RID: 21
	public class SeriesCollection : ICollection, IEnumerable
	{
		// Token: 0x0600008B RID: 139 RVA: 0x0000569F File Offset: 0x0000469F
		internal SeriesCollection(DataFile file)
		{
			this.file = file;
			this.collection = new SortedList();
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600008C RID: 140 RVA: 0x000056B9 File Offset: 0x000046B9
		public int Count
		{
			get
			{
				return this.collection.Count;
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x000056C6 File Offset: 0x000046C6
		public bool Contains(string name)
		{
			return this.collection.ContainsKey(name);
		}

		// Token: 0x17000020 RID: 32
		public FileSeries this[string name]
		{
			get
			{
				return this.collection[name] as FileSeries;
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x000056E8 File Offset: 0x000046E8
		public void Remove(string name)
		{
			FileSeries fileSeries = this[name];
			this.collection.Remove(fileSeries.Name);
			this.file.Streamer.RemoveSeries(fileSeries);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00005720 File Offset: 0x00004720
		public FileSeries Add(string name)
		{
			if (name.Length == 0 || name.Length > 127)
			{
				throw new ArgumentException("Unsupported length of the series name.Must be 1..127 symbols", "name");
			}
			FileSeries fileSeries = new FileSeries(this.file.Streamer, name, "", this.file.DefaultZipLevel, this.file.DefaultBlockSize, this.file.DefaultIndexer);
			this.collection.Add(fileSeries.Name, fileSeries);
			this.file.Streamer.WriteSeriesSettings(fileSeries);
			return fileSeries;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000057AC File Offset: 0x000047AC
		public void Rename(string oldName, string newName)
		{
			if (oldName == null)
			{
				throw new ArgumentNullException("oldName");
			}
			if (newName == null)
			{
				throw new ArgumentNullException("newName");
			}
			if (newName.Length == 0 || newName.Length > 127)
			{
				throw new ArgumentException("The new series name must contains from 1 to 127 symbols.");
			}
			FileSeries fileSeries = this[oldName];
			if (fileSeries == null)
			{
				throw new ArgumentException("The series " + oldName + " not found.");
			}
			if (this.Contains(newName))
			{
				throw new ArgumentException("The series " + newName + " already exists.");
			}
			fileSeries.SetName(newName);
			this.collection.Remove(oldName);
			this.collection.Add(newName, fileSeries);
			this.file.Streamer.WriteSeriesSettings(fileSeries);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00005864 File Offset: 0x00004864
		internal FileSeries Add(string name, string description, int zipLevel, int maxBlockSize, Indexer indexer)
		{
			FileSeries fileSeries = new FileSeries(this.file.Streamer, name, description, zipLevel, maxBlockSize, indexer);
			this.collection.Add(fileSeries.Name, fileSeries);
			return fileSeries;
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000093 RID: 147 RVA: 0x0000589C File Offset: 0x0000489C
		public bool IsSynchronized
		{
			get
			{
				return this.collection.IsSynchronized;
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000058A9 File Offset: 0x000048A9
		public void CopyTo(Array array, int index)
		{
			this.collection.Values.CopyTo(array, index);
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000095 RID: 149 RVA: 0x000058BD File Offset: 0x000048BD
		public object SyncRoot
		{
			get
			{
				return this.collection.SyncRoot;
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000058CA File Offset: 0x000048CA
		public IEnumerator GetEnumerator()
		{
			return this.collection.Values.GetEnumerator();
		}

		// Token: 0x04000052 RID: 82
		private SortedList collection;

		// Token: 0x04000053 RID: 83
		private DataFile file;
	}
}
