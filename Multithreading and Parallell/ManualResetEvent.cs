
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace TheBeginningOfCSharp
{
    class MonitorPulseWaitPulseAllMultithreading
    {
        static ManualResetEvent _mre = new ManualResetEvent(false);
        static void Main(string[] args)
        {
            Console.WriteLine("Main method execution started");

            Thread t1 = new Thread(Write);
            Thread t2 = new Thread(Read);

            t1.Start();
            for(int i = 0; i < 5; i++)
            {
                new Thread(Read).Start();
            }

            Console.WriteLine("Main method execution completed");
            Console.ReadLine();

        }

        public static void Write()
        {
                Console.WriteLine("Write Thread Working... ");
                _mre.Reset();
                Thread.Sleep(5000);
                Console.WriteLine("Write Thread Completed... ");
                _mre.Set();
        }

        public static void Read()
        {
                Console.WriteLine("Read Thread Wait... ");
                _mre.WaitOne();
                Console.WriteLine("Read Thread Completed... ");
        }
    }
}

