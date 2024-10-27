using System;

public class Baby
{
    
    public DateTime bornDate { get;  set; }
    public string Name { get; set; }
    public string SurName { get; set; }

    
    public Baby()
    {
        bornDate = DateTime.Now;
        Console.WriteLine("Ingaaaa");  
    }

   
    public Baby(string name, string surname) : this() 
    {
        Name = name;
        SurName = surname;
    }

    
    public void printInfo()
    {
        Console.WriteLine($"name: {Name}, surName: {SurName}, bornDate: {bornDate}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        
      Baby baby1 = new Baby();
        baby1. Name = "Jack";
        baby1.SurName = "London";
        baby1.printInfo();
        Baby baby2 = new Baby("Sue", "Emir");
        baby2.printInfo();
    }
}