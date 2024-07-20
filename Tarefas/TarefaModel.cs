#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
public class TarefaModel
{
    private List<Tarefa> tarefas;
    private TarefaPersistence tarefaPersistence;

    public TarefaModel() {
        this.tarefas = new List<Tarefa>();
        this.tarefaPersistence = new TarefaPersistence();
    }

    public void CriarTarefa(string nome)
    {
        // Gera um novo Id (em um método especializado para isso)
        int novoId = gerarNovoId();

        // Cria uma nova Tarefa utilizando o Id gerado e o nome fornecido
        // E depois adiciona a nova Tarefa na lista de tarefas
        Tarefa novaTarefa = new Tarefa(novoId, nome);
        this.tarefas.Add(novaTarefa);

        // Realiza a lógica de negócios para persistir os dados
        this.tarefaPersistence.SalvarDados( this.tarefas );
    }

    public void ExcluirTarefa(int id)
    {
        // Exclui todas as tarefas que obedeçam a regra:
        // Id da Tarefa é igual ao "id" que veio como parâmetro
        // no ExcluirTarefa
        this.tarefas.RemoveAll(t => t.id == id);

        // Realiza a lógica de negócios para persistir os dados
        this.tarefaPersistence.SalvarDados( this.tarefas );
    }

    public void FinalizarTarefa(int id)
    {
        // Exclui todas as tarefas que obedeçam a regra:
        // Id da Tarefa é igual ao "id" que veio como parâmetro
        // no ExcluirTarefa
        Tarefa tarefa = this.tarefas.Find(t => t.id == id);
        tarefa.finalizada = true;

        // Realiza a lógica de negócios para persistir os dados
        this.tarefaPersistence.SalvarDados( this.tarefas );
    }

    public List<Tarefa> GetTarefas()
    {
        // Realiza a lógica de negócios de carregar os dados da persistência
        this.tarefas = this.tarefaPersistence.CarregarDados();

        return this.tarefas;
    }

    private int gerarNovoId() {
        // Carrega o último item da lista (ou null, se estiver vazia)
        Tarefa ultimaTarefa = tarefas.LastOrDefault();

        // Define o número 1, caso a lista esteja vazia ou então
        // definirá o novo Id como sendo o do último elemento + 1
        int novoId = 1;
        if (ultimaTarefa != null) {
            novoId = ultimaTarefa.id + 1;
        }

        return novoId;
    }
    
}
