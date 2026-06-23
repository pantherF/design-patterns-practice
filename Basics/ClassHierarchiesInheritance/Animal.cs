class Animal
{
    public required string Name { get; set; }
    public required uint Age { get; set; }

    public virtual string Speak()
    {
        return "...";
    }
}