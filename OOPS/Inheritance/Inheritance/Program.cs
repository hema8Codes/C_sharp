using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBeginningOfCSharp
{
    class Program
    {
        public static void Main(string[] args)
        {

            // Access

            // public -> Accessible from everywhere
            // private -> Accessible only from the class
            // protected -> Accessible only from the class and it's derived classes
            // internal -> Accessible only from the same assembly
            // protected internal -> Accessible only from the same assembly or any derived classes

            // In C#, we use access modifiers to control visibility of the class member

            var customer = new Customer();

        }

    }
}
