using System;
using System.Threading;
namespace ThreadSample
{
    class Class1
    {
        static void PrintHelloFromThreadName()
        {
            Console.WriteLine("Hello, from thread {0}",
                Thread.CurrentThread.Name); // {0} 
        }

        public void ThreadStart()
        {
            PrintHelloFromThreadName();
        }

        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "Luong chinh";
            Class1 obj = new Class1();
            Thread thread = new Thread(new ThreadStart(obj.ThreadStart));
            thread.Name = "Luong Forked";
            thread.Start();
            PrintHelloFromThreadName();
        }
    }
}