class Rectangle : IShape
{
    public double Width { get; set; }
    public double Length { get; set; }

    public Rectangle(double width, double length)
    {
        if (width <= 0 || length <= 0)
        {
            throw new ArgumentException("Side lengths can't be less than or equal to zero.");
        }

        Width = width;
        Length = length;
    }

    public double Area()
    {
        return Width * Length;
    }

    public double Perimeter()
    {
        return (2 * Width) + (2 * Length);
    }

    public string Describe()
    {
        return "A two-dimensional, convex quadrilateral with four right angles (90°).";
    }
}