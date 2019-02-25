using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization;
using SmartQuant.Data;

namespace SmartQuant.File
{
	// Token: 0x02000012 RID: 18
	internal class Block : IEnumerable
	{
		// Token: 0x0600007A RID: 122 RVA: 0x00005404 File Offset: 0x00004404
		internal Block(DateTime firstDateTime, DateTime lastDateTime, int objectCount)
		{
			this.firstDateTime = firstDateTime;
			this.lastDateTime = lastDateTime;
			this.objectCount = objectCount;
			this.objects = new ArrayList();
			this.isModified = false;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00005456 File Offset: 0x00004456
		internal Block() : this(DateTime.MaxValue, DateTime.MinValue, 0)
		{
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00005469 File Offset: 0x00004469
		internal DateTime FirstDateTime
		{
			get
			{
				return this.firstDateTime;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00005471 File Offset: 0x00004471
		internal DateTime LastDateTime
		{
			get
			{
				return this.lastDateTime;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00005479 File Offset: 0x00004479
		internal int ObjectCount
		{
			get
			{
				return this.objectCount;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00005481 File Offset: 0x00004481
		internal bool IsModified
		{
			get
			{
				return this.isModified;
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000548C File Offset: 0x0000448C
		internal void Add(ISeriesObject obj)
		{
			int index = this.FindSuitableIndex(obj.DateTime);
			this.objects.Insert(index, obj);
			if (obj.DateTime < this.firstDateTime)
			{
				this.firstDateTime = obj.DateTime;
			}
			if (obj.DateTime > this.lastDateTime)
			{
				this.lastDateTime = obj.DateTime;
			}
			this.objectCount = this.objects.Count;
			this.isModified = true;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000550C File Offset: 0x0000450C
		internal void RemoveAt(int index)
		{
			this.objects.RemoveAt(index);
			if (this.objects.Count > 0)
			{
				this.firstDateTime = (this.objects[0] as ISeriesObject).DateTime;
				this.lastDateTime = (this.objects[this.objects.Count - 1] as ISeriesObject).DateTime;
			}
			this.objectCount = this.objects.Count;
			this.isModified = true;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00005590 File Offset: 0x00004590
		internal void ReplaceAt(int index, ISeriesObject obj)
		{
			if ((this.objects[index] as ISeriesObject).DateTime != obj.DateTime)
			{
				throw new ArgumentException("The datetime mismatch");
			}
			this.objects[index] = obj;
			this.isModified = true;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000055E0 File Offset: 0x000045E0
		private int FindSuitableIndex(DateTime datetime)
		{
			int i;
			for (i = this.objects.Count; i > 0; i--)
			{
				ISeriesObject seriesObject = this.objects[i - 1] as ISeriesObject;
				if (datetime >= seriesObject.DateTime)
				{
					break;
				}
			}
			return i;
		}

		// Token: 0x1700001D RID: 29
		internal ISeriesObject this[int index]
		{
			get
			{
				return this.objects[index] as ISeriesObject;
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00005639 File Offset: 0x00004639
		internal void Save(Stream stream, IFormatter formatter)
		{
			formatter.Serialize(stream, this.objects);
			this.isModified = false;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000564F File Offset: 0x0000464F
		internal void Load(Stream stream, IFormatter formatter)
		{
			this.objects = (formatter.Deserialize(stream) as ArrayList);
			this.isModified = false;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000566A File Offset: 0x0000466A
		public IEnumerator GetEnumerator()
		{
			return this.objects.GetEnumerator();
		}

		// Token: 0x04000046 RID: 70
		internal long Position = -1L;

		// Token: 0x04000047 RID: 71
		internal long PrevBlockPosition = -1L;

		// Token: 0x04000048 RID: 72
		internal long NextBlockPosition = -1L;

		// Token: 0x04000049 RID: 73
		private DateTime firstDateTime;

		// Token: 0x0400004A RID: 74
		private DateTime lastDateTime;

		// Token: 0x0400004B RID: 75
		private ArrayList objects;

		// Token: 0x0400004C RID: 76
		private int objectCount;

		// Token: 0x0400004D RID: 77
		private bool isModified;
	}
}
