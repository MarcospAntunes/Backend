for(double f = 10; double.IsFinite(f); f *= f)
{
  Console.WriteLine(f);
}

for (float f = 10; float.IsFinite(f); f *= f)
{
  Console.WriteLine(f);
}

int myInt = 10;
byte myByte = (byte)myInt;
double myDouble = (double)myByte;
//bool myBool = (bool)myDouble; Não pode converter double em bool
string myString = "false";
//myBool = (bool)myString; Não pode converter string em bool
//myString = (string)myInt; Não pode converter int em string desta maneira. Utilize myInt.ToString() no lugar
myString = myInt.ToString();
//myBool = (bool)myByte; Não pode converter byte em bool
//myByte = (byte)myBool; // Não pode converter bool em byte
short myShort = (short)myInt;
char myChar = 'x';
//myString = (string)myChar; // Não se pode converter char em String
long myLong = (long)myInt;
decimal myDecimal = (decimal)myLong;
myString = myString + myInt + myByte + myDouble + myChar;