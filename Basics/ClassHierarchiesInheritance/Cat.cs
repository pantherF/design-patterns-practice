class Cat : Animal
{
    public string? FurLength { get; set; }
    public override string Speak()
    {
        return "Meow!";
    }
}