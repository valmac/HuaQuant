using System;
using System.ComponentModel;
using System.Text;
using SmartQuant.Series;

namespace SmartQuant.Testing.TesterItems
{
	// Token: 0x02000002 RID: 2
	public class TesterItem
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00001050
		// (remove) Token: 0x06000002 RID: 2 RVA: 0x00002069 File Offset: 0x00001069
		public event TesterComponentNameEventHandler ComponentNameChanged;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000003 RID: 3 RVA: 0x00002082 File Offset: 0x00001082
		// (remove) Token: 0x06000004 RID: 4 RVA: 0x0000209B File Offset: 0x0000109B
		public event TesterItemEventHandler PropertyChanged;

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000005 RID: 5 RVA: 0x000020B4 File Offset: 0x000010B4
		// (set) Token: 0x06000006 RID: 6 RVA: 0x000020BC File Offset: 0x000010BC
		[Category("Properties")]
		[Browsable(false)]
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				if (this.name != value)
				{
					string oldName = this.name;
					this.name = value;
					this.EmitComponentNameChanged(oldName, this.name);
					this.EmitPropertyChanged();
				}
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000007 RID: 7 RVA: 0x000020F8 File Offset: 0x000010F8
		// (set) Token: 0x06000008 RID: 8 RVA: 0x00002100 File Offset: 0x00001100
		[Browsable(false)]
		[Category("Properties")]
		public string Description
		{
			get
			{
				return this.description;
			}
			set
			{
				this.description = value;
				this.EmitPropertyChanged();
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000210F File Offset: 0x0000110F
		public TesterItem()
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000212D File Offset: 0x0000112D
		public TesterItem(string name)
		{
			this.name = name;
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00002152 File Offset: 0x00001152
		[Browsable(false)]
		public virtual double LastValue
		{
			get
			{
				return this.lastValue;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000C RID: 12 RVA: 0x0000215A File Offset: 0x0000115A
		[Browsable(false)]
		public virtual DoubleSeries Series
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002160 File Offset: 0x00001160
		public virtual string ValueToSrting()
		{
			return this.LastValue.ToString("F4");
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002180 File Offset: 0x00001180
		public virtual string ValueToSrting(string format)
		{
			if (format.ToLower() != "d")
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.AppendFormat(format, this.LastValue);
				return stringBuilder.ToString();
			}
			return this.DateTimeValueToString();
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000021C8 File Offset: 0x000011C8
		public virtual string DateTimeValueToString()
		{
			string text = "";
			long num = (long)this.LastValue;
			if (num <= 0L)
			{
				return "";
			}
			TimeSpan timeSpan = new TimeSpan(num);
			if (timeSpan.Days != 0)
			{
				text = text + timeSpan.Days.ToString() + "Days";
			}
			if (timeSpan.Hours != 0)
			{
				text = text + timeSpan.Hours.ToString() + "Hr";
			}
			if (timeSpan.Minutes != 0)
			{
				text = text + timeSpan.Minutes.ToString() + "Min";
			}
			return text;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002265 File Offset: 0x00001265
		public virtual void Reset()
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002267 File Offset: 0x00001267
		public virtual void Disconnect()
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002269 File Offset: 0x00001269
		public virtual void Connect()
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0000226B File Offset: 0x0000126B
		private void EmitComponentNameChanged(string oldName, string newName)
		{
			if (this.ComponentNameChanged != null)
			{
				this.ComponentNameChanged(this, new ComponentNameEventArgs(oldName, newName));
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002288 File Offset: 0x00001288
		protected void EmitPropertyChanged()
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this);
			}
		}

		// Token: 0x04000003 RID: 3
		protected string name = "";

		// Token: 0x04000004 RID: 4
		protected string description = "";

		// Token: 0x04000005 RID: 5
		protected double lastValue;
	}
}
