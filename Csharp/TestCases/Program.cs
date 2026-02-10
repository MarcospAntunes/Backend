for(double f = 10; double.IsFinite(f); f *= f)
{
  Console.WriteLine(f);
}

for (float f = 10; float.IsFinite(f); f *= f)
{
  Console.WriteLine(f);
}