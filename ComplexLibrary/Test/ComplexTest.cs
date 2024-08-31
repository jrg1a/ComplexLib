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
}