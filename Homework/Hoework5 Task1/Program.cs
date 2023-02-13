using static System.Console;
namespace Hoework5_Task1
{
    internal class Program
    {
        public static string[] SplitText(string input)
        {
            
            string[] StringMassive =  input.Split(' ');
            return StringMassive;
            
        }
        static void PrintWords(string[] subs)
        {
            foreach (var sub in subs)
                WriteLine($"Substring: {sub}");
        }
        static public void Main()
        {
            
            Write("Введите предложение:");
            string? text = ReadLine();
            if (text == null | text == "") { Main(); }
            else  { PrintWords(SplitText(text)); }
            
        }       
    }
}