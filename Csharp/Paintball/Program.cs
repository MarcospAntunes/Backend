
class Program
{
  static void Main(string[] args)
  {
    int numberOfBalls = ReadInt(20, "Number of balls");
    int magazineSize = ReadInt(16, "Magazine size");

    Console.WriteLine($"Loaded [false]: ");
    bool.TryParse(Console.ReadLine(), out bool isLoaded);

    PaintballGun gun = new PaintballGun(numberOfBalls, magazineSize, isLoaded);

    while(true)
    {
      Console.WriteLine($"{gun.Balls} balls, {gun.BallsLoaded} loaded");
      if (gun.isEmpty()) Console.WriteLine("WARNING: You're out of ammo");
      Console.WriteLine("Space to shoot, r to reload, + to add ammo, q to quit");
      char key = Console.ReadKey(true).KeyChar;

      if (key == ' ') Console.WriteLine($"Shooting returned {gun.Shoot()}");
      else if (key == 'r') gun.Reload();
      else if (key == '+') gun.Balls += gun.MagazineSize;
      else if (key == 'q') return;
    }
  }

  static int ReadInt(int lastUsedValue, string prompt)
  {
    string menssage = prompt + " [" + lastUsedValue + "]";
    Console.WriteLine(menssage);

    string newValue = Console.ReadLine();

    if (int.TryParse(newValue, out int value))
    {
      Console.WriteLine("using value " + value);
      return value;
    }
    else
    {
      Console.WriteLine("usign default value " + lastUsedValue);
      return lastUsedValue;
    }
  }
}


class PaintballGun
{
  public int MagazineSize { get; private set; } = 16;
  private int balls = 0;
  public int BallsLoaded { get; private set; }
  public bool isEmpty() { return BallsLoaded == 0; }
  public int Balls
  {
    get { return balls; }
    set
    {
      if (value > 0) balls = value;
      Reload();
    }
  }

  public PaintballGun(int balls, int magazineSize, bool loaded)
  {
    this.balls = balls;
    MagazineSize = magazineSize;
    if (!loaded) Reload();
  }
  
  public void Reload()
  {
    if (balls > MagazineSize) BallsLoaded = MagazineSize;
    else BallsLoaded = balls;
  }

  public bool Shoot()
  {
    if (BallsLoaded == 0) return false;
    BallsLoaded--;
    balls--;
    return true;
  }
}