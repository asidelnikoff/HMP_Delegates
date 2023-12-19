using Task2;
using Task = Task2.Task;

namespace Tests
{
    [TestClass]
    public class Task2Tests
    {
        [TestMethod]
        public void TestAddTask()
        {
            TaskManager taskManager = new TaskManager(new List<Task>() { new Task("1", "1"), new Task("2", "2") });

            Task toAddTask = new Task("add", "add");
            taskManager.AddTask(toAddTask);

            Assert.AreEqual(3, taskManager.Tasks.Count);
            Assert.IsTrue(taskManager.Tasks.Contains(toAddTask));

        }

        [TestMethod]
        public void TestRemoveTask() 
        {
            TaskManager taskManager = new TaskManager(new List<Task>() { new Task("1", "1"), new Task("2", "2") });

            Task toAddTask = new Task("add", "add");
            taskManager.AddTask(toAddTask);

            taskManager.RemoveTask(toAddTask);

            Assert.IsFalse(taskManager.Tasks.Contains(toAddTask));
        }

        [TestMethod]
        public void TestRemoveTaskNotFromList()
        {
            TaskManager taskManager = new TaskManager(new List<Task>() { new Task("1", "1"), new Task("2", "2") });

            Assert.ThrowsException<KeyNotFoundException>(() => taskManager.RemoveTask(new Task("3", "3")));
        }

        [TestMethod]
        public void TestCompleteTask()
        {
            TaskManager taskManager = new TaskManager(new List<Task>() { new Task("1", "1"), new Task("2", "2") });
            Task toAddTask = new Task("add", "add");

            toAddTask.TaskCompleted = (a) => { Assert.AreEqual(Task.TaskStatuses.Complited, a.Status); };

            taskManager.AddTask(toAddTask);

            taskManager.CompleteTask(toAddTask);
        }
    }
}