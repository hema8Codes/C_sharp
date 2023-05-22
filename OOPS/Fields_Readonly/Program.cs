using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSLearning
{
    partial class Program
    {
        public static void Main(string[] args)
        {

            var customer = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            // readonly is used in situations where you know that the variable should only be initialized once
            // it provides safety for reset of a variable.
            //customer.Promote();

            Console.WriteLine(customer.Orders.Count);
        }

    }
}
