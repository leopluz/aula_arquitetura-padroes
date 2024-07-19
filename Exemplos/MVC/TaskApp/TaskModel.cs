public class TaskModel
{

    private static List<Task> tasks = new List<Task>();

    public static void AddTask(string task)
    {
        Task lastTask = tasks.LastOrDefault();
        int newId = 1;
        if (lastTask != null) {
            newId = lastTask.Id + 1;
        }
        Task newTask = new Task(newId ,task);
        tasks.Add(newTask);
    }

    public static void RemoveTask(int id)
    {
        tasks.RemoveAll(t => t.Id == id);
    }

    public static List<Task> GetTasks()
    {
        return tasks;
    }
}
