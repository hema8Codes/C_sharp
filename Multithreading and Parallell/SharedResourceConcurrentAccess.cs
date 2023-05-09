
namespace TheBeginningOfCSharp
{
    class ProgramIsAliveJoin
    {
        public static int Sum = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Main method execution started");

            Thread t1 = new Thread(Addition);            
            Thread t2 = new Thread(Addition);
            Thread t3 = new Thread(Addition);

            t1.Start();
            t2.Start();
            t3.Start();

            t1.Join();
            t2.Join();
            t3.Join();

            Console.WriteLine("Total sum is:-" + Sum);
            Console.WriteLine("Main method execution completed");
            Console.ReadLine();

        }
        
        public static void Addition()
        {
            for(int i = 1; i < 50000; i++)
            {
                Sum++;
            }
        }

    }
}
