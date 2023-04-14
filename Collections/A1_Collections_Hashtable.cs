

using System.Collections;
using System.Security.Cryptography;

namespace ConsoleApp1
{
    public class A1_Collections_Hashtable
    {   
        static void Main(string[] args)
        {
            // Collections 
            // Generic and Non-Generic Collections in C#

            // A Generic collection is a class that provides type safety
            // Generic Collection is strongly typed while a Non Generic Collection is not strongly typed

            // Hashtable stores values in key/value pair
            // All elements (Keys & Values) are of object type
            // cannnot contain duplicate keys
            // System.Collections

            // HashTable
            Hashtable ht = new Hashtable();

            //Adding Items to a Hashtable

            ht.Add("India", "Hindi");
            ht.Add("China", "Mandarin");
            ht.Add("Belgium", "French");
            ht.Add("UK", "English");

            foreach(DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key+ " "+ d.Value);
            }

            // Retriving an Item value from Hastable
            // table["key"] --> "value"

            string country = ht["India"].ToString();
            Console.WriteLine(country);
            Console.WriteLine(ht["Belgium"]);

            // Removing Items from a Hashtable
            // table.Remove("key")

            ht.Remove("China");

            // Looking through all the items of Hashtable
            // DictionaryEntry: is a class whose object represents the data in combination of Key & Value pairs

            // Updating value 
            ht["Beligium"] = "english";

            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine($"Key = {item.Key} Value = {item.Value}");
            }

            Console.WriteLine(ht.ContainsKey("UAE")); // check whether the particular key exists or not

            Console.WriteLine(ht.ContainsValue("Hindi"));  // check whether the value exists or not

            // ----------------------------------------
            // Properties of Hashtable

            Hashtable myTable = new Hashtable();
            myTable.Add("shirt",1200);
            myTable.Add("jacket",1390);
            myTable.Add("cap",900);
            myTable.Add("sweater", 5000);
            myTable.Add("shoes",3000);
            myTable.Add("dress", 7000);

            // Count -> gets the number of key/value pair in Hashtable.
            Console.WriteLine(myTable.Count);

            // IsFixedSize -> gets a bool value indicating whether the Hashtable has fixed size
            Console.WriteLine(myTable.IsFixedSize);

            // IsReadOnly -> gets a bool value indicating whether the Hashtable is read only
            Console.WriteLine(myTable.IsReadOnly);

            // Keys -> Gets the collection of keys from Hashtable
            var keys = myTable.Keys;
            foreach(object e in keys)
            Console.WriteLine(e);

            // Methods of Hashtable
            // Add()
            // Remove()
            // Clear()
            // Clone()
            // Contains(), ContainsKey()

            var table = myTable.Clone();
            

            //myTable.Clear();

        }

    }
}
