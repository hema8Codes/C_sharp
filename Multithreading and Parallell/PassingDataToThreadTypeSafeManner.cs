
namespace TheBeginningOfCSharp
{
    class ParameterizedThreadStartDelegate_2
    {
        static void Main(string[] args)
        {
            int max = 10;
            NumberHelper _helper = new NumberHelper(max);
            ThreadStart obj = new ThreadStart(_helper.ShowNumbers);

            Thread t = new Thread(obj);
            t.Start();
            Console.ReadLine();
        }



        public class NumberHelper
        {
            private int _Number;

            public NumberHelper(int num)
            {
                _Number = num;
            }
            public void ShowNumbers()
            {
                for (int i = 0; i < _Number; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }



    }
}
