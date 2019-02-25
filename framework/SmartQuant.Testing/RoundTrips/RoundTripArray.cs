using System;
using System.Collections;

namespace SmartQuant.Testing.RoundTrips
{
	// Token: 0x0200003D RID: 61
	public class RoundTripArray : ICollection, IEnumerable
	{
		// Token: 0x060001DE RID: 478 RVA: 0x0000BA56 File Offset: 0x0000AA56
		public RoundTripArray(ArrayList array)
		{
			this.array = array;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0000BA65 File Offset: 0x0000AA65
		public RoundTripArray()
		{
			this.array = new ArrayList();
		}

		// Token: 0x17000047 RID: 71
		public RoundTrip this[int index]
		{
			get
			{
				return this.array[index] as RoundTrip;
			}
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000BA8B File Offset: 0x0000AA8B
		public bool Contains(RoundTrip roundTrip)
		{
			return this.array.Contains(roundTrip);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0000BA99 File Offset: 0x0000AA99
		public void Clear()
		{
			this.array.Clear();
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0000BAA6 File Offset: 0x0000AAA6
		public void Add(RoundTrip roundTrip)
		{
			this.array.Add(roundTrip);
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x0000BAB5 File Offset: 0x0000AAB5
		public bool IsSynchronized
		{
			get
			{
				return this.array.IsSynchronized;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x0000BAC2 File Offset: 0x0000AAC2
		public int Count
		{
			get
			{
				return this.array.Count;
			}
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000BACF File Offset: 0x0000AACF
		public void CopyTo(Array array, int index)
		{
			array.CopyTo(array, index);
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x0000BAD9 File Offset: 0x0000AAD9
		public object SyncRoot
		{
			get
			{
				return this.array.SyncRoot;
			}
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0000BAE6 File Offset: 0x0000AAE6
		public IEnumerator GetEnumerator()
		{
			return this.array.GetEnumerator();
		}

		// Token: 0x040000C8 RID: 200
		protected ArrayList array;
	}
}
