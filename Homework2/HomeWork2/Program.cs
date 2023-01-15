namespace HomeWork2
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
            Console.WriteLine($"{"Name:",23} {fullName}");
            Console.WriteLine($"{"Age:",23} {age}");
            Console.WriteLine($"{"email:",23} {email}");
            Console.WriteLine($"{"Points for Programming:",23} {programmingPoints}");
            Console.WriteLine($"{"Points for Math:",23} {mathPoints}");
            Console.WriteLine($"{"Points for Physics:",23} {physicsPoints}");
            Console.ReadLine();
        }   
            

    }
}