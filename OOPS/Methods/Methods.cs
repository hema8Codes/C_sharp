using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSLearning
{   
    // Out Modifier
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public void Move(Point newLocation)
        {
            //this.X = newLocation.X;
            //this.Y = newLocation.Y;
            if (newLocation == null)
                throw new ArgumentNullException("newLocation");

            Move(newLocation.X, newLocation.Y);
        }
    }
    public class Calculator
    {   
        //Params Modifier
        public int AddNums(params int[] ListNumbers)
        {
            int total = 0;

            foreach(int i in  ListNumbers)
            {
                total += i;
            }
            return total;
        }

        // Ref Modifier
        public void Add(ref int a) {
            a += 2;
        } 
    }
    class Methods
    {
        public static void Main(string[] args)
        {
            var a = 1;
            ; var calculator = new Calculator();
            Console.WriteLine(calculator);
            Calculator cal = new Calculator();
            //ref modifier
            cal.Add(ref a);
            Console.WriteLine("The Value of a = "+ a);


            //out modifier

            try
            {
                var num = int.Parse("abc");
            }
            catch(Exception e)
            {
                Console.WriteLine("Conversion failed");
            }

            //var number = int.Parse("abc");
            int number;
            var result = int.TryParse("abc", out number);
            if (result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion failed");


        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator);
            Calculator cal = new Calculator();
            //param modifier
            int y = cal.AddNums(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            Console.WriteLine("The Value of List of Numbers = " + y);
            Console.WriteLine(cal.AddNums(1, 2));
            Console.WriteLine(cal.AddNums(1, 2, 3));
            Console.WriteLine(cal.AddNums(1, 2, 3, 4));
            Console.WriteLine(cal.AddNums(1, 2, 3, 4, 5));
        }
        static void UsePoints()
        {
            try
            {
                //out modifier
                var point = new Point(10, 20);
                point.Move(new Point(40, 60));
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occured.");
            }
        }
    }
}
