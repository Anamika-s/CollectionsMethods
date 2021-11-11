         using System;
         
          class CalculationWIthEnum
          {
              enum Options {Addition=1 , Subtraction, Product, Divide};
              static void Main()
              {
            int x, y;
            Console.WriteLine("Enter No1");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter No2");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Choice");
            int ch = byte.Parse(Console.ReadLine());
           switch(ch)
            {
                // case 1:
                case (int)Options.Addition:
                    {
                        Console.WriteLine(x+y);
                        break;
                    }
                // case 2:
                 case (int)Options.Subtraction:
                    {
                        Console.WriteLine(x - y);
                        break;
                    }
                // case 3:
                 case (int)Options.Product:
                    {
                        Console.WriteLine(x * y);
                        break;
                    }
                // case 4:
                 case (int)Options.Divide:
                    {
                        Console.WriteLine(x / y);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Choice");
                        break;
                    }
            }
              }
          }