public class Task
{
    public int Id { get; set; }
    public string Description { get; set; }
    public bool IsCompleted { get; set; }

    public Task(int Id, string Description) {
        this.Id = Id;
        this.Description = Description;
        this.IsCompleted = false;
    }
}