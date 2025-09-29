Random rand = new Random();

Console.WriteLine("Do you want to bet on color or number? ");
string val = Console.ReadLine();


if (val == "number")
{
    while (true)
    {

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("pick a number between 0 and 36");

        int roulette = rand.Next(0, 37);

        int guess = Convert.ToInt32(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(roulette);

        if (guess == roulette)
        {
            Console.WriteLine("u won");
        }
        else
        {
            Console.WriteLine("U lost");
        }

        Console.WriteLine("Want to play again?");

        string answer = Console.ReadLine().ToLower();

        if (answer != "yes" && answer != "y")
        {
            break;
        }
        Console.Clear();
    }
}
if (val == "color") ;
{
    Console.WriteLine("Choose a number between 1 or 2 (red for 1 and 2 for black): ");
    int guess = Convert.ToInt32(Console.ReadLine());
    int wow = rand.Next(1, 3);

    if (guess == wow)
    {
        Console.WriteLine("You win! ");
    }
    else
    {
        Console.WriteLine("You lose!");
    }
}