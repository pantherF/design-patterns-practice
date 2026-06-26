class PayPalProcessor : PaymentProcessor
{
    public override void Process(decimal amount)
    {
        Console.WriteLine($"Transfering {amount} dollars.");
        Console.WriteLine("Processing done by PayPal.");
    }
}