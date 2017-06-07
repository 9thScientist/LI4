public class SugestaoEstablecimento
{
    public int id { get; }
    public string nome { get; }
    public string telefone { get; }
    public string descricao { get; }
    public string localizacao { get; }
    public int autor { get; }
    public int establecimento { get; }

    public SugestaoEstablecimento(int id, string nome, string telefone, string descricao, string localizacao, int autor, int establecimento)
    {
        this.id = id;
        this.nome = nome;
        this.telefone = telefone;
        this.descricao = descricao;
        this.localizacao = localizacao;
        this.autor = autor;
        this.establecimento = establecimento;
    }
}