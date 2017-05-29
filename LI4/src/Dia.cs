public class Dia : ICloneable
{
    public List<Intervalo> intervalos {
        get {
            List<Intervalo> ret = new List<Intervalo>();

            foreach (Intervalo i in intervalos)
                ret.Add((Intervalo) i.Clone());

            return ret;
        }

        set {
            intervalos = new List<Intervalo>();

            foreach(Intervalo i in value)
                intervalos.Add((Intervalo) i.Clone);
        }
    }
    
    public Dia(List<Intervalo> intervalos)
    {
        intervalos = new List<Intervalo>();

        foreach(Intervalo i in value)
            intervalos.Add((Intervalo) i.Clone);
    }

    public Dia Clone()
    {
        return new Dia(intervalos);
    }
}