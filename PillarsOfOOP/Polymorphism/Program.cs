// Exercise 7 — Polymorphism
// Topic: Runtime type detection, virtual dispatch

var payment = new PaymentProcessor();
var payPal = new PayPalProcessor();
var cryptoProcessor = new CryptoProcessor();
var creditCardProcessor = new CreditCardProcessor();

var processors = new List<PaymentProcessor>
{
    payment,
    payPal,
    cryptoProcessor,
    creditCardProcessor
};

RunPayments(processors, 60000);

static void RunPayments(List<PaymentProcessor> processors, decimal amount)
{
    foreach (var processor in processors)
    {
        amount += 3;
        Console.WriteLine("===");
        processor.Process(amount);
    }
}