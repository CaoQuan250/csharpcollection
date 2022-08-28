using System;
using System.Collections;
public class Program
{
    public static void Main()
    {
        SortedList objSl = new SortedList();
        objSl.Add("4", "!");
        objSl.Add("3", "Brilliant");
        objSl.Add("2", "am");
        objSl.Add("1", "I");
        Console.WriteLine("Number of Elements in objSL : {0}", objSl.Count); 
        Console.WriteLine("\t-KEY-\t-VALUE-");
        for (int i = 0; i < objSl.Count; i++) 
        { 
            Console.WriteLine("\t{0}:\t{1}", objSl.GetKey(i), 
                objSl.GetByIndex(i)); 
        }
        Console.ReadLine();
    }
}