namespace EFproj
{
    class Employee
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public override string ToString()
        {
            return $"{Id} and {Name} and {Salary}";
        }
    }

    
    internal class Program
    {
        static void Main(string[] args)
        {
           Employee employee = new Employee () ;

            Console.WriteLine();
            
        }
    }
}
