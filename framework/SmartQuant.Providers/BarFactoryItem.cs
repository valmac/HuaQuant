using System;
using System.ComponentModel;
using SmartQuant.Data;

namespace SmartQuant.Providers
{
	// Token: 0x02000057 RID: 87
	public class BarFactoryItem : IComparable
	{
		// Token: 0x0600020B RID: 523 RVA: 0x00005604 File Offset: 0x00004604
		public BarFactoryItem(BarType barType, long barSize, bool enabled)
		{
			this.barType = barType;
			this.barSize = barSize;
			this.enabled = enabled;
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00005621 File Offset: 0x00004621
		public BarFactoryItem() : this(BarType.Time, 60L, true)
		{
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600020D RID: 525 RVA: 0x0000562E File Offset: 0x0000462E
		// (set) Token: 0x0600020E RID: 526 RVA: 0x00005636 File Offset: 0x00004636
		[DefaultValue(BarType.Time)]
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

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600020F RID: 527 RVA: 0x0000563F File Offset: 0x0000463F
		// (set) Token: 0x06000210 RID: 528 RVA: 0x00005647 File Offset: 0x00004647
		[DefaultValue(60L)]
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

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000211 RID: 529 RVA: 0x00005650 File Offset: 0x00004650
		// (set) Token: 0x06000212 RID: 530 RVA: 0x00005658 File Offset: 0x00004658
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

		// Token: 0x06000213 RID: 531 RVA: 0x00005664 File Offset: 0x00004664
		public int CompareTo(object obj)
		{
			BarFactoryItem barFactoryItem = obj as BarFactoryItem;
			if (barFactoryItem != null)
			{
				if (this.barSize > barFactoryItem.barSize)
				{
					return 1;
				}
				if (this.barSize < barFactoryItem.barSize)
				{
					return -1;
				}
			}
			return 0;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0000569C File Offset: 0x0000469C
		public override string ToString()
		{
			return string.Format("{0}({1}) - {2}", this.barType, this.barSize, this.enabled);
		}

		// Token: 0x040000BF RID: 191
		internal const BarType DEFAULT_BAR_TYPE = BarType.Time;

		// Token: 0x040000C0 RID: 192
		internal const long DEFAULT_BAR_SIZE = 60L;

		// Token: 0x040000C1 RID: 193
		internal const bool DEFAULT_ENABLED = true;

		// Token: 0x040000C2 RID: 194
		private BarType barType;

		// Token: 0x040000C3 RID: 195
		private long barSize;

		// Token: 0x040000C4 RID: 196
		private bool enabled;
	}
}
