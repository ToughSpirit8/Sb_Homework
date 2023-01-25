namespace HomeWork2_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Vladimir Dracula Cepish";
            byte age = 254;
            string email = "vladimir1752@dracula.com";
            double programmingPoints = 1.1;
            double mathPoints = 5.5;
            double physicsPoints = 10.10;
            Console.WriteLine($"{"Name:",23} {fullName}\n{"Age:",23} {age}\n{"Email:",23} {email}\n{"Points for Programming:",23} {programmingPoints}\n{"Points for Math:",23} {mathPoints}\n{"Points for Physics:",23} {physicsPoints}");
            Console.ReadLine();
        }


    }
}