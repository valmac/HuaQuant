using System;
using System.ComponentModel;
using SmartQuant.Series;
using SmartQuant.Testing.TesterItems;

namespace SmartQuant.Testing.RoundTrips
{
	// Token: 0x0200000A RID: 10
	public class RoundTripsTesterItem : SeriesTesterItem
	{
		// Token: 0x06000054 RID: 84 RVA: 0x00002DDC File Offset: 0x00001DDC
		public RoundTripsTesterItem(RoundTripList parentRoundTripList, string title) : base(title)
		{
			this.isUpdating = false;
			this.lastDateTime = DateTime.MinValue;
			this.series = new DoubleSeries();
			this.series.Name = this.name;
			this.series.Title = title;
			this.parentRoundTripList = parentRoundTripList;
			this.lastNotUpdatedIndex = -1;
			this.Connect();
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00002E3E File Offset: 0x00001E3E
		[Browsable(false)]
		public override DoubleSeries ParentSeries
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00002E41 File Offset: 0x00001E41
		// (set) Token: 0x06000057 RID: 87 RVA: 0x00002E44 File Offset: 0x00001E44
		[Browsable(false)]
		public override SeriesTesterItem ParentComponent
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00002E48 File Offset: 0x00001E48
		[Browsable(false)]
		public override double LastValue
		{
			get
			{
				if (!this.enabled)
				{
					return double.NaN;
				}
				if (this.fillSeries)
				{
					if (this.series.Count > 0)
					{
						return this.series.Last;
					}
					return double.NaN;
				}
				else
				{
					if (this.parentRoundTripList.Count > 0)
					{
						return this.GetValue(this.parentRoundTripList.Count - 1);
					}
					return double.NaN;
				}
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002EC0 File Offset: 0x00001EC0
		protected override void CalculateSeries(int firstIndex, int lastIndex)
		{
			for (int i = firstIndex; i <= lastIndex; i++)
			{
				double value = this.GetValue(i);
				if (!double.IsNaN(value))
				{
					this.series.Add(this.parentRoundTripList[i].ExitDateTime, value);
				}
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002F06 File Offset: 0x00001F06
		protected virtual double GetValue(int lastIndex)
		{
			return double.NaN;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002F11 File Offset: 0x00001F11
		public override void Connect()
		{
			this.parentRoundTripList.Updated += this.parentRoundTripList_Updated;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002F2A File Offset: 0x00001F2A
		public override void Disconnect()
		{
			this.parentRoundTripList.Updated -= this.parentRoundTripList_Updated;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002F43 File Offset: 0x00001F43
		public override void Reset()
		{
			this.lastNotUpdatedIndex = -1;
			base.Reset();
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002F52 File Offset: 0x00001F52
		private void parentRoundTripList_Updated(RoundTripListEventArgs args)
		{
			this.lastNotUpdatedIndex = args.LastNotUpdatedIndex;
			if (!this.isUpdating && this.fillSeries)
			{
				this.Calculate();
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002F78 File Offset: 0x00001F78
		public override void Calculate()
		{
			if (this.enabled)
			{
				int firstIndex;
				if (this.lastIndex == -1)
				{
					firstIndex = 0;
				}
				else
				{
					firstIndex = this.lastNotUpdatedIndex + 1;
				}
				this.lastIndex = this.parentRoundTripList.Count - 1;
				if (this.lastNotUpdatedIndex >= 0)
				{
					DateTime exitDateTime = this.parentRoundTripList[this.lastNotUpdatedIndex].ExitDateTime;
					int index = this.series.GetIndex(exitDateTime.AddTicks(1L), EIndexOption.Next);
					if (index != -1)
					{
						while (this.series.Count > index)
						{
							this.series.Remove(this.series.Count - 1);
						}
					}
				}
				else
				{
					this.series.Clear();
				}
				this.CalculateSeries(firstIndex, this.lastIndex);
			}
		}

		// Token: 0x04000015 RID: 21
		protected RoundTripList parentRoundTripList;

		// Token: 0x04000016 RID: 22
		protected int lastNotUpdatedIndex;
	}
}
