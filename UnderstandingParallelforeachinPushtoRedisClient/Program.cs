
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace TheCSharpLearningDataStructueOptimization
{
    public class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

            ConcurrentDictionary<long, List<DatastructureforImei>> dictdata = new ConcurrentDictionary<long, List<DatastructureforImei>>();

            int n = 6;
            int m = 2;
            bool flag = false;

            for (int i = 0; i < 1000; i++)
            {
                List<DatastructureforImei> lt = new List<DatastructureforImei>();
                if (flag == false)
                {
                    for (int j = 0; j < n; j++)
                    {
                        DatastructureforImei mei = new DatastructureforImei();
                        mei.imeiNumber = 234243 + j;
                        mei.imeiNumberPivotSlot = $"2LPS324{j}";

                        lt.Add(mei);
                    }
                    flag = true;
                }
                else
                {
                    for (int j = 0; j < m; j++)
                    {
                        DatastructureforImei mei = new DatastructureforImei();
                        mei.imeiNumber = 233558 + j;
                        mei.imeiNumberPivotSlot = $"7LPSU56{j}";

                        lt.Add(mei);
                    }
                    flag = false;

                }

                dictdata.TryAdd(2398340 + i, lt);
            }

            sw.Start();
            foreach (var d in dictdata)
            {
                Console.Write($" KEY = {d.Key}  VALUE = ");
                foreach (var i in d.Value)
                {
                    Console.Write($" {i.imeiNumber} | {i.imeiNumberPivotSlot}");
                }
                Console.WriteLine();
            }
            sw.Stop();
            long time = sw.ElapsedMilliseconds;
            Console.WriteLine($"time taken {time}");
            sw.Reset();
            sw.Start();


            Parallel.ForEach(dictdata, new ParallelOptions{
                MaxDegreeOfParallelism = 4}, d =>
            {
                Console.Write($" KEY = {d.Key}  VALUE = ");
                foreach (var i in d.Value)
                {
                    Console.Write($" {i.imeiNumber} | {i.imeiNumberPivotSlot}");
                }
                Console.WriteLine();

            });

            sw.Stop();
            long time2 = sw.ElapsedMilliseconds;
            Console.WriteLine($"time taken {time2}");




        }
    }
}
