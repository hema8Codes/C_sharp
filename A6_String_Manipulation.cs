
using System.Globalization;
using System.Xml;

namespace ConsoleApp1
{
    public class A6_String_Manipulation
    {   
        static void Main(string[] args)
        {
            // variables
            int cost = 250;
            string productName = "shirt";

            // 1. string concatenation
            Console.WriteLine("String Concatenation");
            Console.WriteLine("The cost of the product " + productName + " is " + cost + " dollars ");

            // 2. string formatting
            // string formatting uses index
            Console.WriteLine("String Formatting");
            Console.WriteLine("The cost of the product {0} is more than {1} dollars", productName, cost);

            // 3. String interpolation
            //string Interpolation uses $ at the start which will allow us to write our
            // variables like this {variableName}
            Console.WriteLine("String Interpolation");
            Console.WriteLine($"The cost of the product {productName} is more than {cost} dollars");

            //4. Verbatim strings
            // Verbatim strings start with @ and tells the compiler to take the string
            // literally and ignore any spaces and escape character like \n
            Console.WriteLine("Verbatim Strings");
            Console.WriteLine(@"Hey 
this is verbatim 
        string");




        }

    }
}
