using System;

namespace ENSE707_Week1_Lab;

public class BankAccount
{
	//Visual Studio was throwing a fit over these 
	//public string AccountHolder = { get, set };
	//public decimal Balance = { get, private set};

	public string AccountHolder;
	public decimal Balance;

	public BankAccount(string accountholder, decimal openingBalance)
	{
		if (string.IsNullOrWhiteSpace(accountholder) || openingBalance < 0)
		{
			throw new ArgumentException("Account Holder field must be provided and opening balance must be >= 0");
		}

		AccountHolder = accountholder;
		Balance = openingBalance;
	}

	//Deposit Funds into account, returns nothing, takes decimal input
	public void Deposit(decimal amount)
	{
		if (amount > 0)
		{
			Balance += amount;
			return;
		}
		throw new ArgumentException("Deposit amount must be more than 0");
	}
	//Withdraw funds, returns true, takes decimal input. No Validation
	public bool Withdraw(decimal amount)
	{
		if (Balance >= amount) {
			Balance -= amount;
			return true;
		}
		throw new ArgumentException("You cannot withdraw more than your balance!");
	}

	//Calculates the transaction fee for the provided amount
	public decimal CalculateTransactionFee(decimal amount)
	{
        if (amount > 0)
        {
	        return amount * 0.02m; // Hardcoded...        
        }
		throw new ArgumentException("Input must be positive!");
	}
}
