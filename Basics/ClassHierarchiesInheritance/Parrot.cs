class Parrot : Animal
{
    public string? Color { get; set; }
    public override string Speak()
    {
        return "Squeak!";
    }
}