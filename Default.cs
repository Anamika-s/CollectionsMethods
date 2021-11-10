using System;
class DefaultDemo
{
  static void SI(int principal=12000, int rate =4 , int time=3)
  {
      float SI = (float)( principal*rate * time)/100;
    Console.WriteLine("SI is " +  SI);
  }
  static void Main()
  {
    SI(12000,2,2);
    SI(12000,2);
    SI(12000);
    SI();

  }
}