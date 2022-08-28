using System;
using System.Collections;
class Product
{
    string name;
    double cost;
    int onhand;
    public Product(string n, double c, int h)
    {
        name = n;
        cost = c;
        onhand = h;
    }
    public override string ToString()
    {
        return String.Format("{0,-3}Cost: {1,6:C} On hand: {2}", name, cost, onhand);
    }
}
class Program
{
    public static void Main()
    {
        ArrayList inv = new ArrayList();

        inv.Add(new Product("A", 5.9, 3));
        inv.Add(new Product("B", 8.2, 2));
        inv.Add(new Product("C", 3.5, 4));
        inv.Add(new Product("D", 1.8, 8));
        Console.WriteLine("Product list:");
        foreach (Product i in inv)
        {
            Console.WriteLine(" " + i);
        }
    }
}
