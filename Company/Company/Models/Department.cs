namespace Company.Models
{
    internal class Department
    {
        public int Department_Id { get; set; }                // مفتاح أساسي
        public string Name { get; set; }                      // اسم القسم
        public string? Description { get; set; }              // وصف (nullable)

        public List<Employee> Employees { get; set; } = new(); // One-to-Many
    }
}
