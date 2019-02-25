using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x020000BE RID: 190
	public class FIXUserRequest : FIXMessage
	{
		// Token: 0x1700112D RID: 4397
		// (get) Token: 0x06002608 RID: 9736 RVA: 0x00028A8C File Offset: 0x00027A8C
		// (set) Token: 0x06002609 RID: 9737 RVA: 0x00028A9E File Offset: 0x00027A9E
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

		// Token: 0x1700112E RID: 4398
		// (get) Token: 0x0600260A RID: 9738 RVA: 0x00028AAC File Offset: 0x00027AAC
		// (set) Token: 0x0600260B RID: 9739 RVA: 0x00028ABB File Offset: 0x00027ABB
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

		// Token: 0x1700112F RID: 4399
		// (get) Token: 0x0600260C RID: 9740 RVA: 0x00028AC6 File Offset: 0x00027AC6
		// (set) Token: 0x0600260D RID: 9741 RVA: 0x00028AD5 File Offset: 0x00027AD5
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

		// Token: 0x17001130 RID: 4400
		// (get) Token: 0x0600260E RID: 9742 RVA: 0x00028AE0 File Offset: 0x00027AE0
		// (set) Token: 0x0600260F RID: 9743 RVA: 0x00028AEF File Offset: 0x00027AEF
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

		// Token: 0x17001131 RID: 4401
		// (get) Token: 0x06002610 RID: 9744 RVA: 0x00028AFA File Offset: 0x00027AFA
		// (set) Token: 0x06002611 RID: 9745 RVA: 0x00028B09 File Offset: 0x00027B09
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

		// Token: 0x17001132 RID: 4402
		// (get) Token: 0x06002612 RID: 9746 RVA: 0x00028B14 File Offset: 0x00027B14
		// (set) Token: 0x06002613 RID: 9747 RVA: 0x00028B23 File Offset: 0x00027B23
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

		// Token: 0x17001133 RID: 4403
		// (get) Token: 0x06002614 RID: 9748 RVA: 0x00028B2E File Offset: 0x00027B2E
		// (set) Token: 0x06002615 RID: 9749 RVA: 0x00028B40 File Offset: 0x00027B40
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

		// Token: 0x17001134 RID: 4404
		// (get) Token: 0x06002616 RID: 9750 RVA: 0x00028B4E File Offset: 0x00027B4E
		// (set) Token: 0x06002617 RID: 9751 RVA: 0x00028B5D File Offset: 0x00027B5D
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

		// Token: 0x17001135 RID: 4405
		// (get) Token: 0x06002618 RID: 9752 RVA: 0x00028B68 File Offset: 0x00027B68
		// (set) Token: 0x06002619 RID: 9753 RVA: 0x00028B77 File Offset: 0x00027B77
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

		// Token: 0x17001136 RID: 4406
		// (get) Token: 0x0600261A RID: 9754 RVA: 0x00028B82 File Offset: 0x00027B82
		// (set) Token: 0x0600261B RID: 9755 RVA: 0x00028B91 File Offset: 0x00027B91
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

		// Token: 0x17001137 RID: 4407
		// (get) Token: 0x0600261C RID: 9756 RVA: 0x00028B9C File Offset: 0x00027B9C
		// (set) Token: 0x0600261D RID: 9757 RVA: 0x00028BAB File Offset: 0x00027BAB
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

		// Token: 0x17001138 RID: 4408
		// (get) Token: 0x0600261E RID: 9758 RVA: 0x00028BB6 File Offset: 0x00027BB6
		// (set) Token: 0x0600261F RID: 9759 RVA: 0x00028BC8 File Offset: 0x00027BC8
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

		// Token: 0x17001139 RID: 4409
		// (get) Token: 0x06002620 RID: 9760 RVA: 0x00028BD6 File Offset: 0x00027BD6
		// (set) Token: 0x06002621 RID: 9761 RVA: 0x00028BE5 File Offset: 0x00027BE5
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

		// Token: 0x1700113A RID: 4410
		// (get) Token: 0x06002622 RID: 9762 RVA: 0x00028BF0 File Offset: 0x00027BF0
		// (set) Token: 0x06002623 RID: 9763 RVA: 0x00028BFE File Offset: 0x00027BFE
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

		// Token: 0x1700113B RID: 4411
		// (get) Token: 0x06002624 RID: 9764 RVA: 0x00028C08 File Offset: 0x00027C08
		// (set) Token: 0x06002625 RID: 9765 RVA: 0x00028C17 File Offset: 0x00027C17
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

		// Token: 0x06002626 RID: 9766 RVA: 0x00028C22 File Offset: 0x00027C22
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06002627 RID: 9767 RVA: 0x00028C35 File Offset: 0x00027C35
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x1700113C RID: 4412
		// (get) Token: 0x06002628 RID: 9768 RVA: 0x00028C44 File Offset: 0x00027C44
		// (set) Token: 0x06002629 RID: 9769 RVA: 0x00028C56 File Offset: 0x00027C56
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

		// Token: 0x1700113D RID: 4413
		// (get) Token: 0x0600262A RID: 9770 RVA: 0x00028C64 File Offset: 0x00027C64
		// (set) Token: 0x0600262B RID: 9771 RVA: 0x00028C76 File Offset: 0x00027C76
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

		// Token: 0x1700113E RID: 4414
		// (get) Token: 0x0600262C RID: 9772 RVA: 0x00028C84 File Offset: 0x00027C84
		// (set) Token: 0x0600262D RID: 9773 RVA: 0x00028C93 File Offset: 0x00027C93
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

		// Token: 0x1700113F RID: 4415
		// (get) Token: 0x0600262E RID: 9774 RVA: 0x00028C9E File Offset: 0x00027C9E
		// (set) Token: 0x0600262F RID: 9775 RVA: 0x00028CAD File Offset: 0x00027CAD
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

		// Token: 0x17001140 RID: 4416
		// (get) Token: 0x06002630 RID: 9776 RVA: 0x00028CB8 File Offset: 0x00027CB8
		// (set) Token: 0x06002631 RID: 9777 RVA: 0x00028CC7 File Offset: 0x00027CC7
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

		// Token: 0x17001141 RID: 4417
		// (get) Token: 0x06002632 RID: 9778 RVA: 0x00028CD2 File Offset: 0x00027CD2
		// (set) Token: 0x06002633 RID: 9779 RVA: 0x00028CE1 File Offset: 0x00027CE1
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

		// Token: 0x17001142 RID: 4418
		// (get) Token: 0x06002634 RID: 9780 RVA: 0x00028CEC File Offset: 0x00027CEC
		// (set) Token: 0x06002635 RID: 9781 RVA: 0x00028CFE File Offset: 0x00027CFE
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

		// Token: 0x17001143 RID: 4419
		// (get) Token: 0x06002636 RID: 9782 RVA: 0x00028D0C File Offset: 0x00027D0C
		// (set) Token: 0x06002637 RID: 9783 RVA: 0x00028D1E File Offset: 0x00027D1E
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

		// Token: 0x17001144 RID: 4420
		// (get) Token: 0x06002638 RID: 9784 RVA: 0x00028D2C File Offset: 0x00027D2C
		// (set) Token: 0x06002639 RID: 9785 RVA: 0x00028D3E File Offset: 0x00027D3E
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

		// Token: 0x17001145 RID: 4421
		// (get) Token: 0x0600263A RID: 9786 RVA: 0x00028D4C File Offset: 0x00027D4C
		// (set) Token: 0x0600263B RID: 9787 RVA: 0x00028D5E File Offset: 0x00027D5E
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

		// Token: 0x17001146 RID: 4422
		// (get) Token: 0x0600263C RID: 9788 RVA: 0x00028D6C File Offset: 0x00027D6C
		// (set) Token: 0x0600263D RID: 9789 RVA: 0x00028D7E File Offset: 0x00027D7E
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

		// Token: 0x0600263E RID: 9790 RVA: 0x00028D8C File Offset: 0x00027D8C
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x0600263F RID: 9791 RVA: 0x00028DAA File Offset: 0x00027DAA
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x17001147 RID: 4423
		// (get) Token: 0x06002640 RID: 9792 RVA: 0x00028DC7 File Offset: 0x00027DC7
		// (set) Token: 0x06002641 RID: 9793 RVA: 0x00028DD9 File Offset: 0x00027DD9
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

		// Token: 0x17001148 RID: 4424
		// (get) Token: 0x06002642 RID: 9794 RVA: 0x00028DE7 File Offset: 0x00027DE7
		// (set) Token: 0x06002643 RID: 9795 RVA: 0x00028DF9 File Offset: 0x00027DF9
		[FIXField("923", EFieldOption.Required)]
		public string UserRequestID
		{
			get
			{
				return this.GetStringField(923).Value;
			}
			set
			{
				this.AddStringField(923, value);
			}
		}

		// Token: 0x17001149 RID: 4425
		// (get) Token: 0x06002644 RID: 9796 RVA: 0x00028E07 File Offset: 0x00027E07
		// (set) Token: 0x06002645 RID: 9797 RVA: 0x00028E19 File Offset: 0x00027E19
		[FIXField("924", EFieldOption.Required)]
		public int UserRequestType
		{
			get
			{
				return this.GetIntField(924).Value;
			}
			set
			{
				this.AddIntField(924, value);
			}
		}

		// Token: 0x1700114A RID: 4426
		// (get) Token: 0x06002646 RID: 9798 RVA: 0x00028E27 File Offset: 0x00027E27
		// (set) Token: 0x06002647 RID: 9799 RVA: 0x00028E39 File Offset: 0x00027E39
		[FIXField("553", EFieldOption.Required)]
		public string Username
		{
			get
			{
				return this.GetStringField(553).Value;
			}
			set
			{
				this.AddStringField(553, value);
			}
		}

		// Token: 0x1700114B RID: 4427
		// (get) Token: 0x06002648 RID: 9800 RVA: 0x00028E47 File Offset: 0x00027E47
		// (set) Token: 0x06002649 RID: 9801 RVA: 0x00028E59 File Offset: 0x00027E59
		[FIXField("554", EFieldOption.Optional)]
		public string Password
		{
			get
			{
				return this.GetStringField(554).Value;
			}
			set
			{
				this.AddStringField(554, value);
			}
		}

		// Token: 0x1700114C RID: 4428
		// (get) Token: 0x0600264A RID: 9802 RVA: 0x00028E67 File Offset: 0x00027E67
		// (set) Token: 0x0600264B RID: 9803 RVA: 0x00028E79 File Offset: 0x00027E79
		[FIXField("925", EFieldOption.Optional)]
		public string NewPassword
		{
			get
			{
				return this.GetStringField(925).Value;
			}
			set
			{
				this.AddStringField(925, value);
			}
		}

		// Token: 0x1700114D RID: 4429
		// (get) Token: 0x0600264C RID: 9804 RVA: 0x00028E87 File Offset: 0x00027E87
		// (set) Token: 0x0600264D RID: 9805 RVA: 0x00028E96 File Offset: 0x00027E96
		[FIXField("95", EFieldOption.Optional)]
		public int RawDataLength
		{
			get
			{
				return this.GetIntField(95).Value;
			}
			set
			{
				this.AddIntField(95, value);
			}
		}

		// Token: 0x1700114E RID: 4430
		// (get) Token: 0x0600264E RID: 9806 RVA: 0x00028EA1 File Offset: 0x00027EA1
		// (set) Token: 0x0600264F RID: 9807 RVA: 0x00028EB0 File Offset: 0x00027EB0
		[FIXField("96", EFieldOption.Optional)]
		public string RawData
		{
			get
			{
				return this.GetStringField(96).Value;
			}
			set
			{
				this.AddStringField(96, value);
			}
		}

		// Token: 0x1700114F RID: 4431
		// (get) Token: 0x06002650 RID: 9808 RVA: 0x00028EBB File Offset: 0x00027EBB
		// (set) Token: 0x06002651 RID: 9809 RVA: 0x00028ECA File Offset: 0x00027ECA
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

		// Token: 0x17001150 RID: 4432
		// (get) Token: 0x06002652 RID: 9810 RVA: 0x00028ED5 File Offset: 0x00027ED5
		// (set) Token: 0x06002653 RID: 9811 RVA: 0x00028EE4 File Offset: 0x00027EE4
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

		// Token: 0x17001151 RID: 4433
		// (get) Token: 0x06002654 RID: 9812 RVA: 0x00028EEF File Offset: 0x00027EEF
		// (set) Token: 0x06002655 RID: 9813 RVA: 0x00028EFE File Offset: 0x00027EFE
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

		// Token: 0x06002656 RID: 9814 RVA: 0x00028F09 File Offset: 0x00027F09
		public FIXUserRequest()
		{
		}

		// Token: 0x06002657 RID: 9815 RVA: 0x00028F27 File Offset: 0x00027F27
		public FIXUserRequest(string UserRequestID, int UserRequestType, string Username)
		{
			this.UserRequestID = UserRequestID;
			this.UserRequestType = UserRequestType;
			this.Username = Username;
		}

		// Token: 0x04000398 RID: 920
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x04000399 RID: 921
		private ArrayList fHopsGroup = new ArrayList();
	}
}
