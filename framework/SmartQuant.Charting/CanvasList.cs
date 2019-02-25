using System;
using System.Collections;

namespace SmartQuant.Charting
{
	// Token: 0x02000025 RID: 37
	[Serializable]
	public class CanvasList : SortedList
	{
		// Token: 0x06000186 RID: 390 RVA: 0x00007258 File Offset: 0x00006258
		public void Add(Canvas canvas)
		{
			base.Add(canvas.Name, canvas);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00007267 File Offset: 0x00006267
		public void Remove(Canvas canvas)
		{
			base.Remove(canvas.Name);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00007278 File Offset: 0x00006278
		public void Print()
		{
			foreach (object obj in this)
			{
				Canvas canvas = (Canvas)obj;
				canvas.Print();
			}
		}

		// Token: 0x1700006A RID: 106
		public Canvas this[string name]
		{
			get
			{
				return base[name] as Canvas;
			}
		}
	}
}
