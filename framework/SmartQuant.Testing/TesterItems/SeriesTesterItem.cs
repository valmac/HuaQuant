using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Design;
using SmartQuant.Series;
using SmartQuant.Testing.Design;

namespace SmartQuant.Testing.TesterItems
{
	// Token: 0x02000003 RID: 3
	[Editor(typeof(TesterComponentTypeEditor), typeof(UITypeEditor))]
	[TypeConverter(typeof(TesterComponentTypeConverter))]
	public class SeriesTesterItem : TesterItem
	{
		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000015 RID: 21 RVA: 0x0000229E File Offset: 0x0000129E
		// (remove) Token: 0x06000016 RID: 22 RVA: 0x000022B7 File Offset: 0x000012B7
		public event EventHandler ComponentEnabledChanged;

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000017 RID: 23 RVA: 0x000022D0 File Offset: 0x000012D0
		// (set) Token: 0x06000018 RID: 24 RVA: 0x000022D8 File Offset: 0x000012D8
		[Category("Properties")]
		[Browsable(false)]
		public virtual bool Enabled
		{
			get
			{
				return this.enabled;
			}
			set
			{
				if (this.enabled != value)
				{
					this.enabled = value;
					if (this.enabled)
					{
						if (this.parentComponent != null)
						{
							this.parentComponent.Enabled = true;
							this.parentComponent.FillSeries = true;
						}
						foreach (object obj in this.parentList)
						{
							SeriesTesterItem seriesTesterItem = (SeriesTesterItem)obj;
							seriesTesterItem.Enabled = true;
							seriesTesterItem.FillSeries = true;
						}
					}
					this.EmitComponentEnabledChanged();
					base.EmitPropertyChanged();
				}
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000019 RID: 25 RVA: 0x0000237C File Offset: 0x0000137C
		// (set) Token: 0x0600001A RID: 26 RVA: 0x00002384 File Offset: 0x00001384
		[Category("Parameters")]
		public virtual bool FillSeries
		{
			get
			{
				return this.fillSeries;
			}
			set
			{
				this.fillSeries = value;
				if (this.fillSeries)
				{
					this.isUpdating = true;
					if (this.parentComponent != null)
					{
						this.parentComponent.FillSeries = true;
					}
					this.Calculate();
					this.isUpdating = false;
				}
				base.EmitPropertyChanged();
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001B RID: 27 RVA: 0x000023C4 File Offset: 0x000013C4
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
					this.CalculateParentSeries();
					if (this.parentSeries.Count > 0)
					{
						return this.GetValue(this.parentSeries.LastDateTime);
					}
					return double.NaN;
				}
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001C RID: 28 RVA: 0x0000243E File Offset: 0x0000143E
		[Browsable(false)]
		public virtual DoubleSeries ParentSeries
		{
			get
			{
				return this.parentSeries;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00002446 File Offset: 0x00001446
		[Browsable(false)]
		public override DoubleSeries Series
		{
			get
			{
				return this.series;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600001E RID: 30 RVA: 0x0000244E File Offset: 0x0000144E
		// (set) Token: 0x0600001F RID: 31 RVA: 0x00002458 File Offset: 0x00001458
		[Category("Parent Components")]
		[Browsable(false)]
		public virtual SeriesTesterItem ParentComponent
		{
			get
			{
				return this.parentComponent;
			}
			set
			{
				SeriesTesterItem seriesTesterItem = this.parentComponent;
				if (value != seriesTesterItem)
				{
					this.parentComponent = value;
					this.parentSeries = this.parentComponent.Series;
					this.ChangeParentSeries(seriesTesterItem, value);
					base.EmitPropertyChanged();
				}
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002496 File Offset: 0x00001496
		public SeriesTesterItem()
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000024A9 File Offset: 0x000014A9
		public SeriesTesterItem(string name) : base(name)
		{
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000024BD File Offset: 0x000014BD
		public SeriesTesterItem(string name, SeriesTesterItem parentSeriesItem, string title) : base(name)
		{
			this.Init(name, parentSeriesItem, title, false);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000024DB File Offset: 0x000014DB
		public SeriesTesterItem(string name, SeriesTesterItem parentSeriesItem, string title, bool fillSeries) : base(name)
		{
			this.Init(name, parentSeriesItem, title, fillSeries);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000024FC File Offset: 0x000014FC
		protected void Init(string name, SeriesTesterItem parentSeriesItem, string title, bool fillSeries)
		{
			this.isUpdating = false;
			this.lastDateTime = DateTime.MinValue;
			this.series = new DoubleSeries();
			this.series.Name = name;
			this.series.Title = title;
			this.parentComponent = parentSeriesItem;
			this.parentSeries = parentSeriesItem.Series;
			if (this.parentSeries != null)
			{
				this.parentSeries.ItemAdded += this.parentSeries_ItemAdded;
			}
			this.FillSeries = fillSeries;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002578 File Offset: 0x00001578
		private void ChangeParentSeries(SeriesTesterItem oldComponent, SeriesTesterItem newComponent)
		{
			this.Reset();
			if (oldComponent != null)
			{
				oldComponent.Series.ItemAdded -= this.parentSeries_ItemAdded;
			}
			this.isUpdating = true;
			if (this.fillSeries)
			{
				newComponent.FillSeries = true;
			}
			this.isUpdating = false;
			newComponent.Series.ItemAdded += this.parentSeries_ItemAdded;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000025D9 File Offset: 0x000015D9
		protected virtual double GetValue(DateTime date)
		{
			return double.NaN;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000025E4 File Offset: 0x000015E4
		private void parentSeries_ItemAdded(object sender, DateTimeEventArgs e)
		{
			this.lastDateTime = e.DateTime;
			if (!this.isUpdating && this.fillSeries)
			{
				this.Calculate();
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002608 File Offset: 0x00001608
		protected virtual void CalculateSeries(int firstIndex, int lastIndex)
		{
			for (int i = firstIndex; i <= lastIndex; i++)
			{
				this.Calculate(this.parentSeries.GetDateTime(i));
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002633 File Offset: 0x00001633
		protected void CalculateParentSeries()
		{
			this.isUpdating = true;
			if (this.parentComponent != null)
			{
				this.parentComponent.Calculate();
			}
			this.isUpdating = false;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002658 File Offset: 0x00001658
		private void Calculate(DateTime date)
		{
			double value = this.GetValue(date);
			if (!double.IsNaN(value))
			{
				this.series.Add(date, value);
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002684 File Offset: 0x00001684
		public virtual void Calculate()
		{
			if (this.enabled)
			{
				this.CalculateParentSeries();
				int firstIndex = 0;
				if (this.series.Count != 0)
				{
					if (this.parentSeries.Contains(this.lastDateTime))
					{
						firstIndex = Math.Min(this.lastIndex + 1, this.parentSeries.GetIndex(this.lastDateTime));
					}
					else
					{
						firstIndex = this.lastIndex + 1;
					}
				}
				this.lastDateTime = DateTime.MinValue;
				this.lastIndex = this.parentSeries.Count - 1;
				this.CalculateSeries(firstIndex, this.lastIndex);
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002716 File Offset: 0x00001716
		public override void Reset()
		{
			base.Reset();
			if (this.series != null)
			{
				this.series.Clear();
			}
			this.lastIndex = -1;
			this.lastDateTime = DateTime.MinValue;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002743 File Offset: 0x00001743
		public override void Connect()
		{
			this.parentSeries.ItemAdded += this.parentSeries_ItemAdded;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000275C File Offset: 0x0000175C
		public override void Disconnect()
		{
			this.parentSeries.ItemAdded -= this.parentSeries_ItemAdded;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002775 File Offset: 0x00001775
		protected void EmitComponentEnabledChanged()
		{
			if (this.ComponentEnabledChanged != null)
			{
				this.ComponentEnabledChanged(this, EventArgs.Empty);
			}
		}

		// Token: 0x04000007 RID: 7
		protected SeriesTesterItem parentComponent;

		// Token: 0x04000008 RID: 8
		protected DoubleSeries parentSeries;

		// Token: 0x04000009 RID: 9
		protected DoubleSeries series;

		// Token: 0x0400000A RID: 10
		protected bool fillSeries;

		// Token: 0x0400000B RID: 11
		protected int lastIndex;

		// Token: 0x0400000C RID: 12
		protected bool isUpdating;

		// Token: 0x0400000D RID: 13
		protected bool enabled;

		// Token: 0x0400000E RID: 14
		protected ArrayList parentList = new ArrayList();

		// Token: 0x0400000F RID: 15
		protected DateTime lastDateTime;
	}
}
