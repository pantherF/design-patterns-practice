class BankAccount
{
    string Owner { get; set; }
    string AccountNumber { get; set; }
    double Balance { get; set; }
    static uint TotalAccounts = 0;

    public BankAccount(string owner, string accountNumber, double balance)
    {
        Owner = owner;
        AccountNumber = accountNumber;
        Balance = balance;
        TotalAccounts++;
    }

    public void Deposit(double amount)
    {
        Balance += amount;

        Console.WriteLine($"Amount: {amount} deposited.");
        Console.WriteLine($"New account balance: {Balance}.");
    }

    public void Withdraw(double amount)
    {
        var withdrawn = Balance - amount;
        if (withdrawn < 0)
        {
            throw new Exception("Not enough money to withdraw");
        }
        else
        {
            Balance -= amount;

            Console.WriteLine($"Amount: {amount} withdrawn.");
            Console.WriteLine($"New account balance: {Balance}.");
        }
    }

    public string GetSummary()
    {
        return $"Owner: {Owner}\nAccount Number: {AccountNumber}\nBalance: {Balance:C}";
    }

    public override string ToString()
    {
        return $"Nr. of accounts: {TotalAccounts}";
    }
}