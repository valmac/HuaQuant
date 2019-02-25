using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x020000C7 RID: 199
	public class FIXInstrumentExtension : FIXMessage
	{
		// Token: 0x170011AB RID: 4523
		// (get) Token: 0x06002720 RID: 10016 RVA: 0x00029B70 File Offset: 0x00028B70
		// (set) Token: 0x06002721 RID: 10017 RVA: 0x00029B82 File Offset: 0x00028B82
		[FIXField("668", EFieldOption.Optional)]
		public int DeliveryForm
		{
			get
			{
				return this.GetIntField(668).Value;
			}
			set
			{
				this.AddIntField(668, value);
			}
		}

		// Token: 0x170011AC RID: 4524
		// (get) Token: 0x06002722 RID: 10018 RVA: 0x00029B90 File Offset: 0x00028B90
		// (set) Token: 0x06002723 RID: 10019 RVA: 0x00029BA2 File Offset: 0x00028BA2
		[FIXField("869", EFieldOption.Optional)]
		public double PctAtRisk
		{
			get
			{
				return this.GetDoubleField(869).Value;
			}
			set
			{
				this.AddDoubleField(869, value);
			}
		}

		// Token: 0x170011AD RID: 4525
		// (get) Token: 0x06002724 RID: 10020 RVA: 0x00029BB0 File Offset: 0x00028BB0
		// (set) Token: 0x06002725 RID: 10021 RVA: 0x00029BC2 File Offset: 0x00028BC2
		[FIXField("870", EFieldOption.Optional)]
		public int NoInstrAttrib
		{
			get
			{
				return this.GetIntField(870).Value;
			}
			set
			{
				this.AddIntField(870, value);
			}
		}

		// Token: 0x06002726 RID: 10022 RVA: 0x00029BD0 File Offset: 0x00028BD0
		public FIXInstrAttribGroup GetInstrAttribGroup(int i)
		{
			if (i < this.NoInstrAttrib)
			{
				return (FIXInstrAttribGroup)this.fInstrAttribGroup[i];
			}
			return null;
		}

		// Token: 0x06002727 RID: 10023 RVA: 0x00029BEE File Offset: 0x00028BEE
		public void AddGroup(FIXInstrAttribGroup group)
		{
			this.fInstrAttribGroup.Add(group);
			this.NoInstrAttrib++;
		}

		// Token: 0x040003A5 RID: 933
		private ArrayList fInstrAttribGroup = new ArrayList();
	}
}
