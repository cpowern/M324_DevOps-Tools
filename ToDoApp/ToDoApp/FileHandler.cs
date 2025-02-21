using System;
using System.Collections.Generic;
using System.IO;

class FileHandler
{
    private const string filePath = "todo_list.csv";

    public static void SaveTasks(List<string> tasks)
    {
        File.WriteAllLines(filePath, tasks);
    }

    public static List<string> LoadTasks()
    {
        if (File.Exists(filePath))
        {
            return new List<string>(File.ReadAllLines(filePath));
        }
        return new List<string>(); // Leere Liste, falls Datei nicht existiert
    }
}
