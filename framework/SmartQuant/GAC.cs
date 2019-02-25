using System;
using System.Collections;
using System.Reflection;

namespace SmartQuant
{
	// Token: 0x0200001C RID: 28
	public class GAC
	{
		// Token: 0x060000B7 RID: 183 RVA: 0x00004142 File Offset: 0x00003142
		private GAC()
		{
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000414C File Offset: 0x0000314C
		static GAC()
		{
			ArrayList arrayList = new ArrayList();
			IAssemblyEnum enumerator = AssemblyCache.CreateGACEnum();
			IAssemblyName nameRef = null;
			while (AssemblyCache.GetNextAssembly(enumerator, out nameRef) == 0)
			{
				AssemblyName assemblyName = GAC.GetAssemblyName(nameRef);
				arrayList.Add(assemblyName);
			}
			GAC.assemblies = (arrayList.ToArray(typeof(AssemblyName)) as AssemblyName[]);
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x0000419C File Offset: 0x0000319C
		public static AssemblyName[] Assemblies
		{
			get
			{
				return GAC.assemblies;
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000041A4 File Offset: 0x000031A4
		public static bool Exists(AssemblyName assemblyName)
		{
			foreach (AssemblyName assemblyName2 in GAC.assemblies)
			{
				if (assemblyName2.Name == assemblyName.Name && assemblyName2.Version == assemblyName.Version)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000041F8 File Offset: 0x000031F8
		public static string GetPath(AssemblyName assemblyName)
		{
			foreach (AssemblyName assemblyName2 in GAC.assemblies)
			{
				if (assemblyName2.Name == assemblyName.Name && assemblyName2.Version == assemblyName.Version)
				{
					string result;
					if (assemblyName2.CodeBase == "")
					{
						result = assemblyName2.Name + ".dll";
					}
					else
					{
						result = assemblyName2.CodeBase.Replace("file:///", "").Replace("/", "\\");
					}
					return result;
				}
			}
			return "";
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000042B8 File Offset: 0x000032B8
		private static string KeyToString(byte[] key)
		{
			char[] array = new char[]
			{
				'0',
				'1',
				'2',
				'3',
				'4',
				'5',
				'6',
				'7',
				'8',
				'9',
				'a',
				'b',
				'c',
				'd',
				'e',
				'f'
			};
			string text = "";
			foreach (byte b in key)
			{
				text += array[(int)(b / 16)];
				text += array[(int)(b % 16)];
			}
			return text;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000431C File Offset: 0x0000331C
		private static AssemblyName GetAssemblyName(IAssemblyName nameRef)
		{
			AssemblyName assemblyName = new AssemblyName();
			assemblyName.Name = AssemblyCache.GetName(nameRef);
			assemblyName.Version = AssemblyCache.GetVersion(nameRef);
			assemblyName.CultureInfo = AssemblyCache.GetCulture(nameRef);
			assemblyName.CodeBase = AssemblyCache.GetCodeBase(nameRef);
			assemblyName.SetPublicKeyToken(AssemblyCache.GetPublicKeyToken(nameRef));
			return assemblyName;
		}

		// Token: 0x04000076 RID: 118
		private static AssemblyName[] assemblies;
	}
}
