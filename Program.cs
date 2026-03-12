namespace Homework7;

class Program
{
    static void Main(string[] args)
    {
       //Answer Q1 and Q2
       Customer Alice = new Customer(110, "Alice", 28);
       Alice.PrintCusInfo();
       Customer Bob = new Customer(111, "Bob", 30);
       Bob.PrintCusInfo();
       Alice.ChangeID(220);
       Alice.PrintCusInfo();
       Bob.ChangeID(221);
       Bob.PrintCusInfo();
       Alice.CompareAge(Bob);
    }
}
class Customer
    {
        //Code for Customer class
        private int cus_id;
        public string cus_name { get; set; }= string.Empty;
        public int cus_age { get; set; }
        public Customer (int cus_id, string cus_name, int cus_age)
        {
            this.cus_id = cus_id;
            this.cus_name = cus_name;
            this.cus_age = cus_age;
        }
        public void ChangeID(int new_id)
        {
            cus_id = new_id;
        }
        public void PrintCusInfo()
        {
            Console.WriteLine($"Customer: {cus_id}, Name: {cus_name}, Age: {cus_age}");
        }
    
    
    public void CompareAge(Customer other)
    {
        if (this.cus_age > other.cus_age)
        {
            Console.WriteLine($"{this.cus_name} is older than {other.cus_name}.");
        }
        else if(this.cus_age < other.cus_age)
        {
            Console.WriteLine($"{other.cus_name} is older than {this.cus_name}.");
        }
        else
        {
            Console.WriteLine($"{this.cus_name} and {other.cus_name} are of the same age.");
        }
     }
    }