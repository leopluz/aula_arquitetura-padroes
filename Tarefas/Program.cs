class Program
{
    private static TarefaModel? _model;
    private static TarefaView? _view;
    private static TarefaController? _controller;

    static void Main(string[] args)
    {
        _model = new TarefaModel();
        _controller = new TarefaController(_model);

        _view = new TarefaView(_controller);

        _view.ExecutarInterfaceConsole();
    }
}