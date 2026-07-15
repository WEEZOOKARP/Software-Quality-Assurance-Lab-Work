
using ENSE707_Week1_Lab;

BankAccount account = new BankAccount("dingus", 10);
account.Deposit(50);
account.Withdraw(30);

Console.WriteLine($"Account Holder : {account.AccountHolder}");
Console.WriteLine($"Current Balance: ${account.Balance}");
Console.WriteLine($"Fee on $100 Transaction: ${account.CalculateTransactionFee(100)}");