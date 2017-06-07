using System;
using System.Collections.Generic;

public class Produto : ICloneable
{
    public int Id { get; set; }
    public int Establecimento { get; set; }
    public string Imagem { get; set; }
    public string Nome { get; set; }
    public string Regime { get; set; }
    public List<string> Ingredientes {
        get { return new List<string>(Ingredientes); }
        set { Ingredientes = new List<string>(value); }
    }
    public List<Avaliacao> Avaliacoes {
        get {
            List<Avaliacao> ret = new List<Avaliacao>();
        
            foreach (Avaliacao a in this.Avaliacoes)
            {
                ret.Add((Avaliacao) a.Clone());
            }

            return ret;
        }
        
        set {
            this.Avaliacoes = new List<Avaliacao>();
            
            foreach( Avaliacao a in value)
            {
                this.Avaliacoes.Add((Avaliacao) a.Clone());
            }
        }
    }

    public Produto(int id, string imagem, string nome, string regime, List<string> ingredientes)
    {
        Id = id;
        Imagem = imagem;
        Nome = nome;
        Regime = regime;
        Ingredientes = new List<string>(ingredientes);
        Avaliacoes = new List<Avaliacao>();
    }

    private Produto(int id, string imagem, string nome, string regime, List<string> ingredientes, List<Avaliacao> avaliacoes)
    {
        Id = id;
        Imagem = imagem;
        Nome = nome;
        Regime = regime;
        Ingredientes = new List<string>(ingredientes);
        Avaliacoes = new List<Avaliacao>();

        foreach (Avaliacao a in avaliacoes)
            Avaliacoes.Add((Avaliacao)a.Clone());
    }

    public void AddRating(Avaliacao avaliacao)
    {
        Avaliacoes.Add((Avaliacao) avaliacao.Clone());
    }

    public object Clone()
    {
        return new Produto(Id, Imagem, Nome, Regime, Ingredientes, Avaliacoes);
    }
}