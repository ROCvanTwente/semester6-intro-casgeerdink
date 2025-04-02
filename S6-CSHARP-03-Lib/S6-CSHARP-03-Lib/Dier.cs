namespace S6_CSHARP_03_Lib;

public abstract class Dier
{
    public Dier(int gewicht)
    {
        Gewicht = gewicht;
    }

    public int Gewicht { get; set; }
    public abstract void Geluid();
}