internal class Program
{
  private static void Main(string[] args)
  {
    Guy guyJoe = new Guy(name: "Joe", cash: 50);
    Guy guyBob = new Guy(name: "Bob", cash: 100);

    while (true)
    {
      guyJoe.WriteMyInfo();
      guyBob.WriteMyInfo();
      Console.WriteLine("Enter an amount: ");
      string howMuch = Console.ReadLine();

      if (howMuch == "") return;

      int amount;

      if (int.TryParse(howMuch, out amount))
      {
        Console.Write("Who should give the cash: ");
        string whichGuy = Console.ReadLine();

        if (whichGuy == "Joe")
        {
          guyJoe.GiveCash(amount);
          guyBob.ReceiveCash(amount);
        }
        else if (whichGuy == "Bob")
        {
          guyBob.GiveCash(amount);
          guyJoe.ReceiveCash(amount);
        }
        else
        {
          Console.WriteLine("Please, enter 'Joe' or 'Bob'");
        }
      }
      else
      {
        Console.WriteLine("Please, enter an amount (or blank line to exit).");
      }
    }
  }

  public class Guy
  {
    public string Name;
    public decimal Cash;

    public Guy(string name, decimal cash) {
      this.Name = name;
      this.Cash = cash;

      return;
    }

    public void WriteMyInfo()
    {
      Console.WriteLine(Name + " has " + Cash + " bucks.");
    }

    public decimal GiveCash(decimal amount)
    {
      if(amount <= 0)
      {
        Console.WriteLine(Name + " says: " + amount + " isn't a valid amount");
        return 0;
      }
      if(amount > Cash)
      {
        Console.WriteLine(Name + " says: " + "I don't have enough cash to give you " + amount);
        return 0;
      }

      Cash -= amount;
      return amount;
    }

    public void ReceiveCash(int amount)
    {
      if(amount <= 0)
      {
        Console.WriteLine(Name + " says " + amount + " ins't an amount I'll take");

      } else
      {
        Cash += amount;
      }
    }
  }
}