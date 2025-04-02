using S6_CSHARP_01.Models;

namespace S6_CSHARP_01_Tests;

public class StringExtensionsTests
{
    [Fact]
    public void IsPalindrome_ReturnsTrue_ForPalindrome()
    {
        // Arrange
        string input = "racecar";

        // Act
        bool result = input.IsPalindrome();

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsPalindrome_ReturnsFalse_ForNonPalindrome()
    {
        // Arrange
        string input = "hello";

        // Act
        bool result = input.IsPalindrome();

        // Assert
        Assert.False(result);
    }
    
    [Fact]
    public void FirstCharToUpper_ReturnsCorrectFormat_ForKoffietijd()
    {
        // Arrange
        string input = "koffietijd";

        // Act
        string result = input.FirstCharToUpper();

        // Assert
        Assert.Equal("Koffietijd", result);
    }
    
    [Fact]
    public void FirstCharToUpper_ReturnsCorrectFormat_ForComplexSentence()
    {
        // Arrange
        string input = "deze Zin kent wat VreemD Gebruik van HOOFDLETTERS";

        // Act
        string result = input.FirstCharToUpper();

        // Assert
        Assert.Equal("Deze zin kent wat vreemd gebruik van hoofdletters", result);
    }
}