
public class BankAccount
{
    private string _accountHolder = string.Empty;
    private double _balance;

    public string AccountHolder
    {
        get { return _accountHolder; }
        set
        {
            if (value != null)
            {
                _accountHolder = value;
            }
        }
    }

    public double Balance
    {
        get { return _balance; }
        set
        {
            if (value > 0)
            {
                _balance = value;
            }
        }
    }

    public void Deposit(double amount)
    {
        _balance += amount;
        Console.WriteLine("Deposit Successfull");
    }

    public void Withdraw(double amount)
    {
        if (amount <= _balance)
        {
            _balance -= amount;
            Console.WriteLine("Withdraw Successfull");
        }
    }
}

