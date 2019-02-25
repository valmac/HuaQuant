using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using SmartQuant.Data;

namespace SmartQuant.File
{
	// Token: 0x02000002 RID: 2
	internal class TypeManager
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000020D0 File Offset: 0x000010D0
		internal TypeManager(string location)
		{
			this.filename = location + "\\types.xml";
			this.types = new Hashtable();
			this.objects = new Hashtable();
			this.LoadTypes();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002108 File Offset: 0x00001108
		internal byte GetTypeId(Type type)
		{
			if (!this.types.ContainsKey(type))
			{
				this.types.Add(type, this.nextId);
				this.objects.Add(this.nextId, Activator.CreateInstance(type));
				this.nextId += 1;
				this.SaveTypes();
			}
			return (byte)this.types[type];
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000217C File Offset: 0x0000117C
		internal ISeriesObject CreateInstance(byte typeId)
		{
			return (this.objects[typeId] as ISeriesObject).NewInstance();
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002199 File Offset: 0x00001199
		internal Hashtable RegisteredTypes
		{
			get
			{
				return this.types.Clone() as Hashtable;
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000021AC File Offset: 0x000011AC
		private void LoadTypes()
		{
			this.nextId = 0;
			if (System.IO.File.Exists(this.filename))
			{
				DataSet dataSet = new DataSet();
				dataSet.ReadXml(this.filename, XmlReadMode.ReadSchema);
				DataTable dataTable = dataSet.Tables["type"];
				foreach (object obj in dataTable.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					string text = (string)dataRow["name"];
					Type type = Type.GetType(text);
					byte b = (byte)dataRow["id"];
					if (type == null)
					{
						Trace.WriteLine(string.Format("{0} QuantServer cannot load type - {1}", DateTime.Now, text));
						if (Environment.UserInteractive)
						{
							string text2 = string.Format("QuantServer cannot load type {0}.{1}{1}{2}", text, Environment.NewLine, "");
							MessageBox.Show(text2, "QuantServer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						}
					}
					else
					{
						this.types.Add(type, b);
						this.objects.Add(b, Activator.CreateInstance(type));
						if (b >= this.nextId)
						{
							this.nextId =(byte)( b + 1);
						}
					}
				}
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002304 File Offset: 0x00001304
		private void SaveTypes()
		{
			DataTable dataTable = new DataTable("type");
			dataTable.Columns.Add("name", typeof(string));
			dataTable.Columns.Add("id", typeof(byte));
			foreach (object obj in this.types)
			{
				DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
				DataRow dataRow = dataTable.NewRow();
				dataTable.Rows.Add(dataRow);
				dataRow["name"] = ((Type)dictionaryEntry.Key).AssemblyQualifiedName;
				dataRow["id"] = (byte)dictionaryEntry.Value;
			}
			new DataSet("types")
			{
				Tables = 
				{
					dataTable
				}
			}.WriteXml(this.filename, XmlWriteMode.WriteSchema);
		}

		// Token: 0x04000001 RID: 1
		private const string TAG_DATA_SET = "types";

		// Token: 0x04000002 RID: 2
		private const string TAG_DATA_TABLE = "type";

		// Token: 0x04000003 RID: 3
		private const string TAG_ELEMENT_TYPE_NAME = "name";

		// Token: 0x04000004 RID: 4
		private const string TAG_ELEMENT_TYPE_ID = "id";

		// Token: 0x04000005 RID: 5
		private Hashtable types;

		// Token: 0x04000006 RID: 6
		private Hashtable objects;

		// Token: 0x04000007 RID: 7
		private string filename;

		// Token: 0x04000008 RID: 8
		private byte nextId;
	}
}
