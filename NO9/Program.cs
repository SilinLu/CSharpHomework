//第四讲第二题
using System;
using System.Threading;

namespace NO9
{
    public delegate void ClockHandler(object sender);

    public class ClockTick
    {
        public event ClockHandler tick;
        public void Tick()
        {
            
            tick(this);
        }
    }
    public class ClockAlarm
    {
        public event ClockHandler alarm;
        public void Alarm()
        {

            alarm(this);
        }
    }
    
    public class Form
    {
        public ClockTick clockTick = new ClockTick();
        public ClockAlarm clockAlarm = new ClockAlarm();
        public Form()
        {
            clockTick.tick += new ClockHandler(Clock_Tick);
            clockAlarm.alarm += new ClockHandler(Clock_Alarm);
            void Clock_Tick(object sender)
            {
                Console.WriteLine("Clock tick");
            }
            void Clock_Alarm(object sender)
            {
                Console.WriteLine("Clock Alarm");
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Form form1 = new Form();
            while (true)
            {
                Thread.Sleep(1000);
                form1.clockTick.Tick();
                Console.WriteLine(DateTime.Now.ToLongTimeString());
                if (DateTime.Now.ToLongTimeString() == "0:51:50")
                {
                    
                    form1.clockAlarm.Alarm();
                }

            }
            

        }
    }
}
