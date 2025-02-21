using System;

class Program
{
    static void Main()
    {
        TodoManager todoManager = new TodoManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n Wähle eine Option:");
            Console.WriteLine("1️ Aufgabe hinzufügen");
            Console.WriteLine("2️ Aufgaben anzeigen");
            Console.WriteLine("3️ Beenden");
            Console.Write("Eingabe: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Write("Gib eine neue Aufgabe ein: ");
                    string task = Console.ReadLine();
                    todoManager.AddTask(task);
                    break;
                case "2":
                    todoManager.ShowTasks();
                    break;
                case "3":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Ungültige Eingabe!");
                    break;
            }
        }

        Console.WriteLine("Programm beendet.");
    }
}
