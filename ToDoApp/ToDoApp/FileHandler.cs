using System;
using System.Collections.Generic;
using System.IO;

class FileHandler
{
    public const string filePath = "todo_list.csv";

    // Overwrite the file but allow read/write from other processes
    public static void SaveTasks(List<string> tasks)
    {
        using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.ReadWrite))
        using (StreamWriter writer = new StreamWriter(fs))
        {
            foreach (var task in tasks)
            {
                writer.WriteLine(task);
            }
        }
    }

    public static List<string> LoadTasks()
    {
        if (File.Exists(filePath))
        {
            // We open with FileShare.ReadWrite so it won't be locked
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (StreamReader reader = new StreamReader(fs))
            {
                List<string> tasks = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    // If line is null for some reason, skip it.
                    if (line != null)
                    {
                        tasks.Add(line);
                    }
                }
                return tasks;
            }
        }
        return new List<string>();
    }
}
