using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using static System.Console;
namespace Task3
{
    internal class Program
    {
        static void Main()
        {
            WriteLine($"Enter number u want to check. To quit enter 0");
            string userInput = ReadLine();
            int userInputInt = int.Parse(userInput);
            if (userInputInt == 1){WriteLine($"1 is not simple"); Main();}
            else if (userInputInt == 0) {Environment.Exit(1);}
            int counter = 2;
            bool notSimple = false;
            while (counter < userInputInt)
            {
                int solution = userInputInt % (counter);
                //WriteLine(solution);
                if (solution == 0)
                {
                    notSimple = true;
                    break;
                }
                else
                {
                    counter++;
                }
            }
            if (notSimple == false)
            {
                WriteLine($"Number {userInput} is simple");
            }
            else if (notSimple == true)
            {
                WriteLine($"Number {userInput} is not simple");
            }
            Main();
        }
    }
}