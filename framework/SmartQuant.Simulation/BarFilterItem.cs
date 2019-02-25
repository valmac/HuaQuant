using System;
using System.ComponentModel;
using SmartQuant.Data;
using SmartQuant.Instruments;

namespace SmartQuant.Simulation
{
	// Token: 0x02000021 RID: 33
	public class BarFilterItem
	{
		// Token: 0x06000118 RID: 280 RVA: 0x000063F6 File Offset: 0x000053F6
		public BarFilterItem(BarType barType, long barSize, bool enabled)
		{
			this.barType = barType;
			this.barSize = barSize;
			this.enabled = enabled;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00006413 File Offset: 0x00005413
		public BarFilterItem() : this(DataManager.DefaultBarType, DataManager.DefaultBarSize, true)
		{
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600011A RID: 282 RVA: 0x00006426 File Offset: 0x00005426
		// (set) Token: 0x0600011B RID: 283 RVA: 0x0000642E File Offset: 0x0000542E
		[Category("Status")]
		[DefaultValue(true)]
		public bool Enabled
		{
			get
			{
				return this.enabled;
			}
			set
			{
				this.enabled = value;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00006437 File Offset: 0x00005437
		// (set) Token: 0x0600011D RID: 285 RVA: 0x0000643F File Offset: 0x0000543F
		[Category("Properties")]
		public BarType BarType
		{
			get
			{
				return this.barType;
			}
			set
			{
				this.barType = value;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600011E RID: 286 RVA: 0x00006448 File Offset: 0x00005448
		// (set) Token: 0x0600011F RID: 287 RVA: 0x00006450 File Offset: 0x00005450
		[Category("Properties")]
		public long BarSize
		{
			get
			{
				return this.barSize;
			}
			set
			{
				this.barSize = value;
			}
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00006459 File Offset: 0x00005459
		public override string ToString()
		{
			return string.Format("{0}({1}) - {2}", this.barType, this.barSize, this.enabled);
		}

		// Token: 0x0400009F RID: 159
		private const string CATEGORY_STATUS = "Status";

		// Token: 0x040000A0 RID: 160
		private const string CATEGORY_PROPERTIES = "Properties";

		// Token: 0x040000A1 RID: 161
		private bool enabled;

		// Token: 0x040000A2 RID: 162
		private BarType barType;

		// Token: 0x040000A3 RID: 163
		private long barSize;
	}
}
