using System;
using System.Threading;
namespace ThreadSample
{
    class Class1
    {
        static void MethodA()
        {
            for (int i = 0; i < 100; i++)
                Console.Write("0");
        }

        static void MethodB()
        {
            for (int i = 0; i < 100; i++)
                Console.Write("1");
        }

        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(MethodA));
            t.IsBackground = true;
            t.Start();
            MethodB(); 
        }
    }
}