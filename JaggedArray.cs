using System;
class JaggedArray
{
  static void Main()
  {
    int[][] students = new  int[20][];
    Console.WriteLine("How many students");
    int count = Convert.ToByte(Console.ReadLine());
    for(int j=0;j<count;j++)
    {
    Console.WriteLine("ENter Marks for Student No {0}", j+1);
    students[j] = new int[3];
    for(int i=0;i<3;i++)
    students[0][i] = Byte.Parse(Console.ReadLine());
    Console.WriteLine("ENter Marks for 2nd Student");
    students[1] = new int[2];
    for(int i=0;i<2;i++)
    students[1][i] = Byte.Parse(Console.ReadLine());
    }


  }
}