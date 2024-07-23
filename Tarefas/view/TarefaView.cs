public interface TarefaView {
    public string MenuSelecao();
    public string SolicitarNomeNovaTarefa();
    public string SolicitarIdExcluirTarefa();
    public string SolicitarIdFinalizarTarefa();
    public void ListarTarefas(List<Tarefa> tarefas);
}