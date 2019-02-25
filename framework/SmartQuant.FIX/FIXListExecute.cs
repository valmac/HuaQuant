using System;
using System.Collections;

namespace SmartQuant.FIX
{
	// Token: 0x02000081 RID: 129
	public class FIXListExecute : FIXMessage
	{
		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x060018F2 RID: 6386 RVA: 0x0001B5A4 File Offset: 0x0001A5A4
		// (set) Token: 0x060018F3 RID: 6387 RVA: 0x0001B5B6 File Offset: 0x0001A5B6
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

		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x060018F4 RID: 6388 RVA: 0x0001B5C4 File Offset: 0x0001A5C4
		// (set) Token: 0x060018F5 RID: 6389 RVA: 0x0001B5D3 File Offset: 0x0001A5D3
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

		// Token: 0x17000B36 RID: 2870
		// (get) Token: 0x060018F6 RID: 6390 RVA: 0x0001B5DE File Offset: 0x0001A5DE
		// (set) Token: 0x060018F7 RID: 6391 RVA: 0x0001B5ED File Offset: 0x0001A5ED
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

		// Token: 0x17000B37 RID: 2871
		// (get) Token: 0x060018F8 RID: 6392 RVA: 0x0001B5F8 File Offset: 0x0001A5F8
		// (set) Token: 0x060018F9 RID: 6393 RVA: 0x0001B607 File Offset: 0x0001A607
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

		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x060018FA RID: 6394 RVA: 0x0001B612 File Offset: 0x0001A612
		// (set) Token: 0x060018FB RID: 6395 RVA: 0x0001B621 File Offset: 0x0001A621
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

		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x060018FC RID: 6396 RVA: 0x0001B62C File Offset: 0x0001A62C
		// (set) Token: 0x060018FD RID: 6397 RVA: 0x0001B63B File Offset: 0x0001A63B
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

		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x060018FE RID: 6398 RVA: 0x0001B646 File Offset: 0x0001A646
		// (set) Token: 0x060018FF RID: 6399 RVA: 0x0001B658 File Offset: 0x0001A658
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

		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x06001900 RID: 6400 RVA: 0x0001B666 File Offset: 0x0001A666
		// (set) Token: 0x06001901 RID: 6401 RVA: 0x0001B675 File Offset: 0x0001A675
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

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x06001902 RID: 6402 RVA: 0x0001B680 File Offset: 0x0001A680
		// (set) Token: 0x06001903 RID: 6403 RVA: 0x0001B68F File Offset: 0x0001A68F
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

		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x06001904 RID: 6404 RVA: 0x0001B69A File Offset: 0x0001A69A
		// (set) Token: 0x06001905 RID: 6405 RVA: 0x0001B6A9 File Offset: 0x0001A6A9
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

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x06001906 RID: 6406 RVA: 0x0001B6B4 File Offset: 0x0001A6B4
		// (set) Token: 0x06001907 RID: 6407 RVA: 0x0001B6C3 File Offset: 0x0001A6C3
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

		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x06001908 RID: 6408 RVA: 0x0001B6CE File Offset: 0x0001A6CE
		// (set) Token: 0x06001909 RID: 6409 RVA: 0x0001B6E0 File Offset: 0x0001A6E0
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

		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x0600190A RID: 6410 RVA: 0x0001B6EE File Offset: 0x0001A6EE
		// (set) Token: 0x0600190B RID: 6411 RVA: 0x0001B6FD File Offset: 0x0001A6FD
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

		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x0600190C RID: 6412 RVA: 0x0001B708 File Offset: 0x0001A708
		// (set) Token: 0x0600190D RID: 6413 RVA: 0x0001B716 File Offset: 0x0001A716
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

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x0600190E RID: 6414 RVA: 0x0001B720 File Offset: 0x0001A720
		// (set) Token: 0x0600190F RID: 6415 RVA: 0x0001B72F File Offset: 0x0001A72F
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

