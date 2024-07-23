class Program
{
    private static TarefaModel? _model;
    private static TarefaView? _view;
    private static TarefaController? _controller;
    private static PersistenceFacade? _persistenceFacade;

    static void Main(string[] args)
    {
        _persistenceFacade = new PersistenceFacadeImpl();

        _model = new TarefaModel(_persistenceFacade);
        
        if ( _persistenceFacade.getLingua().Equals("EN") ) {
            _view = new TarefaViewEN();
        } else {
            _view = new TarefaViewPTBR();
        }

        _controller = new TarefaController(_model, _view);

        while (true)
        {
            _controller.TelaInicial();
        }
    }
}