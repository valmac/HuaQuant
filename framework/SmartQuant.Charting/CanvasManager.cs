using System;

namespace SmartQuant.Charting
{
	// Token: 0x02000016 RID: 22
	public class CanvasManager
	{
		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x0000425D File Offset: 0x0000325D
		public static CanvasList Canvases
		{
			get
			{
				return CanvasManager.fCanvases;
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00004264 File Offset: 0x00003264
		public static void Add(Canvas canvas)
		{
			if (CanvasManager.fCanvases[canvas.Name] != null)
			{
				CanvasManager.fCanvases.Remove(canvas.Name);
			}
			CanvasManager.fCanvases.Add(canvas.Name, canvas);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00004299 File Offset: 0x00003299
		public static void Remove(Canvas canvas)
		{
			CanvasManager.fCanvases.Remove(canvas.Name);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000042AB File Offset: 0x000032AB
		public static Canvas GetCanvas(string name)
		{
			return CanvasManager.fCanvases[name];
		}

		// Token: 0x04000053 RID: 83
		private static CanvasList fCanvases = new CanvasList();
	}
}
