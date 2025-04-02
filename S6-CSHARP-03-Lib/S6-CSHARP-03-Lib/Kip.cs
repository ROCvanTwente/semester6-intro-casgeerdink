namespace S6_CSHARP_03_Lib;

public class Kip : Dier
{
    public Kip(int gewicht) : base(gewicht)
    {
    }

    public override void Geluid()
    {
        Console.WriteLine("De kip zegt: Tok tok!");
    }
}