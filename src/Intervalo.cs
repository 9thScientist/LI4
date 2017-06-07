public class Intervalo : ICloneable
{
    public TimeSpan abertura { get; set; }
    public TimeSpan fecho { get; set; }

    public Intervalo(TimeSpan abertura, TimeSpan fecho)
    {
        this.abertura = abertura;
        this.fecho = fecho;
    }

    public Intervalo Clone()
    {
        return new Intervalo(abertura, fecho);
    }
}