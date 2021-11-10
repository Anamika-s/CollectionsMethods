using System;
class OutputPara
{
  static void Calculate(int num1, int num2,  out int add , out  int subtract, out  int product, out int div)
  {
    add = num1 + num2;
    subtract = num1- num2;
    product = num1 * num2;
    div = num1/num2;
  }
   
  static void Main()
  {
    int add, subtract, product, div;
    Calculate(10,2 , out  add  , out  subtract , out product,
    out div);
    Console.WriteLine("Sum is " + add);
    Console.WriteLine("Difference is " + subtract);
    Console.WriteLine("Product is " + product);
    Console.WriteLine("Quotient is " + div);

  }
}