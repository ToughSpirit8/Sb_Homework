using static System.Console;
namespace Task5
{
    internal class Program
    {
        static void Main()
        {
            {
                WriteLine("Введите максимальное число диапозона от 0 до...");
                int lastValue = int.Parse(ReadLine());
                int solution = new Random().Next(0, lastValue + 1);
                //WriteLine(solution); //чит код)
                string guessValue = "-1";
                WriteLine("Для выхода нажмите enter в пустой строке");
                WriteLine("Введите загаданное число");
                while (solution != int.Parse(guessValue))
                {
                    guessValue = ReadLine();
                    if (guessValue == "") { WriteLine($"Жаль, загаданное число было {solution}. Покаки!"); Environment.Exit(1); }
                    else if (int.Parse(guessValue) > solution) { WriteLine($"Загаданное число меньше {guessValue}"); }
                    else if (int.Parse(guessValue) < solution) { WriteLine($"Загаданное число больше {guessValue}"); }
                }
                WriteLine($"Вы угадали! Загаданное число было {guessValue}");
                Main();
            }
        }
    }
}