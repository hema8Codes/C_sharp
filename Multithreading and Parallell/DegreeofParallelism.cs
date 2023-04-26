using System.Diagnostics;
using System.Threading;

namespace TheBeginningOfCSharp 
{
    class ParallelFor 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine($"Main Thread : {Thread.CurrentThread.ManagedThreadId} Started");
            int length = 10;

            Console.WriteLine("C# parallel for loop");

            ParallelOptions _options = new ParallelOptions
            {
                MaxDegreeOfParallelism = 4
            };

            Parallel.For(0, length, _options, count =>
            {
                Console.WriteLine($"the value is {count} and Thread : {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(10);
            });


            Console.WriteLine($"Main Thread : {Thread.CurrentThread.ManagedThreadId} Completed");
            Console.ReadLine();
        }

    }
}


    
  