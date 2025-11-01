from BankAccount import BankAccount
from datetime import datetime

account = BankAccount("<name>", 1000)
print(f"Account {account.Number} was created for {account.Owner} with ${account.Balance} initial balance.")

account.MakeWithdrawal(500, datetime.now(), "Rent payment")
print(account.Balance)

account.MakeDeposit(100, datetime.now(), "Friend paid me back")
print(account.Balance)

print()
print(account.GetAccountHistory())