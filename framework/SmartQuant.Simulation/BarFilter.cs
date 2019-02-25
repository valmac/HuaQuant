using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using SmartQuant.Data;
using SmartQuant.Simulation.Design;

namespace SmartQuant.Simulation
{
	// Token: 0x02000022 RID: 34
	[TypeConverter(typeof(BarFilterTypeConverter))]
	public class BarFilter
	{
		// Token: 0x06000121 RID: 289 RVA: 0x00006486 File Offset: 0x00005486
		public BarFilter()
		{
			this.items = new List<BarFilterItem>();
			this.enabled = false;
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000122 RID: 290 RVA: 0x000064A0 File Offset: 0x000054A0
		// (set) Token: 0x06000123 RID: 291 RVA: 0x000064A8 File Offset: 0x000054A8
		[DefaultValue(false)]
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

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000124 RID: 292 RVA: 0x000064B1 File Offset: 0x000054B1
		[Editor(typeof(BarFilterItemListEditor), typeof(UITypeEditor))]
		public List<BarFilterItem> Items
		{
			get
			{
				return this.items;
			}
		}

		// Token: 0x06000125 RID: 293 RVA: 0x000064BC File Offset: 0x000054BC
		public bool Contains(BarType barType, long barSize)
		{
			if (!this.enabled)
			{
				return true;
			}
			foreach (BarFilterItem barFilterItem in this.items)
			{
				if (barFilterItem.BarType == barType && barFilterItem.BarSize == barSize)
				{
					return barFilterItem.Enabled;
				}
			}
			return false;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00006530 File Offset: 0x00005530
		public void Reset()
		{
			this.enabled = false;
			this.items.Clear();
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00006544 File Offset: 0x00005544
		public override string ToString()
		{
			List<string> list = new List<string>();
			list.Add(this.enabled.ToString());
			foreach (BarFilterItem barFilterItem in this.items)
			{
				list.Add(string.Format("{0},{1},{2}", barFilterItem.Enabled, barFilterItem.BarType, barFilterItem.BarSize));
			}
			return string.Join("-", list.ToArray());
		}

		// Token: 0x06000128 RID: 296 RVA: 0x000065E8 File Offset: 0x000055E8
		internal void FromString(string value)
		{
			try
			{
				this.Reset();
				string[] array = value.Split(new char[]
				{
					'-'
				});
				this.enabled = bool.Parse(array[0]);
				for (int i = 1; i < array.Length; i++)
				{
					string[] array2 = array[i].Split(new char[]
					{
						','
					});
					BarFilterItem item = new BarFilterItem((BarType)Enum.Parse(typeof(BarType), array2[1]), long.Parse(array2[2]), bool.Parse(array2[0]));
					this.items.Add(item);
				}
			}
			catch (Exception ex)
			{
				if (Trace.IsLevelEnabled(TraceLevel.Error))
				{
					Trace.WriteLine(ex.ToString());
				}
				this.Reset();
			}
		}

		// Token: 0x040000A4 RID: 164
		private bool enabled;

		// Token: 0x040000A5 RID: 165
		private List<BarFilterItem> items;
	}
}
