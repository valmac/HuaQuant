using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;

namespace SmartQuant
{
	// Token: 0x02000031 RID: 49
	internal class AssemblyCache
	{
		// Token: 0x060000DB RID: 219
		[DllImport("fusion.dll", PreserveSig = false, SetLastError = true)]
		private static extern void CreateAssemblyCache(out IAssemblyCache ppAsmCache, uint dwReserved);

		// Token: 0x060000DC RID: 220
		[DllImport("fusion.dll", CharSet = CharSet.Unicode, PreserveSig = false, SetLastError = true)]
		private static extern void CreateAssemblyNameObject(out IAssemblyName ppAssemblyNameObj, string szAssemblyName, uint dwFlags, IntPtr pvReserved);

		// Token: 0x060000DD RID: 221
		[DllImport("fusion.dll", PreserveSig = false, SetLastError = true)]
		private static extern void CreateAssemblyEnum(out IAssemblyEnum pEnum, IntPtr pUnkReserved, IAssemblyName pName, ASM_CACHE_FLAGS dwFlags, IntPtr pvReserved);

		// Token: 0x060000DE RID: 222
		[DllImport("fusion.dll", PreserveSig = false, SetLastError = true)]
		private static extern void CreateInstallReferenceEnum(out IInstallReferenceEnum ppRefEnum, IAssemblyName pName, uint dwFlags, IntPtr pvReserved);

