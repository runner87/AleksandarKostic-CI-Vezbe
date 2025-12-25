using Xunit;

namespace Calculator.Tests;

public class CalculatorServiceTests
{
    private readonly CalculatorService _calculator = new();

    [Fact]
    public void Add_ReturnsCorrectSum()
    {
        var result = _calculator.Add(2, 3);
        Assert.Equal(5, result);
    }

    [Fact]
    public void Subtract_ReturnsCorrectDifference()
    {
        var result = _calculator.Subtract(6, 3);
        Assert.Equal(3, result);
    }

    [Fact]
    public void Divide_ByZero_ThrowsException()
    {
        Assert.Throws<DivideByZeroException>(() =>
            _calculator.Divide(10, 0));
       
    }

    [Fact]
    public void Multiply_ReturnsCorrectProduct()
    {
        var result = _calculator.Multiply(40, 5);
        Assert.Equal(200, result);
    }

    [Fact]
    public void Modulo_ReturnsRemainder()
    {
        var result = _calculator.Modulo(20, 3);
        Assert.Equal(2, result);
    }
}
