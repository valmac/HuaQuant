using System;
using System.ComponentModel;

namespace SmartQuant.Trading
{
	// Token: 0x0200000D RID: 13
	public class ComponentBase : IComponentBase
	{
		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00005008 File Offset: 0x00004008
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x00005010 File Offset: 0x00004010
		[ReadOnly(true)]
		[Description("Component name")]
		[Category("Description")]
		public virtual string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x00005019 File Offset: 0x00004019
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x00005021 File Offset: 0x00004021
		[ReadOnly(true)]
		[Category("Description")]
		[Description("Component description")]
		public virtual string Description
		{
			get
			{
				return this.description;
			}
			set
			{
				this.description = value;
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0000502A File Offset: 0x0000402A
		public virtual void Init()
		{
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000502C File Offset: 0x0000402C
		public virtual void Connect()
		{
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000502E File Offset: 0x0000402E
		public virtual void Disconnect()
		{
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00005030 File Offset: 0x00004030
		public virtual void OnStrategyStop()
		{
		}

		// Token: 0x04000045 RID: 69
		protected string name;

		// Token: 0x04000046 RID: 70
		protected string description;
	}
}
