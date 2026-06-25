class Circle : IShape
{
    public double Diameter { get; set; }
    public double Radius { get; set; }

    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("The radius can't be less than or equal to zero.");
        }

        Radius = radius;
        Diameter = radius * 2;
    }
    
    public double Area()
    {
        return Math.PI * (Radius * Radius);
    }

    public double Perimeter()
    {
        return Math.PI * 2 * Radius;
    }

    public string Describe()
    {
        return "A plane curve everywhere equidistant from a given fixed point, the center.";
    }
}