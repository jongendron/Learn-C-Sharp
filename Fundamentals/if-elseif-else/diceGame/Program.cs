Random dice = new Random();

int roll1 = 0;
int roll2 = 0;
int roll3 = 0;
int total = 0;

string userOption = "";
string gameResult = "";

while (true)
{

    Console.WriteLine("Enter your choice ...\n\t1. Roll the dice.\n\t2. Exit.");
    userOption = Console.ReadLine();

    if (userOption == "2")
    {
        break;
    }
    else if (userOption == "1")
    {
        roll1 = dice.Next(1, 7);
        roll2 = dice.Next(1, 7);
        roll3 = dice.Next(1, 7);
        
        total = roll1 + roll2 + roll3;

        Console.WriteLine($"Base roll: {roll1} + {roll2} + {roll3} = {total}");

        if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
            if ((roll1 == roll2) && (roll2 == roll3))
            {
                Console.WriteLine("You rolled triples! +6 bounus to total!");
                total += 6;
            }
            else
            {
                Console.WriteLine("You rolled doubles! +2 bonus to total!");
                total += 2;
            }


        if (total >= 16)
        {
            gameResult = "You win a new car!\n\n";
        }
        else if (total >= 10)
        {
            gameResult = "You win a new laptop!\n\n";
        }
        else if (total == 7)
        {
            gameResult = "You win a trip for two!\n\n";
        }
        else
        {
            gameResult = "You win a kitten!\n\n";
        }

        Console.WriteLine(gameResult);
    }
    else
    {
        Console.WriteLine("Invalid option. Please try again.\n");
    }
        
};
