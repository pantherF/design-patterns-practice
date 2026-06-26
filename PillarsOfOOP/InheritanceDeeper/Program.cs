// Exercise 6 — Inheritance (deeper)
// Topic: Abstract classes, forced overrides

var bicycle = new Bicycle();
var electricCar = new ElectricCar();
var petrolMotorcycle = new PetrolMotorcycle();

Console.WriteLine(bicycle.Describe());
Console.WriteLine(electricCar.Describe());
Console.WriteLine(petrolMotorcycle.Describe());

// This will give a build error, and also shows up in intellisense:
// var vehicle = new Vehicle();

// Intellisense: Cannot create an instance of the abstract type or interface 'Vehicle'

// Build error:
// error CS0144: Cannot create an instance of the abstract type or interface 'Vehicle'
// The build failed. Fix the build errors and run again.