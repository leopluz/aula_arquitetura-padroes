public class IdPersistence {
    public int gerarNovoId() {
        string idStr = File.ReadAllText("id.txt");
        int id = Int32.Parse(idStr);
        int idNovo = ++id;

        File.WriteAllText("id.txt", idNovo.ToString());
        
        return idNovo;
    }

}