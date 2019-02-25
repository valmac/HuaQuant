using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x0200011C RID: 284
	public class FIXSettlInstGroup : FIXGroup
	{
		// Token: 0x1700185C RID: 6236
		// (get) Token: 0x0600361A RID: 13850 RVA: 0x0003914F File Offset: 0x0003814F
		// (set) Token: 0x0600361B RID: 13851 RVA: 0x00039161 File Offset: 0x00038161
		[FIXField("162", EFieldOption.Optional)]
		public string SettlInstID
		{
			get
			{
				return this.GetStringField(162).Value;
			}
			set
			{
				this.AddStringField(162, value);
			}
		}

		// Token: 0x1700185D RID: 6237
		// (get) Token: 0x0600361C RID: 13852 RVA: 0x0003916F File Offset: 0x0003816F
		// (set) Token: 0x0600361D RID: 13853 RVA: 0x00039181 File Offset: 0x00038181
		[FIXField("163", EFieldOption.Optional)]
		public char SettlInstTransType
		{
			get
			{
				return this.GetCharField(163).Value;
			}
			set
			{
				this.AddCharField(163, value);
			}
		}

		// Token: 0x1700185E RID: 6238
		// (get) Token: 0x0600361E RID: 13854 RVA: 0x0003918F File Offset: 0x0003818F
		// (set) Token: 0x0600361F RID: 13855 RVA: 0x000391A1 File Offset: 0x000381A1
		[FIXField("214", EFieldOption.Optional)]
		public string SettlInstRefID
		{
			get
			{
				return this.GetStringField(214).Value;
			}
			set
			{
				this.AddStringField(214, value);
			}
		}

		// Token: 0x1700185F RID: 6239
		// (get) Token: 0x06003620 RID: 13856 RVA: 0x000391AF File Offset: 0x000381AF
		// (set) Token: 0x06003621 RID: 13857 RVA: 0x000391C1 File Offset: 0x000381C1
		[FIXField("453", EFieldOption.Optional)]
		public int NoPartyIDs
		{
			get
			{
				return this.GetIntField(453).Value;
			}
			set
			{
				this.AddIntField(453, value);
			}
		}

		// Token: 0x06003622 RID: 13858 RVA: 0x000391CF File Offset: 0x000381CF
		public FIXPartyIDsGroup GetPartyIDsGroup(int i)
		{
			if (i < this.NoPartyIDs)
			{
				return (FIXPartyIDsGroup)this.fPartyIDsGroup[i];
			}
			return null;
		}

		// Token: 0x06003623 RID: 13859 RVA: 0x000391ED File Offset: 0x000381ED
		public void AddGroup(FIXPartyIDsGroup group)
		{
			this.fPartyIDsGroup.Add(group);
			this.NoPartyIDs++;
		}

		// Token: 0x17001860 RID: 6240
		// (get) Token: 0x06003624 RID: 13860 RVA: 0x0003920A File Offset: 0x0003820A
		// (set) Token: 0x06003625 RID: 13861 RVA: 0x00039219 File Offset: 0x00038219
		[FIXField("54", EFieldOption.Optional)]
		public char Side
		{
			get
			{
				return this.GetCharField(54).Value;
			}
			set
			{
				this.AddCharField(54, value);
			}
		}

		// Token: 0x17001861 RID: 6241
		// (get) Token: 0x06003626 RID: 13862 RVA: 0x00039224 File Offset: 0x00038224
		// (set) Token: 0x06003627 RID: 13863 RVA: 0x00039236 File Offset: 0x00038236
		[FIXField("460", EFieldOption.Optional)]
		public int Product
		{
			get
			{
				return this.GetIntField(460).Value;
			}
			set
			{
				this.AddIntField(460, value);
			}
		}

		// Token: 0x17001862 RID: 6242
		// (get) Token: 0x06003628 RID: 13864 RVA: 0x00039244 File Offset: 0x00038244
		// (set) Token: 0x06003629 RID: 13865 RVA: 0x00039256 File Offset: 0x00038256
		[FIXField("167", EFieldOption.Optional)]
		public string SecurityType
		{
			get
			{
				return this.GetStringField(167).Value;
			}
			set
			{
				this.AddStringField(167, value);
			}
		}

		// Token: 0x17001863 RID: 6243
		// (get) Token: 0x0600362A RID: 13866 RVA: 0x00039264 File Offset: 0x00038264
		// (set) Token: 0x0600362B RID: 13867 RVA: 0x00039276 File Offset: 0x00038276
		[FIXField("461", EFieldOption.Optional)]
		public string CFICode
		{
			get
			{
				return this.GetStringField(461).Value;
			}
			set
			{
				this.AddStringField(461, value);
			}
		}

		// Token: 0x17001864 RID: 6244
		// (get) Token: 0x0600362C RID: 13868 RVA: 0x00039284 File Offset: 0x00038284
		// (set) Token: 0x0600362D RID: 13869 RVA: 0x00039296 File Offset: 0x00038296
		[FIXField("168", EFieldOption.Optional)]
		public DateTime EffectiveTime
		{
			get
			{
				return this.GetDateTimeField(168).Value;
			}
			set
			{
				this.AddDateTimeField(168, value);
			}
		}

		// Token: 0x17001865 RID: 6245
		// (get) Token: 0x0600362E RID: 13870 RVA: 0x000392A4 File Offset: 0x000382A4
		// (set) Token: 0x0600362F RID: 13871 RVA: 0x000392B3 File Offset: 0x000382B3
		[FIXField("126", EFieldOption.Optional)]
		public DateTime ExpireTime
		{
			get
			{
				return this.GetDateTimeField(126).Value;
			}
			set
			{
				this.AddDateTimeField(126, value);
			}
		}

		// Token: 0x17001866 RID: 6246
		// (get) Token: 0x06003630 RID: 13872 RVA: 0x000392BE File Offset: 0x000382BE
		// (set) Token: 0x06003631 RID: 13873 RVA: 0x000392D0 File Offset: 0x000382D0
		[FIXField("779", EFieldOption.Optional)]
		public DateTime LastUpdateTime
		{
			get
			{
				return this.GetDateTimeField(779).Value;
			}
			set
			{
				this.AddDateTimeField(779, value);
			}
		}

		// Token: 0x17001867 RID: 6247
		// (get) Token: 0x06003632 RID: 13874 RVA: 0x000392DE File Offset: 0x000382DE
		// (set) Token: 0x06003633 RID: 13875 RVA: 0x000392F0 File Offset: 0x000382F0
		[FIXField("172", EFieldOption.Optional)]
		public int SettlDeliveryType
		{
			get
			{
				return this.GetIntField(172).Value;
			}
			set
			{
				this.AddIntField(172, value);
			}
		}

		// Token: 0x17001868 RID: 6248
		// (get) Token: 0x06003634 RID: 13876 RVA: 0x000392FE File Offset: 0x000382FE
		// (set) Token: 0x06003635 RID: 13877 RVA: 0x00039310 File Offset: 0x00038310
		[FIXField("169", EFieldOption.Optional)]
		public int StandInstDbType
		{
			get
			{
				return this.GetIntField(169).Value;
			}
			set
			{
				this.AddIntField(169, value);
			}
		}

		// Token: 0x17001869 RID: 6249
		// (get) Token: 0x06003636 RID: 13878 RVA: 0x0003931E File Offset: 0x0003831E
		// (set) Token: 0x06003637 RID: 13879 RVA: 0x00039330 File Offset: 0x00038330
		[FIXField("170", EFieldOption.Optional)]
		public string StandInstDbName
		{
			get
			{
				return this.GetStringField(170).Value;
			}
			set
			{
				this.AddStringField(170, value);
			}
		}

		// Token: 0x1700186A RID: 6250
		// (get) Token: 0x06003638 RID: 13880 RVA: 0x0003933E File Offset: 0x0003833E
		// (set) Token: 0x06003639 RID: 13881 RVA: 0x00039350 File Offset: 0x00038350
		[FIXField("171", EFieldOption.Optional)]
		public string StandInstDbID
		{
			get
			{
				return this.GetStringField(171).Value;
			}
			set
			{
				this.AddStringField(171, value);
			}
		}

		// Token: 0x1700186B RID: 6251
		// (get) Token: 0x0600363A RID: 13882 RVA: 0x0003935E File Offset: 0x0003835E
		// (set) Token: 0x0600363B RID: 13883 RVA: 0x0003936D File Offset: 0x0003836D
		[FIXField("85", EFieldOption.Optional)]
		public int NoDlvyInst
		{
			get
			{
				return this.GetIntField(85).Value;
			}
			set
			{
				this.AddIntField(85, value);
			}
		}

		// Token: 0x0600363C RID: 13884 RVA: 0x00039378 File Offset: 0x00038378
		public FIXDlvyInstGroup GetDlvyInstGroup(int i)
		{
			if (i < this.NoDlvyInst)
			{
				return (FIXDlvyInstGroup)this.fDlvyInstGroup[i];
			}
			return null;
		}

		// Token: 0x0600363D RID: 13885 RVA: 0x00039396 File Offset: 0x00038396
		public void AddGroup(FIXDlvyInstGroup group)
		{
			this.fDlvyInstGroup.Add(group);
			this.NoDlvyInst++;
		}

		// Token: 0x1700186C RID: 6252
		// (get) Token: 0x0600363E RID: 13886 RVA: 0x000393B3 File Offset: 0x000383B3
		// (set) Token: 0x0600363F RID: 13887 RVA: 0x000393C5 File Offset: 0x000383C5
		[FIXField("492", EFieldOption.Optional)]
		public int PaymentMethod
		{
			get
			{
				return this.GetIntField(492).Value;
			}
			set
			{
				this.AddIntField(492, value);
			}
		}

		// Token: 0x1700186D RID: 6253
		// (get) Token: 0x06003640 RID: 13888 RVA: 0x000393D3 File Offset: 0x000383D3
		// (set) Token: 0x06003641 RID: 13889 RVA: 0x000393E5 File Offset: 0x000383E5
		[FIXField("476", EFieldOption.Optional)]
		public string PaymentRef
		{
			get
			{
				return this.GetStringField(476).Value;
			}
			set
			{
				this.AddStringField(476, value);
			}
		}

		// Token: 0x1700186E RID: 6254
		// (get) Token: 0x06003642 RID: 13890 RVA: 0x000393F3 File Offset: 0x000383F3
		// (set) Token: 0x06003643 RID: 13891 RVA: 0x00039405 File Offset: 0x00038405
		[FIXField("488", EFieldOption.Optional)]
		public string CardHolderName
		{
			get
			{
				return this.GetStringField(488).Value;
			}
			set
			{
				this.AddStringField(488, value);
			}
		}

		// Token: 0x1700186F RID: 6255
		// (get) Token: 0x06003644 RID: 13892 RVA: 0x00039413 File Offset: 0x00038413
		// (set) Token: 0x06003645 RID: 13893 RVA: 0x00039425 File Offset: 0x00038425
		[FIXField("489", EFieldOption.Optional)]
		public string CardNumber
		{
			get
			{
				return this.GetStringField(489).Value;
			}
			set
			{
				this.AddStringField(489, value);
			}
		}

		// Token: 0x17001870 RID: 6256
		// (get) Token: 0x06003646 RID: 13894 RVA: 0x00039433 File Offset: 0x00038433
		// (set) Token: 0x06003647 RID: 13895 RVA: 0x00039445 File Offset: 0x00038445
		[FIXField("503", EFieldOption.Optional)]
		public DateTime CardStartDate
		{
			get
			{
				return this.GetDateTimeField(503).Value;
			}
			set
			{
				this.AddDateTimeField(503, value);
			}
		}

		// Token: 0x17001871 RID: 6257
		// (get) Token: 0x06003648 RID: 13896 RVA: 0x00039453 File Offset: 0x00038453
		// (set) Token: 0x06003649 RID: 13897 RVA: 0x00039465 File Offset: 0x00038465
		[FIXField("490", EFieldOption.Optional)]
		public DateTime CardExpDate
		{
			get
			{
				return this.GetDateTimeField(490).Value;
			}
			set
			{
				this.AddDateTimeField(490, value);
			}
		}

		// Token: 0x17001872 RID: 6258
		// (get) Token: 0x0600364A RID: 13898 RVA: 0x00039473 File Offset: 0x00038473
		// (set) Token: 0x0600364B RID: 13899 RVA: 0x00039485 File Offset: 0x00038485
		[FIXField("491", EFieldOption.Optional)]
		public string CardIssNum
		{
			get
			{
				return this.GetStringField(491).Value;
			}
			set
			{
				this.AddStringField(491, value);
			}
		}

		// Token: 0x17001873 RID: 6259
		// (get) Token: 0x0600364C RID: 13900 RVA: 0x00039493 File Offset: 0x00038493
		// (set) Token: 0x0600364D RID: 13901 RVA: 0x000394A5 File Offset: 0x000384A5
		[FIXField("504", EFieldOption.Optional)]
		public DateTime PaymentDate
		{
			get
			{
				return this.GetDateTimeField(504).Value;
			}
			set
			{
				this.AddDateTimeField(504, value);
			}
		}

		// Token: 0x17001874 RID: 6260
		// (get) Token: 0x0600364E RID: 13902 RVA: 0x000394B3 File Offset: 0x000384B3
		// (set) Token: 0x0600364F RID: 13903 RVA: 0x000394C5 File Offset: 0x000384C5
		[FIXField("505", EFieldOption.Optional)]
		public string PaymentRemitterID
		{
			get
			{
				return this.GetStringField(505).Value;
			}
			set
			{
				this.AddStringField(505, value);
			}
		}

		// Token: 0x04000507 RID: 1287
		private ArrayList fPartyIDsGroup = new ArrayList();

		// Token: 0x04000508 RID: 1288
		private ArrayList fDlvyInstGroup = new ArrayList();
	}
}
