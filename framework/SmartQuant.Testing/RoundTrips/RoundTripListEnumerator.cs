using System;
using System.Collections;

namespace SmartQuant.Testing.RoundTrips
{
	// Token: 0x0200003C RID: 60
	public class RoundTripListEnumerator : IEnumerator
	{
		// Token: 0x060001DA RID: 474 RVA: 0x0000B9F4 File Offset: 0x0000A9F4
		public RoundTripListEnumerator(RoundTripList roundTripList)
		{
			this.current = -1;
			this.roundTripList = roundTripList;
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0000BA0A File Offset: 0x0000AA0A
		public void Reset()
		{
			this.current = -1;
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060001DC RID: 476 RVA: 0x0000BA13 File Offset: 0x0000AA13
		public object Current
		{
			get
			{
				return this.roundTripList[this.current];
			}
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0000BA28 File Offset: 0x0000AA28
		public bool MoveNext()
		{
			return ++this.current != this.roundTripList.Count;
		}

		// Token: 0x040000C6 RID: 198
		private int current;

		// Token: 0x040000C7 RID: 199
		private RoundTripList roundTripList;
	}
}
