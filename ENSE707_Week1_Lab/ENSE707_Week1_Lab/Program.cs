class Core
{
    BankAccount account;
    int accounts = 0;
    public void Main(String[] args)
    {
        Console.WriteLine("Banking System ---");
        interactionScreen();
    }

    void interactionScreen()
    {
        String[] items = {"1 - Create account", "2 - Deposit", "3 - Withdraw"};

        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    
        String userInput = Console.ReadLine();

        switch (userInput)
        {
            case "1":
                accounts++;
                account = new BankAccount(accounts);
                break;
            case "2":
                Console.WriteLine("How much would you like to deposit?");
                float value;
                try
                {
                    value = Convert.ToSingle(Console.ReadLine());
                    account.deposit(value);
                }
                catch (Exception e)
                {
                    Console.WriteLine("An error has occured.");
                    Console.WriteLine(e.Message);
                }
                break;
        };
    }
}