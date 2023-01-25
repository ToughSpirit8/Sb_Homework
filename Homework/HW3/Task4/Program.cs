using static System.Console;
namespace Task4
{
    internal class Program
    {
        static void Main()
        {
            {
                WriteLine("Введите длинну последовательности");
                int numLength = int.Parse(ReadLine()); 
                int minValue = int.MaxValue;
                WriteLine("Введите числа из последовательности");
                for (int i = numLength; i > 0; i--)
                {
                    int currentNumber = int.Parse(ReadLine());
                    if (currentNumber < minValue) { minValue = currentNumber;}  
                }
                WriteLine($"Минимальное значение в заданной последовательности {minValue}");
            }
        }
    }
}