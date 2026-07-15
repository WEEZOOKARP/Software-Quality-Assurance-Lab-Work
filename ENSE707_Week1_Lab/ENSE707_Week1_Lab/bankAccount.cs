using System;

public class BankAccount
{
	private float balance;
    public int accountID;
	public BankAccount(int accountIdentifier)
	{
		balance = 0;
		accountID = accountIdentifier;
	}

	public float getBalance()
	{
        return this.getBalanceImpl();
	}

	private float getBalanceImpl()
	{
		return this.balance;
	}

    public void deposit(float value)
    {
        if (value <= 0)
            throw new ArgumentException("You cannot deposit values less than or equal to 0");
        
        this.depositImpl(value);
    }
    private void depositImpl(float value)
    {
        this.balance += value;
    }

    public void withdraw(float value)
    {
        if (value <= 0)
            throw new ArgumentException("You cannot withdraw values less than or equal to 0");

        this.withdrawImpl(value);
    }
    private void withdrawImpl(float value)
    {
        this.balance -= value;
    }
}
