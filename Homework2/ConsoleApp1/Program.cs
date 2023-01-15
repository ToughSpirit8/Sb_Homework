namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int programmingPoints = 12;
            double mathPoints = 5.5;
            double sumOfPoints = mathPoints + programmingPoints;
            double midArithmetic = sumOfPoints / 2;
            Console.WriteLine($"{"Points for Programming:",23} {programmingPoints}");
            Console.WriteLine($"{"Points for Math:",23} {mathPoints}");
            Console.WriteLine("\nPress enter to get arithmetic mean...");
            Console.ReadLine();
            Console.WriteLine($"{"arithmetic mean is:",23} {midArithmetic}");
            Console.WriteLine("\nPress enter to quit...");
            Console.ReadLine();
        }   
    }
}