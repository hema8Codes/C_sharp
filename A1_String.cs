
namespace ConsoleApp1
{
    public class A1_String
    {
        static void Main(string[] args)
        {
            string myname = "Harry";
            string message = "My name is " + myname;

            Console.WriteLine(myname);
            Console.WriteLine(message);
            string capMessage = message.ToUpper();
            Console.WriteLine(capMessage);
            string lowCaseMessage = message.ToLower();
            Console.WriteLine(lowCaseMessage.Length);
            Console.Read();
        }

    }
}
