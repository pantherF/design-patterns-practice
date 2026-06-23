class Dog : Animal
{
    public required string Breed { get; set; }

    public override string Speak()
    {
        return "Woof!";
    }
}