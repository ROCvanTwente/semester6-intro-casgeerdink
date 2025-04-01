namespace S6_CSHARP_04_Lib.Models;

public class Schaap : Dier
{
    public Schaap(string name, int gewicht) : base(name, gewicht) { }

    public override void MakeSound()
    {
        Console.WriteLine("beh");
    }
}