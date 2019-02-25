using System;
using System.Collections;

namespace SmartQuant.Trading
{
	// Token: 0x02000046 RID: 70
	public class RequestList : CollectionBase
	{
		// Token: 0x17000097 RID: 151
		public string this[int index]
		{
			get
			{
				return base.InnerList[index] as string;
			}
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0000BA6F File Offset: 0x0000AA6F
		public void Add(string request)
		{
			base.List.Add(request);
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0000BA7E File Offset: 0x0000AA7E
		public void Remove(string request)
		{
			if (base.List.Contains(request))
			{
				base.List.Remove(request);
			}
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x0000BA9A File Offset: 0x0000AA9A
		public bool Contains(string request)
		{
			return base.InnerList.Contains(request);
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x0000BAA8 File Offset: 0x0000AAA8
		protected override void OnInsert(int index, object value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value", "The request cannot be null.");
			}
			string text = value as string;
			if (text == null)
			{
				throw new ArgumentException("Invalid value type - " + value.GetType().ToString());
			}
			if (base.InnerList.Contains(text))
			{
				throw new ArgumentException("Duplicate request - " + text);
			}
		}
	}
}
