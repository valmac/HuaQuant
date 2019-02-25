using System;
using System.Collections;
using SmartQuant.Instruments;

namespace SmartQuant.Testing.RoundTrips
{
	// Token: 0x0200003B RID: 59
	public class RoundTripList : IEnumerable
	{
		// Token: 0x14000019 RID: 25
		// (add) Token: 0x060001C3 RID: 451 RVA: 0x0000B442 File Offset: 0x0000A442
		// (remove) Token: 0x060001C4 RID: 452 RVA: 0x0000B45B File Offset: 0x0000A45B
		public event RoundTripListEventHandler Updated;

		// Token: 0x060001C5 RID: 453 RVA: 0x0000B474 File Offset: 0x0000A474
		public RoundTripList(LiveTester tester)
		{
			this.tester = tester;
			this.lastNotUpdatedIndex = -1;
			this.lastOpenRoundTripDate = DateTime.MaxValue;
			this.Connect();
			this.list = new ArrayList();
			this.openRoundTrips = new OpenRoundTripList();
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0000B4B1 File Offset: 0x0000A4B1
		public IEnumerator GetEnumerator()
		{
			return new RoundTripListEnumerator(this);
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x0000B4B9 File Offset: 0x0000A4B9
		public int Count
		{
			get
			{
				return this.list.Count + this.openRoundTrips.Count;
			}
		}

		// Token: 0x17000045 RID: 69
		public RoundTrip this[int index]
		{
			get
			{
				if (index < this.list.Count)
				{
					return this.list[index] as RoundTrip;
				}
				if (index < this.Count)
				{
					return this.openRoundTrips[index - this.list.Count];
				}
				return null;
			}
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0000B524 File Offset: 0x0000A524
		public void Connect()
		{
			this.tester.RoundTripsUpdated += this.tester_RoundTripsUpdated;
			this.tester.RoundTripsFinished += this.tester_RoundTripsFinished;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0000B554 File Offset: 0x0000A554
		public void Disconnect()
		{
			this.tester.RoundTripsUpdated -= this.tester_RoundTripsUpdated;
			this.tester.RoundTripsFinished -= this.tester_RoundTripsFinished;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0000B584 File Offset: 0x0000A584
		public int GetClosedRoundTripIndex(RoundTrip roundTrip)
		{
			return this.list.IndexOf(roundTrip);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0000B592 File Offset: 0x0000A592
		public int CountOfClosedRoundTrips()
		{
			return this.list.Count;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0000B5A0 File Offset: 0x0000A5A0
		public void Clear()
		{
			this.list.Clear();
			foreach (object obj in this.openRoundTrips)
			{
				RoundTrip roundTrip = (RoundTrip)obj;
				roundTrip.Cancel();
			}
			this.openRoundTrips.Clear();
			this.lastNotUpdatedIndex = -1;
		}

		// Token: 0x060001CE RID: 462 RVA: 0x0000B618 File Offset: 0x0000A618
		public void AddOpenRoundTrip(RoundTrip openRoundTrip)
		{
			this.openRoundTrips.Add(openRoundTrip);
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0000B626 File Offset: 0x0000A626
		public bool IsRoundTripOpen(RoundTrip roundTrip)
		{
			return this.openRoundTrips.Contains(roundTrip);
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0000B634 File Offset: 0x0000A634
		public RoundTripArray GetRoundTrips(Instrument instrument)
		{
			ArrayList arrayList = new ArrayList();
			foreach (object obj in this.list)
			{
				RoundTrip roundTrip = (RoundTrip)obj;
				if (roundTrip.Instrument == instrument)
				{
					arrayList.Add(roundTrip);
				}
			}
			if (this.openRoundTrips.Contains(instrument))
			{
				arrayList.Add(this.openRoundTrips[instrument]);
			}
			return new RoundTripArray(arrayList);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0000B6C4 File Offset: 0x0000A6C4
		public RoundTripArray GetRoundTrips(InstrumentList instrumentList)
		{
			ArrayList arrayList = new ArrayList();
			foreach (object obj in this.list)
			{
				RoundTrip roundTrip = (RoundTrip)obj;
				if (instrumentList.Contains(roundTrip.Instrument))
				{
					arrayList.Add(roundTrip);
				}
			}
			foreach (object obj2 in this.openRoundTrips)
			{
				RoundTrip roundTrip2 = (RoundTrip)obj2;
				if (instrumentList.Contains(roundTrip2.Instrument))
				{
					arrayList.Add(roundTrip2);
				}
			}
			return new RoundTripArray(arrayList);
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x0000B79C File Offset: 0x0000A79C
		public void UpdateOpenRoundTrips()
		{
			foreach (object obj in this.openRoundTrips)
			{
				RoundTrip roundTrip = (RoundTrip)obj;
				roundTrip.Update();
			}
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0000B7F4 File Offset: 0x0000A7F4
		public void CloseOpenRoundTrip(Instrument instrument, double exitPrice, DateTime exitDate)
		{
			RoundTrip roundTrip = this.openRoundTrips[instrument];
			if (roundTrip != null)
			{
				this.openRoundTrips.Remove(instrument);
				roundTrip.Close(exitDate);
				this.list.Add(roundTrip);
			}
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0000B831 File Offset: 0x0000A831
		public RoundTrip GetOpenRoundTrip(Instrument instrument)
		{
			if (this.openRoundTrips.Contains(instrument))
			{
				return this.openRoundTrips[instrument];
			}
			return null;
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x0000B850 File Offset: 0x0000A850
		public RoundTripArray GetOpenRoundTrips(InstrumentList instrumentList)
		{
			ArrayList arrayList = new ArrayList();
			foreach (object obj in this.openRoundTrips)
			{
				RoundTrip roundTrip = (RoundTrip)obj;
				if (instrumentList.Contains(roundTrip.Instrument))
				{
					arrayList.Add(roundTrip);
				}
			}
			return new RoundTripArray(arrayList);
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0000B8C4 File Offset: 0x0000A8C4
		public OpenRoundTripList GetOpenRoundTrips()
		{
			return this.openRoundTrips;
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0000B8CC File Offset: 0x0000A8CC
		private void EmitUpdated(int lastNotUpdatedIndex)
		{
			if (this.Updated != null)
			{
				this.Updated(new RoundTripListEventArgs(lastNotUpdatedIndex));
			}
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0000B8E8 File Offset: 0x0000A8E8
		private void tester_RoundTripsUpdated(LiveTester sender)
		{
			if (this.list.Count > 0 || this.openRoundTrips.Count > 0)
			{
				int num = this.list.Count - 1;
				while (num >= 0 && this.lastOpenRoundTripDate <= (this.list[num] as RoundTrip).ExitDateTime)
				{
					num--;
				}
				if (this.openRoundTrips.Count > 0)
				{
					this.lastOpenRoundTripDate = this.openRoundTrips[0].ExitDateTime;
				}
				else
				{
					this.lastOpenRoundTripDate = DateTime.MaxValue;
				}
				this.lastNotUpdatedIndex = num;
			}
			else
			{
				this.lastNotUpdatedIndex = -1;
			}
			this.EmitUpdated(this.lastNotUpdatedIndex);
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x0000B99C File Offset: 0x0000A99C
		private void tester_RoundTripsFinished(LiveTester sender)
		{
			foreach (object obj in this.openRoundTrips)
			{
				RoundTrip roundTrip = (RoundTrip)obj;
				roundTrip.Cancel();
			}
		}

		// Token: 0x040000C0 RID: 192
		protected ArrayList list;

		// Token: 0x040000C1 RID: 193
		protected OpenRoundTripList openRoundTrips;

		// Token: 0x040000C2 RID: 194
		protected LiveTester tester;

		// Token: 0x040000C3 RID: 195
		protected int lastNotUpdatedIndex;

		// Token: 0x040000C4 RID: 196
		protected DateTime lastOpenRoundTripDate;
	}
}
