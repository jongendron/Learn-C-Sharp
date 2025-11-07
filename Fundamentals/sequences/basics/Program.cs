string[] fraudulentOrderIDs = new string[3];

Console.Write($"Enter Fraudulent Order IDs ...");
for (int i = 0; i < fraudulentOrderIDs.Length; i++)
{
    Console.Write($"\n{i}: ");
    fraudulentOrderIDs[i] = Console.ReadLine();
}

for (int i = 0; i < fraudulentOrderIDs.Length; i++)
{
    Console.WriteLine($"Fraudulent Order ID {i}: {fraudulentOrderIDs[i]}");
}

// fraudulentOrderIDs[3] = "abc123"; // This line will cause an IndexOutOfRangeException
fraudulentOrderIDs[1] = "ReplacedID";
Console.WriteLine($"Array of Fraudulent IDs: {string.Join(", ", fraudulentOrderIDs)}");

// New Array declaration and Initialization
string[] fraudulentOrderIDs2 = new string[] {"A123", "B456", "C789"}; // array initializer
Console.WriteLine($"Array 2 of Fraudulent IDs: {string.Join(", ", fraudulentOrderIDs2)}"); 
string[] fraudulentOrderIDs3 = ["X111", "Y222", "Z33"]; // collection expression
Console.WriteLine($"Array 3 of Fraudulent IDs: {string.Join(", ", fraudulentOrderIDs2)}");

// Report Length Property
Console.WriteLine($"Length of fraudulentOrderIDs3: {fraudulentOrderIDs3.Length}");
