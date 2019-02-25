using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Design;
using System.Threading;
using SmartQuant.Data;
using SmartQuant.Simulation.Design;

namespace SmartQuant.Simulation
{
	// Token: 0x02000018 RID: 24
	public class Simulator
	{
		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000087 RID: 135 RVA: 0x00004B98 File Offset: 0x00003B98
		// (remove) Token: 0x06000088 RID: 136 RVA: 0x00004BB1 File Offset: 0x00003BB1
		public event SeriesObjectEventHandler NewObject;

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000089 RID: 137 RVA: 0x00004BCA File Offset: 0x00003BCA
		// (remove) Token: 0x0600008A RID: 138 RVA: 0x00004BE3 File Offset: 0x00003BE3
		public event ExceptionEventHandler Error;

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x0600008B RID: 139 RVA: 0x00004BFC File Offset: 0x00003BFC
		// (remove) Token: 0x0600008C RID: 140 RVA: 0x00004C15 File Offset: 0x00003C15
		public event EventHandler EnterSimulation;

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x0600008D RID: 141 RVA: 0x00004C2E File Offset: 0x00003C2E
		// (remove) Token: 0x0600008E RID: 142 RVA: 0x00004C47 File Offset: 0x00003C47
		public event EventHandler ExitSimulation;

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x0600008F RID: 143 RVA: 0x00004C60 File Offset: 0x00003C60
		// (remove) Token: 0x06000090 RID: 144 RVA: 0x00004C79 File Offset: 0x00003C79
		public event EventHandler StateChanged;

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06000091 RID: 145 RVA: 0x00004C92 File Offset: 0x00003C92
		// (remove) Token: 0x06000092 RID: 146 RVA: 0x00004CAB File Offset: 0x00003CAB
		public event IntervalEventHandler EnterInterval;

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06000093 RID: 147 RVA: 0x00004CC4 File Offset: 0x00003CC4
		// (remove) Token: 0x06000094 RID: 148 RVA: 0x00004CDD File Offset: 0x00003CDD
		public event IntervalEventHandler LeaveInterval;

