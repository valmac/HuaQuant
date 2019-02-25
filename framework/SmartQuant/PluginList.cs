using System;
using System.Collections;

namespace SmartQuant
{
	// Token: 0x0200003D RID: 61
	public class PluginList : ReadOnlyCollectionBase
	{
		// Token: 0x06000130 RID: 304 RVA: 0x00005CA5 File Offset: 0x00004CA5
		internal PluginList()
		{
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00005CAD File Offset: 0x00004CAD
		internal void Add(Plugin plugin)
		{
			base.InnerList.Add(plugin);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00005CBC File Offset: 0x00004CBC
		internal void Remove(Plugin plugin)
		{
			base.InnerList.Remove(plugin);
		}
	}
}
