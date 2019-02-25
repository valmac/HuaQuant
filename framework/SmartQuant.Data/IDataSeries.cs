using System;
using System.Collections;

namespace SmartQuant.Data
{
	// Token: 0x02000015 RID: 21
	public interface IDataSeries : IEnumerable
	{
		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600009A RID: 154
		string Name { get; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600009B RID: 155
		// (set) Token: 0x0600009C RID: 156
		string Description { get; set; }

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600009D RID: 157
		int Count { get; }

		// Token: 0x17000037 RID: 55
		object this[DateTime datetime]
		{
			get;
			set;
		}

		// Token: 0x17000038 RID: 56
		object this[int index]
		{
			get;
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000A1 RID: 161
		DateTime FirstDateTime { get; }

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000A2 RID: 162
		DateTime LastDateTime { get; }

		// Token: 0x060000A3 RID: 163
		void Add(DateTime datetime, object obj);

		// Token: 0x060000A4 RID: 164
		void Update(DateTime datetime, object obj);

		// Token: 0x060000A5 RID: 165
		void Update(int index, object obj);

		// Token: 0x060000A6 RID: 166
		bool Contains(DateTime datetime);

		// Token: 0x060000A7 RID: 167
		int IndexOf(DateTime datetime);

		// Token: 0x060000A8 RID: 168
		int IndexOf(DateTime datetime, SearchOption option);

		// Token: 0x060000A9 RID: 169
		DateTime DateTimeAt(int index);

		// Token: 0x060000AA RID: 170
		void Remove(DateTime datetime);

		// Token: 0x060000AB RID: 171
		void RemoveAt(int index);

		// Token: 0x060000AC RID: 172
		void Clear();

		// Token: 0x060000AD RID: 173
		void Flush();
	}
}
