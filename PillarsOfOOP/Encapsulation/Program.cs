// Exercise 4 — Encapsulation
// Topic: Private state, public interface

var temp = new Temperature();

temp.Celsius = 160.0;

Console.WriteLine(temp.Celsius);
Console.WriteLine(temp.Fahrenheit);
Console.WriteLine(temp.Kelvin);

try
{
    temp.Celsius = -300.0;
    // output when unhandled:
    // Unhandled exception. System.ArgumentException: Value cannot be lower than -273.15
    //    at Temperature.set_Celsius(Double value) in /home/findus/design-patterns-practice/PillarsOfOOP/Encapsulation/Temperature.cs:line 11
    //    at Program.<Main>$(String[] args) in /home/findus/design-patterns-practice/PillarsOfOOP/Encapsulation/Program.cs:line 12
}
catch (ArgumentException e)
{
    Console.WriteLine(e.Message);
    // output when handled:
    // Value cannot be lower than -273.15
}

var tempFarenheit = Temperature.FromFahrenheit(212.0);

Console.WriteLine(tempFarenheit.Celsius);
Console.WriteLine(tempFarenheit.Kelvin);
Console.WriteLine(tempFarenheit.Fahrenheit);