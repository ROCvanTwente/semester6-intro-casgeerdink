namespace S6_CSHARP_01.Models;

public static class IntExtensions
{
    public static bool IsEven(this int number)
    {
        return number % 2 == 0;
    }
}