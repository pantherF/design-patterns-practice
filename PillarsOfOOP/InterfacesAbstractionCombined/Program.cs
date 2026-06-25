// Exercise 5 — Interfaces & Abstraction (combined)
// Topic: Contracts, interface keyword

void PrintShapeInfo(IShape shape)
{
    Console.WriteLine(shape);
    Console.WriteLine($"Area: {shape.Area()}");
    Console.WriteLine($"Perimeter: {shape.Perimeter()}");
    Console.WriteLine($"Description: {shape.Describe()}");
    Console.WriteLine($"===");
}

var shapes = new List<IShape>
{
    new Rectangle(4.0, 7.0),
    new Rectangle(10.0, 3.5),
    new Circle(5.0),
    new Circle(2.5),
    new Triangle(3.0, 4.0, 5.0),
    new Triangle(6.0, 6.0, 6.0)
};

foreach (var shape in shapes)
{
    PrintShapeInfo(shape);
}

// output:
// Rectangle
// Area: 28
// Perimeter: 22
// Description: A two-dimensional, convex quadrilateral with four right angles (90°).
// ===
// Rectangle
// Area: 35
// Perimeter: 27
// Description: A two-dimensional, convex quadrilateral with four right angles (90°).
// ===
// Circle
// Area: 78.53981633974483
// Perimeter: 31.41592653589793
// Description: A plane curve everywhere equidistant from a given fixed point, the center.
// ===
// Circle
// Area: 19.634954084936208
// Perimeter: 15.707963267948966
// Description: A plane curve everywhere equidistant from a given fixed point, the center.
// ===
// Triangle
// Area: 6
// Perimeter: 12
// Description: A fundamental two-dimensional geometric shape and polygon defined by three straight sides, three vertices (corners), and three interior angles.
// ===
// Triangle
// Area: 15.588457268119896
// Perimeter: 18
// Description: A fundamental two-dimensional geometric shape and polygon defined by three straight sides, three vertices (corners), and three interior angles.
// ===