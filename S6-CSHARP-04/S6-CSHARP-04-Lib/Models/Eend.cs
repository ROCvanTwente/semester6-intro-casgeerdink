namespace S6_CSHARP_04_Lib.Models;

public class Eend : Dier
{
    public Eend(string name, int gewicht) : base(name, gewicht) { }

    public override void MakeSound()
    {
        Console.WriteLine("kwak");
    }
}