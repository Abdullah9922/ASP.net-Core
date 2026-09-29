public class Mainn
{
    public static void Main(string[] args)
    {
        BankAccount a = new BankAccount();

        a.Balance = 5000;
        a.AccountHolder = "Arif";

        a.Deposit(5000);
        a.Withdraw(3000);

        Console.WriteLine(a.Balance);

    }
}
