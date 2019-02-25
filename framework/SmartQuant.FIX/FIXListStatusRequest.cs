using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000170 RID: 368
	public class FIXListStatusRequest : FIXMessage
	{
		// Token: 0x17001EFC RID: 7932
		// (get) Token: 0x060044B8 RID: 17592 RVA: 0x0004C5F3 File Offset: 0x0004B5F3
		// (set) Token: 0x060044B9 RID: 17593 RVA: 0x0004C605 File Offset: 0x0004B605
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

		// Token: 0x17001EFD RID: 7933
		// (get) Token: 0x060044BA RID: 17594 RVA: 0x0004C613 File Offset: 0x0004B613
		// (set) Token: 0x060044BB RID: 17595 RVA: 0x0004C622 File Offset: 0x0004B622
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

		// Token: 0x17001EFE RID: 7934
		// (get) Token: 0x060044BC RID: 17596 RVA: 0x0004C62D File Offset: 0x0004B62D
		// (set) Token: 0x060044BD RID: 17597 RVA: 0x0004C63C File Offset: 0x0004B63C
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

		// Token: 0x17001EFF RID: 7935
		// (get) Token: 0x060044BE RID: 17598 RVA: 0x0004C647 File Offset: 0x0004B647
		// (set) Token: 0x060044BF RID: 17599 RVA: 0x0004C656 File Offset: 0x0004B656
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

		// Token: 0x17001F00 RID: 7936
		// (get) Token: 0x060044C0 RID: 17600 RVA: 0x0004C661 File Offset: 0x0004B661
		// (set) Token: 0x060044C1 RID: 17601 RVA: 0x0004C670 File Offset: 0x0004B670
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

		// Token: 0x17001F01 RID: 7937
		// (get) Token: 0x060044C2 RID: 17602 RVA: 0x0004C67B File Offset: 0x0004B67B
		// (set) Token: 0x060044C3 RID: 17603 RVA: 0x0004C68A File Offset: 0x0004B68A
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

		// Token: 0x17001F02 RID: 7938
		// (get) Token: 0x060044C4 RID: 17604 RVA: 0x0004C695 File Offset: 0x0004B695
		// (set) Token: 0x060044C5 RID: 17605 RVA: 0x0004C6A7 File Offset: 0x0004B6A7
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

		// Token: 0x17001F03 RID: 7939
		// (get) Token: 0x060044C6 RID: 17606 RVA: 0x0004C6B5 File Offset: 0x0004B6B5
		// (set) Token: 0x060044C7 RID: 17607 RVA: 0x0004C6C4 File Offset: 0x0004B6C4
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

		// Token: 0x17001F04 RID: 7940
		// (get) Token: 0x060044C8 RID: 17608 RVA: 0x0004C6CF File Offset: 0x0004B6CF
		// (set) Token: 0x060044C9 RID: 17609 RVA: 0x0004C6DE File Offset: 0x0004B6DE
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

		// Token: 0x17001F05 RID: 7941
		// (get) Token: 0x060044CA RID: 17610 RVA: 0x0004C6E9 File Offset: 0x0004B6E9
		// (set) Token: 0x060044CB RID: 17611 RVA: 0x0004C6F8 File Offset: 0x0004B6F8
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

		// Token: 0x17001F06 RID: 7942
		// (get) Token: 0x060044CC RID: 17612 RVA: 0x0004C703 File Offset: 0x0004B703
		// (set) Token: 0x060044CD RID: 17613 RVA: 0x0004C712 File Offset: 0x0004B712
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

		// Token: 0x17001F07 RID: 7943
		// (get) Token: 0x060044CE RID: 17614 RVA: 0x0004C71D File Offset: 0x0004B71D
		// (set) Token: 0x060044CF RID: 17615 RVA: 0x0004C72F File Offset: 0x0004B72F
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

		// Token: 0x17001F08 RID: 7944
		// (get) Token: 0x060044D0 RID: 17616 RVA: 0x0004C73D File Offset: 0x0004B73D
		// (set) Token: 0x060044D1 RID: 17617 RVA: 0x0004C74C File Offset: 0x0004B74C
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

		// Token: 0x17001F09 RID: 7945
		// (get) Token: 0x060044D2 RID: 17618 RVA: 0x0004C757 File Offset: 0x0004B757
		// (set) Token: 0x060044D3 RID: 17619 RVA: 0x0004C765 File Offset: 0x0004B765
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

		// Token: 0x17001F0A RID: 7946
		// (get) Token: 0x060044D4 RID: 17620 RVA: 0x0004C76F File Offset: 0x0004B76F
		// (set) Token: 0x060044D5 RID: 17621 RVA: 0x0004C77E File Offset: 0x0004B77E
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

		// Token: 0x060044D6 RID: 17622 RVA: 0x0004C789 File Offset: 0x0004B789
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x060044D7 RID: 17623 RVA: 0x0004C79C File Offset: 0x0004B79C
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17001F0B RID: 7947
		// (get) Token: 0x060044D8 RID: 17624 RVA: 0x0004C7AB File Offset: 0x0004B7AB
		// (set) Token: 0x060044D9 RID: 17625 RVA: 0x0004C7BD File Offset: 0x0004B7BD
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

		// Token: 0x17001F0C RID: 7948
		// (get) Token: 0x060044DA RID: 17626 RVA: 0x0004C7CB File Offset: 0x0004B7CB
		// (set) Token: 0x060044DB RID: 17627 RVA: 0x0004C7DD File Offset: 0x0004B7DD
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

		// Token: 0x17001F0D RID: 7949
		// (get) Token: 0x060044DC RID: 17628 RVA: 0x0004C7EB File Offset: 0x0004B7EB
		// (set) Token: 0x060044DD RID: 17629 RVA: 0x0004C7FA File Offset: 0x0004B7FA
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

		// Token: 0x17001F0E RID: 7950
		// (get) Token: 0x060044DE RID: 17630 RVA: 0x0004C805 File Offset: 0x0004B805
		// (set) Token: 0x060044DF RID: 17631 RVA: 0x0004C814 File Offset: 0x0004B814
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

		// Token: 0x17001F0F RID: 7951
		// (get) Token: 0x060044E0 RID: 17632 RVA: 0x0004C81F File Offset: 0x0004B81F
		// (set) Token: 0x060044E1 RID: 17633 RVA: 0x0004C82E File Offset: 0x0004B82E
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

		// Token: 0x17001F10 RID: 7952
		// (get) Token: 0x060044E2 RID: 17634 RVA: 0x0004C839 File Offset: 0x0004B839
		// (set) Token: 0x060044E3 RID: 17635 RVA: 0x0004C848 File Offset: 0x0004B848
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

		// Token: 0x17001F11 RID: 7953
		// (get) Token: 0x060044E4 RID: 17636 RVA: 0x0004C853 File Offset: 0x0004B853
		// (set) Token: 0x060044E5 RID: 17637 RVA: 0x0004C865 File Offset: 0x0004B865
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

		// Token: 0x17001F12 RID: 7954
		// (get) Token: 0x060044E6 RID: 17638 RVA: 0x0004C873 File Offset: 0x0004B873
		// (set) Token: 0x060044E7 RID: 17639 RVA: 0x0004C885 File Offset: 0x0004B885
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

		// Token: 0x17001F13 RID: 7955
		// (get) Token: 0x060044E8 RID: 17640 RVA: 0x0004C893 File Offset: 0x0004B893
		// (set) Token: 0x060044E9 RID: 17641 RVA: 0x0004C8A5 File Offset: 0x0004B8A5
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

		// Token: 0x17001F14 RID: 7956
		// (get) Token: 0x060044EA RID: 17642 RVA: 0x0004C8B3 File Offset: 0x0004B8B3
		// (set) Token: 0x060044EB RID: 17643 RVA: 0x0004C8C5 File Offset: 0x0004B8C5
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

		// Token: 0x17001F15 RID: 7957
		// (get) Token: 0x060044EC RID: 17644 RVA: 0x0004C8D3 File Offset: 0x0004B8D3
		// (set) Token: 0x060044ED RID: 17645 RVA: 0x0004C8E5 File Offset: 0x0004B8E5
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

		// Token: 0x060044EE RID: 17646 RVA: 0x0004C8F3 File Offset: 0x0004B8F3
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x060044EF RID: 17647 RVA: 0x0004C911 File Offset: 0x0004B911
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x17001F16 RID: 7958
		// (get) Token: 0x060044F0 RID: 17648 RVA: 0x0004C92E File Offset: 0x0004B92E
		// (set) Token: 0x060044F1 RID: 17649 RVA: 0x0004C940 File Offset: 0x0004B940
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

		// Token: 0x17001F17 RID: 7959
		// (get) Token: 0x060044F2 RID: 17650 RVA: 0x0004C94E File Offset: 0x0004B94E
		// (set) Token: 0x060044F3 RID: 17651 RVA: 0x0004C95D File Offset: 0x0004B95D
		[FIXField("66", EFieldOption.Required)]
		public string ListID
		{
			get
			{
				return this.GetStringField(66).Value;
			}
			set
			{
				this.AddStringField(66, value);
			}
		}

		// Token: 0x17001F18 RID: 7960
		// (get) Token: 0x060044F4 RID: 17652 RVA: 0x0004C968 File Offset: 0x0004B968
		// (set) Token: 0x060044F5 RID: 17653 RVA: 0x0004C977 File Offset: 0x0004B977
		[FIXField("58", EFieldOption.Optional)]
		public string Text
		{
			get
			{
				return this.GetStringField(58).Value;
			}
			set
			{
				this.AddStringField(58, value);
			}
		}

		// Token: 0x17001F19 RID: 7961
		// (get) Token: 0x060044F6 RID: 17654 RVA: 0x0004C982 File Offset: 0x0004B982
		// (set) Token: 0x060044F7 RID: 17655 RVA: 0x0004C994 File Offset: 0x0004B994
		[FIXField("354", EFieldOption.Optional)]
		public int EncodedTextLen
		{
			get
			{
				return this.GetIntField(354).Value;
			}
			set
			{
				this.AddIntField(354, value);
			}
		}

		// Token: 0x17001F1A RID: 7962
		// (get) Token: 0x060044F8 RID: 17656 RVA: 0x0004C9A2 File Offset: 0x0004B9A2
		// (set) Token: 0x060044F9 RID: 17657 RVA: 0x0004C9B4 File Offset: 0x0004B9B4
		[FIXField("355", EFieldOption.Optional)]
		public string EncodedText
		{
			get
			{
				return this.GetStringField(355).Value;
			}
			set
			{
				this.AddStringField(355, value);
			}
		}

		// Token: 0x17001F1B RID: 7963
		// (get) Token: 0x060044FA RID: 17658 RVA: 0x0004C9C2 File Offset: 0x0004B9C2
		// (set) Token: 0x060044FB RID: 17659 RVA: 0x0004C9D1 File Offset: 0x0004B9D1
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

		// Token: 0x17001F1C RID: 7964
		// (get) Token: 0x060044FC RID: 17660 RVA: 0x0004C9DC File Offset: 0x0004B9DC
		// (set) Token: 0x060044FD RID: 17661 RVA: 0x0004C9EB File Offset: 0x0004B9EB
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

		// Token: 0x17001F1D RID: 7965
		// (get) Token: 0x060044FE RID: 17662 RVA: 0x0004C9F6 File Offset: 0x0004B9F6
		// (set) Token: 0x060044FF RID: 17663 RVA: 0x0004CA05 File Offset: 0x0004BA05
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

		// Token: 0x06004500 RID: 17664 RVA: 0x0004CA10 File Offset: 0x0004BA10
		public FIXListStatusRequest()
		{
		}

		// Token: 0x06004501 RID: 17665 RVA: 0x0004CA2E File Offset: 0x0004BA2E
		public FIXListStatusRequest(string ListID)
		{
			this.ListID = ListID;
		}

		// Token: 0x04000D70 RID: 3440
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x04000D71 RID: 3441
		private ArrayList fHopsGroup = new ArrayList();
	}
}
