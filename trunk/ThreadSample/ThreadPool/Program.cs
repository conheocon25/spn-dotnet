using System;
using System.Threading;
using System.Diagnostics;

namespace ConsoleApplication2
{
    public class Ware
    {
        public int id;
        public Ware(int _id)
        {
            id = _id;
        }
    }

    class Class1
    {
        public int QueueLength;

        public Class1()
        {
            QueueLength = 0;
        }

        public void Produce(Ware ware)
        {
            ThreadPool.QueueUserWorkItem(
                new WaitCallback(Consume), ware);
            QueueLength++;
        }

        public void Consume(Object obj)
        {
            Console.WriteLine("Thread {0} consumes {1}",
                Thread.CurrentThread.GetHashCode(), //{0} 
                ((Ware)obj).id); //{1} 
            Thread.Sleep(100);
            QueueLength--;
        }

        public static void Main(String[] args)
        {
            Class1 obj = new Class1();
            for (int i = 0; i < 1000; i++)
            {
                obj.Produce(new Ware(i));
            }
            Console.WriteLine("Thread {0}",
                Thread.CurrentThread.GetHashCode()); //{0} 
            while (obj.QueueLength != 0)
            {
                Thread.Sleep(1000);
            }
        }
    }
}
