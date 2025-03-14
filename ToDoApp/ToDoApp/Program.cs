using System;
using System.Collections.Generic;

namespace ToDoApp
{
    class Program
    {
        static void Main()
        {
            TodoManager todoManager = new TodoManager();

            while (true)
            {
                Console.WriteLine("\nToDo-Liste: ");
                Console.WriteLine("1. Aufgabe hinzufügen");
                Console.WriteLine("2. Aufgabe entfernen");
                Console.WriteLine("3. Aufgaben anzeigen");
                Console.WriteLine("4. Beenden");
                Console.Write("Auswahl: ");

                string choice = Console.ReadLine();

                // WICHTIG: Stelle sicher, dass der Switch-Block korrekt geschrieben ist
                switch (choice)
                {
                    case "1":
                        Console.Write("Neue Aufgabe: ");
                        string task = Console.ReadLine();
                        todoManager.AddTask(task);
                        break;
                    case "2":
                        todoManager.ShowTasks();
                        Console.Write("Nummer der zu löschenden Aufgabe: ");
                        if (int.TryParse(Console.ReadLine(), out int index))
                        {
                            todoManager.DeleteTask(index);
                        }
                        else
                        {
                            Console.WriteLine("⚠ Ungültige Eingabe!");
                        }
                        break;
                    case "3":
                        todoManager.ShowTasks();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("⚠ Ungültige Auswahl!");
                        break;
                } 
            }
        }
    }
}

