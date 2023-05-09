﻿
namespace TheBeginningOfCSharp
{
    class ProgramIsAliveJoin
    {
 
        static void Main(string[] args)
        {
            Console.WriteLine("Main method execution started");

            Thread t1 = new Thread(ProgramIsAliveJoin.Method1);
            t1.Start();
            Thread t2 = new Thread(ProgramIsAliveJoin.Method2);
            t2.Start();

            if (t1.Join(2000))
            {
                Console.WriteLine("Method1 execution completed");
            }


            t2.Join();
            Console.WriteLine("Method2 execution completed");

            if (t1.IsAlive)
            {
                Console.WriteLine("method1 execution is still going on");
            }
            else
            {
                Console.WriteLine("method1 execution completed");
            }

            Console.WriteLine("Main method execution completed");
            Console.ReadLine();

        }

        static void Method1()
        {
            Console.WriteLine("Method1 execution started");
            Thread.Sleep(5000);
            Console.WriteLine("method 1 is awake");
        }

        static void Method2()
        {
            Console.WriteLine("Method2 execution started");
        }

    }
}
