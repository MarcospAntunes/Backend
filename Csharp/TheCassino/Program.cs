using TheCassino.objetos;

internal class Program
{
  private static void Main(string[] args)
  {
    Random random = new Random();
    decimal odds = 0.75M;
    Guy player = new Guy(name: "The Player", 100);

    Console.WriteLine("Welcome to the casino. The odds are " + odds);

    while(true)
    {
      player.WriteMyInfo();

      Console.WriteLine("How much do you want to bet: ");
      string howMuch = Console.ReadLine();
      if (howMuch == "") return;

      int amount;

      if (int.TryParse(howMuch, out amount))
      {
        int pot = amount * 2;
        decimal luckyNumber = (decimal)random.NextDouble();

        if (luckyNumber > odds)
        {
          player.ReceiveCash(pot);
          Console.WriteLine("You win " + pot);
        }
        else
        {
          player.GiveCash(amount);
          Console.WriteLine("Bad luck, you lose.");
          Console.WriteLine("The house always wins.");
        }

      }
    }
   
  }
}


  