using System;
using System.Collections.Generic;
using System.IO;

namespace ToDoApp
{
    public class FileHandler
    {
        private const string filePath = "todo_list.csv";

        /// <summary>
        /// Speichert die Aufgabenliste in eine CSV-Datei.
        /// </summary>
        public static void SaveTasks(List<string> tasks)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, false))
                {
                    foreach (var task in tasks)
                    {
                        writer.WriteLine(task);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"❌ Fehler beim Speichern der Datei: {ex.Message}");
            }
        }

        /// <summary>
        /// Lädt die Aufgabenliste aus der CSV-Datei.
        /// </summary>
        public static List<string> LoadTasks()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        List<string> tasks = new List<string>();
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            tasks.Add(line);
                        }
                        return tasks;
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"❌ Fehler beim Laden der Datei: {ex.Message}");
            }
            return new List<string>(); // Falls Fehler auftreten, wird eine leere Liste zurückgegeben.
        }
    }
}
