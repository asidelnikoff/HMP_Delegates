using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Task
    {
        public enum TaskStatuses { InProgress, Complited };

        public string Name { get; set; }
        public string Description { get; set; }
        public TaskStatuses Status { get; set; }

        public delegate void OnTaskCompleted(Task task);

        public OnTaskCompleted TaskCompleted { get; set; }

        public Task(string name, string description, TaskStatuses status = TaskStatuses.InProgress)
        {
            Name = name;
            Description = description;
            Status = status;
        }

        public override string ToString()
        {
            return $"{Name}";
        }

        public override int GetHashCode()
        {
            return $"{Name}{Description}{Status}".GetHashCode();
        }
    }
}
