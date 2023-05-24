namespace TheBeginningOfCSharp
{
    public class Car: Vehicle
    {
        public Car(string registrationNumber)
            : base(registrationNumber)
        {
            Console.WriteLine("Car is being initailized. {0}", registrationNumber);
        }
    }
}
