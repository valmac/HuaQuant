using System;

namespace SmartQuant.Trading.Conditions
{
	// Token: 0x0200000A RID: 10
	public class SignalItem : RuleItem
	{
		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00004EE0 File Offset: 0x00003EE0
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x00004EE8 File Offset: 0x00003EE8
		public SignalItemType SignalType
		{
			get
			{
				return this.signalType;
			}
			set
			{
				this.signalType = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00004EF1 File Offset: 0x00003EF1
		public override string Name
		{
			get
			{
				return this.signalType.ToString();
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00004F03 File Offset: 0x00003F03
		public override string CodeName
		{
			get
			{
				return "rule." + this.signalType;
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00004F1A File Offset: 0x00003F1A
		public SignalItem(SignalItemType signalType, IStrategyComponent component)
		{
			this.signalType = signalType;
			this.component = component;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00004F30 File Offset: 0x00003F30
		public SignalItem(SignalItemType signalType)
		{
			this.signalType = signalType;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00004F40 File Offset: 0x00003F40
		public override void Execute()
		{
			if (this.component is Entry)
			{
				Entry entry = this.component as Entry;
				switch (this.signalType)
				{
				case SignalItemType.Long:
					entry.LongEntry();
					break;
				case SignalItemType.Short:
					entry.ShortEntry();
					break;
				}
			}
			if (this.component is Exit)
			{
				Exit exit = this.component as Exit;
				switch (this.signalType)
				{
				case SignalItemType.Long:
					exit.LongExit();
					return;
				case SignalItemType.Short:
					exit.ShortExit();
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x04000042 RID: 66
		private SignalItemType signalType;

		// Token: 0x04000043 RID: 67
		private IStrategyComponent component;
	}
}
