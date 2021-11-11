using System;
using System.Collections;
class CollectionsDemo
{
  static void Main()
  {
   
        ArrayList list = new ArrayList();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        foreach(int x in list)
            Console.WriteLine(x);
        list.Insert(0, 100);
        list.Remove(3);
        list.RemoveAt(0);
        list.Add("Ajay");
        list.Add(12.8f);
        foreach (var x in list)
            Console.WriteLine(x);
    }
}
    

   
 