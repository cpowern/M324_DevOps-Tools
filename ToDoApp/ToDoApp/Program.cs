using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Willkommen zur ToDo-App!");
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nWähle eine Option:");
            Console.WriteLine("1 - Aufgabe hinzufügen");
            Console.WriteLine("2 - Aufgaben anzeigen");
            Console.WriteLine("3 - Beenden");
            Console.Write("Eingabe: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Funktion zum Hinzufügen wird später implementiert.");
                    break;
                case "2":
                    Console.WriteLine("Funktion zum Anzeigen wird später implementiert.");
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
