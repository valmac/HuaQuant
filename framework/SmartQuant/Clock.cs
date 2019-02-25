using System;
using System.Collections;
using System.Timers;

namespace SmartQuant
{
	// Token: 0x0200003B RID: 59
	public class Clock
	{
		// Token: 0x0600011A RID: 282 RVA: 0x00005464 File Offset: 0x00004464
		static Clock()
		{
			Clock.timer = new Timer();
			Clock.timer.Interval = 1000.0;
			Clock.timer.AutoReset = false;
			Clock.timer.Elapsed += Clock.OnElapsed;
			Clock.timer.Start();
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x0600011B RID: 283 RVA: 0x000054E3 File Offset: 0x000044E3
		// (remove) Token: 0x0600011C RID: 284 RVA: 0x000054FA File Offset: 0x000044FA
		public static event EventHandler ClockModeChanged;

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600011D RID: 285 RVA: 0x00005511 File Offset: 0x00004511
		// (set) Token: 0x0600011E RID: 286 RVA: 0x00005518 File Offset: 0x00004518
		public static ClockMode ClockMode
		{
			get
			{
				return Clock.clockMode;
			}
			set
			{
				lock (typeof(Clock))
				{
					bool flag = Clock.clockMode != value;
					Clock.clockMode = value;
					if (flag)
					{
						if (Clock.clockMode == ClockMode.Realtime)
						{
							DateTime now = DateTime.Now;
							Clock.datetime = new DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute, now.Second);
						}
						Clock.reminders.Clear();
						Clock.EmitClockModeChanged();
					}
				}
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600011F RID: 287 RVA: 0x000055B4 File Offset: 0x000045B4
		public static DateTime Now
		{
			get
			{
				DateTime now;
				switch (Clock.clockMode)
				{
				case ClockMode.Realtime:
					now = DateTime.Now;
					break;
				case ClockMode.Simulation:
					now = Clock.datetime;
					break;
				default:
					throw new NotSupportedException("Not supported clock mode - " + Clock.clockMode);
				}
				return now.Add(Clock.offset);
			}
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00005610 File Offset: 0x00004610
		public static void SetDateTime(DateTime datetime)
		{
			lock (typeof(Clock))
			{
				if (Clock.clockMode == ClockMode.Realtime)
				{
					throw new InvalidOperationException("Cannot set date/time because clock in realtime mode");
				}
				Clock.RunTo(datetime);
			}
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00005660 File Offset: 0x00004660
		public static void AddReminder(ReminderEventHandler handler, DateTime datetime, object data)
		{
			lock (typeof(Clock))
			{
				if (!Clock.rejectReminders)
				{
					if (Clock.datetime > datetime)
					{
						throw new ArgumentException("Cannot set reminder - the datetime must be greater than Clock.Now");
					}
					ArrayList arrayList = Clock.reminders[datetime] as ArrayList;
					if (arrayList == null)
					{
						arrayList = new ArrayList();
						Clock.reminders.Add(datetime, arrayList);
					}
					arrayList.Add(new ReminderItem(handler, data));
				}
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000056F8 File Offset: 0x000046F8
		public static void RemoveReminder(ReminderEventHandler handler, DateTime datetime)
		{
			lock (typeof(Clock))
			{
				ArrayList arrayList = Clock.reminders[datetime] as ArrayList;
				if (arrayList != null)
				{
					Clock.RemoveReminder(arrayList, handler);
				}
			}
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00005750 File Offset: 0x00004750
		public static void RemoveReminder(ReminderEventHandler handler)
		{
			lock (typeof(Clock))
			{
				foreach (object obj in Clock.reminders.Values)
				{
					ArrayList items = (ArrayList)obj;
					Clock.RemoveReminder(items, handler);
				}
			}
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000057D4 File Offset: 0x000047D4
		public static void FireAllReminders()
		{
			lock (typeof(Clock))
			{
				if (Clock.clockMode == ClockMode.Realtime)
				{
					throw new InvalidOperationException("Cannot perform this operation in realtime mode");
				}
				Clock.rejectReminders = true;
				foreach (object obj in Clock.reminders)
				{
					DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
					DateTime signalTime = (DateTime)dictionaryEntry.Key;
					ArrayList arrayList = dictionaryEntry.Value as ArrayList;
					Clock.datetime = signalTime;
					foreach (ReminderItem reminderItem in arrayList.ToArray())
					{
						object[] parameters = new object[]
						{
							new ReminderEventArgs(signalTime, reminderItem.Data)
						};
						try
						{
							Delegate handler = reminderItem.Handler;
							handler.Method.Invoke(handler.Target, parameters);
						}
						catch (Exception e)
						{
							RuntimeErrorManager.ReportError(new RuntimeError(RuntimeErrorLevel.Critical, e));
						}
					}
				}
				Clock.reminders.Clear();
				Clock.rejectReminders = false;
			}
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00005924 File Offset: 0x00004924
		private static void RemoveReminder(ArrayList items, ReminderEventHandler handler)
		{
			int i = 0;
			while (i < items.Count)
			{
				ReminderItem reminderItem = items[i] as ReminderItem;
				if (reminderItem.Handler == handler)
				{
					items.RemoveAt(i);
				}
				else
				{
					i++;
				}
			}
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00005968 File Offset: 0x00004968
		private static void RunTo(DateTime datetime)
		{
			while (Clock.reminders.Count != 0)
			{
				DateTime dateTime = (DateTime)Clock.reminders.GetKey(0);
				if (!(datetime >= dateTime))
				{
					break;
				}
				Clock.datetime = dateTime;
				ArrayList arrayList = (ArrayList)Clock.reminders.GetByIndex(0);
				foreach (ReminderItem reminderItem in arrayList.ToArray())
				{
					object[] parameters = new object[]
					{
						new ReminderEventArgs(dateTime, reminderItem.Data)
					};
					try
					{
						ReminderEventHandler handler = reminderItem.Handler;
						handler.Method.Invoke(handler.Target, parameters);
					}
					catch (Exception e)
					{
						RuntimeErrorManager.ReportError(new RuntimeError(RuntimeErrorLevel.Critical, e));
					}
				}
				Clock.reminders.RemoveAt(0);
			}
			Clock.datetime = datetime;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00005A50 File Offset: 0x00004A50
		private static void Notify()
		{
			DateTime now = Clock.Now;
			while (Clock.reminders.Count != 0)
			{
				DateTime dateTime = (DateTime)Clock.reminders.GetKey(0);
				if (!(now >= dateTime))
				{
					return;
				}
				ArrayList arrayList = Clock.reminders.GetByIndex(0) as ArrayList;
				foreach (ReminderItem reminderItem in arrayList.ToArray())
				{
					object[] parameters = new object[]
					{
						new ReminderEventArgs(dateTime, reminderItem.Data)
					};
					try
					{
						Delegate handler = reminderItem.Handler;
						handler.Method.Invoke(handler.Target, parameters);
					}
					catch (Exception e)
					{
						RuntimeErrorManager.ReportError(new RuntimeError(RuntimeErrorLevel.Critical, e));
					}
				}
				Clock.reminders.RemoveAt(0);
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00005B34 File Offset: 0x00004B34
		private static void OnElapsed(object sender, ElapsedEventArgs e)
		{
			lock (typeof(Clock))
			{
				if (Clock.clockMode == ClockMode.Realtime)
				{
					DateTime now = DateTime.Now;
					Clock.RunTo(new DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute, now.Second));
				}
				Clock.timer.Start();
			}
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00005BB8 File Offset: 0x00004BB8
		private static void EmitClockModeChanged()
		{
			if (Clock.ClockModeChanged != null)
			{
				Clock.ClockModeChanged(null, null);
			}
		}

		// Token: 0x040000E8 RID: 232
		private static ClockMode clockMode = ClockMode.Realtime;

		// Token: 0x040000E9 RID: 233
		private static DateTime datetime = DateTime.Now;

		// Token: 0x040000EA RID: 234
		private static TimeSpan offset = TimeSpan.Zero;

		// Token: 0x040000EB RID: 235
		private static SortedList reminders = new SortedList();

		// Token: 0x040000EC RID: 236
		private static Timer timer;

		// Token: 0x040000ED RID: 237
		private static bool rejectReminders = false;
	}
}
