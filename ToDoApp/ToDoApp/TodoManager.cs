using System;
using System.Collections.Generic;

class TodoManager
{
    private List<string> tasks = new List<string>();

    public void AddTask(string task)
    {
        tasks.Add(task);
        Console.WriteLine($"Aufgabe hinzugefügt: {task}");
    }

    public void ShowTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("Keine Aufgaben vorhanden.");
            return;
        }

        Console.WriteLine("Deine Aufgaben:");
        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {tasks[i]}");
        }
    }
}
