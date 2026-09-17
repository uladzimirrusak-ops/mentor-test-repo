using Xunit;
using StudentProject; // Неймспейс класса студента

public sealed class CalculatorTests
{
    [Fact]
    public void Add_TwoNumbers_ReturnsSum()
    {
        var calc = new Calculator();
        var result = calc.Add(2, 24);
        Assert.Equal(5, result);
    }
}
