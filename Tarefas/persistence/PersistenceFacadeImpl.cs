public class PersistenceFacadeImpl : PersistenceFacade
{
    private TarefaPersistence tarefaPersistence;
    private IdPersistence idPersistence;
    private LocalePersistence localePersistence;

    public PersistenceFacadeImpl()
    {
        this.tarefaPersistence = new TarefaPersistence();
        this.idPersistence = new IdPersistence();
        this.localePersistence = new LocalePersistence();
    }

    public void SalvarDados(List<Tarefa> tarefasParaSalvar)
    {
        this.tarefaPersistence.SalvarDados(tarefasParaSalvar);
    }
    public List<Tarefa> CarregarDados()
    {
        return this.tarefaPersistence.CarregarDados();
    }

    public int gerarNovoId() { 
        return this.idPersistence.gerarNovoId();
    }

    public string getLingua() {
        return this.localePersistence.getLocale();
    }
}