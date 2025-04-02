namespace S6_CSHARP_04_Lib.Models;

public class Koe : Dier
{
    public Koe(string name, int gewicht) : base(name, gewicht) { }

    public override void MakeSound()
    {
        Console.WriteLine("moe");
    } 
}