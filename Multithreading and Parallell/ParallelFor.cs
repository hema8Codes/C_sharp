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
            Console.WriteLine("C# standard for loop");

            Stopwatch _watch= Stopwatch.StartNew();
            _watch.Start();
            for( int i = 0; i < length; i++ )
            {
                Console.WriteLine($" the value is {i} and Thread : {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep( 10 );
            }
            _watch.Stop();
            Console.WriteLine("time taken " + _watch.ElapsedMilliseconds);

            Console.WriteLine("C# parallel for loop");
            _watch.Reset();
            _watch.Start();
            Parallel.For(0, length, count =>
            {
                Console.WriteLine($"the value is {count} and Thread : {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(10);
            });
            _watch.Stop();
            Console.WriteLine("time taken " + _watch.ElapsedMilliseconds);

            Console.WriteLine($"Main Thread : {Thread.CurrentThread.ManagedThreadId} Completed");
            Console.ReadLine();
        }

    }
}


    
  