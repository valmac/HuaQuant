using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization;
using SharpZipLib.Zip;
using SmartQuant.Data;
using SmartQuant.File.Indexing;

namespace SmartQuant.File
{
	// Token: 0x0200000B RID: 11
	internal class Streamer
	{
		// Token: 0x06000019 RID: 25 RVA: 0x000024F9 File Offset: 0x000014F9
		internal Streamer(string location, IFormatter formatter)
		{
			this.location = location;
			this.formatter = formatter;
			this.Init();
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002518 File Offset: 0x00001518
		private void Init()
		{
			this.cacheManager = new CacheManager();
			this.dataStream = new FileStream(this.location + "\\.data", FileMode.OpenOrCreate);
			this.headerStream = new FileStream(this.location + "\\.header", FileMode.OpenOrCreate);
			this.indexStream = new FileStream(this.location + "\\.index", FileMode.OpenOrCreate);
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00002584 File Offset: 0x00001584
		internal long DataFileSize
		{
			get
			{
				long length;
				lock (this)
				{
					length = this.dataStream.Length;
				}
				return length;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001C RID: 28 RVA: 0x000025C0 File Offset: 0x000015C0
		internal long HeaderFileSize
		{
			get
			{
				long length;
				lock (this)
				{
					length = this.headerStream.Length;
				}
				return length;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001D RID: 29 RVA: 0x000025FC File Offset: 0x000015FC
		internal long IndexFileSize
		{
			get
			{
				long length;
				lock (this)
				{
					length = this.indexStream.Length;
				}
				return length;
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002638 File Offset: 0x00001638
		internal void Close()
		{
			lock (this)
			{
				this.headerStream.Close();
				this.dataStream.Close();
				this.indexStream.Close();
				this.cacheManager.Clear();
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002694 File Offset: 0x00001694
		internal void LoadSeries(SeriesCollection collection)
		{
			lock (this)
			{
				BinaryReader binaryReader = new BinaryReader(this.headerStream);
				long num = this.headerStream.Position = 0L;
				while (binaryReader.PeekChar() != -1)
				{
					byte b = binaryReader.ReadByte();
					if (b == 255)
					{
						string name = binaryReader.ReadString().Trim();
						string description = binaryReader.ReadString().Trim();
						int zipLevel = binaryReader.ReadInt32();
						int maxBlockSize = binaryReader.ReadInt32();
						byte indexer = binaryReader.ReadByte();
						long firstBlockPosition = binaryReader.ReadInt64();
						long lastBlockPosition = binaryReader.ReadInt64();
						DateTime firstDateTime = new DateTime(binaryReader.ReadInt64());
						DateTime lastDateTime = new DateTime(binaryReader.ReadInt64());
						int objectCount = binaryReader.ReadInt32();
						long indexPosition = binaryReader.ReadInt64();
						FileSeries fileSeries = collection.Add(name, description, zipLevel, maxBlockSize, (Indexer)indexer);
						fileSeries.HeaderPosition = num;
						fileSeries.FirstBlockPosition = firstBlockPosition;
						fileSeries.LastBlockPosition = lastBlockPosition;
						fileSeries.firstDateTime = firstDateTime;
						fileSeries.lastDateTime = lastDateTime;
						fileSeries.ObjectCount = objectCount;
						fileSeries.IndexPosition = indexPosition;
					}
					num += 374L;
					this.headerStream.Position = num;
				}
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000027E4 File Offset: 0x000017E4
		internal void WriteSeriesSettings(FileSeries series)
		{
			lock (this)
			{
				bool flag = false;
				if (series.HeaderPosition == -1L)
				{
					series.HeaderPosition = this.headerStream.Length;
					flag = true;
				}
				this.headerStream.Position = series.HeaderPosition;
				BinaryWriter binaryWriter = new BinaryWriter(this.headerStream);
				binaryWriter.Write(byte.MaxValue);
				binaryWriter.Write(this.GetString127(series.Name));
				binaryWriter.Write(this.GetString127(series.Description));
				binaryWriter.Write(series.ZipLevel);
				binaryWriter.Write(series.MaxBlockSize);
				binaryWriter.Write((byte)series.Indexer);
				binaryWriter.Flush();
				if (flag)
				{
					this.WriteSeriesBlockPositions(series);
					this.WriteSeriesInfo(series);
					this.WriteSeriesIndexPosition(series);
					this.WriteSeriesReservedBytes(series);
				}
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000028C8 File Offset: 0x000018C8
		private void WriteSeriesBlockPositions(FileSeries series)
		{
			this.headerStream.Position = series.HeaderPosition + 266L;
			BinaryWriter binaryWriter = new BinaryWriter(this.headerStream);
			binaryWriter.Write(series.FirstBlockPosition);
			binaryWriter.Write(series.LastBlockPosition);
			binaryWriter.Flush();
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002918 File Offset: 0x00001918
		private void WriteSeriesInfo(FileSeries series)
		{
			this.headerStream.Position = series.HeaderPosition + 282L;
			BinaryWriter binaryWriter = new BinaryWriter(this.headerStream);
			binaryWriter.Write(series.firstDateTime.Ticks);
			binaryWriter.Write(series.lastDateTime.Ticks);
			binaryWriter.Write(series.ObjectCount);
			binaryWriter.Flush();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002980 File Offset: 0x00001980
		private void WriteSeriesIndexPosition(FileSeries series)
		{
			this.headerStream.Position = series.HeaderPosition + 302L;
			BinaryWriter binaryWriter = new BinaryWriter(this.headerStream);
			binaryWriter.Write(series.IndexPosition);
			binaryWriter.Flush();
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000029C4 File Offset: 0x000019C4
		private void WriteSeriesReservedBytes(FileSeries series)
		{
			this.headerStream.Position = series.HeaderPosition + 310L;
			BinaryWriter binaryWriter = new BinaryWriter(this.headerStream);
			binaryWriter.Write(0L);
			binaryWriter.Write(0L);
			binaryWriter.Write(0L);
			binaryWriter.Write(0L);
			binaryWriter.Write(0L);
			binaryWriter.Write(0L);
			binaryWriter.Write(0L);
			binaryWriter.Write(0L);
			binaryWriter.Flush();
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002A3B File Offset: 0x00001A3B
		private string GetString127(string src)
		{
			while (src.Length < 127)
			{
				src += " ";
			}
			return src;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002A58 File Offset: 0x00001A58
		internal void RemoveSeries(FileSeries series)
		{
			lock (this)
			{
				BinaryWriter binaryWriter = new BinaryWriter(this.headerStream);
				this.headerStream.Position = series.HeaderPosition;
				binaryWriter.Write(0);
				binaryWriter.Flush();
				this.cacheManager.Clear(series);
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002ABC File Offset: 0x00001ABC
		internal void AddObject(FileSeries series, ISeriesObject obj)
		{
			lock (this)
			{
				obj = (obj.Clone() as ISeriesObject);
				CacheUnit cacheUnit = this.cacheManager.GetCacheUnit(series);
				cacheUnit.Block2 = null;
				Block block = cacheUnit.Block;
				if (block == null)
				{
					block = this.ReadBlock(series.LastBlockPosition, false);
				}
				if (block == null)
				{
					block = new Block();
					block.Add(obj);
					this.RegisterObject(cacheUnit, obj.DateTime);
					this.WriteBlock(series, block);
					cacheUnit.Block = block;
				}
				else
				{
					if (obj.DateTime < block.FirstDateTime)
					{
						for (long prevBlockPosition = block.PrevBlockPosition; prevBlockPosition != -1L; prevBlockPosition = block.PrevBlockPosition)
						{
							block = cacheUnit[prevBlockPosition];
							if (block == null)
							{
								block = this.ReadBlock(prevBlockPosition, false);
							}
							if (obj.DateTime >= block.FirstDateTime)
							{
								break;
							}
						}
					}
					else
					{
						for (long nextBlockPosition = block.NextBlockPosition; nextBlockPosition != -1L; nextBlockPosition = block.NextBlockPosition)
						{
							Block block2 = cacheUnit[nextBlockPosition];
							if (block2 == null)
							{
								block2 = this.ReadBlock(nextBlockPosition, false);
							}
							if (obj.DateTime < block2.FirstDateTime)
							{
								break;
							}
							block = block2;
						}
					}
					if (block.ObjectCount >= series.MaxBlockSize)
					{
						if (obj.DateTime >= block.LastDateTime)
						{
							bool flag = true;
							if (cacheUnit.ContainsBlock(block))
							{
								block = cacheUnit.Block;
								flag = false;
							}
							this.WriteBlock(series, cacheUnit.Block);
							if (flag)
							{
								block = this.ReadBlock(block.Position, false);
							}
							Block block3 = new Block();
							block3.Add(obj);
							block3.PrevBlockPosition = block.Position;
							block3.NextBlockPosition = block.NextBlockPosition;
							this.RegisterObject(cacheUnit, obj.DateTime);
							this.WriteBlock(series, block3);
							bool flag2 = cacheUnit.Block == cacheUnit.Block2;
							cacheUnit.Block = block3;
							if (flag2 && cacheUnit.Block2 != null)
							{
								cacheUnit.Block2 = this.ReadBlock(cacheUnit.Block2.Position, true);
							}
						}
						else
						{
							if (cacheUnit.ContainsBlock(block))
							{
								block = cacheUnit.Block;
							}
							else
							{
								this.WriteBlock(series, cacheUnit.Block);
								block = this.ReadBlock(block.Position, true);
							}
							Block block4 = new Block();
							Block block5 = new Block();
							int num = block.ObjectCount / 2;
							for (int i = 0; i < block.ObjectCount; i++)
							{
								if (i < num)
								{
									block4.Add(block[i]);
								}
								else
								{
									block5.Add(block[i]);
								}
							}
							block4.PrevBlockPosition = block.PrevBlockPosition;
							block5.NextBlockPosition = block.NextBlockPosition;
							this.WriteBlock(block4, series.ZipLevel, false);
							this.WriteBlock(block5, series.ZipLevel, false);
							block4.NextBlockPosition = block5.Position;
							block5.PrevBlockPosition = block4.Position;
							this.CorrectReferences(block4);
							this.CorrectReferences(block5);
							if (block4.PrevBlockPosition == -1L)
							{
								series.FirstBlockPosition = block4.Position;
								this.WriteSeriesBlockPositions(series);
							}
							if (block5.NextBlockPosition == -1L)
							{
								series.LastBlockPosition = block5.Position;
								this.WriteSeriesBlockPositions(series);
							}
							this.WriteSeriesInfo(series);
							if (obj.DateTime < block5.FirstDateTime)
							{
								block4.Add(obj);
								cacheUnit.Block = block4;
							}
							else
							{
								block5.Add(obj);
								cacheUnit.Block = block5;
							}
							if (cacheUnit.Block2 != null)
							{
								if (cacheUnit.Block2.PrevBlockPosition == block.Position)
								{
									cacheUnit.Block2.PrevBlockPosition = block5.Position;
								}
								if (cacheUnit.Block2.NextBlockPosition == block.Position)
								{
									cacheUnit.Block2.NextBlockPosition = block4.Position;
								}
							}
							this.RegisterObject(cacheUnit, obj.DateTime);
						}
					}
					else
					{
						if (!cacheUnit.ContainsBlock(block))
						{
							this.WriteBlock(series, cacheUnit.Block);
							block = this.ReadBlock(block.Position, true);
							cacheUnit.Block = block;
						}
						else
						{
							block = cacheUnit.Block;
						}
						block.Add(obj);
						this.RegisterObject(cacheUnit, obj.DateTime);
					}
				}
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002EDC File Offset: 0x00001EDC
		internal void Update(FileSeries series, ISeriesObject obj)
		{
			lock (this)
			{
				int num = this.IndexOf(series, obj.DateTime, SmartQuant.Data.SearchOption.Exact);
				if (num == -1)
				{
					this.AddObject(series, obj);
				}
				else
				{
					this.Update(series, obj, num);
				}
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002F30 File Offset: 0x00001F30
		internal void Update(FileSeries series, ISeriesObject obj, int index)
		{
			lock (this)
			{
				if (index < 0 || index >= series.Count)
				{
					throw new ArgumentOutOfRangeException("Index out of range");
				}
				CacheUnit cacheUnit = this.cacheManager.GetCacheUnit(series);
				int num = index;
				long position = series.FirstBlockPosition;
				Block block;
				for (;;)
				{
					block = cacheUnit[position];
					if (block == null)
					{
						block = this.ReadBlock(position, false);
					}
					if (num < block.ObjectCount)
					{
						break;
					}
					num -= block.ObjectCount;
					position = block.NextBlockPosition;
				}
				if (cacheUnit.ContainsBlock(block))
				{
					block = cacheUnit[block.Position];
				}
				else
				{
					this.WriteBlock(series, cacheUnit.Block);
					block = this.ReadBlock(block.Position, true);
					cacheUnit.Block = block;
					if (cacheUnit.Block2 != null && cacheUnit.Block2.Position == block.Position)
					{
						cacheUnit.Block2 = block;
					}
				}
				block.ReplaceAt(num, obj.Clone() as ISeriesObject);
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00003030 File Offset: 0x00002030
		private void WriteBlock(FileSeries series, Block block)
		{
			if (block != null && block.IsModified)
			{
				long position = block.Position;
				this.WriteBlock(block, series.ZipLevel, true);
				if (block.PrevBlockPosition == -1L)
				{
					series.FirstBlockPosition = block.Position;
					this.WriteSeriesBlockPositions(series);
				}
				if (block.NextBlockPosition == -1L)
				{
					series.LastBlockPosition = block.Position;
					this.WriteSeriesBlockPositions(series);
				}
				this.WriteSeriesInfo(series);
				CacheUnit cacheUnit = this.cacheManager.GetCacheUnit(series);
				if (cacheUnit.Block2 != null)
				{
					if (cacheUnit.Block2.PrevBlockPosition == position)
					{
						cacheUnit.Block2.PrevBlockPosition = block.Position;
					}
					if (cacheUnit.Block2.NextBlockPosition == position)
					{
						cacheUnit.Block2.NextBlockPosition = block.Position;
					}
				}
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000030F8 File Offset: 0x000020F8
		internal ISeriesObject[] GetArray(FileSeries series, DateTime begin, DateTime end)
		{
			ISeriesObject[] result;
			lock (this)
			{
				CacheUnit cacheUnit = this.cacheManager.GetCacheUnit(series);
				ArrayList arrayList = new ArrayList();
				this.TryIndex(cacheUnit);
				long position;
				if (cacheUnit.Index == null)
				{
					position = series.FirstBlockPosition;
				}
				else
				{
					IndexItem indexItem = cacheUnit.Index[begin];
					position = ((indexItem == null) ? series.FirstBlockPosition : indexItem.BlockPosition);
				}
				Block block = cacheUnit[position];
				if (block == null)
				{
					block = this.ReadBlock(position, false);
				}
				while (block != null && !(begin <= block.LastDateTime))
				{
					if (block.NextBlockPosition == -1L)
					{
						block = null;
						break;
					}
					long nextBlockPosition = block.NextBlockPosition;
					block = cacheUnit[nextBlockPosition];
					if (block == null)
					{
						block = this.ReadBlock(nextBlockPosition, false);
					}
				}
				if (block != null)
				{
					for (long num = block.Position; num != -1L; num = block.NextBlockPosition)
					{
						block = cacheUnit[num];
						if (block == null)
						{
							block = this.ReadBlock(num, true);
						}
						foreach (object obj in block)
						{
							ISeriesObject seriesObject = (ISeriesObject)obj;
							if (seriesObject.DateTime >= begin && seriesObject.DateTime <= end)
							{
								arrayList.Add(seriesObject.Clone());
							}
						}
						if (end < block.LastDateTime)
						{
							break;
						}
					}
				}
				result = (arrayList.ToArray(typeof(ISeriesObject)) as ISeriesObject[]);
			}
			return result;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000032C4 File Offset: 0x000022C4
		internal ISeriesObject[] GetArray(FileSeries series, int beginIndex, int endIndex)
		{
			ISeriesObject[] result;
			lock (this)
			{
				if (beginIndex < 0 || beginIndex >= series.ObjectCount)
				{
					throw new ArgumentOutOfRangeException("beginIndex", beginIndex, "The begin index is out of range");
				}
				if (beginIndex > endIndex)
				{
					throw new ArgumentException("The begin index is greater than end endex", "beginIndex");
				}
				if (endIndex < 0 || endIndex >= series.ObjectCount)
				{
					throw new ArgumentOutOfRangeException("endIndex", endIndex, "The end index is out of range");
				}
				CacheUnit cacheUnit = this.cacheManager.GetCacheUnit(series);
				ArrayList arrayList = new ArrayList();
				long position = series.FirstBlockPosition;
				int num = beginIndex;
				this.TryIndex(cacheUnit);
				if (cacheUnit.Index != null)
				{
					IndexItem indexItem = cacheUnit.Index[beginIndex];
					if (indexItem != null)
					{
						position = indexItem.BlockPosition;
						num = beginIndex - indexItem.ObjectPosition;
					}
				}
				Block block;
				for (;;)
				{
					block = cacheUnit[position];
					if (block == null)
					{
						block = this.ReadBlock(position, false);
					}
					if (num < block.ObjectCount)
					{
						break;
					}
					num -= block.ObjectCount;
					position = block.NextBlockPosition;
				}
				block = cacheUnit[position];
				if (block == null)
				{
					block = this.ReadBlock(position, true);
				}
				int i = endIndex - beginIndex + 1;
				while (i > 0)
				{
					if (num < block.ObjectCount)
					{
						arrayList.Add(block[num].Clone());
						num++;
						i--;
					}
					else
					{
						position = block.NextBlockPosition;
						block = cacheUnit[position];
						if (block == null)
						{
							block = this.ReadBlock(position, true);
						}
						num = 0;
					}
				}
				result = (arrayList.ToArray(typeof(ISeriesObject)) as ISeriesObject[]);
			}
			return result;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003468 File Offset: 0x00002468
		internal void Flush(FileSeries series, bool flushIndex)
		{
			lock (this)
			{
				CacheUnit cacheUnit = this.cacheManager.GetCacheUnit(series, false);
				if (cacheUnit != null)
				{
					this.WriteBlock(series, cacheUnit.Block);
					if (flushIndex)
					{
						throw new NotImplementedException();
					}
				}
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000034C0 File Offset: 0x000024C0
		internal void Reindex(FileSeries series)
		{
			lock (this)
			{
				CacheUnit cacheUnit = this.cacheManager.GetCacheUnit(series);
				cacheUnit.Index = Index.GetIndex(series.Indexer);
				if (cacheUnit.Index != null)
				{
					this.Flush(series, false);
					long num = series.FirstBlockPosition;
					int num2 = 0;
					while (num != -1L)
					{
						Block block = this.ReadBlock(num, true);
						foreach (object obj in block)
						{
							ISeriesObject seriesObject = (ISeriesObject)obj;
							cacheUnit.Index.Add(seriesObject.DateTime, num2, block.Position);
						}
						num2 += block.ObjectCount;
						num = block.NextBlockPosition;
					}
					this.WriteIndex(cacheUnit);
				}
				else
				{
					series.IndexPosition = -1L;
				}
				this.WriteSeriesIndexPosition(series);
				this.WriteSeriesSettings(series);
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000035C8 File Offset: 0x000025C8
		internal void Defragment(string tempDir, DataFile file, int zipLevel, int maxBlockSize)
		{
			lock (this)
			{
				Hashtable hashtable = new Hashtable();
				Streamer streamer = new Streamer(tempDir, this.formatter);
				foreach (object obj in file.Series)
				{
					FileSeries fileSeries = (FileSeries)obj;
					file.EmitSeriesDefragmentStarted(fileSeries);
					int zipLevel2 = (zipLevel == -1) ? fileSeries.ZipLevel : zipLevel;
					int maxBlockSize2 = (maxBlockSize == -1) ? fileSeries.MaxBlockSize : maxBlockSize;
					FileSeries fileSeries2 = new FileSeries(streamer, fileSeries.Name, fileSeries.Description, zipLevel2, maxBlockSize2, fileSeries.Indexer);
					streamer.WriteSeriesSettings(fileSeries2);
					CacheUnit cacheUnit = this.cacheManager.GetCacheUnit(fileSeries);
					Block block;
					for (long num = fileSeries.FirstBlockPosition; num != -1L; num = block.NextBlockPosition)
					{
						block = cacheUnit[num];
						if (block == null)
						{
							block = this.ReadBlock(num, true);
						}
						foreach (object obj2 in block)
						{
							ISeriesObject obj3 = (ISeriesObject)obj2;
							fileSeries2.Add(obj3);
						}
					}
					fileSeries2.Flush();
					fileSeries2.Reindex(fileSeries2.Indexer);
					hashtable.Add(fileSeries, fileSeries2);
					streamer.cacheManager.Clear();
					file.EmitSeriesDefragmentFinished(fileSeries);
					DefragmentCancelEventArgs defragmentCancelEventArgs = new DefragmentCancelEventArgs();
					file.EmitDefragmentCancelRequest(defragmentCancelEventArgs);
					if (defragmentCancelEventArgs.Cancel)
					{
						streamer.dataStream.Close();
						streamer.headerStream.Close();
						streamer.indexStream.Close();
						return;
					}
				}
				streamer.dataStream.Close();
				streamer.headerStream.Close();
				streamer.indexStream.Close();
				this.dataStream.Close();
				this.headerStream.Close();
				this.indexStream.Close();
				this.cacheManager.Clear();
                System.IO.File.Delete(this.location + "\\.data");
                System.IO.File.Delete(this.location + "\\.header");
                System.IO.File.Delete(this.location + "\\.index");
                System.IO.File.Move(tempDir + "\\.data", this.location + "\\.data");
                System.IO.File.Move(tempDir + "\\.header", this.location + "\\.header");
                System.IO.File.Move(tempDir + "\\.index", this.location + "\\.index");
				this.Init();
				foreach (object obj4 in hashtable)
				{
					DictionaryEntry dictionaryEntry = (DictionaryEntry)obj4;
					FileSeries fileSeries3 = (FileSeries)dictionaryEntry.Key;
					FileSeries fileSeries4 = (FileSeries)dictionaryEntry.Value;
					fileSeries3.HeaderPosition = fileSeries4.HeaderPosition;
					fileSeries3.FirstBlockPosition = fileSeries4.FirstBlockPosition;
					fileSeries3.LastBlockPosition = fileSeries4.LastBlockPosition;
					fileSeries3.IndexPosition = fileSeries4.IndexPosition;
					fileSeries3.MaxBlockSize = fileSeries4.MaxBlockSize;
					fileSeries3.ZipLevel = fileSeries4.ZipLevel;
				}
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000397C File Offset: 0x0000297C
		internal int IndexOf(FileSeries series, DateTime datetime, SmartQuant.Data.SearchOption option)
		{
			int result;
			lock (this)
			{
				if (datetime < series.firstDateTime)
				{
					switch (option)
					{
					case SmartQuant.Data.SearchOption.Prev:
					case SmartQuant.Data.SearchOption.Exact:
						return -1;
					case SmartQuant.Data.SearchOption.Next:
						return (series.ObjectCount == 0) ? -1 : 0;
					}
				}
				if (datetime == series.firstDateTime)
				{
					result = 0;
				}
				else
				{
					if (datetime > series.lastDateTime)
					{
						switch (option)
						{
						case SmartQuant.Data.SearchOption.Prev:
							return (series.ObjectCount == 0) ? -1 : (series.ObjectCount - 1);
						case SmartQuant.Data.SearchOption.Exact:
						case SmartQuant.Data.SearchOption.Next:
							return -1;
						}
					}
					if (datetime == series.lastDateTime)
					{
						result = series.Count - 1;
					}
					else
					{
						CacheUnit cacheUnit = this.cacheManager.GetCacheUnit(series);
						int num = 0;
						this.TryIndex(cacheUnit);
						if (cacheUnit.Index != null)
						{
							IndexItem indexItem = cacheUnit.Index[datetime];
							if (indexItem != null)
							{
								num = indexItem.ObjectPosition;
							}
						}
						for (int i = num; i < series.ObjectCount; i++)
						{
							DateTime dateTime = this.GetByIndex(series, i).DateTime;
							if (datetime == dateTime)
							{
								return i;
							}
							if (dateTime > datetime)
							{
								if (option == SmartQuant.Data.SearchOption.Exact)
								{
									return -1;
								}
								if (option == SmartQuant.Data.SearchOption.Next)
								{
									return i;
								}
								if (option == SmartQuant.Data.SearchOption.Prev)
								{
									return i - 1;
								}
							}
						}
						result = ((option == SmartQuant.Data.SearchOption.Prev) ? (series.ObjectCount - 1) : -1);
					}
				}
			}
			return result;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00003B10 File Offset: 0x00002B10
		internal ISeriesObject GetByIndex(FileSeries series, int index)
		{
			ISeriesObject result;
			lock (this)
			{
				if (index < 0 || index >= series.ObjectCount)
				{
					throw new IndexOutOfRangeException("The index is out of range");
				}
				CacheUnit cacheUnit = this.cacheManager.GetCacheUnit(series);
				this.ValidateReadBuffer(cacheUnit, index);
				result = (cacheUnit.Block2[index - cacheUnit.FirstObjectPosition].Clone() as ISeriesObject);
			}
			return result;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003B8C File Offset: 0x00002B8C
		internal ISeriesObject GetByDateTime(FileSeries series, DateTime datetime, SmartQuant.Data.SearchOption option)
		{
			ISeriesObject result;
			lock (this)
			{
				int num = this.IndexOf(series, datetime, option);
				result = ((num == -1) ? null : this.GetByIndex(series, num));
			}
			return result;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00003BD8 File Offset: 0x00002BD8
		internal int GetSeriesPosition(FileSeries series)
		{
			int currentPosition;
			lock (this)
			{
				CacheUnit cacheUnit = this.cacheManager.GetCacheUnit(series);
				currentPosition = cacheUnit.CurrentPosition;
			}
			return currentPosition;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00003C1C File Offset: 0x00002C1C
		internal void SetSeriesPosition(FileSeries series, int position)
		{
			lock (this)
			{
				if (position < 0 || position >= series.ObjectCount)
				{
					throw new IndexOutOfRangeException("The series contains no object with specified position");
				}
				CacheUnit cacheUnit = this.cacheManager.GetCacheUnit(series);
				cacheUnit.CurrentPosition = position;
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00003C78 File Offset: 0x00002C78
		internal ISeriesObject Read(FileSeries series)
		{
			ISeriesObject result;
			lock (this)
			{
				CacheUnit cacheUnit = this.cacheManager.GetCacheUnit(series);
				if (cacheUnit.CurrentPosition >= series.ObjectCount)
				{
					throw new InvalidOperationException("Attempt to read object at the end of the series");
				}
				this.ValidateReadBuffer(cacheUnit, cacheUnit.CurrentPosition);
				ISeriesObject seriesObject = cacheUnit.Block2[cacheUnit.CurrentPosition - cacheUnit.FirstObjectPosition];
				cacheUnit.CurrentPosition++;
				result = (seriesObject.Clone() as ISeriesObject);
			}
			return result;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00003D10 File Offset: 0x00002D10
		internal void Remove(FileSeries series, DateTime datetime)
		{
			lock (this)
			{
				if (!(datetime < series.firstDateTime) && !(datetime > series.lastDateTime))
				{
					int index;
					while ((index = this.IndexOf(series, datetime, SmartQuant.Data.SearchOption.Exact)) != -1)
					{
						this.RemoveAt(series, index);
					}
				}
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00003D78 File Offset: 0x00002D78
		internal void RemoveAt(FileSeries series, int index)
		{
			lock (this)
			{
				if (index < 0 || index >= series.ObjectCount)
				{
					throw new IndexOutOfRangeException("The index is out of range");
				}
				CacheUnit cacheUnit = this.cacheManager.GetCacheUnit(series);
				long position = series.FirstBlockPosition;
				int num = index;
				this.TryIndex(cacheUnit);
				if (cacheUnit.Index != null)
				{
					IndexItem indexItem = cacheUnit.Index[index];
					if (indexItem != null)
					{
						position = indexItem.BlockPosition;
						num = index - indexItem.ObjectPosition;
					}
				}
				Block block;
				for (;;)
				{
					block = cacheUnit[position];
					if (block == null)
					{
						block = this.ReadBlock(position, false);
					}
					if (num < block.ObjectCount)
					{
						break;
					}
					num -= block.ObjectCount;
					position = block.NextBlockPosition;
				}
				if (cacheUnit.ContainsBlock(block))
				{
					block = cacheUnit.Block;
				}
				else
				{
					this.WriteBlock(series, cacheUnit.Block);
					block = this.ReadBlock(position, true);
					cacheUnit.Block = block;
				}
				ISeriesObject seriesObject = block[num];
				block.RemoveAt(num);
				if (block.ObjectCount == 0)
				{
					Block block2 = this.ReadBlock(block.PrevBlockPosition, false);
					Block block3 = this.ReadBlock(block.NextBlockPosition, false);
					if (block2 != null && block3 != null)
					{
						block2.NextBlockPosition = block3.Position;
						block3.PrevBlockPosition = block2.Position;
						this.WriteBlockReferences(block2);
						this.WriteBlockReferences(block3);
						if (cacheUnit.Block2 != null)
						{
							if (cacheUnit.Block2.Position == block.Position)
							{
								cacheUnit.Block2 = null;
							}
							else
							{
								if (cacheUnit.Block2.Position == block2.Position)
								{
									cacheUnit.Block2.NextBlockPosition = block3.Position;
								}
								if (cacheUnit.Block2.Position == block3.Position)
								{
									cacheUnit.Block2.PrevBlockPosition = block2.Position;
								}
							}
						}
					}
					if (block2 == null && block3 != null)
					{
						block3.PrevBlockPosition = -1L;
						this.WriteBlockReferences(block3);
						series.FirstBlockPosition = block3.Position;
						this.WriteSeriesBlockPositions(series);
						if (cacheUnit.Block2 != null)
						{
							if (cacheUnit.Block2.Position == block.Position)
							{
								cacheUnit.Block2 = null;
							}
							else if (cacheUnit.Block2.Position == block3.Position)
							{
								cacheUnit.Block2.PrevBlockPosition = -1L;
							}
						}
					}
					if (block2 != null && block3 == null)
					{
						block2.NextBlockPosition = -1L;
						this.WriteBlockReferences(block2);
						series.LastBlockPosition = block2.Position;
						this.WriteSeriesBlockPositions(series);
						if (cacheUnit.Block2 != null)
						{
							if (cacheUnit.Block2.Position == block.Position)
							{
								cacheUnit.Block2 = null;
							}
							else if (cacheUnit.Block2.Position == block2.Position)
							{
								cacheUnit.Block2.NextBlockPosition = -1L;
							}
						}
					}
					if (block2 == null && block3 == null)
					{
						series.FirstBlockPosition = -1L;
						series.LastBlockPosition = -1L;
						this.WriteSeriesBlockPositions(series);
						cacheUnit.Block2 = null;
					}
				}
				else if (cacheUnit.Block2 != null && cacheUnit.Block2.Position == block.Position)
				{
					cacheUnit.Block2 = block;
				}
				this.UnRegisterObject(cacheUnit, seriesObject.DateTime);
				if (cacheUnit.Block.ObjectCount == 0)
				{
					cacheUnit.Block = null;
				}
				if (cacheUnit.Block2 != null && index < cacheUnit.FirstObjectPosition)
				{
					cacheUnit.FirstObjectPosition--;
				}
				if (series.IndexPosition != -1L)
				{
					series.IndexPosition = -1L;
					this.WriteSeriesIndexPosition(series);
				}
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000040E0 File Offset: 0x000030E0
		internal void Clear(FileSeries series)
		{
			lock (this)
			{
				series.FirstBlockPosition = -1L;
				series.LastBlockPosition = -1L;
				series.firstDateTime = DateTime.MaxValue;
				series.lastDateTime = DateTime.MinValue;
				series.ObjectCount = 0;
				this.WriteSeriesBlockPositions(series);
				this.WriteSeriesInfo(series);
				this.cacheManager.Clear(series);
				if (series.IndexPosition != -1L)
				{
					series.IndexPosition = -1L;
					this.WriteSeriesIndexPosition(series);
				}
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00004170 File Offset: 0x00003170
		private Block ReadBlock(long position, bool readContent)
		{
			Block block = null;
			if (position >= 0L)
			{
				BinaryReader binaryReader = new BinaryReader(this.dataStream);
				this.dataStream.Position = position;
				long position2 = binaryReader.ReadInt64();
				long prevBlockPosition = binaryReader.ReadInt64();
				long nextBlockPosition = binaryReader.ReadInt64();
				block = new Block(new DateTime(binaryReader.ReadInt64()), new DateTime(binaryReader.ReadInt64()), binaryReader.ReadInt32());
				block.Position = position2;
				block.PrevBlockPosition = prevBlockPosition;
				block.NextBlockPosition = nextBlockPosition;
				if (readContent)
				{
					ZipInputStream zipInputStream = new ZipInputStream(this.dataStream);
					zipInputStream.GetNextEntry();
					MemoryStream memoryStream = new MemoryStream();
					byte[] array = new byte[8192];
					int count;
					while ((count = zipInputStream.Read(array, 0, array.Length)) > 0)
					{
						memoryStream.Write(array, 0, count);
					}
					memoryStream.Position = 0L;
					block.Load(memoryStream, this.formatter);
				}
			}
			return block;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00004258 File Offset: 0x00003258
		private void WriteBlock(Block block, int zipLevel, bool correctReferences)
		{
			BinaryWriter binaryWriter = new BinaryWriter(this.dataStream);
			this.dataStream.Seek(0L, SeekOrigin.End);
			block.Position = this.dataStream.Position;
			binaryWriter.Write(block.Position);
			binaryWriter.Write(block.PrevBlockPosition);
			binaryWriter.Write(block.NextBlockPosition);
			binaryWriter.Write(block.FirstDateTime.Ticks);
			binaryWriter.Write(block.LastDateTime.Ticks);
			binaryWriter.Write(block.ObjectCount);
			MemoryStream memoryStream = new MemoryStream();
			block.Save(memoryStream, this.formatter);
			ZipOutputStream zipOutputStream = new ZipOutputStream(this.dataStream);
			zipOutputStream.SetLevel(zipLevel);
			zipOutputStream.PutNextEntry(new ZipEntry("Block"));
			memoryStream.WriteTo(zipOutputStream);
			zipOutputStream.Flush();
			zipOutputStream.Finish();
			this.dataStream.Flush();
			if (correctReferences)
			{
				this.CorrectReferences(block);
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00004348 File Offset: 0x00003348
		private void WriteBlockReferences(Block block)
		{
			BinaryWriter binaryWriter = new BinaryWriter(this.dataStream);
			this.dataStream.Position = block.Position;
			binaryWriter.Write(block.Position);
			binaryWriter.Write(block.PrevBlockPosition);
			binaryWriter.Write(block.NextBlockPosition);
			binaryWriter.Flush();
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0000439C File Offset: 0x0000339C
		private void CorrectReferences(Block block)
		{
			if (block.PrevBlockPosition != -1L)
			{
				Block block2 = this.ReadBlock(block.PrevBlockPosition, false);
				block2.NextBlockPosition = block.Position;
				this.WriteBlockReferences(block2);
			}
			if (block.NextBlockPosition != -1L)
			{
				Block block3 = this.ReadBlock(block.NextBlockPosition, false);
				block3.PrevBlockPosition = block.Position;
				this.WriteBlockReferences(block3);
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00004400 File Offset: 0x00003400
		private void RegisterObject(CacheUnit unit, DateTime datetime)
		{
			if (datetime < unit.Series.firstDateTime)
			{
				unit.Series.firstDateTime = datetime;
			}
			if (datetime > unit.Series.lastDateTime)
			{
				unit.Series.lastDateTime = datetime;
			}
			unit.Series.ObjectCount++;
			if (unit.Block2 != null && datetime < unit.Block2[0].DateTime)
			{
				unit.FirstObjectPosition++;
			}
			if (unit.Series.IndexPosition != -1L)
			{
				unit.Series.IndexPosition = -1L;
				this.WriteSeriesIndexPosition(unit.Series);
				unit.Index = null;
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000044BC File Offset: 0x000034BC
		private void UnRegisterObject(CacheUnit unit, DateTime datetime)
		{
			if (unit.Series.ObjectCount > 0)
			{
				if (datetime == unit.Series.firstDateTime)
				{
					Block block = unit[unit.Series.FirstBlockPosition];
					if (block == null)
					{
						block = this.ReadBlock(unit.Series.FirstBlockPosition, false);
					}
					if (block != null)
					{
						unit.Series.firstDateTime = block.FirstDateTime;
					}
				}
				if (datetime == unit.Series.lastDateTime)
				{
					Block block2 = unit[unit.Series.LastBlockPosition];
					if (block2 == null)
					{
						block2 = this.ReadBlock(unit.Series.LastBlockPosition, false);
					}
					if (block2 != null)
					{
						unit.Series.lastDateTime = block2.LastDateTime;
					}
				}
				unit.Series.ObjectCount--;
				if (unit.Series.ObjectCount == 0)
				{
					unit.Series.firstDateTime = DateTime.MaxValue;
					unit.Series.lastDateTime = DateTime.MinValue;
					this.WriteSeriesInfo(unit.Series);
				}
				if (unit.Series.IndexPosition != -1L)
				{
					unit.Series.IndexPosition = -1L;
					this.WriteSeriesIndexPosition(unit.Series);
					unit.Index = null;
				}
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000045F4 File Offset: 0x000035F4
		private void ValidateReadBuffer(CacheUnit unit, int requestedPosition)
		{
			if (unit.Block2 == null || requestedPosition < unit.FirstObjectPosition || requestedPosition >= unit.FirstObjectPosition + unit.Block2.ObjectCount)
			{
				this.TryIndex(unit);
				if (unit.Index != null)
				{
					IndexItem indexItem = unit.Index[requestedPosition];
					if (indexItem != null)
					{
						unit.Block2 = this.ReadBlock(indexItem.BlockPosition, true);
						unit.FirstObjectPosition = indexItem.ObjectPosition;
					}
				}
				Block block = unit.Block2;
				if (block == null)
				{
					block = unit[unit.Series.FirstBlockPosition];
					if (block == null)
					{
						block = this.ReadBlock(unit.Series.FirstBlockPosition, false);
					}
					unit.FirstObjectPosition = 0;
				}
				for (;;)
				{
					if (requestedPosition < unit.FirstObjectPosition)
					{
						long position = block.PrevBlockPosition;
						block = unit[position];
						if (block == null)
						{
							block = this.ReadBlock(position, false);
						}
						unit.FirstObjectPosition -= block.ObjectCount;
					}
					else
					{
						if (requestedPosition < unit.FirstObjectPosition + block.ObjectCount)
						{
							break;
						}
						unit.FirstObjectPosition += block.ObjectCount;
						long position = block.NextBlockPosition;
						block = unit[position];
						if (block == null)
						{
							block = this.ReadBlock(position, false);
						}
					}
				}
				unit.Block2 = unit[block.Position];
				if (unit.Block2 == null)
				{
					unit.Block2 = this.ReadBlock(block.Position, true);
				}
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00004748 File Offset: 0x00003748
		private void WriteIndex(CacheUnit unit)
		{
			BinaryWriter binaryWriter = new BinaryWriter(this.indexStream);
			this.indexStream.Seek(0L, SeekOrigin.End);
			unit.Series.IndexPosition = this.indexStream.Position;
			binaryWriter.Write(unit.Index.Count);
			foreach (object obj in unit.Index)
			{
				IndexItem indexItem = (IndexItem)obj;
				binaryWriter.Write(indexItem.DateTime.Ticks);
				binaryWriter.Write(indexItem.ObjectPosition);
				binaryWriter.Write(indexItem.BlockPosition);
			}
			binaryWriter.Flush();
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0000480C File Offset: 0x0000380C
		private void ReadIndex(CacheUnit unit)
		{
			BinaryReader binaryReader = new BinaryReader(this.indexStream);
			this.indexStream.Position = unit.Series.IndexPosition;
			int num = binaryReader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				IndexItem indexItem = new IndexItem();
				indexItem.DateTime = new DateTime(binaryReader.ReadInt64());
				indexItem.ObjectPosition = binaryReader.ReadInt32();
				indexItem.BlockPosition = binaryReader.ReadInt64();
				unit.Index.Add(indexItem);
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x0000488C File Offset: 0x0000388C
		private void TryIndex(CacheUnit unit)
		{
			if (unit.Series.Indexer != Indexer.None && unit.Series.IndexPosition != -1L && unit.Index == null)
			{
				unit.Index = Index.GetIndex(unit.Series.Indexer);
				this.ReadIndex(unit);
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000048DC File Offset: 0x000038DC
		internal void DumpBlocks(FileSeries series)
		{
			CacheUnit cacheUnit = this.cacheManager.GetCacheUnit(series);
			long num = series.FirstBlockPosition;
			Console.WriteLine("Starting dump...");
			Console.WriteLine("Cache:");
			Console.Write("\tBlock: ");
			if (cacheUnit.Block == null)
			{
				Console.WriteLine("null");
			}
			else
			{
				Console.WriteLine(string.Concat(new object[]
				{
					cacheUnit.Block.PrevBlockPosition,
					" ",
					cacheUnit.Block.Position,
					" ",
					cacheUnit.Block.NextBlockPosition,
					" ",
					cacheUnit.Block.FirstDateTime.ToShortDateString(),
					" ",
					cacheUnit.Block.LastDateTime.ToShortDateString(),
					" ",
					cacheUnit.Block.ObjectCount.ToString(),
					" ",
					cacheUnit.Block.IsModified.ToString()
				}));
			}
			Console.Write("\tBlock2: ");
			if (cacheUnit.Block2 == null)
			{
				Console.WriteLine("null");
			}
			else
			{
				Console.WriteLine(string.Concat(new object[]
				{
					cacheUnit.Block2.PrevBlockPosition,
					" ",
					cacheUnit.Block2.Position,
					" ",
					cacheUnit.Block2.NextBlockPosition,
					" ",
					cacheUnit.Block2.FirstDateTime.ToShortDateString(),
					" ",
					cacheUnit.Block2.LastDateTime.ToShortDateString(),
					" ",
					cacheUnit.Block2.ObjectCount.ToString(),
					" ",
					cacheUnit.Block2.IsModified.ToString()
				}));
			}
			Console.WriteLine("Blocks:");
			while (num != -1L)
			{
				Block block = cacheUnit[num];
				if (block == null)
				{
					block = this.ReadBlock(num, false);
				}
				Console.WriteLine(string.Concat(new object[]
				{
					"\t",
					block.PrevBlockPosition,
					" ",
					block.Position,
					" ",
					block.NextBlockPosition,
					" ",
					block.FirstDateTime.ToShortDateString(),
					" ",
					block.LastDateTime.ToShortDateString(),
					" ",
					block.ObjectCount.ToString(),
					" ",
					block.IsModified.ToString()
				}));
				num = block.NextBlockPosition;
			}
			Console.WriteLine("End of dump");
		}

		// Token: 0x04000017 RID: 23
		private const string DATA_FILE_NAME = ".data";

		// Token: 0x04000018 RID: 24
		private const string HEADER_FILE_NAME = ".header";

		// Token: 0x04000019 RID: 25
		private const string INDEX_FILE_NAME = ".index";

		// Token: 0x0400001A RID: 26
		private const byte SERIES_STATUS_OK = 255;

		// Token: 0x0400001B RID: 27
		private const byte SERIES_STATUS_REMOVED = 0;

		// Token: 0x0400001C RID: 28
		private const long SERIES_HEADER_SIZE = 374L;

		// Token: 0x0400001D RID: 29
		private const long SERIES_HEADER_BLOCK_POSITIONS_OFFSET = 266L;

		// Token: 0x0400001E RID: 30
		private const long SERIES_HEADER_INFO_OFFSET = 282L;

		// Token: 0x0400001F RID: 31
		private const long SERIES_HEADER_INDEX_POSITION_OFFSET = 302L;

		// Token: 0x04000020 RID: 32
		private const long SERIES_HEADER_RESERVED_OFFSET = 310L;

		// Token: 0x04000021 RID: 33
		private Stream dataStream;

		// Token: 0x04000022 RID: 34
		private Stream headerStream;

		// Token: 0x04000023 RID: 35
		private Stream indexStream;

		// Token: 0x04000024 RID: 36
		private IFormatter formatter;

		// Token: 0x04000025 RID: 37
		private string location;

		// Token: 0x04000026 RID: 38
		private CacheManager cacheManager;
	}
}
