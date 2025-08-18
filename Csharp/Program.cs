namespace Csharp.ProgramCs
{
  class Program
  {
    string varivavel;
    static void Main(string[] args)
    {
      Program app = new Program();
      app.varivavel = "teste";
      byte marcos = 100;

      Console.Write(app.varivavel);
      app.varivavel = Console.ReadLine();
      Console.Write(app.varivavel);

      int xpto = Convert.ToInt32("30");

      var dataNiver = "02/10/2003";
      DateTime dataConvertida = Convert.ToDateTime(dataNiver);

      double saldo = 3432.32;
      saldo = saldo / 2;
      Console.Write("Saldo atual: " + saldo);

      String[] nomes = new string[2];
      nomes[0] = "Marcos";
      nomes[1] = "Fernanda";

      String[] teste = ["Axel", "Lucas"]; // mesma coisa
      const String souImutavel = "Pai ta on!"; 
    }
  }
}