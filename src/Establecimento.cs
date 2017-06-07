public class Establecimento
{
    public int id { get; set; }
    public string nome { get; set; }
    public string telefone { get; set; }
    public string descricao { get; set; }
    public string localizacao { get; set; }
    public int rating { get; set; }
    public List<string> galeria { get; set; }
    public int responsavel { get; set; }
    public bool sugestoes { get; set; }
    public List<Dia> horarios;

    public int getDistance(int latitude, int longitude)
    {

    }

    public int getDistancePrintable(int latitude, int longitude)
    {

    }
}