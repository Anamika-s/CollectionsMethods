using System;
class MethodOverloading
{
  static void Add(int a, int b)
  {
    
    Console.WriteLine("Sum is " + (a+b));
  }
  // static int Add(int a, int b)
  // {
    
  //   Console.WriteLine("Sum is " + (a+b));
  // }
  static void Add(int a, int b, int c)
  {
    
    Console.WriteLine("Sum is " + (a+b +c));
  }
  static void Add(int a, int b, int c, int d)
  {
    
    Console.WriteLine("Sum is " + (a+b +c +d));
  }
  static void Add(float a, float b)
  {
    
    Console.WriteLine("Sum is " + (a+b));
  }
  static void Add(string a, string b)
  {
    
    Console.WriteLine("Value is  " + a +" " + b);
  }

  static void Add(int a, float b)
  {
    
    Console.WriteLine("Sum is  " + a+b);
  }

  static void Main()
  {
    Add(10,20);
    Add(1,2,3);
    Add(12.6f, 12.7f);
    Add("Deepak" , "Kumar");
  }
}