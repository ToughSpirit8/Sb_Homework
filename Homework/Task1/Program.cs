using System.Numerics;
using System.Transactions;
using static System.Console;
namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Input your number...");
            int number = BigInteger.Parse(ReadLine();
            number = (int)(long)number;
            if (number == 0) WriteLine("Zero is uneven");
            else if (number % 2 == 0) WriteLine("Entered number is even");
            else WriteLine("Entered number is uneven");





        }
    }
}