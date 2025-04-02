namespace S6_CSHARP_03_Lib;

public class Hond : Dier
{
    public Hond(int gewicht) : base(gewicht)
    {
    }

    public override void Geluid()
    {
        Console.WriteLine("hond blaft");
    }
}