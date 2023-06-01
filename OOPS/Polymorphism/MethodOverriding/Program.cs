using System;
using System.Collections;
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

            // Method overriding 
            // Virtual / override keywords

            // Method Overriding
            // Modifying the implementation of an inherited method

            var shapes = new List<Shape>();
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);  

        }

    }
}
