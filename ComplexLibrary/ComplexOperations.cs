namespace ComplexLibrary;

/// <summary>
/// Provides operations for complex numbers.
/// </summary>
public static class ComplexOperations
{
    /// <summary>
    /// Adds two complex numbers.
    /// </summary>
    /// <param name="a">The first complex number.</param>
    /// <param name="b">The second complex number.</param>
    /// <returns>The sum of the two complex numbers.</returns>
    public static Complex Add(Complex a, Complex b)
    {
        return new Complex(a.RealPart + b.RealPart, a.ImaginaryPart + b.ImaginaryPart);
    }

    /// <summary>
    /// Subtracts the second complex number from the first.
    /// </summary>
    /// <param name="a">The first complex number.</param>
    /// <param name="b">The second complex number.</param>
    /// <returns>The difference of the two complex numbers.</returns>
    public static Complex Subtract(Complex a, Complex b)
    {
        return new Complex(a.RealPart - b.RealPart, a.ImaginaryPart - b.ImaginaryPart);
    }

    /// <summary>
    /// Multiplies two complex numbers.
    /// </summary>
    /// <param name="a">The first complex number.</param>
    /// <param name="b">The second complex number.</param>
    /// <returns>The product of the two complex numbers.</returns>
    public static Complex Multiply(Complex a, Complex b)
    {
        double realProduct = a.RealPart * b.RealPart - a.ImaginaryPart * b.ImaginaryPart;
        double imaginaryProduct = a.RealPart * b.ImaginaryPart + a.ImaginaryPart * b.RealPart;
        return new Complex(realProduct, imaginaryProduct);
    }

    /// <summary>
    /// Divides the first complex number by the second.
    /// </summary>
    /// <param name="a">The first complex number.</param>
    /// <param name="b">The second complex number.</param>
    /// <returns>The quotient of the two complex numbers.</returns>
    public static Complex Divide(Complex a, Complex b)
    {
        double denominator = Math.Pow(b.RealPart, 2) + Math.Pow(b.ImaginaryPart, 2);
        if (denominator == 0)
        {
            throw new DivideByZeroException("Cannot divide by a complex number with zero magnitude.");
        }
        double realPart = (a.RealPart * b.RealPart + a.ImaginaryPart * b.ImaginaryPart) / denominator;
        double imaginaryPart = (a.ImaginaryPart * b.RealPart - a.RealPart * b.ImaginaryPart) / denominator;
        return new Complex(realPart, imaginaryPart);
    }

    /// <summary>
    /// Converts a complex number to its polar form.
    /// </summary>
    /// <param name="a">The complex number.</param>
    /// <returns>The polar form of the complex number.</returns>
    public static Complex PolarForm(Complex a)
    {
        double magnitude = Math.Sqrt(Math.Pow(a.RealPart, 2) + Math.Pow(a.ImaginaryPart, 2));
        double angle = Math.Atan2(a.ImaginaryPart, a.RealPart);
        return new Complex(magnitude, angle);
    }

    /// <summary>
    /// Calculates the exponential of a complex number.
    /// </summary>
    /// <param name="a">The complex number.</param>
    /// <returns>The exponential of the complex number.</returns>
    public static Complex Exp(Complex a)
    {
        double expReal = Math.Exp(a.RealPart);
        return new Complex(expReal * Math.Cos(a.ImaginaryPart), expReal * Math.Sin(a.ImaginaryPart));
    }

    /// <summary>
    /// Calculates the natural logarithm of a complex number.
    /// </summary>
    /// <param name="a">The complex number.</param>
    /// <returns>The natural logarithm of the complex number.</returns>
    public static Complex Log(Complex a)
    {
        return new Complex(Math.Log(a.Magnitude()), a.Phase());
    }

    /// <summary>
    /// Calculates the sine of a complex number.
    /// </summary>
    /// <param name="a">The complex number.</param>
    /// <returns>The sine of the complex number.</returns>
    public static Complex Sin(Complex a)
    {
        return new Complex(Math.Sin(a.RealPart) * Math.Cosh(a.ImaginaryPart), Math.Cos(a.RealPart) * Math.Sinh(a.ImaginaryPart));
    }

    /// <summary>
    /// Calculates the cosine of a complex number.
    /// </summary>
    /// <param name="a">The complex number.</param>
    /// <returns>The cosine of the complex number.</returns>
    public static Complex Cos(Complex a)
    {
        return new Complex(Math.Cos(a.RealPart) * Math.Cosh(a.ImaginaryPart), -Math.Sin(a.RealPart) * Math.Sinh(a.ImaginaryPart));
    }

