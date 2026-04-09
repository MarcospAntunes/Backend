class Program
{
  static readonly Random Random = new Random();
  public static void Main(String[] args)
  {
    SwordDamage swordDamage = new SwordDamage();
    

    while (true) 
    {
      Console.WriteLine("0 for no magic/flaming, 1 for magic, 2 for flaming, 3 for both, anything else to quit: ");
      String? keyPressed = Console.ReadLine();
      swordDamage.Roll = Random.Next(3, 18);

      if (keyPressed == "0")
      {
        swordDamage.SetFlaming(false);
        swordDamage.SetMagic(false);

      } else if(keyPressed == "1")
      {
        swordDamage.SetFlaming(false);
        swordDamage.SetMagic(true);

      } else if(keyPressed == "2")
      {
        swordDamage.SetFlaming(true);
        swordDamage.SetMagic(false);

      } else if (keyPressed == "3")
      {
        swordDamage.SetFlaming(true);
        swordDamage.SetMagic(true);

      } else
      {
        break;
      }
      Console.WriteLine($"Rolled {swordDamage.Roll} for {swordDamage.Damage} HP");
    }
  }
}

class SwordDamage
{
  public const int BASE_DAMAGE = 3;
  public const int FLAME_DAMAGE = 2;

  public int Roll;
  public decimal MagicMultiplier = 1M;
  public int FlamingDamage = 0;
  public int Damage;

  public void CalculateDamage()
  {
    Damage = (int)(Roll * MagicMultiplier) + BASE_DAMAGE + FlamingDamage;
  }

  public void SetMagic(bool isMagic)
  {
    if (isMagic) MagicMultiplier = 1.75M;
    else MagicMultiplier = 1M;

    CalculateDamage();
  }

  public void SetFlaming(bool isFlaming)
  {
    CalculateDamage();

    if (isFlaming) Damage += FLAME_DAMAGE;
  }
}