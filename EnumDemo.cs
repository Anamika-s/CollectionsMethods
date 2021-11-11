using System;
class EnumDemo
{
  enum Days {  Sunday , Monday, Tuesday, Wednesday, Thursday, Friday, Saturday};
   static void Main()
    {
      Console.WriteLine(Days.Monday);
      Console.WriteLine((int)Days.Friday);
    }
}