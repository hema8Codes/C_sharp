
using MyCSLearning;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace TheBeginningOfCSharp
{
    class ObjectInitializers { 
        static void Main(string[] args)
        {
            var person = new Person
            {
                FirstName = "Harry",
                LastName = "Potter"
            };

            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.LastName);
        }

    }
}

