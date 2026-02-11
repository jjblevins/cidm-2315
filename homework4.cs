using System.Reflection.Metadata;

namespace Homework4;

class Program
{
    static void Main(string[] args)
    {
        //Call Q1 Method
        Console.WriteLine("Enter two numbers:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int max_num = Q1_Method(num1, num2);
        Console.WriteLine($"a={num1}; b={num2}");
        Console.WriteLine($"The largest number is: {max_num}");


         //Call Q2 Method
         Console.WriteLine("Input an integer:");
         int N = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Choose a shape (left or right):");
         string shape = Console.ReadLine().ToLower();
         Console.WriteLine($"N is {N}; shape is {shape}");
         Q2_Method(N, shape);


        
    }

    //Q1_method
    static int Q1_Method(int num1, int num2)
    {
         int max_num = (num1 > num2) ? num1 : num2;
         return max_num;
    }

    //Q2_method
    static void Q2_Method(int N, string shape)
    {
        if (shape == "left")
        {
            for (int row = 0; row <N; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    if (row >= col)
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
        else if (shape == "right")
        {
            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    if (col < N - row - 1)
                        Console.Write(" ");
                    else
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
        else
        {
            Console.WriteLine("Invalid shape choice. Please choose 'left' or 'right'.");
        }
    }


}
