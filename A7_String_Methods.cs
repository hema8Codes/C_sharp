
using System.Globalization;
using System.Xml;

namespace ConsoleApp1
{
    public class A7_String_Methods
    {   
        static void Main(string[] args)
        {

            // string is an object of the System.String class.
            // In programming terms, string means sequence of characters.

            // Functions of the String class are used to manipulate and to perform various actions on a given string.

            // SubString(int32) - is used to get the substring from the string, starting from the speciefied index

            // ToLower() - is used to convert the string to lowercase

            // ToUpper() - is used to convert the string to uppercase

            // Trim() - is used to trim all leading and trailing white space from the string

            // IndexOf(string) - is used to get the first occurrence of the string or character inside the string

            // IsNullorWhiteSpace - returns true if the string is either null or is blank else return false

            // String.Format() -  is used to insert the object or variable value inside any string
            // With String.Format() we can replace the value in the specified format
            // String.Format("any string {index}", object);

            string firstName = "Hemakshi  ";
            string lastName = "Pandey";
            var anyVar = "developement";

            string fullName = string.Concat(firstName, lastName);

            Console.WriteLine(fullName);
            Console.WriteLine(firstName.Substring(2)); 
            Console.WriteLine(firstName.ToLower());
            Console.WriteLine(firstName.ToUpper());
            Console.WriteLine(fullName.Trim());
            Console.WriteLine(firstName.IndexOf('k'));
            Console.WriteLine(String.IsNullOrWhiteSpace(firstName));
            string formated = String.Format(" software {0} ", anyVar);
            Console.WriteLine(formated);


        }

    }
}
