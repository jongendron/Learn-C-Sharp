// https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/oop

namespace Classes;

public class LineOfCreditAccount : BankAccount
{
    // creditLimit is positive (magnitude) but _minimum balance is negative this value
    public LineOfCreditAccount(string name, decimal initialBalance, decimal creditLimit) : base(name, initialBalance, -creditLimit) { }

    public override void PerformMonthEndTransactions()
    {
        if (Balance < 0)
        {
            // Negate the balance to get a positive interest charge:
            decimal interest = -Balance * 0.07m;
            MakeWithdrawal(interest, DateTime.Now, "Charge monthly interest"); // TODO: Update so that monthly interested withdrawal doesn't cause another overdraft fee (if you want)
        }
    }

    // protected override Transaction? CheckWithdrawalLimit(bool isOverdrawn) =>
    //     isOverdrawn
    //         ? new Transaction(-20, DateTime.Now, "Apply overdraft fee")
    //         : default;
    protected override Transaction? CheckWithdrawalLimit(bool isOverdrawn)
    {
        if (isOverdrawn)
        {
            // Apply a $20 overdraft fee
            return new Transaction(-20, DateTime.Now, "Apply overdraft fee");
        }
        else
        {
            // No overdraft, so no fee transaction to add
            return default;
        }
    }
}