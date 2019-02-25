using System;

namespace SmartQuant.Trading.Conditions
{
	// Token: 0x02000009 RID: 9
	public abstract class RuleItem
	{
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00004ED1 File Offset: 0x00003ED1
		public virtual string Name
		{
			get
			{
				return "";
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00004ED8 File Offset: 0x00003ED8
		public RuleItem()
		{
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000CD RID: 205
		public abstract string CodeName { get; }

		// Token: 0x060000CE RID: 206
		public abstract void Execute();
	}
}
