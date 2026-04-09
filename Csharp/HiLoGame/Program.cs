class Program
{
  public static void Main(string[] args)
  {
    Console.WriteLine("Welcome to HiLo.");
    Console.WriteLine($"Guess numbers between 1 and {HiLoGame.MAXIMUM}.");
    HiLoGame.Hint();
    
    while(HiLoGame.GetPot() > 0)
    {
      Console.WriteLine("Press h for higher, 1 for lower, ? to buy a hint,");
      Console.WriteLine($"or any other key to quit with {HiLoGame.GetPot()}.");
      char key = Console.ReadKey(true).KeyChar;
      if (key == 'h') HiLoGame.Guess(true);
      else if (key == '1') HiLoGame.Guess(false);
      else if (key == '?') HiLoGame.Hint();
      else return;
    }
    Console.WriteLine("The pot is empty. Bye!");
  }
}

static class HiLoGame
{
  public const int MAXIMUM = 10;
  private static Random random = new Random();
  private static int currentNumber = random.Next(1, MAXIMUM + 1);
  private static int pot = 10;

  public static void Guess(bool higher)
  {
    int nextNumber = random.Next(1, MAXIMUM + 1);

    if((higher && nextNumber >= currentNumber) || (!higher && nextNumber <= currentNumber))
    {
      Console.WriteLine("You guessed right!");
      pot++;
    } else
    {
      Console.WriteLine("Bad luck, you guessed wrong.");
      pot--;
    }
    currentNumber = nextNumber;
    Console.WriteLine($"The current number is {currentNumber}.");
  }

  public static void Hint()
  {
    int half = (MAXIMUM / 2);
    if(currentNumber >= half)
    {
      Console.WriteLine($"The number is at least {half}.");
    } else
    {
      Console.WriteLine($"The number is at most {half}.");
    }

      pot--;
  }

  public static int GetPot()
  {
    return pot;
  }

}