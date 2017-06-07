using System;
using System.Collections.Generic;

public class SugestaoProduto : ISugestao
{
    public int Id { get; }
    public string Nome { get; }
    public string Regime { get; }
    public List<string> Ingredientes { get;  }
    public DateTime Data { get; }
    public int Autor { get; }
    public int Produto { get; }

    public SugestaoProduto(int id, string nome, string regime, List<string> ingredientes, DateTime data, int autor, int produto)
    {
        this.Id = id;
        this.Nome = nome;
        this.Regime = regime;
        this.Ingredientes = new List<string>(ingredientes);
        this.Data = data;
        this.Autor = autor;
        this.Produto = produto;  
    }

    public void Apply()
    {
        // TODO
    }

    public object Clone()
    {
        return new SugestaoProduto(Id, Nome, Regime, Ingredientes, Data, Autor, Produto);
    }
}