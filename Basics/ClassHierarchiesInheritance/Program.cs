// Exercise 2 — Class Hierarchies & Inheritance
// Topic: Superclass, subclass, method overriding

var dog = new Dog { Age = 10, Name = "Barty", Breed = "German Shepperd" };
var cat = new Cat { Age = 3, Name = "Max", FurLength = "5 cm" };
var parrot = new Parrot { Age = 3, Name = "Josie", Color = "Green" };

var animals = new List<Animal>
{
    dog,
    cat,
    parrot
};

foreach (var animal in animals)
{
    Console.WriteLine(animal.Speak());
}
