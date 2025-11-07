string[] orderIDs = new string[]
{
    "B123",
    "C234",
    "A345",
    "C15",
    "B177",
    "G3003",
    "C235",
    "B179"
};

string[] fraudulentOrderIDs = new string[orderIDs.Length];
int idx = 0;
foreach (string orderID in orderIDs)
{
    if (orderID.StartsWith("B"))
    {
        fraudulentOrderIDs[idx] = orderID;
        Console.WriteLine($"Order ID {orderID} is potentially fraudulent.");
    }
    idx++;
}

Console.WriteLine($"The following orders are potentially fraudulent: {string.Join(", ", fraudulentOrderIDs)}");


