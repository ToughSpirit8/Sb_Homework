using System.Globalization;
using System;
using static System.Console;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Task2
{
    internal class Program
    {
        static void Main()
        {
            bool keepplaying = true;
            while (keepplaying == true)
            {
                Write("Введите количество ваших карт: ");
                string amountOfCardsStr = ReadLine(); 
                if (int.TryParse(amountOfCardsStr, out int amountOfCards) == true) WriteLine("Ставки сделаны, ставок больше нет");
                else { WriteLine("неверное значение карт начните сначала");break; }
                
                int score = 0;
                WriteLine("\nКакие карты у вас в руке? \nВыберите из:\n1-10 \nВалет = J\nДама = Q\nКороль = K\nТуз = T");
                int j = 0; //счётчик номера вводимой карты
                for (int i = amountOfCards; i > 0; i--)
                {
                    j++;
                    Write($"\nКарта #{j} ");
                    string card = ReadLine();
                    string cardL = card.ToLower();
                    
                    
                    if (cardL == "j" | cardL == "q" | cardL == "k" | cardL == "t") { score += 10; }
                    else if (int.TryParse(card, out int cardParsed)) { score += cardParsed; }
                    else { WriteLine("Такой карты нет, введите одно из предложенных значений!"); i++; }
                
                }
                j = 0; //обнуляем счётчик номера вводимой карты
                WriteLine($"Your score is {score}");
                int oponentScore = new Random().Next(6, 21);
                WriteLine($"Score of your opponent is {oponentScore}");
                
                if (oponentScore > score) WriteLine($"LOOSER");
                else if (oponentScore == score) WriteLine("Draw");
                else if (score > 21) WriteLine($"LOOSER");
                else { WriteLine("YOU WON!"); }
                
                WriteLine($"Чтобы продолжить играть введите любой символ чтобы выйти нажмите enter");
                
                string answer = ReadLine();
                if (answer == null | answer == "") { keepplaying = false; }
                else { continue; }
            
            }
        }
    }
}
