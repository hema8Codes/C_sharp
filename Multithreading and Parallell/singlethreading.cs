
namespace TheBeginningOfCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Thread t = Thread.CurrentThread;
            //t.Name = "Main Thread";
            //Console.WriteLine("Thread name - " + t.Name);
            //Console.WriteLine("My current thread - " + Thread.CurrentThread.Name);

            Method1();
            Console.WriteLine("Method 1 excution is completed");
            Method2();
            Console.WriteLine("Method 2 excution is completed");
            Method3();
            Console.WriteLine("Method 3 excution is completed");

            Console.ReadLine();

        }

        static void Method1()
        {
            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method1 :"+ i);
            }
        }

        static void Method2()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method2 :" + i);
                if(i == 2)
                {
                    Console.WriteLine("executing code Started");
                    //sleep for 10 seconds
                    Thread.Sleep(10000);
                    Console.WriteLine("executing code Completed");
                }
            }
        }

        static void Method3()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method3 :" + i);
            }
        }

    }
}
