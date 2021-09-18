//第四讲第二题
using System;
using System.Threading;

namespace NO9
{
    public delegate void ClockHandler(object sender,ClockEventArgs args);
    public class ClockEventArgs
    { 
        public DateTime currentTime { get; set; }
    }
    public class Clock
    {
        public event ClockHandler tick;
        public event ClockHandler alarm;
        public ClockEventArgs args;
        public void Alarm(DateTime t)
        {

            args = new ClockEventArgs() { currentTime = t };
            Console.WriteLine(t);
            alarm(this, args);
        }
        public void Tick(DateTime t)
        {
            args = new ClockEventArgs() { currentTime = t };
            Console.WriteLine(t);
            tick(this, args);
        }
    }



    public class Form
    {
        public Clock clock = new Clock();

        public Form()
        {
            clock.alarm += new ClockHandler(Clock_Alarm);
            clock.tick += new ClockHandler(Clock_Tick);
        }
        void Clock_Tick(object sender,ClockEventArgs args)
        {
            Console.WriteLine("Clock tick");
        }
        void Clock_Alarm(object sender, ClockEventArgs args)
        {
            Console.WriteLine("Clock alarm");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form();
            DateTime t;
            while (true)
            {
                t = DateTime.Now;
                Thread.Sleep(1000);
                form.clock.Alarm(t);
                if (t.ToLongTimeString() == "11:27:00") {
                    form.clock.Tick(t);
                }
            }
        }
    }
}
