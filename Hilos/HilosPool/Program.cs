using System;
using System.Diagnostics;
using System.Threading;

namespace HilosPool
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Stopwatch sw = new Stopwatch();

            Console.WriteLine("Thread Pool Execution");
            sw.Start();
            ProcessWithThreadPoolMethod();
            sw.Stop();
            Console.WriteLine("Time consumed by ProcessWithThreadPoolMethod is : " + sw.ElapsedMilliseconds);
            
            Console.WriteLine("Thread Execution");            
            sw.Restart();
            ProcessWithThreadMethod();
            sw.Stop();
            Console.WriteLine("Time consumed by ProcessWithThreadMethod is : " + sw.ElapsedMilliseconds);

        }

        static void ProcessWithThreadPoolMethod()
        {
            for (int i = 0; i <= 10; i++)
            {
                ThreadPool.QueueUserWorkItem(Process);
            }
        }

        static void ProcessWithThreadMethod()
        {
            for (int i = 0; i <= 10; i++)
            {
                Thread obj = new Thread(Process);
                obj.Start();
                obj.Join();

            }
        }

        static void Process(object callback)
        {
            Console.WriteLine("I am Process");
        }
                
    }

}
