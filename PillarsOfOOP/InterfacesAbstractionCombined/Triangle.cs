class Triangle : IShape
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }

    public Triangle(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
        {
            throw new ArgumentException("Side lengths can't be less than or equal to zero.");
        }

        double[] sides = [a, b, c];
        Array.Sort(sides);

        var a2 = sides[0];
        var b2 = sides[1];
        var longest = sides[2];

        if (!((a2 + b2) > longest))
        {
            throw new ArgumentException("Violation of the Triangle Inequality Theorem.");
        }

        A = a;
        B = b;
        C = c;
    }

    public double Area()
    {
        var side = (A + B + C) / 2;
        return Math.Sqrt(side * (side - A) * (side - B) * (side - C));
    }

    public double Perimeter()
    {
        return A + B + C;
    }

    public string Describe()
    {
        return "A fundamental two-dimensional geometric shape and polygon defined by three straight sides, three vertices (corners), and three interior angles.";
    }
}