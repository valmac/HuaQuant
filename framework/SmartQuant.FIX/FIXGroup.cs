using System;
using System.Collections;
using System.ComponentModel;

namespace SmartQuant.FIX
{
	// Token: 0x02000003 RID: 3
	public class FIXGroup
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002070 File Offset: 0x00001070
		// (set) Token: 0x06000005 RID: 5 RVA: 0x00002078 File Offset: 0x00001078
		[Browsable(false)]
		public int Id
		{
			get
			{
				return this.fId;
			}
			set
			{
				this.fId = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002081 File Offset: 0x00001081
		[Browsable(false)]
		public virtual int Tag
		{
			get
			{
				return -1;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002084 File Offset: 0x00001084
		[Browsable(false)]
		public Hashtable Fields
		{
			get
			{
				return this.fFields;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000008 RID: 8 RVA: 0x0000208C File Offset: 0x0000108C
		[Browsable(false)]
		public FIXGroupTable Groups
		{
			get
			{
				return this.fGroups;
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000020BC File Offset: 0x000010BC
		public FIXGroup Group(int tag)
		{
			if (tag == 454)
			{
				return new FIXSecurityAltIDGroup();
			}
			if (tag == 534)
			{
				return new FIXAffectedOrdersGroup();
			}
			throw new ArgumentException("Can not create group for unknown NumInGroup tag : " + tag);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000020FC File Offset: 0x000010FC
		public virtual bool ContainsField(int Tag)
		{
			return this.fFields.Contains(Tag);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000210F File Offset: 0x0000110F
		public virtual void RemoveField(int Tag)
		{
			this.fFields.Remove(Tag);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002122 File Offset: 0x00001122
		public virtual void Clear()
		{
			this.fFields.Clear();
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000212F File Offset: 0x0000112F
		public virtual void AddField(FIXField Field)
		{
			this.fFields.Remove(Field.Tag);
			this.fFields.Add(Field.Tag, Field);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002160 File Offset: 0x00001160
		public virtual void AddField(int Tag, object Value)
		{
			if (Value is char)
			{
				this.AddCharField(Tag, (char)Value);
				return;
			}
			if (Value is int)
			{
				this.AddIntField(Tag, (int)Value);
				return;
			}
			if (Value is double)
			{
				this.AddDoubleField(Tag, (double)Value);
				return;
			}
			if (Value is bool)
			{
				this.AddBoolField(Tag, (bool)Value);
				return;
			}
			if (Value is string)
			{
				this.AddStringField(Tag, (string)Value);
				return;
			}
			if (Value is DateTime)
			{
				this.AddDateTimeField(Tag, (DateTime)Value);
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000021F0 File Offset: 0x000011F0
		public virtual void AddStringField(int Tag, string Value)
		{
			this.AddField(new FIXStringField(Tag, Value));
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000021FF File Offset: 0x000011FF
		public virtual void AddCharField(int Tag, char Value)
		{
			this.AddField(new FIXCharField(Tag, Value));
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000220E File Offset: 0x0000120E
		public virtual void AddBoolField(int Tag, bool Value)
		{
			this.AddField(new FIXBoolField(Tag, Value));
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0000221D File Offset: 0x0000121D
		public virtual void AddIntField(int Tag, int Value)
		{
			this.AddField(new FIXIntField(Tag, Value));
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0000222C File Offset: 0x0000122C
		public virtual void AddDoubleField(int Tag, double Value)
		{
			this.AddField(new FIXDoubleField(Tag, Value));
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000223B File Offset: 0x0000123B
		public virtual void AddDateTimeField(int Tag, DateTime Value)
		{
			this.AddField(new FIXDateTimeField(Tag, Value));
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000224A File Offset: 0x0000124A
		public virtual void AddNumInGroupField(int Tag, int Value)
		{
			this.AddField(new FIXNumInGroupField(Tag, Value));
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000225C File Offset: 0x0000125C
		public virtual void AddFields(FIXGroup From)
		{
			foreach (object obj in From.Fields.Values)
			{
				FIXField field = (FIXField)obj;
				this.AddField(field);
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000022BC File Offset: 0x000012BC
		public virtual FIXField GetField(int Tag)
		{
			return (FIXField)this.fFields[Tag];
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000022D4 File Offset: 0x000012D4
		public virtual FIXStringField GetStringField(int Tag)
		{
			return (FIXStringField)this.fFields[Tag];
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000022EC File Offset: 0x000012EC
		public virtual FIXCharField GetCharField(int Tag)
		{
			return (FIXCharField)this.fFields[Tag];
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002304 File Offset: 0x00001304
		public virtual FIXBoolField GetBoolField(int Tag)
		{
			return (FIXBoolField)this.fFields[Tag];
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000231C File Offset: 0x0000131C
		public virtual FIXIntField GetIntField(int Tag)
		{
			return (FIXIntField)this.fFields[Tag];
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002334 File Offset: 0x00001334
		public virtual FIXDoubleField GetDoubleField(int Tag)
		{
			return (FIXDoubleField)this.fFields[Tag];
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000234C File Offset: 0x0000134C
		public virtual FIXDateTimeField GetDateTimeField(int Tag)
		{
			return (FIXDateTimeField)this.fFields[Tag];
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002364 File Offset: 0x00001364
		public virtual FIXNumInGroupField GetNumInGroupField(int Tag)
		{
			return (FIXNumInGroupField)this.fFields[Tag];
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000237C File Offset: 0x0000137C
		public virtual object GetValue(int tag)
		{
			return this.fFields[tag];
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002390 File Offset: 0x00001390
		public virtual bool GetBoolValue(int Tag)
		{
			FIXBoolField boolField = this.GetBoolField(Tag);
			return boolField != null && boolField.Value;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000023B0 File Offset: 0x000013B0
		public virtual int GetIntValue(int Tag)
		{
			FIXIntField intField = this.GetIntField(Tag);
			if (intField == null)
			{
				return 0;
			}
			return intField.Value;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000023D0 File Offset: 0x000013D0
		public virtual double GetDoubleValue(int Tag)
		{
			FIXDoubleField doubleField = this.GetDoubleField(Tag);
			if (doubleField == null)
			{
				return 0.0;
			}
			return doubleField.Value;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000023F8 File Offset: 0x000013F8
		public virtual char GetCharValue(int Tag)
		{
			FIXCharField charField = this.GetCharField(Tag);
			if (charField == null)
			{
				return '\0';
			}
			return charField.Value;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002418 File Offset: 0x00001418
		public virtual string GetStringValue(int Tag)
		{
			FIXStringField stringField = this.GetStringField(Tag);
			if (stringField == null)
			{
				return "";
			}
			return stringField.Value;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000243C File Offset: 0x0000143C
		public virtual DateTime GetDateTimeValue(int Tag)
		{
			FIXDateTimeField dateTimeField = this.GetDateTimeField(Tag);
			if (dateTimeField == null)
			{
				return new DateTime(0L);
			}
			return dateTimeField.Value;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002464 File Offset: 0x00001464
		public virtual int GetNumInGroupValue(int Tag)
		{
			FIXNumInGroupField numInGroupField = this.GetNumInGroupField(Tag);
			if (numInGroupField == null)
			{
				return 0;
			}
			return numInGroupField.Value;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002484 File Offset: 0x00001484
		public virtual void SetBoolValue(int Tag, bool Value)
		{
			this.AddBoolField(Tag, Value);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000248E File Offset: 0x0000148E
		public virtual void SetIntValue(int Tag, int Value)
		{
			this.AddIntField(Tag, Value);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002498 File Offset: 0x00001498
		public virtual void SetDoubleValue(int Tag, double Value)
		{
			this.AddDoubleField(Tag, Value);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000024A2 File Offset: 0x000014A2
		public virtual void SetCharValue(int Tag, char Value)
		{
			this.AddCharField(Tag, Value);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000024AC File Offset: 0x000014AC
		public virtual void SetStringValue(int Tag, string Value)
		{
			this.AddStringField(Tag, Value);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000024B6 File Offset: 0x000014B6
		public virtual void SetDateTimeValue(int Tag, DateTime Value)
		{
			this.AddDateTimeField(Tag, Value);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000024C0 File Offset: 0x000014C0
		public virtual void SetNumInGroupValue(int Tag, int Value)
		{
			this.AddNumInGroupField(Tag, Value);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000024CC File Offset: 0x000014CC
		public override string ToString()
		{
			string text = "";
			foreach (object obj in this.Fields.Values)
			{
				FIXField fixfield = (FIXField)obj;
				string text2 = text;
				text = string.Concat(new string[]
				{
					text2,
					EFIXField.ToString(fixfield.Tag),
					"=",
					fixfield.ToString(),
					";"
				});
			}
			if (text != "")
			{
				text = text.Remove(text.Length - 1, 1);
			}
			return text;
		}

		// Token: 0x04000002 RID: 2
		protected int fId = -1;

		// Token: 0x04000003 RID: 3
		protected Hashtable fFields = new Hashtable();

		// Token: 0x04000004 RID: 4
		protected FIXGroupTable fGroups = new FIXGroupTable();
	}
}
