using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickACardUI
{
  /// <summary>
  /// Escola um número de cartas e retorne-as
  /// </summary>
  internal class CardPicker
  {

    static Random random = new Random();
    /// <summary>
    /// Escolha um número de cartas e retorne-as
    /// </summary>
    /// <param name="numberOfCards">O número de cartas para pegar.</param>
    /// <returns>Um array de strings que contém os nomes das cartas.</returns>
    public static string[] PickSomeCards(int numberOfCards)
    {
      string[] pickedCards = new String[numberOfCards];
      for (int i = 0; i < numberOfCards; i++)
      {
        pickedCards[i] = RandomValue() + " of " + RandomSuit();
      }
      return pickedCards;
    }

    private static string RandomSuit()
    {
      int value = random.Next(1, 5);
      if (value == 1) return "Spades"; //Caso value seja 1, retorna Spades
      if (value == 2) return "Hearts"; //Caso value seja 2, retorna Hearts
      if (value == 3) return "Clubs"; //Caso value seja 3, retorna Clubs

      return "Diamonds"; //Caso nenhuma condição tenha sido satisfeita, retorna Diamonds
    }

    private static string RandomValue()
    {
      int value = random.Next(1, 14);
      if (value == 1) return "Ace"; //Se o valor for 1, retorna Ace
      if (value == 11) return "Jack"; //Se o valor for 11, retorna Jack
      if (value == 12) return "Queen"; //Se o valor for 12, retorna Queen
      if (value == 13) return "King"; //Se o valor for 13, retorna King
      return value.ToString(); //Caso nenhuma condição tenha sido satisfeita, retorna o valor de value mas em string
    }
  }
}
