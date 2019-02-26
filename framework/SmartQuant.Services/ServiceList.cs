using System;
using System.Collections;
using System.Collections.Generic;

namespace SmartQuant.Services
{
	// Token: 0x0200000F RID: 15
	public class ServiceList : ICollection, IEnumerable
	{
		// Token: 0x0600002C RID: 44 RVA: 0x000021AF File Offset: 0x000011AF
		internal ServiceList()
		{
			this.servicesByName = new SortedList<string, IService>();
			this.servicesById = new SortedList<byte, IService>();
			this.services = new List<IService>();
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000021D8 File Offset: 0x000011D8
		public void CopyTo(Array array, int index)
		{
			this.services.ToArray().CopyTo(array, index);
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600002E RID: 46 RVA: 0x000021EC File Offset: 0x000011EC
		public int Count
		{
			get
			{
				return this.services.Count;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600002F RID: 47 RVA: 0x000021F9 File Offset: 0x000011F9
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000030 RID: 48 RVA: 0x000021FC File Offset: 0x000011FC
		public object SyncRoot
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000021FF File Offset: 0x000011FF
		public IEnumerator GetEnumerator()
		{
			return this.services.GetEnumerator();
		}

		// Token: 0x17000014 RID: 20
		public IService this[string name]
		{
			get
			{
				IService result;
				if (this.servicesByName.TryGetValue(name, out result))
				{
					return result;
				}
				return null;
			}
		}

		// Token: 0x17000015 RID: 21
		public IService this[byte id]
		{
			get
			{
				IService result;
				if (this.servicesById.TryGetValue(id, out result))
				{
					return result;
				}
				return null;
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002254 File Offset: 0x00001254
		internal void Add(IService service)
		{
			this.servicesByName.Add(service.Name, service);
			this.servicesById.Add(service.Id, service);
			this.SynchronizeList();
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002280 File Offset: 0x00001280
		private void SynchronizeList()
		{
			this.services.Clear();
			foreach (IService item in this.servicesByName.Values)
			{
				this.services.Add(item);
			}
		}

		// Token: 0x04000009 RID: 9
		private SortedList<string, IService> servicesByName;

		// Token: 0x0400000A RID: 10
		private SortedList<byte, IService> servicesById;

		// Token: 0x0400000B RID: 11
		private List<IService> services;
	}
}
