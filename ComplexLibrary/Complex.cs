namespace ComplexLibrary;

/// <summary>
/// Represents a complex number with real and imaginary parts.
/// </summary>
public class Complex
{
    private double realPart;
    private double imaginaryPart;

    /// <summary>
    /// Initializes a new instance of the <see cref="Complex"/> class.
    /// </summary>
    /// <param name="realPart">The real part of the complex number.</param>
    /// <param name="imaginaryPart">The imaginary part of the complex number.</param>
    public Complex(double realPart, double imaginaryPart)
    {
        this.realPart = realPart;
        this.imaginaryPart = imaginaryPart;
    }

    /// <summary>
    /// Returns a string that represents the current complex number.
    /// </summary>
    /// <returns>A string that represents the current complex number.</returns>
    public override string ToString()
    {
        if (this.imaginaryPart >= 0)
        {
            return string.Format("{0:F2} + {1:F2}i", this.realPart, this.imaginaryPart);
        }
        else
        {
            return string.Format("{0:F2} - {1:F2}i", this.realPart, Math.Abs(this.imaginaryPart));
        }
    }

    /// <summary>
    /// Returns the conjugate of the current complex number.
    /// </summary>
    /// <returns>A new <see cref="Complex"/> object that is the conjugate of the current complex number.</returns>
    public Complex Conjugate()
    {
        return new Complex(this.realPart, -this.imaginaryPart);
    }

    /// <summary>
    /// Returns the magnitude of the current complex number.
    /// </summary>
    /// <returns>The magnitude of the current complex number.</returns>
    public double Magnitude()
    {
        return Math.Sqrt(Math.Pow(this.realPart, 2) + Math.Pow(this.imaginaryPart, 2));
    }

    /// <summary>
    /// Returns the phase of the current complex number.
    /// </summary>
    /// <returns>The phase of the current complex number.</returns>
    public double Phase()
    {
        return Math.Atan2(this.imaginaryPart, this.realPart);
    }

    /// <summary>
    /// Determines whether the specified object is equal to the current complex number.
    /// </summary>
    /// <param name="obj">The object to compare with the current complex number.</param>
    /// <returns>true if the specified object is equal to the current complex number; otherwise, false.</returns>
    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }
        Complex other = (Complex)obj;
        return this.realPart == other.realPart && this.imaginaryPart == other.imaginaryPart;
    }

    /// <summary>
    /// Returns a hash code for the current complex number.
    /// </summary>
    /// <returns>A hash code for the current complex number.</returns>
    public override int GetHashCode()
    {
        return this.realPart.GetHashCode() ^ this.imaginaryPart.GetHashCode();
    }

    /// <summary>
    /// Gets or sets the real part of the complex number.
    /// </summary>
    public double RealPart
    {
        get { return this.realPart; }
        set { this.realPart = value; }
    }

    /// <summary>
    /// Gets or sets the imaginary part of the complex number.
    /// </summary>
    public double ImaginaryPart
    {
        get { return this.imaginaryPart; }
        set { this.imaginaryPart = value; }
    }

    /// <summary>
    /// Adds two complex numbers.
    /// </summary>
    /// <param name="a">The first complex number.</param>
    /// <param name="b">The second complex number.</param>
    /// <returns>The sum of the two complex numbers.</returns>
    public static Complex operator +(Complex a, Complex b)
    {
        return ComplexOperations.Add(a, b);
    }

    /// <summary>
    /// Subtracts the second complex number from the first.
    /// </summary>
    /// <param name="a">The first complex number.</param>
    /// <param name="b">The second complex number.</param>
    /// <returns>The difference between the two complex numbers.</returns>
    public static Complex operator -(Complex a, Complex b)
    {
        return ComplexOperations.Subtract(a, b);
    }

    /// <summary>
    /// Multiplies two complex numbers.
    /// </summary>
    /// <param name="a">The first complex number.</param>
    /// <param name="b">The second complex number.</param>
    /// <returns>The product of the two complex numbers.</returns>
    public static Complex operator *(Complex a, Complex b)
    {
        return ComplexOperations.Multiply(a, b);
    }

    /// <summary>
    /// Divides the first complex number by the second.
    /// </summary>
    /// <param name="a">The first complex number.</param>
    /// <param name="b">The second complex number.</param>
    /// <returns>The quotient of the two complex numbers.</returns>
    public static Complex operator /(Complex a, Complex b)
    {
        return ComplexOperations.Divide(a, b);
    }

    /// <summary>
    /// Converts the string representation of a complex number to its <see cref="Complex"/> equivalent.
    /// </summary>
    /// <param name="s">A string that contains a complex number to convert.</param>
    /// <returns>A <see cref="Complex"/> equivalent to the complex number contained in <paramref name="s"/>.</returns>
    public static Complex Parse(string s)
    {
        s = s.Replace(" ", "").Replace("i", "");
        double real = 0, imaginary = 0;
        bool isNegative = s.Contains("-");
        string[] parts = s.Split(new char[] { '+', '-' }, StringSplitOptions.RemoveEmptyEntries);
        if (parts.Length == 2)
        {
            real = double.Parse(parts[0]);
            imaginary = double.Parse(parts[1]);
            if (isNegative) imaginary = -imaginary;
        }
        else if (s.EndsWith("i"))
        {
            imaginary = double.Parse(parts[0]);
        }
        else
        {
            real = double.Parse(parts[0]);
        }
        return new Complex(real, imaginary);
    }
}