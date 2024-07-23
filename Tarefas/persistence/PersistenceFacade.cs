public interface PersistenceFacade
{
    public void SalvarDados(List<Tarefa> tarefasParaSalvar);
    public List<Tarefa> CarregarDados();

    public int gerarNovoId();

    public string getLingua();
}