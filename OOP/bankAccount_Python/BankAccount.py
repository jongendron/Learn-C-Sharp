from datetime import datetime
from Transaction import Transaction

class BankAccount():
    
    s_accountNumberSeed = 1234567890

    @property
    def Number(self) -> str:
        return self._number
    
    @Number.setter
    def Number(self, value: str) -> None:
        self._number = value
    
    @property
    def Owner(self) -> str:
        return self._owner
    
    @Owner.setter
    def Owner(self, value) -> None:
        self._owner = value 
    
    @property
    def Balance(self) -> float:
        balance = 0
        for transaction in self._allTransactions:
            balance += transaction.Amount
        return balance
    

    def __init__(self, name: str, initialBalance: float):
        self.Number = str(BankAccount.s_accountNumberSeed)
        BankAccount.s_accountNumberSeed += 1
        self.Owner = name
        self._allTransactions = []
        self.MakeDeposit(initialBalance, datetime.now(), "Initial balance")

    def MakeDeposit(self, amount: float, date: datetime, note: str):
        if amount <= 0:
            raise ValueError("Amount of deposit must be positive")
        
        deposit = Transaction(amount, date, note)
        self._allTransactions.append(deposit)

    def MakeWithdrawal(self, amount: float, date: datetime, note: str):
        if amount <= 0:
            raise ValueError("Amount of withdrawal must be positive")
        if self.Balance - amount < 0:
            raise ValueError("Insufficient funds for this withdrawal")
        
        withdrawal = Transaction(-amount, date, note)
        self._allTransactions.append(withdrawal)

    def GetAccountHistory(self) -> str:
        report = []
        balance = 0
        report.append("Date\t\tAmount\tBalance\tNote")
        for transaction in self._allTransactions:
            balance += transaction.Amount
            report.append(f"{transaction.Date.date()}\t{transaction.Amount}\t{balance}\t{transaction.Notes}")
        
        return "\n".join(report)

