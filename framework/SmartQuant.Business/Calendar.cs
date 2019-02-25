using System;

namespace SmartQuant.Business
{
	// Token: 0x02000002 RID: 2
	public class Calendar
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00001050
		// (set) Token: 0x06000002 RID: 2 RVA: 0x00002058 File Offset: 0x00001058
		public string Name
		{
			get
			{
				return this.fName;
			}
			set
			{
				this.fName = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002061 File Offset: 0x00001061
		// (set) Token: 0x06000004 RID: 4 RVA: 0x00002069 File Offset: 0x00001069
		public string Description
		{
			get
			{
				return this.fDescription;
			}
			set
			{
				this.fDescription = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002072 File Offset: 0x00001072
		public HolidayList Holidays
		{
			get
			{
				return this.fHolidays;
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000207A File Offset: 0x0000107A
		public void Init()
		{
			this.fHolidays = new HolidayList();
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002087 File Offset: 0x00001087
		public Calendar()
		{
			this.Init();
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002095 File Offset: 0x00001095
		public Calendar(string name, string description)
		{
			this.fName = name;
			this.fDescription = description;
			this.Init();
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000020B1 File Offset: 0x000010B1
		public Calendar(string name)
		{
			this.fName = name;
			this.Init();
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000020C6 File Offset: 0x000010C6
		public void AddHoliday(Holiday holiday)
		{
			this.fHolidays.Add(holiday);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000020D4 File Offset: 0x000010D4
		public void AddHoliday(DateTime date, string name, string description)
		{
			this.fHolidays.Add(new Holiday(date, name, description));
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000020E9 File Offset: 0x000010E9
		public void AddHoliday(DateTime date, string name)
		{
			this.fHolidays.Add(new Holiday(date, name));
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000020FD File Offset: 0x000010FD
		public Holiday GetHoliday(DateTime date)
		{
			return this.fHolidays[date];
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000210B File Offset: 0x0000110B
		public static bool IsWeekend(DateTime date)
		{
			return date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002123 File Offset: 0x00001123
		public bool IsHoliday(DateTime date)
		{
			return !this.IsBusinessDay(date);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000212F File Offset: 0x0000112F
		public bool IsBusinessDay(DateTime date)
		{
			return !Calendar.IsWeekend(date) && this.GetHoliday(date) == null;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002148 File Offset: 0x00001148
		public int GetNBusinessDays(DateTime date1, DateTime date2)
		{
			int num = 0;
			DateTime dateTime = date1;
			while (dateTime <= date2)
			{
				if (this.IsBusinessDay(dateTime))
				{
					num++;
				}
				dateTime = dateTime.AddDays(1.0);
			}
			return num;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002184 File Offset: 0x00001184
		public static int GetNWeekends(DateTime date1, DateTime date2)
		{
			int num = 0;
			DateTime dateTime = date1;
			while (dateTime <= date2)
			{
				if (Calendar.IsWeekend(dateTime))
				{
					num++;
				}
				dateTime = dateTime.AddDays(1.0);
			}
			return num;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000021C0 File Offset: 0x000011C0
		public int GetNHolidays(DateTime date1, DateTime date2)
		{
			int num = 0;
			DateTime dateTime = date1;
			while (dateTime <= date2)
			{
				if (this.IsHoliday(dateTime))
				{
					num++;
				}
				dateTime = dateTime.AddDays(1.0);
			}
			return num;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000021FB File Offset: 0x000011FB
		public DateTime GetNextBusinessDay(DateTime date)
		{
			do
			{
				date = date.AddDays(1.0);
			}
			while (!this.IsBusinessDay(date));
			return date;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002219 File Offset: 0x00001219
		public static DateTime GetNextWeekend(DateTime date)
		{
			do
			{
				date = date.AddDays(1.0);
			}
			while (!Calendar.IsWeekend(date));
			return date;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002236 File Offset: 0x00001236
		public static DateTime GetNextNonWeekend(DateTime date)
		{
			while (Calendar.IsWeekend(date))
			{
				date = date.AddDays(1.0);
			}
			return date;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002255 File Offset: 0x00001255
		public static DateTime GetPrevNonWeekend(DateTime date)
		{
			while (Calendar.IsWeekend(date))
			{
				date = date.AddDays(-1.0);
			}
			return date;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002274 File Offset: 0x00001274
		public DateTime GetNextHoliday(DateTime date)
		{
			do
			{
				date = date.AddDays(1.0);
			}
			while (!this.IsHoliday(date));
			return date;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002292 File Offset: 0x00001292
		public DateTime GetPrevBusinessDay(DateTime date)
		{
			do
			{
				date = date.AddDays(-1.0);
			}
			while (!this.IsBusinessDay(date));
			return date;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000022B0 File Offset: 0x000012B0
		public static DateTime GetPrevWeekend(DateTime date)
		{
			do
			{
				date = date.AddDays(-1.0);
			}
			while (!Calendar.IsWeekend(date));
			return date;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000022CD File Offset: 0x000012CD
		public DateTime GetPrevHoliday(DateTime date)
		{
			do
			{
				date = date.AddDays(-1.0);
			}
			while (!this.IsHoliday(date));
			return date;
		}

		// Token: 0x04000001 RID: 1
		private string fName;

		// Token: 0x04000002 RID: 2
		private string fDescription;

		// Token: 0x04000003 RID: 3
		private HolidayList fHolidays;
	}
}