		// Token: 0x06000095 RID: 149 RVA: 0x00004CF8 File Offset: 0x00003CF8
		public Simulator()
		{
			this.intervals = new IntervalList();
			this.inputSeries = new DataSeriesList();
			this.simulationMode = SimulationMode.MaxSpeed;
			this.speedMultiplier = 1.0;
			this.doWork = false;
			this.doPause = false;
			this.step = 0;
			this.stepEnabled = false;
			this.objectsInInterval = 0;
			this.state = SimulatorState.Stopped;
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00004D61 File Offset: 0x00003D61
		[Editor(typeof(DataSeriesListEditor), typeof(UITypeEditor))]
		public DataSeriesList InputSeries
		{
			get
			{
				return this.inputSeries;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00004D69 File Offset: 0x00003D69
		public IntervalList Intervals
		{
			get
			{
				return this.intervals;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00004D71 File Offset: 0x00003D71
		// (set) Token: 0x06000099 RID: 153 RVA: 0x00004D7C File Offset: 0x00003D7C
		[DefaultValue(SimulationMode.MaxSpeed)]
		public SimulationMode SimulationMode
		{
			get
			{
				return this.simulationMode;
			}
			set
			{
				lock (this)
				{
					if (this.state != SimulatorState.Stopped)
					{
						throw new InvalidOperationException("You cannot change the mode while simulator is not stopped");
					}
					this.simulationMode = value;
				}
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00004DC4 File Offset: 0x00003DC4
		// (set) Token: 0x0600009B RID: 155 RVA: 0x00004DCC File Offset: 0x00003DCC
		[DefaultValue(1.0)]
		public double SpeedMultiplier
		{
			get
			{
				return this.speedMultiplier;
			}
			set
			{
				lock (this)
				{
					if (this.state == SimulatorState.Running)
					{
						throw new InvalidOperationException("You cannot change the speed multiplier while simulator is running");
					}
					if (value <= 0.0)
					{
						throw new ArgumentException("The multiplier must be greater then zero");
					}
					this.speedMultiplier = value;
				}
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00004E2C File Offset: 0x00003E2C
		// (set) Token: 0x0600009D RID: 157 RVA: 0x00004E34 File Offset: 0x00003E34
		[DefaultValue(0)]
		public int Step
		{
			get
			{
				return this.step;
			}
			set
			{
				lock (this)
				{
					if (this.state == SimulatorState.Running)
					{
						throw new InvalidOperationException("Your cannot change step while simulator is running");
					}
					if (value < 0)
					{
						throw new ArgumentException("The step must be equal or greater then zero");
					}
					this.step = value;
				}
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00004E8C File Offset: 0x00003E8C
		[Browsable(false)]
		public bool StepEnabled
		{
			get
			{
				return this.stepEnabled;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00004E94 File Offset: 0x00003E94
		[Browsable(false)]
		public int ObjectsInInterval
		{
			get
			{
				return this.objectsInInterval;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00004E9C File Offset: 0x00003E9C
		[Browsable(false)]
		public SimulatorState CurrentState
		{
			get
			{
				return this.state;
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00004EA4 File Offset: 0x00003EA4
		public void Start(bool wait)
		{
			lock (this)
			{
				if (this.state != SimulatorState.Stopped)
				{
					throw new InvalidOperationException("The simulator is already running");
				}
				this.stepEnabled = false;
				this.doWork = true;
				this.thread = new Thread(new ThreadStart(this.Run));
				this.thread.Name = "Simulator";
				this.thread.Start();
			}
			if (wait)
			{
				this.thread.Join();
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00004F34 File Offset: 0x00003F34
		public void Start()
		{
			this.Start(false);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00004F40 File Offset: 0x00003F40
		public void Stop(bool wait)
		{
			lock (this)
			{
				if (this.state == SimulatorState.Running || this.state == SimulatorState.Paused)
				{
					this.doWork = false;
					this.doPause = false;
				}
			}
			if (wait)
			{
				while (this.state != SimulatorState.Stopped)
				{
					Thread.Sleep(1);
				}
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00004FA4 File Offset: 0x00003FA4
		public void Stop()
		{
			this.Stop(true);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00004FB0 File Offset: 0x00003FB0
		public void Pause()
		{
			lock (this)
			{
				if (this.state != SimulatorState.Running)
				{
					throw new InvalidOperationException("Cannot pause simulator because it is not running");
				}
				this.doPause = true;
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00004FFC File Offset: 0x00003FFC
		public void Continue()
		{
			lock (this)
			{
				if (this.state != SimulatorState.Paused)
				{
					throw new InvalidOperationException("Cannot continue simulator because it is not paused");
				}
				this.stepEnabled = false;
				this.doPause = false;
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000504C File Offset: 0x0000404C
		public void DoStep(bool wait)
		{
			lock (this)
			{
				if (this.state == SimulatorState.Running)
				{
					throw new InvalidOperationException("Cannot perform operation 'Step' because simulator is running");
				}
				this.stepEnabled = true;
				switch (this.state)
				{
				case SimulatorState.Stopped:
					this.doWork = true;
					this.thread = new Thread(new ThreadStart(this.Run));
					this.thread.Name = "Simulator";
					this.thread.Start();
					goto IL_8D;
				case SimulatorState.Paused:
					this.doPause = false;
					goto IL_8D;
				}
				throw new ApplicationException("Unknown simulator state");
				IL_8D:;
			}
			if (wait)
			{
				while (this.state != SimulatorState.Paused)
				{
					Thread.Sleep(1);
				}
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00005114 File Offset: 0x00004114
		public void DoStep()
		{
			this.DoStep(true);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00005120 File Offset: 0x00004120
		private void Run()
		{
			try
			{
				Clock.ClockMode = ClockMode.Simulation;
				this.state = SimulatorState.Running;
				this.EmitStateChanged();
				this.EmitEnterSimulationEvent();
				foreach (object obj in this.intervals)
				{
					Interval interval = (Interval)obj;
					if (!this.doWork)
					{
						break;
					}
					Clock.SetDateTime(interval.Begin);
					this.EmitEnterIntervalEvent(interval);
					ArrayList arrayList = new ArrayList();
					this.objectsInInterval = 0;
					foreach (object obj2 in new ArrayList(this.inputSeries))
					{
						IDataSeries dataSeries = (IDataSeries)obj2;
						int num = dataSeries.IndexOf(interval.Begin, SearchOption.Next);
						int num2 = dataSeries.IndexOf(interval.End.AddMilliseconds(1.0), SearchOption.Prev);
						if (num != -1 && num <= num2)
						{
							QueueEntry queueEntry = new QueueEntry();
							queueEntry.Series = dataSeries;
							queueEntry.Object = (dataSeries[num] as IDataObject);
							queueEntry.CurrentPosition = num + 1;
							queueEntry.EndPosition = num2;
							arrayList.Add(queueEntry);
							int num3 = (queueEntry.Object is Bar) ? 2 : 1;
							this.objectsInInterval += (num2 - num + 1) * num3;
						}
					}
					if (arrayList.Count > 0)
					{
						arrayList.Sort();
						DateTime dateTime = (arrayList[0] as QueueEntry).Object.DateTime;
						DateTime dateTime2 = (this.simulationMode == SimulationMode.MaxSpeed) ? interval.End.AddYears(1) : dateTime;
						DateTime dateTime3 = (this.step == 0) ? DateTime.MaxValue : dateTime.AddSeconds((double)this.step);
						DateTime d = DateTime.Now;
						DateTime dateTime4 = dateTime2;
						while (arrayList.Count > 0 && this.doWork)
						{
							for (;;)
							{
								if (this.doPause)
								{
									this.state = SimulatorState.Paused;
									this.EmitStateChanged();
									DateTime now = DateTime.Now;
									while (this.doPause)
									{
										Thread.Sleep(1);
									}
									DateTime now2 = DateTime.Now;
									if (this.doWork)
									{
										if (this.simulationMode == SimulationMode.UserDefinedSpeed)
										{
											d = d.AddTicks(now2.Ticks - now.Ticks);
										}
										if (this.simulationMode == SimulationMode.MaxSpeed && dateTime3 < Clock.Now)
										{
											dateTime3 = Clock.Now.AddSeconds((double)this.step);
										}
										this.state = SimulatorState.Running;
										this.EmitStateChanged();
									}
								}
								if (!this.doWork)
								{
									break;
								}
								bool flag = false;
								QueueEntry queueEntry2 = arrayList[0] as QueueEntry;
								if ((this.simulationMode != SimulationMode.UserDefinedSpeed || !(dateTime2 >= dateTime3)) && (this.simulationMode != SimulationMode.MaxSpeed || !(queueEntry2.Object.DateTime >= dateTime3)))
								{
									goto IL_2D9;
								}
								dateTime3 = dateTime3.AddSeconds((double)this.step);
								if (!this.stepEnabled)
								{
									goto IL_2D9;
								}
								this.doPause = true;
								flag = true;
								IL_4FA:
								if (!flag)
								{
									break;
								}
								continue;
								IL_2D9:
								if (dateTime2 >= queueEntry2.Object.DateTime)
								{
									arrayList.RemoveAt(0);
									if (queueEntry2.Object is Bar || queueEntry2.Object is BarObject)
									{
										if (queueEntry2 is QueueEntry2)
										{
											BarObject barObject = queueEntry2.Object as BarObject;
											QueueEntry2 queueEntry3 = queueEntry2 as QueueEntry2;
											queueEntry3.Bar.High = barObject.Bar.High;
											queueEntry3.Bar.Low = barObject.Bar.Low;
											queueEntry3.Bar.Close = barObject.Bar.Close;
											queueEntry3.Bar.Volume = barObject.Bar.Volume;
											queueEntry3.Bar.OpenInt = barObject.Bar.OpenInt;
											queueEntry3.Bar.EndTime = barObject.Bar.EndTime;
											queueEntry3.Bar.IsComplete = true;
											queueEntry3.Object = queueEntry3.Bar;
										}
										else
										{
											Bar bar = queueEntry2.Object as Bar;
                                            BarObject barObj = new BarObject(bar);
                                            barObj.DateTime = bar.EndTime;
                                            this.InsertEntry(arrayList, new QueueEntry2
											{
												Bar = bar,
												Series = queueEntry2.Series,
												Object = barObj,
												CurrentPosition = 1,
												EndPosition = 0,	
											});
											bar.High = bar.Open;
											bar.Low = bar.Open;
											bar.Close = bar.Open;
											bar.Volume = 0L;
											bar.OpenInt = 0L;
											bar.IsComplete = false;
										}
									}
									this.EmitNewObject(queueEntry2.Series, queueEntry2.Object);
									if (queueEntry2.CurrentPosition <= queueEntry2.EndPosition)
									{
										queueEntry2.Object = (queueEntry2.Series[queueEntry2.CurrentPosition] as IDataObject);
										queueEntry2.CurrentPosition++;
										this.InsertEntry(arrayList, queueEntry2);
									}
									flag = (arrayList.Count > 0);
									goto IL_4FA;
								}
								goto IL_4FA;
							}
							if (this.simulationMode == SimulationMode.UserDefinedSpeed)
							{
								Clock.SetDateTime(dateTime2);
								Thread.Sleep(1);
								DateTime now3 = DateTime.Now;
								dateTime2 = dateTime4.Add(new TimeSpan((long)((double)(now3 - d).Ticks * this.speedMultiplier)));
							}
						}
					}
					Clock.FireAllReminders();
					this.EmitLeaveIntervalEvent(interval);
				}
			}
			finally
			{
				Clock.ClockMode = ClockMode.Realtime;
				this.EmitExitSimulationEvent();
				this.state = SimulatorState.Stopped;
				this.EmitStateChanged();
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00005718 File Offset: 0x00004718
		public override string ToString()
		{
			return this.state.ToString();
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000572C File Offset: 0x0000472C
		private void EmitNewObject(IDataSeries series, IDataObject obj)
		{
			DateTime dateTime;
			if (obj is Bar)
			{
				Bar bar = obj as Bar;
				dateTime = (bar.IsComplete ? bar.EndTime : bar.BeginTime);
			}
			else
			{
				dateTime = obj.DateTime;
			}
			Clock.SetDateTime(dateTime);
			if (this.NewObject != null)
			{
				this.NewObject(new SeriesObjectEventArgs(series, obj));
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00005788 File Offset: 0x00004788
		private void EmitErrorEvent(Exception exception)
		{
			if (this.Error != null)
			{
				this.Error(new ExceptionEventArgs(exception));
			}
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000057A3 File Offset: 0x000047A3
		private void EmitEnterSimulationEvent()
		{
			if (this.EnterSimulation != null)
			{
				this.EnterSimulation(this, EventArgs.Empty);
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000057BE File Offset: 0x000047BE
		private void EmitExitSimulationEvent()
		{
			if (this.ExitSimulation != null)
			{
				this.ExitSimulation(this, EventArgs.Empty);
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000057D9 File Offset: 0x000047D9
		private void EmitStateChanged()
		{
			if (this.StateChanged != null)
			{
				this.StateChanged(this, EventArgs.Empty);
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x000057F4 File Offset: 0x000047F4
		private void EmitEnterIntervalEvent(Interval interval)
		{
			if (this.EnterInterval != null)
			{
				this.EnterInterval(new IntervalEventArgs(interval));
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000580F File Offset: 0x0000480F
		private void EmitLeaveIntervalEvent(Interval interval)
		{
			if (this.LeaveInterval != null)
			{
				this.LeaveInterval(new IntervalEventArgs(interval));
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000582C File Offset: 0x0000482C
		private void InsertEntry(ArrayList queue, QueueEntry entry)
		{
			if (queue.Count == 0)
			{
				queue.Add(entry);
				return;
			}
			bool flag = entry is QueueEntry2;
			int num = entry.CompareTo(queue[0]);
			if (num < 0 || (num == 0 && flag))
			{
				queue.Insert(0, entry);
				return;
			}
			num = entry.CompareTo(queue[queue.Count - 1]);
			if (num > 0 || (num == 0 && !flag))
			{
				queue.Add(entry);
				return;
			}
			DateTime dateTime = entry.Object.DateTime;
			int num2 = 0;
			int num3 = queue.Count - 1;
			int num4;
			for (;;)
			{
				num4 = (num3 + num2) / 2;
				DateTime dateTime2 = (queue[num4] as QueueEntry).Object.DateTime;
				DateTime dateTime3 = (queue[num4 + 1] as QueueEntry).Object.DateTime;
				if (flag)
				{
					if (dateTime2 < dateTime && dateTime <= dateTime3)
					{
						break;
					}
					if (dateTime > dateTime3)
					{
						num2 = num4 + 1;
					}
					else if (dateTime <= dateTime2)
					{
						num3 = num4;
					}
				}
				else
				{
					if (dateTime2 <= dateTime && dateTime < dateTime3)
					{
						break;
					}
					if (dateTime >= dateTime3)
					{
						num2 = num4 + 1;
					}
					else if (dateTime < dateTime2)
					{
						num3 = num4;
					}
				}
			}
			queue.Insert(num4 + 1, entry);
		}

		// Token: 0x04000060 RID: 96
		private const SimulationMode DEFAULT_SIMULATION_MODE = SimulationMode.MaxSpeed;

		// Token: 0x04000061 RID: 97
		private const double DEFAULT_SPEED_MULTIPLIER = 1.0;

		// Token: 0x04000062 RID: 98
		private const int DEFAULT_STEP = 0;

		// Token: 0x04000063 RID: 99
		private IntervalList intervals;

		// Token: 0x04000064 RID: 100
		private DataSeriesList inputSeries;

		// Token: 0x04000065 RID: 101
		private SimulationMode simulationMode;

		// Token: 0x04000066 RID: 102
		private double speedMultiplier;

		// Token: 0x04000067 RID: 103
		private Thread thread;

		// Token: 0x04000068 RID: 104
		private bool doWork;

		// Token: 0x04000069 RID: 105
		private bool doPause;

		// Token: 0x0400006A RID: 106
		private SimulatorState state;

		// Token: 0x0400006B RID: 107
		private int step;

		// Token: 0x0400006C RID: 108
		private bool stepEnabled;

		// Token: 0x0400006D RID: 109
		private int objectsInInterval;
	}
}
