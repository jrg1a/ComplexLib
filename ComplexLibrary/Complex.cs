namespace ComplexLibrary;

public class Complex
{
    private double realPart;
    private double imaginaryPart;

    public Complex(double realPart, double imaginaryPart)
    {
        this.realPart = realPart;
        this.imaginaryPart = imaginaryPart;
    }

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

    public Complex Conjugate()
    {
        return new Complex(this.realPart, -this.imaginaryPart);
    }

    public double Magnitude()
    {
        return Math.Sqrt(Math.Pow(this.realPart, 2) + Math.Pow(this.imaginaryPart, 2));
    }

    public double Phase()
    {
        return Math.Atan2(this.imaginaryPart, this.realPart);
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }
        Complex other = (Complex)obj;
        return this.realPart == other.realPart && this.imaginaryPart == other.imaginaryPart;
    }

    public override int GetHashCode()
    {
        return this.realPart.GetHashCode() ^ this.imaginaryPart.GetHashCode();
    }

    public double RealPart
    {
        get { return this.realPart; }
        set { this.realPart = value; }
    }

    public double ImaginaryPart
    {
        get { return this.imaginaryPart; }
        set { this.imaginaryPart = value; }
    }

    public static Complex operator +(Complex a, Complex b)
    {
        return ComplexOperations.Add(a, b);
    }

    public static Complex operator -(Complex a, Complex b)
    {
        return ComplexOperations.Subtract(a, b);
    }

    public static Complex operator *(Complex a, Complex b)
    {
        return ComplexOperations.Multiply(a, b);
    }

    public static Complex operator /(Complex a, Complex b)
    {
        return ComplexOperations.Divide(a, b);
    }

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