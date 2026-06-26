class CryptoProcessor : PaymentProcessor
{
    public override void Process(decimal amount)
    {
        decimal btc = amount * 0.000016684185060980698m;
        Console.WriteLine($"Transfering {btc} BTC in progress...");
    }
}