using System.Media;
Random randomNumber = new Random();
int computerRandomNumber = randomNumber.Next(1, 101);
int choisses = 0;
while (true)
{
    Console.Write("Choose a number (1-100): ");
    string playerInput = Console.ReadLine();
    bool isValid = int.TryParse(playerInput, out int playerNumber);

    if (isValid)
    {
        if (playerNumber < computerRandomNumber)
        {
            Console.WriteLine("Your number is too low!");
            choisses++;
        }
        else if (playerNumber > computerRandomNumber)
        {
            Console.WriteLine("Your number is too high!");
            choisses++;
        }
        else
        {
            Console.WriteLine($"You guess the number, after {choisses} choisses!");
            SoundPlayer win = new SoundPlayer("Win.wav");
            win.PlaySync();
            break;
        }
        if (playerNumber > 100)
        {
            Console.WriteLine("Don't be stupid! Enter number between 1 and 100!");
            SoundPlayer stupid = new SoundPlayer("Stupid.wav");
            stupid.PlaySync();
        }
    }
    else
    {
        Console.WriteLine("Invalid input! Try again!");
        continue;
    }
}


