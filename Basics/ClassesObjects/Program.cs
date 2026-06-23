// Challenge 1 — Classes & Objects
// Topic: Fields, methods, instances
// ---

var account = new BankAccount("John", "234h45", 2002393.00);
var account2 = new BankAccount("maria", "267h45", 7802393.00);

Console.WriteLine(account.GetSummary());
account.Deposit(23.1);
account.Withdraw(500.0);

Console.WriteLine(account2.GetSummary());
account2.Deposit(26.0);
try
{
    account2.Withdraw(50000000000.0);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine(account.ToString());