using System;

namespace TheBeginningOfCSharp //a namespace - used for organisation
{
    class Program // a class - has members (such as a method and data attributes)
    {
        static void Main(string[] args) // a method - contains a block of code
        {
            Console.WriteLine("Hello World!");  // a statement
            Program mp = new Program();
            mp.Print();
        }

        void Print()
        {
            Console.WriteLine("This is awesome");
        }
        
    }
}
    
    // create the method
    // invoke the method
    // namespace -> classes -> members -> method -> statements