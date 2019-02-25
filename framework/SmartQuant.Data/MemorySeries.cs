using System;
using System.Collections;
using System.Collections.Generic;

namespace SmartQuant.Data
{
	// Token: 0x02000016 RID: 22
	public class MemorySeries<TValue> : IDataSeries, IEnumerable
	{
		// Token: 0x060000AE RID: 174 RVA: 0x00003583 File Offset: 0x00002583
		public MemorySeries(string name, string description)
		{
			this.name = name;
			this.description = description;
			this.array = new SortedList<DateTime, TValue>();
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000035A4 File Offset: 0x000025A4
		public MemorySeries(string name) : this(name, "")
		{
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x000035B2 File Offset: 0x000025B2
		public MemorySeries() : this("NoName")
		{
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x000035BF File Offset: 0x000025BF
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x000035C7 File Offset: 0x000025C7
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x000035CF File Offset: 0x000025CF
		public string Description
		{
			get
			{
				return this.description;
			}
			set
			{
				this.description = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x000035D8 File Offset: 0x000025D8
		public int Count
		{
			get
			{
				return this.array.Count;
			}
		}

		// Token: 0x1700003E RID: 62
		public object this[DateTime datetime]
		{
			get
			{
				return this.array[datetime];
			}
			set
			{
				this.array[datetime] = (TValue)((object)value);
			}
		}

		// Token: 0x1700003F RID: 63
		public object this[int index]
		{
			get
			{
				return this.array.Values[index];
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00003624 File Offset: 0x00002624
		public DateTime FirstDateTime
		{
			get
			{
				return this.array.Keys[0];
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x00003637 File Offset: 0x00002637
		public DateTime LastDateTime
		{
			get
			{
				return this.array.Keys[this.array.Count - 1];
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00003656 File Offset: 0x00002656
		public void Add(DateTime datetime, object obj)
		{
			this.array[datetime] = (TValue)((object)obj);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000366A File Offset: 0x0000266A
		public void Update(DateTime datetime, object obj)
		{
			this.Add(datetime, obj);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00003674 File Offset: 0x00002674
		public void Update(int index, object obj)
		{
			this.Update(this.array.Keys[index], obj);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000368E File Offset: 0x0000268E
		public bool Contains(DateTime datetime)
		{
			return this.array.ContainsKey(datetime);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000369C File Offset: 0x0000269C
		public int IndexOf(DateTime datetime)
		{
			return this.array.IndexOfKey(datetime);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000036AC File Offset: 0x000026AC
		public int IndexOf(DateTime datetime, SearchOption option)
		{
			int num = 0;
			int num2 = 0;
			int num3 = this.array.Count - 1;
			bool flag = true;
			while (flag)
			{
				if (num3 < num2)
				{
					return -1;
				}
				num = (num2 + num3) / 2;
				switch (option)
				{
				case SearchOption.Prev:
					if (this.array.Keys[num] <= datetime && (num == this.array.Count - 1 || this.array.Keys[num + 1] > datetime))
					{
						flag = false;
					}
					else if (this.array.Keys[num] > datetime)
					{
						num3 = num - 1;
					}
					else
					{
						num2 = num + 1;
					}
					break;
				case SearchOption.Exact:
					if (this.array.Keys[num] == datetime)
					{
						flag = false;
					}
					else if (this.array.Keys[num] > datetime)
					{
						num3 = num - 1;
					}
					else if (this.array.Keys[num] < datetime)
					{
						num2 = num + 1;
					}
					break;
				case SearchOption.Next:
					if (this.array.Keys[num] >= datetime && (num == 0 || this.array.Keys[num - 1] < datetime))
					{
						flag = false;
					}
					else if (this.array.Keys[num] < datetime)
					{
						num2 = num + 1;
					}
					else
					{
						num3 = num - 1;
					}
					break;
				}
			}
			return num;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00003835 File Offset: 0x00002835
		public DateTime DateTimeAt(int index)
		{
			return this.array.Keys[index];
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00003848 File Offset: 0x00002848
		public void Remove(DateTime datetime)
		{
			this.array.Remove(datetime);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00003857 File Offset: 0x00002857
		public void RemoveAt(int index)
		{
			this.array.RemoveAt(index);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00003865 File Offset: 0x00002865
		public void Clear()
		{
			this.array.Clear();
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00003872 File Offset: 0x00002872
		public void Flush()
		{
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00003874 File Offset: 0x00002874
		public IEnumerator GetEnumerator()
		{
			return this.array.Values.GetEnumerator();
		}

		// Token: 0x04000038 RID: 56
		private string name;

		// Token: 0x04000039 RID: 57
		private string description;

		// Token: 0x0400003A RID: 58
		private SortedList<DateTime, TValue> array;
	}
}
