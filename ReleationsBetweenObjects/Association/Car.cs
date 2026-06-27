class Car(string model)
{
    public string Model { get; set; } = model;
    public string? Owner { get; set; }

    public void Drive()
    {
        Console.WriteLine($"Driving along with the marvelous {Model}");
    }
}