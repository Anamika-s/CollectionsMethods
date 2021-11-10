using System;
class CallByValueCallByRef
{
  static void Change1(int x)
  {
    x= 100;
    Console.WriteLine("Value of x in Change1 is " + x);
  }
  static void Change2(ref int x)
  {
    x= 200;
    Console.WriteLine("Value of x in Change2 is " + x);
  }
  static void Main()
  {
    int x = 10;
    Console.WriteLine("Value of x in Main is " + x);
    Change1(x);
    Console.WriteLine("Value of x in Main after calling Change1 is " + x);
    Change2(ref x);
    Console.WriteLine("Value of x in Main after calling Change2 is " + x);

  }
}