using System;

// Interface
interface IPayable
{
    double CalculateSalary();
}

// Base Class
class Employee
{
    protected int empId;
    protected string name;

    public Employee(int id, string n)
    {
        empId = id;
        name = n;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Employee ID   : " + empId);
        Console.WriteLine("Employee Name : " + name);
    }
}

// Derived Class - Full Time Employee
class FullTimeEmployee : Employee, IPayable
{
    private double monthlySalary;
    private int absentDays;

    public FullTimeEmployee(int id, string n, double salary, int absent)
        : base(id, n)
    {
        monthlySalary = salary;
        absentDays = absent;
    }

    public double CalculateSalary()
    {
        double deduction = monthlySalary * 0.01 * absentDays; // 1% deduction per absent day
        return monthlySalary - deduction;
    }
}

// Derived Class - Part Time Employee
class PartTimeEmployee : Employee, IPayable
{
    private int hoursWorked;
    private double hourlyRate;

    public PartTimeEmployee(int id, string n, int hours, double rate)
        : base(id, n)
    {
        hoursWorked = hours;
        hourlyRate = rate;
    }

    public double CalculateSalary()
    {
        return hoursWorked * hourlyRate;
    }
}

// Main Class
class Program
{
    static void Main(string[] args)
    {
        // Full Time Employee Input
        Console.WriteLine("----- Full Time Employee -----");
        Console.Write("Enter Employee ID: ");
        int id1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Employee Name: ");
        string name1 = Console.ReadLine();

        Console.Write("Enter Monthly Salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Absent Days: ");
        int absent = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        // Part Time Employee Input
        Console.WriteLine("----- Part Time Employee -----");
        Console.Write("Enter Employee ID: ");
        int id2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Employee Name: ");
        string name2 = Console.ReadLine();

        Console.Write("Enter Hours Worked: ");
        int hours = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Hourly Rate: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine();

        // Polymorphism
        IPayable emp1 = new FullTimeEmployee(id1, name1, salary, absent);
        IPayable emp2 = new PartTimeEmployee(id2, name2, hours, rate);

        Employee e1 = (Employee)emp1;
        Employee e2 = (Employee)emp2;

        Console.WriteLine("========== Payroll Details ==========\n");

        Console.WriteLine("Full Time Employee");
        e1.DisplayDetails();
        Console.WriteLine("Final Salary : " + emp1.CalculateSalary());

        Console.WriteLine("\n----------------------------------\n");

        Console.WriteLine("Part Time Employee");
        e2.DisplayDetails();
        Console.WriteLine("Salary : " + emp2.CalculateSalary());
    }
}