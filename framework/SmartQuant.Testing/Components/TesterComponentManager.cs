using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using SmartQuant.Testing.TesterItems;

namespace SmartQuant.Testing.Components
{
	// Token: 0x02000022 RID: 34
	public class TesterComponentManager
	{
		// Token: 0x14000005 RID: 5
		// (add) Token: 0x060000D4 RID: 212 RVA: 0x0000544B File Offset: 0x0000444B
		// (remove) Token: 0x060000D5 RID: 213 RVA: 0x00005462 File Offset: 0x00004462
		public static event TesterComponentEventHandler TesterComponentAdded;

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x060000D6 RID: 214 RVA: 0x00005479 File Offset: 0x00004479
		// (remove) Token: 0x060000D7 RID: 215 RVA: 0x00005490 File Offset: 0x00004490
		public static event TesterComponentEventHandler TesterComponentRemoved;

		// Token: 0x060000D8 RID: 216 RVA: 0x000054A7 File Offset: 0x000044A7
		static TesterComponentManager()
		{
			TesterComponentManager.Load();
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x000054B8 File Offset: 0x000044B8
		public static TesterComponentRecordList Components
		{
			get
			{
				return TesterComponentManager.components;
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000054BF File Offset: 0x000044BF
		private static void Load()
		{
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000054C4 File Offset: 0x000044C4
		private static TesterComponentRecord[] LoadFile(FileInfo file)
		{
			CompilerResults compilerResults = CompilingService.Compile(new string[]
			{
				file.FullName
			}, new string[]
			{
				"System.dll",
				"System.Drawing.dll"
			}, false);
			ArrayList arrayList = new ArrayList();
			foreach (Type type in compilerResults.CompiledAssembly.GetTypes())
			{
				object[] customAttributes = type.GetCustomAttributes(typeof(TesterComponentAttribute), false);
				string name;
				string description;
				if (customAttributes.Length > 0)
				{
					TesterComponentAttribute testerComponentAttribute = customAttributes[0] as TesterComponentAttribute;
					name = ((testerComponentAttribute.Name == null) ? type.Name : testerComponentAttribute.Name);
					description = ((testerComponentAttribute.Description == null) ? "" : testerComponentAttribute.Description);
				}
				else
				{
					name = type.Name;
					description = "";
				}
				TesterComponentRecord testerComponentRecord = new TesterComponentRecord(name, description, file, type);
				TesterComponentManager.components.Add(testerComponentRecord);
				arrayList.Add(testerComponentRecord);
			}
			return arrayList.ToArray(typeof(TesterComponentRecord)) as TesterComponentRecord[];
		}

		// Token: 0x060000DC RID: 220 RVA: 0x000055D7 File Offset: 0x000045D7
		public static void AddExistingComponent(FileInfo existingFile)
		{
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000055DC File Offset: 0x000045DC
		public static TesterComponentRecordList GetComponents(bool onlySeries)
		{
			TesterComponentRecordList testerComponentRecordList = new TesterComponentRecordList();
			foreach (object obj in TesterComponentManager.components)
			{
				TesterComponentRecord testerComponentRecord = (TesterComponentRecord)obj;
				if (!onlySeries || testerComponentRecord.Type == typeof(SeriesTesterItem))
				{
					testerComponentRecordList.Add(testerComponentRecord);
				}
			}
			return testerComponentRecordList;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00005650 File Offset: 0x00004650
		public static TesterItem GetComponent(string name)
		{
			TesterComponentRecord testerComponentRecord = TesterComponentManager.components[name];
			TesterItem testerItem = Activator.CreateInstance(testerComponentRecord.Type, new object[]
			{
				name
			}) as TesterItem;
			testerItem.Name = testerComponentRecord.Name;
			testerItem.Description = testerComponentRecord.Description;
			return testerItem;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x000056A0 File Offset: 0x000046A0
		public static void SaveComponent(TesterItem component, string fileDir)
		{
			StreamWriter streamWriter = new StreamWriter(fileDir + component.Name + ".cpt");
			streamWriter.WriteLine("$ComponentType$ = " + component.GetType().Name);
			PropertyInfo[] properties = component.GetType().GetProperties();
			foreach (PropertyInfo propertyInfo in properties)
			{
				BrowsableAttribute[] array2 = propertyInfo.GetCustomAttributes(typeof(BrowsableAttribute), true) as BrowsableAttribute[];
				bool flag = true;
				foreach (BrowsableAttribute browsableAttribute in array2)
				{
					if (!browsableAttribute.Browsable)
					{
						flag = false;
					}
				}
				if (flag)
				{
					TesterComponentManager.WriteComponentProperty(component, propertyInfo, streamWriter);
				}
			}
			streamWriter.Close();
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000575C File Offset: 0x0000475C
		public static TesterItem LoadComponent(LiveTester tester, string fileName)
		{
			StreamReader streamReader = new StreamReader(fileName);
			string text = streamReader.ReadLine();
			TesterItem component = TesterComponentManager.GetComponent(text.Remove(0, text.IndexOf(" ") + 3));
			string propertyString;
			while ((propertyString = streamReader.ReadLine()) != null)
			{
				TesterComponentManager.ReadComponentProperty(tester, component, propertyString, fileName);
			}
			streamReader.Close();
			return component;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000057B0 File Offset: 0x000047B0
		private static void WriteComponentProperty(TesterItem component, PropertyInfo property, StreamWriter writer)
		{
			string name = property.Name;
			string str = "";
			if (property.PropertyType.IsSubclassOf(typeof(TesterItem)))
			{
				TesterItem testerItem = property.GetValue(component, null) as TesterItem;
				if (testerItem != null)
				{
					str = testerItem.Name;
				}
			}
			else
			{
				str = property.GetValue(component, null).ToString();
			}
			writer.WriteLine(name + " = " + str);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0000581C File Offset: 0x0000481C
		private static void ReadComponentProperty(LiveTester tester, TesterItem component, string propertyString, string filePath)
		{
			string name = propertyString.Substring(0, propertyString.IndexOf(" "));
			string text = propertyString.Remove(0, propertyString.IndexOf(" ") + 3);
			PropertyInfo property = component.GetType().GetProperty(name);
			object value = null;
			if (property.PropertyType.IsSubclassOf(typeof(TesterItem)))
			{
				if (tester.Components.Contains(text))
				{
					value = tester.Components[text];
				}
				else if (text != "")
				{
					if (new FileInfo(filePath.LastIndexOf("\\") + 1 + text + ".cpt").Exists)
					{
						value = TesterComponentManager.LoadComponent(tester, filePath.Substring(0, filePath.LastIndexOf("\\") + 1) + text + ".cpt");
					}
					else
					{
						value = TesterComponentManager.GetComponent(text);
					}
				}
			}
			else if (property.PropertyType == typeof(double))
			{
				value = double.Parse(text);
			}
			else if (property.PropertyType == typeof(string))
			{
				value = text;
			}
			else if (property.PropertyType == typeof(int))
			{
				value = int.Parse(text);
			}
			property.SetValue(component, value, null);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00005961 File Offset: 0x00004961
		private static void EmitComponentAdded(TesterComponentRecord record)
		{
			if (TesterComponentManager.TesterComponentAdded != null)
			{
				TesterComponentManager.TesterComponentAdded(new TesterComponentEventArgs(record));
			}
		}

		// Token: 0x04000035 RID: 53
		private const string SUB_DIR_DATA = "tester";

		// Token: 0x04000036 RID: 54
		public const string COMP_EXT = ".cpt";

		// Token: 0x04000037 RID: 55
		private static TesterComponentRecordList components = new TesterComponentRecordList();
	}
}
