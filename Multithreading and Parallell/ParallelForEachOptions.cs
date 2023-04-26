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

            Console.WriteLine("Parallel foreach loop");

            var option = new ParallelOptions()
            {
                MaxDegreeOfParallelism = 2
            };
            Parallel.ForEach(collection, option, i =>
            {
                Console.WriteLine($"the value is {i} Thread : {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(10);
            });

            Console.WriteLine($"Main Thread : {Thread.CurrentThread.ManagedThreadId} Completed");
            Console.ReadLine();
        }

    }
}


    
  