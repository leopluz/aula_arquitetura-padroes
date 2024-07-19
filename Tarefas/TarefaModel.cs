
using System.Text.Json;

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8604 // Possible null reference argument.
public class TarefaModel
{
    private List<Tarefa> tarefas;

    public TarefaModel() {
        tarefas = new List<Tarefa>();
    }

    public void CriarTarefa(string nome)
    {
        int novoId = gerarNovoId();
        Tarefa novaTarefa = new Tarefa(novoId, nome);
        tarefas.Add(novaTarefa);

        SalvarDados();
    }

    public void ExcluirTarefa(int id)
    {
        //Exclui todas as tarefas que obedeçam a regra:
        //Id da Tarefa é igual ao "id" que veio como parâmetro
        //  no ExcluirTarefa
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
        //Limpa o arquivo
        File.WriteAllText("tarefas.txt", string.Empty);

        //Carregando cada uma das Tarefas e colocando numa Array de String (formato JSON)
        Tarefa[] tarefasArr = tarefas.ToArray<Tarefa>();
        string[] linhas = new string[tarefasArr.Length];
        int i = 0;
        foreach (Tarefa tarefa in tarefasArr) {
            linhas[i++] = JsonSerializer.Serialize(tarefa);
        }

        //Escreve no arquivo as Tarefas (em formato JSON)
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
