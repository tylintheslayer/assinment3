namespace ASSIGNMENT3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transportofchoice Person1 = new Transportofchoice("taxi", 5, true);
            Console.WriteLine($"It is {Person1.TravelingToWork} that Person 1 travels to work using a {Person1.FormOfTransport} and travels {Person1.FrequencyOfTravel} times a week.");
        }
    }
}

