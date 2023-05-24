using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1_Stopwatch
{
    static class Commands
    {
        public static void Run()
        {
            Console.WriteLine("This is a stopwatch program");
            Console.WriteLine("Press 1 to start the stopwatch");
            Console.WriteLine("Press 2 to stop the stopwatch");
            Console.WriteLine("Press 3 to reset the stopwatch");
            Console.WriteLine("Perss 0 to exit the program");
            Console.WriteLine("Choose desired operation from the options above.");

            var stopwatch = new Stopwatch();
            int command = -1;

            do
            {
                try
                {
                    command = int.Parse(Console.ReadLine());

                    switch (command)
                    {
                        case 1:
                            {
                                stopwatch.Start();
                                break;
                            }
                        case 2:
                            {
                                stopwatch.Stop();
                                break;
                            }
                        case 3:
                            {
                                stopwatch.Reset();
                                break;
                            }
                        case 0:
                            {
                                Console.WriteLine("Thank you for using my stopwatch program!");
                                Console.ReadLine();
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Please enter a valid option from the options above.");
                                break;
                            }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error details: {0}", ex.Message);
                    Console.WriteLine("Please enter a valid option from the options above.");
                }
            } while (command != 0);
        }
    }
}
