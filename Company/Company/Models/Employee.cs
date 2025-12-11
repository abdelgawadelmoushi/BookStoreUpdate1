namespace Company.Models
{
    internal class Employee
    {
        public int Employee_Id { get; set; }       // مفتاح أساسي
        public string Name { get; set; }           // اسم الموظف
        public decimal Salary { get; set; }        // الراتب

        public int Department_Id { get; set; }     // المفتاح الأجنبي (FK)
        public Department Department { get; set; } // العلاقة مع Department
    }
}
