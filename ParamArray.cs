using System;
class ParamsArray
{
  // static int Add(int x, int y)
  // {
  //   return x+y;

  // }
  static int Add(params int[] num)
  {
    int sum =0;
    foreach(int temp in num)
    sum+= temp;
    return sum;
  }
  static void Main()
  {
  int res = Add(1,2);
  Console.WriteLine("Sum is " + res);
  res = Add(1,2,1,1,1,1,1,1,3);
  Console.WriteLine("Sum is " + res);
  res = Add(1);
  Console.WriteLine("Sum is " + res);
  
  }
}