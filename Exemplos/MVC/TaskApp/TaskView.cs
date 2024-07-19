public class TaskView
{
    public void DisplayTasks(List<Task> tasks)
    {
        foreach (var task in tasks)
        {
            Console.WriteLine($"{task.Id}: {task.Description} - {(task.IsCompleted ? "Completed" : "Not Completed")}");
        }
    }

    public string GetTaskInput()
    {
        Console.WriteLine("Enter task description:");
        string description = Console.ReadLine();

        return description;
    }
}
