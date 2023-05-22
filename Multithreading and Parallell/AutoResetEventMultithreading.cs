
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace TheBeginningOfCSharp
{
    class AutoResetEventMultithreading
    {
        static AutoResetEvent _event = new AutoResetEvent(false);
        static void Main(string[] args)
        {
            Console.WriteLine("Main method execution started");

            Thread t1 = new Thread(Write);

            for(int i = 0; i < 5; i++)
            {
                new Thread(Write).Start();
            }

            Thread.Sleep(4000);
            _event.Set();
            Console.WriteLine("Main method execution completed");
            Console.ReadLine();

        }

        public static void Write()
        {
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "Write Thread Waiting..");
                _event.WaitOne();
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "Write Thread Working... ");
                
                Thread.Sleep(5000);
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "Write Thread Completed... ");
                _event.Set();
                
        }


    }
}

