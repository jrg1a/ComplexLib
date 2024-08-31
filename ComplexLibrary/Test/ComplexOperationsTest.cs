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
    
    
    
    /*
     * Here are some tests for the other methods in the ComplexOperations class.
     * The expected values are obtained from Wolfram Alpha.
     * - e.g. cos(1 + 1i) = 0.833730025131149 + 0.988897705762865i
     * 
     * The tolerance for the comparison is set to 1e-10. (as the expected values are not exact)
     * 
     */
    
    
    
    [Fact]
    public void TestSqrt()
    {
        var a = new Complex(1, 1);
        var result = ComplexOperations.Sqrt(a);
        Assert.Equal(new Complex(1.09868411346781, 0.455089860562227), result, new ComplexEqualityComparer(1e-10));
    }
    
    [Fact]
    public void TestExp()
    {
        var a = new Complex(1, 1);
        var result = ComplexOperations.Exp(a);
        Assert.Equal(new Complex(1.46869393991589, 2.28735528717884), result, new ComplexEqualityComparer(1e-10));
    }
    
    [Fact]
    public void TestLog()
    {
        var a = new Complex(1, 1);
        var result = ComplexOperations.Log(a);
        Assert.Equal(new Complex(0.346573590279973, 0.785398163397448), result, new ComplexEqualityComparer(1e-10));
    }
    
    [Fact]
    public void TestSin()
    {
        var a = new Complex(1, 1);
        var result = ComplexOperations.Sin(a);
        Assert.Equal(new Complex(1.29845758141598, 0.634963914784736), result, new ComplexEqualityComparer(1e-10));
    }
    
    [Fact]
    public void TestCos()
    {
        var a = new Complex(1, 1);
        var result = ComplexOperations.Cos(a);
        Assert.Equal(new Complex(0.833730025131149, -0.988897705762865), result, new ComplexEqualityComparer(1e-10));
    }
    
    [Fact]
    public void TestTan()
    {
        var a = new Complex(1, 1);
        var result = ComplexOperations.Tan(a);
        Assert.Equal(new Complex(0.271752585319512, 1.08392332733869), result, new ComplexEqualityComparer(1e-10));
    }
    
    [Fact]
    public void TestSinh()
    {
        var a = new Complex(1, 1);
        var result = ComplexOperations.Sinh(a);
        Assert.Equal(new Complex(0.634963914784736, 1.29845758141598), result, new ComplexEqualityComparer(1e-10));
    }
    
    [Fact]
    public void TestCosh()
    {
        var a = new Complex(1, 1);
        var result = ComplexOperations.Cosh(a);
        Assert.Equal(new Complex(0.83373002513114, 0.988897705762865), result, new ComplexEqualityComparer(1e-10));
    }
    
    [Fact]
    public void TestTanh()
    {
        var a = new Complex(1, 1);
        var result = ComplexOperations.Tanh(a);
        Assert.Equal(new Complex(1.08392332733869, 0.271752585319512), result, new ComplexEqualityComparer(1e-10));
    }
    
    [Fact]
    public void TestAsin()
    {
        var a = new Complex(1, 1);
        var result = ComplexOperations.Asin(a);
        Assert.Equal(new Complex(0.666239432492515, 1.06127506190504), result, new ComplexEqualityComparer(1e-10));
    }
    
    [Fact]
    public void TestAcos()
    {
        var a = new Complex(1, 1);
        var result = ComplexOperations.Acos(a);
        Assert.Equal(new Complex(0.904556894302381, -1.06127506190504), result, new ComplexEqualityComparer(1e-10));
    }
    
    
    /*
     * Wolfram Alpha: atanh(1 + 1i)
1.017221967897851367722788961550482922063560876986836587149202692437053033654423102307308848327973213273801947753915995418526370... +
0.4023594781085250936501898333065469098814003385671294304781619728685447469269144411575334695232949026999915757554288907249310013... i
(result in radians)
     */
    [Fact]
    public void TestAtan()
    {
        var a = new Complex(1, 1);
        var result = ComplexOperations.Atan(a);
        Assert.Equal(new Complex(1.017221967897851, 0.402359478108525), result, new ComplexEqualityComparer(1e-10));
    }
    
    [Fact]
    public void TestAsinh()
    {
        var a = new Complex(1, 1);
        var result = ComplexOperations.Asinh(a);
        Assert.Equal(new Complex(1.06127506190504, 0.666239432492515), result, new ComplexEqualityComparer(1e-10));
    }
    
    [Fact]
    public void TestAcosh()
    {
        var a = new Complex(1, 1);
        var result = ComplexOperations.Acosh(a);
        Assert.Equal(new Complex(1.06127506190504, 0.904556894302381), result, new ComplexEqualityComparer(1e-10));
    }
    [Fact]
    public void TestAtanh()
    {
        var a = new Complex(1, 1);
        var result = ComplexOperations.Atanh(a);
        var expected = new Complex(0.402359478108525, 1.0172219678978514); // Correct expected value for atanh(1 + 1i)

        Assert.Equal(expected, result, new ComplexEqualityComparer(1e-10));
    }
    
    
    
}


/// <summary>
/// Class that implements IEqualityComparer for Complex numbers.
/// </summary>
public class ComplexEqualityComparer : IEqualityComparer<Complex>
{
    private readonly double tolerance;

    /// <summary>
    /// Initializes a new instance of the ComplexEqualityComparer class with the specified tolerance.
    /// </summary>
    /// <param name="tolerance">The tolerance used to compare the real and imaginary parts of the Complex numbers.</param>
    public ComplexEqualityComparer(double tolerance = 1e-10)
    {
        this.tolerance = tolerance;
    }
    
    /// <summary>
    /// Determines whether the specified Complex objects are equal.
    /// </summary>
    /// <param name="x">The first Complex object to compare.</param>
    /// <param name="y">The second Complex object to compare.</param>
    /// <returns>true if the specified Complex objects are equal; otherwise, false
    public bool Equals(Complex x, Complex y)
    {
        return Math.Abs(x.RealPart - y.RealPart) < tolerance && Math.Abs(x.ImaginaryPart - y.ImaginaryPart) < tolerance;
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