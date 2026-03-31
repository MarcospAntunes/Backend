using System.Configuration;
using System.Data;
using System.Windows;

namespace SloppyJoeMenu
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application
  {
  }

  class MenuItem
  {
    public static Random Randomizer = new Random();
    public string[] Proteins = { "Roast beef", "Salami", "Turkey", "Ham", "Pastrami", "Tofu"};
    public string[] Condiments = { "yellow mustard", "brown mustard", "honey mustard", "mayo", "relish", "french dressing" };
    public string[] Breads = { "rye", "white", "wheat", "pumpernickel", "a roll" };

    public string Description = "";
    public string Price;

    public void Generate()
    {
      string randomProtein = Proteins[Randomizer.Next(Proteins.Length)];
      string randomCondiment = Condiments[Randomizer.Next(Condiments.Length)];
      string randomBread = Breads[Randomizer.Next(Breads.Length)];

      Description = randomProtein + " with " + randomCondiment + " on " + randomBread;

      decimal Bucks = Randomizer.Next(2, 5);
      decimal cents = Randomizer.Next(1, 98);
      decimal price = Bucks + (cents * .01M);
      Price = price.ToString("c");
    }
  }

}
