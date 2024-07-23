public class LocalePersistence {
    public string getLocale() {
        string locale = File.ReadAllText("locale.txt");
        
        return locale;
    }

}