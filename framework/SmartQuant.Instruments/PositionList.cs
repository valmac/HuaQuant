using System;
using System.Collections;

namespace SmartQuant.Instruments
{
	// Token: 0x02000021 RID: 33
	public class PositionList : IEnumerable
	{
		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000229 RID: 553 RVA: 0x00007822 File Offset: 0x00006822
		public int Count
		{
			get
			{
				return this.fList.Count;
			}
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00007842 File Offset: 0x00006842
		public void Add(Position position)
		{
			if (this.fList.Contains(position.Name))
			{
				throw new ApplicationException("Can not add position that is already present in the list : " + position.Name);
			}
			this.fList.Add(position.Name, position);
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0000787F File Offset: 0x0000687F
		public void Remove(Position position)
		{
			this.fList.Remove(position.Name);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00007892 File Offset: 0x00006892
		public void RemoveAt(int index)
		{
			this.fList.RemoveAt(index);
		}

		// Token: 0x0600022E RID: 558 RVA: 0x000078A0 File Offset: 0x000068A0
		public void Clear()
		{
			this.fList.Clear();
		}

		// Token: 0x0600022F RID: 559 RVA: 0x000078AD File Offset: 0x000068AD
		public bool Contains(string name)
		{
			return this.fList.Contains(name);
		}

		// Token: 0x06000230 RID: 560 RVA: 0x000078BB File Offset: 0x000068BB
		public bool Contains(Instrument instrument)
		{
			return this.fList.Contains(instrument.Symbol);
		}

		// Token: 0x06000231 RID: 561 RVA: 0x000078CE File Offset: 0x000068CE
		public bool Contains(Position position)
		{
			return this.fList.ContainsValue(position);
		}

		// Token: 0x17000080 RID: 128
		public Position this[int index]
		{
			get
			{
				return this.fList.GetByIndex(index) as Position;
			}
		}

		// Token: 0x17000081 RID: 129
		public Position this[string name]
		{
			get
			{
				return this.fList[name] as Position;
			}
		}

		// Token: 0x17000082 RID: 130
		public Position this[Instrument instrument]
		{
			get
			{
				return this.fList[instrument.Symbol] as Position;
			}
		}

		// Token: 0x06000235 RID: 565 RVA: 0x0000791A File Offset: 0x0000691A
		public IEnumerator GetEnumerator()
		{
			return this.fList.Values.GetEnumerator();
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0000792C File Offset: 0x0000692C
		public override string ToString()
		{
			string text = "";
			foreach (object obj in this.fList.Values)
			{
				Position position = (Position)obj;
				text = text + position.ToString() + Environment.NewLine;
			}
			return text;
		}

		// Token: 0x0400008D RID: 141
		private SortedList fList = new SortedList();
	}
}
