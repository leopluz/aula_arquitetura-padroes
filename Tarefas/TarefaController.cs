#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
public class TarefaController
{
    private TarefaModel _model;
    private TarefaView _view;

    public TarefaController(TarefaModel model, TarefaView view)
    {
        _model = model;
        _view = view;
    }
    
    public void TelaInicial()
    {
        // Encaminha para a View definir o que vai ser mostrado
        // para o usuário no Menu
        string escolha = _view.MenuSelecao();

        // Após o usuário definir sua ação, a definição da rota
        // a seguir na execução será feita pelo Controller
        // (e não pela View)
        DefinirAcao(escolha);
    }

    public void DefinirAcao(string escolha)
    {
       // Baseado na escolha do usuário, o Controller direcionará
       // para qual lógica deverá seguir
        if (escolha == "1")
        {
            CriarTarefa();
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
            FinalizarTarefa();
        }
        else if (escolha == "5")
        {
           // Comando para finalizar a aplicação
            Environment.Exit(0);
        }
    }

    public void CriarTarefa()
    {
        // Encaminha para a View definir como será a interação com o usuário
        string nome = _view.SolicitarNomeNovaTarefa();

        // Tendo a informação trazida pela View, encaminha para o Model
        // realizar as regras de negócio
        _model.CriarTarefa(nome);
    }

    public void ExcluirTarefa()
    {
        // Encaminha para a View definir como será a interação com o usuário
        string idStr = _view.SolicitarIdExcluirTarefa();
        int id = Int32.Parse(idStr);

        // Tendo a informação trazida pela View, encaminha para o Model
        // realizar as regras de negócio
        _model.ExcluirTarefa(id);
    }

    public void FinalizarTarefa()
    {
        // Encaminha para a View definir como será a interação com o usuário
        string idStr = _view.SolicitarIdFinalizarTarefa();
        int id = Int32.Parse(idStr);

        // Tendo a informação trazida pela View, encaminha para o Model
        // realizar as regras de negócio
        _model.FinalizarTarefa(id);
    }

    public void ListarTarefas()
    {
        // Como trazer todas as tarefas não possui filtros, não é necessário
        // solicitar novas informações ao usuário, portanto é chamado
        // diretamente o Model, para realizar as regras para trazer os dados
        List<Tarefa> tarefas = _model.GetTarefas();

        // Após trazer os dados, é encaminhado para a View definir
        // como a informação será mostrada para o usuário
        _view.ListarTarefas(tarefas);
    }
}
