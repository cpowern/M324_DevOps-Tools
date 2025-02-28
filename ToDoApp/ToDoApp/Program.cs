using System;

namespace ToDoApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\n📌 Wähle eine Option:");
            Console.WriteLine("1️⃣ Aufgabe hinzufügen");
            Console.WriteLine("2️⃣ Aufgaben anzeigen");
            Console.WriteLine("3️⃣ Aufgabe löschen");
            Console.WriteLine("4️⃣ Beenden");
            Console.Write("🔹 Eingabe: ");

            string input = Console.ReadLine();

            while (running)
            {
                case "1":
                    Console.Write("✏ Gib eine neue Aufgabe ein: ");
                    string task = Console.ReadLine();
                    todoManager.AddTask(task);
                    break;
                case "2":
                    todoManager.ShowTasks();
                    break;
                case "3":
                    Console.Write("🗑 Welche Aufgabe soll gelöscht werden (Nummer)?: ");
                    if (int.TryParse(Console.ReadLine(), out int taskNumber))
                    {
                        todoManager.DeleteTask(taskNumber);
                    }
                    else
                    {
                        Console.WriteLine("⚠ Ungültige Eingabe! Bitte eine Zahl eingeben.");
                    }
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("⚠ Ungültige Eingabe!");
                    break;

            }

        Console.WriteLine("👋 Programm beendet.");
    }
}

