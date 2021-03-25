using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    class Clock
    {
        static public string alarmTime = "00:00:00";

        public delegate void ClockEventHandler(DateTime dateTime);

        public event ClockEventHandler Tick;
        public event ClockEventHandler Alarm;

        public void TimeUpdate(DateTime dateTime)
        {
            Tick(dateTime);
            Alarm(dateTime);
        }

        static public void ClockTick(DateTime dateTime)
        {
            Console.WriteLine(dateTime.ToString()+"     Tick!");
        }

        static public void ClockAlarm(DateTime dateTime)
        {
            if (dateTime.ToLongTimeString().Equals(Clock.alarmTime)) Console.WriteLine("!!!The alarm is ringing!!!");
        }
    }
}
