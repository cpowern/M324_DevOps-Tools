using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;

namespace ToDoApp.Tests
{
    [TestClass]
    public sealed class TodoManagerTests
    {
        private const string TestFilePath = "todo_list.csv";

        [TestInitialize]
        public void Setup()
        {
            // Stelle sicher, dass die Datei existiert, bevor Tests starten
            if (!File.Exists(TestFilePath))
            {
                File.Create(TestFilePath).Close();
            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            // Löscht die Datei nach jedem Testlauf, um Sperrungen zu vermeiden
            if (File.Exists(TestFilePath))
            {
                File.Delete(TestFilePath);
            }
        }

        [TestMethod]
        public void AddTask_ShouldIncreaseTaskCount()
        {
            // Arrange
            var todoManager = new TodoManager();
            int initialCount = todoManager.GetTaskCount();

            // Act
            todoManager.AddTask("Neue Aufgabe");

            // Assert
            Assert.AreEqual(initialCount + 1, todoManager.GetTaskCount());
        }

        [TestMethod]
        public void DeleteTask_ShouldDecreaseTaskCount()
        {
            // Arrange
            var todoManager = new TodoManager();
            todoManager.AddTask("Aufgabe zum Löschen");
            int countBeforeDelete = todoManager.GetTaskCount();

            // Act
            todoManager.DeleteTask(1);

            // Assert
            Assert.AreEqual(countBeforeDelete - 1, todoManager.GetTaskCount());
        }
    }
}
