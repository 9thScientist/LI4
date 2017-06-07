using System.Collections.Generic;

public class Utilizador
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string Nome { get; set; }
    public string Fotografia { get; set; }
    public string Regime { get; set; }
    public List<string> Preferencias { get; set; }
    public List<int> Historico { get; set; }
    public int Denuncias { get; set; }

    public void AddPreferencias(string preferencia)
    {
        Preferencias.Add(preferencia);
    }

    public void RemovePreferencias(string preferencia)
    {
        Preferencias.Remove(preferencia);
    }

    public void AddHistorico(int local)
    {
        Historico.Add(local);
    }

    public int Report()
    {
        //TODO
        return -1;
    }
}