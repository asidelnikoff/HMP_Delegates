namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Task> tasks = new List<Task>()
            {
                new Task("Task 1","vveronvoern"),
                new Task("Task 2", "vorenoviner"),
                new Task("Task 3", "voreinvonre"),
                new Task("Task 4", "vorneonvoern")
            };

            tasks[0].TaskCompleted += TaskComplitedNotification;
            tasks[2].TaskCompleted += TaskComplitedNotification;

            TaskManager taskManager = new TaskManager(tasks);

            taskManager.CompleteTask(tasks[1]);
            taskManager.CompleteTask(tasks[0]);
        }

        static void TaskComplitedNotification(Task task) => Console.WriteLine($"Task complited: {task}");
    }
}