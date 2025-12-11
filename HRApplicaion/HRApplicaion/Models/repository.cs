namespace HRApplication.Models
{
    public class Repository
    {
        public static List  <Employee> employeesList =new List <Employee> ();
        public static IEnumerable<Employee> GetEmployees() =>employeesList;

        public static void addEmployee (Employee emp) 
        { 
            
            employeesList.Add (emp);
        }
    }
}
