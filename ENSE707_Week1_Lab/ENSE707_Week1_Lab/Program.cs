using Microsoft.VisualBasic;

class Core
{
    BankAccount account;
    int accounts = 0;
    public static void Main(String[] args)
    {
        Core core = new Core();
        core.interactionScreen();
    }

    float getLocalBalance()
    {
        if (account)
        {
            return account.getBalance();
        }
        return 0.0f;
    }
    void interactionScreen()
    {
        Console.WriteLine();
        Console.WriteLine("Banking System --- BALANCE : $" + getLocalBalance());
        String[] items = {"1 - Create account", "2 - Deposit", "3 - Withdraw", "4 - Admin"};

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
                Console.WriteLine("Account created, ID : " + accounts);
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
        interactionScreen();
    }
}