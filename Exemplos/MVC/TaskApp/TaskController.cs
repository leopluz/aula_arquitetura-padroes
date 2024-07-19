public class TaskController
{
    private TaskModel _model;
    private TaskView _view;

    public TaskController(TaskModel model, TaskView view)
    {
        _model = model;
        _view = view;
    }

    public void AddTask()
    {
        var task = _view.GetTaskInput();
        TaskModel.AddTask(task);
        _view.DisplayTasks(TaskModel.GetTasks());
    }

    public void RemoveTask(int id)
    {
        TaskModel.RemoveTask(id);
        _view.DisplayTasks(TaskModel.GetTasks());
    }

    public void ListTasks()
    {
        _view.DisplayTasks(TaskModel.GetTasks());
    }
}
