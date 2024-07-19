
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
public class TarefaModel
{
    private static List<Tarefa> tarefas = new List<Tarefa>();

    public void CriarTarefa(string tarefa)
    {
        int novoId = gerarNovoId();
        Tarefa newTask = new Tarefa(novoId ,tarefa);
        tarefas.Add(newTask);
    }

    private int gerarNovoId() {
        Tarefa lastTask = tarefas.LastOrDefault();

        int novoId = 1;
        if (lastTask != null) {
            novoId = lastTask.id + 1;
        }

        return novoId;
    }

    public void ExcluirTarefa(int id)
    {
        tarefas.RemoveAll(t => t.id == id);
    }

    public List<Tarefa> GetTarefas()
    {
        return tarefas;
    }
}
