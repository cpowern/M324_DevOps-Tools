using System;
using System.Collections.Generic;

namespace ToDoApp
{
    public class TodoManager
    {

        tasks.Add(task);
        Console.WriteLine($"✅ Aufgabe hinzugefügt: {task}");
    }


        public TodoManager()
        {
            tasks = FileHandler.LoadTasks(); // Lade gespeicherte Aufgaben beim Start
        }

        public void AddTask(string task)
        {
            tasks.Add(task);
            FileHandler.SaveTasks(tasks); // Speichern nach jeder Änderung
            Console.WriteLine($"✅ Aufgabe hinzugefügt: {task}");
        }

        public void ShowTasks()
        {

            Console.WriteLine("📭 Keine Aufgaben vorhanden.");
            return;
        }

        Console.WriteLine("📝 Deine Aufgaben:");
        for (int i = 0; i < tasks.Count; i++)

        {
            return tasks.Count;
        }
    }

    public void DeleteTask(int index)
    {
        if (index < 1 || index > tasks.Count)
        {
            Console.WriteLine("⚠ Ungültige Nummer! Bitte eine gültige Aufgaben-ID eingeben.");
            return;
        }

        Console.WriteLine($"❌ Aufgabe entfernt: {tasks[index - 1]}");
        tasks.RemoveAt(index - 1);
    }
}
