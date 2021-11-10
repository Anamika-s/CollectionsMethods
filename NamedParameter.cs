using System;
class NamedParameter
{
  static void Display(int rn , string name, string address,
  int marks)
  {
    Console.WriteLine("RollNo is " + rn);
    Console.WriteLine("Name is " + name);
    Console.WriteLine("Address is " + address);
    Console.WriteLine("Marks are " + marks);
  }
  static void Main()
 {
    // Display("Ajay", 1,"Delhi", 90);
    // To change sequence of parameters, we can use Named Parameter

    Display(name:"Deepak",rn:1, marks:90,address:"Delhi");


 }
}