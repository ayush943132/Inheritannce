using System;

public class Employee{  //Base Class containing an employee details
    public String FirstName;
    public String LastName;
    public int salary;

    public void printname()
    {
        Console.WriteLine(FirstName + " "+LastName);
    }
}
public class fulltimeemployee:Employee //inheriting base class
{
   public float netsal = 500000;
}
public class Intern : Employee
{
   public float hourlysal = 100; // Inheriting
}

public class inheritance
{
    public static void Main()
    {
        fulltimeemployee employee = new fulltimeemployee();
        employee.FirstName = "harry";
        employee.LastName = "moris";
        employee.salary = 7000000;
        employee.printname();

        Intern i=new Intern();
        i.FirstName = "code";
        i.LastName = "buster";
        i.hourlysal = 100;
        i.printname();  

    }
}