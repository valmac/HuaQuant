using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace SmartQuant.Charting
{
	// Token: 0x02000047 RID: 71
	[Serializable]
	public partial class Canvas : Form
	{
		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x0000F1C2 File Offset: 0x0000E1C2
		public Pad Pad
		{
			get
			{
				return Chart.Pad;
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000414 RID: 1044 RVA: 0x0000F1C9 File Offset: 0x0000E1C9
		// (set) Token: 0x06000415 RID: 1045 RVA: 0x0000F1D1 File Offset: 0x0000E1D1
		public string Title
		{
			get
			{
				return this.Text;
			}
			set
			{
				this.Text = value;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000416 RID: 1046 RVA: 0x0000F1DA File Offset: 0x0000E1DA
		// (set) Token: 0x06000417 RID: 1047 RVA: 0x0000F1E1 File Offset: 0x0000E1E1
		public static bool FileEnabled
		{
			get
			{
				return Canvas.fFileEnabled;
			}
			set
			{
				Canvas.fFileEnabled = value;
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000418 RID: 1048 RVA: 0x0000F1E9 File Offset: 0x0000E1E9
		// (set) Token: 0x06000419 RID: 1049 RVA: 0x0000F1F0 File Offset: 0x0000E1F0
		public static string FileDir
		{
			get
			{
				return Canvas.fFileDir;
			}
			set
			{
				Canvas.fFileDir = value;
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x0000F1F8 File Offset: 0x0000E1F8
		// (set) Token: 0x0600041B RID: 1051 RVA: 0x0000F1FF File Offset: 0x0000E1FF
		public static string FileNamePrefix
		{
			get
			{
				return Canvas.fFileNamePrefix;
			}
			set
			{
				Canvas.fFileNamePrefix = value;
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x0600041C RID: 1052 RVA: 0x0000F207 File Offset: 0x0000E207
		// (set) Token: 0x0600041D RID: 1053 RVA: 0x0000F20E File Offset: 0x0000E20E
		public static string FileNameSuffix
		{
			get
			{
				return Canvas.fFileNameSuffix;
			}
			set
			{
				Canvas.fFileNameSuffix = value;
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x0000F216 File Offset: 0x0000E216
		// (set) Token: 0x0600041F RID: 1055 RVA: 0x0000F223 File Offset: 0x0000E223
		public bool GroupZoomEnabled
		{
			get
			{
				return this.fChart.GroupZoomEnabled;
			}
			set
			{
				this.fChart.GroupZoomEnabled = value;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000420 RID: 1056 RVA: 0x0000F231 File Offset: 0x0000E231
		// (set) Token: 0x06000421 RID: 1057 RVA: 0x0000F23E File Offset: 0x0000E23E
		public bool GroupLeftMarginEnabled
		{
			get
			{
				return this.fChart.GroupLeftMarginEnabled;
			}
			set
			{
				this.fChart.GroupLeftMarginEnabled = value;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000422 RID: 1058 RVA: 0x0000F24C File Offset: 0x0000E24C
		// (set) Token: 0x06000423 RID: 1059 RVA: 0x0000F259 File Offset: 0x0000E259
		public bool DoubleBufferingEnabled
		{
			get
			{
				return this.fChart.DoubleBufferingEnabled;
			}
			set
			{
				this.fChart.DoubleBufferingEnabled = value;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x0000F267 File Offset: 0x0000E267
		// (set) Token: 0x06000425 RID: 1061 RVA: 0x0000F274 File Offset: 0x0000E274
		public bool SmoothingEnabled
		{
			get
			{
				return this.fChart.SmoothingEnabled;
			}
			set
			{
				this.fChart.SmoothingEnabled = value;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x0000F282 File Offset: 0x0000E282
		// (set) Token: 0x06000427 RID: 1063 RVA: 0x0000F28F File Offset: 0x0000E28F
		public bool AntiAliasingEnabled
		{
			get
			{
				return this.fChart.AntiAliasingEnabled;
			}
			set
			{
				this.fChart.AntiAliasingEnabled = value;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x0000F29D File Offset: 0x0000E29D
		// (set) Token: 0x06000429 RID: 1065 RVA: 0x0000F2AA File Offset: 0x0000E2AA
		public PrintDocument PrintDocument
		{
			get
			{
				return this.fChart.PrintDocument;
			}
			set
			{
				this.fChart.PrintDocument = value;
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x0600042A RID: 1066 RVA: 0x0000F2B8 File Offset: 0x0000E2B8
		// (set) Token: 0x0600042B RID: 1067 RVA: 0x0000F2C5 File Offset: 0x0000E2C5
		public int PrintX
		{
			get
			{
				return this.fChart.PrintX;
			}
			set
			{
				this.fChart.PrintX = value;
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x0600042C RID: 1068 RVA: 0x0000F2D3 File Offset: 0x0000E2D3
		// (set) Token: 0x0600042D RID: 1069 RVA: 0x0000F2E0 File Offset: 0x0000E2E0
		public int PrintY
		{
			get
			{
				return this.fChart.PrintY;
			}
			set
			{
				this.fChart.PrintY = value;
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x0000F2EE File Offset: 0x0000E2EE
		// (set) Token: 0x0600042F RID: 1071 RVA: 0x0000F2FB File Offset: 0x0000E2FB
		public int PrintWidth
		{
			get
			{
				return this.fChart.PrintWidth;
			}
			set
			{
				this.fChart.PrintWidth = value;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000430 RID: 1072 RVA: 0x0000F309 File Offset: 0x0000E309
		// (set) Token: 0x06000431 RID: 1073 RVA: 0x0000F316 File Offset: 0x0000E316
		public int PrintHeight
		{
			get
			{
				return this.fChart.PrintHeight;
			}
			set
			{
				this.fChart.PrintHeight = value;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x0000F324 File Offset: 0x0000E324
		// (set) Token: 0x06000433 RID: 1075 RVA: 0x0000F331 File Offset: 0x0000E331
		public EPrintAlign PrintAlign
		{
			get
			{
				return this.fChart.PrintAlign;
			}
			set
			{
				this.fChart.PrintAlign = value;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000434 RID: 1076 RVA: 0x0000F33F File Offset: 0x0000E33F
		// (set) Token: 0x06000435 RID: 1077 RVA: 0x0000F34C File Offset: 0x0000E34C
		public EPrintLayout PrintLayout
		{
			get
			{
				return this.fChart.PrintLayout;
			}
			set
			{
				this.fChart.PrintLayout = value;
			}
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x0000F35A File Offset: 0x0000E35A
		private void Init()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x0000F364 File Offset: 0x0000E364
		private void PostInit()
		{
			if (Canvas.fFileEnabled)
			{
				this.fChart.FileName = string.Concat(new string[]
				{
					Canvas.fFileDir,
					"//",
					Canvas.fFileNamePrefix,
					base.Name,
					DateTime.Now.ToString("MMddyyyhhmmss"),
					Canvas.fFileNameSuffix,
					".gif"
				});
			}
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x0000F3D6 File Offset: 0x0000E3D6
		public Canvas()
		{
			this.Init();
			base.Name = "Canvas";
			this.Text = "SmartQuant Canvas";
			this.PostInit();
			CanvasManager.Add(this);
			if (!Canvas.fFileEnabled)
			{
				base.Show();
			}
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x0000F413 File Offset: 0x0000E413
		public Canvas(string Name, string Title)
		{
			this.Init();
			base.Name = Name;
			this.Text = Title;
			this.PostInit();
			CanvasManager.Add(this);
			if (!Canvas.FileEnabled)
			{
				base.Show();
			}
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x0000F448 File Offset: 0x0000E448
		public Canvas(string name)
		{
			this.Init();
			base.Name = name;
			this.Text = name;
			this.PostInit();
			CanvasManager.Add(this);
			if (!Canvas.FileEnabled)
			{
				base.Show();
			}
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x0000F47D File Offset: 0x0000E47D
		public Canvas(string Name, string Title, string FileName)
		{
			this.Init();
			base.Name = Name;
			this.Text = Title;
			this.PostInit();
			this.fChart.FileName = FileName;
			CanvasManager.Add(this);
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x0000F4B4 File Offset: 0x0000E4B4
		public Canvas(string Name, string Title, int Width, int Height)
		{
			this.Init();
			base.Name = Name;
			this.Text = Title;
			this.PostInit();
			CanvasManager.Add(this);
			base.Width = Width;
			base.Height = Height;
			if (!Canvas.FileEnabled)
			{
				base.Show();
			}
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x0000F504 File Offset: 0x0000E504
		public Canvas(string Name, int Width, int Height)
		{
			this.Init();
			base.Name = Name;
			this.Text = Name;
			this.PostInit();
			CanvasManager.Add(this);
			base.Width = Width;
			base.Height = Height;
			if (!Canvas.FileEnabled)
			{
				base.Show();
			}
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x0000F554 File Offset: 0x0000E554
		public Canvas(string Name, string Title, string FileName, int Width, int Height)
		{
			this.Init();
			base.Name = Name;
			this.Text = Title;
			this.PostInit();
			this.fChart.FileName = FileName;
			CanvasManager.Add(this);
			base.Width = Width;
			base.Height = Height;
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x0600043F RID: 1087 RVA: 0x0000F5A3 File Offset: 0x0000E5A3
		public Chart Chart
		{
			get
			{
				return this.fChart;
			}
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x0000F5AB File Offset: 0x0000E5AB
		public Pad cd(int pad)
		{
			return this.fChart.cd(pad);
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x0000F5B9 File Offset: 0x0000E5B9
		public void Clear()
		{
			this.fChart.Clear();
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x0000F5C6 File Offset: 0x0000E5C6
		public void UpdateChart()
		{
			this.fChart.UpdatePads();
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x0000F5D3 File Offset: 0x0000E5D3
		public new void Update()
		{
			base.Update();
			this.UpdateChart();
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x0000F5E1 File Offset: 0x0000E5E1
		public Pad AddPad(double x1, double y1, double x2, double y2)
		{
			return this.fChart.AddPad(x1, y1, x2, y2);
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x0000F5F3 File Offset: 0x0000E5F3
		public void Divide(int x, int y)
		{
			this.fChart.Divide(x, y);
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x0000F602 File Offset: 0x0000E602
		public void Divide(int x, int y, double[] widths, double[] heights)
		{
			this.fChart.Divide(x, y, widths, heights);
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x0000F639 File Offset: 0x0000E639
		public virtual void Print()
		{
			this.fChart.Print();
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x0000F646 File Offset: 0x0000E646
		public virtual void PrintPreview()
		{
			this.fChart.PrintPreview();
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x0000F653 File Offset: 0x0000E653
		public virtual void PrintSetup()
		{
			this.fChart.PrintSetup();
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x0000F660 File Offset: 0x0000E660
		public virtual void PrintPageSetup()
		{
			this.fChart.PrintPageSetup();
		}

		// Token: 0x040001B4 RID: 436
		private static string fFileDir = "";

		// Token: 0x040001B5 RID: 437
		private static string fFileNamePrefix = "";

		// Token: 0x040001B6 RID: 438
		private static string fFileNameSuffix = "";

		// Token: 0x040001B7 RID: 439
		private static bool fFileEnabled = false;
	}
}
