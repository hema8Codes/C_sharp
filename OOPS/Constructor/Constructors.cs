
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace TheBeginningOfCSharp
{
    class Constructors { 
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.Name = "Hemakshi";

            var order = new Order();
            customer.Orders.Add(order);

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
            Console.WriteLine();

        }

    }
}

