namespace Homework9;
using System.Linq;
using Microsoft.VisualBasic;

class Student
{
    private int studentID;
    private string studentName;

    public void PrintInfo()
    {
    }
    

    public Student(int studentID, string studentName)
    {
        this.studentID = studentID;
        this.studentName = studentName;
    }
    public int StudentID
    {
        get { return studentID; }
        set { studentID = value; }
    }
    public string StudentName
    {
        get { return studentName; }
        set { studentName = value; }
    }
    public static List<Student> studentList = new List<Student>();

}

class Program
{static void Main (string[] args)


    {
        

       Student student1 = new Student(111,"Alice");
        Student student2 = new Student(222, "Bob");
        Student student3 = new Student(333, "Charlie");
        Student student4 = new Student(444, "David");

        Student.studentList.Add(student1);
        Student.studentList.Add(student2);
        Student.studentList.Add(student3);
        Student.studentList.Add(student4);

        
        Dictionary<string, double> gradebook = new Dictionary<string, double>();
        gradebook.Add("Alice", 4.0);
        gradebook.Add("Bob", 3.6);
        gradebook.Add("Charlie", 2.5);
        gradebook.Add("David", 1.8);
       

        if (gradebook.ContainsKey("Tom"))
        Console.WriteLine("Tom is in the gradebook");
        else
        Console.WriteLine("Tom is not in the gradebook");

        
        gradebook.Add("Tom", 3.3);

        var averageScore = gradebook.Values.Average();
        var certainScore = gradebook["Tom"];
        Console.WriteLine($"The average GPA is: {averageScore}");

      

       foreach (Student student in Student.studentList)
        
        {
            if (gradebook.ContainsKey(student.StudentName))
            {
                double gpa = gradebook[student.StudentName];

                if (gpa > averageScore)
                {
                 
                Console.WriteLine($"StudentID: {student.StudentID}, Student Name: {student.StudentName}");
            }
            
        }
        }
    }
}

