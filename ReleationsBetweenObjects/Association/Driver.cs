class Driver(string name, Car? car = null)
{
    public string Name { get; set; } = name;
    public Car? Car { get; set; } = car;

    public void StartJourney(Car? otherCar = null)
    {
        if (otherCar != null)
        {
            Console.WriteLine($"Going somewhere with a {otherCar.Model}.");
            return;
        }

        if (Car == null)
        {
            Console.WriteLine("Not going anywhere, I have no car.");
            return;
        }

        Console.WriteLine($"Going somewhere with my {Car?.Model}.");
    }
}