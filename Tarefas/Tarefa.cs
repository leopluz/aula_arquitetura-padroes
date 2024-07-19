public class Tarefa
{
    public int id { get; set; }
    public string nome { get; set; }
    public bool finalizada { get; set; }

    public Tarefa(int id, string nome) {
        this.id = id;
        this.nome = nome;
        this.finalizada = false;
    }
}