
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8604 // Possible null reference argument.
public class TarefaView
{
    private TarefaController _controller;

    public TarefaView(TarefaController controller)
    {
        _controller = controller;
    }

    public void ExecutarInterfaceConsole()
    {

        while (true)
        {
            MostrarMenu();
        }
    }

    public void MostrarMenu()
    {
        Console.WriteLine("----------MENU----------");
        Console.WriteLine("| 1. Criar Tarefa      |");
        Console.WriteLine("| 2. Excluir Tarefa    |");
        Console.WriteLine("| 3. Listar Tarefas    |");
        Console.WriteLine("| 4. Sair              |");
        Console.WriteLine("------------------------");
        string escolha = Console.ReadLine();

        if (escolha == "1")
        {
            CadastrarTarefa();
        }
        else if (escolha == "2")
        {
            ExcluirTarefa();
        }
        else if (escolha == "3")
        {
            ListarTarefas();
        }
        else if (escolha == "4")
        {
            Environment.Exit(0);
        }
    }

    public void CadastrarTarefa()
    {
        Console.WriteLine("Digite o nome da sua tarefa:");
        string nome = Console.ReadLine();

        _controller.CriarTarefa(nome);
    }

    public void ExcluirTarefa()
    {
        Console.WriteLine("Digite o ID da Tarefa para excluir:");
        string idStr = Console.ReadLine();
        int id = Int32.Parse(idStr);

        _controller.ExcluirTarefa(id);
    }
    public void ListarTarefas()
    {
        List<Tarefa> tarefas = _controller.ListarTarefas();

        Console.WriteLine("----------LISTA DE TAREFAS----------");
        foreach (var tarefa in tarefas)
        {
            Console.WriteLine($"#{tarefa.id}: {tarefa.nome} -> {(tarefa.finalizada ? "Finalizada" : "Pendente")}");
        }
        Console.WriteLine("------------------------------------");
    }
}
