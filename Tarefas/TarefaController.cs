public class TarefaController
{
    private TarefaModel _model;

    public TarefaController(TarefaModel model)
    {
        _model = model;
    }

    public void CriarTarefa(string nome)
    {
        _model.CriarTarefa(nome);
    }

    public void ExcluirTarefa(int id)
    {
        _model.ExcluirTarefa(id);
    }

    public List<Tarefa> ListarTarefas()
    {
        return _model.GetTarefas();
    }
}
