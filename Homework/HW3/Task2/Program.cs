using System.Globalization;
using System;
using static System.Console;
using System.Diagnostics.CodeAnalysis;

namespace Task2
{
    internal class Program
    {
        static void Main()
        {
        WriteLine("Введите количество ваших карт");
        string amountOfCardsStr = ReadLine(); //Здесь нужен try catch но я пока не знаю как его реализовывать
        int amountOfCards = int.Parse(amountOfCardsStr); //как избежать null без try catch тоже не понятно
            int score = 0;
            WriteLine("Какие карты у вас в руке? \n1-10 \nВалет = J\nДама = Q\nКороль = K\nТуз = T");
            for (int i = amountOfCards; i > 0; i--)
            {
                
                string card = ReadLine();
                string cardL = card.ToLower();
                if (cardL == "j" | cardL == "q" | cardL == "k" | cardL == "t")
                {
                    score += 10;
                }
                else if (card == "1" | card == "2" | card == "3" | card == "4" | card == "5" | card == "6" | card == "7" | card == "8" | card == "9" | card == "10")
                {
                    switch (card)
                    {
                        case "0": score += 0; continue; //изначально хотел парсить строку но опять же 
                        case "1": score += 1; continue; //без try catch не понятно как избежать вылета
                        case "2": score += 2; continue; //когда пытаюсь сам навоять try catch возникают проблемы с локальной видимостью переменных
                        case "3": score += 3; continue; 
                        case "4": score += 4; continue;
                        case "5": score += 5; continue;
                        case "6": score += 6; continue;
                        case "7": score += 7; continue;
                        case "8": score += 8; continue;
                        case "9": score += 9; continue;
                        case "10": score += 10; continue;
                    }
                }
                else
                {
                    WriteLine("There is not such card GET OUT of here!");
                    
                    Main(); // Start again 
                }
            }
            WriteLine($"Your score is {score}");
            int oponentScore = new Random().Next(6, 21);
            WriteLine($"Score of your opponent is {oponentScore}");
            if (oponentScore > score) WriteLine($"LOOSER");
            else { WriteLine("YOU WON!"); }
            ReadLine();
        }
    }
}