using System;
using System.Collections;
class Emp
{
    public int id { get;set;}
    public string name { get; set;}
    public int age { get; set;}
    public double salary { get; set;}

    public Emp()
    {

    }
    public Emp(int id, string name, int age, double salary)
    {
        this.id = id;
        this.name = name;
        this.age = age;
        this.salary = salary;
    }
    public override string ToString()
    {
        return String.Format("Id: {0} Name: {1} Age: {2} Salary: {3:C}", id, name, age, salary);
    }
}
class Program
{
    public static ArrayList list = new ArrayList();
   
    public static void menu()
    {
        Console.WriteLine("1. Add employee");
        Console.WriteLine("2. Show all employee");
        Console.WriteLine("3. Update employee");
        Console.WriteLine("4. Delete employee");
        Console.WriteLine("5. Exist");
        
    }
    public static void Main(string[] args)
    {
        menu();
        while (true)
        {
            string choice;
            Console.Write("Your choice: ");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                add();
                menu();
            }
            else if (choice == "2")
            {
                show();
                menu();
            }
            else if(choice == "3")
            {
                update();
                
               menu();
            }
            else if(choice == "4")
            {
                remove();
                menu();
            } 
            else if (choice == "5")
            {
                break;
            }
            else
            {
                Console.WriteLine("Input the correct choice");
            }
        }

    }
    public static void add()
    {
        int id;
        string name;
        int age;
        double salary;
        Console.Write("Input Emp id: ");
        id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input Emp name: ");
        name = Console.ReadLine();
        Console.Write("Input Emp age: ");
        age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input Emp salary: ");
        salary = Convert.ToDouble(Console.ReadLine());
        Emp employee = new Emp(id,name,age,salary);
        list.Add(employee);
    }

    public static void show()
    {
        foreach (Emp emp in list)
        {
            Console.WriteLine(" " + emp);
        }
    }
  
    public static void remove()
    {
        int ids;
        Console.Write("Enter emp id: ");
        ids = Convert.ToInt32(Console.ReadLine());
        try
        {
            foreach (Emp e in list)
            {
                if (e.id == ids)
                {
                    int choice;
                    Console.WriteLine("Are you sure deleting this emp? (1.Yes 2.No)");
                    Console.Write("Your choice");
                    choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 1)
                        list.RemoveAt(ids-1);
                    
                } else if (e.id != ids)
                {
                    Console.WriteLine("Can not find emp with id: " + ids);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public static void update()
    {
        int ids;
        Console.Write("Enter emp id: ");
        ids = Convert.ToInt32(Console.ReadLine());
        foreach (Emp e in list)
        {
            if (e.id == ids)
            {
                int choice;
                Console.WriteLine("Choose what you want to update");
                Console.WriteLine("1. ID");
                Console.WriteLine("2. Name");
                Console.WriteLine("3. Age");
                Console.WriteLine("4. Salary");
                Console.Write("Your Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.Write("Input new id: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    e.id = id;
                    
                } else if (choice == 2)
                {
                    Console.Write("Input new name: ");
                    string name = Console.ReadLine();
                    e.name = name;
                } else if (choice == 3)
                {
                    Console.Write("Input new age: ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    e.age = age;
                    
                } else if (choice == 4)
                {
                    Console.Write("Input new salary: ");
                    double salary = Convert.ToDouble(Console.ReadLine());
                    e.salary = salary;
                }
            }
            else if (e.id != ids)
            {
                Console.WriteLine("Can not find emp with id: " + ids);
            }
        }
        
    }
}