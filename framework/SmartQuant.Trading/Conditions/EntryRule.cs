using System;
using System.Collections;

namespace SmartQuant.Trading.Conditions
{
	// Token: 0x0200006D RID: 109
	public class EntryRule
	{
		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000472 RID: 1138 RVA: 0x0001013A File Offset: 0x0000F13A
		public SignalItem LongEntry
		{
			get
			{
				return this.longSignal;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x00010142 File Offset: 0x0000F142
		public SignalItem ShortEntry
		{
			get
			{
				return this.shortSignal;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x0001014A File Offset: 0x0000F14A
		public ArrayList ItemList
		{
			get
			{
				return this.list;
			}
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00010152 File Offset: 0x0000F152
		public EntryRule(Entry entry)
		{
			this.entry = entry;
			this.Init();
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00010167 File Offset: 0x0000F167
		private void Init()
		{
			this.list = new ArrayList();
			this.longSignal = new SignalItem(SignalItemType.Long, this.entry);
			this.shortSignal = new SignalItem(SignalItemType.Short, this.entry);
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00010198 File Offset: 0x0000F198
		public void Add(RuleItem ruleItem)
		{
			this.list.Add(ruleItem);
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x000101A8 File Offset: 0x0000F1A8
		public void Execute()
		{
			foreach (object obj in this.list)
			{
				RuleItem ruleItem = (RuleItem)obj;
				ruleItem.Execute();
			}
		}

		// Token: 0x0400015E RID: 350
		private Entry entry;

		// Token: 0x0400015F RID: 351
		private ArrayList list;

		// Token: 0x04000160 RID: 352
		private SignalItem longSignal;

		// Token: 0x04000161 RID: 353
		private SignalItem shortSignal;
	}
}
