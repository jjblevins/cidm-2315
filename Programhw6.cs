namespace Homework6; 
class Program 
{ 
    static void Main(string[] args)
 { 
    //Answer Q1 and Q2 
    Professor p1 = new Professor(); 
    p1.Name = "Alice"; 
    p1.Teach= "Java"; 
    p1.SetSalary(9000); 
    p1.PrintInfo(); 

    Professor p2 = new Professor(); 
    p2.Name = "Bob"; 
    p2.Teach= "Math"; 
    p2.SetSalary(8000); 
    p2.PrintInfo(); 

    Student s1 = new Student(); 
    s1.Name = "Lisa"; 
    s1.Enroll = "Java"; 
    s1.SetGrade(90); 
    s1.PrintInfo(); 

    Student s2 = new Student(); 
    s2.Name = "Tom"; 
    s2.Enroll = "Math"; 
    s2.SetGrade(80); 
    s2.PrintInfo(); 

    double SalaryDifference = p1.GetSalary() - p2.GetSalary();
    Console.WriteLine($"The salary difference between {p1.Name} and {p2.Name} is: {SalaryDifference}");

    double TotalGrade = s1.GetGrade() + s2.GetGrade();
    Console.WriteLine($"The total grade of {s1.Name} and {s2.Name} is: {TotalGrade}");

        } 
} 
    class Professor 
    { 
        public string Name;
        public string Teach; 
        private double Salary;
        
        public void SetSalary(double salary_amount) 
        { 
            Salary = salary_amount; 
        }
        public double GetSalary() 
        { 
            return Salary; 
        }
        public void PrintInfo()
        
         {
             Console.WriteLine($"Professor {Name} teaches {Teach}, and the salary is: {Salary}"); 
         }
    } 
    class Student 
    { 
        public string Name; 
        public string Enroll;
        private double Grade; 

        public void SetGrade(double grade_amount) 
        { 
            Grade = grade_amount; 
        }   
        public double GetGrade() 
        { 
            return Grade; 
        }
        public void PrintInfo()
            { 
                Console.WriteLine($"Student {Name} enrolls in {Enroll}, and the grade is: {Grade}"); 
            }
     }
     
     