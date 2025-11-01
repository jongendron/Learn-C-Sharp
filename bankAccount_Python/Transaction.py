from datetime import datetime

class Transaction():

    def __init__(self, Amount: float, Date: datetime, Notes: str):
        self.Amount = Amount
        self.Date = Date
        self.Notes = Notes