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
        string escolha = _view.MenuSelecao();
        DefinirAcao(escolha);
    }

    public void DefinirAcao(string escolha)
    {
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
            Environment.Exit(0);
        }
    }

    public void CriarTarefa()
    {
        string nome = _view.SolicitarNomeNovaTarefa();

        _model.CriarTarefa(nome);
    }

    public void ExcluirTarefa()
    {
        string idStr = _view.SolicitarIdExcluirTarefa();
        int id = Int32.Parse(idStr);

        _model.ExcluirTarefa(id);
    }

    public void ListarTarefas()
    {
        List<Tarefa> tarefas = _model.GetTarefas();

        _view.ListarTarefas(tarefas);
    }
}
