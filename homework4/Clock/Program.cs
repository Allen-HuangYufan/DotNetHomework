using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please set the alarm(hh:mm:ss)");
            Clock.alarmTime = Console.ReadLine();
            Timer timer = new Timer(1000);
            timer.AutoReset = true;
            timer.Elapsed += new ElapsedEventHandler(TimeLapse);
            timer.Start();
            Console.ReadLine();
        }

        static void TimeLapse(object sender, ElapsedEventArgs args)
        {
            Clock clock = new Clock();
            clock.Tick += new Clock.ClockEventHandler(Clock.ClockTick);
            clock.Alarm += new Clock.ClockEventHandler(Clock.ClockAlarm);
            clock.TimeUpdate(DateTime.Now);
        }
    }
}
