using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SloppyJoeMenu;

namespace SloppyJoeMenu
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
      MakeTheMenu();
    }

    private void MakeTheMenu()
    {
      MenuItem[] menuItens = new MenuItem[5];
      string guacamolePrice;

      for (int i = 0; i < 5; i++)
      {
        menuItens[i] = new MenuItem();
        if( i>= 3)
        {
          menuItens[i].Breads = new string[]
          {
            "plain bagel", "onion bagel", "pumpernickel bagel", "everything bagel"
          };
        }
        menuItens[i].Generate();
      }
      item1.Text = menuItens[0].Description;
      price1.Text = menuItens[0].Price;
      item2.Text = menuItens[1].Description;
      price2.Text = menuItens[1].Price;
      item3.Text = menuItens[2].Description;
      price3.Text = menuItens[2].Price;
      item4.Text = menuItens[3].Description;
      price4.Text = menuItens[3].Price;
      item5.Text = menuItens[4].Description;
      price5.Text = menuItens[4].Price;

      MenuItem specialMenuItem = new MenuItem()
      {
        Proteins = new string[] { "Organic ham", "Mushroom patty", "Mortadella" },
        Breads = new string[] { "a glutten free rool", "a wrap", "pita" },
        Condiments = new string[] { "dijon mustard", "miso dressing", "aujus" }
      };
      specialMenuItem.Generate();

      item6.Text = specialMenuItem.Description;
      price6.Text = specialMenuItem.Price;

      MenuItem guacamoleMenuItem = new MenuItem();
      guacamoleMenuItem.Generate();
      guacamolePrice = guacamoleMenuItem.Price;
      guacamole.Text = "Add guacamole for " + guacamolePrice; 
    }
  }
}