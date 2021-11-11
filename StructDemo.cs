using System;
struct Record
{
     string name;
     int id;
     string batch;
     int marks;
    public void GetDetails()
    {
      Console.WriteLine("Enter ID");
      id= Convert.ToByte(Console.ReadLine());
      Console.WriteLine("Enter Name");
      name =  Console.ReadLine();
      Console.WriteLine("Enter batch");
      batch= Console.ReadLine();
      Console.WriteLine("Enter marks");
      marks= Convert.ToByte(Console.ReadLine());
      
    }
    public void DisplayDetails()
    {
      Console.WriteLine("ID is " + id);
      Console.WriteLine("Name is " + name);
      Console.WriteLine("Batch is  " + batch);
      Console.WriteLine("Marks are " + marks);

    }
}
class StructDemo
{
    
     static void Main()
    {
        Record record = new Record();
        // Console.WriteLine(record.id);
        // Console.WriteLine(record.name);
        record.GetDetails();
        record.DisplayDetails();
    }
}