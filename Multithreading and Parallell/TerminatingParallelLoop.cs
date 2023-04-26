using System.Diagnostics;
using System.Threading;

namespace TheBeginningOfCSharp 
{
    class DegreeofParallelism 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine($"Main Thread : {Thread.CurrentThread.ManagedThreadId} Started");
            int length = 300;
            int data = 0;

            Console.WriteLine("C# parallel for loop");


            Parallel.For(0, length, (count,breakCount) =>
            {
                data = data + count;
                if (data > 100)
                {
                    breakCount.Break();
                    Console.WriteLine($"the value is {count} and data : {data}");
                }
            });


            Console.WriteLine($"Main Thread : {Thread.CurrentThread.ManagedThreadId} Completed");
            Console.ReadLine();
        }

    }
}


    
  