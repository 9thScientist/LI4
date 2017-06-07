using System;
using System.Collections.Generic;

public class Dia : ICloneable
{
    public List<Intervalo> Intervalos {
        get {
            List<Intervalo> ret = new List<Intervalo>();

            foreach (Intervalo i in Intervalos)
                ret.Add((Intervalo) i.Clone());

            return ret;
        }

        set {
            Intervalos = new List<Intervalo>();

            foreach(Intervalo i in value)
                Intervalos.Add((Intervalo) i.Clone());
        }
    }
    
    public Dia(List<Intervalo> intervls)
    {
        Intervalos = new List<Intervalo>();

        foreach(Intervalo i in intervls)
            Intervalos.Add((Intervalo) i.Clone());
    }

    public object Clone()
    {
        return new Dia(Intervalos);
    }
}