namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte programmingPoints = 12;
            double mathPoints = 5.5;
            double sumOfPoints = mathPoints + programmingPoints;
            double midArithmetic = sumOfPoints / 2;
            Console.WriteLine($"{"Points for programming:",23}{programmingPoints}\n{"Points for math:",23}{mathPoints}\n{"Sum of Points is:"}{sumOfPoints}\nArithmetic mean of Points is: {midArithmetic}");
            Console.ReadLine();
            string Pattern = "Points for programming:{0}\nPoints for math:{1}\nSum of Points is:{2}\nArithmetic mean of Points is: {3}\nPress enter to quit...";
            Console.WriteLine(Pattern, programmingPoints, mathPoints, sumOfPoints, midArithmetic);
            Console.ReadLine();
        }
    }
}