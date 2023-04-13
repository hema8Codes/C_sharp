
using System.Globalization;

namespace ConsoleApp1
{
    public class A5_Type_Conversion
    {   
        static void Main(string[] args)
        {
            // implicit conversion
            int num = 122332432;
            long bigNum = num;

            float myFloat = 13.37f;
            double myNewDouble = myFloat;

            double myDouble = 13.37;
            int myInt;

            // explicit conversion
            // cast double to int;
            myInt = (int)myDouble;

            // typeCoversion
            string myString = myDouble.ToString();
            string myFloatString = myFloat.ToString();

            Console.WriteLine(myFloatString);

            //Parsing a String To An Integer
            string num1 = "234";
            string num2 = "344";
            string num3 = num1 + num2;

            int n1 = Int32.Parse(num1);
            int n2 = Int32.Parse(num2);
            int resultInt = n1 + n2;
            Console.WriteLine(resultInt);

            string strFloatValue = "119.8765";
            float floatValue = float.Parse(strFloatValue, CultureInfo.InvariantCulture.NumberFormat);
            Console.WriteLine(floatValue);
            Console.Read();

        }

    }
}
