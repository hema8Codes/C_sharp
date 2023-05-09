
namespace TheBeginningOfCSharp
{
    public delegate void SumOfNumberCallbackDelegate(int SumOfNum);
    class PassingDataToThreadTypeSafeManner
    {
        public static void DisplaySumofNo(int Sum)
        {
            Console.WriteLine("the sum of numbers is :- " + Sum);
        } 
        static void Main(string[] args)
        {
            int max = 10;
            SumOfNumberCallbackDelegate _callback = new SumOfNumberCallbackDelegate(DisplaySumofNo);
            NumberHelper _helper = new NumberHelper(max, _callback);
            ThreadStart obj = new ThreadStart(_helper.ShowNumbers);

            Thread t = new Thread(obj);
            t.Start();
            Console.ReadLine();
        }



        public class NumberHelper
        {
            private int _Number;
            SumOfNumberCallbackDelegate _callbackDelegate;

            public NumberHelper(int num, SumOfNumberCallbackDelegate _delegate)
            {
                _Number = num;
                _callbackDelegate = _delegate;
            }
            public void ShowNumbers()
            {
                int sum = 0;
                for (int i = 0; i < _Number; i++)
                {
                    sum = sum + i;
                }
                if(_callbackDelegate != null)
                {
                    _callbackDelegate(sum);
                }
            }
        }



    }
}
