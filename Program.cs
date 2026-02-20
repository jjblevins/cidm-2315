namespace Homework5;

class Program
{
    static void Main(string[] args)
    {
        // Call Q1_method()
        Console.WriteLine("Enter two numbers:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int max_num = Q1_Method(num1, num2);
        Console.WriteLine($"a={num1}; b={num2}");
        Console.WriteLine($"The largest number is: {max_num}");

        //Call Q_2method()
        Console.WriteLine("Enter four numbers:");
        int n1 = Convert.ToInt32(Console.ReadLine());
        int n2 = Convert.ToInt32(Console.ReadLine());
        int n3 = Convert.ToInt32(Console.ReadLine());
        int n4 = Convert.ToInt32(Console.ReadLine());
        int max_num3 = Q2_Method(n1, n2, n3, n4);
        Console.WriteLine($"The largest number is: {max_num3}");

        // Call Q_3method()
        
        Console.WriteLine("Enter Your Username:");
        string username = Console.ReadLine();
        Console.WriteLine("Enter Your Password:");
        string password = Console.ReadLine();
        Console.WriteLine("Enter Your Password Again:");
        string re_password = Console.ReadLine();
        Console.WriteLine("Enter Your Birth Year:");
        int birth_year = Convert.ToInt32(Console.ReadLine());
        Q3_Method(username, password, re_password, birth_year);
       

        
    }

    //Q1_method
    static int Q1_Method(int num1, int num2)
    {
         int max_num = (num1 > num2) ? num1 : num2;
         return max_num;
    }
    //Q2_method
    static int Q2_Method(int n1, int n2, int n3, int n4)
    {
        int max_num1 = Q1_Method(n1, n2);
        int max_num2 = Q1_Method(n3, n4);
        int max_num3 = Q1_Method(max_num1, max_num2);
        return max_num3;
    }
    
    //Q3_method
    static void Q3_Method(string username, string password, string re_password, int birth_year)
    {
        
        int current_year = 2026;
        int age = current_year - birth_year;

        if (age < 18)
        {
            Console.WriteLine("Could not create an account.");
            return;
        }
        if (password != re_password)
        {
            Console.WriteLine("Wrong Password");
            return;
        }


        Console.WriteLine("Account created successfully.");
    }
}
