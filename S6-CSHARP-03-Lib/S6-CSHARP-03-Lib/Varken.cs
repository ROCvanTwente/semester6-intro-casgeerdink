namespace S6_CSHARP_03_Lib;

public class Varken : Dier
{
    public Varken(int gewicht) : base(gewicht)
    {
    }

    public override void Geluid()
    {
        Console.WriteLine("knor!");
    }
}