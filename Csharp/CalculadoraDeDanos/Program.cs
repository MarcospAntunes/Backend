using System;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;


Random random = new Random();
SwordDamage swordDamage = new SwordDamage(RollDice(3));
ArrowDamage arrowDamage = new ArrowDamage(RollDice(1));

while(true)
{
  Console.Write("0 for no magic/flaming, 1 for magic, 2 for flaming, 3 for both, anything else to quit: ");
  char key = Console.ReadKey().KeyChar;
  if (key != '0' && key != '1' && key != '2' && key != '3') return;

  Console.Write("\nS for sword, A for arrow, anything else to quit: ");
  char weaponKey = Char.ToUpper(Console.ReadKey().KeyChar);

  switch(weaponKey)
  {
    case 'S':
      swordDamage.Roll = RollDice(3);
      swordDamage.Magic = (key == '1' || key == '3');
      swordDamage.Flaming = (key == '2' || key == '3');
      Console.WriteLine($"\nRolled {swordDamage.Roll} for {swordDamage.Damage} HP\n");
      break;
    case 'A':
      arrowDamage.Roll = RollDice(3);
      arrowDamage.Magic = (key == '1' || key == '3');
      arrowDamage.Flaming = (key == '2' || key == '3');
      Console.WriteLine($"\nRolled {arrowDamage.Roll} for {arrowDamage.Damage} HP\n");
      break;
    default:
      return;
  }
}

int RollDice(int numberOfRolls)
{
  int total = 0;
  for (int i = 0; i < numberOfRolls; i++) total += random.Next(1,7);
  return total;
}

class ArrowDamage
{
  private const decimal BASE_MULTIPLIER = .35M;
  private const decimal FLAME_DAMAGE = 1.25M;
  private const decimal MAGIC_MULTIPLIER = 2.5M;
  private int roll;
  public int Roll
  {
    get { return roll; }
    set
    {
      roll = value;
      CalculateDamage();
    }
  }
  private bool flaming;
  public bool Flaming
  {
    get { return flaming; }
    set
    {
      flaming = value;
      CalculateDamage();
    }
  }

  private bool magic;
  public bool Magic
  {
    get { return magic; }
    set
    {
      magic = value;
      CalculateDamage();
    }
  }
  public decimal Damage { get; private set; }

  public ArrowDamage(int dado)
  {
    roll = dado;
    CalculateDamage();
  }

  private void CalculateDamage()
  {
    decimal baseDamage = Roll * BASE_MULTIPLIER;
    if (Magic) baseDamage *= MAGIC_MULTIPLIER;
    if (Flaming) Damage = (int)Math.Ceiling(baseDamage + FLAME_DAMAGE);
    else Damage = (int)Math.Ceiling(baseDamage);
  }
}

class SwordDamage
{
  private const int BASE_DAMAGE = 3;
  private const int FLAME_DAMAGE = 2;
  private int roll;
  public int Roll
  {
    get { return roll; }
    set
    {
      roll = value;
      CalculateDamage();
    }
  }
  private bool flaming;
  public bool Flaming
  {
    get { return flaming; }
    set
    {
      flaming = value;
      CalculateDamage();
    }
  }

  private bool magic;
  public bool Magic
  {
    get { return magic; }
    set
    {
      magic = value;
      CalculateDamage();
    }
  }
  public int Damage { get; private set; }

  public SwordDamage(int dado)
  {
    roll = dado;
    CalculateDamage();
  }

  private void CalculateDamage()
  {

    decimal magicMultiplier = 1M;
    if (Magic) magicMultiplier = 1.75M;

    Damage = BASE_DAMAGE;
    Damage = (int)(Roll * magicMultiplier) + BASE_DAMAGE;

    if (Flaming) Damage += FLAME_DAMAGE;
  }
}