
using System.Text.Json;

#pragma warning disable CS8604 // Possible null reference argument.
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
class TarefaPersistence {
    public void SalvarDados(List<Tarefa> tarefasParaSalvar) {
        // Limpa o arquivo
        File.WriteAllText("tarefas.txt", string.Empty);

        // Carrega cada uma das Tarefas e coloca numa Array de String (formato JSON)
        Tarefa[] tarefasArr = tarefasParaSalvar.ToArray<Tarefa>();
        string[] linhas = new string[tarefasArr.Length];
        int i = 0;
        foreach (Tarefa tarefa in tarefasArr) {
            linhas[i++] = JsonSerializer.Serialize(tarefa);
        }

        // Escreve no arquivo as Tarefas (em formato JSON)
        File.WriteAllLines("tarefas.txt", linhas);
    }

    public List<Tarefa> CarregarDados() {
        // Cria uma nova lista (vazia)
        List<Tarefa> tarefasDoArquivo = new List<Tarefa>();

        // Carrega os dados vindo do arquivos
        string[] linhas = File.ReadAllLines("tarefas.txt");
        foreach (string linhasLine in linhas) {
            Tarefa tarefa = JsonSerializer.Deserialize<Tarefa>(linhasLine);
            tarefasDoArquivo.Add(tarefa);
        }

        return tarefasDoArquivo;
    }
}