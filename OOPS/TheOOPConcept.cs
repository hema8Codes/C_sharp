
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace TheBeginningOfCSharp
{
    public class Person { 

    public string Name;

    public void Introduce(string to)
    {
            Console.WriteLine("Hi {0}, I am {1}", Name, to);
    }

    public static Person Parse(string str)
    {
            var person = new Person();
            person.Name = str;
            return person;
    }
}
    class TheOOPConcept
    {
        static void Main(string[] args)
        {
          
            var person = Person.Parse("Harry");
            person.Introduce("Wizard");

        }

    }
}