		// Token: 0x060000DF RID: 223
		[DllImport("fusion.dll", CharSet = CharSet.Unicode, PreserveSig = false, SetLastError = true)]
		private static extern void GetCachePath(ASM_CACHE_FLAGS dwCacheFlags, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder pwzCachePath, ref uint pcchPath);

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00004875 File Offset: 0x00003875
		internal static Guid FUSION_REFCOUNT_UNINSTALL_SUBKEY_GUID
		{
			get
			{
				return new Guid("8cedc215-ac4b-488b-93c0-a50a49cb2fb8");
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00004881 File Offset: 0x00003881
		internal static Guid FUSION_REFCOUNT_FILEPATH_GUID
		{
			get
			{
				return new Guid("b02f9d65-fb77-4f7a-afa5-b391309f11c9");
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x0000488D File Offset: 0x0000388D
		internal static Guid FUSION_REFCOUNT_OPAQUE_STRING_GUID
		{
			get
			{
				return new Guid("2ec93463-b0c3-45e1-8364-327e96aea856");
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x00004899 File Offset: 0x00003899
		internal static Guid FUSION_REFCOUNT_MSI_GUID
		{
			get
			{
				return new Guid("25df0fc1-7f97-4070-add7-4b13bbfd7cb8");
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x000048A8 File Offset: 0x000038A8
		internal static IAssemblyCache CreateAssemblyCache()
		{
			IAssemblyCache result;
			AssemblyCache.CreateAssemblyCache(out result, 0u);
			return result;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x000048C0 File Offset: 0x000038C0
		internal static IAssemblyName CreateAssemblyName(string name)
		{
			IAssemblyName result;
			AssemblyCache.CreateAssemblyNameObject(out result, name, 2u, (IntPtr)0);
			return result;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000048E0 File Offset: 0x000038E0
		internal static string GetDisplayName(IAssemblyName name, ASM_DISPLAY_FLAGS which)
		{
			uint capacity = 255u;
			StringBuilder stringBuilder = new StringBuilder((int)capacity);
			name.GetDisplayName(stringBuilder, ref capacity, which);
			return stringBuilder.ToString();
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000490C File Offset: 0x0000390C
		internal static string GetName(IAssemblyName name)
		{
			uint capacity = 255u;
			StringBuilder stringBuilder = new StringBuilder((int)capacity);
			name.GetName(ref capacity, stringBuilder);
			return stringBuilder.ToString();
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00004938 File Offset: 0x00003938
		internal static Version GetVersion(IAssemblyName name)
		{
			uint num;
			uint num2;
			name.GetVersion(out num, out num2);
			return new Version((int)(num >> 16), (int)(num & 65535u), (int)(num2 >> 16), (int)(num2 & 65535u));
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0000496C File Offset: 0x0000396C
		internal static byte[] GetPublicKeyToken(IAssemblyName name)
		{
			byte[] array = new byte[8];
			uint cb = 8u;
			IntPtr intPtr = Marshal.AllocHGlobal((int)cb);
			name.GetProperty(ASM_NAME.ASM_NAME_PUBLIC_KEY_TOKEN, intPtr, ref cb);
			for (int i = 0; i < 8; i++)
			{
				array[i] = Marshal.ReadByte(intPtr, i);
			}
			Marshal.FreeHGlobal(intPtr);
			return array;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000049B4 File Offset: 0x000039B4
		internal static byte[] GetPublicKey(IAssemblyName name)
		{
			uint num = 512u;
			IntPtr intPtr = Marshal.AllocHGlobal((int)num);
			name.GetProperty(ASM_NAME.ASM_NAME_PUBLIC_KEY, intPtr, ref num);
			byte[] array = new byte[num];
			int num2 = 0;
			while ((long)num2 < (long)((ulong)num))
			{
				array[num2] = Marshal.ReadByte(intPtr, num2);
				num2++;
			}
			Marshal.FreeHGlobal(intPtr);
			return array;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00004A00 File Offset: 0x00003A00
		internal static CultureInfo GetCulture(IAssemblyName name)
		{
			uint cb = 255u;
			IntPtr intPtr = Marshal.AllocHGlobal((int)cb);
			name.GetProperty(ASM_NAME.ASM_NAME_CULTURE, intPtr, ref cb);
			string name2 = Marshal.PtrToStringAuto(intPtr);
			Marshal.FreeHGlobal(intPtr);
			return new CultureInfo(name2);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00004A38 File Offset: 0x00003A38
		internal static string GetCodeBase(IAssemblyName name)
		{
			uint num = 255u;
			IntPtr intPtr = Marshal.AllocHGlobal((int)num);
			name.GetProperty(ASM_NAME.ASM_NAME_CODEBASE_URL, intPtr, ref num);
			string result = (num == 0u) ? "" : Marshal.PtrToStringAuto(intPtr);
			Marshal.FreeHGlobal(intPtr);
			return result;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00004A78 File Offset: 0x00003A78
		internal static IAssemblyEnum CreateGACEnum()
		{
			IAssemblyEnum result;
			AssemblyCache.CreateAssemblyEnum(out result, (IntPtr)0, null, ASM_CACHE_FLAGS.ASM_CACHE_GAC, (IntPtr)0);
			return result;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00004A9B File Offset: 0x00003A9B
		internal static int GetNextAssembly(IAssemblyEnum enumerator, out IAssemblyName name)
		{
			return enumerator.GetNextAssembly((IntPtr)0, out name, 0u);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00004AAC File Offset: 0x00003AAC
		internal static string GetGACPath()
		{
			uint capacity = 255u;
			StringBuilder stringBuilder = new StringBuilder((int)capacity);
			AssemblyCache.GetCachePath(ASM_CACHE_FLAGS.ASM_CACHE_GAC, stringBuilder, ref capacity);
			return stringBuilder.ToString();
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00004AD8 File Offset: 0x00003AD8
		internal static string GetZapPath()
		{
			uint capacity = 255u;
			StringBuilder stringBuilder = new StringBuilder((int)capacity);
			AssemblyCache.GetCachePath(ASM_CACHE_FLAGS.ASM_CACHE_ZAP, stringBuilder, ref capacity);
			return stringBuilder.ToString();
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00004B04 File Offset: 0x00003B04
		internal static string GetDownloadPath()
		{
			uint capacity = 255u;
			StringBuilder stringBuilder = new StringBuilder((int)capacity);
			AssemblyCache.GetCachePath(ASM_CACHE_FLAGS.ASM_CACHE_DOWNLOAD, stringBuilder, ref capacity);
			return stringBuilder.ToString();
		}
	}
}
