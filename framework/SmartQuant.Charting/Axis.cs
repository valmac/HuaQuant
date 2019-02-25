using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SmartQuant.Charting
{
	// Token: 0x02000052 RID: 82
	[Serializable]
	public class Axis
	{
		// Token: 0x1700016F RID: 367
		// (get) Token: 0x0600048A RID: 1162 RVA: 0x00010CA0 File Offset: 0x0000FCA0
		// (set) Token: 0x0600048B RID: 1163 RVA: 0x00010CA8 File Offset: 0x0000FCA8
		public double X1
		{
			get
			{
				return this.fX1;
			}
			set
			{
				this.fX1 = value;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x0600048C RID: 1164 RVA: 0x00010CB1 File Offset: 0x0000FCB1
		// (set) Token: 0x0600048D RID: 1165 RVA: 0x00010CB9 File Offset: 0x0000FCB9
		public double Y1
		{
			get
			{
				return this.fY1;
			}
			set
			{
				this.fY1 = value;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x0600048E RID: 1166 RVA: 0x00010CC2 File Offset: 0x0000FCC2
		// (set) Token: 0x0600048F RID: 1167 RVA: 0x00010CCA File Offset: 0x0000FCCA
		public double X2
		{
			get
			{
				return this.fX2;
			}
			set
			{
				this.fX2 = value;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000490 RID: 1168 RVA: 0x00010CD3 File Offset: 0x0000FCD3
		// (set) Token: 0x06000491 RID: 1169 RVA: 0x00010CDB File Offset: 0x0000FCDB
		public double Y2
		{
			get
			{
				return this.fY2;
			}
			set
			{
				this.fY2 = value;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000492 RID: 1170 RVA: 0x00010CE4 File Offset: 0x0000FCE4
		// (set) Token: 0x06000493 RID: 1171 RVA: 0x00010CEC File Offset: 0x0000FCEC
		public Color Color
		{
			get
			{
				return this.fColor;
			}
			set
			{
				this.fColor = value;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000494 RID: 1172 RVA: 0x00010CF5 File Offset: 0x0000FCF5
		// (set) Token: 0x06000495 RID: 1173 RVA: 0x00010CFD File Offset: 0x0000FCFD
		public EAxisType Type
		{
			get
			{
				return this.fType;
			}
			set
			{
				this.fType = value;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x00010D06 File Offset: 0x0000FD06
		// (set) Token: 0x06000497 RID: 1175 RVA: 0x00010D0E File Offset: 0x0000FD0E
		public EAxisPosition Position
		{
			get
			{
				return this.fPosition;
			}
			set
			{
				this.fPosition = value;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x00010D17 File Offset: 0x0000FD17
		// (set) Token: 0x06000499 RID: 1177 RVA: 0x00010D1F File Offset: 0x0000FD1F
		public EVerticalGridStyle VerticalGridStyle
		{
			get
			{
				return this.fVerticalGridStyle;
			}
			set
			{
				this.fVerticalGridStyle = value;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x0600049A RID: 1178 RVA: 0x00010D28 File Offset: 0x0000FD28
		// (set) Token: 0x0600049B RID: 1179 RVA: 0x00010D30 File Offset: 0x0000FD30
		public bool MajorTicksEnabled
		{
			get
			{
				return this.fMajorTicksEnabled;
			}
			set
			{
				this.fMajorTicksEnabled = value;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x00010D39 File Offset: 0x0000FD39
		// (set) Token: 0x0600049D RID: 1181 RVA: 0x00010D41 File Offset: 0x0000FD41
		public Color MajorTicksColor
		{
			get
			{
				return this.fMajorTicksColor;
			}
			set
			{
				this.fMajorTicksColor = value;
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x0600049E RID: 1182 RVA: 0x00010D4A File Offset: 0x0000FD4A
		// (set) Token: 0x0600049F RID: 1183 RVA: 0x00010D52 File Offset: 0x0000FD52
		public float MajorTicksWidth
		{
			get
			{
				return this.fMajorTicksWidth;
			}
			set
			{
				this.fMajorTicksWidth = value;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060004A0 RID: 1184 RVA: 0x00010D5B File Offset: 0x0000FD5B
		// (set) Token: 0x060004A1 RID: 1185 RVA: 0x00010D63 File Offset: 0x0000FD63
		public int MajorTicksLength
		{
			get
			{
				return this.fMajorTicksLength;
			}
			set
			{
				this.fMajorTicksLength = value;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060004A2 RID: 1186 RVA: 0x00010D6C File Offset: 0x0000FD6C
		// (set) Token: 0x060004A3 RID: 1187 RVA: 0x00010D74 File Offset: 0x0000FD74
		public bool MinorTicksEnabled
		{
			get
			{
				return this.fMinorTicksEnabled;
			}
			set
			{
				this.fMinorTicksEnabled = value;
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060004A4 RID: 1188 RVA: 0x00010D7D File Offset: 0x0000FD7D
		// (set) Token: 0x060004A5 RID: 1189 RVA: 0x00010D85 File Offset: 0x0000FD85
		public Color MinorTicksColor
		{
			get
			{
				return this.fMinorTicksColor;
			}
			set
			{
				this.fMinorTicksColor = value;
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060004A6 RID: 1190 RVA: 0x00010D8E File Offset: 0x0000FD8E
		// (set) Token: 0x060004A7 RID: 1191 RVA: 0x00010D96 File Offset: 0x0000FD96
		public float MinorTicksWidth
		{
			get
			{
				return this.fMinorTicksWidth;
			}
			set
			{
				this.fMinorTicksWidth = value;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060004A8 RID: 1192 RVA: 0x00010D9F File Offset: 0x0000FD9F
		// (set) Token: 0x060004A9 RID: 1193 RVA: 0x00010DA7 File Offset: 0x0000FDA7
		public int MinorTicksLength
		{
			get
			{
				return this.fMinorTicksLength;
			}
			set
			{
				this.fMinorTicksLength = value;
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060004AA RID: 1194 RVA: 0x00010DB0 File Offset: 0x0000FDB0
		// (set) Token: 0x060004AB RID: 1195 RVA: 0x00010DB8 File Offset: 0x0000FDB8
		public EAxisTitlePosition TitlePosition
		{
			get
			{
				return this.fTitlePosition;
			}
			set
			{
				this.fTitlePosition = value;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x00010DC1 File Offset: 0x0000FDC1
		// (set) Token: 0x060004AD RID: 1197 RVA: 0x00010DC9 File Offset: 0x0000FDC9
		public Font TitleFont
		{
			get
			{
				return this.fTitleFont;
			}
			set
			{
				this.fTitleFont = value;
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x00010DD2 File Offset: 0x0000FDD2
		// (set) Token: 0x060004AF RID: 1199 RVA: 0x00010DDA File Offset: 0x0000FDDA
		public Color TitleColor
		{
			get
			{
				return this.fTitleColor;
			}
			set
			{
				this.fTitleColor = value;
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x00010DE3 File Offset: 0x0000FDE3
		// (set) Token: 0x060004B1 RID: 1201 RVA: 0x00010DEB File Offset: 0x0000FDEB
		public int TitleOffset
		{
			get
			{
				return this.fTitleOffset;
			}
			set
			{
				this.fTitleOffset = value;
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060004B2 RID: 1202 RVA: 0x00010DF4 File Offset: 0x0000FDF4
		// (set) Token: 0x060004B3 RID: 1203 RVA: 0x00010DFC File Offset: 0x0000FDFC
		public double Min
		{
			get
			{
				return this.fMin;
			}
			set
			{
				this.fMin = value;
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060004B4 RID: 1204 RVA: 0x00010E05 File Offset: 0x0000FE05
		// (set) Token: 0x060004B5 RID: 1205 RVA: 0x00010E0D File Offset: 0x0000FE0D
		public double Max
		{
			get
			{
				return this.fMax;
			}
			set
			{
				this.fMax = value;
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060004B6 RID: 1206 RVA: 0x00010E16 File Offset: 0x0000FE16
		// (set) Token: 0x060004B7 RID: 1207 RVA: 0x00010E1E File Offset: 0x0000FE1E
		public bool Enabled
		{
			get
			{
				return this.fEnabled;
			}
			set
			{
				this.fEnabled = value;
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060004B8 RID: 1208 RVA: 0x00010E27 File Offset: 0x0000FE27
		// (set) Token: 0x060004B9 RID: 1209 RVA: 0x00010E2F File Offset: 0x0000FE2F
		public bool Zoomed
		{
			get
			{
				return this.fZoomed;
			}
			set
			{
				this.fZoomed = value;
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060004BA RID: 1210 RVA: 0x00010E38 File Offset: 0x0000FE38
		// (set) Token: 0x060004BB RID: 1211 RVA: 0x00010E40 File Offset: 0x0000FE40
		public bool GridEnabled
		{
			get
			{
				return this.fGridEnabled;
			}
			set
			{
				this.fGridEnabled = value;
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060004BC RID: 1212 RVA: 0x00010E49 File Offset: 0x0000FE49
		// (set) Token: 0x060004BD RID: 1213 RVA: 0x00010E51 File Offset: 0x0000FE51
		public Color GridColor
		{
			get
			{
				return this.fGridColor;
			}
			set
			{
				this.fGridColor = value;
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060004BE RID: 1214 RVA: 0x00010E5A File Offset: 0x0000FE5A
		// (set) Token: 0x060004BF RID: 1215 RVA: 0x00010E62 File Offset: 0x0000FE62
		public float GridWidth
		{
			get
			{
				return this.fGridWidth;
			}
			set
			{
				this.fGridWidth = value;
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060004C0 RID: 1216 RVA: 0x00010E6B File Offset: 0x0000FE6B
		// (set) Token: 0x060004C1 RID: 1217 RVA: 0x00010E73 File Offset: 0x0000FE73
		public DashStyle GridDashStyle
		{
			get
			{
				return this.fGridDashStyle;
			}
			set
			{
				this.fGridDashStyle = value;
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060004C2 RID: 1218 RVA: 0x00010E7C File Offset: 0x0000FE7C
		// (set) Token: 0x060004C3 RID: 1219 RVA: 0x00010E84 File Offset: 0x0000FE84
		public bool MinorGridEnabled
		{
			get
			{
				return this.fMinorGridEnabled;
			}
			set
			{
				this.fMinorGridEnabled = value;
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060004C4 RID: 1220 RVA: 0x00010E8D File Offset: 0x0000FE8D
		// (set) Token: 0x060004C5 RID: 1221 RVA: 0x00010E95 File Offset: 0x0000FE95
		public Color MinorGridColor
		{
			get
			{
				return this.fMinorGridColor;
			}
			set
			{
				this.fMinorGridColor = value;
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060004C6 RID: 1222 RVA: 0x00010E9E File Offset: 0x0000FE9E
		// (set) Token: 0x060004C7 RID: 1223 RVA: 0x00010EA6 File Offset: 0x0000FEA6
		public float MinorGridWidth
		{
			get
			{
				return this.fMinorGridWidth;
			}
			set
			{
				this.fMinorGridWidth = value;
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060004C8 RID: 1224 RVA: 0x00010EAF File Offset: 0x0000FEAF
		// (set) Token: 0x060004C9 RID: 1225 RVA: 0x00010EB7 File Offset: 0x0000FEB7
		public DashStyle MinorGridDashStyle
		{
			get
			{
				return this.fMinorGridDashStyle;
			}
			set
			{
				this.fMinorGridDashStyle = value;
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060004CA RID: 1226 RVA: 0x00010EC0 File Offset: 0x0000FEC0
		// (set) Token: 0x060004CB RID: 1227 RVA: 0x00010EC8 File Offset: 0x0000FEC8
		public bool TitleEnabled
		{
			get
			{
				return this.fTitleEnabled;
			}
			set
			{
				this.fTitleEnabled = value;
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060004CC RID: 1228 RVA: 0x00010ED1 File Offset: 0x0000FED1
		// (set) Token: 0x060004CD RID: 1229 RVA: 0x00010ED9 File Offset: 0x0000FED9
		public bool LabelEnabled
		{
			get
			{
				return this.fLabelEnabled;
			}
			set
			{
				this.fLabelEnabled = value;
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060004CE RID: 1230 RVA: 0x00010EE2 File Offset: 0x0000FEE2
		// (set) Token: 0x060004CF RID: 1231 RVA: 0x00010EEA File Offset: 0x0000FEEA
		public Font LabelFont
		{
			get
			{
				return this.fLabelFont;
			}
			set
			{
				this.fLabelFont = value;
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060004D0 RID: 1232 RVA: 0x00010EF3 File Offset: 0x0000FEF3
		// (set) Token: 0x060004D1 RID: 1233 RVA: 0x00010EFB File Offset: 0x0000FEFB
		public Color LabelColor
		{
			get
			{
				return this.fLabelColor;
			}
			set
			{
				this.fLabelColor = value;
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060004D2 RID: 1234 RVA: 0x00010F04 File Offset: 0x0000FF04
		// (set) Token: 0x060004D3 RID: 1235 RVA: 0x00010F0C File Offset: 0x0000FF0C
		public int LabelOffset
		{
			get
			{
				return this.fLabelOffset;
			}
			set
			{
				this.fLabelOffset = value;
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060004D4 RID: 1236 RVA: 0x00010F15 File Offset: 0x0000FF15
		// (set) Token: 0x060004D5 RID: 1237 RVA: 0x00010F1D File Offset: 0x0000FF1D
		public string LabelFormat
		{
			get
			{
				return this.fLabelFormat;
			}
			set
			{
				this.fLabelFormat = value;
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060004D6 RID: 1238 RVA: 0x00010F26 File Offset: 0x0000FF26
		// (set) Token: 0x060004D7 RID: 1239 RVA: 0x00010F2E File Offset: 0x0000FF2E
		public EAxisLabelAlignment LabelAlignment
		{
			get
			{
				return this.fLabelAlignment;
			}
			set
			{
				this.fLabelAlignment = value;
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060004D8 RID: 1240 RVA: 0x00010F38 File Offset: 0x0000FF38
		// (set) Token: 0x060004D9 RID: 1241 RVA: 0x00011041 File Offset: 0x00010041
		public int Width
		{
			get
			{
				if (!this.fEnabled)
				{
					return 0;
				}
				if (this.fWidth != -1)
				{
					return this.fWidth;
				}
				int num = 0;
				int num2 = 0;
				this.fLastValidAxisWidth = 0;
				if (this.fTitleEnabled)
				{
					num = (int)((float)this.fTitleOffset + this.fPad.Graphics.MeasureString(this.fMax.ToString("F1"), this.fTitleFont).Height);
				}
				if (this.fLabelEnabled)
				{
					if (this.fLabelFormat == null)
					{
						num2 = (int)((float)this.fLabelOffset + this.fPad.Graphics.MeasureString(this.fMax.ToString("F1"), this.fLabelFont).Width);
					}
					else
					{
						num2 = (int)((float)this.fLabelOffset + this.fPad.Graphics.MeasureString(this.fMax.ToString(this.fLabelFormat), this.fLabelFont).Width);
					}
				}
				this.fLastValidAxisWidth = num2 + num + 2;
				return num2 + num + 2;
			}
			set
			{
				this.fWidth = value;
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060004DA RID: 1242 RVA: 0x0001104A File Offset: 0x0001004A
		// (set) Token: 0x060004DB RID: 1243 RVA: 0x00011052 File Offset: 0x00010052
		public int LastValidAxisWidth
		{
			get
			{
				return this.fLastValidAxisWidth;
			}
			set
			{
				this.fLastValidAxisWidth = value;
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060004DC RID: 1244 RVA: 0x0001105C File Offset: 0x0001005C
		// (set) Token: 0x060004DD RID: 1245 RVA: 0x000110F7 File Offset: 0x000100F7
		public int Height
		{
			get
			{
				if (!this.fEnabled)
				{
					return 0;
				}
				if (this.fHeight != -1)
				{
					return this.fHeight;
				}
				int num = 0;
				int num2 = 0;
				if (this.fTitleEnabled)
				{
					num = (int)((float)this.fTitleOffset + this.fPad.Graphics.MeasureString("Example", this.fTitleFont).Height);
				}
				if (this.fLabelEnabled)
				{
					num2 = (int)((float)this.fLabelOffset + this.fPad.Graphics.MeasureString("Example", this.fLabelFont).Height);
				}
				return num2 + num;
			}
			set
			{
				this.fHeight = value;
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060004DE RID: 1246 RVA: 0x00011100 File Offset: 0x00010100
		// (set) Token: 0x060004DF RID: 1247 RVA: 0x00011108 File Offset: 0x00010108
		public string Title
		{
			get
			{
				return this.fTitle;
			}
			set
			{
				this.fTitle = value;
			}
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00011114 File Offset: 0x00010114
		private void Init()
		{
			this.fEnabled = true;
			this.fZoomed = false;
			this.fColor = Color.Black;
			this.fTitle = "";
			this.fTitleEnabled = true;
			this.fTitlePosition = EAxisTitlePosition.Centre;
			this.fTitleFont = new Font("Arial", 8f);
			this.fTitleColor = Color.Black;
			this.fTitleOffset = 2;
			this.fLabelEnabled = true;
			this.fLabelFont = new Font("Arial", 8f);
			this.fLabelColor = Color.Black;
			this.fLabelFormat = null;
			this.fLabelOffset = 2;
			this.fLabelAlignment = EAxisLabelAlignment.Centre;
			this.fGridEnabled = true;
			this.fGridColor = Color.Gray;
			this.fGridDashStyle = DashStyle.Solid;
			this.fGridWidth = 0.5f;
			this.fMinorGridEnabled = false;
			this.fMinorGridColor = Color.Gray;
			this.fMinorGridDashStyle = DashStyle.Solid;
			this.fMinorGridWidth = 0.5f;
			this.fMajorTicksEnabled = true;
			this.fMajorTicksColor = Color.Black;
			this.fMajorTicksWidth = 0.5f;
			this.fMajorTicksLength = 4;
			this.fMinorTicksEnabled = true;
			this.fMinorTicksColor = Color.Black;
			this.fMinorTicksWidth = 0.5f;
			this.fMinorTicksLength = 1;
			this.fType = EAxisType.Numeric;
			this.fVerticalGridStyle = EVerticalGridStyle.ByDateTime;
			this.fMouseDown = false;
			this.fMouseDownX = 0;
			this.fMouseDownY = 0;
			this.fOutlineEnabled = false;
			this.fOutline1 = 0;
			this.fOutline2 = 0;
			this.fWidth = -1;
			this.fHeight = -1;
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x0001128C File Offset: 0x0001028C
		public Axis(Pad Pad)
		{
			this.fPad = Pad;
			this.fPosition = EAxisPosition.None;
			this.fX1 = 0.0;
			this.fX2 = 0.0;
			this.fY1 = 0.0;
			this.fY2 = 0.0;
			this.Init();
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x000112F0 File Offset: 0x000102F0
		public Axis(Pad Pad, EAxisPosition Position)
		{
			this.fPad = Pad;
			this.fPosition = Position;
			this.fX1 = 0.0;
			this.fX2 = 0.0;
			this.fY1 = 0.0;
			this.fY2 = 0.0;
			this.Init();
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00011353 File Offset: 0x00010353
		public Axis(Pad Pad, double X1, double Y1, double X2, double Y2)
		{
			this.fPad = Pad;
			this.fPosition = EAxisPosition.None;
			this.fX1 = X1;
			this.fX2 = X2;
			this.fY1 = Y1;
			this.fY2 = Y2;
			this.Init();
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x0001138D File Offset: 0x0001038D
		public void SetLocation(double X1, double Y1, double X2, double Y2)
		{
			this.fX1 = X1;
			this.fX2 = X2;
			this.fY1 = Y1;
			this.fY2 = Y2;
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x000113AC File Offset: 0x000103AC
		public void SetRange(double Min, double Max)
		{
			this.fMin = Min;
			this.fMax = Max;
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x000113BC File Offset: 0x000103BC
		public void Zoom(double Min, double Max)
		{
			this.fMin = Min;
			this.fMax = Max;
			this.fZoomed = true;
			this.fPad.EmitZoom(true);
			if (!this.fPad.Chart.GroupZoomEnabled)
			{
				this.fPad.Update();
			}
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x000113FC File Offset: 0x000103FC
		public void Zoom(DateTime Min, DateTime Max)
		{
			this.Zoom((double)Min.Ticks, (double)Max.Ticks);
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00011414 File Offset: 0x00010414
		public void Zoom(string Min, string Max)
		{
			this.Zoom(DateTime.Parse(Min), DateTime.Parse(Max));
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00011428 File Offset: 0x00010428
		public void UnZoom()
		{
			EAxisPosition eaxisPosition = this.fPosition;
			if (eaxisPosition != EAxisPosition.Left)
			{
				if (eaxisPosition == EAxisPosition.Bottom)
				{
					this.SetRange(this.fPad.XMin, this.fPad.XMax);
				}
			}
			else
			{
				this.SetRange(this.fPad.YMin, this.fPad.YMax);
			}
			this.fZoomed = false;
			this.fPad.EmitZoom(false);
			if (!this.fPad.Chart.GroupZoomEnabled)
			{
				this.fPad.Update();
			}
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x000114B0 File Offset: 0x000104B0
		public static long GetNextMajor(long PrevMajor, EGridSize GridSize)
		{
			if (GridSize <= EGridSize.year1)
			{
				if (GridSize <= EGridSize.month3)
				{
					if (GridSize == EGridSize.month1)
					{
						return new DateTime(PrevMajor).AddMonths(1).Ticks;
					}
					if (GridSize == EGridSize.month2)
					{
						return new DateTime(PrevMajor).AddMonths(2).Ticks;
					}
					if (GridSize == EGridSize.month3)
					{
						return new DateTime(PrevMajor).AddMonths(3).Ticks;
					}
				}
				else
				{
					if (GridSize == EGridSize.month4)
					{
						return new DateTime(PrevMajor).AddMonths(4).Ticks;
					}
					if (GridSize == EGridSize.month6)
					{
						return new DateTime(PrevMajor).AddMonths(6).Ticks;
					}
					if (GridSize == EGridSize.year1)
					{
						return new DateTime(PrevMajor).AddYears(1).Ticks;
					}
				}
			}
			else if (GridSize <= EGridSize.year4)
			{
				if (GridSize == EGridSize.year2)
				{
					return new DateTime(PrevMajor).AddYears(2).Ticks;
				}
				if (GridSize == EGridSize.year3)
				{
					return new DateTime(PrevMajor).AddYears(3).Ticks;
				}
				if (GridSize == EGridSize.year4)
				{
					return new DateTime(PrevMajor).AddYears(4).Ticks;
				}
			}
			else
			{
				if (GridSize == EGridSize.year5)
				{
					return new DateTime(PrevMajor).AddYears(5).Ticks;
				}
				if (GridSize == EGridSize.year10)
				{
					return new DateTime(PrevMajor).AddYears(10).Ticks;
				}
				if (GridSize == EGridSize.year20)
				{
					return new DateTime(PrevMajor).AddYears(20).Ticks;
				}
			}
			return (long)(PrevMajor + GridSize);
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x00011718 File Offset: 0x00010718
		public static EGridSize CalculateSize(double ticks)
		{
			int num = 10;
			int num2 = 3;
			double num3 = Math.Floor(ticks / 600000000.0);
			if (num3 >= (double)num2 && num3 <= (double)num)
			{
				return EGridSize.min1;
			}
			num3 /= 2.0;
			if (num3 >= (double)num2 && num3 <= (double)num)
			{
				return EGridSize.min2;
			}
			num3 /= 2.5;
            if (num3 >= (double)num2 && num3 <= (double)num)
            {
                return unchecked((EGridSize)((ulong)-1294967296));
            }
			num3 /= 2.0;
			if (num3 >= (double)num2 && num3 <= (double)num)
			{
				return EGridSize.min10;
			}
			num3 /= 1.5;
			if (num3 >= (double)num2 && num3 <= (double)num)
			{
				return EGridSize.min15;
			}
			num3 /= 1.3333333333333333;
			if (num3 >= (double)num2 && num3 <= (double)num)
			{
				return EGridSize.min20;
			}
			num3 /= 1.5;
			if (num3 >= (double)num2 && num3 <= (double)num)
			{
				return EGridSize.min30;
			}
			num3 /= 2.0;
			if (num3 >= (double)num2 && num3 <= (double)num)
			{
				return EGridSize.hour1;
			}
			num3 /= 2.0;
			if (num3 >= (double)num2 && num3 <= (double)num)
			{
				return EGridSize.hour2;
			}
			num3 /= 1.5;
			if (num3 >= (double)num2 && num3 <= (double)num)
			{
				return EGridSize.hour3;
			}
			num3 /= 1.3333333333333333;
			if (num3 >= (double)num2 && num3 <= (double)num)
			{
				return EGridSize.hour4;
			}
			num3 /= 1.5;
			if (num3 >= (double)num2 && num3 <= (double)num)
			{
				return EGridSize.hour6;
			}
			num3 /= 2.0;
			if (num3 >= (double)num2 && num3 <= (double)num)
			{
				return EGridSize.hour12;
			}
			num3 /= 2.0;
			if (num3 >= (double)num2 && num3 <= (double)num)
			{
				return EGridSize.day1;
			}
			num3 /= 2.0;
			if (num3 >= (double)num2 && num3 <= (double)num)
			{
				return EGridSize.day2;
			}
			num3 /= 1.5;
			if (num3 >= (double)num2 && num3 <= (double)num)
			{
				return EGridSize.day3;
			}
			num3 /= 1.6666666666666667;
			if (num3 >= (double)num2 && num3 <= (double)num)
			{
				return EGridSize.day5;
			}
			num3 /= 1.4;
			if (num3 >= (double)num2 && num3 <= (double)num)
			{
				return EGridSize.week1;
			}
			num3 /= 2.0;
			if (num3 >= (double)num2 && num3 <= (double)num)
			{
				return EGridSize.week2;
			}
			num3 /= 2.1428571428571428;
			if (num3 >= (double)num2 && num3 <= (double)num)
			{
				return EGridSize.month1;
			}
			num3 /= 2.0;
			if (num3 >= (double)num2 && num3 <= (double)num)
			{
				return EGridSize.month2;
			}
			num3 /= 1.5;
			if (num3 >= (double)num2 && num3 <= (double)num)
			{
				return EGridSize.month3;
			}
			num3 /= 1.3333333333333333;
			if (num3 >= (double)num2 && num3 <= (double)num)
			{
				return EGridSize.month4;
			}
			num3 /= 1.5;
			if (num3 >= (double)num2 && num3 <= (double)num)
			{
				return EGridSize.month6;
			}
			num3 /= 2.0;
			if (num3 >= (double)num2 && num3 <= (double)num)
			{
				return EGridSize.year1;
			}
			num3 /= 2.0;
			if (num3 >= (double)num2 && num3 <= (double)num)
			{
				return EGridSize.year2;
			}
			num3 /= 1.5;
			if (num3 >= (double)num2 && num3 <= (double)num)
			{
				return EGridSize.year3;
			}
			num3 /= 1.3333333333333333;
			if (num3 >= (double)num2 && num3 <= (double)num)
			{
				return EGridSize.year4;
			}
			num3 /= 0.8;
			if (num3 >= (double)num2 && num3 <= (double)num)
			{
				return EGridSize.year5;
			}
			num3 /= 2.0;
			if (num3 >= (double)num2 && num3 <= (double)num)
			{
				return EGridSize.year10;
			}
			num3 /= 2.0;
			if (num3 >= (double)num2 && num3 <= (double)num)
			{
				return EGridSize.year20;
			}
			return EGridSize.year20;
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x00011B10 File Offset: 0x00010B10
		public void PaintWithDates()
		{
			if (this.fEnabled)
			{
				this.fPad.DrawLine(new Pen(this.fColor), this.fX1, this.fY1, this.fX2, this.fY2, false);
				SolidBrush brush = new SolidBrush(this.fTitleColor);
				SolidBrush brush2 = new SolidBrush(this.fLabelColor);
				Pen pen = new Pen(this.fTitleColor);
				Pen pen2 = new Pen(this.fGridColor);
				Pen pen3 = new Pen(this.fMinorGridColor);
				Pen pen4 = new Pen(this.fMinorTicksColor);
				Pen pen5 = new Pen(this.fMajorTicksColor);
				pen2.Width = this.fGridWidth;
				pen2.DashStyle = this.fGridDashStyle;
				pen3.Width = this.fMinorGridWidth;
				pen3.DashStyle = this.fMinorGridDashStyle;
				DateTime dateTime = default(DateTime);
				double num = this.fMin;
				double num2 = this.fMax;
				dateTime = new DateTime(Math.Max(0L, (long)num));
				new DateTime((long)num2);
				EGridSize egridSize = EGridSize.min1;
				this.fPad.GetFirstGridDivision(ref egridSize, ref num, ref num2, ref dateTime);
				double num3 = 5.0;
				EGridSize egridSize2 = egridSize;
				double num4;
				if (egridSize2 <= EGridSize.day2)
				{
					if (egridSize2 <= EGridSize.min30)
					{

                        if (egridSize2 <= unchecked((EGridSize)(ulong)-1294967296))
						{
							if (egridSize2 == EGridSize.min1)
							{
								num4 = (double)new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, 0).AddMinutes(1.0).Ticks;
								goto IL_D4B;
							}
							if (egridSize2 == EGridSize.min2)
							{
								num4 = (double)new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, 0).AddMinutes((double)(1 + (1 - (int)new TimeSpan(dateTime.Ticks).TotalMinutes % 2))).Ticks;
								goto IL_D4B;
							}
							if (egridSize2 == unchecked((EGridSize)((ulong)-1294967296)))
							{
								num4 = (double)new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, 0).AddMinutes((double)(1 + (4 - (int)new TimeSpan(dateTime.Ticks).TotalMinutes % 5))).Ticks;
								goto IL_D4B;
							}
						}
						else if (egridSize2 <= EGridSize.min15)
						{
							if (egridSize2 == EGridSize.min10)
							{
								num4 = (double)new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, 0).AddMinutes((double)(1 + (9 - (int)new TimeSpan(dateTime.Ticks).TotalMinutes % 10))).Ticks;
								goto IL_D4B;
							}
							if (egridSize2 == EGridSize.min15)
							{
								num4 = (double)new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, 0).AddMinutes((double)(1 + (14 - (int)new TimeSpan(dateTime.Ticks).TotalMinutes % 15))).Ticks;
								goto IL_D4B;
							}
						}
						else
						{
							if (egridSize2 == EGridSize.min20)
							{
								num4 = (double)new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, 0).AddMinutes((double)(1 + (19 - (int)new TimeSpan(dateTime.Ticks).TotalMinutes % 20))).Ticks;
								goto IL_D4B;
							}
							if (egridSize2 == EGridSize.min30)
							{
								num4 = (double)new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, 0).AddMinutes((double)(1 + (29 - (int)new TimeSpan(dateTime.Ticks).TotalMinutes % 30))).Ticks;
								goto IL_D4B;
							}
						}
					}
					else if (egridSize2 <= EGridSize.hour4)
					{
						if (egridSize2 <= EGridSize.hour2)
						{
							if (egridSize2 == EGridSize.hour1)
							{
								num4 = (double)new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, 0, 0).AddHours(1.0).Ticks;
								goto IL_D4B;
							}
							if (egridSize2 == EGridSize.hour2)
							{
								num4 = (double)new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, 0, 0).AddHours((double)(1 + (1 - (int)new TimeSpan(dateTime.Ticks).TotalHours % 2))).Ticks;
								goto IL_D4B;
							}
						}
						else
						{
							if (egridSize2 == EGridSize.hour3)
							{
								num4 = (double)new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, 0, 0).AddHours((double)(1 + (2 - (int)new TimeSpan(dateTime.Ticks).TotalHours % 3))).Ticks;
								goto IL_D4B;
							}
							if (egridSize2 == EGridSize.hour4)
							{
								num4 = (double)new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, 0, 0).AddHours((double)(1 + (3 - (int)new TimeSpan(dateTime.Ticks).TotalHours % 4))).Ticks;
								goto IL_D4B;
							}
						}
					}
					else if (egridSize2 <= EGridSize.hour12)
					{
						if (egridSize2 == EGridSize.hour6)
						{
							num4 = (double)new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, 0, 0).AddHours((double)(1 + (5 - (int)new TimeSpan(dateTime.Ticks).TotalHours % 6))).Ticks;
							goto IL_D4B;
						}
						if (egridSize2 == EGridSize.hour12)
						{
							num4 = (double)new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, 0, 0).AddHours((double)(1 + (11 - (int)new TimeSpan(dateTime.Ticks).TotalHours % 12))).Ticks;
							goto IL_D4B;
						}
					}
					else
					{
						if (egridSize2 == EGridSize.day1)
						{
							num4 = (double)new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays(1.0).Ticks;
							goto IL_D4B;
						}
						if (egridSize2 == EGridSize.day2)
						{
							num4 = (double)new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays((double)(1 + (int)new TimeSpan(dateTime.Ticks).TotalDays % 2)).Ticks;
							goto IL_D4B;
						}
					}
				}
				else if (egridSize2 <= EGridSize.month4)
				{
					if (egridSize2 <= EGridSize.week2)
					{
						if (egridSize2 <= EGridSize.day5)
						{
							if (egridSize2 == EGridSize.day3)
							{
								num4 = (double)new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays((double)(1 + (2 - (int)new TimeSpan(dateTime.Ticks).TotalDays % 3))).Ticks;
								goto IL_D4B;
							}
							if (egridSize2 == EGridSize.day5)
							{
								num4 = (double)new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays((double)(1 + (4 - (int)new TimeSpan(dateTime.Ticks).TotalDays % 5))).Ticks;
								goto IL_D4B;
							}
						}
						else
						{
							if (egridSize2 == EGridSize.week1)
							{
								num4 = (double)new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays(8.0 - (double)dateTime.DayOfWeek).Ticks;
								goto IL_D4B;
							}
							if (egridSize2 == EGridSize.week2)
							{
								num4 = (double)new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays(8.0 - (double)dateTime.DayOfWeek + (double)(7 * (1 - (int)Math.Floor(new TimeSpan(dateTime.AddDays(8.0 - (double)dateTime.DayOfWeek).Ticks).TotalDays) / 7 % 2))).Ticks;
								goto IL_D4B;
							}
						}
					}
					else if (egridSize2 <= EGridSize.month2)
					{
						if (egridSize2 == EGridSize.month1)
						{
							num4 = (double)new DateTime(dateTime.Year, dateTime.Month, 1).AddMonths(1).Ticks;
							goto IL_D4B;
						}
						if (egridSize2 == EGridSize.month2)
						{
							num4 = (double)new DateTime(dateTime.Year, dateTime.Month, 1).AddMonths(1 + dateTime.Month % 2).Ticks;
							goto IL_D4B;
						}
					}
					else
					{
						if (egridSize2 == EGridSize.month3)
						{
							num4 = (double)new DateTime(dateTime.Year, dateTime.Month, 1).AddMonths(1 + (12 - dateTime.Month) % 3).Ticks;
							goto IL_D4B;
						}
						if (egridSize2 == EGridSize.month4)
						{
							num4 = (double)new DateTime(dateTime.Year, dateTime.Month, 1).AddMonths(1 + (12 - dateTime.Month) % 4).Ticks;
							goto IL_D4B;
						}
					}
				}
				else if (egridSize2 <= EGridSize.year3)
				{
					if (egridSize2 <= EGridSize.year1)
					{
						if (egridSize2 == EGridSize.month6)
						{
							num4 = (double)new DateTime(dateTime.Year, dateTime.Month, 1).AddMonths(1 + (12 - dateTime.Month) % 6).Ticks;
							goto IL_D4B;
						}
						if (egridSize2 == EGridSize.year1)
						{
							num4 = (double)new DateTime(dateTime.Year, 1, 1).AddYears(1).Ticks;
							goto IL_D4B;
						}
					}
					else
					{
						if (egridSize2 == EGridSize.year2)
						{
							num4 = (double)new DateTime(dateTime.Year, 1, 1).AddYears(1 + (1 - dateTime.Year % 2)).Ticks;
							goto IL_D4B;
						}
						if (egridSize2 == EGridSize.year3)
						{
							num4 = (double)new DateTime(dateTime.Year, 1, 1).AddYears(1 + (2 - dateTime.Year % 3)).Ticks;
							goto IL_D4B;
						}
					}
				}
				else if (egridSize2 <= EGridSize.year5)
				{
					if (egridSize2 == EGridSize.year4)
					{
						num4 = (double)new DateTime(dateTime.Year, 1, 1).AddYears(1 + (3 - dateTime.Year % 4)).Ticks;
						goto IL_D4B;
					}
					if (egridSize2 == EGridSize.year5)
					{
						num4 = (double)new DateTime(dateTime.Year, 1, 1).AddYears(1 + (4 - dateTime.Year % 5)).Ticks;
						goto IL_D4B;
					}
				}
				else
				{
					if (egridSize2 == EGridSize.year10)
					{
						num4 = (double)new DateTime(dateTime.Year, 1, 1).AddYears(1 + (9 - dateTime.Year % 10)).Ticks;
						goto IL_D4B;
					}
					if (egridSize2 == EGridSize.year20)
					{
						num4 = (double)new DateTime(dateTime.Year, 1, 1).AddYears(1 + (19 - dateTime.Year % 20)).Ticks;
						goto IL_D4B;
					}
				}
				num4 = (double)(dateTime.Ticks + egridSize);
				IL_D4B:
				int num5 = 0;
				int num6 = 0;
				double num7 = 0.0;
				double num8 = 0.0;
				double num9 = 0.0;
				string text = "";
				int num10 = 0;
				double num11 = num2;
				dateTime = new DateTime((long)num4);
				new DateTime((long)num11);
				while (num7 < num11)
				{
					num7 = this.fPad.GetNextGridDivision(num4, num8, num10, egridSize);
					if (num7 < num11)
					{
						EAxisType eaxisType = this.fType;
						if (eaxisType == EAxisType.DateTime)
						{
							if (this.fLabelFormat == null)
							{
								text = new DateTime((long)num7).ToString("MMM yyyy");
							}
							else
							{
								string format;
								if ((long)num7 % 864000000000L == this.fPad.SessionStart.Ticks || (long)num7 % 864000000000L == this.fPad.SessionEnd.Ticks)
								{
									if (num8 == 0.0)
									{
										format = "yyy MMM dd";
									}
									else
									{
										DateTime dateTime2 = new DateTime((long)num8);
										DateTime dateTime3 = new DateTime((long)num7);
										if (dateTime2.Year != dateTime3.Year)
										{
											format = "yyyy MMM dd";
										}
										else
										{
											format = "MMM dd";
										}
									}
								}
								else if (num8 == 0.0)
								{
									format = "yyy MMM dd HH:mm";
								}
								else
								{
									DateTime dateTime4 = new DateTime((long)num8);
									DateTime dateTime5 = new DateTime((long)num7);
									if (dateTime4.Year != dateTime5.Year)
									{
										format = "yyy MMM dd HH:mm";
									}
									else if (dateTime4.Month != dateTime5.Month)
									{
										format = "MMM dd HH:mm";
									}
									else if (dateTime4.Day != dateTime5.Day)
									{
										format = "MMM dd HH:mm";
									}
									else if (dateTime4.Minute == dateTime5.Minute && dateTime4.Hour == dateTime5.Hour)
									{
										format = "HH:mm:ss";
									}
									else
									{
										format = "HH:mm";
									}
								}
								text = new DateTime((long)num7).ToString(format);
								brush2 = new SolidBrush(Color.Black);
							}
						}
						if (this.fPosition == EAxisPosition.Bottom)
						{
							if (this.fGridEnabled)
							{
								this.fPad.DrawVerticalGrid(pen2, num7);
							}
							if (this.fMajorTicksEnabled)
							{
								this.fPad.DrawVerticalTick(pen, num7, this.fY2, -5);
							}
							if (this.fLabelEnabled)
							{
								SizeF sizeF = this.fPad.Graphics.MeasureString(text, this.fLabelFont);
								int num12 = (int)sizeF.Width;
								int num13 = (int)sizeF.Height;
								if (this.fLabelAlignment == EAxisLabelAlignment.Right)
								{
									this.fPad.Graphics.DrawString(text, this.fLabelFont, brush2, (float)this.fPad.ClientX(num7), (float)((int)(this.fY2 + (double)this.fLabelOffset)));
								}
								if (this.fLabelAlignment == EAxisLabelAlignment.Left)
								{
									this.fPad.Graphics.DrawString(text, this.fLabelFont, brush2, (float)(this.fPad.ClientX(num7) - num12), (float)((int)(this.fY2 + (double)this.fLabelOffset)));
								}
								if (this.fLabelAlignment == EAxisLabelAlignment.Centre)
								{
									int num14 = this.fPad.ClientX(num7) - num12 / 2;
									int num15 = (int)(this.fY2 + (double)this.fLabelOffset);
									bool flag = num10 == 0 || num14 - num5 >= 1;
									if (flag)
									{
										this.fPad.Graphics.DrawString(text, this.fLabelFont, brush2, (float)num14, (float)num15);
										num5 = num14 + num12;
									}
								}
							}
						}
						if (this.fPosition == EAxisPosition.Left || this.fPosition == EAxisPosition.Right)
						{
							if (this.fGridEnabled)
							{
								this.fPad.DrawHorizontalGrid(pen2, num7);
							}
							if (this.fMajorTicksEnabled)
							{
								this.fPad.DrawHorizontalTick(pen5, this.fX1, num7, 5);
							}
							if (this.fLabelEnabled)
							{
								SizeF sizeF2 = this.fPad.Graphics.MeasureString(text, this.fLabelFont);
								int num12 = (int)(sizeF2.Width + (float)this.fLabelOffset);
								int num13 = (int)sizeF2.Height;
								if (this.fLabelAlignment == EAxisLabelAlignment.Centre)
								{
									int num14 = (int)(this.fX1 - (double)num12);
									int num15 = this.fPad.ClientY(num7) - num13 / 2;
									bool flag = num10 == 0 || num6 - (num15 + num13) >= 1;
									if (flag)
									{
										this.fPad.Graphics.DrawString(text, this.fLabelFont, brush2, (float)num14, (float)num15);
										num6 = num15;
									}
								}
							}
						}
					}
					if (num10 != 0)
					{
						if (num10 == 1)
						{
							num9 = (num7 - num8 - this.fPad.Transformation.CalculateNotInSessionTicks(num8, num7)) / num3;
						}
						int num16 = 1;
						while ((double)num16 <= num3)
						{
							double num17 = num8 + this.fPad.Transformation.CalculateRealQuantityOfTicks_Right(num8, num8 + (double)num16 * num9);
							if (num17 < num2)
							{
								if (this.fPosition == EAxisPosition.Bottom)
								{
									if (this.fMinorGridEnabled)
									{
										this.fPad.DrawVerticalGrid(pen3, num17);
									}
									if (this.fMinorTicksEnabled)
									{
										this.fPad.DrawVerticalTick(pen4, num17, this.fY2, -2);
									}
								}
								if (this.fPosition == EAxisPosition.Left)
								{
									if (this.fMinorGridEnabled)
									{
										this.fPad.DrawHorizontalGrid(pen3, num17);
									}
									if (this.fMinorTicksEnabled)
									{
										this.fPad.DrawHorizontalTick(pen5, this.fX1, num17, 2);
									}
									if (this.fPosition == EAxisPosition.Right)
									{
										if (this.fMinorGridEnabled)
										{
											this.fPad.DrawHorizontalGrid(pen3, num17);
										}
										if (this.fMinorTicksEnabled)
										{
											this.fPad.DrawHorizontalTick(pen4, this.fX2 - 2.0, num17, 2);
										}
									}
								}
							}
							num16++;
						}
					}
					else
					{
						num4 = num7;
					}
					num8 = num7;
					num10++;
				}
				int num18 = 0;
				while ((double)num18 <= num3)
				{
					double num17 = num4 + this.fPad.Transformation.CalculateRealQuantityOfTicks_Left(num4, num4 - (double)num18 * num9);
					if (num17 > this.fMin)
					{
						if (this.fPosition == EAxisPosition.Bottom)
						{
							if (this.fMinorGridEnabled)
							{
								this.fPad.DrawVerticalGrid(pen3, num17);
							}
							if (this.fMinorTicksEnabled)
							{
								this.fPad.DrawVerticalTick(pen4, num17, this.fY2, -2);
							}
						}
						if (this.fPosition == EAxisPosition.Left)
						{
							if (this.fMinorGridEnabled)
							{
								this.fPad.DrawHorizontalGrid(pen3, num17);
							}
							if (this.fMinorTicksEnabled)
							{
								this.fPad.DrawHorizontalTick(pen4, this.fX1, num17, 2);
							}
						}
					}
					num18++;
				}
				if (this.fPad.SessionGridEnabled && ((TIntradayTransformation)this.fPad.Transformation).Session >= (long)2L * (long)egridSize)
				{
					int num19 = 0;
					double num20 = (double)(((long)this.fMin / 864000000000L + 1L) * 864000000000L);
					double num17;
					while ((num17 = num20 + this.fPad.Transformation.CalculateRealQuantityOfTicks_Right(num20, num20 + (double)((long)num19 * ((TIntradayTransformation)this.fPad.Transformation).Session))) < num2)
					{
						this.fPad.DrawVerticalGrid(new Pen(this.fPad.SessionGridColor), num17);
						num19++;
					}
				}
				if (this.fOutlineEnabled)
				{
					if (this.fPosition == EAxisPosition.Bottom)
					{
						this.fPad.DrawVerticalGrid(new Pen(Color.Green), this.fPad.WorldX(this.fOutline1));
						this.fPad.DrawVerticalGrid(new Pen(Color.Green), this.fPad.WorldX(this.fOutline2));
					}
					if (this.fPosition == EAxisPosition.Left)
					{
						this.fPad.DrawHorizontalGrid(new Pen(Color.Green), this.fPad.WorldY(this.fOutline1));
						this.fPad.DrawHorizontalGrid(new Pen(Color.Green), this.fPad.WorldY(this.fOutline2));
					}
				}
				if (this.fTitleEnabled)
				{
					int num13 = (int)this.fPad.Graphics.MeasureString("Example", this.fLabelFont).Height;
					int num12 = (int)this.fPad.Graphics.MeasureString(this.fMax.ToString("F1"), this.fLabelFont).Width;
					int num21 = (int)this.fPad.Graphics.MeasureString(this.fTitle, this.fTitleFont).Height;
					int num22 = (int)this.fPad.Graphics.MeasureString(this.fTitle, this.fTitleFont).Width;
					if (this.fPosition == EAxisPosition.Bottom)
					{
						if (this.fTitlePosition == EAxisTitlePosition.Left)
						{
							this.fPad.Graphics.DrawString(this.fTitle, this.fTitleFont, brush, (float)((int)this.fX1), (float)((int)(this.fY2 + (double)this.fLabelOffset + (double)num13 + (double)this.fTitleOffset)));
						}
						if (this.fTitlePosition == EAxisTitlePosition.Right)
						{
							this.fPad.Graphics.DrawString(this.fTitle, this.fTitleFont, brush, (float)((int)this.fX2 - num22), (float)((int)(this.fY2 + (double)this.fLabelOffset + (double)num13 + (double)this.fTitleOffset)));
						}
						if (this.fTitlePosition == EAxisTitlePosition.Centre)
						{
							this.fPad.Graphics.DrawString(this.fTitle, this.fTitleFont, brush, (float)((int)(this.fX1 + (this.fX2 - this.fX1 - (double)num22) / 2.0)), (float)((int)(this.fY2 + (double)this.fLabelOffset + (double)num13 + (double)this.fTitleOffset)));
						}
					}
					if (this.fPosition == EAxisPosition.Left && this.fTitlePosition == EAxisTitlePosition.Centre)
					{
						StringFormat stringFormat = new StringFormat();
						stringFormat.FormatFlags = (StringFormatFlags.DirectionRightToLeft | StringFormatFlags.DirectionVertical);
						stringFormat.FormatFlags = StringFormatFlags.DirectionVertical;
						this.fPad.Graphics.DrawString(this.fTitle, this.fTitleFont, brush, (float)((int)(this.fX1 - (double)this.fLabelOffset - (double)num12 - (double)this.fTitleOffset - (double)num21)), (float)((int)(this.fY1 + (this.fY2 - this.fY1 - (double)num22) / 2.0)), stringFormat);
						this.fPad.Graphics.ResetTransform();
					}
				}
			}
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x000132A4 File Offset: 0x000122A4
		public virtual void Paint()
		{
			try
			{
				if (this.fEnabled)
				{
					if (this.fVerticalGridStyle == EVerticalGridStyle.ByDateTime && this.fType == EAxisType.DateTime && this.fMax > 100000.0)
					{
						this.PaintWithDates();
					}
					else
					{
						bool flag = false;
						string text = "";
						if (this.fMax <= 1000000.0 && this.fType == EAxisType.DateTime)
						{
							this.fType = EAxisType.Numeric;
							flag = true;
							text = this.fLabelFormat;
							this.fLabelFormat = "F1";
						}
						SolidBrush brush = new SolidBrush(this.fTitleColor);
						SolidBrush brush2 = new SolidBrush(this.fLabelColor);
						new Pen(this.fTitleColor);
						Pen pen = new Pen(this.fGridColor);
						Pen pen2 = new Pen(this.fMinorGridColor);
						Pen pen3 = new Pen(this.fMinorTicksColor);
						Pen pen4 = new Pen(this.fMajorTicksColor);
						pen.DashStyle = this.fGridDashStyle;
						pen2.DashStyle = this.fMinorGridDashStyle;
						this.fPad.DrawLine(new Pen(this.fColor), this.fX1, this.fY1, this.fX2, this.fY2, false);
						int num = 10;
						int num2 = 5;
						double num3 = Axis.Ceiling125(Math.Abs(this.fMax - this.fMin) * 0.999999 / (double)num);
						double num4 = Axis.Ceiling125(num3 / (double)num2);
						double num5 = Math.Ceiling((this.fMin - 0.001 * num3) / num3) * num3;
						double num6 = Math.Floor((this.fMax + 0.001 * num3) / num3) * num3;
						int num7 = 0;
						int num8 = 0;
						if (num3 != 0.0)
						{
							num7 = Math.Min(10000, (int)Math.Floor((num6 - num5) / num3 + 0.5) + 1);
						}
						if (num3 != 0.0)
						{
							num8 = Math.Abs((int)Math.Floor(num3 / num4 + 0.5)) - 1;
						}
						int num9 = 0;
						int num10 = 0;
						int num11 = 0;
						string text2 = "";
						for (int i = 0; i < num7; i++)
						{
							double num12 = num5 + (double)i * num3;
							switch (this.fType)
							{
							case EAxisType.Numeric:
								if (this.fLabelFormat == null)
								{
									text2 = num12.ToString("F1");
								}
								else
								{
									text2 = num12.ToString(this.fLabelFormat);
								}
								break;
							case EAxisType.DateTime:
								if (this.fLabelFormat == null)
								{
									text2 = new DateTime((long)num12).ToString("MMM yyyy");
								}
								else
								{
									text2 = new DateTime((long)num12).ToString(this.fLabelFormat);
								}
								break;
							}
							if (this.fPosition == EAxisPosition.Bottom)
							{
								if (this.fGridEnabled)
								{
									this.fPad.DrawVerticalGrid(pen, num12);
								}
								if (this.fMajorTicksEnabled)
								{
									this.fPad.DrawVerticalTick(pen4, num12, this.fY2 - 1.0, -this.fMajorTicksLength);
								}
								if (this.fLabelEnabled)
								{
									SizeF sizeF = this.fPad.Graphics.MeasureString(text2, this.fLabelFont);
									int num13 = (int)sizeF.Width;
									int num14 = (int)sizeF.Height;
									if (this.fLabelAlignment == EAxisLabelAlignment.Right)
									{
										this.fPad.Graphics.DrawString(text2, this.fLabelFont, brush2, (float)this.fPad.ClientX(num12), (float)((int)(this.fY2 + (double)this.fLabelOffset)));
									}
									if (this.fLabelAlignment == EAxisLabelAlignment.Left)
									{
										this.fPad.Graphics.DrawString(text2, this.fLabelFont, brush2, (float)(this.fPad.ClientX(num12) - num13), (float)((int)(this.fY2 + (double)this.fLabelOffset)));
									}
									if (this.fLabelAlignment == EAxisLabelAlignment.Centre)
									{
										num9 = this.fPad.ClientX(num12) - num13 / 2;
										int num15 = (int)(this.fY2 + (double)this.fLabelOffset);
										bool flag2 = i == 0 || num9 - num10 >= 1;
										if (flag2)
										{
											this.fPad.Graphics.DrawString(text2, this.fLabelFont, brush2, (float)num9, (float)num15);
											num10 = num9 + num13;
										}
									}
								}
							}
							if (this.fPosition == EAxisPosition.Left || this.fPosition == EAxisPosition.Right)
							{
								if (this.fPosition == EAxisPosition.Left && this.fGridEnabled)
								{
									this.fPad.DrawHorizontalGrid(pen, num12);
								}
								if (this.fPosition == EAxisPosition.Right && (!this.fPad.AxisLeft.Enabled || !this.fPad.AxisLeft.GridEnabled) && this.fGridEnabled)
								{
									this.fPad.DrawHorizontalGrid(pen, num12);
								}
								if (this.fMajorTicksEnabled)
								{
									switch (this.fPosition)
									{
									case EAxisPosition.Left:
										this.fPad.DrawHorizontalTick(pen4, this.fX1 + 1.0, num12, this.fMajorTicksLength);
										break;
									case EAxisPosition.Right:
										this.fPad.DrawHorizontalTick(pen4, this.fX1 - (double)this.fMajorTicksLength - 1.0, num12, this.fMajorTicksLength);
										break;
									}
								}
								if (this.fLabelEnabled)
								{
									SizeF sizeF2 = this.fPad.Graphics.MeasureString(text2, this.fLabelFont);
									int num13 = (int)(sizeF2.Width + (float)this.fLabelOffset);
									int num14 = (int)sizeF2.Height;
									if (this.fLabelAlignment == EAxisLabelAlignment.Centre)
									{
										switch (this.fPosition)
										{
										case EAxisPosition.Left:
											num9 = (int)(this.fX1 - (double)num13);
											break;
										case EAxisPosition.Right:
											num9 = (int)(this.fX1 + 2.0);
											break;
										}
										int num15 = this.fPad.ClientY(num12) - num14 / 2;
										bool flag2 = i == 0 || num11 - (num15 + num14) >= 1;
										if (flag2)
										{
											if ((double)num15 > this.fY1 && (double)(num15 + num14) < this.fY2)
											{
												this.fPad.Graphics.DrawString(text2, this.fLabelFont, brush2, (float)num9, (float)num15);
											}
											num11 = num15;
										}
									}
								}
							}
							for (int j = 1; j <= num8; j++)
							{
								double num16 = num5 + (double)i * num3 + (double)j * num4;
								if (num16 < this.fMax)
								{
									if (this.fPosition == EAxisPosition.Bottom)
									{
										if (this.fMinorGridEnabled)
										{
											this.fPad.DrawVerticalGrid(pen2, num16);
										}
										if (this.fMinorTicksEnabled)
										{
											this.fPad.DrawVerticalTick(pen3, num16, this.fY2 - 1.0, -this.fMinorTicksLength);
										}
									}
									if (this.fPosition == EAxisPosition.Left || this.fPosition == EAxisPosition.Right)
									{
										if (this.fPosition == EAxisPosition.Left && this.fMinorGridEnabled)
										{
											this.fPad.DrawHorizontalGrid(pen, num16);
										}
										if (this.fPosition == EAxisPosition.Right && (!this.fPad.AxisLeft.Enabled || !this.fPad.AxisLeft.MinorGridEnabled) && this.fMinorGridEnabled)
										{
											this.fPad.DrawHorizontalGrid(pen, num16);
										}
										if (this.fMinorTicksEnabled)
										{
											switch (this.fPosition)
											{
											case EAxisPosition.Left:
												this.fPad.DrawHorizontalTick(pen3, this.fX1 + 1.0, num16, this.fMinorTicksLength);
												break;
											case EAxisPosition.Right:
												this.fPad.DrawHorizontalTick(pen3, this.fX1 - (double)this.fMinorTicksLength - 1.0, num16, this.fMinorTicksLength);
												break;
											}
										}
									}
								}
							}
						}
						for (int k = 1; k <= num8; k++)
						{
							double num16 = num5 - (double)k * num4;
							if (num16 > this.fMin)
							{
								if (this.fPosition == EAxisPosition.Bottom)
								{
									if (this.fMinorGridEnabled)
									{
										this.fPad.DrawVerticalGrid(pen2, num16);
									}
									if (this.fMinorTicksEnabled)
									{
										this.fPad.DrawVerticalTick(pen3, num16, this.fY2 - 1.0, -this.fMinorTicksLength);
									}
								}
								if (this.fPosition == EAxisPosition.Left || this.fPosition == EAxisPosition.Right)
								{
									if (this.fPosition == EAxisPosition.Left && this.fMinorGridEnabled)
									{
										this.fPad.DrawHorizontalGrid(pen, num16);
									}
									if (this.fPosition == EAxisPosition.Right && (!this.fPad.AxisLeft.Enabled || !this.fPad.AxisLeft.MinorGridEnabled) && this.fMinorGridEnabled)
									{
										this.fPad.DrawHorizontalGrid(pen, num16);
									}
									if (this.fMinorTicksEnabled)
									{
										switch (this.fPosition)
										{
										case EAxisPosition.Left:
											this.fPad.DrawHorizontalTick(pen3, this.fX1 + 1.0, num16, this.fMinorTicksLength);
											break;
										case EAxisPosition.Right:
											this.fPad.DrawHorizontalTick(pen3, this.fX1 - (double)this.fMinorTicksLength - 1.0, num16, this.fMinorTicksLength);
											break;
										}
									}
								}
							}
						}
						if (this.fOutlineEnabled)
						{
							if (this.fPosition == EAxisPosition.Bottom)
							{
								this.fPad.DrawVerticalGrid(new Pen(Color.Green), this.fPad.WorldX(this.fOutline1));
								this.fPad.DrawVerticalGrid(new Pen(Color.Green), this.fPad.WorldX(this.fOutline2));
							}
							if (this.fPosition == EAxisPosition.Left)
							{
								this.fPad.DrawHorizontalGrid(new Pen(Color.Green), this.fPad.WorldY(this.fOutline1));
								this.fPad.DrawHorizontalGrid(new Pen(Color.Green), this.fPad.WorldY(this.fOutline2));
							}
						}
						if (this.fTitleEnabled)
						{
							int num14 = (int)this.fPad.Graphics.MeasureString("Example", this.fLabelFont).Height;
							int num13 = (int)this.fPad.Graphics.MeasureString(this.fMax.ToString("F1"), this.fLabelFont).Width;
							int num17 = (int)this.fPad.Graphics.MeasureString(this.fTitle, this.fTitleFont).Height;
							int num18 = (int)this.fPad.Graphics.MeasureString(this.fTitle, this.fTitleFont).Width;
							if (this.fPosition == EAxisPosition.Bottom)
							{
								if (this.fTitlePosition == EAxisTitlePosition.Left)
								{
									this.fPad.Graphics.DrawString(this.fTitle, this.fTitleFont, brush, (float)((int)this.fX1), (float)((int)(this.fY2 + (double)this.fLabelOffset + (double)num14 + (double)this.fTitleOffset)));
								}
								if (this.fTitlePosition == EAxisTitlePosition.Right)
								{
									this.fPad.Graphics.DrawString(this.fTitle, this.fTitleFont, brush, (float)((int)this.fX2 - num18), (float)((int)(this.fY2 + (double)this.fLabelOffset + (double)num14 + (double)this.fTitleOffset)));
								}
								if (this.fTitlePosition == EAxisTitlePosition.Centre)
								{
									this.fPad.Graphics.DrawString(this.fTitle, this.fTitleFont, brush, (float)((int)(this.fX1 + (this.fX2 - this.fX1 - (double)num18) / 2.0)), (float)((int)(this.fY2 + (double)this.fLabelOffset + (double)num14 + (double)this.fTitleOffset)));
								}
							}
							if (this.fPosition == EAxisPosition.Left && this.fTitlePosition == EAxisTitlePosition.Centre)
							{
								StringFormat stringFormat = new StringFormat();
								stringFormat.FormatFlags = (StringFormatFlags.DirectionRightToLeft | StringFormatFlags.DirectionVertical);
								stringFormat.FormatFlags = StringFormatFlags.DirectionVertical;
								this.fPad.Graphics.DrawString(this.fTitle, this.fTitleFont, brush, (float)((int)(this.fX1 - (double)this.fLabelOffset - (double)num13 - (double)this.fTitleOffset - (double)num17)), (float)((int)(this.fY1 + (this.fY2 - this.fY1 - (double)num18) / 2.0)), stringFormat);
								this.fPad.Graphics.ResetTransform();
							}
						}
						if (flag)
						{
							this.fType = EAxisType.DateTime;
							this.fLabelFormat = text;
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x00013EDC File Offset: 0x00012EDC
		public virtual void MouseMove(MouseEventArgs Event)
		{
			if (this.fMouseDown)
			{
				EAxisPosition eaxisPosition = this.fPosition;
				if (eaxisPosition != EAxisPosition.Left)
				{
					if (eaxisPosition != EAxisPosition.Bottom)
					{
						return;
					}
					if (this.fPad.MouseZoomXAxisEnabled)
					{
						this.fOutline2 = Event.X;
						this.fPad.Update();
					}
				}
				else if (this.fPad.MouseZoomYAxisEnabled)
				{
					this.fOutline2 = Event.Y;
					this.fPad.Update();
					return;
				}
			}
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00013F4C File Offset: 0x00012F4C
		public virtual void MouseDown(MouseEventArgs Event)
		{
			if (Event.Button == MouseButtons.Left)
			{
				EAxisPosition eaxisPosition = this.fPosition;
				if (eaxisPosition != EAxisPosition.Left)
				{
					if (eaxisPosition != EAxisPosition.Bottom)
					{
						return;
					}
					if (this.fPad.MouseZoomXAxisEnabled && this.fX1 <= (double)Event.X && this.fX2 >= (double)Event.X && this.fY1 <= (double)Event.Y && this.fY1 + 10.0 >= (double)Event.Y)
					{
						this.fMouseDown = true;
						this.fMouseDownX = Event.X;
						this.fMouseDownY = Event.Y;
						this.fOutline1 = Event.X;
						this.fOutlineEnabled = true;
					}
				}
				else if (this.fPad.MouseZoomYAxisEnabled && this.fX1 - 10.0 <= (double)Event.X && this.fX1 >= (double)Event.X && this.fY1 <= (double)Event.Y && this.fY2 >= (double)Event.Y)
				{
					this.fMouseDown = true;
					this.fMouseDownX = Event.X;
					this.fMouseDownY = Event.Y;
					this.fOutline1 = Event.Y;
					this.fOutlineEnabled = true;
					return;
				}
			}
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x00014098 File Offset: 0x00013098
		public virtual void MouseUp(MouseEventArgs Event)
		{
			this.fOutlineEnabled = false;
			if (Event.Button == MouseButtons.Right)
			{
				EAxisPosition eaxisPosition = this.fPosition;
				if (eaxisPosition != EAxisPosition.Left)
				{
					if (eaxisPosition == EAxisPosition.Bottom)
					{
						if (this.fX1 <= (double)Event.X && this.fX2 >= (double)Event.X && this.fY1 <= (double)Event.Y && this.fY1 + 10.0 >= (double)Event.Y)
						{
							this.UnZoom();
						}
					}
				}
				else if (this.fX1 - 10.0 <= (double)Event.X && this.fX1 >= (double)Event.X && this.fY1 <= (double)Event.Y && this.fY2 >= (double)Event.Y)
				{
					this.UnZoom();
				}
			}
			if (this.fMouseDown && Event.Button == MouseButtons.Left)
			{
				EAxisPosition eaxisPosition2 = this.fPosition;
				if (eaxisPosition2 != EAxisPosition.Left)
				{
					if (eaxisPosition2 == EAxisPosition.Bottom)
					{
						if (this.fPad.MouseZoomXAxisEnabled)
						{
							double num = this.fPad.WorldX(this.fMouseDownX);
							double num2 = this.fPad.WorldX(Event.X);
							if (num < num2)
							{
								this.Zoom(num, num2);
							}
							else
							{
								this.Zoom(num2, num);
							}
						}
					}
				}
				else if (this.fPad.MouseZoomYAxisEnabled)
				{
					double num3 = this.fPad.WorldY(this.fMouseDownY);
					double num4 = this.fPad.WorldY(Event.Y);
					if (num3 < num4)
					{
						this.Zoom(num3, num4);
					}
					else
					{
						this.Zoom(num4, num3);
					}
				}
			}
			this.fMouseDown = false;
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x0001423C File Offset: 0x0001323C
		private static double Ceiling125(double X)
		{
			double num = (X > 0.0) ? 1.0 : -1.0;
			if (X == 0.0)
			{
				return 0.0;
			}
			double num2 = Math.Log10(Math.Abs(X));
			double num3 = Math.Floor(num2);
			double num4 = Math.Pow(10.0, num2 - num3);
			if (num4 <= 1.0)
			{
				num4 = 1.0;
			}
			else if (num4 <= 2.0)
			{
				num4 = 2.0;
			}
			else if (num4 <= 5.0)
			{
				num4 = 5.0;
			}
			else
			{
				num4 = 10.0;
			}
			double num5 = num4 * Math.Pow(10.0, num3);
			return num * num5;
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x00014310 File Offset: 0x00013310
		private static double Floor125(double X)
		{
			double num = (X > 0.0) ? 1.0 : -1.0;
			if (X == 0.0)
			{
				return 0.0;
			}
			double num2 = Math.Log10(Math.Abs(X));
			double num3 = Math.Floor(num2);
			double num4 = Math.Pow(10.0, num2 - num3);
			if (num4 >= 10.0)
			{
				num4 = 10.0;
			}
			else if (num4 >= 5.0)
			{
				num4 = 5.0;
			}
			else if (num4 >= 2.0)
			{
				num4 = 2.0;
			}
			else
			{
				num4 = 1.0;
			}
			double num5 = num4 * Math.Pow(10.0, num3);
			return num * num5;
		}

		// Token: 0x04000210 RID: 528
		private Pad fPad;

		// Token: 0x04000211 RID: 529
		private EAxisType fType;

		// Token: 0x04000212 RID: 530
		private EAxisPosition fPosition;

		// Token: 0x04000213 RID: 531
		private EAxisTitlePosition fTitlePosition;

		// Token: 0x04000214 RID: 532
		private EVerticalGridStyle fVerticalGridStyle;

		// Token: 0x04000215 RID: 533
		private bool fEnabled;

		// Token: 0x04000216 RID: 534
		private bool fZoomed;

		// Token: 0x04000217 RID: 535
		private Color fColor;

		// Token: 0x04000218 RID: 536
		private bool fTitleEnabled;

		// Token: 0x04000219 RID: 537
		private string fTitle;

		// Token: 0x0400021A RID: 538
		private Font fTitleFont;

		// Token: 0x0400021B RID: 539
		private Color fTitleColor;

		// Token: 0x0400021C RID: 540
		private int fTitleOffset;

		// Token: 0x0400021D RID: 541
		private bool fLabelEnabled;

		// Token: 0x0400021E RID: 542
		private Font fLabelFont;

		// Token: 0x0400021F RID: 543
		private Color fLabelColor;

		// Token: 0x04000220 RID: 544
		private int fLabelOffset;

		// Token: 0x04000221 RID: 545
		private string fLabelFormat;

		// Token: 0x04000222 RID: 546
		private EAxisLabelAlignment fLabelAlignment;

		// Token: 0x04000223 RID: 547
		private bool fGridEnabled;

		// Token: 0x04000224 RID: 548
		private Color fGridColor;

		// Token: 0x04000225 RID: 549
		private float fGridWidth;

		// Token: 0x04000226 RID: 550
		private DashStyle fGridDashStyle;

		// Token: 0x04000227 RID: 551
		private bool fMinorGridEnabled;

		// Token: 0x04000228 RID: 552
		private Color fMinorGridColor;

		// Token: 0x04000229 RID: 553
		private float fMinorGridWidth;

		// Token: 0x0400022A RID: 554
		private DashStyle fMinorGridDashStyle;

		// Token: 0x0400022B RID: 555
		private bool fMajorTicksEnabled;

		// Token: 0x0400022C RID: 556
		private Color fMajorTicksColor;

		// Token: 0x0400022D RID: 557
		private float fMajorTicksWidth;

		// Token: 0x0400022E RID: 558
		private int fMajorTicksLength;

		// Token: 0x0400022F RID: 559
		private bool fMinorTicksEnabled;

		// Token: 0x04000230 RID: 560
		private Color fMinorTicksColor;

		// Token: 0x04000231 RID: 561
		private float fMinorTicksWidth;

		// Token: 0x04000232 RID: 562
		private int fMinorTicksLength;

		// Token: 0x04000233 RID: 563
		private double fX1;

		// Token: 0x04000234 RID: 564
		private double fX2;

		// Token: 0x04000235 RID: 565
		private double fY1;

		// Token: 0x04000236 RID: 566
		private double fY2;

		// Token: 0x04000237 RID: 567
		private double fMin;

		// Token: 0x04000238 RID: 568
		private double fMax;

		// Token: 0x04000239 RID: 569
		private bool fMouseDown;

		// Token: 0x0400023A RID: 570
		private int fMouseDownX;

		// Token: 0x0400023B RID: 571
		private int fMouseDownY;

		// Token: 0x0400023C RID: 572
		private bool fOutlineEnabled;

		// Token: 0x0400023D RID: 573
		private int fOutline1;

		// Token: 0x0400023E RID: 574
		private int fOutline2;

		// Token: 0x0400023F RID: 575
		private int fLastValidAxisWidth;

		// Token: 0x04000240 RID: 576
		private int fWidth;

		// Token: 0x04000241 RID: 577
		private int fHeight;
	}
}
