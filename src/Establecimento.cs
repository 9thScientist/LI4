using System.Collections.Generic;

public class Establecimento
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string Descricao { get; set; }
    public string Localizacao { get; set; }
    public int Rating { get; set; }
    public List<string> Galeria { get; set; }
    public int Responsavel { get; set; }
    public bool P_sugestoes { get; set; }
    public List<ISugestao> Sugestoes
    {
        get
        {
            List<ISugestao> ret = new List<ISugestao>();

            foreach(ISugestao s in Sugestoes)
            {
                ret.Add(s.Clone());
            }

            return ret;
        }

        set
        {
            Sugestoes = new List<ISugestao>();

            foreach(ISugestao s in value)
            {
                Sugestoes.Add(s.Clone());
            }
        }
    }
    public List<Dia> Horarios
    {
        get
        {
            List<Dia> ret = new List<Dia>();

            foreach( Dia d in Horarios)
            {
                ret.Add((Dia) d.Clone());
            }

            return ret;
        }

        set
        {
            Horarios = new List<Dia>();

            foreach( Dia d in value)
            {
                Horarios.Add((Dia) d.Clone());
            }
        }
    }
    public List<Produto> Menu
    {
        get
        {
            List<Produto> ret = new List<Produto>();

            foreach( Produto p in Menu)
            {
                ret.Add((Produto) p.Clone());
            }

            return ret;
        }

        set
        {
            Menu = new List<Produto>();

            foreach( Produto p in value )
            {
                Menu.Add((Produto) p.Clone());
            }
        }
    }

    public int GetDistance(int latitude, int longitude)
    {
        // TODO

        return 0;
    }

    public int GetDistancePrintable(int latitude, int longitude)
    {
        // TODO
        return 0;
    }

    public void AddSugestionProduct(int produto, SugestaoProduto sugestao)
    {
        // TODO
    }

    public void AddSugestionPlace(SugestaoEstablecimento sugestao)
    {
        // TODO
    }

    public void ApplySuggestion(ISugestao sugestao)
    {
        // TODO
    }

    public bool  RemoveMenu(int utilizador, int produto)
    {
        // TODO
        return false;
    }
}