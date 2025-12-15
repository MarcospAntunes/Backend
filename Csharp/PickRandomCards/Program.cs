static void Main()
{
  Console.WriteLine("Enter the number of cards to pick: ");
  string line = Console.ReadLine();

  if (int.TryParse(line, out int numberOfCards))
  {
    string[] cards = PickRandomCards.CardPicker.PickSomeCards(numberOfCards);

    foreach (string card in cards)
    {
      Console.WriteLine(card);
    }
  }
  else
  {
    Console.WriteLine("Error: Make sure you are using a number and not another parameter.");
  }
}

Main();