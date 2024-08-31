namespace ComplexLibrary.Test;

using Xunit;
using ComplexLibrary;

/// <summary>
/// Contains unit tests for the ComplexOperations class.
/// </summary>
public class ComplexOperationsTests
{
    /// <summary>
    /// Tests the Add method of ComplexOperations.
    /// </summary>
    [Fact]
    public void TestAdd()
    {
        var a = new Complex(1, 2);
        var b = new Complex(3, 4);
        var result = ComplexOperations.Add(a, b);
        Assert.Equal(new Complex(4, 6), result, new ComplexEqualityComparer());
    }

    /// <summary>
    /// Tests the Subtract method of ComplexOperations.
    /// </summary>
    [Fact]
    public void TestSubtract()
    {
        var a = new Complex(5, 6);
        var b = new Complex(3, 4);
        var result = ComplexOperations.Subtract(a, b);
        Assert.Equal(new Complex(2, 2), result, new ComplexEqualityComparer());
    }

    /// <summary>
    /// Tests the Multiply method of ComplexOperations.
    /// </summary>
    [Fact]
    public void TestMultiply()
    {
        var a = new Complex(1, 2);
        var b = new Complex(3, 4);
        var result = ComplexOperations.Multiply(a, b);
        Assert.Equal(new Complex(-5, 10), result, new ComplexEqualityComparer());
    }

    /// <summary>
    /// Tests the Divide method of ComplexOperations.
    /// </summary>
    [Fact]
    public void TestDivide()
    {
        var a = new Complex(1, 2);
        var b = new Complex(3, 4);
        var result = ComplexOperations.Divide(a, b);
        Assert.Equal(new Complex(0.44, 0.08), result, new ComplexEqualityComparer());
    }
    
    // TODO: Add tests for the Polar method.
    // TODO: Add tests for the Parse method.
    // TODO: Add tests for the ToString method.
    // TODO: Add tests for the Equals method.
    // TODO: Add tests for the GetHashCode method.
    // TODO: Add tests for the operators.
    // etc.
    
    
    
}


/// <summary>
/// Class that implements IEqualityComparer for Complex numbers.
/// </summary>
public class ComplexEqualityComparer : IEqualityComparer<Complex>
{
    /// <summary>
    /// Determines whether the specified Complex objects are equal.
    /// </summary>
    /// <param name="x">The first Complex object to compare.</param>
    /// <param name="y">The second Complex object to compare.</param>
    /// <returns>true if the specified Complex objects are equal; otherwise, false.</returns>
    public bool Equals(Complex x, Complex y)
    {
        return x.RealPart == y.RealPart && x.ImaginaryPart == y.ImaginaryPart;
    }

    /// <summary>
    /// Returns a hash code for the specified Complex object.
    /// </summary>
    /// <param name="obj">The Complex object for which a hash code is to be returned.</param>
    /// <returns>A hash code for the specified Complex object.</returns>
    public int GetHashCode(Complex obj)
    {
        return obj.RealPart.GetHashCode() ^ obj.ImaginaryPart.GetHashCode();
    }
}