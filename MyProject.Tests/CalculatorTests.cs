using Xunit;

public sealed class CalculatorTests
{
    [Fact]
    public void Smoke_Ok()
    {
        Assert.Equal(2, 1 + 1);
    }

    [Fact]
    public void Intentional_Fail()
    {
        Assert.Equal("HELLO!", "HELLO");
    }
}