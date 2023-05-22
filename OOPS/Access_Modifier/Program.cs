using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSLearning
{
    public class Customer
    {
        private string Name;
    }

    public class Person
    {
        private string Name;
        private DateTime _birthdate;

        public void SetName(string name)
        {
            if(!String.IsNullOrEmpty(name))
                this.Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return _birthdate;
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            // Access Modifier
            // A way to control access to a class and/or it's members
            // why ? -> To create safety in our programs

            var Object1 = new Customer();
            // Object1.Name;  // won't compile

            // Object Oriented Programming

            // Encapsulation / Information Hiding
            // Inheritance
            // Polymorphism

            var person = new Person();
            person.SetBirthdate(new DateTime(1982, 1, 1));
            Console.WriteLine(person.GetBirthdate());   

        }

    }
}
