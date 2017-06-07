using System;

public class SugestaoEstablecimento : ISugestao
{
    public int Id { get; }
    public string Nome { get; }
    public string Telefone { get; }
    public string Descricao { get; }
    public string Localizacao { get; }
    public int Autor { get; }
    public int Establecimento { get; }

    public SugestaoEstablecimento(int id, string nome, string telefone, string descricao, string localizacao, int autor, int establecimento)
    {
        this.Id = id;
        this.Nome = nome;
        this.Telefone = telefone;
        this.Descricao = descricao;
        this.Localizacao = localizacao;
        this.Autor = autor;
        this.Establecimento = establecimento;
    }

    public void Apply()
    {
        // TODO
    }

    public object Clone()
    {
        return new SugestaoEstablecimento(Id, Nome, Telefone, Descricao, Localizacao, Autor, Establecimento);
    }
}