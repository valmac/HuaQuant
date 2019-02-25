using System;
using System.Collections;

namespace SmartQuant.File
{
	// Token: 0x02000018 RID: 24
	internal class FileSeriesEnumerator : IEnumerator
	{
		// Token: 0x060000CB RID: 203 RVA: 0x00005D96 File Offset: 0x00004D96
		internal FileSeriesEnumerator(FileSeries series)
		{
			this.series = series;
			this.index = -1;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00005DAC File Offset: 0x00004DAC
		public void Reset()
		{
			this.index = -1;
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00005DB5 File Offset: 0x00004DB5
		public object Current
		{
			get
			{
				return this.series[this.index];
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00005DC8 File Offset: 0x00004DC8
		public bool MoveNext()
		{
			return ++this.index < this.series.Count;
		}

		// Token: 0x04000064 RID: 100
		private FileSeries series;

		// Token: 0x04000065 RID: 101
		private int index;
	}
}
