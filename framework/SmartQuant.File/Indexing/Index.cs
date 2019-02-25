using System;
using System.Collections;

namespace SmartQuant.File.Indexing
{
	// Token: 0x0200000D RID: 13
	internal abstract class Index : IEnumerable
	{
		// Token: 0x06000046 RID: 70 RVA: 0x00004C3F File Offset: 0x00003C3F
		internal Index()
		{
			this.items = new ArrayList();
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00004C54 File Offset: 0x00003C54
		internal static Index GetIndex(Indexer indexer)
		{
			switch (indexer)
			{
			case Indexer.Daily:
				return new DailyIndex();
			case Indexer.Monthly:
				return new MonthlyIndex();
			default:
				return null;
			}
		}

		// Token: 0x17000007 RID: 7
		internal virtual IndexItem this[DateTime datetime]
		{
			get
			{
				for (int i = this.items.Count - 1; i >= 0; i--)
				{
					IndexItem indexItem = this.items[i] as IndexItem;
					if (datetime >= indexItem.DateTime)
					{
						return indexItem;
					}
				}
				return null;
			}
		}

		// Token: 0x17000008 RID: 8
		internal virtual IndexItem this[int objectPosition]
		{
			get
			{
				for (int i = this.items.Count - 1; i >= 0; i--)
				{
					IndexItem indexItem = this.items[i] as IndexItem;
					if (objectPosition >= indexItem.ObjectPosition)
					{
						return indexItem;
					}
				}
				return null;
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00004D10 File Offset: 0x00003D10
		internal virtual void Add(DateTime datetime, int objectPosition, long blockPosition)
		{
			int i;
			for (i = 0; i < this.items.Count; i++)
			{
				IndexItem indexItem = this.items[i] as IndexItem;
				if (indexItem.DateTime > datetime)
				{
					break;
				}
				if (indexItem.DateTime == datetime)
				{
					i = -1;
					break;
				}
			}
			if (i != -1)
			{
				IndexItem indexItem2 = new IndexItem();
				indexItem2.DateTime = datetime;
				indexItem2.ObjectPosition = objectPosition;
				indexItem2.BlockPosition = blockPosition;
				this.items.Insert(i, indexItem2);
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00004D91 File Offset: 0x00003D91
		public IEnumerator GetEnumerator()
		{
			return this.items.GetEnumerator();
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00004D9E File Offset: 0x00003D9E
		internal int Count
		{
			get
			{
				return this.items.Count;
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00004DAB File Offset: 0x00003DAB
		internal void Add(IndexItem item)
		{
			this.items.Add(item);
		}

		// Token: 0x04000028 RID: 40
		protected ArrayList items;
	}
}