		// Token: 0x06001910 RID: 6416 RVA: 0x0001B73A File Offset: 0x0001A73A
		public FIXHopRefIDGroup GetHopRefIDGroup(int i)
		{
			return (FIXHopRefIDGroup)this.fHopRefIDGroup[i];
		}

		// Token: 0x06001911 RID: 6417 RVA: 0x0001B74D File Offset: 0x0001A74D
		public void AddGroup(FIXHopRefIDGroup group)
		{
			this.fHopRefIDGroup.Add(group);
		}

		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x06001912 RID: 6418 RVA: 0x0001B75C File Offset: 0x0001A75C
		// (set) Token: 0x06001913 RID: 6419 RVA: 0x0001B76E File Offset: 0x0001A76E
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

		// Token: 0x17000B44 RID: 2884
		// (get) Token: 0x06001914 RID: 6420 RVA: 0x0001B77C File Offset: 0x0001A77C
		// (set) Token: 0x06001915 RID: 6421 RVA: 0x0001B78E File Offset: 0x0001A78E
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

		// Token: 0x17000B45 RID: 2885
		// (get) Token: 0x06001916 RID: 6422 RVA: 0x0001B79C File Offset: 0x0001A79C
		// (set) Token: 0x06001917 RID: 6423 RVA: 0x0001B7AB File Offset: 0x0001A7AB
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

		// Token: 0x17000B46 RID: 2886
		// (get) Token: 0x06001918 RID: 6424 RVA: 0x0001B7B6 File Offset: 0x0001A7B6
		// (set) Token: 0x06001919 RID: 6425 RVA: 0x0001B7C5 File Offset: 0x0001A7C5
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

		// Token: 0x17000B47 RID: 2887
		// (get) Token: 0x0600191A RID: 6426 RVA: 0x0001B7D0 File Offset: 0x0001A7D0
		// (set) Token: 0x0600191B RID: 6427 RVA: 0x0001B7DF File Offset: 0x0001A7DF
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

		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x0600191C RID: 6428 RVA: 0x0001B7EA File Offset: 0x0001A7EA
		// (set) Token: 0x0600191D RID: 6429 RVA: 0x0001B7F9 File Offset: 0x0001A7F9
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

		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x0600191E RID: 6430 RVA: 0x0001B804 File Offset: 0x0001A804
		// (set) Token: 0x0600191F RID: 6431 RVA: 0x0001B816 File Offset: 0x0001A816
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

		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x06001920 RID: 6432 RVA: 0x0001B824 File Offset: 0x0001A824
		// (set) Token: 0x06001921 RID: 6433 RVA: 0x0001B836 File Offset: 0x0001A836
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

		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x06001922 RID: 6434 RVA: 0x0001B844 File Offset: 0x0001A844
		// (set) Token: 0x06001923 RID: 6435 RVA: 0x0001B856 File Offset: 0x0001A856
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

		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x06001924 RID: 6436 RVA: 0x0001B864 File Offset: 0x0001A864
		// (set) Token: 0x06001925 RID: 6437 RVA: 0x0001B876 File Offset: 0x0001A876
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

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x06001926 RID: 6438 RVA: 0x0001B884 File Offset: 0x0001A884
		// (set) Token: 0x06001927 RID: 6439 RVA: 0x0001B896 File Offset: 0x0001A896
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

		// Token: 0x06001928 RID: 6440 RVA: 0x0001B8A4 File Offset: 0x0001A8A4
		public FIXHopsGroup GetHopsGroup(int i)
		{
			if (i < this.NoHops)
			{
				return (FIXHopsGroup)this.fHopsGroup[i];
			}
			return null;
		}

