using System;
using System.Threading;

namespace ConsoleApplication8
{
    class Class1
    {
        public void TimerCallback(Object obj)
        {
            Console.WriteLine("Timer triggered");
            ((AutoResetEvent)obj).Set();
            Thread.Sleep(1000);
            ((AutoResetEvent)obj).Set();
        }

        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            AutoResetEvent ev = new AutoResetEvent(false);
            Timer timer = new Timer(new TimerCallback(obj.TimerCallback), ev, 1000, 0);
            ev.WaitOne();
            Console.WriteLine("Event Fired");
            ev.WaitOne();
            Console.WriteLine("Event Fired");
        }
    }
}
