using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization;
using SmartQuant.Data;

namespace SmartQuant.File
{
	// Token: 0x02000017 RID: 23
	internal class SeriesFormatter : IFormatter
	{
		// Token: 0x060000C2 RID: 194 RVA: 0x00005C75 File Offset: 0x00004C75
		internal SeriesFormatter(TypeManager typeManager)
		{
			this.typeManager = typeManager;
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00005C84 File Offset: 0x00004C84
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x00005C87 File Offset: 0x00004C87
		public SerializationBinder Binder
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x00005C8C File Offset: 0x00004C8C
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x00005CA2 File Offset: 0x00004CA2
		public StreamingContext Context
		{
			get
			{
				return default(StreamingContext);
			}
			set
			{
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x00005CA4 File Offset: 0x00004CA4
		// (set) Token: 0x060000C8 RID: 200 RVA: 0x00005CA7 File Offset: 0x00004CA7
		public ISurrogateSelector SurrogateSelector
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00005CAC File Offset: 0x00004CAC
		public void Serialize(Stream stream, object graph)
		{
			BinaryWriter binaryWriter = new BinaryWriter(stream);
			ArrayList arrayList = graph as ArrayList;
			binaryWriter.Write(arrayList.Count);
			foreach (object obj in arrayList)
			{
				ISeriesObject seriesObject = (ISeriesObject)obj;
				byte typeId = this.typeManager.GetTypeId(seriesObject.GetType());
				binaryWriter.Write(typeId);
				seriesObject.WriteTo(binaryWriter);
			}
			binaryWriter.Flush();
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00005D40 File Offset: 0x00004D40
		public object Deserialize(Stream stream)
		{
			BinaryReader binaryReader = new BinaryReader(stream);
			ArrayList arrayList = new ArrayList();
			int num = binaryReader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				byte typeId = binaryReader.ReadByte();
				ISeriesObject seriesObject = this.typeManager.CreateInstance(typeId);
				seriesObject.ReadFrom(binaryReader);
				arrayList.Add(seriesObject);
			}
			return arrayList;
		}

		// Token: 0x04000063 RID: 99
		private TypeManager typeManager;
	}
}
