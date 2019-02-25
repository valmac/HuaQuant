using System;
using System.CodeDom.Compiler;
using Microsoft.CSharp;

namespace SmartQuant
{
	// Token: 0x02000008 RID: 8
	public class CompilingService
	{
		// Token: 0x0600002F RID: 47 RVA: 0x00002B2C File Offset: 0x00001B2C
		public static CompilerResults Compile(string[] files, string[] references, bool generateEXE, bool generateInMemory, string output)
		{
			CodeDomProvider codeDomProvider = new CSharpCodeProvider();
			CompilerParameters compilerParameters = new CompilerParameters();
			if (output != null)
			{
				compilerParameters.OutputAssembly = output;
			}
			compilerParameters.GenerateInMemory = generateInMemory;
			if (generateEXE)
			{
				compilerParameters.GenerateExecutable = true;
			}
			foreach (object obj in Framework.Configuration.References)
			{
				Reference reference = (Reference)obj;
				if (reference.Enabled && reference.Valid)
				{
					compilerParameters.ReferencedAssemblies.Add(reference.Path);
				}
			}
			foreach (string value in references)
			{
				compilerParameters.ReferencedAssemblies.Add(value);
			}
			return codeDomProvider.CompileAssemblyFromFile(compilerParameters, files);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002C08 File Offset: 0x00001C08
		public static CompilerResults Compile(string[] files, string[] references, bool generateEXE)
		{
			return CompilingService.Compile(files, references, generateEXE, true, null);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002C14 File Offset: 0x00001C14
		public static CompilerResults Compile(string filename, bool generateEXE)
		{
			return CompilingService.Compile(new string[]
			{
				filename
			}, new string[0], generateEXE);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002C3C File Offset: 0x00001C3C
		public static CompilerResults CompileSource(string source, string[] references)
		{
			CodeDomProvider codeDomProvider = new CSharpCodeProvider();
			CompilerParameters compilerParameters = new CompilerParameters();
			compilerParameters.GenerateInMemory = true;
			foreach (object obj in Framework.Configuration.References)
			{
				Reference reference = (Reference)obj;
				if (reference.Enabled && reference.Valid)
				{
					compilerParameters.ReferencedAssemblies.Add(reference.Path);
				}
			}
			foreach (string value in references)
			{
				compilerParameters.ReferencedAssemblies.Add(value);
			}
			return codeDomProvider.CompileAssemblyFromSource(compilerParameters, new string[]
			{
				source
			});
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002D10 File Offset: 0x00001D10
		public static CompilerResults CompileSource(string source)
		{
			return CompilingService.CompileSource(source, new string[0]);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002D20 File Offset: 0x00001D20
		public static CompilerResults Compile(string filename, string output)
		{
			return CompilingService.Compile(new string[]
			{
				filename
			}, new string[0], false, false, output);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002D47 File Offset: 0x00001D47
		public static CompilerResults Compile(string[] filenames, string output)
		{
			return CompilingService.Compile(filenames, new string[0], false, false, output);
		}
	}
}
