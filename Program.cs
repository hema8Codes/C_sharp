
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    public class Program
    {
       
        static void Main(string[] args)
        {
            float x = 99.8293f;
            Console.WriteLine(x);
            bool isGPSEnabled = true;
            bool switch_flag = true;
            Console.WriteLine(isGPSEnabled);
            Console.WriteLine(switch_flag);
            char singleLetter = 'A';
            string userName = "";
            Console.WriteLine(singleLetter);
            Console.WriteLine(userName);
            // declaring a variable
            int num1;
            // assigning a value to a variable
            num1 = 13;
            // declaring and initializing a variable in one go
            Console.WriteLine(num1);
            // sum 
            int num2 = 23;
            int sum = num1 + num2;

            // using concatenation
            Console.WriteLine("num is " + num1);
            Console.WriteLine("num1: " + num1 + " + num2: " + num2 + " is " + sum);

            // declaring multiple variable at once
            int num3, num4, num5;

            //double variable
            double d1 = 3.1415;
            double d2 = 5.1;
            double dDiv = d1 / d2;
            Console.WriteLine("d1/d2 is " + dDiv);

            //float variable
            float f1 = 3.1415f;
            float f2 = 5.1f;
            float fDiv = f1 / f2;
            Console.WriteLine("f1/f2 is "+ fDiv);
            Console.Read();
            

        }
    }
}