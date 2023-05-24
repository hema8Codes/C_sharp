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

            // Upcasting and DownCasting 
            // Agenda
            // Conversion from a derived class to a base class (upcasting)
            // Conversion from a base class to derived class (downcasting)
            // The as and is keywords

            // eg -> base class -> Shape
            // derived class -> Circle

            // --Upcasting --
            // Circle circle =  new Circle();
            // Shape shape = circle;

            // --Downcasting--
            // Circle anotherCircle = (Circle)shape;
            // Car car = (Car)shape; // throws InvalidCastException

            // THE 'as' KEYWORD

            // To prevent this exception, use 'as' Keyword

            // Car car = shape as Car;
            // if(car != null)
            // {
            //    ............
            // }

            // when we use as keyword if the object cannot be connverted to target type null is returned
            // then we can check if the result the resultant variable is not null

            // THE 'is' KEYWORD
            // With 'is' keyword we can check the type of an object

            // if(obj is car)
            // {
            //    Car car = (Car) obj;
            //    ...
            // }


            // IMPLEMENTATION

            // Shape -> base class
            // Text -> derived class



            //Text text = new Text();
            //Shape shape = text; // Here Text and Shape has the reference to the same object 
            Shape shape = new Shape();
            Text text = (Text)shape;

            Text text1 = new Text();
            Shape shape2 = text1;

            //text.
            
            // but they have different views

            //text.Width = 200;
            //shape.Width = 100;

            //Console.WriteLine(text.Width);
            // We are going to get value 100 because 
            // both text and shape are the reference to the same object

            /*

            StreamReader reader = new StreamReader(new MemoryStream());
            var list = new ArrayList();
            list.Add(1);
            list.Add("Mosh");
            list.Add(new Text());

            var anotherList = new List<Shape>();

            */

            Shape shape1 = new Text();
        }

    }
}
