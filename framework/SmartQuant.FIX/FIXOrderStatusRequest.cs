using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x020000A6 RID: 166
	public class FIXOrderStatusRequest : FIXMessage
	{
		// Token: 0x17000F74 RID: 3956
		// (get) Token: 0x0600223C RID: 8764 RVA: 0x00024CC6 File Offset: 0x00023CC6
		// (set) Token: 0x0600223D RID: 8765 RVA: 0x00024CD8 File Offset: 0x00023CD8
		[FIXField("144", EFieldOption.Optional)]
		public string OnBehalfOfLocationID
		{
			get
			{
				return this.GetStringField(144).Value;
			}
			set
			{
				this.AddStringField(144, value);
			}
		}

		// Token: 0x17000F75 RID: 3957
		// (get) Token: 0x0600223E RID: 8766 RVA: 0x00024CE6 File Offset: 0x00023CE6
		// (set) Token: 0x0600223F RID: 8767 RVA: 0x00024CF5 File Offset: 0x00023CF5
		[FIXField("9", EFieldOption.Required)]
		public int BodyLength
		{
			get
			{
				return this.GetIntField(9).Value;
			}
			set
			{
				this.AddIntField(9, value);
			}
		}

		// Token: 0x17000F76 RID: 3958
		// (get) Token: 0x06002240 RID: 8768 RVA: 0x00024D00 File Offset: 0x00023D00
		// (set) Token: 0x06002241 RID: 8769 RVA: 0x00024D0F File Offset: 0x00023D0F
		[FIXField("35", EFieldOption.Required)]
		public string MsgType
		{
			get
			{
				return this.GetStringField(35).Value;
			}
			set
			{
				this.AddStringField(35, value);
			}
		}

		// Token: 0x17000F77 RID: 3959
		// (get) Token: 0x06002242 RID: 8770 RVA: 0x00024D1A File Offset: 0x00023D1A
		// (set) Token: 0x06002243 RID: 8771 RVA: 0x00024D29 File Offset: 0x00023D29
		[FIXField("49", EFieldOption.Required)]
		public string SenderCompID
		{
			get
			{
				return this.GetStringField(49).Value;
			}
			set
			{
				this.AddStringField(49, value);
			}
		}

		// Token: 0x17000F78 RID: 3960
		// (get) Token: 0x06002244 RID: 8772 RVA: 0x00024D34 File Offset: 0x00023D34
		// (set) Token: 0x06002245 RID: 8773 RVA: 0x00024D43 File Offset: 0x00023D43
		[FIXField("56", EFieldOption.Required)]
		public string TargetCompID
		{
			get
			{
				return this.GetStringField(56).Value;
			}
			set
			{
				this.AddStringField(56, value);
			}
		}

		// Token: 0x17000F79 RID: 3961
		// (get) Token: 0x06002246 RID: 8774 RVA: 0x00024D4E File Offset: 0x00023D4E
		// (set) Token: 0x06002247 RID: 8775 RVA: 0x00024D5D File Offset: 0x00023D5D
		[FIXField("115", EFieldOption.Optional)]
		public string OnBehalfOfCompID
		{
			get
			{
				return this.GetStringField(115).Value;
			}
			set
			{
				this.AddStringField(115, value);
			}
		}

		// Token: 0x17000F7A RID: 3962
		// (get) Token: 0x06002248 RID: 8776 RVA: 0x00024D68 File Offset: 0x00023D68
		// (set) Token: 0x06002249 RID: 8777 RVA: 0x00024D7A File Offset: 0x00023D7A
		[FIXField("128", EFieldOption.Optional)]
		public string DeliverToCompID
		{
			get
			{
				return this.GetStringField(128).Value;
			}
			set
			{
				this.AddStringField(128, value);
			}
		}

		// Token: 0x17000F7B RID: 3963
		// (get) Token: 0x0600224A RID: 8778 RVA: 0x00024D88 File Offset: 0x00023D88
		// (set) Token: 0x0600224B RID: 8779 RVA: 0x00024D97 File Offset: 0x00023D97
		[FIXField("90", EFieldOption.Optional)]
		public int SecureDataLen
		{
			get
			{
				return this.GetIntField(90).Value;
			}
			set
			{
				this.AddIntField(90, value);
			}
		}

		// Token: 0x17000F7C RID: 3964
		// (get) Token: 0x0600224C RID: 8780 RVA: 0x00024DA2 File Offset: 0x00023DA2
		// (set) Token: 0x0600224D RID: 8781 RVA: 0x00024DB1 File Offset: 0x00023DB1
		[FIXField("91", EFieldOption.Optional)]
		public string SecureData
		{
			get
			{
				return this.GetStringField(91).Value;
			}
			set
			{
				this.AddStringField(91, value);
			}
		}

		// Token: 0x17000F7D RID: 3965
		// (get) Token: 0x0600224E RID: 8782 RVA: 0x00024DBC File Offset: 0x00023DBC
		// (set) Token: 0x0600224F RID: 8783 RVA: 0x00024DCB File Offset: 0x00023DCB
		[FIXField("34", EFieldOption.Required)]
		public int MsgSeqNum
		{
			get
			{
				return this.GetIntField(34).Value;
			}
			set
			{
				this.AddIntField(34, value);
			}
		}

		// Token: 0x17000F7E RID: 3966
		// (get) Token: 0x06002250 RID: 8784 RVA: 0x00024DD6 File Offset: 0x00023DD6
		// (set) Token: 0x06002251 RID: 8785 RVA: 0x00024DE5 File Offset: 0x00023DE5
		[FIXField("50", EFieldOption.Optional)]
		public string SenderSubID
		{
			get
			{
				return this.GetStringField(50).Value;
			}
			set
			{
				this.AddStringField(50, value);
			}
		}

		// Token: 0x17000F7F RID: 3967
		// (get) Token: 0x06002252 RID: 8786 RVA: 0x00024DF0 File Offset: 0x00023DF0
		// (set) Token: 0x06002253 RID: 8787 RVA: 0x00024E02 File Offset: 0x00023E02
		[FIXField("142", EFieldOption.Optional)]
		public string SenderLocationID
		{
			get
			{
				return this.GetStringField(142).Value;
			}
			set
			{
				this.AddStringField(142, value);
			}
		}

		// Token: 0x17000F80 RID: 3968
		// (get) Token: 0x06002254 RID: 8788 RVA: 0x00024E10 File Offset: 0x00023E10
		// (set) Token: 0x06002255 RID: 8789 RVA: 0x00024E1F File Offset: 0x00023E1F
		[FIXField("57", EFieldOption.Optional)]
		public string TargetSubID
		{
			get
			{
				return this.GetStringField(57).Value;
			}
			set
			{
				this.AddStringField(57, value);
			}
		}

		// Token: 0x17000F81 RID: 3969
		// (get) Token: 0x06002256 RID: 8790 RVA: 0x00024E2A File Offset: 0x00023E2A
		// (set) Token: 0x06002257 RID: 8791 RVA: 0x00024E38 File Offset: 0x00023E38
		[FIXField("8", EFieldOption.Required)]
		public string BeginString
		{
			get
			{
				return this.GetStringField(8).Value;
			}
			set
			{
				this.AddStringField(8, value);
			}
		}

		// Token: 0x17000F82 RID: 3970
		// (get) Token: 0x06002258 RID: 8792 RVA: 0x00024E42 File Offset: 0x00023E42
		// (set) Token: 0x06002259 RID: 8793 RVA: 0x00024E51 File Offset: 0x00023E51
		[FIXField("116", EFieldOption.Optional)]
		public string OnBehalfOfSubID
		{
			get
			{
				return this.GetStringField(116).Value;
			}
			set
			{
				this.AddStringField(116, value);
			}
		}

		// Token: 0x0600225A RID: 8794 RVA: 0x00024E5C File Offset: 0x00023E5C
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x0600225B RID: 8795 RVA: 0x00024E6F File Offset: 0x00023E6F
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17000F83 RID: 3971
		// (get) Token: 0x0600225C RID: 8796 RVA: 0x00024E7E File Offset: 0x00023E7E
		// (set) Token: 0x0600225D RID: 8797 RVA: 0x00024E90 File Offset: 0x00023E90
		[FIXField("129", EFieldOption.Optional)]
		public string DeliverToSubID
		{
			get
			{
				return this.GetStringField(129).Value;
			}
			set
			{
				this.AddStringField(129, value);
			}
		}

		// Token: 0x17000F84 RID: 3972
		// (get) Token: 0x0600225E RID: 8798 RVA: 0x00024E9E File Offset: 0x00023E9E
		// (set) Token: 0x0600225F RID: 8799 RVA: 0x00024EB0 File Offset: 0x00023EB0
		[FIXField("145", EFieldOption.Optional)]
		public string DeliverToLocationID
		{
			get
			{
				return this.GetStringField(145).Value;
			}
			set
			{
				this.AddStringField(145, value);
			}
		}

		// Token: 0x17000F85 RID: 3973
		// (get) Token: 0x06002260 RID: 8800 RVA: 0x00024EBE File Offset: 0x00023EBE
		// (set) Token: 0x06002261 RID: 8801 RVA: 0x00024ECD File Offset: 0x00023ECD
		[FIXField("43", EFieldOption.Optional)]
		public bool PossDupFlag
		{
			get
			{
				return this.GetBoolField(43).Value;
			}
			set
			{
				this.AddBoolField(43, value);
			}
		}

		// Token: 0x17000F86 RID: 3974
		// (get) Token: 0x06002262 RID: 8802 RVA: 0x00024ED8 File Offset: 0x00023ED8
		// (set) Token: 0x06002263 RID: 8803 RVA: 0x00024EE7 File Offset: 0x00023EE7
		[FIXField("97", EFieldOption.Optional)]
		public bool PossResend
		{
			get
			{
				return this.GetBoolField(97).Value;
			}
			set
			{
				this.AddBoolField(97, value);
			}
		}

		// Token: 0x17000F87 RID: 3975
		// (get) Token: 0x06002264 RID: 8804 RVA: 0x00024EF2 File Offset: 0x00023EF2
		// (set) Token: 0x06002265 RID: 8805 RVA: 0x00024F01 File Offset: 0x00023F01
		[FIXField("52", EFieldOption.Optional)]
		public DateTime SendingTime
		{
			get
			{
				return this.GetDateTimeField(52).Value;
			}
			set
			{
				this.AddDateTimeField(52, value);
			}
		}

		// Token: 0x17000F88 RID: 3976
		// (get) Token: 0x06002266 RID: 8806 RVA: 0x00024F0C File Offset: 0x00023F0C
		// (set) Token: 0x06002267 RID: 8807 RVA: 0x00024F1B File Offset: 0x00023F1B
		[FIXField("122", EFieldOption.Optional)]
		public DateTime OrigSendingTime
		{
			get
			{
				return this.GetDateTimeField(122).Value;
			}
			set
			{
				this.AddDateTimeField(122, value);
			}
		}

		// Token: 0x17000F89 RID: 3977
		// (get) Token: 0x06002268 RID: 8808 RVA: 0x00024F26 File Offset: 0x00023F26
		// (set) Token: 0x06002269 RID: 8809 RVA: 0x00024F38 File Offset: 0x00023F38
		[FIXField("212", EFieldOption.Optional)]
		public int XmlDataLen
		{
			get
			{
				return this.GetIntField(212).Value;
			}
			set
			{
				this.AddIntField(212, value);
			}
		}

		// Token: 0x17000F8A RID: 3978
		// (get) Token: 0x0600226A RID: 8810 RVA: 0x00024F46 File Offset: 0x00023F46
		// (set) Token: 0x0600226B RID: 8811 RVA: 0x00024F58 File Offset: 0x00023F58
		[FIXField("213", EFieldOption.Optional)]
		public string XmlData
		{
			get
			{
				return this.GetStringField(213).Value;
			}
			set
			{
				this.AddStringField(213, value);
			}
		}

		// Token: 0x17000F8B RID: 3979
		// (get) Token: 0x0600226C RID: 8812 RVA: 0x00024F66 File Offset: 0x00023F66
		// (set) Token: 0x0600226D RID: 8813 RVA: 0x00024F78 File Offset: 0x00023F78
		[FIXField("347", EFieldOption.Optional)]
		public string MessageEncoding
		{
			get
			{
				return this.GetStringField(347).Value;
			}
			set
			{
				this.AddStringField(347, value);
			}
		}

		// Token: 0x17000F8C RID: 3980
		// (get) Token: 0x0600226E RID: 8814 RVA: 0x00024F86 File Offset: 0x00023F86
		// (set) Token: 0x0600226F RID: 8815 RVA: 0x00024F98 File Offset: 0x00023F98
		[FIXField("369", EFieldOption.Optional)]
		public int LastMsgSeqNumProcessed
		{
			get
			{
				return this.GetIntField(369).Value;
			}
			set
			{
				this.AddIntField(369, value);
			}
		}

		// Token: 0x17000F8D RID: 3981
		// (get) Token: 0x06002270 RID: 8816 RVA: 0x00024FA6 File Offset: 0x00023FA6
		// (set) Token: 0x06002271 RID: 8817 RVA: 0x00024FB8 File Offset: 0x00023FB8
		[FIXField("627", EFieldOption.Optional)]
		public int NoHops
		{
			get
			{
				return this.GetIntField(627).Value;
			}
			set
			{
				this.AddIntField(627, value);
			}
		}

		// Token: 0x06002272 RID: 8818 RVA: 0x00024FC6 File Offset: 0x00023FC6
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06002273 RID: 8819 RVA: 0x00024FE4 File Offset: 0x00023FE4
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x17000F8E RID: 3982
		// (get) Token: 0x06002274 RID: 8820 RVA: 0x00025001 File Offset: 0x00024001
		// (set) Token: 0x06002275 RID: 8821 RVA: 0x00025013 File Offset: 0x00024013
		[FIXField("143", EFieldOption.Optional)]
		public string TargetLocationID
		{
			get
			{
				return this.GetStringField(143).Value;
			}
			set
			{
				this.AddStringField(143, value);
			}
		}

		// Token: 0x17000F8F RID: 3983
		// (get) Token: 0x06002276 RID: 8822 RVA: 0x00025021 File Offset: 0x00024021
		// (set) Token: 0x06002277 RID: 8823 RVA: 0x00025030 File Offset: 0x00024030
		[FIXField("37", EFieldOption.Optional)]
		public string OrderID
		{
			get
			{
				return this.GetStringField(37).Value;
			}
			set
			{
				this.AddStringField(37, value);
			}
		}

		// Token: 0x17000F90 RID: 3984
		// (get) Token: 0x06002278 RID: 8824 RVA: 0x0002503B File Offset: 0x0002403B
		// (set) Token: 0x06002279 RID: 8825 RVA: 0x0002504A File Offset: 0x0002404A
		[FIXField("11", EFieldOption.Required)]
		public string ClOrdID
		{
			get
			{
				return this.GetStringField(11).Value;
			}
			set
			{
				this.AddStringField(11, value);
			}
		}

		// Token: 0x17000F91 RID: 3985
		// (get) Token: 0x0600227A RID: 8826 RVA: 0x00025055 File Offset: 0x00024055
		// (set) Token: 0x0600227B RID: 8827 RVA: 0x00025067 File Offset: 0x00024067
		[FIXField("526", EFieldOption.Optional)]
		public string SecondaryClOrdID
		{
			get
			{
				return this.GetStringField(526).Value;
			}
			set
			{
				this.AddStringField(526, value);
			}
		}

		// Token: 0x17000F92 RID: 3986
		// (get) Token: 0x0600227C RID: 8828 RVA: 0x00025075 File Offset: 0x00024075
		// (set) Token: 0x0600227D RID: 8829 RVA: 0x00025087 File Offset: 0x00024087
		[FIXField("583", EFieldOption.Optional)]
		public string ClOrdLinkID
		{
			get
			{
				return this.GetStringField(583).Value;
			}
			set
			{
				this.AddStringField(583, value);
			}
		}

		// Token: 0x17000F93 RID: 3987
		// (get) Token: 0x0600227E RID: 8830 RVA: 0x00025095 File Offset: 0x00024095
		// (set) Token: 0x0600227F RID: 8831 RVA: 0x000250A7 File Offset: 0x000240A7
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

		// Token: 0x06002280 RID: 8832 RVA: 0x000250B5 File Offset: 0x000240B5
		public FIXPartyIDsGroup GetPartyIDsGroup(int i)
		{
			if (i < this.NoPartyIDs)
			{
				return (FIXPartyIDsGroup)this.fPartyIDsGroup[i];
			}
			return null;
		}

		// Token: 0x06002281 RID: 8833 RVA: 0x000250D3 File Offset: 0x000240D3
		public void AddGroup(FIXPartyIDsGroup group)
		{
			this.fPartyIDsGroup.Add(group);
			this.NoPartyIDs++;
		}

		// Token: 0x17000F94 RID: 3988
		// (get) Token: 0x06002282 RID: 8834 RVA: 0x000250F0 File Offset: 0x000240F0
		// (set) Token: 0x06002283 RID: 8835 RVA: 0x00025102 File Offset: 0x00024102
		[FIXField("790", EFieldOption.Optional)]
		public string OrdStatusReqID
		{
			get
			{
				return this.GetStringField(790).Value;
			}
			set
			{
				this.AddStringField(790, value);
			}
		}

		// Token: 0x17000F95 RID: 3989
		// (get) Token: 0x06002284 RID: 8836 RVA: 0x00025110 File Offset: 0x00024110
		// (set) Token: 0x06002285 RID: 8837 RVA: 0x0002511E File Offset: 0x0002411E
		[FIXField("1", EFieldOption.Optional)]
		public string Account
		{
			get
			{
				return this.GetStringField(1).Value;
			}
			set
			{
				this.AddStringField(1, value);
			}
		}

		// Token: 0x17000F96 RID: 3990
		// (get) Token: 0x06002286 RID: 8838 RVA: 0x00025128 File Offset: 0x00024128
		// (set) Token: 0x06002287 RID: 8839 RVA: 0x0002513A File Offset: 0x0002413A
		[FIXField("660", EFieldOption.Optional)]
		public int AcctIDSource
		{
			get
			{
				return this.GetIntField(660).Value;
			}
			set
			{
				this.AddIntField(660, value);
			}
		}

		// Token: 0x17000F97 RID: 3991
		// (get) Token: 0x06002288 RID: 8840 RVA: 0x00025148 File Offset: 0x00024148
		// (set) Token: 0x06002289 RID: 8841 RVA: 0x00025157 File Offset: 0x00024157
		[FIXField("55", EFieldOption.Optional)]
		public string Symbol
		{
			get
			{
				return this.GetStringField(55).Value;
			}
			set
			{
				this.AddStringField(55, value);
			}
		}

		// Token: 0x17000F98 RID: 3992
		// (get) Token: 0x0600228A RID: 8842 RVA: 0x00025162 File Offset: 0x00024162
		// (set) Token: 0x0600228B RID: 8843 RVA: 0x00025171 File Offset: 0x00024171
		[FIXField("65", EFieldOption.Optional)]
		public string SymbolSfx
		{
			get
			{
				return this.GetStringField(65).Value;
			}
			set
			{
				this.AddStringField(65, value);
			}
		}

		// Token: 0x17000F99 RID: 3993
		// (get) Token: 0x0600228C RID: 8844 RVA: 0x0002517C File Offset: 0x0002417C
		// (set) Token: 0x0600228D RID: 8845 RVA: 0x0002518B File Offset: 0x0002418B
		[FIXField("48", EFieldOption.Optional)]
		public string SecurityID
		{
			get
			{
				return this.GetStringField(48).Value;
			}
			set
			{
				this.AddStringField(48, value);
			}
		}

		// Token: 0x17000F9A RID: 3994
		// (get) Token: 0x0600228E RID: 8846 RVA: 0x00025196 File Offset: 0x00024196
		// (set) Token: 0x0600228F RID: 8847 RVA: 0x000251A5 File Offset: 0x000241A5
		[FIXField("22", EFieldOption.Optional)]
		public string SecurityIDSource
		{
			get
			{
				return this.GetStringField(22).Value;
			}
			set
			{
				this.AddStringField(22, value);
			}
		}

		// Token: 0x17000F9B RID: 3995
		// (get) Token: 0x06002290 RID: 8848 RVA: 0x000251B0 File Offset: 0x000241B0
		// (set) Token: 0x06002291 RID: 8849 RVA: 0x000251C2 File Offset: 0x000241C2
		[FIXField("454", EFieldOption.Optional)]
		public int NoSecurityAltID
		{
			get
			{
				return this.GetIntField(454).Value;
			}
			set
			{
				this.AddIntField(454, value);
			}
		}

		// Token: 0x06002292 RID: 8850 RVA: 0x000251D0 File Offset: 0x000241D0
		public FIXSecurityAltIDGroup GetSecurityAltIDGroup(int i)
		{
			if (i < this.NoSecurityAltID)
			{
				return (FIXSecurityAltIDGroup)this.fSecurityAltIDGroup[i];
			}
			return null;
		}

		// Token: 0x06002293 RID: 8851 RVA: 0x000251EE File Offset: 0x000241EE
		public void AddGroup(FIXSecurityAltIDGroup group)
		{
			this.fSecurityAltIDGroup.Add(group);
			this.NoSecurityAltID++;
		}

		// Token: 0x17000F9C RID: 3996
		// (get) Token: 0x06002294 RID: 8852 RVA: 0x0002520B File Offset: 0x0002420B
		// (set) Token: 0x06002295 RID: 8853 RVA: 0x0002521D File Offset: 0x0002421D
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

		// Token: 0x17000F9D RID: 3997
		// (get) Token: 0x06002296 RID: 8854 RVA: 0x0002522B File Offset: 0x0002422B
		// (set) Token: 0x06002297 RID: 8855 RVA: 0x0002523D File Offset: 0x0002423D
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

		// Token: 0x17000F9E RID: 3998
		// (get) Token: 0x06002298 RID: 8856 RVA: 0x0002524B File Offset: 0x0002424B
		// (set) Token: 0x06002299 RID: 8857 RVA: 0x0002525D File Offset: 0x0002425D
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

		// Token: 0x17000F9F RID: 3999
		// (get) Token: 0x0600229A RID: 8858 RVA: 0x0002526B File Offset: 0x0002426B
		// (set) Token: 0x0600229B RID: 8859 RVA: 0x0002527D File Offset: 0x0002427D
		[FIXField("762", EFieldOption.Optional)]
		public string SecuritySubType
		{
			get
			{
				return this.GetStringField(762).Value;
			}
			set
			{
				this.AddStringField(762, value);
			}
		}

		// Token: 0x17000FA0 RID: 4000
		// (get) Token: 0x0600229C RID: 8860 RVA: 0x0002528B File Offset: 0x0002428B
		// (set) Token: 0x0600229D RID: 8861 RVA: 0x0002529D File Offset: 0x0002429D
		[FIXField("200", EFieldOption.Optional)]
		public string MaturityMonthYear
		{
			get
			{
				return this.GetStringField(200).Value;
			}
			set
			{
				this.AddStringField(200, value);
			}
		}

		// Token: 0x17000FA1 RID: 4001
		// (get) Token: 0x0600229E RID: 8862 RVA: 0x000252AB File Offset: 0x000242AB
		// (set) Token: 0x0600229F RID: 8863 RVA: 0x000252BD File Offset: 0x000242BD
		[FIXField("541", EFieldOption.Optional)]
		public DateTime MaturityDate
		{
			get
			{
				return this.GetDateTimeField(541).Value;
			}
			set
			{
				this.AddDateTimeField(541, value);
			}
		}

		// Token: 0x17000FA2 RID: 4002
		// (get) Token: 0x060022A0 RID: 8864 RVA: 0x000252CB File Offset: 0x000242CB
		// (set) Token: 0x060022A1 RID: 8865 RVA: 0x000252DD File Offset: 0x000242DD
		[FIXField("224", EFieldOption.Optional)]
		public DateTime CouponPaymentDate
		{
			get
			{
				return this.GetDateTimeField(224).Value;
			}
			set
			{
				this.AddDateTimeField(224, value);
			}
		}

		// Token: 0x17000FA3 RID: 4003
		// (get) Token: 0x060022A2 RID: 8866 RVA: 0x000252EB File Offset: 0x000242EB
		// (set) Token: 0x060022A3 RID: 8867 RVA: 0x000252FD File Offset: 0x000242FD
		[FIXField("225", EFieldOption.Optional)]
		public DateTime IssueDate
		{
			get
			{
				return this.GetDateTimeField(225).Value;
			}
			set
			{
				this.AddDateTimeField(225, value);
			}
		}

		// Token: 0x17000FA4 RID: 4004
		// (get) Token: 0x060022A4 RID: 8868 RVA: 0x0002530B File Offset: 0x0002430B
		// (set) Token: 0x060022A5 RID: 8869 RVA: 0x0002531D File Offset: 0x0002431D
		[FIXField("239", EFieldOption.Optional)]
		public int RepoCollateralSecurityType
		{
			get
			{
				return this.GetIntField(239).Value;
			}
			set
			{
				this.AddIntField(239, value);
			}
		}

		// Token: 0x17000FA5 RID: 4005
		// (get) Token: 0x060022A6 RID: 8870 RVA: 0x0002532B File Offset: 0x0002432B
		// (set) Token: 0x060022A7 RID: 8871 RVA: 0x0002533D File Offset: 0x0002433D
		[FIXField("226", EFieldOption.Optional)]
		public int RepurchaseTerm
		{
			get
			{
				return this.GetIntField(226).Value;
			}
			set
			{
				this.AddIntField(226, value);
			}
		}

		// Token: 0x17000FA6 RID: 4006
		// (get) Token: 0x060022A8 RID: 8872 RVA: 0x0002534B File Offset: 0x0002434B
		// (set) Token: 0x060022A9 RID: 8873 RVA: 0x0002535D File Offset: 0x0002435D
		[FIXField("227", EFieldOption.Optional)]
		public double RepurchaseRate
		{
			get
			{
				return this.GetDoubleField(227).Value;
			}
			set
			{
				this.AddDoubleField(227, value);
			}
		}

		// Token: 0x17000FA7 RID: 4007
		// (get) Token: 0x060022AA RID: 8874 RVA: 0x0002536B File Offset: 0x0002436B
		// (set) Token: 0x060022AB RID: 8875 RVA: 0x0002537D File Offset: 0x0002437D
		[FIXField("228", EFieldOption.Optional)]
		public double Factor
		{
			get
			{
				return this.GetDoubleField(228).Value;
			}
			set
			{
				this.AddDoubleField(228, value);
			}
		}

		// Token: 0x17000FA8 RID: 4008
		// (get) Token: 0x060022AC RID: 8876 RVA: 0x0002538B File Offset: 0x0002438B
		// (set) Token: 0x060022AD RID: 8877 RVA: 0x0002539D File Offset: 0x0002439D
		[FIXField("255", EFieldOption.Optional)]
		public string CreditRating
		{
			get
			{
				return this.GetStringField(255).Value;
			}
			set
			{
				this.AddStringField(255, value);
			}
		}

		// Token: 0x17000FA9 RID: 4009
		// (get) Token: 0x060022AE RID: 8878 RVA: 0x000253AB File Offset: 0x000243AB
		// (set) Token: 0x060022AF RID: 8879 RVA: 0x000253BD File Offset: 0x000243BD
		[FIXField("543", EFieldOption.Optional)]
		public string InstrRegistry
		{
			get
			{
				return this.GetStringField(543).Value;
			}
			set
			{
				this.AddStringField(543, value);
			}
		}

		// Token: 0x17000FAA RID: 4010
		// (get) Token: 0x060022B0 RID: 8880 RVA: 0x000253CB File Offset: 0x000243CB
		// (set) Token: 0x060022B1 RID: 8881 RVA: 0x000253DD File Offset: 0x000243DD
		[FIXField("470", EFieldOption.Optional)]
		public string CountryOfIssue
		{
			get
			{
				return this.GetStringField(470).Value;
			}
			set
			{
				this.AddStringField(470, value);
			}
		}

		// Token: 0x17000FAB RID: 4011
		// (get) Token: 0x060022B2 RID: 8882 RVA: 0x000253EB File Offset: 0x000243EB
		// (set) Token: 0x060022B3 RID: 8883 RVA: 0x000253FD File Offset: 0x000243FD
		[FIXField("471", EFieldOption.Optional)]
		public string StateOrProvinceOfIssue
		{
			get
			{
				return this.GetStringField(471).Value;
			}
			set
			{
				this.AddStringField(471, value);
			}
		}

		// Token: 0x17000FAC RID: 4012
		// (get) Token: 0x060022B4 RID: 8884 RVA: 0x0002540B File Offset: 0x0002440B
		// (set) Token: 0x060022B5 RID: 8885 RVA: 0x0002541D File Offset: 0x0002441D
		[FIXField("472", EFieldOption.Optional)]
		public string LocaleOfIssue
		{
			get
			{
				return this.GetStringField(472).Value;
			}
			set
			{
				this.AddStringField(472, value);
			}
		}

		// Token: 0x17000FAD RID: 4013
		// (get) Token: 0x060022B6 RID: 8886 RVA: 0x0002542B File Offset: 0x0002442B
		// (set) Token: 0x060022B7 RID: 8887 RVA: 0x0002543D File Offset: 0x0002443D
		[FIXField("240", EFieldOption.Optional)]
		public DateTime RedemptionDate
		{
			get
			{
				return this.GetDateTimeField(240).Value;
			}
			set
			{
				this.AddDateTimeField(240, value);
			}
		}

		// Token: 0x17000FAE RID: 4014
		// (get) Token: 0x060022B8 RID: 8888 RVA: 0x0002544B File Offset: 0x0002444B
		// (set) Token: 0x060022B9 RID: 8889 RVA: 0x0002545D File Offset: 0x0002445D
		[FIXField("202", EFieldOption.Optional)]
		public double StrikePrice
		{
			get
			{
				return this.GetDoubleField(202).Value;
			}
			set
			{
				this.AddDoubleField(202, value);
			}
		}

		// Token: 0x17000FAF RID: 4015
		// (get) Token: 0x060022BA RID: 8890 RVA: 0x0002546B File Offset: 0x0002446B
		// (set) Token: 0x060022BB RID: 8891 RVA: 0x0002547D File Offset: 0x0002447D
		[FIXField("947", EFieldOption.Optional)]
		public double StrikeCurrency
		{
			get
			{
				return this.GetDoubleField(947).Value;
			}
			set
			{
				this.AddDoubleField(947, value);
			}
		}

		// Token: 0x17000FB0 RID: 4016
		// (get) Token: 0x060022BC RID: 8892 RVA: 0x0002548B File Offset: 0x0002448B
		// (set) Token: 0x060022BD RID: 8893 RVA: 0x0002549D File Offset: 0x0002449D
		[FIXField("206", EFieldOption.Optional)]
		public char OptAttribute
		{
			get
			{
				return this.GetCharField(206).Value;
			}
			set
			{
				this.AddCharField(206, value);
			}
		}

		// Token: 0x17000FB1 RID: 4017
		// (get) Token: 0x060022BE RID: 8894 RVA: 0x000254AB File Offset: 0x000244AB
		// (set) Token: 0x060022BF RID: 8895 RVA: 0x000254BD File Offset: 0x000244BD
		[FIXField("231", EFieldOption.Optional)]
		public double ContractMultiplier
		{
			get
			{
				return this.GetDoubleField(231).Value;
			}
			set
			{
				this.AddDoubleField(231, value);
			}
		}

		// Token: 0x17000FB2 RID: 4018
		// (get) Token: 0x060022C0 RID: 8896 RVA: 0x000254CB File Offset: 0x000244CB
		// (set) Token: 0x060022C1 RID: 8897 RVA: 0x000254DD File Offset: 0x000244DD
		[FIXField("223", EFieldOption.Optional)]
		public double CouponRate
		{
			get
			{
				return this.GetDoubleField(223).Value;
			}
			set
			{
				this.AddDoubleField(223, value);
			}
		}

		// Token: 0x17000FB3 RID: 4019
		// (get) Token: 0x060022C2 RID: 8898 RVA: 0x000254EB File Offset: 0x000244EB
		// (set) Token: 0x060022C3 RID: 8899 RVA: 0x000254FD File Offset: 0x000244FD
		[FIXField("207", EFieldOption.Optional)]
		public string SecurityExchange
		{
			get
			{
				return this.GetStringField(207).Value;
			}
			set
			{
				this.AddStringField(207, value);
			}
		}

		// Token: 0x17000FB4 RID: 4020
		// (get) Token: 0x060022C4 RID: 8900 RVA: 0x0002550B File Offset: 0x0002450B
		// (set) Token: 0x060022C5 RID: 8901 RVA: 0x0002551A File Offset: 0x0002451A
		[FIXField("106", EFieldOption.Optional)]
		public string Issuer
		{
			get
			{
				return this.GetStringField(106).Value;
			}
			set
			{
				this.AddStringField(106, value);
			}
		}

		// Token: 0x17000FB5 RID: 4021
		// (get) Token: 0x060022C6 RID: 8902 RVA: 0x00025525 File Offset: 0x00024525
		// (set) Token: 0x060022C7 RID: 8903 RVA: 0x00025537 File Offset: 0x00024537
		[FIXField("348", EFieldOption.Optional)]
		public int EncodedIssuerLen
		{
			get
			{
				return this.GetIntField(348).Value;
			}
			set
			{
				this.AddIntField(348, value);
			}
		}

		// Token: 0x17000FB6 RID: 4022
		// (get) Token: 0x060022C8 RID: 8904 RVA: 0x00025545 File Offset: 0x00024545
		// (set) Token: 0x060022C9 RID: 8905 RVA: 0x00025557 File Offset: 0x00024557
		[FIXField("349", EFieldOption.Optional)]
		public string EncodedIssuer
		{
			get
			{
				return this.GetStringField(349).Value;
			}
			set
			{
				this.AddStringField(349, value);
			}
		}

		// Token: 0x17000FB7 RID: 4023
		// (get) Token: 0x060022CA RID: 8906 RVA: 0x00025565 File Offset: 0x00024565
		// (set) Token: 0x060022CB RID: 8907 RVA: 0x00025574 File Offset: 0x00024574
		[FIXField("107", EFieldOption.Optional)]
		public string SecurityDesc
		{
			get
			{
				return this.GetStringField(107).Value;
			}
			set
			{
				this.AddStringField(107, value);
			}
		}

		// Token: 0x17000FB8 RID: 4024
		// (get) Token: 0x060022CC RID: 8908 RVA: 0x0002557F File Offset: 0x0002457F
		// (set) Token: 0x060022CD RID: 8909 RVA: 0x00025591 File Offset: 0x00024591
		[FIXField("350", EFieldOption.Optional)]
		public int EncodedSecurityDescLen
		{
			get
			{
				return this.GetIntField(350).Value;
			}
			set
			{
				this.AddIntField(350, value);
			}
		}

		// Token: 0x17000FB9 RID: 4025
		// (get) Token: 0x060022CE RID: 8910 RVA: 0x0002559F File Offset: 0x0002459F
		// (set) Token: 0x060022CF RID: 8911 RVA: 0x000255B1 File Offset: 0x000245B1
		[FIXField("351", EFieldOption.Optional)]
		public string EncodedSecurityDesc
		{
			get
			{
				return this.GetStringField(351).Value;
			}
			set
			{
				this.AddStringField(351, value);
			}
		}

		// Token: 0x17000FBA RID: 4026
		// (get) Token: 0x060022D0 RID: 8912 RVA: 0x000255BF File Offset: 0x000245BF
		// (set) Token: 0x060022D1 RID: 8913 RVA: 0x000255D1 File Offset: 0x000245D1
		[FIXField("691", EFieldOption.Optional)]
		public string Pool
		{
			get
			{
				return this.GetStringField(691).Value;
			}
			set
			{
				this.AddStringField(691, value);
			}
		}

		// Token: 0x17000FBB RID: 4027
		// (get) Token: 0x060022D2 RID: 8914 RVA: 0x000255DF File Offset: 0x000245DF
		// (set) Token: 0x060022D3 RID: 8915 RVA: 0x000255F1 File Offset: 0x000245F1
		[FIXField("667", EFieldOption.Optional)]
		public string ContractSettlMonth
		{
			get
			{
				return this.GetStringField(667).Value;
			}
			set
			{
				this.AddStringField(667, value);
			}
		}

		// Token: 0x17000FBC RID: 4028
		// (get) Token: 0x060022D4 RID: 8916 RVA: 0x000255FF File Offset: 0x000245FF
		// (set) Token: 0x060022D5 RID: 8917 RVA: 0x00025611 File Offset: 0x00024611
		[FIXField("875", EFieldOption.Optional)]
		public int CPProgram
		{
			get
			{
				return this.GetIntField(875).Value;
			}
			set
			{
				this.AddIntField(875, value);
			}
		}

		// Token: 0x17000FBD RID: 4029
		// (get) Token: 0x060022D6 RID: 8918 RVA: 0x0002561F File Offset: 0x0002461F
		// (set) Token: 0x060022D7 RID: 8919 RVA: 0x00025631 File Offset: 0x00024631
		[FIXField("876", EFieldOption.Optional)]
		public string CPRegType
		{
			get
			{
				return this.GetStringField(876).Value;
			}
			set
			{
				this.AddStringField(876, value);
			}
		}

		// Token: 0x17000FBE RID: 4030
		// (get) Token: 0x060022D8 RID: 8920 RVA: 0x0002563F File Offset: 0x0002463F
		// (set) Token: 0x060022D9 RID: 8921 RVA: 0x00025651 File Offset: 0x00024651
		[FIXField("864", EFieldOption.Optional)]
		public int NoEvents
		{
			get
			{
				return this.GetIntField(864).Value;
			}
			set
			{
				this.AddIntField(864, value);
			}
		}

		// Token: 0x060022DA RID: 8922 RVA: 0x0002565F File Offset: 0x0002465F
		public FIXEventsGroup GetEventsGroup(int i)
		{
			if (i < this.NoEvents)
			{
				return (FIXEventsGroup)this.fEventsGroup[i];
			}
			return null;
		}

		// Token: 0x060022DB RID: 8923 RVA: 0x0002567D File Offset: 0x0002467D
		public void AddGroup(FIXEventsGroup group)
		{
			this.fEventsGroup.Add(group);
			this.NoEvents++;
		}

		// Token: 0x17000FBF RID: 4031
		// (get) Token: 0x060022DC RID: 8924 RVA: 0x0002569A File Offset: 0x0002469A
		// (set) Token: 0x060022DD RID: 8925 RVA: 0x000256AC File Offset: 0x000246AC
		[FIXField("873", EFieldOption.Optional)]
		public DateTime DatedDate
		{
			get
			{
				return this.GetDateTimeField(873).Value;
			}
			set
			{
				this.AddDateTimeField(873, value);
			}
		}

		// Token: 0x17000FC0 RID: 4032
		// (get) Token: 0x060022DE RID: 8926 RVA: 0x000256BA File Offset: 0x000246BA
		// (set) Token: 0x060022DF RID: 8927 RVA: 0x000256CC File Offset: 0x000246CC
		[FIXField("874", EFieldOption.Optional)]
		public DateTime InterestAccrualDate
		{
			get
			{
				return this.GetDateTimeField(874).Value;
			}
			set
			{
				this.AddDateTimeField(874, value);
			}
		}

		// Token: 0x17000FC1 RID: 4033
		// (get) Token: 0x060022E0 RID: 8928 RVA: 0x000256DA File Offset: 0x000246DA
		// (set) Token: 0x060022E1 RID: 8929 RVA: 0x000256EC File Offset: 0x000246EC
		[FIXField("913", EFieldOption.Optional)]
		public string AgreementDesc
		{
			get
			{
				return this.GetStringField(913).Value;
			}
			set
			{
				this.AddStringField(913, value);
			}
		}

		// Token: 0x17000FC2 RID: 4034
		// (get) Token: 0x060022E2 RID: 8930 RVA: 0x000256FA File Offset: 0x000246FA
		// (set) Token: 0x060022E3 RID: 8931 RVA: 0x0002570C File Offset: 0x0002470C
		[FIXField("914", EFieldOption.Optional)]
		public string AgreementID
		{
			get
			{
				return this.GetStringField(914).Value;
			}
			set
			{
				this.AddStringField(914, value);
			}
		}

		// Token: 0x17000FC3 RID: 4035
		// (get) Token: 0x060022E4 RID: 8932 RVA: 0x0002571A File Offset: 0x0002471A
		// (set) Token: 0x060022E5 RID: 8933 RVA: 0x0002572C File Offset: 0x0002472C
		[FIXField("915", EFieldOption.Optional)]
		public DateTime AgreementDate
		{
			get
			{
				return this.GetDateTimeField(915).Value;
			}
			set
			{
				this.AddDateTimeField(915, value);
			}
		}

		// Token: 0x17000FC4 RID: 4036
		// (get) Token: 0x060022E6 RID: 8934 RVA: 0x0002573A File Offset: 0x0002473A
		// (set) Token: 0x060022E7 RID: 8935 RVA: 0x0002574C File Offset: 0x0002474C
		[FIXField("918", EFieldOption.Optional)]
		public double AgreementCurrency
		{
			get
			{
				return this.GetDoubleField(918).Value;
			}
			set
			{
				this.AddDoubleField(918, value);
			}
		}

		// Token: 0x17000FC5 RID: 4037
		// (get) Token: 0x060022E8 RID: 8936 RVA: 0x0002575A File Offset: 0x0002475A
		// (set) Token: 0x060022E9 RID: 8937 RVA: 0x0002576C File Offset: 0x0002476C
		[FIXField("788", EFieldOption.Optional)]
		public int TerminationType
		{
			get
			{
				return this.GetIntField(788).Value;
			}
			set
			{
				this.AddIntField(788, value);
			}
		}

		// Token: 0x17000FC6 RID: 4038
		// (get) Token: 0x060022EA RID: 8938 RVA: 0x0002577A File Offset: 0x0002477A
		// (set) Token: 0x060022EB RID: 8939 RVA: 0x0002578C File Offset: 0x0002478C
		[FIXField("916", EFieldOption.Optional)]
		public DateTime StartDate
		{
			get
			{
				return this.GetDateTimeField(916).Value;
			}
			set
			{
				this.AddDateTimeField(916, value);
			}
		}

		// Token: 0x17000FC7 RID: 4039
		// (get) Token: 0x060022EC RID: 8940 RVA: 0x0002579A File Offset: 0x0002479A
		// (set) Token: 0x060022ED RID: 8941 RVA: 0x000257AC File Offset: 0x000247AC
		[FIXField("917", EFieldOption.Optional)]
		public DateTime EndDate
		{
			get
			{
				return this.GetDateTimeField(917).Value;
			}
			set
			{
				this.AddDateTimeField(917, value);
			}
		}

		// Token: 0x17000FC8 RID: 4040
		// (get) Token: 0x060022EE RID: 8942 RVA: 0x000257BA File Offset: 0x000247BA
		// (set) Token: 0x060022EF RID: 8943 RVA: 0x000257CC File Offset: 0x000247CC
		[FIXField("919", EFieldOption.Optional)]
		public int DeliveryType
		{
			get
			{
				return this.GetIntField(919).Value;
			}
			set
			{
				this.AddIntField(919, value);
			}
		}

		// Token: 0x17000FC9 RID: 4041
		// (get) Token: 0x060022F0 RID: 8944 RVA: 0x000257DA File Offset: 0x000247DA
		// (set) Token: 0x060022F1 RID: 8945 RVA: 0x000257EC File Offset: 0x000247EC
		[FIXField("898", EFieldOption.Optional)]
		public double MarginRatio
		{
			get
			{
				return this.GetDoubleField(898).Value;
			}
			set
			{
				this.AddDoubleField(898, value);
			}
		}

		// Token: 0x17000FCA RID: 4042
		// (get) Token: 0x060022F2 RID: 8946 RVA: 0x000257FA File Offset: 0x000247FA
		// (set) Token: 0x060022F3 RID: 8947 RVA: 0x0002580C File Offset: 0x0002480C
		[FIXField("711", EFieldOption.Optional)]
		public int NoUnderlyings
		{
			get
			{
				return this.GetIntField(711).Value;
			}
			set
			{
				this.AddIntField(711, value);
			}
		}

		// Token: 0x060022F4 RID: 8948 RVA: 0x0002581A File Offset: 0x0002481A
		public FIXUnderlyingsGroup GetUnderlyingsGroup(int i)
		{
			if (i < this.NoUnderlyings)
			{
				return (FIXUnderlyingsGroup)this.fUnderlyingsGroup[i];
			}
			return null;
		}

		// Token: 0x060022F5 RID: 8949 RVA: 0x00025838 File Offset: 0x00024838
		public void AddGroup(FIXUnderlyingsGroup group)
		{
			this.fUnderlyingsGroup.Add(group);
			this.NoUnderlyings++;
		}

		// Token: 0x17000FCB RID: 4043
		// (get) Token: 0x060022F6 RID: 8950 RVA: 0x00025855 File Offset: 0x00024855
		// (set) Token: 0x060022F7 RID: 8951 RVA: 0x00025864 File Offset: 0x00024864
		[FIXField("54", EFieldOption.Required)]
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

		// Token: 0x17000FCC RID: 4044
		// (get) Token: 0x060022F8 RID: 8952 RVA: 0x0002586F File Offset: 0x0002486F
		// (set) Token: 0x060022F9 RID: 8953 RVA: 0x0002587E File Offset: 0x0002487E
		[FIXField("10", EFieldOption.Required)]
		public string CheckSum
		{
			get
			{
				return this.GetStringField(10).Value;
			}
			set
			{
				this.AddStringField(10, value);
			}
		}

		// Token: 0x17000FCD RID: 4045
		// (get) Token: 0x060022FA RID: 8954 RVA: 0x00025889 File Offset: 0x00024889
		// (set) Token: 0x060022FB RID: 8955 RVA: 0x00025898 File Offset: 0x00024898
		[FIXField("89", EFieldOption.Optional)]
		public string Signature
		{
			get
			{
				return this.GetStringField(89).Value;
			}
			set
			{
				this.AddStringField(89, value);
			}
		}

		// Token: 0x17000FCE RID: 4046
		// (get) Token: 0x060022FC RID: 8956 RVA: 0x000258A3 File Offset: 0x000248A3
		// (set) Token: 0x060022FD RID: 8957 RVA: 0x000258B2 File Offset: 0x000248B2
		[FIXField("93", EFieldOption.Optional)]
		public int SignatureLength
		{
			get
			{
				return this.GetIntField(93).Value;
			}
			set
			{
				this.AddIntField(93, value);
			}
		}

		// Token: 0x060022FE RID: 8958 RVA: 0x000258C0 File Offset: 0x000248C0
		public FIXOrderStatusRequest()
		{
		}

		// Token: 0x060022FF RID: 8959 RVA: 0x00025918 File Offset: 0x00024918
		public FIXOrderStatusRequest(string ClOrdID, char Side)
		{
			this.ClOrdID = ClOrdID;
			this.Side = Side;
		}

		// Token: 0x04000341 RID: 833
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x04000342 RID: 834
		private ArrayList fHopsGroup = new ArrayList();

		// Token: 0x04000343 RID: 835
		private ArrayList fPartyIDsGroup = new ArrayList();

		// Token: 0x04000344 RID: 836
		private ArrayList fSecurityAltIDGroup = new ArrayList();

		// Token: 0x04000345 RID: 837
		private ArrayList fEventsGroup = new ArrayList();

		// Token: 0x04000346 RID: 838
		private ArrayList fUnderlyingsGroup = new ArrayList();
	}
}
