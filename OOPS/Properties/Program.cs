using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSLearning
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Properties
            // A class member that encapsulates a getter/setter for accessing a field
            // why ? -> To create a getter/setter with less code
                
            var person = new Person(new DateTime(1982, 1, 1));
            Console.WriteLine(person.Age);
        }

    }
}
