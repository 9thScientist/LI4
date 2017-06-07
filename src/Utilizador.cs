public class Utilizador
{
    public int id { get; set; }
    public string email { get; set; }
    public string nome { get; set; }
    public string fotografia { get; set; }
    public int regime { get; set; }
    public List<string> preferencias { get; set; }
    public List<int> historico { get; set; }
    public int denuncias { get; set; }

    public void AddPreferencias(string preferencia)
    {
        preferencias.Add(preferencia);
    }

    public void RemovePreferencias(string preferencia)
    {
        preferencias.remove(preferencia);
    }

    public void addHistorico(int local)
    {
        historico.Add(local);
    }

    public void report()
    {
        //TODO
    }
}