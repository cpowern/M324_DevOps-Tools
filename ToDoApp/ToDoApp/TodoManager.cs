﻿using System;
using System.Collections.Generic;

class TodoManager
{
    private List<string> tasks = new List<string>();

    public void AddTask(string task)
    {
        tasks.Add(task);
        Console.WriteLine($"✅ Aufgabe hinzugefügt: {task}");
    }

    public void ShowTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("📭 Keine Aufgaben vorhanden.");
            return;
        }

        Console.WriteLine("📝 Deine Aufgaben:");
        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {tasks[i]}");
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
