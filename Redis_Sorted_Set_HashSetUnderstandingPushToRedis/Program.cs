using RedisWorkClient;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RedisWorkClient
{
    class Program
{
    static void Main(string[] args)
    {

            GetSetHashSortedInterface callme = new HashSortedImplementation();

            /*
            
            // All data -> hashset

            string name;
            int age;
            string email;
            string location;
          
            int n;

            Console.WriteLine("\n Enter the number of records you want to enter");
            n = Int32.Parse(Console.ReadLine());

            int id = 1;

            for(int i = 0; i < n; i++)
            {
                name = Console.ReadLine();
                age = Int32.Parse(Console.ReadLine());
                email = Console.ReadLine();
                location = Console.ReadLine();

                HashEntry[] User = { new HashEntry("name", name), new HashEntry("age", age), new HashEntry("email", email), new HashEntry("location", location) };

                string UserStr = $"User : {id++}";
                callme.AddAndSaveHashSetData(UserStr, User);

            }
            */

            // fetch a hash set data

            //string val = callme.GetHashSetData("User : 3", "name");
            //Console.WriteLine(val);

            /*

            int t;

            Console.WriteLine("\n Enter the number of records you want to enter");
            t = Int32.Parse(Console.ReadLine());


            for (int i = 0; i < t; i++)
            {
                string namep = Console.ReadLine();
                double score = Double.Parse(Console.ReadLine());
                callme.SaveSortedSetData("Player", namep, score);
            }

            */

            callme.ProcessAndGetSortedSetData("Player", 0);













        }



    }


}
