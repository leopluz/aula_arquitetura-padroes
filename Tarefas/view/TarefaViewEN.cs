
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8603 // Possible null reference return.
public class TarefaViewEN : TarefaView
{

    public string MenuSelecao()
    {
        Console.WriteLine("----------MENU----------");
        Console.WriteLine("| 1. Create Task       |");
        Console.WriteLine("| 2. Delete Task       |");
        Console.WriteLine("| 3. List Tasks        |");
        Console.WriteLine("| 4. Mark Task as Done |");
        Console.WriteLine("| 5. Exit              |");
        Console.WriteLine("------------------------");
        string escolha = Console.ReadLine();

        return escolha;
    }

    public string SolicitarNomeNovaTarefa()
    {
        Console.WriteLine("Digite o nome da sua tarefa:");
        string nome = Console.ReadLine();

        return nome;
    }

    public string SolicitarIdExcluirTarefa()
    {
        Console.WriteLine("Digite o ID da Tarefa para excluir:");
        string id = Console.ReadLine();

        return id;
    }

    public string SolicitarIdFinalizarTarefa()
    {
        Console.WriteLine("Digite o ID da Tarefa para ser finalizada:");
        string id = Console.ReadLine();

        return id;
    }
    public void ListarTarefas(List<Tarefa> tarefas)
    {
        Console.WriteLine("----------LISTA DE TAREFAS----------");
        foreach (var tarefa in tarefas)
        {
            Console.WriteLine($"#{tarefa.id}: {tarefa.nome} -> {(tarefa.finalizada ? "Finalizada" : "Pendente")}");
        }
        Console.WriteLine("------------------------------------");
    }
}
