using System.Diagnostics;
using System.Threading;

namespace TheBeginningOfCSharp 
{
    class TerminatingParallelLoop 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine($"Main Thread : {Thread.CurrentThread.ManagedThreadId} Started");
            int length = 300;
            int data = 0;

            Console.WriteLine("C# parallel for loop");

            List<int> collection = Enumerable.Range(0, 10).ToList();
            Console.WriteLine("Standard foreach loop");

            Stopwatch _watch = Stopwatch.StartNew();
            foreach(int item in collection)
            {
                Console.WriteLine($"the value is {item} Thread : {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(10);
            }
            _watch.Stop();
            Console.WriteLine("Time taken "+ _watch.ElapsedMilliseconds);

            Console.WriteLine("Parallel foreach loop");
            _watch.Reset();
            _watch.Start();
            Parallel.ForEach(collection, i =>
            {
                Console.WriteLine($"the value is {i} Thread : {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(10);
            });
            _watch.Stop();
            Console.WriteLine("Time taken " + _watch.ElapsedMilliseconds);

            Console.WriteLine($"Main Thread : {Thread.CurrentThread.ManagedThreadId} Completed");
            Console.ReadLine();
        }

    }
}


    
  