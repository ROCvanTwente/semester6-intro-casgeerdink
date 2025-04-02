using S6_CSHARP_01.Models;

namespace S6_CSHARP_01_Tests;

public class DecimalExtensionsTests
{
    [Fact]
    public void ToCurrencyString_ReturnsCorrectFormat_ForEuro()
    {
        // Arrange
        decimal amount = 1234.56m;

        // Act
        string result = amount.ToCurrencyString(CurrencyCountry.Euro);

        // Assert
        Assert.Contains("€", result);
    }
    
    [Fact]
    public void ToCurrencyString_ReturnsCorrectFormat_ForUSD()
    {
        // Arrange
        decimal amount = 1234.56m;

        // Act
        string result = amount.ToCurrencyString(CurrencyCountry.UnitedStates);

        // Assert
        Assert.Contains("$", result);
    }

}