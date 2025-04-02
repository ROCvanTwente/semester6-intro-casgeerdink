namespace S6_CSHARP_01_Tests;

public class DateTimeExtensionsTests
{
    [Fact]
    public void AddMinutes_ReturnsCorrectFutureDateTime()
    {
        // Arrange
        DateTime initialTime = new DateTime(2025, 3, 25, 12, 0, 0); // 25 maart 2025, 12:00:00

        // Act
        DateTime result = initialTime.AddMinutes(30);

        // Assert
        Assert.Equal(new DateTime(2025, 3, 25, 12, 30, 0), result);
    }
    
    [Fact]
    public void AddMinutes_ReturnsCorrectPastDateTime()
    {
        // Arrange
        DateTime initialTime = new DateTime(2025, 3, 25, 12, 0, 0); // 25 maart 2025, 12:00:00

        // Act
        DateTime result = initialTime.AddMinutes(-15);

        // Assert
        Assert.Equal(new DateTime(2025, 3, 25, 11, 45, 0), result);
    }
}