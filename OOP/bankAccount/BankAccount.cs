namespace Classes;

public class BankAccount
{
    private static int s_accountNumberSeed = 1234567890; // static shared between instances
    public string Number { get; }
    public string Owner { get; set; }
    public decimal Balance // no setter, so initial value only set during construction
    {
        get
        {
            decimal balance = 0;
            foreach (var item in _allTransactions)
            {
                balance += item.Amount;
            }
            return balance;
        }
    }
    private List<Transaction> _allTransactions = new List<Transaction>();
    private readonly decimal _minimumBalance;

    public BankAccount(string name, decimal initialBalance) : this(name, initialBalance, 0) { }
    public BankAccount(string name, decimal initialBalance, decimal minimumBalance)
    {
        
        this.Number = s_accountNumberSeed.ToString();
        s_accountNumberSeed++; // +1 to static member of class; next obj will be init w/ change
        //this.Balance = initialBalance;
        this.Owner = name;
        _minimumBalance = minimumBalance;
        if (initialBalance > 0)
        {
            MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
        }       
        
    }
    public void MakeDeposit(decimal amount, DateTime date, string note)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
        }
        var deposit = new Transaction(amount, date, note);
        _allTransactions.Add(deposit);
    }

    // public void MakeWithdrawal(decimal amount, DateTime date, string note)
    // {
    //     if (amount <= 0)
    //     {
    //         throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
    //     }
    //     if (this.Balance - amount < this._minimumBalance)
    //     {
    //         throw new InvalidOperationException("Insufficient funds for this withdrawal");
    //     }
    //     var withdrawal = new Transaction(-amount, date, note);
    //     _allTransactions.Add(withdrawal);
    // }

    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(amount);
        Transaction? overdraftTransaction = CheckWithdrawalLimit(Balance - amount < _minimumBalance);
        Transaction? withdrawal = new Transaction(-amount, date, note);
        _allTransactions.Add(withdrawal);
        if (overdraftTransaction != null)
        {
            _allTransactions.Add(overdraftTransaction);
        }
    }

    protected virtual Transaction? CheckWithdrawalLimit(bool isOverdrawn)
    {
        if (isOverdrawn)
        {
            throw new InvalidOperationException("Not sufficient funds for this withdrawal");
        }
        else
        {
            return default;
        }
    }

    public string GetAccountHistory()
    {
        var report = new System.Text.StringBuilder();

        decimal balance = 0;
        report.AppendLine("Date\t\tAmount\tBalance\tNote");
        foreach (var item in _allTransactions)
        {
            balance += item.Amount;
            report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
        }

        return report.ToString();
    }

    public virtual void PerformMonthEndTransactions() { }

}