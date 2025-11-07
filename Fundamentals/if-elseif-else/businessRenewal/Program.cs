Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;
string expirationWarning = "Your subscription";

// Your code goes here
if (daysUntilExpiration <= 10)
{
    if (daysUntilExpiration <= 5)
    {
        if (daysUntilExpiration <= 1)
        {
            if (daysUntilExpiration == 0)
            {
                expirationWarning += " has expired.";
            }
            else
            {
                discountPercentage = 20;
                expirationWarning += $" expires within a day!\nRenew now and save {discountPercentage}$!";
            }
        }
        else
        {
            discountPercentage = 10;
            expirationWarning += $" expires in {daysUntilExpiration} days.\nRenew now and save {discountPercentage}%!";
        }
    }
    else
    {
        expirationWarning += " will expire soon. Renew now!";
    }

    Console.WriteLine($"{daysUntilExpiration}");
    Console.WriteLine(expirationWarning);
}
