Console.WriteLine("pick a number between 0 and 36");
    Console.ReadLine();



Random rand = new Random();
int roulette = rand.Next(0, 36);
int guess = Convert.ToInt32(Console.ReadLine());