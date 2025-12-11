using LearningManagementSystem.Data;
using LearningManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace LearningManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext context = new ();
           var Departments =  context.departments.AsNoTracking().AsQueryable();
          var   instrudtorWithDepartement = context.instructors.Include(e=>e.Department).Where(e=>e.Id==1);
            foreach (var e in context.departments)  
            {

                Console.WriteLine($"the departement names are {e.Name}");
            }

           var Department = context.instructors.SingleOrDefault(e=>e.Id==1);
            Console.WriteLine(context.instructors);

            var instructorsWithDepartement = context.instructors.Select(e => new
            {
                e.Name,
                e.Id,
                e.DepartementId,
                DepartementName = e.Department.Name,
                e.Department.Description,

            });

            //  creat / update

            context.Add(new Department
            {
                Name = "Risk departement",
            });
            //partial update
            Department.Name = "Risk departement";

            //remove 
            context.Remove("Risk departement");

        }
    }
}
