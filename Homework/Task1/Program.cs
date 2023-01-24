using System.Numerics;
using System.Runtime.InteropServices;
using System.Transactions;
using static System.Console;
namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Input your number...");
            string number = ReadLine();  //получаем любую строку от юзера
            var number1 = BigInteger.Parse(number); //конвертируем в число (BigInteger используем для чисел любой длинны)
            if (number1 == 0) WriteLine("Zero is uneven");
            else if (number1 % 2 == 0) WriteLine("Entered number is even");
            else WriteLine("Entered number is uneven");
        }
    }
}