using System;

public class Intervalo : ICloneable
{
    public TimeSpan Abertura { get; set; }
    public TimeSpan Fecho { get; set; }

    public Intervalo(TimeSpan abertura, TimeSpan fecho)
    {
        this.Abertura = abertura;
        this.Fecho = fecho;
    }

    public object Clone()
    {
        return new Intervalo(Abertura, Fecho);
    }
}