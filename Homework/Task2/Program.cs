using static System.Console;
namespace Task2
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
                else { WriteLine("неверное значение сторон матрицы попробуйте еще раз"); continue;}

                Write("Введите количество столбцов в матрице: ");
                string collumnsStr = ReadLine();
                if (int.TryParse(collumnsStr, out int collumns));
                else { WriteLine("неверное значение сторон матрицы попробуйте еще раз"); continue;}

                int[,] matrix1 = new int[rows, collumns]; //создаем массив 1 в памяти 

                WriteLine("\nМатрица 1 ");
                for (int i = 0; i < matrix1.GetLength(0); i++) //заполняем и выводим массив 1
                {
                    WriteLine("\n");
                    for (int j = 0; j < matrix1.GetLength(1); j++)
                    {
                        matrix1[i, j] = new Random().Next(8);
                        Write($"{matrix1[i, j]}  ");
                    }
                }
                int[,] matrix2 = new int[rows, collumns]; //создаем массив 2 в памяти

                WriteLine("\n\nМатрица 2 ");
                for (int i = 0; i < matrix2.GetLength(0); i++) //заполняем и выводим массив 2
                {
                    WriteLine("\n");
                    for (int j = 0; j < matrix2.GetLength(1); j++)
                    {
                        matrix2[i, j] = new Random().Next(8);
                        Write($"{matrix2[i, j]}  ");
                    }
                }
                int[,] matrix3 = new int[rows, collumns];   //создаем массив 3 в памяти

                WriteLine("\n\n Матрица 3 (Сумма матриц 1 и 2) ");
                for (int i = 0; i < matrix3.GetLength(0); i++) //заполняем и выводим массив 3
                {
                    WriteLine("\n");
                    for (int j = 0; j < matrix3.GetLength(1); j++)
                    {
                        matrix3[i, j] = matrix2[i, j]+ matrix1[i, j];
                        Write($"{matrix3[i, j]}  ");
                    }
                }
                long summ = 0;                                  //определение и вывод суммы массива 3
                foreach (int i in matrix3) { summ += (long)i; }
                WriteLine($"\n\nСумма элементов матрицы 3 равна: {summ}");

                WriteLine($"\nЧтобы продолжить работу введите любой символ чтобы выйти нажмите enter");
                string workingQ = ReadLine();   //проверяем работать дальше или хватит
                if (workingQ == "" | workingQ == null) working = false;
                else { continue;}
            }
        }
    }
}