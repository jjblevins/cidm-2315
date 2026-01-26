namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
       // Code for Q1
Console.WriteLine("Please input a letter grade");
string grade = Console.ReadLine().ToUpper();

if (grade == "A")
{
    Console.WriteLine("GPA point: 4");
}
else if (grade == "B")
{
    Console.WriteLine("GPA point: 3");
}
else if (grade == "C")
{
    Console.WriteLine("GPA point: 2");
}
else if (grade == "D")
{
    Console.WriteLine("GPA point: 1");
}
else if (grade == "F")
{
    Console.WriteLine("GPA point: 0");
}
else
{
    Console.WriteLine("Wrong Letter Grade!");
}

//Code for Q2

Console.WriteLine("Please input the first num:");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please input the second num:");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please input the third num:");
int n3 = Convert.ToInt32(Console.ReadLine());

if (n1 < n2)
{
    if (n1 < n3)
    {
        Console.WriteLine($"The smallest value is: {n1}");
    }

    else
    {
        Console.WriteLine($"The smallest value is: {n3}");
    }
}
else
{
    if (n2 < n3)
    {
        Console.WriteLine($"The smallest value is:{n2}");
    }
    else
    {
        Console.WriteLine($"The smallest value is: {n3}");

    }
}

//Code for Bonus question

Console.WriteLine("Please input a year: ");
int year = Convert.ToInt32(Console.ReadLine());
if (year % 400 == 0)
{
    Console.WriteLine($"The year {year} is a leap year");
}
else if (year % 100 == 0)
{
    Console.WriteLine($"The year {year} is not a leap year");
}
else if (year % 4 == 0)
{
    Console.WriteLine($"The year {year} is a leap year");
}
else
{
    Console.WriteLine($"The year {year} is not a leap year");
}
           




    }
}
