using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.IO;

namespace SmartQuant.Trading
{
	// Token: 0x0200005E RID: 94
	public class ComponentRecord
	{
		// Token: 0x060003A4 RID: 932 RVA: 0x0000ED30 File Offset: 0x0000DD30
		internal ComponentRecord(Guid guid, ComponentType componentType, string name, string description, FileInfo file, Type runtimeType, CompilerErrorCollection errors)
		{
			this.guid = guid;
			this.componentType = componentType;
			this.name = name;
			this.description = description;
			this.file = file;
			this.runtimeType = runtimeType;
			this.errors = errors;
			this.isChanged = false;
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060003A5 RID: 933 RVA: 0x0000ED7F File Offset: 0x0000DD7F
		[Category("Misc")]
		[Description("Component GUID")]
		public Guid GUID
		{
			get
			{
				return this.guid;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x0000ED87 File Offset: 0x0000DD87
		[Category("Misc")]
		[Description("Component type")]
		[ReadOnly(true)]
		public ComponentType ComponentType
		{
			get
			{
				return this.componentType;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060003A7 RID: 935 RVA: 0x0000ED8F File Offset: 0x0000DD8F
		[Description("Component name")]
		[Category("Naming")]
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x0000ED97 File Offset: 0x0000DD97
		[Category("Naming")]
		[Description("Component description")]
		public string Description
		{
			get
			{
				return this.description;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060003A9 RID: 937 RVA: 0x0000ED9F File Offset: 0x0000DD9F
		[Browsable(false)]
		public FileInfo File
		{
			get
			{
				return this.file;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060003AA RID: 938 RVA: 0x0000EDA7 File Offset: 0x0000DDA7
		public bool BuiltIn
		{
			get
			{
				return this.file == null;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060003AB RID: 939 RVA: 0x0000EDB2 File Offset: 0x0000DDB2
		public Type RuntimeType
		{
			get
			{
				return this.runtimeType;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060003AC RID: 940 RVA: 0x0000EDBA File Offset: 0x0000DDBA
		public bool IsChanged
		{
			get
			{
				return this.isChanged;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060003AD RID: 941 RVA: 0x0000EDC2 File Offset: 0x0000DDC2
		[Browsable(false)]
		public CompilerErrorCollection Errors
		{
			get
			{
				return this.errors;
			}
		}

		// Token: 0x060003AE RID: 942 RVA: 0x0000EDCA File Offset: 0x0000DDCA
		internal void SetIsChanged(bool value)
		{
			this.isChanged = value;
		}

		// Token: 0x060003AF RID: 943 RVA: 0x0000EDD3 File Offset: 0x0000DDD3
		internal void SetGuid(Guid guid)
		{
			this.guid = guid;
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x0000EDDC File Offset: 0x0000DDDC
		internal void SetComponentType(ComponentType componentType)
		{
			this.componentType = componentType;
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x0000EDE5 File Offset: 0x0000DDE5
		internal void SetName(string name)
		{
			this.name = name;
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0000EDEE File Offset: 0x0000DDEE
		internal void SetDescription(string description)
		{
			this.description = description;
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x0000EDF7 File Offset: 0x0000DDF7
		internal void SetRuntimeType(Type runtimeType)
		{
			this.runtimeType = runtimeType;
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0000EE00 File Offset: 0x0000DE00
		internal void SetErrors(CompilerErrorCollection errors)
		{
			this.errors = errors;
		}

		// Token: 0x0400012C RID: 300
		private const string CATEGORY_NAMING = "Naming";

		// Token: 0x0400012D RID: 301
		private const string CATEGORY_MISC = "Misc";

		// Token: 0x0400012E RID: 302
		private Guid guid;

		// Token: 0x0400012F RID: 303
		private ComponentType componentType;

		// Token: 0x04000130 RID: 304
		private string name;

		// Token: 0x04000131 RID: 305
		private string description;

		// Token: 0x04000132 RID: 306
		private FileInfo file;

		// Token: 0x04000133 RID: 307
		private Type runtimeType;

		// Token: 0x04000134 RID: 308
		private CompilerErrorCollection errors;

		// Token: 0x04000135 RID: 309
		private bool isChanged;
	}
}
