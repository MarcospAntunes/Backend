using System;

namespace AbilityScoreCalculator
{
  class Program
  {
    static void Main(string[] args)
    {
      AbilityScoreCalculator calculator = new AbilityScoreCalculator();

      while (true)
      {
        calculator.RollResult = ReadInt(calculator.RollResult, "Starting 4d6 roll");
        calculator.DivideBy = ReadDouble(calculator.DivideBy, "Divide by");
        calculator.AddAmount = ReadInt(calculator.AddAmount, "Add amount");
        calculator.Minimum = ReadInt(calculator.Minimum, "Minimum");

        calculator.CalculateAbilityScore();

        Console.WriteLine("Calculated ability score: " + calculator.Score);

        Console.WriteLine("Press Q to quit, any other key to continue");
        char keyChar = Console.ReadKey(true).KeyChar;

        if ((keyChar == 'Q') || (keyChar == 'q')) return;
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

      static double ReadDouble(double lastUsedValue, string prompt)
      {
        string menssage = prompt + " [" + lastUsedValue + "]";
        Console.WriteLine(menssage);

        string newValue = Console.ReadLine();

        if (double.TryParse(newValue, out double value))
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
  }
  class AbilityScoreCalculator
  {
    public int RollResult = 14;
    public double DivideBy = 1.75;
    public int AddAmount = 2;
    public int Minimum = 3;
    public int Score;

    public void CalculateAbilityScore()
    {
      double divided = RollResult / DivideBy;
      int added = AddAmount + (int)divided;

      if (added < Minimum)
      {
        Score = Minimum;
      }
      else
      {
        Score = added;
      }
    }
  }
}