using System;

namespace SmartQuant
{
	// Token: 0x0200003E RID: 62
	public class PluginEventArgs : EventArgs
	{
		// Token: 0x06000133 RID: 307 RVA: 0x00005CCA File Offset: 0x00004CCA
		public PluginEventArgs(Plugin plugin)
		{
			this.plugin = plugin;
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00005CD9 File Offset: 0x00004CD9
		public Plugin Plugin
		{
			get
			{
				return this.plugin;
			}
		}

		// Token: 0x040000F1 RID: 241
		private Plugin plugin;
	}
}
