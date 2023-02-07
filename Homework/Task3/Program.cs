using System;

class Microorganism
{
    private int health;
    private int age;
    private int nutrition;

    public Microorganism(int health, int age, int nutrition)
    {
        this.health = health;
        this.age = age;
        this.nutrition = nutrition;
    }

    public void Live()
    {
        health -= 1;
        age++;
        nutrition--;
    }
    public void hunger(int x)
    {
        nutrition -= x;
    }
    public void Eat(int x)
    {
        nutrition += x;
    }
    static int R(int x, int y)
    {
        Random random = new Random();
        return random.Next(x, y);
    }
    public static int Rand(int x, int y)
    {
        Random random = new Random();
        return random.Next(x, y);
    }
    public void Reborn()
    {
        health += R(-5, 50);
        age = 0;
    }
    public bool IsAlive()
    {
        return health > 0 && nutrition > 0;
    }

    public int GetAge()
    {
        return age;
    }
    public int GetHealth()
    {
        return health;
    }
    public int GetNutrition()
    {
        return nutrition;
    }
}

class Simulation
{

    static void Main()
    {
        Microorganism microbe = new(100, 0, 50);
        Console.WriteLine("Enter \n'f' to eat anything that is around the microbe,\n'm' to multiply and become new evolved organism(there may be negative mutations),\n'enter' to wait a turn: ");
        while (microbe.IsAlive())
        {
            Console.WriteLine("Age: " + microbe.GetAge() + " Health: " + microbe.GetHealth() + " Nutrition: " + microbe.GetNutrition());

            string playerAction = Console.ReadLine();
            if (playerAction == "f")
            {
                int j = Microorganism.Rand(-8, 18);
                if (j > 0) { Console.WriteLine("You have eaten a juicy microbe"); }
                else { Console.WriteLine("You have lost energy but did not find anything to eat"); }
                microbe.Eat(j);

                microbe.Live();
            }
            else if (playerAction == "m")
            {
                microbe.hunger(50);
                microbe.Reborn();
                microbe.Live();
                Console.WriteLine("You are young and fresh again");
            }
            else if (playerAction == "")

                microbe.Live();
        }
        Console.WriteLine("Your microoganism has died.");
        string action = "";
        while (action == "")
        {
            action = Console.ReadLine();


            if (action == "") { Console.WriteLine("Your microoganism has died.\n to quit enter 'q'to play again enter 'p'");continue; }
            else if (action == "q")
            {
                Environment.Exit(0);
            }

            else if (action == "p")
            {
                Main();
            }

        }
    }
}