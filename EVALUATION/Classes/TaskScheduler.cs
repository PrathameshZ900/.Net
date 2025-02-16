// Implement a "TaskScheduler" class with priority-based task execution using a queue-based approach.


using System;
using System.Collections.Generic;

class TaskScheduler
{
    private List<(string name, int priority)> tasks = new List<(string, int)>();

    public static void Main()
    {
        TaskScheduler scheduler = new TaskScheduler();
        scheduler.AddTask("Task 1", 2);
        scheduler.AddTask("Task 2", 1);
        scheduler.AddTask("Task 3", 3);

        scheduler.ExecuteTasks();
    }

    public void AddTask(string name, int priority)
    {
        tasks.Add((name, priority));
    }

    public void ExecuteTasks()
    {
        tasks.Sort((a, b) => a.priority.CompareTo(b.priority));

        foreach (var task in tasks)
        {
            Console.WriteLine("Executing: " + task.name);
        }
    }
}
