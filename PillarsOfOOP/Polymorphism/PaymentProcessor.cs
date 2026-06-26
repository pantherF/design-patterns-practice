class PaymentProcessor
{
    public virtual void Process(decimal amount)
    {
        Console.WriteLine($"Amount payed: {amount} USD");
        Console.WriteLine("Processing payment...");
    }
}