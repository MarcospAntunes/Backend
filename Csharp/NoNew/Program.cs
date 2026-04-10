class NoNew
{
  private NoNew() { Console.WriteLine("I'm alive!"); }
  public static NoNew CreateInstance() { return new NoNew(); }
}

class Program {
  static void Main(string[] args)
  {
    NoNew noNew = NoNew.CreateInstance();
  }
}