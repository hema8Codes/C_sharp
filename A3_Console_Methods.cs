
namespace ConsoleApp1
{
    public class A3_Console_Methods
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear(); 
            Console.Write("text here"); // Prints and keeps the cursor on the same line.
            Console.WriteLine("text here"); // Prints and puts the the cursor in the next line.
            var val = Console.Read(); //Takes a single input of type string and it returns the ASCII value of that input
            Console.WriteLine(val);
            Console.ReadLine(); // Takes a string or integer and returns it as the output
            Console.ReadKey(); // Takes a single input of the type string and it returns the key info
            string rd = Console.ReadLine();
            Console.WriteLine("value of the string" + rd);
        }

    }
}
