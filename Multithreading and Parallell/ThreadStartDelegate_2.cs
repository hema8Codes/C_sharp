
namespace TheBeginningOfCSharp
{
    class Multithreading
    {
        static void Main(string[] args)
        {

            //Creating Threads
            ThreadStart obj = new ThreadStart(ShowNumbers);
            Thread t1 = new Thread(obj);
            t1.Start();
            Console.ReadLine();

        }

        static void ShowNumbers()
        {
            for(int i = 0; i< 5; i++)
            {
                Console.WriteLine(i);
            }
        }



    }
}
