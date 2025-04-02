namespace S6_CSHARP_01.Models;

public static class StringExtensions
{
    public static bool IsPalindrome(this string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return false;

        string cleanedInput = new string(input
            .Where(char.IsLetterOrDigit)
            .Select(char.ToLower)
            .ToArray());

        return cleanedInput.SequenceEqual(cleanedInput.Reverse());
    }
    
    public static string FirstCharToUpper(this string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return input;

        input = input.ToLower();
        return char.ToUpper(input[0]) + input.Substring(1);
    }
}