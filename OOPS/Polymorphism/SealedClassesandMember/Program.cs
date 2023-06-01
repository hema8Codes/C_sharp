using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSLearning
{
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle");
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {

            // Abstract Classes and Members

            // Abstract Modifier indicates that a class or a member is missing implementation

            // Abtract Members
            // - Do not include implementation
            // - If a member is declared as abtract, the containing class needs to be declared as abstract too
            // - Must implement all abtract members in the base abstract class.
            // - Cannot be instantiated

            // Why to use Abstract?
            // - When you want to provide some common behaviour, while forcing other developer to follow your design.

            var circle = new Circle();
            circle.Draw();

            var rectangle = new Rectangle();
            rectangle.Draw();

        }

    }
}
