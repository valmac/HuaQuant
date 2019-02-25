using System;
using SmartQuant.Data;

namespace SmartQuant.Simulation
{
	// Token: 0x02000015 RID: 21
	public class SeriesObjectEventArgs : EventArgs
	{
		// Token: 0x0600006E RID: 110 RVA: 0x00003C3E File Offset: 0x00002C3E
		public SeriesObjectEventArgs(IDataSeries series, IDataObject obj)
		{
			this.series = series;
			this.obj = obj;
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600006F RID: 111 RVA: 0x00003C54 File Offset: 0x00002C54
		public IDataObject Object
		{
			get
			{
				return this.obj;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00003C5C File Offset: 0x00002C5C
		public IDataSeries Series
		{
			get
			{
				return this.series;
			}
		}

		// Token: 0x04000043 RID: 67
		private IDataSeries series;

		// Token: 0x04000044 RID: 68
		private IDataObject obj;
	}
}
