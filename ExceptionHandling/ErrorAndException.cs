namespace MyProjectLearning
{
    class Program
    {

        public static void Main(string[] args)
        {
            // ** Error Handling in C# **

            // - How to respond to runtime errors 
            // - How to indicate an error occurred
            // - How errors are represented
            // - How to rethrow and wrap exception
            // - How to write unit tests

            // # Why Handle Errors?
            // 1. Not crash Program
            // 2. Chance to fix / retry
            // 3. Meaningful message & graceful exit\
            // 4. opportunity to log error
            // Good Error handling code helps future maintainers understand what possible error conditions may occur and how they can be handled

            // # Error handling Using Error Codes
            // - Need to know all the return values (ints) that represent errors
            // - Need to know all return values that represent success
            // - Need to remember to add an else if/ switch statements for every return value
            // - Program flow will continue as normal even though errors occured and may cause further damage
            // - May be harder to read than eception handling code
            // - Magic numbers with no semantic meaning harm readability / understanding
            // - Need to add if/switch statements every time method is called to check return codes
            // - Errors do not "bubble up" the call stack
            // - Catch some errors at a higher level
            // - Catch some errors in a single place
            // - How do you deal with system errors?
                // 1. Out of memory
                // 2. Access violations
            // - How do you return an error from a contructor?
            
            // # Why Exceptions
            // - Don't need to know all error / success codes
            // - Don't need if / switch statements everywhere method is called
            // - More readable, less clutter
            // - No magic numbers / constants
            // - Exceptions can bubble up
            // - Catch exceptions higher up / in one place
            // - Handle system errors
            // - Generate exceptions from constructors


            // # What is an Exception?
            // - Simply, object instances
            // - These object instances ultimately inherit from System.Exception base class
            // - We can generate our own exception using the throw statement
            // - Different exception classes represent different errors
            // - Exception classes can contain additional error information
            // - Different exceptions can be handled differently
            // ++ Exception Definition
                // - Standard eceptions provided by .NET
                // - Exceptions provided by framework/ library authors (eg NuGet)
                // - Custom application exception






        }

    }
}


