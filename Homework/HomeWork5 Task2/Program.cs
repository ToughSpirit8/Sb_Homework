
using System.ComponentModel;
using static System.Console;
namespace HomeWork5_Task2
{
    internal class Program
    {
        private static string[] SplitText(string input)
        {
            string[] StringMassive = input.Split(" ");
            return StringMassive;
        }
        private static string ReverseString(string input)
        {
            string[] strArr = SplitText(input);
            //WriteLine(strArr.Length);
            var ReversedString = new string[strArr.Length];
            for (int i = strArr.Length - 1; i >= 0; i--)
            {
                int c = strArr.Length - (i + 1);
                //WriteLine(c);
                ReversedString[c] = strArr[i];
            }
            return string.Join(" ", ReversedString);
        }
        static void Main()
        {
            Write("Введите предложение:");
            string input1 = ReadLine();

            if (input1 == null | input1 == "") { Main(); } // это нормальная рекурсия или в таких случая предпочтительнее цикл?
            else { string reversed = ReverseString(input1); WriteLine($"Предложение наооборот*:{reversed}"); }
            //Опционально добавил альтернативный метод
            WriteLine("Альтернативный метод");
            AlternativeMain();
        }
        static void AlternativeMain()
        {
            Write("Введите предложение*:");
            string? input1 = ReadLine();
            string[] t = SplitText(input1);
            if (input1 == null | input1 == "") { AlternativeMain(); } 
            else
            {
                Write("Предложение наооборот*:"); for (int i = t.Length - 1; i >= 0; i--) { Write($"{t[i]} "); }
                WriteLine("\nEnter для выхода");
                ReadLine();
            }
        }
    }
}