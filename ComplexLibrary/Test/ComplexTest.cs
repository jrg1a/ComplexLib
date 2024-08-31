namespace ComplexLibrary.Test;

using Xunit;

/// <summary>
/// Contains unit tests for the Complex class.
/// </summary>
public class ComplexTest
{
    /// <summary>
    /// Tests the addition of two Complex numbers.
    /// </summary>
    [Fact]
    public void TestAddition()
    {
        var a = new Complex(1, 2);
        var b = new Complex(3, 4);
        var result = a + b;
        Assert.Equal(new Complex(4, 6), result);
    }

    /// <summary>
    /// Tests the subtraction of two Complex numbers.
    /// </summary>
    [Fact]
    public void TestSubtraction()
    {
        var a = new Complex(5, 6);
        var b = new Complex(3, 4);
        var result = a - b;
        Assert.Equal(new Complex(2, 2), result);
    }

    /// <summary>
    /// Tests the magnitude calculation of a Complex number.
    /// </summary>
    [Fact]
    public void TestMagnitude()
    {
        var a = new Complex(3, 4);
        var result = a.Magnitude();
        Assert.Equal(5, result);
    }

    /// <summary>
    /// Tests the phase calculation of a Complex number.
    /// </summary>
    [Fact]
    public void TestPhase()
    {
        var a = new Complex(1, 1);
        var result = a.Phase();
        Assert.Equal(Math.PI / 4, result, 5);
    }


    [Fact]
    public void TestConjugate()
    {
        var a = new Complex(1, 2);
        var result = a.Conjugate();
        Assert.Equal(new Complex(1, -2), result);
    }
    
    [Fact]
    public void TestEquals()
    {
        var a = new Complex(1, 2);
        var b = new Complex(1, 2);
        Assert.True(a.Equals(b));
    }
    
    [Fact]
    public void TestNotEquals()
    {
        var a = new Complex(1, 2);
        var b = new Complex(1, 3);
        Assert.False(a.Equals(b));
    }
    
    
    [Fact]
    public void TestToString()
    {
        var a = new Complex(1, 2);
        var result = a.ToString();
        Assert.Equal("1,00 + 2,00i", result);
    }
    
    [Fact]
    public void TestParse()
    {
        var result = Complex.Parse("1,00 + 2,00i");
        Assert.Equal(new Complex(1, 2), result);
    }
    
    
    
    [Fact]
    public void TestAdditionOperator()
    {
        var a = new Complex(1, 2);
        var b = new Complex(3, 4);
        var result = a + b;
        Assert.Equal(new Complex(4, 6), result);
    }
    
    [Fact]
    public void TestSubtractionOperator()
    {
        var a = new Complex(5, 6);
        var b = new Complex(3, 4);
        var result = a - b;
        Assert.Equal(new Complex(2, 2), result);
    }
    
    [Fact]
    public void TestMultiplicationOperator()
    {
        var a = new Complex(1, 2);
        var b = new Complex(3, 4);
        var result = a * b;
        Assert.Equal(new Complex(-5, 10), result);
    }
    
    [Fact]
    public void TestDivisionOperator()
    {
        var a = new Complex(1, 2);
        var b = new Complex(3, 4);
        var result = a / b;
        Assert.Equal(new Complex(0.44, 0.08), result);
    }
    
    
    
    
    
  
    
    
}