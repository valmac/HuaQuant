using System;
using System.Collections.Generic;

namespace SmartQuant.Providers
{
	// Token: 0x02000052 RID: 82
	public class BrokerAccount
	{
		// Token: 0x060001E4 RID: 484 RVA: 0x00005485 File Offset: 0x00004485
		public BrokerAccount(string name)
		{
			this.name = name;
			this.fields = new SortedList<string, SortedList<string, string>>();
			this.positions = new List<BrokerPosition>();
			this.buyingPower = 0.0;
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x000054B9 File Offset: 0x000044B9
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x000054C1 File Offset: 0x000044C1
		// (set) Token: 0x060001E7 RID: 487 RVA: 0x000054C9 File Offset: 0x000044C9
		public double BuyingPower
		{
			get
			{
				return this.buyingPower;
			}
			set
			{
				this.buyingPower = value;
			}
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x000054D4 File Offset: 0x000044D4
		public void AddField(string name, string currency, string value)
		{
			SortedList<string, string> sortedList;
			if (!this.fields.TryGetValue(name, out sortedList))
			{
				sortedList = new SortedList<string, string>();
				this.fields.Add(name, sortedList);
			}
			sortedList.Add(currency, value);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0000550C File Offset: 0x0000450C
		public void AddField(string name, string value)
		{
			this.AddField(name, "", value);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0000551C File Offset: 0x0000451C
		public BrokerAccountField[] GetFields()
		{
			List<BrokerAccountField> list = new List<BrokerAccountField>();
			foreach (KeyValuePair<string, SortedList<string, string>> keyValuePair in this.fields)
			{
				string key = keyValuePair.Key;
				foreach (KeyValuePair<string, string> keyValuePair2 in keyValuePair.Value)
				{
					list.Add(new BrokerAccountField(key, keyValuePair2.Key, keyValuePair2.Value));
				}
			}
			return list.ToArray();
		}

		// Token: 0x060001EB RID: 491 RVA: 0x000055D0 File Offset: 0x000045D0
		public void AddPosition(BrokerPosition position)
		{
			this.positions.Add(position);
		}

		// Token: 0x060001EC RID: 492 RVA: 0x000055DE File Offset: 0x000045DE
		public BrokerPosition[] GetPositions()
		{
			return this.positions.ToArray();
		}

		// Token: 0x040000BA RID: 186
		private string name;

		// Token: 0x040000BB RID: 187
		private SortedList<string, SortedList<string, string>> fields;

		// Token: 0x040000BC RID: 188
		private List<BrokerPosition> positions;

		// Token: 0x040000BD RID: 189
		private double buyingPower;
	}
}
