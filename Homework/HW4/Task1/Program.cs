using static System.Console;
using System.Data;
using System.Globalization;
using System.Diagnostics.CodeAnalysis;

namespace Task1
{
    internal class Program
    {
        static void Main()
        {
        bool working = true;
            while (working)
            {
                Write("Введите количество строк в матрице: ");
                string rowsStr = ReadLine();
                if (int.TryParse(rowsStr, out int rows));
                else { WriteLine("неверное значение сторон матрицы попробуйте еще раз"); continue; }

                Write("Введите количество столбцов в матрице: ");
                string collumnsStr = ReadLine();
                if (int.TryParse(collumnsStr, out int collumns));
                else { WriteLine("неверное значение сторон матрицы попробуйте еще раз"); continue; }

                int[,] matrix = new int[rows, collumns]; //создаем массив в памяти
                    
                for (int i = 0; i < matrix.GetLength(0); i++) //заполняем и выводим массив
                {
                    WriteLine("\n");
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = new Random().Next(8);
                        Write($"{matrix[i, j]}  ");
                    }
                }            
                long summ = 0;              //определение и вывод суммы
                foreach (int i in matrix) { summ += (long)i; }
                WriteLine($"\n\nСумма элементов матрицы равна: {summ}");
                
                WriteLine($"\nЧтобы продолжить работу введите любой символ, чтобы выйти нажмите enter");
                string workingQ = ReadLine();               //проверяем работать дальше или хватит     
                if (workingQ == "" | workingQ == null) working = false;
                else { continue; }
            }
        }
    }
}