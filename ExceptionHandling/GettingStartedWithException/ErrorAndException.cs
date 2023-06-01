using static System.Console;

namespace MyProjectLearning
{
    class ErrorAndException
    {

        public static void Main(string[] args)
        {
            
            // ** Error Handling in C# **
            // 1. Creating  and Throwing an Exception
            // 2. Getting  Started with Exception Catching
            WriteLine("Enter first number");
            int number1 = int.Parse(ReadLine()!);

            WriteLine("Enter second number");
            int number2 = int.Parse(ReadLine()!);

            WriteLine("Enter operation");
            string operation = ReadLine()!.ToUpperInvariant();

            try
            {
                var calculator = new SimpleConsoleCalculator();
                int result = calculator.Calculate(number1, number2, operation);
                DisplayResult(result);
            }
            catch (Exception ex)
            {
                WriteLine($"Sorry, something went wrong. {ex}");
            }
            WriteLine("\nPress enter to exit");
            ReadLine();

            static void DisplayResult(int result) => WriteLine($"Result is: {result}");

            // Exception Handling Good Practices
            // 1. Do not add a catch block that does nothing or just rethrows
            // -> Catch block shoul add some value
            // -> May just be to log the error
            // -> Usually bad practices to ignore (swallow/trap) exceptions
            //Avoid catching and swallowing exceptions: Avoid catching exceptions without taking any appropriate action. 
            // Swallowing exceptions by not handling or logging them can make it difficult to identify and diagnose issues.
            // This can lead to silent failures, unexpected behavior, and a lack of visibility into the underlying problems.
            // 2. Do not use exceptions for normal program flow logic
            // -> Eg. input validation
            // -> You expect input to be invalid sometimes
            // -> Not an exceptional situation
            // -> Part of expected logic flow
            // IsValid(xxx)method(s)
            // 3. Design code to avoid exceptions
            //  - int Parse(string input)
            //  - bool TryParse(string input, out int result)
            //  - if(cn.State != ConnectionState.Closed)
            // {
            //      cn.Closed();
            // }
            //  - Consider returning null (or null object pattern) for extremely common errors
            // 4. Use correct grammer in exception messages
            //    - Consider error message localization
            // 5. Use finally blocks for clean-up
            // - Eg. calling Dispose()
            // - Callers of the methods should be able to assume no unexpected side effects when exception thrown / caught 


        }

    }
}


