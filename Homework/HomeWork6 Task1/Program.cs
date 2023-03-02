using System.Globalization;

class EmployeeDirectory
{
    static string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "employees.txt");

    //Внимание! Программа создает мусор на рабочем столе!

    static void Main()
    {
        bool exit = false;
        Console.WriteLine($"Файл сохранен в {filePath}");

        while (!exit)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1 - Вывести данные на экран");
            Console.WriteLine("2 - Добавить новую запись");
            Console.WriteLine("3 - Выход");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    ShowEmployees();
                    break;
                case "2":
                    AddEmployee();
                    break;
                case "3":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Некорректный выбор");
                    break;
            }
        }
    }

    static void ShowEmployees()
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("Файл не найден");
            return;
        }

        string[] lines = File.ReadAllLines(filePath);
        foreach (string line in lines)
        {
            string[] employeeData = line.Split('#');
            int id;
            DateTime timestamp;
            string name;
            int age;
            int height;
            DateTime birthDate;
            string birthPlace;

            if (int.TryParse(employeeData[0], out id) &&
                DateTime.TryParse(employeeData[1], out timestamp) &&
                !string.IsNullOrEmpty(employeeData[2]) &&
                int.TryParse(employeeData[3], out age) &&
                int.TryParse(employeeData[4], out height) &&
                DateTime.TryParse(employeeData[5], out birthDate) &&
                !string.IsNullOrEmpty(employeeData[6]))
            {
                name = employeeData[2];
                birthPlace = employeeData[6];

                Console.WriteLine("{0} - {1} - {2} - {3} - {4} - {5} - {6}",
                    id, timestamp, name, age, height, birthDate, birthPlace);
            }
            else
            {
                Console.WriteLine("Некорректный формат записи: {0}", line);
            }
        }
    }
    static void AddEmployee()
    {
        Console.WriteLine("Введите данные сотрудника:");

        Console.Write("Ф. И. О.: ");
        string name = Console.ReadLine();

        int age;
        while (true)
        {
            Console.Write("Возраст: ");
            if (int.TryParse(Console.ReadLine(), out age))
            {
                break;
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Попробуйте еще раз.");
            }
        }

        int height;
        while (true)
        {
            Console.Write("Рост: ");
            if (int.TryParse(Console.ReadLine(), out height))
            {
                break;
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Попробуйте еще раз.");
            }
        }

        DateTime birthDate;
        while (true)
        {
            Console.Write("Дата рождения (ДД.ММ.ГГГГ): ");
            if (DateTime.TryParseExact(Console.ReadLine(), "dd.MM.yyyy", null, DateTimeStyles.None, out birthDate))
            {
                break;
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Попробуйте еще раз.");
            }
        }

        Console.Write("Место рождения: ");
        string birthPlace = Console.ReadLine();

        int id = 1;
        DateTime timestamp = DateTime.Now;

        if (File.Exists(filePath))
        {
            string[] lastLine = File.ReadAllLines(filePath);
            if (lastLine.Length > 0)
            {
                string[] lastEmployee = lastLine[lastLine.Length - 1].Split('#');
                id = int.Parse(lastEmployee[0]) + 1;
            }
        }

        string employeeRecord = string.Format("{0}#{1}#{2}#{3}#{4}#{5}#{6}",
            id, timestamp.ToString("dd.MM.yyyy HH:mm"), name, age, height, birthDate.ToString("dd.MM.yyyy"), birthPlace);

        using (StreamWriter writer = File.AppendText(filePath))
        {
            writer.WriteLine(employeeRecord);
        }

        Console.WriteLine("Сотрудник добавлен");
    }
}