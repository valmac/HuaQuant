using System;
using System.Collections;

namespace SmartQuant.File
{
	// Token: 0x02000003 RID: 3
	internal class CacheManager
	{
		// Token: 0x06000007 RID: 7 RVA: 0x00002410 File Offset: 0x00001410
		internal CacheManager()
		{
			this.units = new Hashtable();
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002423 File Offset: 0x00001423
		internal CacheUnit GetCacheUnit(FileSeries series)
		{
			return this.GetCacheUnit(series, true);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002430 File Offset: 0x00001430
		internal CacheUnit GetCacheUnit(FileSeries series, bool createNew)
		{
			CacheUnit cacheUnit = this.units[series] as CacheUnit;
			if (cacheUnit == null && createNew)
			{
				cacheUnit = new CacheUnit();
				cacheUnit.Series = series;
				this.units.Add(series, cacheUnit);
			}
			return cacheUnit;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002470 File Offset: 0x00001470
		internal void Clear()
		{
			this.units.Clear();
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000247D File Offset: 0x0000147D
		internal void Clear(FileSeries series)
		{
			this.units.Remove(series);
		}

		// Token: 0x04000009 RID: 9
		private Hashtable units;
	}
}
