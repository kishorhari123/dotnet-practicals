using System;

class Student
{
    
    private string name;
    private int age;
    private string gender;
    private double percentage;
    private string scholarship;
    private string facilities;
    private string branch;

    public Student(string n, int a, string g, double p)
    {
        name = n;
        age = a;
        gender = g;
        percentage = p;

        if (percentage >= 90)
        {
            scholarship = "100% Scholarship";
            facilities = "Bus + Hostel + Food + Books + Laptop";
            branch = "Computer Science";
        }
        else if (percentage >= 80)
        {
            scholarship = "75% Scholarship";
            facilities = "Bus + Hostel + Food";
            branch = "Information Technology";
        }
        else if (percentage >= 70)
        {
            scholarship = "50% Scholarship";
            facilities = "Bus + Food";
            branch = "Electronics";
        }
        else
        {
            scholarship = "25% Scholarship";
            facilities = "Bus Only";
            branch = "Mechanical";
        }
    }

    public void Display()
    {
        Console.WriteLine("\n===== STUDENT ADMISSION DETAILS =====");
        Console.WriteLine("Name : " + name);
        Console.WriteLine("Age : " + age);
        Console.WriteLine("Gender : " + gender);
        Console.WriteLine("Percentage : " + percentage + "%");
        Console.WriteLine("Branch : " + branch);
        Console.WriteLine("Scholarship : " + scholarship);
        Console.WriteLine("Facilities : " + facilities);
    }
}

class Program
{
    static void Main(string[] args)
    {
        double totalMarks, obtainedMarks, percentage;

        Console.Write("Enter Total Marks: ");
        totalMarks = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Obtained Marks: ");
        obtainedMarks = Convert.ToDouble(Console.ReadLine());

        percentage = (obtainedMarks / totalMarks) * 100;

        Console.WriteLine("\nPercentage = " + percentage + "%");

        if (percentage < 60)
        {
            Console.WriteLine("Sorry! You are not eligible for Scholarship.");
            return;
        }

        Console.WriteLine("Congratulations! You are eligible for Scholarship.");

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Gender: ");
        string gender = Console.ReadLine();

        Student s1 = new Student(name, age, gender, percentage);

        s1.Display();
    }
}