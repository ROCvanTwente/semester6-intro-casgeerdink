using S6_CSHARP_01.Models;

namespace S6_CSHARP_01_Tests;

public class IntExtensionsTests
{
    [Fact]
    public void IsEven_ReturnsTrue_ForEvenNumber()
    {
        // Arrange
        int number = 10;

        // Act
        bool result = number.IsEven();

        // Assert
        Assert.True(result);
    }
    
    [Fact]
    public void IsEven_ReturnsFalse_ForOddNumber()
    {
        // Arrange
        int number = 7;

        // Act
        bool result = number.IsEven();

        // Assert
        Assert.False(result);
    }
}