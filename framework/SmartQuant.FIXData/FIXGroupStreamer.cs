using System;
using System.Collections;
using System.IO;
using SmartQuant.FIX;

namespace SmartQuant.FIXData
{
	// Token: 0x02000004 RID: 4
	public class FIXGroupStreamer
	{
		// Token: 0x06000018 RID: 24 RVA: 0x00002198 File Offset: 0x00001198
		public static void WriteTo(BinaryWriter writer, FIXGroup group)
		{
			writer.Write(group.Fields.Count);
			foreach (object obj in group.Fields)
			{
				DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
				writer.Write((int)dictionaryEntry.Key);
				FIXField fixfield = (FIXField)dictionaryEntry.Value;
				switch (fixfield.FIXType)
				{
				case FIXType.Bool:
					writer.Write(((FIXBoolField)fixfield).Value);
					break;
				case FIXType.Int:
					writer.Write(((FIXIntField)fixfield).Value);
					break;
				case FIXType.Double:
					writer.Write(((FIXDoubleField)fixfield).Value);
					break;
				case FIXType.Char:
					writer.Write(((FIXCharField)fixfield).Value);
					break;
				case FIXType.String:
					writer.Write(((FIXStringField)fixfield).Value);
					break;
				case FIXType.DateTime:
					writer.Write(((FIXDateTimeField)fixfield).Value.Ticks);
					break;
				default:
					throw new ArgumentException("Unknown fix type - " + fixfield.FIXType.ToString());
				}
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000022F4 File Offset: 0x000012F4
		public static void ReadFrom(BinaryReader reader, FIXGroup group)
		{
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				int tag = reader.ReadInt32();
				FIXType fixtype = EFIXFieldTypes.GetFIXType(tag);
				switch (fixtype)
				{
				case FIXType.Bool:
					group.AddBoolField(tag, reader.ReadBoolean());
					break;
				case FIXType.Int:
					group.AddIntField(tag, reader.ReadInt32());
					break;
				case FIXType.Double:
					group.AddDoubleField(tag, reader.ReadDouble());
					break;
				case FIXType.Char:
					group.AddCharField(tag, reader.ReadChar());
					break;
				case FIXType.String:
					group.AddStringField(tag, reader.ReadString());
					break;
				case FIXType.DateTime:
					group.AddDateTimeField(tag, new DateTime(reader.ReadInt64()));
					break;
				default:
					throw new ArgumentException("Unknown fix type - " + fixtype.ToString());
				}
			}
		}
	}
}
