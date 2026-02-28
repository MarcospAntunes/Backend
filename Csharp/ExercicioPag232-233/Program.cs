class Program
{
  static void Main(string[] args)
  {
    Elephant lloyd = new Elephant("Lloyd", 40);
    Elephant lucinda = new Elephant("Lucinda", 33);

    while(true)
    {
      Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap or any key to exit.");
      char keyPressed = Console.ReadKey(true).KeyChar;
      if (keyPressed == '1')
      {
        Console.WriteLine("You pressed 1");
        Console.WriteLine("Calling lloyd.WoAmI()");
        lloyd.WhoAmI();
      }
      else if (keyPressed == '2')
      {
        Console.WriteLine("You pressed 2");
        Console.WriteLine("Calling lucinda.WoAmI()");
        lucinda.WhoAmI();
      }
      else if (keyPressed == '3')
      {
        Console.WriteLine("You pressed 3");

        Elephant temp = lucinda;
        lucinda = lloyd;
        lloyd = temp;

        Console.WriteLine("References have been swapped");
      }
      else
      {
        return;
      }
    }

    
  }

  class Elephant
  {
    private string Name;
    private int EarSize;

    public Elephant(string Name, int EarSize)
    {
      this.Name = Name;
      this.EarSize = EarSize;
    }

    public void WhoAmI()
    {
      Console.WriteLine("My name is " + this.Name);
      Console.WriteLine("My ears are " + this.EarSize + " inches tall");
    }

    public string getName()
    {
      return this.Name;
    }

    public int getEarSize()
    {
      return this.EarSize;
    }

    public void setName(string Name)
    {
      this.Name = Name;
    }

    public void setEarSize(int EarSize)
    {
      this.EarSize = EarSize;
    }
  }
}