    /// <summary>
    /// Calculates the tangent of a complex number.
    /// </summary>
    /// <param name="a">The complex number.</param>
    /// <returns>The tangent of the complex number.</returns>
    public static Complex Tan(Complex a)
    {
        return Divide(Sin(a), Cos(a));
    }

    /// <summary>
    /// Calculates the hyperbolic sine of a complex number.
    /// </summary>
    /// <param name="a">The complex number.</param>
    /// <returns>The hyperbolic sine of the complex number.</returns>
    public static Complex Sinh(Complex a)
    {
        return new Complex(Math.Sinh(a.RealPart) * Math.Cos(a.ImaginaryPart), Math.Cosh(a.RealPart) * Math.Sin(a.ImaginaryPart));
    }

    /// <summary>
    /// Calculates the hyperbolic cosine of a complex number.
    /// </summary>
    /// <param name="a">The complex number.</param>
    /// <returns>The hyperbolic cosine of the complex number.</returns>
    public static Complex Cosh(Complex a)
    {
        return new Complex(Math.Cosh(a.RealPart) * Math.Cos(a.ImaginaryPart), Math.Sinh(a.RealPart) * Math.Sin(a.ImaginaryPart));
    }

    /// <summary>
    /// Calculates the hyperbolic tangent of a complex number.
    /// </summary>
    /// <param name="a">The complex number.</param>
    /// <returns>The hyperbolic tangent of the complex number.</returns>
    public static Complex Tanh(Complex a)
    {
        return Divide(Sinh(a), Cosh(a));
    }

    /// <summary>
    /// Calculates the square root of a complex number.
    /// </summary>
    /// <param name="a">The complex number.</param>
    /// <returns>The square root of the complex number.</returns>
    public static Complex Sqrt(Complex a)
    {
        double magnitude = Math.Sqrt(a.Magnitude());
        double angle = a.Phase() / 2;
        return new Complex(magnitude * Math.Cos(angle), magnitude * Math.Sin(angle));
    }

    /// <summary>
    /// Calculates the arcsine of a complex number.
    /// </summary>
    /// <param name="a">The complex number.</param>
    /// <returns>The arcsine of the complex number.</returns>
    public static Complex Asin(Complex a)
    {
        Complex i = new Complex(0, 1);
        Complex minusI = new Complex(0, -1);
        Complex one = new Complex(1, 0);
        Complex result = minusI * Log(i * a + Sqrt(one - a * a));
        return result;
    }

    /// <summary>
    /// Calculates the arccosine of a complex number.
    /// </summary>
    /// <param name="a">The complex number.</param>
    /// <returns>The arccosine of the complex number.</returns>
    public static Complex Acos(Complex a)
    {
        Complex i = new Complex(0, 1);
        Complex minusI = new Complex(0, -1);
        Complex one = new Complex(1, 0);
        Complex result = minusI * Log(a + i * Sqrt(one - a * a));
        return result;
    }

    /// <summary>
    /// Calculates the arctangent of a complex number.
    /// </summary>
    /// <param name="a">The complex number.</param>
    /// <returns>The arctangent of the complex number.</returns>
    public static Complex Atan(Complex a)
    {
        Complex i = new Complex(0, 1);
        Complex one = new Complex(1, 0);
        Complex two = new Complex(2, 0);
        Complex result = (i / two) * (Log(one - i * a) - Log(one + i * a));
        return result;
    }

    /// <summary>
    /// Calculates the hyperbolic arcsine of a complex number.
    /// </summary>
    /// <param name="a">The complex number.</param>
    /// <returns>The hyperbolic arcsine of the complex number.</returns>
    public static Complex Asinh(Complex a)
    {
        return Log(a + Sqrt(a * a + new Complex(1, 0)));
    }

    /// <summary>
    /// Calculates the hyperbolic arccosine of a complex number.
    /// </summary>
    /// <param name="a">The complex number.</param>
    /// <returns>The hyperbolic arccosine of the complex number.</returns>
    public static Complex Acosh(Complex a)
    {
        return Log(a + Sqrt(a + new Complex(1, 0)) * Sqrt(a - new Complex(1, 0)));
    }

    /// <summary>
    /// Calculates the hyperbolic arctangent of a complex number.
    /// </summary>
    /// <param name="a">The complex number.</param>
    /// <returns>The hyperbolic arctangent of the complex number.</returns>
    public static Complex Atanh(Complex a)
    {
        Complex one = new Complex(1, 0);
        return Divide(Log(one + a) - Log(one - a), new Complex(2, 0));
    }
    
}