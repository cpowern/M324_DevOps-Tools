using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;

// Uncomment this if you didn't create MSTestSettings.cs

namespace ToDoApp.Tests
{
    [TestClass]
    public sealed class TodoManagerTests
    {
        private const string TestFilePath = "todo_list.csv";
        private TodoManager todoManager;

        [TestInitialize]
        public void Setup()
        {
            // If file exists, just clear it out
            if (File.Exists(TestFilePath))
            {
                File.WriteAllText(TestFilePath, "");
            }

            // Create a fresh TodoManager for each test
            todoManager = new TodoManager();
        }

        [TestCleanup]
        public void Cleanup()
        {
            if (File.Exists(TestFilePath))
            {
                File.Delete(TestFilePath);
            }
        }

        [TestMethod]
        public void AddTask_ShouldIncreaseTaskCount()
        {
            int initialCount = todoManager.GetTaskCount();
            todoManager.AddTask("Neue Aufgabe");
            Assert.AreEqual(initialCount + 1, todoManager.GetTaskCount());
        }

        [TestMethod]
        public void DeleteTask_ShouldDecreaseTaskCount()
        {
            todoManager.AddTask("Aufgabe zum Löschen");
            int countBeforeDelete = todoManager.GetTaskCount();
            todoManager.DeleteTask(1);
            Assert.AreEqual(countBeforeDelete - 1, todoManager.GetTaskCount());
        }

        [TestMethod]
        public void DeleteTask_InvalidIndex_ShouldNotChangeCount()
        {
            int initialCount = todoManager.GetTaskCount();
            todoManager.DeleteTask(100);
            Assert.AreEqual(initialCount, todoManager.GetTaskCount());
        }

        [TestMethod]
        public void AddEmptyTask_ShouldNotIncreaseTaskCount()
        {
            int initialCount = todoManager.GetTaskCount();
            todoManager.AddTask("");
            Assert.AreEqual(initialCount, todoManager.GetTaskCount());
        }

        [TestMethod]
        public void LoadTasks_ShouldLoadSavedTasks()
        {
            todoManager.AddTask("Test 1");
            todoManager.AddTask("Test 2");

            var newManager = new TodoManager();
            Assert.AreEqual(2, newManager.GetTaskCount());
        }

        [TestMethod]
        public void ShowTasks_ShouldNotThrowException()
        {
            try
            {
                todoManager.ShowTasks();
            }
            catch (Exception ex)
            {
                Assert.Fail($"ShowTasks should not throw, but got: {ex.Message}");
            }
        }
    }
}
