class Customer
{
    public required string Name { get; set; }
    public string? Email { get; set; }
    public required string PhoneNumber { get; set; }
    public bool Newsletter{ get; set; } = false;

    public void PrintSummary()
    {
        Console.WriteLine("=== Pharmacy Customer Summary ===");
        Console.WriteLine($"Name:  {Name}");
        Console.WriteLine($"Phone: {PhoneNumber}");
        Console.WriteLine($"Email: {Email ?? "N/A"}");
        var subscriptionStatus = Newsletter ? "Subscribed" : "Unsubscribed";
        Console.WriteLine($"Newsletter: {subscriptionStatus}");
    }
}
