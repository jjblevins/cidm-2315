namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
        //Code for q1
        Console.WriteLine("Input an integer:");
        int N = Convert.ToInt32(Console.ReadLine());
        if (N <= 1)
        {
            Console.WriteLine("N is not prime");
        }
        else
        {
            bool isPrime = true;
            for (int i = 2; i * i <= N; i++)
            {
                if (N % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            Console.WriteLine(isPrime ? "N is prime" : "N is not prime");
        }






        //Code for q2
        Console.WriteLine("Assign an int value to N:");
        int N1 = Convert.ToInt32(Console.ReadLine());
        for (int row = 0; row<N1; row++)
        {
            for (int col = 0; col<N1; col++)
            {
                Console.Write('#');
            }
            Console.WriteLine("");
        }


        //Code for q3
        Console.WriteLine("Assign an int value to N:");
        int N2 = Convert.ToInt32(Console.ReadLine());
        for (int row = 0; row<N2; row++){
            for (int col = 0; col<N2; col++)
            {
                if(row>=col)
                Console.Write('*');
            }
            Console.WriteLine("");
            
        }
        

        //Code for bonus question
        Console.WriteLine("Assign an int value to N:");
        int N3 = Convert.ToInt32(Console.ReadLine());
        for (int row = 0; row<N3; row++){
            for (int col = 0; col<N3; col++)
            {
                if(row>=col)
                Console.Write(row+1);
            }
            
            Console.WriteLine("");
            
        }

    
    }
}
