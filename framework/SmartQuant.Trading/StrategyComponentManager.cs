using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace SmartQuant.Trading
{
	// Token: 0x02000058 RID: 88
	public class StrategyComponentManager
	{
		// Token: 0x14000013 RID: 19
		// (add) Token: 0x0600036B RID: 875 RVA: 0x0000D569 File Offset: 0x0000C569
		// (remove) Token: 0x0600036C RID: 876 RVA: 0x0000D580 File Offset: 0x0000C580
		public static event ComponentEventHandler ComponentAdded;

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x0600036D RID: 877 RVA: 0x0000D597 File Offset: 0x0000C597
		// (remove) Token: 0x0600036E RID: 878 RVA: 0x0000D5AE File Offset: 0x0000C5AE
		public static event ComponentEventHandler ComponentRemoved;

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x0600036F RID: 879 RVA: 0x0000D5C5 File Offset: 0x0000C5C5
		// (remove) Token: 0x06000370 RID: 880 RVA: 0x0000D5DC File Offset: 0x0000C5DC
		public static event ComponentEventHandler ComponentReconstructed;

		// Token: 0x06000371 RID: 881 RVA: 0x0000D5F4 File Offset: 0x0000C5F4
		static StrategyComponentManager()
		{
			StrategyComponentManager.templates.Add(ComponentType.CrossEntry, "CrossEntry.cs");
			StrategyComponentManager.templates.Add(ComponentType.CrossExit, "CrossExit.cs");
			StrategyComponentManager.templates.Add(ComponentType.Entry, "Entry.cs");
			StrategyComponentManager.templates.Add(ComponentType.Exit, "Exit.cs");
			StrategyComponentManager.templates.Add(ComponentType.ExecutionManager, "ExecutionManager.cs");
			StrategyComponentManager.templates.Add(ComponentType.ExposureManager, "ExposureManager.cs");
			StrategyComponentManager.templates.Add(ComponentType.MoneyManager, "MoneyManager.cs");
			StrategyComponentManager.templates.Add(ComponentType.RiskManager, "RiskManager.cs");
			StrategyComponentManager.templates.Add(ComponentType.MarketManager, "MarketManager.cs");
			StrategyComponentManager.templates.Add(ComponentType.OptimizationManager, "OptimizationManager.cs");
			StrategyComponentManager.templates.Add(ComponentType.ReportManager, "ReportManager.cs");
			StrategyComponentManager.templates.Add(ComponentType.MetaExposureManager, "MetaExposureManager.cs");
			StrategyComponentManager.templates.Add(ComponentType.MetaMoneyManager, "MetaMoneyManager.cs");
			StrategyComponentManager.templates.Add(ComponentType.MetaRiskManager, "MetaRiskManager.cs");
			StrategyComponentManager.templates.Add(ComponentType.SimulationManager, "SimulationManager.cs");
			StrategyComponentManager.templates.Add(ComponentType.ATSComponent, "ATSComponent.cs");
			StrategyComponentManager.templates.Add(ComponentType.ATSCrossComponent, "ATSCrossComponent.cs");
			StrategyComponentManager.componentCache = new Hashtable();
			StrategyComponentManager.components = new StrategyComponentList();
			StrategyComponentManager.builtComponents = new List<string>();
			StrategyComponentManager.RegisterDefaultComponents();
		}

		// Token: 0x06000372 RID: 882 RVA: 0x0000D7C4 File Offset: 0x0000C7C4
		private static void LoadBuiltComponents()
		{
			string path = Framework.Installation.ComponentDir.FullName + "\\data.data";
			if (File.Exists(path))
			{
				StreamReader streamReader = new StreamReader(path);
				string item;
				while ((item = streamReader.ReadLine()) != null)
				{
					StrategyComponentManager.builtComponents.Add(item);
				}
				streamReader.Close();
			}
		}

		// Token: 0x06000373 RID: 883 RVA: 0x0000D818 File Offset: 0x0000C818
		public static void SaveBuiltComponents()
		{
			StreamWriter streamWriter = new StreamWriter(Framework.Installation.ComponentDir.FullName + "\\data.data");
			foreach (object obj in StrategyComponentManager.components)
			{
				ComponentRecord componentRecord = (ComponentRecord)obj;
				if (componentRecord.File != null && (componentRecord.Errors == null || !componentRecord.Errors.HasErrors))
				{
					streamWriter.WriteLine(componentRecord.File.Name);
				}
			}
			streamWriter.Close();
		}

		// Token: 0x06000374 RID: 884 RVA: 0x0000D8BC File Offset: 0x0000C8BC
		public static void LoadComponents()
		{
			StrategyComponentManager.Load();
			FileSystemWatcher fileSystemWatcher = new FileSystemWatcher();
			fileSystemWatcher.Path = Framework.Installation.ComponentDir.FullName + "\\data";
			fileSystemWatcher.Filter = "*.*";
			fileSystemWatcher.NotifyFilter = NotifyFilters.LastWrite;
			fileSystemWatcher.Changed += StrategyComponentManager.OnFileChanged;
			fileSystemWatcher.EnableRaisingEvents = true;
		}

		// Token: 0x06000375 RID: 885 RVA: 0x0000D91F File Offset: 0x0000C91F
		public static void Init()
		{
			StrategyComponentManager.LoadBuiltComponents();
			StrategyComponentManager.LoadComponents();
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000376 RID: 886 RVA: 0x0000D92B File Offset: 0x0000C92B
		public static StrategyComponentList Components
		{
			get
			{
				return StrategyComponentManager.components;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000377 RID: 887 RVA: 0x0000D932 File Offset: 0x0000C932
		public static ICollection ComponentTypes
		{
			get
			{
				return StrategyComponentManager.templates.Keys;
			}
		}

		// Token: 0x06000378 RID: 888 RVA: 0x0000D940 File Offset: 0x0000C940
		public static void AddNewComponent(ComponentType componentType, string name, string description)
		{
			StreamReader streamReader = new StreamReader(Framework.Installation.ComponentDir.FullName + "\\templates\\" + (string)StrategyComponentManager.templates[componentType]);
			string text = streamReader.ReadToEnd();
			streamReader.Close();
			string newValue = string.Concat(new string[]
			{
				"\"{",
				Guid.NewGuid().ToString(),
				"}\", ComponentType.",
				componentType.ToString(),
				" , Name=\"",
				name,
				"\", Description=\"",
				description,
				"\""
			});
			text = text.Replace("$HEADER$", newValue);
			text = text.Replace("$ClassName$", name);
			FileInfo fileInfo = new FileInfo(Framework.Installation.ComponentDir.FullName + "\\data\\" + name + ".cs");
			if (fileInfo.Exists)
			{
				throw new IOException(string.Format("File {0} already exists.", fileInfo.Name));
			}
			StreamWriter streamWriter = fileInfo.CreateText();
			streamWriter.Write(text);
			streamWriter.Close();
			StrategyComponentManager.RegisterComponents(fileInfo);
		}

		// Token: 0x06000379 RID: 889 RVA: 0x0000DA78 File Offset: 0x0000CA78
		private static void RegisterComponents(FileInfo file)
		{
			CompilerResults compilerResults = CompilingService.Compile(file.FullName, false);
			if (compilerResults.Errors.HasErrors)
			{
				ComponentRecord record = new ComponentRecord(Guid.Empty, ComponentType.Unknown, file.Name, "", file, null, compilerResults.Errors);
				StrategyComponentManager.components.Add(record);
				StrategyComponentManager.EmitComponentAdded(record);
				return;
			}
			bool flag = false;
			foreach (Type type in compilerResults.CompiledAssembly.GetTypes())
			{
				ComponentRecord componentRecord = StrategyComponentManager.CreateRecord(type, file);
				if (componentRecord != null)
				{
					StrategyComponentManager.components.Add(componentRecord);
					StrategyComponentManager.EmitComponentAdded(componentRecord);
					flag = true;
				}
			}
			if (!flag)
			{
				ComponentRecord record2 = new ComponentRecord(Guid.Empty, ComponentType.Unknown, file.Name, "", file, null, new CompilerErrorCollection(new CompilerError[]
				{
					new CompilerError(file.FullName, -1, -1, "-1", "No components found")
				}));
				StrategyComponentManager.components.Add(record2);
				StrategyComponentManager.EmitComponentAdded(record2);
			}
		}

		// Token: 0x0600037A RID: 890 RVA: 0x0000DB74 File Offset: 0x0000CB74
		public static void AddExistingComponent(FileInfo existingFile)
		{
			FileInfo file = existingFile.CopyTo(Framework.Installation.ComponentDir.FullName + "\\data\\" + existingFile.Name);
			StrategyComponentManager.RegisterComponents(file);
		}

		// Token: 0x0600037B RID: 891 RVA: 0x0000DBB0 File Offset: 0x0000CBB0
		public static bool RebuildComponent(FileInfo file)
		{
			ComponentRecord[] array = StrategyComponentManager.components.FindRecords(file);
			foreach (ComponentRecord componentRecord in array)
			{
				componentRecord.SetErrors(new CompilerErrorCollection());
				StrategyComponentManager.componentCache.Remove(componentRecord);
			}
			CompilerResults compilerResults = CompilingService.Compile(file.FullName, false);
			if (compilerResults.Errors.HasErrors)
			{
				foreach (ComponentRecord componentRecord2 in array)
				{
					componentRecord2.SetErrors(compilerResults.Errors);
					StrategyComponentManager.EmitComponentReconstructed(componentRecord2);
				}
				return false;
			}
			ArrayList arrayList = new ArrayList();
			foreach (Type type in compilerResults.CompiledAssembly.GetTypes())
			{
				ComponentRecord componentRecord3 = StrategyComponentManager.CreateRecord(type, file);
				if (componentRecord3 != null)
				{
					arrayList.Add(componentRecord3);
				}
			}
			ArrayList arrayList2 = new ArrayList(array);
			foreach (object obj in arrayList)
			{
				ComponentRecord componentRecord4 = (ComponentRecord)obj;
				bool flag = false;
				foreach (object obj2 in arrayList2)
				{
					ComponentRecord componentRecord5 = (ComponentRecord)obj2;
					if (componentRecord5.GUID == componentRecord4.GUID)
					{
						componentRecord5.SetName(componentRecord4.Name);
						componentRecord5.SetDescription(componentRecord4.Description);
						componentRecord5.SetComponentType(componentRecord4.ComponentType);
						componentRecord5.SetRuntimeType(componentRecord4.RuntimeType);
						componentRecord5.SetIsChanged(false);
						flag = true;
						arrayList2.Remove(componentRecord5);
						StrategyComponentManager.EmitComponentReconstructed(componentRecord5);
						break;
					}
				}
				if (!flag)
				{
					StrategyComponentManager.components.Add(componentRecord4);
					StrategyComponentManager.EmitComponentAdded(componentRecord4);
				}
			}
			foreach (object obj3 in arrayList2)
			{
				ComponentRecord componentRecord6 = (ComponentRecord)obj3;
				if (componentRecord6.GUID == Guid.Empty)
				{
					StrategyComponentManager.components.Remove(componentRecord6);
					StrategyComponentManager.EmitComponentRemoved(componentRecord6);
				}
			}
			return true;
		}

		// Token: 0x0600037C RID: 892 RVA: 0x0000DE1C File Offset: 0x0000CE1C
		public static void RemoveComponent(ComponentRecord record)
		{
			record.File.Delete();
			StrategyComponentManager.components.Remove(record);
			StrategyComponentManager.componentCache.Remove(record);
			StrategyComponentManager.EmitComponentRemoved(record);
		}

		// Token: 0x0600037D RID: 893 RVA: 0x0000DE48 File Offset: 0x0000CE48
		public static StrategyComponentList GetComponentList(ComponentType componentType)
		{
			StrategyComponentList strategyComponentList = new StrategyComponentList();
			foreach (object obj in StrategyComponentManager.components)
			{
				ComponentRecord componentRecord = (ComponentRecord)obj;
				if ((componentRecord.ComponentType & componentType) != (ComponentType)0)
				{
					strategyComponentList.Add(componentRecord);
				}
			}
			return strategyComponentList;
		}

		// Token: 0x0600037E RID: 894 RVA: 0x0000DEB4 File Offset: 0x0000CEB4
		public static IComponentBase GetDefaultComponent(ComponentType type, object issuer)
		{
			if (type <= ComponentType.MetaExposureManager)
			{
				if (type <= ComponentType.MoneyManager)
				{
					switch (type)
					{
					case ComponentType.Entry:
						return StrategyComponentManager.GetComponent("{94FAFF9D-5281-4c67-A599-B893F1F58B38}", issuer);
					case (ComponentType)3:
						break;
					case ComponentType.Exit:
						return StrategyComponentManager.GetComponent("{6FEE0044-0FD2-418d-94E6-400834BEE5D3}", issuer);
					default:
						if (type == ComponentType.ExposureManager)
						{
							return StrategyComponentManager.GetComponent("{0449D7E3-2016-47f6-9B80-C787B3E0F18F}", issuer);
						}
						if (type == ComponentType.MoneyManager)
						{
							return StrategyComponentManager.GetComponent("{9637DF40-0F84-46e3-AC54-0EC2D2CE2699}", issuer);
						}
						break;
					}
				}
				else if (type <= ComponentType.MarketManager)
				{
					if (type == ComponentType.RiskManager)
					{
						return StrategyComponentManager.GetComponent("{BE0176A8-3BBD-407c-814A-D5A3E3437899}", issuer);
					}
					if (type == ComponentType.MarketManager)
					{
						return StrategyComponentManager.GetComponent("{849E4CFE-C19E-4d1e-899D-0BB26DB12AAD}", issuer);
					}
				}
				else
				{
					if (type == ComponentType.OptimizationManager)
					{
						return StrategyComponentManager.GetComponent("{A4D510F9-13DB-4b4c-9557-BC6A48A25D0B}", issuer);
					}
					if (type == ComponentType.MetaExposureManager)
					{
						return StrategyComponentManager.GetComponent("{2DBD0B38-8399-4d0b-9FAA-7C29FC1462BC}", issuer);
					}
				}
			}
			else if (type <= ComponentType.MetaRiskManager)
			{
				if (type <= ComponentType.ExecutionManager)
				{
					if (type == ComponentType.SimulationManager)
					{
						return StrategyComponentManager.GetComponent("{872476E5-3774-4687-828F-34978288A6E0}", issuer);
					}
					if (type == ComponentType.ExecutionManager)
					{
						return StrategyComponentManager.GetComponent("{D106D35A-E1E4-4e86-8869-846289E98232}", issuer);
					}
				}
				else
				{
					if (type == ComponentType.MetaMoneyManager)
					{
						return StrategyComponentManager.GetComponent("{FED5076A-C710-4d3a-B134-3D9D32B8B248}", issuer);
					}
					if (type == ComponentType.MetaRiskManager)
					{
						return StrategyComponentManager.GetComponent("{521B9C4F-01AE-4488-B4A5-104027D06BB8}", issuer);
					}
				}
			}
			else if (type <= ComponentType.ATSComponent)
			{
				if (type == ComponentType.ReportManager)
				{
					return StrategyComponentManager.GetComponent("{5E7810DC-C9C1-427f-8CD9-1DFFE26E59B5}", issuer);
				}
				if (type == ComponentType.ATSComponent)
				{
					return StrategyComponentManager.GetComponent("{AC3C53E2-6C94-4718-A5D8-8A475D8B4EB7}", issuer);
				}
			}
			else
			{
				if (type == ComponentType.CrossEntry)
				{
					return StrategyComponentManager.GetComponent("{664274F3-FDE1-46da-A84F-556E4A0EB170}", issuer);
				}
				if (type == ComponentType.ATSCrossComponent)
				{
					return StrategyComponentManager.GetComponent("{E70A6417-E7FA-4ec1-BC16-B03DE53C6E85}", issuer);
				}
			}
			return null;
		}

		// Token: 0x0600037F RID: 895 RVA: 0x0000E06C File Offset: 0x0000D06C
		public static IComponentBase GetComponent(Guid guid, object issuer)
		{
			ComponentRecord componentRecord = StrategyComponentManager.components.FindRecord(guid);
			if (componentRecord == null)
			{
				return null;
			}
			if (componentRecord.IsChanged)
			{
				StrategyComponentManager.componentCache.Remove(componentRecord);
				CompilerResults compilerResults = CompilingService.Compile(componentRecord.File.FullName, false);
				if (compilerResults.Errors.HasErrors)
				{
					componentRecord.SetErrors(compilerResults.Errors);
					return null;
				}
				componentRecord.SetIsChanged(false);
				foreach (Type type in compilerResults.CompiledAssembly.GetTypes())
				{
					ComponentRecord componentRecord2 = StrategyComponentManager.CreateRecord(type, componentRecord.File);
					if (componentRecord2 != null)
					{
						componentRecord.SetRuntimeType(componentRecord2.RuntimeType);
						break;
					}
				}
			}
			Hashtable hashtable = StrategyComponentManager.componentCache[componentRecord] as Hashtable;
			if (hashtable == null)
			{
				hashtable = new Hashtable();
				StrategyComponentManager.componentCache.Add(componentRecord, hashtable);
			}
			IComponentBase componentBase = hashtable[issuer] as IComponentBase;
			if (componentBase == null)
			{
				ComponentRecord componentRecord3 = StrategyComponentManager.components.FindRecord(guid);
				componentBase = (Activator.CreateInstance(componentRecord3.RuntimeType) as IComponentBase);
				componentBase.Name = componentRecord3.Name;
				componentBase.Description = componentRecord3.Description;
				hashtable.Add(issuer, componentBase);
			}
			return componentBase;
		}

		// Token: 0x06000380 RID: 896 RVA: 0x0000E19D File Offset: 0x0000D19D
		public static IComponentBase GetComponent(string guid, object issuer)
		{
			return StrategyComponentManager.GetComponent(new Guid(guid), issuer);
		}

		// Token: 0x06000381 RID: 897 RVA: 0x0000E1AC File Offset: 0x0000D1AC
		public static void ClearComponentCache(object issuer)
		{
			foreach (object obj in new Hashtable(StrategyComponentManager.componentCache))
			{
				DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
				Hashtable hashtable = (Hashtable)dictionaryEntry.Value;
				hashtable.Remove(issuer);
				if (hashtable.Count == 0)
				{
					StrategyComponentManager.componentCache.Remove(dictionaryEntry.Key);
				}
			}
		}

		// Token: 0x06000382 RID: 898 RVA: 0x0000E230 File Offset: 0x0000D230
		private static void RegisterDefaultComponents()
		{
			foreach (object obj in StrategyComponentManager.ComponentRuntimeTypes)
			{
				Type runtimeType = (Type)obj;
				StrategyComponentManager.RegisterDefaultComponent(runtimeType);
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000383 RID: 899 RVA: 0x0000E288 File Offset: 0x0000D288
		public static ICollection ComponentRuntimeTypes
		{
			get
			{
				return new ArrayList
				{
					typeof(CrossEntry),
					typeof(CrossExit),
					typeof(Entry),
					typeof(Exit),
					typeof(MoneyManager),
					typeof(RiskManager),
					typeof(ExposureManager),
					typeof(MarketManager),
					typeof(OptimizationManager),
					typeof(ReportManager),
					typeof(MetaExposureManager),
					typeof(MetaMoneyManager),
					typeof(MetaRiskManager),
					typeof(SimulationManager),
					typeof(ExecutionManager),
					typeof(ATSComponent),
					typeof(ATSCrossComponent)
				};
			}
		}

		// Token: 0x06000384 RID: 900 RVA: 0x0000E3C0 File Offset: 0x0000D3C0
		public static void RegisterDefaultComponent(Type runtimeType)
		{
			ComponentRecord record = StrategyComponentManager.CreateRecord(runtimeType, null);
			StrategyComponentManager.components.Add(record);
		}

		// Token: 0x06000385 RID: 901 RVA: 0x0000E3E0 File Offset: 0x0000D3E0
		private static void Load()
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(Framework.Installation.ComponentDir.FullName + "\\data");
			StrategyComponentManager.RegisterAllComponents(directoryInfo.GetFiles());
		}

		// Token: 0x06000386 RID: 902 RVA: 0x0000E418 File Offset: 0x0000D418
		private static void RegisterAllComponents(FileInfo[] files)
		{
			string text = "";
			Dictionary<string, FileInfo> dictionary = new Dictionary<string, FileInfo>();
			List<FileInfo> list = new List<FileInfo>();
			List<FileInfo> list2 = new List<FileInfo>();
			int num = 1;
			foreach (FileInfo fileInfo in files)
			{
				if (StrategyComponentManager.builtComponents.Contains(fileInfo.Name))
				{
					StreamReader streamReader = new StreamReader(fileInfo.FullName);
					string text2 = "__" + num;
					dictionary[text2] = fileInfo;
					list.Add(fileInfo);
					string text3 = text;
					text = string.Concat(new string[]
					{
						text3,
						"namespace ",
						text2,
						Environment.NewLine,
						"{",
						Environment.NewLine
					});
					text += streamReader.ReadToEnd();
					text = text + Environment.NewLine + "}" + Environment.NewLine;
					num++;
					streamReader.Close();
				}
				else
				{
					list2.Add(fileInfo);
				}
			}
			CompilerResults compilerResults = CompilingService.CompileSource(text);
			if (compilerResults.Errors.HasErrors)
			{
				foreach (FileInfo file in files)
				{
					StrategyComponentManager.RegisterComponents(file);
				}
				return;
			}
			foreach (Type type in compilerResults.CompiledAssembly.GetTypes())
			{
				if (type.IsPublic)
				{
					string key = type.FullName.Substring(0, type.FullName.IndexOf("."));
					FileInfo fileInfo2 = dictionary[key];
					list.Remove(fileInfo2);
					ComponentRecord componentRecord = StrategyComponentManager.CreateRecord(type, fileInfo2);
					if (componentRecord != null)
					{
						StrategyComponentManager.components.Add(componentRecord);
						StrategyComponentManager.EmitComponentAdded(componentRecord);
					}
				}
			}
			foreach (FileInfo fileInfo3 in list)
			{
				ComponentRecord record = new ComponentRecord(Guid.Empty, ComponentType.Unknown, fileInfo3.Name, "", fileInfo3, null, new CompilerErrorCollection(new CompilerError[]
				{
					new CompilerError(fileInfo3.FullName, -1, -1, "-1", "No components found")
				}));
				StrategyComponentManager.components.Add(record);
				StrategyComponentManager.EmitComponentAdded(record);
			}
			foreach (FileInfo file2 in list2)
			{
				StrategyComponentManager.RegisterComponents(file2);
			}
		}

		// Token: 0x06000387 RID: 903 RVA: 0x0000E6C0 File Offset: 0x0000D6C0
		private static ComponentRecord CreateRecord(Type type, FileInfo file)
		{
			StrategyComponentAttribute[] array = type.GetCustomAttributes(typeof(StrategyComponentAttribute), false) as StrategyComponentAttribute[];
			if (array == null || array.Length != 1)
			{
				return null;
			}
			StrategyComponentAttribute strategyComponentAttribute = array[0];
			string name = (strategyComponentAttribute.Name == null) ? type.Name : strategyComponentAttribute.Name;
			return new ComponentRecord(strategyComponentAttribute.GUID, strategyComponentAttribute.Type, name, strategyComponentAttribute.Description, file, type, null);
		}

		// Token: 0x06000388 RID: 904 RVA: 0x0000E728 File Offset: 0x0000D728
		private static void OnFileChanged(object sender, FileSystemEventArgs e)
		{
			if (e.ChangeType == WatcherChangeTypes.Changed)
			{
				string text = e.FullPath;
				if (text.EndsWith(".TMP"))
				{
					int num = text.LastIndexOf("~RF");
					if (num != -1)
					{
						text = text.Substring(0, num);
					}
				}
				foreach (object obj in StrategyComponentManager.components)
				{
					ComponentRecord componentRecord = (ComponentRecord)obj;
					if (!componentRecord.BuiltIn && componentRecord.File.FullName.ToLower() == text.ToLower())
					{
						componentRecord.SetIsChanged(true);
					}
				}
			}
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0000E7E4 File Offset: 0x0000D7E4
		private static void EmitComponentAdded(ComponentRecord record)
		{
			if (StrategyComponentManager.ComponentAdded != null)
			{
				StrategyComponentManager.ComponentAdded(new ComponentEventArgs(record));
			}
		}

		// Token: 0x0600038A RID: 906 RVA: 0x0000E7FD File Offset: 0x0000D7FD
		private static void EmitComponentRemoved(ComponentRecord record)
		{
			if (StrategyComponentManager.ComponentRemoved != null)
			{
				StrategyComponentManager.ComponentRemoved(new ComponentEventArgs(record));
			}
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0000E816 File Offset: 0x0000D816
		private static void EmitComponentReconstructed(ComponentRecord record)
		{
			if (StrategyComponentManager.ComponentReconstructed != null)
			{
				StrategyComponentManager.ComponentReconstructed(new ComponentEventArgs(record));
			}
		}

		// Token: 0x0400011D RID: 285
		private const string SUB_DIR_DATA = "data";

		// Token: 0x0400011E RID: 286
		private const string SUB_DIR_TEMPLATES = "templates";

		// Token: 0x0400011F RID: 287
		private const string BUILT_COMPONENTS_FILE = "data.data";

		// Token: 0x04000120 RID: 288
		private static StrategyComponentList components;

		// Token: 0x04000121 RID: 289
		private static List<string> builtComponents;

		// Token: 0x04000122 RID: 290
		private static Hashtable templates = new Hashtable();

		// Token: 0x04000123 RID: 291
		private static Hashtable componentCache;
	}
}