		// Token: 0x06001929 RID: 6441 RVA: 0x0001B8C2 File Offset: 0x0001A8C2
		public void AddGroup(FIXHopsGroup group)
		{
			this.fHopsGroup.Add(group);
			this.NoHops++;
		}

		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x0600192A RID: 6442 RVA: 0x0001B8DF File Offset: 0x0001A8DF
		// (set) Token: 0x0600192B RID: 6443 RVA: 0x0001B8F1 File Offset: 0x0001A8F1
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

		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x0600192C RID: 6444 RVA: 0x0001B8FF File Offset: 0x0001A8FF
		// (set) Token: 0x0600192D RID: 6445 RVA: 0x0001B90E File Offset: 0x0001A90E
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

		// Token: 0x17000B50 RID: 2896
		// (get) Token: 0x0600192E RID: 6446 RVA: 0x0001B919 File Offset: 0x0001A919
		// (set) Token: 0x0600192F RID: 6447 RVA: 0x0001B92B File Offset: 0x0001A92B
		[FIXField("391", EFieldOption.Optional)]
		public string ClientBidID
		{
			get
			{
				return this.GetStringField(391).Value;
			}
			set
			{
				this.AddStringField(391, value);
			}
		}

		// Token: 0x17000B51 RID: 2897
		// (get) Token: 0x06001930 RID: 6448 RVA: 0x0001B939 File Offset: 0x0001A939
		// (set) Token: 0x06001931 RID: 6449 RVA: 0x0001B94B File Offset: 0x0001A94B
		[FIXField("390", EFieldOption.Optional)]
		public string BidID
		{
			get
			{
				return this.GetStringField(390).Value;
			}
			set
			{
				this.AddStringField(390, value);
			}
		}

		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x06001932 RID: 6450 RVA: 0x0001B959 File Offset: 0x0001A959
		// (set) Token: 0x06001933 RID: 6451 RVA: 0x0001B968 File Offset: 0x0001A968
		[FIXField("60", EFieldOption.Required)]
		public DateTime TransactTime
		{
			get
			{
				return this.GetDateTimeField(60).Value;
			}
			set
			{
				this.AddDateTimeField(60, value);
			}
		}

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x06001934 RID: 6452 RVA: 0x0001B973 File Offset: 0x0001A973
		// (set) Token: 0x06001935 RID: 6453 RVA: 0x0001B982 File Offset: 0x0001A982
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

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x06001936 RID: 6454 RVA: 0x0001B98D File Offset: 0x0001A98D
		// (set) Token: 0x06001937 RID: 6455 RVA: 0x0001B99F File Offset: 0x0001A99F
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

		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x06001938 RID: 6456 RVA: 0x0001B9AD File Offset: 0x0001A9AD
		// (set) Token: 0x06001939 RID: 6457 RVA: 0x0001B9BF File Offset: 0x0001A9BF
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

		// Token: 0x17000B56 RID: 2902
		// (get) Token: 0x0600193A RID: 6458 RVA: 0x0001B9CD File Offset: 0x0001A9CD
		// (set) Token: 0x0600193B RID: 6459 RVA: 0x0001B9DC File Offset: 0x0001A9DC
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

		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x0600193C RID: 6460 RVA: 0x0001B9E7 File Offset: 0x0001A9E7
		// (set) Token: 0x0600193D RID: 6461 RVA: 0x0001B9F6 File Offset: 0x0001A9F6
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

		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x0600193E RID: 6462 RVA: 0x0001BA01 File Offset: 0x0001AA01
		// (set) Token: 0x0600193F RID: 6463 RVA: 0x0001BA10 File Offset: 0x0001AA10
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

		// Token: 0x06001940 RID: 6464 RVA: 0x0001BA1B File Offset: 0x0001AA1B
		public FIXListExecute()
		{
		}

		// Token: 0x06001941 RID: 6465 RVA: 0x0001BA39 File Offset: 0x0001AA39
		public FIXListExecute(string ListID, DateTime TransactTime)
		{
			this.ListID = ListID;
			this.TransactTime = TransactTime;
		}

		// Token: 0x040002A7 RID: 679
		private ArrayList fHopRefIDGroup = new ArrayList();

		// Token: 0x040002A8 RID: 680
		private ArrayList fHopsGroup = new ArrayList();
	}
}
