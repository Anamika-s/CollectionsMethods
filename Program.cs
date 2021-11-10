using System;

namespace CollectionsMethods
{
    class Program
    {   static void Square1(int num)
        {
        Console.Write(num * num);
             
        }
        static int Square(int num)
        {
            return num * num;
        }
        static int Cube(int num)
        {
            return num * num * num;
        }
        static void Main(string[] args)
        {   Console.WriteLine("Enter Number");
            Byte num = Byte.Parse(Console.ReadLine());
            int square = Square(num);
            Console.WriteLine("square is "  + square);
            int cube = Cube(num);
            Console.WriteLine("Cube is "  + cube);
            
        }
    }
}
