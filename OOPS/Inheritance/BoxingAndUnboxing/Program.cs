using System;
using System.Collections;
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
            // Boxing and Unboxing 

            // - Value Types and Reference Types
            // - Boxing and Unboxing
            
            // # Value Types
            // Are stored on the stack
            // Examples:
            // All primitive types: byte, int , float, char, bool
            // The struct type

            // # Reference Types
            // Are stored in the heap
            // Examples:
            // Any classes (Object, Array, String, DbMigrator, etc)

            // Also...
            // The Object class is the base of all classes in .NET Framework

            // BOXING
            
            // The process of converting a value type instance to an object reference
            // int number = 10;
            // object obj = number;

            // or
            // object obj = 10;

            // UNBOXING

            // object obj = 10;
            // int number = (int) obj;

            // Boxing and Unboxing have a performance penalty


        }

    }
}
