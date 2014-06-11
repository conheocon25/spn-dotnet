using System;
using System.Threading;
using System.Diagnostics;

namespace ConsoleApplication7
{
    class Class1
    {
        public void Pump()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Value {0}", i);
                Thread.Sleep(1);
            }
        }

        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            Thread pump = new Thread(
                new ThreadStart(obj.Pump));
            pump.Start();
            Thread.Sleep(500); // force the other thread 
            // thru a couple iterations 
            pump.Join(); // wait until the thread is 
            // completed 
            Console.WriteLine("Goodbye");
        }
    }
}