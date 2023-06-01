using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectLearning
{
    public class SimpleConsoleCalculator
    {

        public int Calculate(int number1, int number2, string operation)
        {
            if (operation == "/")
            {
                return Divide(number1, number2);
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(operation), "The mathematical operator is not supported");
                
                //Console.WriteLine("Unknown Operation.");
                //return 0;
            }

        }
        private int Divide(int number, int divisor) => number / divisor;

    }
}
