using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class TaskManager
    {
        private List<Task> tasks;
        public List<Task> Tasks 
        { 
            get => tasks; 
            set => tasks = new List<Task>(value);
        }

        public TaskManager(IEnumerable<Task> tasks)
        {
            Tasks = tasks.ToList();
        }

        public void AddTask(Task task) 
        {
            Tasks.Add(task);
        }

        public void RemoveTask(Task task)
        {
            if (!Tasks.Contains(task))
                throw new KeyNotFoundException("No such task");

            Tasks.Remove(task);
        }

        public void CompleteTask(Task task)
        {
            task.Status = Task.TaskStatuses.Complited;
            task.TaskCompleted?.Invoke(task);
        }
    }
}
