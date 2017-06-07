public class Produto
{
    public int id { get; set; }
    public int regime { get; set; }
    public string imagem { get; set; }
    public string nome { get; set; }
    public List<string> ingredientes {
        get { return new List<string>(ingredientes); }
        set { ingredientes = new List<string>(value); }
        }
    }
    public list<Avaliacao> avaliacoes {
        get {
            List<Avaliacao> ret = new List<Avaliacao>();
        
            foreach (Avaliacao a in avaliacoes)
            {
                ret.Add((Avaliacao) a.Clone());
            }

            return ret;
        }
        
        set { this.ingredientes = new list<string>(value); }
    }

    public Produto(int id, string imagem, string nome, int regime, List<string> ingredientes)
    {
        this.id = id;
        this.imagem = imagem;
        this.nome = nome;
        this.regime = regime;
        this.ingredientes = new List<string>(ingredientes);
        this.avaliacoes = new List<Avaliacao>();
    }
    
    public void addRating(Avaliacao avaliacao)
    {
        avaliacoes.Add((Avalaiacao) avaliacao.Clone());
    }
}