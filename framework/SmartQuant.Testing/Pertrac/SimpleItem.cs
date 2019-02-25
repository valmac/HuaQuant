using System;
using System.ComponentModel;
using SmartQuant.Testing.TesterItems;

namespace SmartQuant.Testing.Pertrac
{
	// Token: 0x0200001E RID: 30
	public class SimpleItem : TesterItem
	{
		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x0000516E File Offset: 0x0000416E
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x00005176 File Offset: 0x00004176
		[Category("Properties")]
		public string Format
		{
			get
			{
				return this.format;
			}
			set
			{
				this.format = value;
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0000517F File Offset: 0x0000417F
		public SimpleItem(string name, string format) : base(name)
		{
			this.format = format;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000518F File Offset: 0x0000418F
		public SimpleItem(string name) : base(name)
		{
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00005198 File Offset: 0x00004198
		public override string ValueToSrting()
		{
			return this.LastValue.ToString(this.format);
		}

		// Token: 0x04000032 RID: 50
		protected string format;
	}
}
