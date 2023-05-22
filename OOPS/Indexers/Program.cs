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
            // Indexers -> A way to access elements in a class that represents a list of values
            // An Indexer is nothing but a property 

            var cookie = new HttpCookie();
            cookie["name"] = "Hemakshi";
            Console.WriteLine(cookie["name"]);
        }

    }
}
