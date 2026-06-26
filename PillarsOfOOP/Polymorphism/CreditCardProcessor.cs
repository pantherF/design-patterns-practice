class CreditCardProcessor : PaymentProcessor
{
    public override void Process(decimal amount)
    {
        Console.WriteLine("Checking credit card...");
        Console.WriteLine("Validating payment amount...");
        Console.WriteLine("Processing payment...");
        Console.WriteLine($"Paying out your money of {amount} USD");
    }
}