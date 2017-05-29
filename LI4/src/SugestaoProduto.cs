public class SugestaoProduto
{
    public int id { get; }
    public string nome { get; }
    public string regime { get; }
    public List<string> ingredientes;
    public DateTime data { get; }
    public int autor { get; }
    public int produto { get; }

    public SugestaoProduto(int id, string nome, string regime, List<string> ingredientes, DateTime data, int autor, int produto)
    {
        this.id = id;
        this.nome = nome;
        this.regime = regime;
        this.ingredientes = new List<string>(ingredientes);
        this.data = data;
        this.autor = autor;
        this.produto = produto;  
    }
}