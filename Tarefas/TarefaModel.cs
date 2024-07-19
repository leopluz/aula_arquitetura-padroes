
using System.Text.Json;

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8604 // Possible null reference argument.
public class TarefaModel
{
    private static List<Tarefa> tarefas = new List<Tarefa>();

    public void CriarTarefa(string tarefa)
    {
        int novoId = gerarNovoId();
        Tarefa newTask = new Tarefa(novoId ,tarefa);
        tarefas.Add(newTask);
        SalvarDados();
    }

    public void ExcluirTarefa(int id)
    {
        tarefas.RemoveAll(t => t.id == id);

        SalvarDados();
    }

    public List<Tarefa> GetTarefas()
    {
        CarregarDados();
        return tarefas;
    }

    private int gerarNovoId() {
        Tarefa lastTask = tarefas.LastOrDefault();

        int novoId = 1;
        if (lastTask != null) {
            novoId = lastTask.id + 1;
        }

        return novoId;
    }

    private void SalvarDados() {
        File.WriteAllText("tarefas.txt", string.Empty);

        Tarefa[] tarefasArr = tarefas.ToArray<Tarefa>();
        string[] linhas = new string[tarefasArr.Length];
        int i = 0;
        foreach (Tarefa tarefa in tarefasArr) {
            linhas[i++] = JsonSerializer.Serialize(tarefa);
            // Console.WriteLine(jsonString);
        }

        File.WriteAllLines("tarefas.txt", linhas);
    }

    private void CarregarDados() {
        tarefas = new List<Tarefa>();

        string[] linhas = File.ReadAllLines("tarefas.txt");
        foreach (string linhasLine in linhas) {
            Tarefa tarefa = JsonSerializer.Deserialize<Tarefa>(linhasLine);
            tarefas.Add(tarefa);
        }
    }
}
